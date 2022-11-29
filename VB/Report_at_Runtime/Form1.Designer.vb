Namespace WindowsApplication1

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
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
            Dim dataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding5 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.button1 = New System.Windows.Forms.Button()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.customerReportsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.nwindDataSet = New WindowsApplication1.nwindDataSet()
            Me.fieldProductName1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCompanyName1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderMonth = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductAmount1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.customerReportsTableAdapter = New WindowsApplication1.nwindDataSetTableAdapters.CustomerReportsTableAdapter()
            Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit()
            Me.checkEdit2 = New DevExpress.XtraEditors.CheckEdit()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.customerReportsBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.nwindDataSet), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radioGroup1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEdit2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' button1
            ' 
            Me.button1.Location = New System.Drawing.Point(5, 5)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(175, 83)
            Me.button1.TabIndex = 0
            Me.button1.Text = "Create and Show the Report"
            Me.button1.UseVisualStyleBackColor = True
            AddHandler Me.button1.Click, New System.EventHandler(AddressOf Me.button1_Click)
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.DataSource = Me.customerReportsBindingSource
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldProductName1, Me.fieldCompanyName1, Me.fieldOrderMonth, Me.fieldProductAmount1, Me.pivotGridField1})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsChartDataSource.SelectionOnly = False
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.Size = New System.Drawing.Size(868, 463)
            Me.pivotGridControl1.TabIndex = 1
            ' 
            ' customerReportsBindingSource
            ' 
            Me.customerReportsBindingSource.DataMember = "CustomerReports"
            Me.customerReportsBindingSource.DataSource = Me.nwindDataSet
            ' 
            ' nwindDataSet
            ' 
            Me.nwindDataSet.DataSetName = "nwindDataSet"
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' fieldProductName1
            ' 
            Me.fieldProductName1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldProductName1.AreaIndex = 1
            Me.fieldProductName1.Caption = "Product Name"
            dataSourceColumnBinding1.ColumnName = "ProductName"
            Me.fieldProductName1.DataBinding = dataSourceColumnBinding1
            Me.fieldProductName1.Name = "fieldProductName1"
            ' 
            ' fieldCompanyName1
            ' 
            Me.fieldCompanyName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCompanyName1.AreaIndex = 0
            Me.fieldCompanyName1.Caption = "Company Name"
            dataSourceColumnBinding2.ColumnName = "CompanyName"
            Me.fieldCompanyName1.DataBinding = dataSourceColumnBinding2
            Me.fieldCompanyName1.Name = "fieldCompanyName1"
            ' 
            ' fieldOrderMonth
            ' 
            Me.fieldOrderMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldOrderMonth.AreaIndex = 0
            Me.fieldOrderMonth.Caption = "Month"
            dataSourceColumnBinding3.ColumnName = "OrderDate"
            dataSourceColumnBinding3.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
            Me.fieldOrderMonth.DataBinding = dataSourceColumnBinding3
            Me.fieldOrderMonth.Name = "fieldOrderMonth"
            ' 
            ' fieldProductAmount1
            ' 
            Me.fieldProductAmount1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldProductAmount1.AreaIndex = 0
            Me.fieldProductAmount1.Caption = "Sum"
            dataSourceColumnBinding4.ColumnName = "ProductAmount"
            Me.fieldProductAmount1.DataBinding = dataSourceColumnBinding4
            Me.fieldProductAmount1.Name = "fieldProductAmount1"
            ' 
            ' pivotGridField1
            ' 
            Me.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.pivotGridField1.AreaIndex = 1
            Me.pivotGridField1.Caption = "Count"
            dataSourceColumnBinding5.ColumnName = "ProductAmount"
            Me.pivotGridField1.DataBinding = dataSourceColumnBinding5
            Me.pivotGridField1.Name = "pivotGridField1"
            ' 
            ' customerReportsTableAdapter
            ' 
            Me.customerReportsTableAdapter.ClearBeforeFill = True
            ' 
            ' radioGroup1
            ' 
            Me.radioGroup1.EditValue = "autosize"
            Me.radioGroup1.Location = New System.Drawing.Point(186, 5)
            Me.radioGroup1.Name = "radioGroup1"
            Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("autosize", "autosize to page width"), New DevExpress.XtraEditors.Controls.RadioGroupItem("do not autosize column width", "do not autosize and use column width"), New DevExpress.XtraEditors.Controls.RadioGroupItem("do not autosize and best fit columns", "do not autosize and best fit columns")})
            Me.radioGroup1.Size = New System.Drawing.Size(226, 83)
            Me.radioGroup1.TabIndex = 2
            AddHandler Me.radioGroup1.SelectedIndexChanged, New System.EventHandler(AddressOf Me.radioGroup1_SelectedIndexChanged)
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(427, 15)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(66, 13)
            Me.labelControl1.TabIndex = 3
            Me.labelControl1.Text = "Column Width"
            ' 
            ' spinEdit1
            ' 
            Me.spinEdit1.EditValue = New Decimal(New Integer() {30, 0, 0, 0})
            Me.spinEdit1.Enabled = False
            Me.spinEdit1.Location = New System.Drawing.Point(498, 12)
            Me.spinEdit1.Name = "spinEdit1"
            Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinEdit1.Properties.MaxValue = New Decimal(New Integer() {150, 0, 0, 0})
            Me.spinEdit1.Properties.MinValue = New Decimal(New Integer() {30, 0, 0, 0})
            Me.spinEdit1.Size = New System.Drawing.Size(100, 20)
            Me.spinEdit1.TabIndex = 4
            ' 
            ' checkEdit2
            ' 
            Me.checkEdit2.Enabled = False
            Me.checkEdit2.Location = New System.Drawing.Point(425, 63)
            Me.checkEdit2.Name = "checkEdit2"
            Me.checkEdit2.Properties.Caption = "Repeat row header on every page"
            Me.checkEdit2.Size = New System.Drawing.Size(216, 20)
            Me.checkEdit2.TabIndex = 6
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.button1)
            Me.panelControl1.Controls.Add(Me.checkEdit2)
            Me.panelControl1.Controls.Add(Me.radioGroup1)
            Me.panelControl1.Controls.Add(Me.spinEdit1)
            Me.panelControl1.Controls.Add(Me.labelControl1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelControl1.Location = New System.Drawing.Point(0, 367)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(868, 96)
            Me.panelControl1.TabIndex = 7
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(868, 463)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.customerReportsBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.nwindDataSet), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radioGroup1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEdit2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private button1 As System.Windows.Forms.Button

        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

        Private nwindDataSet As WindowsApplication1.nwindDataSet

        Private customerReportsBindingSource As System.Windows.Forms.BindingSource

        Private customerReportsTableAdapter As WindowsApplication1.nwindDataSetTableAdapters.CustomerReportsTableAdapter

        Private fieldProductName1 As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldCompanyName1 As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldOrderMonth As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldProductAmount1 As DevExpress.XtraPivotGrid.PivotGridField

        Private radioGroup1 As DevExpress.XtraEditors.RadioGroup

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private spinEdit1 As DevExpress.XtraEditors.SpinEdit

        Private checkEdit2 As DevExpress.XtraEditors.CheckEdit

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private pivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    End Class
End Namespace
