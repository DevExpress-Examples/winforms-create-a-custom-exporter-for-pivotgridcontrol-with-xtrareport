Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraEditors

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

			radioGroup1.Properties.Items(0).Value = ReportGeneratorType.SinglePage
			radioGroup1.Properties.Items(1).Value = ReportGeneratorType.FixedColumnWidth
			radioGroup1.Properties.Items(2).Value = ReportGeneratorType.BestFitColumns
			radioGroup1.EditValue = ReportGeneratorType.SinglePage
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim rep As XtraReport = PivotReportGenerator.GenerateReport(pivotGridControl1, (CType(radioGroup1.EditValue, ReportGeneratorType)), Convert.ToInt32(spinEdit1.EditValue), checkEdit2.Checked)
			rep.ShowPreviewDialog()
		End Sub



		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.customerReportsTableAdapter.Fill(Me.nwindDataSet.CustomerReports)
		End Sub
		Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioGroup1.SelectedIndexChanged
			Select Case (CType((CType(sender, RadioGroup)).EditValue, ReportGeneratorType))
				Case ReportGeneratorType.SinglePage
					spinEdit1.Enabled = False
					checkEdit2.Enabled = False
				Case ReportGeneratorType.FixedColumnWidth
					spinEdit1.Enabled = True
					checkEdit2.Enabled = True

				Case ReportGeneratorType.BestFitColumns
					spinEdit1.Enabled = False
					checkEdit2.Enabled = True
			End Select
		End Sub

	End Class
End Namespace