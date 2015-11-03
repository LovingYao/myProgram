using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace SapBatchTool
{
    public static class SqlHelper
    {
        /// <summary>
        /// 从config.xml 获取集中数据库连接字符串
        /// </summary>
        private static string _ConnectString;

        /// <summary>
        /// 从config.xml 获取集中数据库连接字符串
        /// </summary>
        public static string ConnectString
        {
            get
            {
                if (string.IsNullOrEmpty(_ConnectString))
                    _ConnectString = ConfigurationManager.AppSettings["DbConn"].Trim();
                return _ConnectString;
            }
        }

        #region 私有方法

        /// <summary>
        /// 将参数数组附加到SqlCommand上
        /// 
        /// 如果参数是InputOutput的并且value为null的，就自动设置value为DBNull
        /// </summary>
        /// <param name="command">要被附加参数的命令</param>
        /// <param name="commandParameters">参数数组</param>
        private static void AttachParameters(SqlCommand command, IEnumerable<SqlParameter> commandParameters)
        {
            if (command == null)
                throw new ArgumentNullException("command");

            if (commandParameters == null)
                return;

            foreach (var param in commandParameters)
            {
                if (param == null)
                    continue;

                // 检查参数输入输出方向并为空值设置DBNull
                if ((param.Direction == ParameterDirection.InputOutput ||
                     param.Direction == ParameterDirection.Input) &&
                    (param.Value == null))
                {
                    param.Value = DBNull.Value;
                }
                command.Parameters.Add(param);
            }
        }

        /// <summary>
        /// 给命令附加连接，事务，参数等
        /// </summary>
        /// <param name="command">命令</param>
        /// <param name="connection">执行命令使用的连接</param>
        /// <param name="transaction">执行命令的事务，可以为null</param>
        /// <param name="commandType">命令的类型（存储过程或SQL）</param>
        /// <param name="commandText">命令的内容</param>
        /// <param name="commandParameters">参数数组，可以为null</param>
        /// <param name="mustCloseConnection">当连接时有本方法打开时为<c>true</c>，否则为false</param>
        private static void PrepareCommand(SqlCommand command, SqlConnection connection, SqlTransaction transaction,
            CommandType commandType, string commandText, IEnumerable<SqlParameter> commandParameters,
            out bool mustCloseConnection)
        {
            if (command == null)
                throw new ArgumentNullException("command");

            if (string.IsNullOrEmpty(commandText))
                throw new ArgumentNullException("commandText");

            // 如果提供的连接没有打开，则打开它
            if (connection.State != ConnectionState.Open)
            {
                mustCloseConnection = true;
                connection.Open();
            }
            else
            {
                mustCloseConnection = false;
            }
            // 将连接附加到命令上
            command.Connection = connection;
            // 设置命令的内容
            command.CommandText = commandText;
            // 如果需要是用事务，给命令设置事务
            if (transaction != null)
            {
                if (transaction.Connection == null)
                    throw new ArgumentException("事务被回滚或关闭，请提供一个有效的事务", "transaction");
                command.Transaction = transaction;
            }
            // 设置命令类型
            command.CommandType = commandType;
            // 设置命令参数
            if (commandParameters != null)
            {
                AttachParameters(command, commandParameters);
            }
            return;
        }

        #endregion

        #region ExecuteNonQuery

        /// <summary>
        /// 执行数据库操作命令（无参数无返回值）
        /// </summary>
        /// <remarks>
        /// 示例：
        ///  int result = ExecuteNonQuery(connString, CommandType.StoredProcedure, "PublishOrders");
        /// </remarks>
        /// <param name="connectionString">有效的数据库连接字符串</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="commandText">命令内容</param>
        /// <returns>命令影响的行数</returns>
        public static int ExecuteNonQuery(string connectionString, CommandType commandType, string commandText)
        {
            return ExecuteNonQuery(connectionString, commandType, commandText, null);
        }

        /// <summary>
        /// 执行数据库操作命令（无返回值）
        /// </summary>
        /// <remarks>
        /// 示例：
        ///  int result = ExecuteNonQuery(connString, CommandType.StoredProcedure, "PublishOrders", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="connectionString">有效的数据库连接字符串</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="commandText">命令内容</param>
        /// <param name="commandParameters">命令的参数</param>
        /// <returns>命令影响的行数</returns>
        public static int ExecuteNonQuery(string connectionString, CommandType commandType, string commandText,
            params SqlParameter[] commandParameters)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException("connectionString");

            // 创建并打开一个连接，使用完后自动关闭
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                return ExecuteNonQuery(connection, commandType, commandText, commandParameters);
            }
        }

        /// <summary>
        /// 执行数据库操作命令（无参数无返回值）
        /// </summary>
        /// <remarks>
        /// 示例：
        ///  int result = ExecuteNonQuery(conn, CommandType.StoredProcedure, "PublishOrders");
        /// </remarks>
        /// <param name="connection">有效的数据库连接</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="commandText">命令内容</param>
        /// <returns>命令影响的行数</returns>
        public static int ExecuteNonQuery(SqlConnection connection, CommandType commandType, string commandText)
        {
            return ExecuteNonQuery(connection, commandType, commandText, null);
        }

        /// <summary>
        /// 执行数据库操作命令（无返回值）
        /// </summary>
        /// <remarks>
        /// 示例：
        ///  int result = ExecuteNonQuery(conn, CommandType.StoredProcedure, "PublishOrders", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="connection">有效的数据库连接</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="commandText">命令内容</param>
        /// <param name="commandParameters">命令的参数</param>
        /// <returns>命令影响的行数</returns>
        public static int ExecuteNonQuery(SqlConnection connection, CommandType commandType, string commandText,
            params SqlParameter[] commandParameters)
        {
            return ExecuteNonQuery(connection, null, commandType, commandText, commandParameters);
        }

        /// <summary>
        /// 执行数据库操作命令（无返回值）
        /// </summary>
        /// <remarks>
        /// 示例：
        ///  int result = ExecuteNonQuery(conn, trans, CommandType.StoredProcedure, "PublishOrders", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="connection">有效的数据库连接</param>
        /// <param name="transaction">有效的数据库事务</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="commandText">命令内容</param>
        /// <param name="commandParameters">命令的参数</param>
        /// <returns>命令影响的行数</returns>
        public static int ExecuteNonQuery(SqlConnection connection, SqlTransaction transaction, CommandType commandType,
            string commandText, params SqlParameter[] commandParameters)
        {
            if (connection == null) throw new ArgumentNullException("connection");

            // 创建一个命令并配置好
            var cmd = new SqlCommand();
            bool mustCloseConnection;
            PrepareCommand(cmd, connection, transaction, commandType, commandText, commandParameters, out mustCloseConnection);

            // 执行命令
            var retval = cmd.ExecuteNonQuery();

            // 释放
            cmd.Parameters.Clear();
            if (mustCloseConnection)
                connection.Close();
            return retval;
        }

        /// <summary>
        /// 执行数据库操作命令（无参数无返回值）带事务
        /// </summary>
        /// <remarks>
        /// 示例：
        ///  int result = ExecuteNonQuery(trans, CommandType.StoredProcedure, "PublishOrders");
        /// </remarks>
        /// <param name="transaction">有效的数据库事务</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="commandText">命令内容</param>
        /// <returns>命令影响的行数</returns>
        public static int ExecuteNonQuery(SqlTransaction transaction, CommandType commandType, string commandText)
        {
            return ExecuteNonQuery(transaction, commandType, commandText, null);
        }

        /// <summary>
        /// 执行数据库操作命令（无返回值）带事务
        /// </summary>
        /// <remarks>
        /// 示例：
        ///  int result = ExecuteNonQuery(trans, CommandType.StoredProcedure, "GetOrders", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="transaction">有效的数据库事务</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="commandText">命令内容</param>
        /// <param name="commandParameters">命令参数</param>
        /// <returns>命令影响的行数</returns>
        public static int ExecuteNonQuery(SqlTransaction transaction, CommandType commandType, string commandText,
            params SqlParameter[] commandParameters)
        {
            if (transaction == null) throw new ArgumentNullException("transaction");
            if (transaction != null && transaction.Connection == null)
                throw new ArgumentException("事务被回滚或关闭，请提供一个有效的事务", "transaction");

            // 创建一个命令并配置好
            var cmd = new SqlCommand();
            bool mustCloseConnection;
            PrepareCommand(cmd, transaction.Connection, transaction, commandType, commandText, commandParameters, out mustCloseConnection);

            // 执行命令
            var retval = cmd.ExecuteNonQuery();

            // 释放
            cmd.Parameters.Clear();
            return retval;
        }

        #endregion ExecuteNonQuery

        #region ExecuteDataset

        /// <summary>
        /// 执行数据库操作命令（无参数返回结果集）
        /// </summary>
        /// <remarks>
        /// 示例：
        ///  DataSet ds = ExecuteDataset(connString, CommandType.StoredProcedure, "GetOrders");
        /// </remarks>
        /// <param name="connectionString">有效的数据库连接字符串</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="commandText">命令内容</param>
        /// <returns>结果集</returns>
        public static DataSet ExecuteDataset(string connectionString, CommandType commandType, string commandText)
        {
            return ExecuteDataset(connectionString, commandType, commandText, null);
        }

        /// <summary>
        /// 执行数据库操作命令（返回结果集）
        /// </summary>
        /// <remarks>
        /// 示例：
        ///  DataSet ds = ExecuteDataset(connString, CommandType.StoredProcedure, "GetOrders", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="connectionString">有效的数据库连接字符串</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="commandText">命令内容</param>
        /// <param name="commandParameters">命令参数</param>
        /// <returns>结果集</returns>
        public static DataSet ExecuteDataset(string connectionString, CommandType commandType, string commandText,
            params SqlParameter[] commandParameters)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException("connectionString");

            // 创建并打开一个连接，使用完后自动关闭
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                return ExecuteDataset(connection, commandType, commandText, commandParameters);
            }
        }

        /// <summary>
        /// 执行数据库操作命令（无参数返回结果集）
        /// </summary>
        /// <remarks>
        /// 示例：
        ///  DataSet ds = ExecuteDataset(conn, CommandType.StoredProcedure, "GetOrders");
        /// </remarks>
        /// <param name="connection">有效的数据库连接</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="commandText">命令内容</param>
        /// <returns>结果集</returns>
        public static DataSet ExecuteDataset(SqlConnection connection, CommandType commandType, string commandText)
        {
            return ExecuteDataset(connection, commandType, commandText, null);
        }

        /// <summary>
        /// 执行数据库操作命令（返回结果集）
        /// </summary>
        /// <remarks>
        /// 示例：
        ///  DataSet ds = ExecuteDataset(conn, CommandType.StoredProcedure, "GetOrders", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="connection">有效的数据库连接</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="commandText">命令内容</param>
        /// <param name="commandParameters">命令参数</param>
        /// <returns>结果集</returns>
        public static DataSet ExecuteDataset(SqlConnection connection, CommandType commandType, string commandText,
            params SqlParameter[] commandParameters)
        {
            return ExecuteDataset(connection, null, commandType, commandText, commandParameters);
        }

        /// <summary>
        /// 执行数据库操作命令（返回结果集）
        /// </summary>
        /// <remarks>
        /// 示例：
        ///  DataSet ds = ExecuteDataset(conn, trans, CommandType.StoredProcedure, "GetOrders", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="connection">有效的数据库连接</param>
        /// <param name="transaction">有效的数据库事务</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="commandText">命令内容</param>
        /// <param name="commandParameters">命令参数</param>
        /// <returns>结果集</returns>
        public static DataSet ExecuteDataset(SqlConnection connection, SqlTransaction transaction, CommandType commandType,
            string commandText, params SqlParameter[] commandParameters)
        {
            if (connection == null)
                throw new ArgumentNullException("connection");

            // 创建一个命令并准备好
            var cmd = new SqlCommand();
            bool mustCloseConnection;
            PrepareCommand(cmd, connection, transaction, commandType, commandText, commandParameters, out mustCloseConnection);

            // 创建DataAdapter和DataSet
            using (var da = new SqlDataAdapter(cmd))
            {
                var ds = new DataSet();
                da.Fill(ds);
                cmd.Parameters.Clear();

                if (mustCloseConnection)
                    connection.Close();

                return ds;
            }
        }

        /// <summary>
        /// 执行数据库操作命令（返回结果集）
        /// </summary>
        /// <remarks>
        /// 示例：
        ///  DataSet ds = ExecuteDataset(trans, CommandType.StoredProcedure, "GetOrders");
        /// </remarks>
        /// <param name="transaction">有效的数据库事务</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="commandText">命令内容</param>
        /// <returns>结果集</returns>
        public static DataSet ExecuteDataset(SqlTransaction transaction, CommandType commandType, string commandText)
        {
            return ExecuteDataset(transaction, commandType, commandText, null);
        }

        /// <summary>
        /// 执行数据库操作命令（返回结果集）
        /// </summary>
        /// <remarks>
        /// 示例：
        ///  DataSet ds = ExecuteDataset(trans, CommandType.StoredProcedure, "GetOrders", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="transaction">有效的数据库事务</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="commandText">命令内容</param>
        /// <param name="commandParameters">命令参数</param>
        /// <returns>结果集</returns>
        public static DataSet ExecuteDataset(SqlTransaction transaction, CommandType commandType, string commandText,
            params SqlParameter[] commandParameters)
        {
            if (transaction == null)
                throw new ArgumentNullException("transaction");

            if (transaction != null && transaction.Connection == null)
                throw new ArgumentException("事务被回滚或关闭，请提供一个有效的事务", "transaction");

            // 创建命令
            var cmd = new SqlCommand();
            bool mustCloseConnection;
            PrepareCommand(cmd, transaction.Connection, transaction, commandType, commandText, commandParameters, out mustCloseConnection);

            using (var da = new SqlDataAdapter(cmd))
            {
                var ds = new DataSet();
                da.Fill(ds);
                cmd.Parameters.Clear();

                return ds;
            }
        }

        #endregion ExecuteDataset

        #region ExecuteReader

        /// <summary>
        /// 用来说明连接是由调用者创建还是有SqlHelper创建，从而在调用ExecuteReader()的时候确定适当的CommandBehavior
        /// </summary>
        private enum SqlConnectionOwnership
        {
            /// <summary>
            /// 连接属于SqlHelper
            /// </summary>
            Internal,
            /// <summary>
            /// 连接属于调用者
            /// </summary>
            External
        }

        /// <summary>
        /// 执行数据库操作命令（返回Reader）
        /// </summary>
        /// <param name="connection">数据库连接</param>
        /// <param name="transaction">数据库事务</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="commandText">命令内容</param>
        /// <param name="commandParameters">命令内容</param>
        /// <param name="connectionOwnership">连接属性</param>
        /// <returns>执行结果</returns>
        private static SqlDataReader ExecuteReader(SqlConnection connection, SqlTransaction transaction,
            CommandType commandType, string commandText, IEnumerable<SqlParameter> commandParameters,
            SqlConnectionOwnership connectionOwnership)
        {
            if (connection == null) throw new ArgumentNullException("connection");

            var mustCloseConnection = false;
            var cmd = new SqlCommand();
            try
            {
                PrepareCommand(cmd, connection, transaction, commandType, commandText, commandParameters, out mustCloseConnection);
                var dataReader = connectionOwnership ==
                                   SqlConnectionOwnership.External ? cmd.ExecuteReader() :
                                                                     cmd.ExecuteReader(CommandBehavior.CloseConnection);
                var canClear = true;
                foreach (SqlParameter commandParameter in cmd.Parameters)
                {
                    if (commandParameter.Direction != ParameterDirection.Input)
                        canClear = false;
                }
                if (canClear)
                {
                    cmd.Parameters.Clear();
                }
                return dataReader;
            }
            catch
            {
                if (mustCloseConnection)
                    connection.Close();
                throw;
            }
        }

        /// <summary>
        /// 执行数据库操作命令（返回Reader） 
        /// </summary>
        /// <remarks>
        /// 示例：
        ///  SqlDataReader dr = ExecuteReader(connString, CommandType.StoredProcedure, "GetOrders");
        /// </remarks>
        /// <param name="connectionString">数据库连接字符串</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="commandText">命令内容</param>
        /// <returns>返回SqlDataReader</returns>
        public static SqlDataReader ExecuteReader(string connectionString, CommandType commandType, string commandText)
        {
            return ExecuteReader(connectionString, commandType, commandText, null);
        }

        /// <summary>
        /// 执行数据库操作命令（返回Reader） 
        /// </summary>
        /// <remarks>
        /// 示例：
        ///  SqlDataReader dr = ExecuteReader(connString, CommandType.StoredProcedure, "GetOrders", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="connectionString">连接字符串</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="commandText">命令内容</param>
        /// <param name="commandParameters">命令参数</param>
        /// <returns>返回SqlDataReader</returns>
        public static SqlDataReader ExecuteReader(string connectionString, CommandType commandType, string commandText,
            params SqlParameter[] commandParameters)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException("connectionString");

            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                return ExecuteReader(connection, null, commandType, commandText, commandParameters,
                    SqlConnectionOwnership.Internal);
            }
            catch
            {
                if (connection != null) connection.Close();
                throw;
            }
        }

        /// <summary>
        /// 执行数据库操作命令（返回Reader）
        /// </summary>
        /// <remarks>
        /// 示例：
        ///  SqlDataReader dr = ExecuteReader(conn, CommandType.StoredProcedure, "GetOrders");
        /// </remarks>
        /// <param name="connection">数据库连接</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="commandText">命令参数</param>
        /// <returns>返回SqlDataReader</returns>
        public static SqlDataReader ExecuteReader(SqlConnection connection, CommandType commandType, string commandText)
        {
            return ExecuteReader(connection, commandType, commandText, null);
        }

        /// <summary>
        /// 执行数据库操作命令（返回Reader）
        /// </summary>
        /// <remarks>
        /// 示例：
        ///  SqlDataReader dr = ExecuteReader(conn, CommandType.StoredProcedure, "GetOrders", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="connection">数据库连接</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="commandText">命令参数</param>
        /// <param name="commandParameters">命令参数</param>
        /// <returns>返回SqlDataReader</returns>
        public static SqlDataReader ExecuteReader(SqlConnection connection, CommandType commandType, string commandText,
            params SqlParameter[] commandParameters)
        {
            return ExecuteReader(connection, null, commandType, commandText, commandParameters,
                SqlConnectionOwnership.External);
        }

        /// <summary>
        /// 执行数据库操作命令（返回Reader）
        /// </summary>
        /// <remarks>
        /// 示例：
        ///  SqlDataReader dr = ExecuteReader(trans, CommandType.StoredProcedure, "GetOrders");
        /// </remarks>
        /// <param name="transaction">数据库事务</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="commandText">命令参数</param>
        /// <returns>返回SqlDataReader</returns>
        public static SqlDataReader ExecuteReader(SqlTransaction transaction, CommandType commandType, string commandText)
        {
            return ExecuteReader(transaction, commandType, commandText, null);
        }

        /// <summary>
        /// 执行数据库操作命令（返回Reader）
        /// </summary>
        /// <remarks>
        /// 示例：
        ///   SqlDataReader dr = ExecuteReader(trans, CommandType.StoredProcedure, "GetOrders", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="transaction">数据库事务</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="commandText">命令参数</param>
        /// <param name="commandParameters">命令参数</param>
        /// <returns>返回SqlDataReader</returns>
        public static SqlDataReader ExecuteReader(SqlTransaction transaction, CommandType commandType, string commandText,
            params SqlParameter[] commandParameters)
        {
            if (transaction == null)
                throw new ArgumentNullException("transaction");

            if (transaction != null && transaction.Connection == null)
                throw new ArgumentException("事务被回滚或关闭，请提供一个有效的事务", "transaction");

            return ExecuteReader(transaction.Connection, transaction, commandType, commandText, commandParameters,
                SqlConnectionOwnership.External);
        }

        #endregion ExecuteReader

        #region ExecuteScalar

        /// <summary>
        /// 执行数据库操作命令（返回1*1结果集）
        /// </summary>
        /// <remarks>
        /// 示例：
        ///  int orderCount = (int)ExecuteScalar(connString, CommandType.StoredProcedure, "GetOrderCount");
        /// </remarks>
        /// <param name="connectionString">数据库连接字符串</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="commandText">命令内容</param>
        /// <returns>返回1*1结果集</returns>
        public static object ExecuteScalar(string connectionString, CommandType commandType, string commandText)
        {
            return ExecuteScalar(connectionString, commandType, commandText, null);
        }

        /// <summary>
        /// 执行数据库操作命令（返回1*1结果集）
        /// </summary>
        /// <remarks>
        /// 示例：
        ///  int orderCount = (int)ExecuteScalar(connString, CommandType.StoredProcedure, "GetOrderCount", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="connectionString">数据库连接字符串</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="commandText">命令内容</param>
        /// <param name="commandParameters">命令参数</param>
        /// <returns>返回1*1结果集</returns>
        public static object ExecuteScalar(string connectionString, CommandType commandType, string commandText,
            params SqlParameter[] commandParameters)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException("connectionString");

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                return ExecuteScalar(connection, commandType, commandText, commandParameters);
            }
        }

        /// <summary>
        /// 执行数据库操作命令（返回1*1结果集）
        /// </summary>
        /// <remarks>
        /// 示例：
        ///  int orderCount = (int)ExecuteScalar(conn, CommandType.StoredProcedure, "GetOrderCount");
        /// </remarks>
        /// <param name="connection">数据库连接</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="commandText">命令内容</param>
        /// <returns>返回1*1结果集</returns>
        public static object ExecuteScalar(SqlConnection connection, CommandType commandType, string commandText)
        {
            return ExecuteScalar(connection, commandType, commandText, null);
        }

        /// <summary>
        /// 执行数据库操作命令（返回1*1结果集）
        /// </summary>
        /// <remarks>
        /// 示例：
        ///  int orderCount = (int)ExecuteScalar(conn, CommandType.StoredProcedure, "GetOrderCount", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="connection">数据库连接</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="commandText">命令内容</param>
        /// <param name="commandParameters">命令参数</param>
        /// <returns>返回1*1结果集</returns>
        public static object ExecuteScalar(SqlConnection connection, CommandType commandType, string commandText,
            params SqlParameter[] commandParameters)
        {
            return ExecuteScalar(connection, null, commandType, commandText, commandParameters);
        }

        /// <summary>
        /// 执行数据库操作命令（返回1*1结果集）
        /// </summary>
        /// <remarks>
        /// 示例：
        ///  int orderCount = (int)ExecuteScalar(conn, CommandType.StoredProcedure, "GetOrderCount", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="connection">数据库连接</param>
        /// <param name="transaction">数据库事务</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="commandText">命令内容</param>
        /// <param name="commandParameters">命令参数</param>
        /// <returns>返回1*1结果集</returns>
        public static object ExecuteScalar(SqlConnection connection, SqlTransaction transaction, CommandType commandType,
            string commandText, params SqlParameter[] commandParameters)
        {
            if (connection == null) throw new ArgumentNullException("connection");

            var cmd = new SqlCommand();
            bool mustCloseConnection;
            PrepareCommand(cmd, connection, transaction, commandType, commandText, commandParameters,
                out mustCloseConnection);
            var retval = cmd.ExecuteScalar();
            cmd.Parameters.Clear();

            if (mustCloseConnection)
                connection.Close();
            return retval;
        }

        /// <summary>
        /// 执行数据库操作命令（返回1*1结果集）
        /// </summary>
        /// <remarks>
        /// 示例：
        ///  int orderCount = (int)ExecuteScalar(trans, CommandType.StoredProcedure, "GetOrderCount");
        /// </remarks>
        /// <param name="transaction">数据库事务</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="commandText">命令内容</param>
        /// <returns>返回1*1结果集</returns>
        public static object ExecuteScalar(SqlTransaction transaction, CommandType commandType, string commandText)
        {
            return ExecuteScalar(transaction, commandType, commandText, null);
        }

        /// <summary>
        /// 执行数据库操作命令（返回1*1结果集）
        /// </summary>
        /// <remarks>
        /// 示例：
        ///  int orderCount = (int)ExecuteScalar(trans, CommandType.StoredProcedure, "GetOrderCount", new SqlParameter("@prodid", 24));
        /// </remarks>
        /// <param name="transaction">数据库事务</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="commandText">命令内容</param>
        /// <param name="commandParameters">命令参数</param>
        /// <returns>返回1*1结果集</returns>
        public static object ExecuteScalar(SqlTransaction transaction, CommandType commandType, string commandText,
            params SqlParameter[] commandParameters)
        {
            if (transaction == null)
                throw new ArgumentNullException("transaction");

            if (transaction != null && transaction.Connection == null)
                throw new ArgumentException("事务被回滚或关闭，请提供一个有效的事务", "transaction");

            var cmd = new SqlCommand();
            bool mustCloseConnection;
            PrepareCommand(cmd, transaction.Connection, transaction, commandType, commandText, commandParameters,
                out mustCloseConnection);
            var retval = cmd.ExecuteScalar();
            cmd.Parameters.Clear();
            return retval;
        }
        #endregion
    }

 
       
}
