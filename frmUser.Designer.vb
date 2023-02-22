<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUser))
        Me.AdminrecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdminrecordDataSet = New BUS_TICKETING_SYSTEM.adminrecordDataSet()
        Me.AdminrecordsTableAdapter = New BUS_TICKETING_SYSTEM.adminrecordDataSetTableAdapters.adminrecordsTableAdapter()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OneWayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RounTripDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FromDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeopleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECSADSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RECSDataSet = New BUS_TICKETING_SYSTEM.RECSDataSet()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnBookNow = New System.Windows.Forms.Button()
        Me.rbRoundTrip = New System.Windows.Forms.RadioButton()
        Me.rbOneWay = New System.Windows.Forms.RadioButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.cbxPeople = New System.Windows.Forms.ComboBox()
        Me.dtpReturn = New System.Windows.Forms.DateTimePicker()
        Me.dtpDepart = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxTo = New System.Windows.Forms.ComboBox()
        Me.cbxFrom = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.RECSADSTableAdapter = New BUS_TICKETING_SYSTEM.RECSDataSetTableAdapters.RECSADSTableAdapter()
        CType(Me.AdminrecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminrecordDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RECSADSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RECSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AdminrecordsBindingSource
        '
        Me.AdminrecordsBindingSource.DataMember = "adminrecords"
        Me.AdminrecordsBindingSource.DataSource = Me.AdminrecordDataSet
        '
        'AdminrecordDataSet
        '
        Me.AdminrecordDataSet.DataSetName = "adminrecordDataSet"
        Me.AdminrecordDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdminrecordsTableAdapter
        '
        Me.AdminrecordsTableAdapter.ClearBeforeFill = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtSearch)
        Me.TabPage2.Controls.Add(Me.btnSearch)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(549, 447)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(6, 37)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(133, 22)
        Me.txtSearch.TabIndex = 5
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(145, 37)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OneWayDataGridViewTextBoxColumn, Me.RounTripDataGridViewTextBoxColumn, Me.FromDataGridViewTextBoxColumn, Me.ToDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.PeopleDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RECSADSBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(9, 65)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(528, 264)
        Me.DataGridView1.TabIndex = 3
        '
        'OneWayDataGridViewTextBoxColumn
        '
        Me.OneWayDataGridViewTextBoxColumn.DataPropertyName = "OneWay"
        Me.OneWayDataGridViewTextBoxColumn.HeaderText = "OneWay"
        Me.OneWayDataGridViewTextBoxColumn.Name = "OneWayDataGridViewTextBoxColumn"
        '
        'RounTripDataGridViewTextBoxColumn
        '
        Me.RounTripDataGridViewTextBoxColumn.DataPropertyName = "RounTrip"
        Me.RounTripDataGridViewTextBoxColumn.HeaderText = "RounTrip"
        Me.RounTripDataGridViewTextBoxColumn.Name = "RounTripDataGridViewTextBoxColumn"
        '
        'FromDataGridViewTextBoxColumn
        '
        Me.FromDataGridViewTextBoxColumn.DataPropertyName = "_From"
        Me.FromDataGridViewTextBoxColumn.HeaderText = "_From"
        Me.FromDataGridViewTextBoxColumn.Name = "FromDataGridViewTextBoxColumn"
        '
        'ToDataGridViewTextBoxColumn
        '
        Me.ToDataGridViewTextBoxColumn.DataPropertyName = "_To"
        Me.ToDataGridViewTextBoxColumn.HeaderText = "_To"
        Me.ToDataGridViewTextBoxColumn.Name = "ToDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "DepartDate"
        Me.DataGridViewTextBoxColumn1.HeaderText = "DepartDate"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ReturnDate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ReturnDate"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'PeopleDataGridViewTextBoxColumn
        '
        Me.PeopleDataGridViewTextBoxColumn.DataPropertyName = "People"
        Me.PeopleDataGridViewTextBoxColumn.HeaderText = "People"
        Me.PeopleDataGridViewTextBoxColumn.Name = "PeopleDataGridViewTextBoxColumn"
        '
        'RECSADSBindingSource
        '
        Me.RECSADSBindingSource.DataMember = "RECSADS"
        Me.RECSADSBindingSource.DataSource = Me.RECSDataSet
        '
        'RECSDataSet
        '
        Me.RECSDataSet.DataSetName = "RECSDataSet"
        Me.RECSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnCancel)
        Me.TabPage1.Controls.Add(Me.btnBookNow)
        Me.TabPage1.Controls.Add(Me.rbRoundTrip)
        Me.TabPage1.Controls.Add(Me.rbOneWay)
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Controls.Add(Me.cbxPeople)
        Me.TabPage1.Controls.Add(Me.dtpReturn)
        Me.TabPage1.Controls.Add(Me.dtpDepart)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.cbxTo)
        Me.TabPage1.Controls.Add(Me.cbxFrom)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(549, 447)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(284, 378)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 29)
        Me.btnCancel.TabIndex = 30
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnBookNow
        '
        Me.btnBookNow.BackColor = System.Drawing.Color.SteelBlue
        Me.btnBookNow.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnBookNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookNow.Location = New System.Drawing.Point(113, 378)
        Me.btnBookNow.Name = "btnBookNow"
        Me.btnBookNow.Size = New System.Drawing.Size(120, 29)
        Me.btnBookNow.TabIndex = 29
        Me.btnBookNow.Text = "Proceed"
        Me.btnBookNow.UseVisualStyleBackColor = False
        '
        'rbRoundTrip
        '
        Me.rbRoundTrip.AutoSize = True
        Me.rbRoundTrip.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.AdminrecordsBindingSource, "BusRoutes", True))
        Me.rbRoundTrip.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRoundTrip.Location = New System.Drawing.Point(161, 164)
        Me.rbRoundTrip.Name = "rbRoundTrip"
        Me.rbRoundTrip.Size = New System.Drawing.Size(87, 20)
        Me.rbRoundTrip.TabIndex = 28
        Me.rbRoundTrip.TabStop = True
        Me.rbRoundTrip.Text = "Round Trip"
        Me.rbRoundTrip.UseVisualStyleBackColor = True
        '
        'rbOneWay
        '
        Me.rbOneWay.AutoSize = True
        Me.rbOneWay.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.AdminrecordsBindingSource, "BusRoutes", True))
        Me.rbOneWay.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbOneWay.Location = New System.Drawing.Point(32, 164)
        Me.rbOneWay.Name = "rbOneWay"
        Me.rbOneWay.Size = New System.Drawing.Size(80, 20)
        Me.rbOneWay.TabIndex = 27
        Me.rbOneWay.TabStop = True
        Me.rbOneWay.Text = "One Way"
        Me.rbOneWay.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(548, 138)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'cbxPeople
        '
        Me.cbxPeople.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.AdminrecordsBindingSource, "TotalPassenger", True))
        Me.cbxPeople.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AdminrecordsBindingSource, "TotalPassenger", True))
        Me.cbxPeople.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminrecordsBindingSource, "TotalPassenger", True))
        Me.cbxPeople.FormattingEnabled = True
        Me.cbxPeople.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cbxPeople.Location = New System.Drawing.Point(264, 306)
        Me.cbxPeople.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxPeople.Name = "cbxPeople"
        Me.cbxPeople.Size = New System.Drawing.Size(124, 25)
        Me.cbxPeople.TabIndex = 25
        '
        'dtpReturn
        '
        Me.dtpReturn.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.AdminrecordsBindingSource, "ReturnDate", True))
        Me.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReturn.Location = New System.Drawing.Point(148, 308)
        Me.dtpReturn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpReturn.Name = "dtpReturn"
        Me.dtpReturn.Size = New System.Drawing.Size(100, 22)
        Me.dtpReturn.TabIndex = 24
        '
        'dtpDepart
        '
        Me.dtpDepart.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.AdminrecordsBindingSource, "Departdate", True))
        Me.dtpDepart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDepart.Location = New System.Drawing.Point(32, 308)
        Me.dtpDepart.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpDepart.Name = "dtpDepart"
        Me.dtpDepart.Size = New System.Drawing.Size(98, 22)
        Me.dtpDepart.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(261, 288)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "People"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(145, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 16)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Return"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(29, 286)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Depart"
        '
        'cbxTo
        '
        Me.cbxTo.FormattingEnabled = True
        Me.cbxTo.Items.AddRange(New Object() {"ANTIPOLO", "MARIKINA", "MAKATI", "MANDALUYONG", "TAGUIG"})
        Me.cbxTo.Location = New System.Drawing.Point(257, 228)
        Me.cbxTo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxTo.Name = "cbxTo"
        Me.cbxTo.Size = New System.Drawing.Size(131, 25)
        Me.cbxTo.TabIndex = 19
        '
        'cbxFrom
        '
        Me.cbxFrom.FormattingEnabled = True
        Me.cbxFrom.Items.AddRange(New Object() {"PASIG"})
        Me.cbxFrom.Location = New System.Drawing.Point(32, 228)
        Me.cbxFrom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxFrom.Name = "cbxFrom"
        Me.cbxFrom.Size = New System.Drawing.Size(132, 25)
        Me.cbxFrom.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(255, 208)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(22, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "To"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(29, 208)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 16)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "From"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(557, 477)
        Me.TabControl1.TabIndex = 16
        '
        'RECSADSTableAdapter
        '
        Me.RECSADSTableAdapter.ClearBeforeFill = True
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(581, 497)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User"
        CType(Me.AdminrecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminrecordDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RECSADSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RECSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BusTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReturnDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EarningsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdminrecordDataSet As adminrecordDataSet
    Friend WithEvents AdminrecordsBindingSource As BindingSource
    Friend WithEvents AdminrecordsTableAdapter As adminrecordDataSetTableAdapters.adminrecordsTableAdapter
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnBookNow As Button
    Friend WithEvents rbRoundTrip As RadioButton
    Friend WithEvents rbOneWay As RadioButton
    Friend WithEvents PictureBox2 As PictureBox
    Public WithEvents cbxPeople As ComboBox
    Public WithEvents dtpReturn As DateTimePicker
    Public WithEvents dtpDepart As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Public WithEvents cbxTo As ComboBox
    Public WithEvents cbxFrom As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents RECSDataSet As RECSDataSet
    Friend WithEvents RECSADSBindingSource As BindingSource
    Friend WithEvents RECSADSTableAdapter As RECSDataSetTableAdapters.RECSADSTableAdapter
    Friend WithEvents OneWayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RounTripDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FromDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents PeopleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
