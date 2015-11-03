using org.in2bits.MyXls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QueryStepInfor
{
    public class DataToExcel
    {
        public static void ToExcel(List<DataModel> dm,out string Msg)
        {
            Msg = "导入成功";
            if(dm.Count<=0)
            {
                Msg="没有相应的数据";
                return;
            }

            //行数不可以大于65536    
            if (dm.Count > 65536)
            {
                Msg="数据量太大，请减少时间区间进行查询";
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save Excel File";
            sfd.Filter = "Excel File(*.xls)|*.xls";
            //sfd.FilterIndex = 1;
            sfd.OverwritePrompt = true;
            sfd.DefaultExt = "xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string FileName = sfd.FileName;
                XlsDocument xls = new XlsDocument();//创建空xls文档
                xls.FileName = FileName;
                Worksheet sheet = xls.Workbook.Worksheets.AddNamed("Report"); //创建一个工作页为Report

                ////设定列宽度--Carton Number、Class、Module Number
                //ColumnInfo colInfo0 = new ColumnInfo(xls, sheet);
                //colInfo0.ColumnIndexStart = 0;
                //colInfo0.ColumnIndexEnd = 0;
                //colInfo0.Width = 20 * 256;
                //sheet.AddColumnInfo(colInfo0);

                //ColumnInfo colInfo1 = new ColumnInfo(xls, sheet);
                //colInfo1.ColumnIndexStart = 1;
                //colInfo1.ColumnIndexEnd = 1;
                //colInfo1.Width = 15 * 256;
                //sheet.AddColumnInfo(colInfo1);

                //ColumnInfo colInfo2 = new ColumnInfo(xls, sheet);
                //colInfo2.ColumnIndexStart = 2;
                //colInfo2.ColumnIndexEnd = 2;
                //colInfo2.Width = 18 * 256;
                //sheet.AddColumnInfo(colInfo2);

                //ColumnInfo colInfo3 = new ColumnInfo(xls, sheet);
                //colInfo3.ColumnIndexStart = 3;
                //colInfo3.ColumnIndexEnd = 3;
                //colInfo3.Width = 10 * 256;
                //sheet.AddColumnInfo(colInfo3);

                //ColumnInfo colInfo8 = new ColumnInfo(xls, sheet);
                //colInfo8.ColumnIndexStart = 8;
                //colInfo8.ColumnIndexEnd = 8;
                //colInfo8.Width = 12 * 256;
                //sheet.AddColumnInfo(colInfo8);
                //创建列
                Cells cells = sheet.Cells; //获得指定工作页列集合 

                //创建表头
                
                Cell title = cells.Add(1, 1, "车间");
                title.HorizontalAlignment = HorizontalAlignments.Centered;
                title.VerticalAlignment = VerticalAlignments.Centered;

                Cell title1 = cells.Add(1, 2, "线别");
                title1.HorizontalAlignment = HorizontalAlignments.Centered;
                title1.VerticalAlignment = VerticalAlignments.Centered;

                Cell title2 = cells.Add(1, 3, "设备名称");
                title2.HorizontalAlignment = HorizontalAlignments.Centered;
                title2.VerticalAlignment = VerticalAlignments.Centered;

                Cell title3 = cells.Add(1, 4, "组件号");
                title3.HorizontalAlignment = HorizontalAlignments.Centered;
                title3.VerticalAlignment = VerticalAlignments.Centered;

                Cell title4 = cells.Add(1, 5, "刷入时间");
                title4.HorizontalAlignment = HorizontalAlignments.Centered;
                title4.VerticalAlignment = VerticalAlignments.Centered;

                int m=0;
                double dtmp=0.00;
                foreach(DataModel dataModel in dm)
                {
                    m++;
                    Cell value = cells.Add(m + 1, 1, dataModel.WORKSHOP);
                    Cell value1 = cells.Add(m + 1, 2, dataModel.LINE);
                    Cell value2 = cells.Add(m + 1, 3, dataModel.EQUIPMENT_NAME);
                    Cell value3 = cells.Add(m + 1, 4, dataModel.MODULE_SN);
                    Cell value4 = cells.Add(m + 1, 5, dataModel.CREATED_ON);
                    value.HorizontalAlignment = HorizontalAlignments.Centered;
                    value.VerticalAlignment = VerticalAlignments.Centered;
                    value1.HorizontalAlignment = HorizontalAlignments.Centered;
                    value1.VerticalAlignment = VerticalAlignments.Centered;
                    value2.HorizontalAlignment = HorizontalAlignments.Centered;
                    value2.VerticalAlignment = VerticalAlignments.Centered;
                    value3.HorizontalAlignment = HorizontalAlignments.Centered;
                    value3.VerticalAlignment = VerticalAlignments.Centered;
                    value4.HorizontalAlignment = HorizontalAlignments.Centered;
                    value4.VerticalAlignment = VerticalAlignments.Centered;
                       
                }


              
                try
                {           
                    xls.Save(true);
                    Msg = "导入成功";
                }
                catch(Exception e)
                {
                    Msg="导入失败"+e.Message;
                }
            }

        }
 
    
    }
}
