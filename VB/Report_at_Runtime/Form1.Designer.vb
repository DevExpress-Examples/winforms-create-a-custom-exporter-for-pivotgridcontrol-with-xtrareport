Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim DataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding5 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.button1 = New System.Windows.Forms.Button()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.customerReportsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.nwindDataSet = New nwindDataSet()
            Me.fieldProductName1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCompanyName1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderMonth = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductAmount1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.customerReportsTableAdapter = New nwindDataSetTableAdapters.CustomerReportsTableAdapter()
            Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit()
            Me.checkEdit2 = New DevExpress.XtraEditors.CheckEdit()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.customerReportsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            '
            'button1
            '
            Me.button1.Location = New System.Drawing.Point(5, 5)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(175, 86)
            Me.button1.TabIndex = 0
            Me.button1.Text = "Create and Show the Report"
            Me.button1.UseVisualStyleBackColor = True
            '
            'pivotGridControl1
            '
            Me.pivotGridControl1.DataSource = Me.customerReportsBindingSource
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldProductName1, Me.fieldCompanyName1, Me.fieldOrderMonth, Me.fieldProductAmount1, Me.pivotGridField1})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsChartDataSource.SelectionOnly = False
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.Size = New System.Drawing.Size(714, 463)
            Me.pivotGridControl1.TabIndex = 1
            '
            'customerReportsBindingSource
            '
            Me.customerReportsBindingSource.DataMember = "CustomerReports"
            Me.customerReportsBindingSource.DataSource = Me.nwindDataSet
            '
            'nwindDataSet
            '
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'fieldProductName1
            '
            Me.fieldProductName1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldProductName1.AreaIndex = 1
            Me.fieldProductName1.Caption = "Product Name"
            DataSourceColumnBinding1.ColumnName = "ProductName"
            Me.fieldProductName1.DataBinding = DataSourceColumnBinding1
            Me.fieldProductName1.Name = "fieldProductName1"
            '
            'fieldCompanyName1
            '
            Me.fieldCompanyName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCompanyName1.AreaIndex = 0
            Me.fieldCompanyName1.Caption = "Company Name"
            DataSourceColumnBinding2.ColumnName = "CompanyName"
            Me.fieldCompanyName1.DataBinding = DataSourceColumnBinding2
            Me.fieldCompanyName1.Name = "fieldCompanyName1"
            '
            'fieldOrderMonth
            '
            Me.fieldOrderMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldOrderMonth.AreaIndex = 0
            Me.fieldOrderMonth.Caption = "Month"
            DataSourceColumnBinding3.ColumnName = "OrderDate"
            DataSourceColumnBinding3.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
            Me.fieldOrderMonth.DataBinding = DataSourceColumnBinding3
            Me.fieldOrderMonth.Name = "fieldOrderMonth"
            '
            'fieldProductAmount1
            '
            Me.fieldProductAmount1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldProductAmount1.AreaIndex = 0
            Me.fieldProductAmount1.Caption = "Sum"
            DataSourceColumnBinding4.ColumnName = "ProductAmount"
            Me.fieldProductAmount1.DataBinding = DataSourceColumnBinding4
            Me.fieldProductAmount1.Name = "fieldProductAmount1"
            '
            'pivotGridField1
            '
            Me.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.pivotGridField1.AreaIndex = 1
            Me.pivotGridField1.Caption = "Count"
            DataSourceColumnBinding5.ColumnName = "ProductAmount"
            Me.pivotGridField1.DataBinding = DataSourceColumnBinding5
            Me.pivotGridField1.Name = "pivotGridField1"
            '
            'customerReportsTableAdapter
            '
            Me.customerReportsTableAdapter.ClearBeforeFill = True
            '
            'radioGroup1
            '
            Me.radioGroup1.EditValue = "autosize"
            Me.radioGroup1.Location = New System.Drawing.Point(186, 5)
            Me.radioGroup1.Name = "radioGroup1"
            Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("autosize", "autosize to page width"), New DevExpress.XtraEditors.Controls.RadioGroupItem("do not autosize column width", "do not autosize and use column width"), New DevExpress.XtraEditors.Controls.RadioGroupItem("do not autosize and best fit columns", "do not autosize and best fit columns")})
            Me.radioGroup1.Size = New System.Drawing.Size(248, 86)
            Me.radioGroup1.TabIndex = 2
            '
            'labelControl1
            '
            Me.labelControl1.Location = New System.Drawing.Point(457, 15)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(66, 13)
            Me.labelControl1.TabIndex = 3
            Me.labelControl1.Text = "Column Width"
            '
            'spinEdit1
            '
            Me.spinEdit1.EditValue = New Decimal(New Integer() {30, 0, 0, 0})
            Me.spinEdit1.Enabled = False
            Me.spinEdit1.Location = New System.Drawing.Point(528, 12)
            Me.spinEdit1.Name = "spinEdit1"
            Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinEdit1.Properties.MaxValue = New Decimal(New Integer() {150, 0, 0, 0})
            Me.spinEdit1.Properties.MinValue = New Decimal(New Integer() {30, 0, 0, 0})
            Me.spinEdit1.Size = New System.Drawing.Size(100, 20)
            Me.spinEdit1.TabIndex = 4
            '
            'checkEdit2
            '
            Me.checkEdit2.Enabled = False
            Me.checkEdit2.Location = New System.Drawing.Point(457, 53)
            Me.checkEdit2.Name = "checkEdit2"
            Me.checkEdit2.Properties.Caption = "Repeat row header on every page"
            Me.checkEdit2.Size = New System.Drawing.Size(216, 20)
            Me.checkEdit2.TabIndex = 6
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.button1)
            Me.panelControl1.Controls.Add(Me.checkEdit2)
            Me.panelControl1.Controls.Add(Me.radioGroup1)
            Me.panelControl1.Controls.Add(Me.spinEdit1)
            Me.panelControl1.Controls.Add(Me.labelControl1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelControl1.Location = New System.Drawing.Point(0, 341)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(714, 122)
            Me.panelControl1.TabIndex = 7
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(714, 463)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.customerReportsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private WithEvents button1 As System.Windows.Forms.Button
		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private nwindDataSet As nwindDataSet
		Private customerReportsBindingSource As System.Windows.Forms.BindingSource
		Private customerReportsTableAdapter As nwindDataSetTableAdapters.CustomerReportsTableAdapter
		Private fieldProductName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCompanyName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldOrderMonth As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductAmount1 As DevExpress.XtraPivotGrid.PivotGridField
		Private WithEvents radioGroup1 As DevExpress.XtraEditors.RadioGroup
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private spinEdit1 As DevExpress.XtraEditors.SpinEdit
		Private checkEdit2 As DevExpress.XtraEditors.CheckEdit
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private pivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace

