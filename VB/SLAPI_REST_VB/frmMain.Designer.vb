<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.cmbDropDown = New System.Windows.Forms.ComboBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnPut = New System.Windows.Forms.Button()
        Me.btnPost = New System.Windows.Forms.Button()
        Me.btnGet = New System.Windows.Forms.Button()
        Me.txtResponse = New System.Windows.Forms.TextBox()
        Me.txtPostVars = New System.Windows.Forms.TextBox()
        Me.rdoObjectMask = New System.Windows.Forms.RadioButton()
        Me.rdoPost = New System.Windows.Forms.RadioButton()
        Me.rdoGet = New System.Windows.Forms.RadioButton()
        Me.txtEndPoint = New System.Windows.Forms.TextBox()
        Me.txtApiUrl = New System.Windows.Forms.TextBox()
        Me.txtApiKey = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbDropDown
        '
        Me.cmbDropDown.FormattingEnabled = True
        Me.cmbDropDown.Items.AddRange(New Object() {"XML Mode", "JSON Mode"})
        Me.cmbDropDown.Location = New System.Drawing.Point(113, 403)
        Me.cmbDropDown.Name = "cmbDropDown"
        Me.cmbDropDown.Size = New System.Drawing.Size(135, 21)
        Me.cmbDropDown.TabIndex = 41
        Me.cmbDropDown.Text = "XML Mode"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(542, 399)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(79, 27)
        Me.btnDelete.TabIndex = 40
        Me.btnDelete.Text = "Http Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnPut
        '
        Me.btnPut.Location = New System.Drawing.Point(457, 399)
        Me.btnPut.Name = "btnPut"
        Me.btnPut.Size = New System.Drawing.Size(79, 27)
        Me.btnPut.TabIndex = 39
        Me.btnPut.Text = "Http Put"
        Me.btnPut.UseVisualStyleBackColor = True
        '
        'btnPost
        '
        Me.btnPost.Location = New System.Drawing.Point(372, 399)
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(79, 27)
        Me.btnPost.TabIndex = 38
        Me.btnPost.Text = "Http Post"
        Me.btnPost.UseVisualStyleBackColor = True
        '
        'btnGet
        '
        Me.btnGet.Location = New System.Drawing.Point(287, 399)
        Me.btnGet.Name = "btnGet"
        Me.btnGet.Size = New System.Drawing.Size(79, 27)
        Me.btnGet.TabIndex = 37
        Me.btnGet.Text = "Http Get"
        Me.btnGet.UseVisualStyleBackColor = True
        '
        'txtResponse
        '
        Me.txtResponse.Location = New System.Drawing.Point(109, 439)
        Me.txtResponse.Multiline = True
        Me.txtResponse.Name = "txtResponse"
        Me.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtResponse.Size = New System.Drawing.Size(512, 160)
        Me.txtResponse.TabIndex = 36
        Me.txtResponse.WordWrap = False
        '
        'txtPostVars
        '
        Me.txtPostVars.Location = New System.Drawing.Point(111, 221)
        Me.txtPostVars.Multiline = True
        Me.txtPostVars.Name = "txtPostVars"
        Me.txtPostVars.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtPostVars.Size = New System.Drawing.Size(512, 160)
        Me.txtPostVars.TabIndex = 35
        Me.txtPostVars.WordWrap = False
        '
        'rdoObjectMask
        '
        Me.rdoObjectMask.AutoSize = True
        Me.rdoObjectMask.Location = New System.Drawing.Point(313, 173)
        Me.rdoObjectMask.Name = "rdoObjectMask"
        Me.rdoObjectMask.Size = New System.Drawing.Size(121, 17)
        Me.rdoObjectMask.TabIndex = 34
        Me.rdoObjectMask.Text = "Servers On Account"
        Me.rdoObjectMask.UseVisualStyleBackColor = True
        '
        'rdoPost
        '
        Me.rdoPost.AutoSize = True
        Me.rdoPost.Location = New System.Drawing.Point(544, 173)
        Me.rdoPost.Name = "rdoPost"
        Me.rdoPost.Size = New System.Drawing.Size(80, 17)
        Me.rdoPost.TabIndex = 33
        Me.rdoPost.Text = "New Ticket"
        Me.rdoPost.UseVisualStyleBackColor = True
        '
        'rdoGet
        '
        Me.rdoGet.AutoSize = True
        Me.rdoGet.Checked = True
        Me.rdoGet.Location = New System.Drawing.Point(109, 171)
        Me.rdoGet.Name = "rdoGet"
        Me.rdoGet.Size = New System.Drawing.Size(140, 17)
        Me.rdoGet.TabIndex = 32
        Me.rdoGet.TabStop = True
        Me.rdoGet.Text = "Recently Closed Tickets"
        Me.rdoGet.UseVisualStyleBackColor = True
        '
        'txtEndPoint
        '
        Me.txtEndPoint.Location = New System.Drawing.Point(109, 134)
        Me.txtEndPoint.Name = "txtEndPoint"
        Me.txtEndPoint.Size = New System.Drawing.Size(515, 20)
        Me.txtEndPoint.TabIndex = 31
        '
        'txtApiUrl
        '
        Me.txtApiUrl.Location = New System.Drawing.Point(109, 101)
        Me.txtApiUrl.Name = "txtApiUrl"
        Me.txtApiUrl.Size = New System.Drawing.Size(515, 20)
        Me.txtApiUrl.TabIndex = 30
        Me.txtApiUrl.Text = "https://api.softlayer.com/rest/v3"
        '
        'txtApiKey
        '
        Me.txtApiKey.Location = New System.Drawing.Point(109, 60)
        Me.txtApiKey.Name = "txtApiKey"
        Me.txtApiKey.Size = New System.Drawing.Size(515, 20)
        Me.txtApiKey.TabIndex = 29
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(109, 24)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(515, 20)
        Me.txtUserName.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 439)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Response:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Post Vars:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Examples:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "End Point:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Api Url:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Api Key:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Username:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 615)
        Me.Controls.Add(Me.cmbDropDown)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnPut)
        Me.Controls.Add(Me.btnPost)
        Me.Controls.Add(Me.btnGet)
        Me.Controls.Add(Me.txtResponse)
        Me.Controls.Add(Me.txtPostVars)
        Me.Controls.Add(Me.rdoObjectMask)
        Me.Controls.Add(Me.rdoPost)
        Me.Controls.Add(Me.rdoGet)
        Me.Controls.Add(Me.txtEndPoint)
        Me.Controls.Add(Me.txtApiUrl)
        Me.Controls.Add(Me.txtApiKey)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "SLAPI Example of REST Interface"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbDropDown As System.Windows.Forms.ComboBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnPut As System.Windows.Forms.Button
    Friend WithEvents btnPost As System.Windows.Forms.Button
    Friend WithEvents btnGet As System.Windows.Forms.Button
    Friend WithEvents txtResponse As System.Windows.Forms.TextBox
    Friend WithEvents txtPostVars As System.Windows.Forms.TextBox
    Friend WithEvents rdoObjectMask As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPost As System.Windows.Forms.RadioButton
    Friend WithEvents rdoGet As System.Windows.Forms.RadioButton
    Friend WithEvents txtEndPoint As System.Windows.Forms.TextBox
    Friend WithEvents txtApiUrl As System.Windows.Forms.TextBox
    Friend WithEvents txtApiKey As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
