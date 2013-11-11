using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevAge.ComponentModel;
using Excel;
using LumenWorks.Framework.IO.Csv;

namespace SpreadSheetInspector
{
    public partial class SSControl : UserControl
    {
        private DataSet ds;

        public SSControl()
        {
            InitializeComponent();
        }

        private static IDataReader CreateReader(string fileName, string mimeType)
        {
            var stream = File.OpenRead(fileName);
            switch (mimeType)
            {
                case "application/vnd.ms-excel":
                case "application/msexcel":
                case "application/x-msexcel":
                case "application/x-ms-excel":
                case "application/x-excel":
                case "application/x-dos_ms_excel":
                case "application/xls":
                case "application/x-xls":
                    return ExcelReaderFactory.CreateBinaryReader(stream);
                case "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet":
                case "application/vnd.openxmlformats-officedocument.spreadsheetml.template":
                    return ExcelReaderFactory.CreateOpenXmlReader(stream);
                case "text/comma-separated-values":
                case "text/any":
                case "text/csv":
                case "application/csv":
                    TextReader reader = new StreamReader(stream);
                    return new CsvReader(reader, true);
                default:
                    throw new ArgumentException("Not a supported mime type");
            }
        }

        public void LoadSpreadSheet (string fileName, string mimeType)
        {
            using (var rdr = CreateReader(fileName, mimeType))
            {
                if (ds != null) ds.Dispose();
                if (rdr is IExcelDataReader)
                {
                    ds = ((IExcelDataReader) rdr).AsDataSet();
                }
                else
                {
                    ds = new DataSet();
                    var dt = new DataTable(Path.GetFileNameWithoutExtension(fileName));
                    dt.BeginInit();
                    dt.BeginLoadData();
                    for (int i = 0; i < rdr.FieldCount; i++) { dt.Columns.Add(rdr.GetName(i), typeof(string)); }
                    while (rdr.Read())
                    {
                        var row = dt.NewRow();
                        for (int i = 0; i < rdr.FieldCount; i++)
                        {
                            row[i] = rdr.GetString(i);
                        }
                    }
                    dt.EndLoadData();
                    dt.EndInit();
                    ds.Tables.Add(dt);
                }
            }
            cmbWorkSheets.DataSource = (from table in ds.Tables.Cast<DataTable>() select table.TableName).ToList();
            cmbWorkSheets.SelectedIndex = 0;
        }

        private void cmbWorkSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dataSource = new BoundDataView(new DataView(ds.Tables[(string)cmbWorkSheets.SelectedValue]));
            gridWorkSheet.DataSource = dataSource;
        }
    }
}
