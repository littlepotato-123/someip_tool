using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Reflection;
//using Microsoft.Office.Core;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    class EXCEL
    {
        [DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern bool WritePrivateProfileString(
         string lpAppName, string lpKeyName, string lpString, string lpFileName);

        [DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern int GetPrivateProfileString(
            string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString,
            int nSize, string lpFileName);

        Microsoft.Office.Interop.Excel.Application app;
        Workbooks wbks;
        _Workbook _wbk;
        Sheets shs;
        _Worksheet _wsh;
        Worksheet wb;

        public void CreateExcel()
        {
            app = new Microsoft.Office.Interop.Excel.Application();
            wbks = app.Workbooks;
            _wbk = wbks.Add(true);
            shs = _wbk.Sheets;
            _wsh = (_Worksheet)shs.get_Item(1);
            _wsh.Name = "Message Map";
        }

        public void OpenExcel(int index, String filename)
        {
            app = new Microsoft.Office.Interop.Excel.Application();
            wbks = app.Workbooks;
            // _wbk = wbks.Add(display.excelfile);
            _wbk = wbks.Add(filename);
            shs = _wbk.Sheets;
            _wsh = (_Worksheet)shs.get_Item(index);
        }

        public void Write(int Row, int Cell, String Text)
        {
            _wsh.Cells[Row, Cell] = Text;
        }

        public string ReadExcel(int Row, int Column)
        {
            return _wsh.Cells[Row, Column].Text;
        }

        public void Close()
        {
            //app.AlertBeforeOverwriting = false;
            _wbk.Close(null, null, null);
            wbks.Close();
            app.Quit();//关闭组件对象
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wbks);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(_wbk);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(shs);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
            //app = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        public void Save(string fileSavePath)
        {
            app.AlertBeforeOverwriting = false;
            //app.Save(fileSavePath);
            app.GetSaveAsFilename(fileSavePath, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            app.Quit();
            
            System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
            app = null;
        }

        /*
        public void Save(String filename, Microsoft.Office.Interop.Excel.Application excel, Microsoft.Office.Interop.Excel.Workbook wb)
        {
            
            Process[] localByNameApp = Process.GetProcessesByName(filename);//获取程序名的所有进程


            if(localByNameApp.Length > 0)
            {
                foreach(var appfile in localByNameApp)
                {
                    if(!appfile.HasExited)
                    {
                        #region
                        //设置禁止弹出保存和覆盖的询问提示框   
                        excel.DisplayAlerts = false;
                        excel.AlertBeforeOverwriting = false;

                        //保存工作簿   
                        excel.Application.Workbooks.Add(true).Save();
                        //保存excel文件   
                        excel.Save("F:" + "\\test.xlsx");
                        //确保Excel进程关闭   
                        excel.Quit();
                        excel = null; 
                        #endregion
                        appfile.Kill();//关闭进程
                    }
                }
            }
            if (wb != null)
                wb.Close(true, Type.Missing, Type.Missing);
            excel.Quit();
            // 安全回收进程
            System.GC.GetGeneration(excel);

        }*/

        public void SetExcelCell_HW(int Cow, int Raw, int Heignt, int Width)
        {
            ((Range)_wsh.Rows[Cow, Missing.Value]).RowHeight = Heignt;
            ((Range)_wsh.Cells[Raw, Missing.Value]).ColumnWidth = Width;
        }

        //public void SetSingleCell_1(int Cow, int Raw, int BodySize, bool Bold, int postion)
        //{

        //    ((Range)_wsh.Cells[Cow, Raw]).Font.Size = BodySize;
        //    ((Range)_wsh.Cells[Cow, Raw]).Font.Bold = Bold;
        //    if (postion == 1)
        //    {
        //        ((Range)_wsh.Cells[Cow, Raw]).HorizontalAlignment = Microsoft.Office.Core.XlVAlign.xlVAlignBottom;
        //    }
        //    else if (postion == 2)
        //    {
        //        ((Range)_wsh.Cells[Cow, Raw]).HorizontalAlignment = Microsoft.Office.Core.XlVAlign.xlVAlignTop;
        //    }
        //    else
        //    {
        //        ((Range)_wsh.Cells[Cow, Raw]).HorizontalAlignment = Microsoft.Office.Core.XlVAlign.xlVAlignCenter;
        //    }
        //}

        //当同一个测试案例的测试内容增加时，列自动增加测试项
        public void Add_menu(int item_row, int item_column)
        {
            try
            {
                //插入3列
                Range xlsColumns = (Range)_wsh.Columns[(item_column + 1) * 3, Type.Missing];
                xlsColumns.Insert(XlInsertShiftDirection.xlShiftToRight, Type.Missing);
                xlsColumns.Insert(XlInsertShiftDirection.xlShiftToRight, Type.Missing);
                xlsColumns.Insert(XlInsertShiftDirection.xlShiftToRight, Type.Missing);

                Range src_copy = _wsh.Range[_wsh.Cells[1, 3], _wsh.Cells[(item_row + 1), 5]];

                Range des_copy = _wsh.Cells[1, (item_column + 1) * 3];

                src_copy.Copy(des_copy);//复制测试项

                for (int i = 2; i <= item_row + 1; i++)//行循环
                {
                    _wsh.Cells[i, (item_column + 1) * 3] = "/";
                    _wsh.Cells[i, (item_column + 1) * 3 + 1] = "";
                    _wsh.Cells[i, (item_column + 1) * 3 + 2] = "/";
                }


            }
            catch
            {
                MessageBox.Show("程序出错，请联系作者！！");
            }

        }
        //当需要增加测试案例时
        public void Add_item(int item_row, int end_column)
        {
            try
            {
                _wsh.Range[_wsh.Cells[item_row, 1], _wsh.Cells[item_row, end_column]].Copy(_wsh.Cells[item_row + 1, 1]);
                //设置行高为26
                ((Range)_wsh.Rows[item_row + 1, Missing.Value]).RowHeight = 26;
                //测试案例自加
                _wsh.Cells[item_row + 1, 1] = item_row.ToString();
            }
            catch
            {
                MessageBox.Show("程序出错，请联系作者！！");
            }
        }
    }
}
