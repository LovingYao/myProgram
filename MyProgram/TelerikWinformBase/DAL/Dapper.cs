using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace TelerikWinformBase
{
    internal class Dapper
    {
        internal static bool Save<T>(T t, string sql)
        {
            int result;

            using (var conn = new SqlConnection(Conn.getConn()))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (var trans = conn.BeginTransaction())
                {
                    result = conn.Execute(sql, t, trans, 30, CommandType.Text);
                    if (result <= 0)
                        trans.Rollback();
                    else
                        trans.Commit();
                }

                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }

            return result > 0;
        }
        internal static bool Save<T>(T t, string sql, string connstring)
        {
            int result;

            using (var conn = new SqlConnection(connstring))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (var trans = conn.BeginTransaction())
                {
                    result = conn.Execute(sql, t, trans, 30, CommandType.Text);
                    if (result <= 0)
                        trans.Rollback();
                    else
                        trans.Commit();
                }

                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }

            return result > 0;
        }

        internal static bool Save<T>(List<T> list, string sql)
        {
            var result = -1;

            using (var conn = new SqlConnection(Conn.getConn()))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (var trans = conn.BeginTransaction())
                {
                    foreach (var item in list)
                    {
                        result = conn.Execute(sql, item, trans, 30, CommandType.Text);
                        if (result <= 0)
                            trans.Rollback();
                    }

                    trans.Commit();
                }

                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }

            return result > 0;
        }
        internal static bool Save<T>(List<T> list, string sql, string connstring)
        {
            var result = -1;

            using (var conn = new SqlConnection(connstring))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (var trans = conn.BeginTransaction())
                {
                    foreach (var item in list)
                    {
                        result = conn.Execute(sql, item, trans, 30, CommandType.Text);
                        if (result <= 0)
                            trans.Rollback();
                    }

                    trans.Commit();
                }

                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }

            return result > 0;
        }

        internal static bool Save<T>(T t, string sql, SqlConnection conn, SqlTransaction trans)
        {
            var result = conn.Execute(sql, t, trans, 30, CommandType.Text);

            return result > 0;
        }

        internal static T QuerySingle<T>(string sql, object param)
        {
            T t;

            using (var conn = new SqlConnection(Conn.getConn()))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                t = conn.Query<T>(sql, param).SingleOrDefault();

                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }

            return t;
        }
        internal static T QuerySingle<T>(string sql, object param, string connstring)
        {
            T t;

            using (var conn = new SqlConnection(connstring))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                t = conn.Query<T>(sql, param).SingleOrDefault();

                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }

            return t;
        }

        internal static List<T> Query<T>(string sql, object param)
        {
            List<T> list;

            using (var conn = new SqlConnection(Conn.getConn()))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                list = conn.Query<T>(sql, param).ToList();

                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }

            return list;
        }
        internal static List<T> Query<T>(string sql, object param, string connstring)
        {
            List<T> list;

            using (var conn = new SqlConnection(connstring))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                list = conn.Query<T>(sql, param).ToList();

                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }

            return list;
        }
    }
}
