using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using NullableDateControls;

namespace com.digitalwave.iCare.gui.HIS.Reports
{
    public partial class frmReport_GroupEarningCollect : com.digitalwave.GUI_Base.frmMDI_Child_Base
    {
        private string m_strRptID = string.Empty;
        private string[] m_strGroupIDArr = new string[2];

        internal string GhItemIDArr = "";
        internal string ZcItemIDArr = "";

        public frmReport_GroupEarningCollect()
        {
            InitializeComponent();
        }

        private void frmReport_GroupEarningCollect_Load(object sender, EventArgs e)
        {            
            m_dtpBeginDat.Value = DateTime.Now;
            m_dtpEndDat.Value = DateTime.Now;
            dw_groupearningcollect.LibraryList = Application.StartupPath + "\\PB_OP.pbl";
            dw_groupearningcollect.DataWindowObject = "d_bih_reportgroupearningcollect";
        }
        public override void CreateController()
        {
            this.objController = new com.digitalwave.iCare.gui.HIS.Reports.clsCtl_Report_GroupEarningCollect();
            objController.Set_GUI_Apperance(this);
        }

        private void m_cmdQuery_Click(object sender, EventArgs e)
        {
            try
            {
                clsPublic.PlayAvi("findFILE.avi", "正在检索数据，请稍候...");
                //((clsCtl_Report_GroupEarningCollect)this.objController).m_mthSelectGroupEarningCollect();

                ((clsCtl_Report_GroupEarningCollect)this.objController).m_mthShowReport(m_strRptID, m_strGroupIDArr);
            }
            finally
            {
                clsPublic.CloseAvi();
            }
        }

        public void ShowWithParm(string p_strRptID, string p_strGroupID1, string p_strGroupID2)
        {            
            //((clsCtl_Report_GroupEarningCollect)this.objController).m_mthGetParams(p_ghcode, p_zjcode);
            m_strRptID = p_strRptID;
            m_strGroupIDArr[0] = p_strGroupID1;
            m_strGroupIDArr[1] = p_strGroupID2;

            this.Show();
        }

        private void m_cmdPrint_Click(object sender, EventArgs e)
        {
            clsPublic.ChoosePrintDialog(dw_groupearningcollect, true);
        }

        private void buttonXP1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonXP2_Click(object sender, EventArgs e)
        {
            this.dw_groupearningcollect.PrintProperties.Preview = !this.dw_groupearningcollect.PrintProperties.Preview;
        }
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int GetWindowThreadProcessId(IntPtr hwnd, out   int ID);
        private void buttonXP3_Click(object sender, EventArgs e)
        {
            if (this.dw_groupearningcollect.RowCount > 0)
            {
                SaveFileDialog FD = new SaveFileDialog();
                FD.Filter = "Excel 文档|*.xls";
                FD.Title = "导出";
                FD.ShowDialog();
                int m_intColumnCount = this.dw_groupearningcollect.ColumnCount;
                if (FD.FileName.Trim() != "")
                {
                    this.dw_groupearningcollect.SaveAs(FD.FileName.Trim(), Sybase.DataWindow.FileSaveAsType.Excel, true, Sybase.DataWindow.FileSaveAsEncoding.Utf8);
                    string m_strTemp;
                    string m_strText;
                    Excel.Application excel = new Excel.Application();
                    Excel.Workbook wb = null;

                    object missing = System.Reflection.Missing.Value;

                    wb = excel.Workbooks.Open(FD.FileName, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing);
                    excel.Visible = false;
                    for (int i = 1; i <= m_intColumnCount; i++)
                    {
                        m_strTemp = this.dw_groupearningcollect.Describe("#" + i.ToString() + ".name");
                        m_strTemp += "_t.text";
                        m_strText = this.dw_groupearningcollect.Describe(m_strTemp);
                        excel.Cells[1, i] = m_strText;
                    }
                    wb.Save();
                    excel.Quit();
                    IntPtr t = new IntPtr(excel.Hwnd);
                    int k = 0;
                    GetWindowThreadProcessId(t, out   k);
                    System.Diagnostics.Process p = System.Diagnostics.Process.GetProcessById(k);
                    p.Kill();
                }
            }
        }
    }
}