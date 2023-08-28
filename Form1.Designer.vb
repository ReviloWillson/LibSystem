<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMain))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblInfoWelcome = New System.Windows.Forms.Label()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.lblAut = New System.Windows.Forms.Label()
        Me.txtBoxAut = New System.Windows.Forms.TextBox()
        Me.txtBoxTitle = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtBoxPublisher = New System.Windows.Forms.TextBox()
        Me.txtBoxPubDate = New System.Windows.Forms.TextBox()
        Me.txtBoxLoc = New System.Windows.Forms.TextBox()
        Me.lblPublisher = New System.Windows.Forms.Label()
        Me.lblPubDate = New System.Windows.Forms.Label()
        Me.lblLoc = New System.Windows.Forms.Label()
        Me.lblSearchInfo = New System.Windows.Forms.Label()
        Me.chkBoxAut = New System.Windows.Forms.CheckBox()
        Me.chkBoxPublisher = New System.Windows.Forms.CheckBox()
        Me.chkBoxPubDate = New System.Windows.Forms.CheckBox()
        Me.chkBoxTitle = New System.Windows.Forms.CheckBox()
        Me.chkBoxLoc = New System.Windows.Forms.CheckBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.grpSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Fishbits", 26.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(511, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(155, 64)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblInfoWelcome
        '
        Me.lblInfoWelcome.AutoSize = True
        Me.lblInfoWelcome.Location = New System.Drawing.Point(13, 13)
        Me.lblInfoWelcome.Name = "lblInfoWelcome"
        Me.lblInfoWelcome.Size = New System.Drawing.Size(445, 13)
        Me.lblInfoWelcome.TabIndex = 1
        Me.lblInfoWelcome.Text = "Welcome to LibSystem. Click here for more information concerning the use of this " &
    "application."
        '
        'grpSearch
        '
        Me.grpSearch.Controls.Add(Me.btnSearch)
        Me.grpSearch.Controls.Add(Me.chkBoxLoc)
        Me.grpSearch.Controls.Add(Me.chkBoxPublisher)
        Me.grpSearch.Controls.Add(Me.chkBoxPubDate)
        Me.grpSearch.Controls.Add(Me.lblSearchInfo)
        Me.grpSearch.Controls.Add(Me.chkBoxTitle)
        Me.grpSearch.Controls.Add(Me.chkBoxAut)
        Me.grpSearch.Controls.Add(Me.lblLoc)
        Me.grpSearch.Controls.Add(Me.lblPubDate)
        Me.grpSearch.Controls.Add(Me.lblPublisher)
        Me.grpSearch.Controls.Add(Me.txtBoxLoc)
        Me.grpSearch.Controls.Add(Me.txtBoxPubDate)
        Me.grpSearch.Controls.Add(Me.txtBoxPublisher)
        Me.grpSearch.Controls.Add(Me.lblTitle)
        Me.grpSearch.Controls.Add(Me.txtBoxTitle)
        Me.grpSearch.Controls.Add(Me.txtBoxAut)
        Me.grpSearch.Controls.Add(Me.lblAut)
        Me.grpSearch.Location = New System.Drawing.Point(16, 29)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(489, 193)
        Me.grpSearch.TabIndex = 2
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search Fields"
        '
        'lblAut
        '
        Me.lblAut.AutoSize = True
        Me.lblAut.Location = New System.Drawing.Point(45, 63)
        Me.lblAut.Name = "lblAut"
        Me.lblAut.Size = New System.Drawing.Size(38, 13)
        Me.lblAut.TabIndex = 0
        Me.lblAut.Text = "Author"
        '
        'txtBoxAut
        '
        Me.txtBoxAut.BackColor = System.Drawing.SystemColors.Desktop
        Me.txtBoxAut.Location = New System.Drawing.Point(118, 56)
        Me.txtBoxAut.Name = "txtBoxAut"
        Me.txtBoxAut.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxAut.TabIndex = 1
        '
        'txtBoxTitle
        '
        Me.txtBoxTitle.BackColor = System.Drawing.SystemColors.Desktop
        Me.txtBoxTitle.Location = New System.Drawing.Point(118, 82)
        Me.txtBoxTitle.Name = "txtBoxTitle"
        Me.txtBoxTitle.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxTitle.TabIndex = 2
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(56, 89)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Title"
        '
        'txtBoxPublisher
        '
        Me.txtBoxPublisher.BackColor = System.Drawing.SystemColors.Desktop
        Me.txtBoxPublisher.Location = New System.Drawing.Point(118, 109)
        Me.txtBoxPublisher.Name = "txtBoxPublisher"
        Me.txtBoxPublisher.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxPublisher.TabIndex = 4
        '
        'txtBoxPubDate
        '
        Me.txtBoxPubDate.BackColor = System.Drawing.SystemColors.Desktop
        Me.txtBoxPubDate.Location = New System.Drawing.Point(118, 136)
        Me.txtBoxPubDate.Name = "txtBoxPubDate"
        Me.txtBoxPubDate.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxPubDate.TabIndex = 5
        '
        'txtBoxLoc
        '
        Me.txtBoxLoc.BackColor = System.Drawing.SystemColors.Desktop
        Me.txtBoxLoc.Location = New System.Drawing.Point(118, 163)
        Me.txtBoxLoc.Name = "txtBoxLoc"
        Me.txtBoxLoc.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxLoc.TabIndex = 6
        '
        'lblPublisher
        '
        Me.lblPublisher.AutoSize = True
        Me.lblPublisher.Location = New System.Drawing.Point(33, 116)
        Me.lblPublisher.Name = "lblPublisher"
        Me.lblPublisher.Size = New System.Drawing.Size(50, 13)
        Me.lblPublisher.TabIndex = 7
        Me.lblPublisher.Text = "Publisher"
        '
        'lblPubDate
        '
        Me.lblPubDate.AutoSize = True
        Me.lblPubDate.Location = New System.Drawing.Point(6, 143)
        Me.lblPubDate.Name = "lblPubDate"
        Me.lblPubDate.Size = New System.Drawing.Size(79, 13)
        Me.lblPubDate.TabIndex = 8
        Me.lblPubDate.Text = "Date Published"
        '
        'lblLoc
        '
        Me.lblLoc.AutoSize = True
        Me.lblLoc.Location = New System.Drawing.Point(33, 170)
        Me.lblLoc.Name = "lblLoc"
        Me.lblLoc.Size = New System.Drawing.Size(48, 13)
        Me.lblLoc.TabIndex = 9
        Me.lblLoc.Text = "Location"
        '
        'lblSearchInfo
        '
        Me.lblSearchInfo.AutoSize = True
        Me.lblSearchInfo.Location = New System.Drawing.Point(56, 16)
        Me.lblSearchInfo.Name = "lblSearchInfo"
        Me.lblSearchInfo.Size = New System.Drawing.Size(255, 39)
        Me.lblSearchInfo.TabIndex = 10
        Me.lblSearchInfo.Text = "Enter search terms into one or more entry fields. and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "check the appropriate boxe" &
    "s. The database to query" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "may be customised in dataSettings.cfg."
        '
        'chkBoxAut
        '
        Me.chkBoxAut.AutoSize = True
        Me.chkBoxAut.Location = New System.Drawing.Point(224, 58)
        Me.chkBoxAut.Name = "chkBoxAut"
        Me.chkBoxAut.Size = New System.Drawing.Size(99, 17)
        Me.chkBoxAut.TabIndex = 11
        Me.chkBoxAut.Text = "Search Authors"
        Me.chkBoxAut.UseVisualStyleBackColor = True
        '
        'chkBoxPublisher
        '
        Me.chkBoxPublisher.AutoSize = True
        Me.chkBoxPublisher.Location = New System.Drawing.Point(224, 111)
        Me.chkBoxPublisher.Name = "chkBoxPublisher"
        Me.chkBoxPublisher.Size = New System.Drawing.Size(111, 17)
        Me.chkBoxPublisher.TabIndex = 12
        Me.chkBoxPublisher.Text = "Search Publishers"
        Me.chkBoxPublisher.UseVisualStyleBackColor = True
        '
        'chkBoxPubDate
        '
        Me.chkBoxPubDate.AutoSize = True
        Me.chkBoxPubDate.Location = New System.Drawing.Point(224, 138)
        Me.chkBoxPubDate.Name = "chkBoxPubDate"
        Me.chkBoxPubDate.Size = New System.Drawing.Size(142, 17)
        Me.chkBoxPubDate.TabIndex = 13
        Me.chkBoxPubDate.Text = "Search Publishing Dates"
        Me.chkBoxPubDate.UseVisualStyleBackColor = True
        '
        'chkBoxTitle
        '
        Me.chkBoxTitle.AutoSize = True
        Me.chkBoxTitle.Location = New System.Drawing.Point(224, 85)
        Me.chkBoxTitle.Name = "chkBoxTitle"
        Me.chkBoxTitle.Size = New System.Drawing.Size(88, 17)
        Me.chkBoxTitle.TabIndex = 14
        Me.chkBoxTitle.Text = "Search Titles"
        Me.chkBoxTitle.UseVisualStyleBackColor = True
        '
        'chkBoxLoc
        '
        Me.chkBoxLoc.AutoSize = True
        Me.chkBoxLoc.Location = New System.Drawing.Point(224, 165)
        Me.chkBoxLoc.Name = "chkBoxLoc"
        Me.chkBoxLoc.Size = New System.Drawing.Size(109, 17)
        Me.chkBoxLoc.TabIndex = 15
        Me.chkBoxLoc.Text = "Search Locations"
        Me.chkBoxLoc.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Fishbits", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(369, 20)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(114, 163)
        Me.btnSearch.TabIndex = 16
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 227)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.lblInfoWelcome)
        Me.Controls.Add(Me.btnExit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formMain"
        Me.Text = "RoofDuck LibrarySystem"
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents lblInfoWelcome As Label
    Friend WithEvents grpSearch As GroupBox
    Friend WithEvents lblPubDate As Label
    Friend WithEvents lblPublisher As Label
    Friend WithEvents txtBoxLoc As TextBox
    Friend WithEvents txtBoxPubDate As TextBox
    Friend WithEvents txtBoxPublisher As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtBoxTitle As TextBox
    Friend WithEvents txtBoxAut As TextBox
    Friend WithEvents lblAut As Label
    Friend WithEvents lblSearchInfo As Label
    Friend WithEvents lblLoc As Label
    Friend WithEvents chkBoxLoc As CheckBox
    Friend WithEvents chkBoxPublisher As CheckBox
    Friend WithEvents chkBoxPubDate As CheckBox
    Friend WithEvents chkBoxTitle As CheckBox
    Friend WithEvents chkBoxAut As CheckBox
    Friend WithEvents btnSearch As Button
End Class
