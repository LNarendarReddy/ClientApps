using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NFRTest
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                textEdit1.Text = folderDlg.SelectedPath;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtMem = new DataTable();
                DataTable dtCPU = new DataTable();
                string stMemFilePathPath = textEdit1.Text + "\\memLogs";
                var FolderPath = new DirectoryInfo(stMemFilePathPath).GetDirectories("*", SearchOption.AllDirectories).OrderByDescending(d => d.LastWriteTimeUtc).First();
                string[] filePaths = Directory.GetFiles(stMemFilePathPath + "\\" + Convert.ToString(FolderPath));
                if (filePaths != null && filePaths.Count() > 0)
                {
                    string stFilePath = filePaths[0];
                    var table = new DataTable();
                    var fileContents = File.ReadAllLines(stFilePath);
                    var splitFileContents = (from f in fileContents select f.Split('\t')).ToArray();
                    int maxLength = (from s in splitFileContents select s.Count()).Max();
                    for (int i = 0; i < maxLength; i++)
                    {
                        table.Columns.Add();
                    }
                    foreach (var line in splitFileContents)
                    {
                        DataRow row = table.NewRow();
                        row.ItemArray = (object[])line;
                        table.Rows.Add(row);
                    }
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Capturetime", typeof(DateTime));
                    dt.Columns.Add("Value", typeof(int));
                    int OldValue = 0;
                    foreach (DataRow dr in table.Rows)
                    {
                        DateTime dtTime = DateTime.Now;
                        if (DateTime.TryParse(Convert.ToString(dr[0]), out dtTime))
                        {
                            int Ivalue = 0;
                            string stValue = Convert.ToString(dr[1]).Replace("K","").Replace(":","").Replace("B","").Replace(",","");
                            if (int.TryParse(stValue, out Ivalue) && OldValue != Ivalue)
                            {
                                DataRow drnew = dt.NewRow();
                                drnew["Capturetime"] = dtTime;
                                drnew["Value"] = Ivalue;
                                dt.Rows.Add(drnew);
                                OldValue = Ivalue;
                            }
                        }
                    }
                    Series series = new Series("Series1", ViewType.Line);
                    chartControl3.Series.Add(series);

                    // Generate a data table and bind the series to it.
                    series.DataSource =  dt;
                    dtMem = dt.Copy();
                    // Specify data members to bind the series.
                    series.ArgumentScaleType = ScaleType.DateTime;
                    series.ArgumentDataMember = "Capturetime";
                    series.ValueScaleType = ScaleType.Numerical;
                    series.ValueDataMembers.AddRange(new string[] { "Value" });
                    chartControl3.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

                    XYDiagram diagram = chartControl3.Diagram as XYDiagram;
                    diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Second;
                    diagram.AxisX.Label.TextPattern = "{V:dd/MM/yyyy hh:mm:ss}";
                }
                string stCPUFilePathPath = textEdit1.Text + "\\cpuLogs";
                var stFolderPath = new DirectoryInfo(stCPUFilePathPath).GetDirectories("*", SearchOption.AllDirectories).OrderByDescending(d => d.LastWriteTimeUtc).First();
                string[] stfilePaths = Directory.GetFiles(stCPUFilePathPath + "\\" + Convert.ToString(stFolderPath));
                if (stfilePaths != null && stfilePaths.Count() > 0)
                {
                    string stFilePath = stfilePaths[0];
                    var table = new DataTable();
                    var fileContents = File.ReadAllLines(stFilePath);
                    int TotalCount = fileContents.Count();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Capturetime", typeof(DateTime));
                    dt.Columns.Add("Value", typeof(int));
                    int OldValue = 0;
                    for (int i = 0; i < TotalCount; i += 2)
                    {
                        if(fileContents[i].Contains("%"))
                        { 
                        string stValue = fileContents[i].Substring(0, 4).Trim();
                        string stDAte = fileContents[i + 1].Trim();
                        int IValue = 0;
                            if (int.TryParse(stValue, out IValue) && OldValue!= IValue)
                            {
                                DateTime dttime = DateTime.Now;
                                if (DateTime.TryParse(stDAte, out dttime))
                                {
                                    DataRow dr = dt.NewRow();
                                    dr["Capturetime"] = dttime;
                                    dr["Value"] = IValue;
                                    dt.Rows.Add(dr);
                                    OldValue = IValue;
                                }
                            }
                        }
                    }
                    Series series = new Series("Series2", ViewType.Line);
                    chartControl2.Series.Add(series);

                    series.DataSource = dt;
                    dtCPU = dt.Copy();
                    series.ArgumentScaleType = ScaleType.DateTime;
                    series.ArgumentDataMember = "Capturetime";
                    series.ValueScaleType = ScaleType.Numerical;
                    series.ValueDataMembers.AddRange(new string[] { "Value" });
                    chartControl2.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
                    XYDiagram diagram = chartControl2.Diagram as XYDiagram;
                    diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Second;
                    diagram.AxisX.Label.TextPattern = "{V:dd/MM/yyyy hh:MM:ss}";
                }

                UpdateValues(dtMem, dtCPU);
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.ToString()); }
        }

        private void UpdateValues(DataTable dtMem,DataTable dtCPU)
        {
            try
            {
                RegistryKey RGkey = Registry.CurrentUser.OpenSubKey(@"Software\NFRTest", true);
                if (RGkey == null)
                    RGkey = Registry.CurrentUser.CreateSubKey(@"Software\NFRTest");
                if (dtMem != null && dtMem.Rows.Count > 0)
                {
                     object MemAvg = dtMem.Compute("AVG([Value])", "");
                    object MemMAx = dtMem.Compute("MAX([Value])", "");

                    if (RGkey.GetValue("MEMAvgValue") == null)
                    {
                        RGkey.SetValue("MEMAvgValue", MemAvg);
                        txtLastMemAvgValue.Text = "0";
                        txtMemAvgValue.Text = Convert.ToString(MemAvg);
                    }
                    else
                    {
                        txtMemAvgValue.Text = Convert.ToString(MemAvg);
                        txtLastMemAvgValue.Text = Convert.ToString(RGkey.GetValue("MEMAvgValue"));
                        RGkey.SetValue("MEMAvgValue", MemAvg);
                        RGkey.Flush();
                    }

                    if (RGkey.GetValue("MemMaxValue") == null)
                    {
                        RGkey.SetValue("MemMaxValue", MemMAx);
                        txtlastMemMaxValue.Text = "0";
                        txtMemMaxValue.Text = Convert.ToString(MemMAx);
                    }
                    else
                    {
                        txtMemMaxValue.Text = Convert.ToString(MemMAx);
                        txtlastMemMaxValue.Text = Convert.ToString(RGkey.GetValue("MemMaxValue"));
                        RGkey.SetValue("MemMaxValue", MemMAx);
                        RGkey.Flush();
                    }
                }

                if (dtCPU != null && dtCPU.Rows.Count > 0)
                {
                    object CPUAvg = dtCPU.Compute("AVG([Value])", "");
                    object CPUMAx = dtCPU.Compute("MAX([Value])", "");

                    if (RGkey.GetValue("CPUAvgValue") == null)
                    {
                        RGkey.SetValue("CPUAvgValue", CPUAvg);
                        txtLastCPUAvgValue.Text = "0";
                        txtCPUAvgValue.Text = Convert.ToString(CPUAvg);
                    }
                    else
                    {
                        txtCPUAvgValue.Text = Convert.ToString(CPUAvg);
                        txtLastCPUAvgValue.Text = Convert.ToString(RGkey.GetValue("CPUAvgValue"));
                        RGkey.SetValue("CPUAvgValue", CPUAvg);
                        RGkey.Flush();
                    }

                    if (RGkey.GetValue("CPUMaxValue") == null)
                    {
                        RGkey.SetValue("CPUMaxValue", CPUMAx);
                        txtLastCPUMaxValue.Text = "0";
                        txtCPUMaxVAlue.Text = Convert.ToString(CPUMAx);
                    }
                    else
                    {
                        txtCPUMaxVAlue.Text = Convert.ToString(CPUMAx);
                        txtLastCPUMaxValue.Text = Convert.ToString(RGkey.GetValue("CPUMaxValue"));
                        RGkey.SetValue("CPUMaxValue", CPUMAx);
                        RGkey.Flush();
                    }
                }
                RGkey.Close();
            }
            catch (Exception ex) { }
        }
    }
}
