using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraEditors;

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            radioGroup1.Properties.Items[0].Value = ReportGeneratorType.SinglePage;
            radioGroup1.Properties.Items[1].Value = ReportGeneratorType.FixedColumnWidth;
            radioGroup1.Properties.Items[2].Value = ReportGeneratorType.BestFitColumns;
            radioGroup1.EditValue = ReportGeneratorType.SinglePage;
        }
        private void button1_Click(object sender, EventArgs e) {
            XtraReport rep = PivotReportGenerator.GenerateReport(pivotGridControl1, ((ReportGeneratorType)radioGroup1.EditValue), Convert.ToInt32(spinEdit1.EditValue), checkEdit2.Checked);
            rep.ShowPreviewDialog();
        }
        private void Form1_Load(object sender, EventArgs e) {
            this.customerReportsTableAdapter.Fill(this.nwindDataSet.CustomerReports);
            fieldProductName1.FilterValues.ValuesIncluded = fieldProductName1.GetUniqueValues().Take(7).ToArray();
            pivotGridControl1.BestFit();
        }
        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e) {
            switch (((ReportGeneratorType)((RadioGroup)sender).EditValue)) {
                case ReportGeneratorType.SinglePage:
                    spinEdit1.Enabled = false;
                    checkEdit2.Enabled = false;
                    break;
                case ReportGeneratorType.FixedColumnWidth:
                    spinEdit1.Enabled = true;
                    checkEdit2.Enabled = true;
                    break;

                case ReportGeneratorType.BestFitColumns:
                    spinEdit1.Enabled = false;
                    checkEdit2.Enabled = true;
                    break;
            }
        }
    }
}
