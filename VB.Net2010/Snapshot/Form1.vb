Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbovideodevice As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnstart As System.Windows.Forms.Button
    Friend WithEvents cbovideoinput As System.Windows.Forms.ComboBox
    Friend WithEvents btnsnapshot As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbovideoformat As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents AxVideoCap1 As AxVIDEOCAPLib.AxVideoCap

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbovideodevice = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbovideoinput = New System.Windows.Forms.ComboBox
        Me.btnstart = New System.Windows.Forms.Button
        Me.btnsnapshot = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbovideoformat = New System.Windows.Forms.ComboBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.AxVideoCap1 = New AxVIDEOCAPLib.AxVideoCap
        CType(Me.AxVideoCap1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Video Device"
        '
        'cbovideodevice
        '
        Me.cbovideodevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovideodevice.Location = New System.Drawing.Point(136, 8)
        Me.cbovideodevice.Name = "cbovideodevice"
        Me.cbovideodevice.Size = New System.Drawing.Size(224, 21)
        Me.cbovideodevice.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Video Input"
        '
        'cbovideoinput
        '
        Me.cbovideoinput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovideoinput.Location = New System.Drawing.Point(136, 40)
        Me.cbovideoinput.Name = "cbovideoinput"
        Me.cbovideoinput.Size = New System.Drawing.Size(224, 21)
        Me.cbovideoinput.TabIndex = 3
        '
        'btnstart
        '
        Me.btnstart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstart.Location = New System.Drawing.Point(368, 72)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(96, 24)
        Me.btnstart.TabIndex = 4
        Me.btnstart.Text = "Preview"
        '
        'btnsnapshot
        '
        Me.btnsnapshot.Location = New System.Drawing.Point(16, 328)
        Me.btnsnapshot.Name = "btnsnapshot"
        Me.btnsnapshot.Size = New System.Drawing.Size(128, 24)
        Me.btnsnapshot.TabIndex = 7
        Me.btnsnapshot.Text = "Snapshot"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Video Format"
        '
        'cbovideoformat
        '
        Me.cbovideoformat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovideoformat.Location = New System.Drawing.Point(136, 72)
        Me.cbovideoformat.Name = "cbovideoformat"
        Me.cbovideoformat.Size = New System.Drawing.Size(224, 21)
        Me.cbovideoformat.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(336, 112)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(240, 184)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'AxVideoCap1
        '
        Me.AxVideoCap1.Enabled = True
        Me.AxVideoCap1.Location = New System.Drawing.Point(24, 112)
        Me.AxVideoCap1.Name = "AxVideoCap1"
        Me.AxVideoCap1.OcxState = CType(resources.GetObject("AxVideoCap1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVideoCap1.Size = New System.Drawing.Size(280, 192)
        Me.AxVideoCap1.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(592, 382)
        Me.Controls.Add(Me.AxVideoCap1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cbovideoformat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnsnapshot)
        Me.Controls.Add(Me.btnstart)
        Me.Controls.Add(Me.cbovideoinput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbovideodevice)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Snapshot sample"
        CType(Me.AxVideoCap1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        Dim i As Integer

        For i = 0 To AxVideoCap1.GetDeviceCount- 1
            cbovideodevice.Items.Add(AxVideoCap1.GetDeviceName(i))
        Next

        If cbovideodevice.Items.Count > 0 Then
            cbovideodevice.SelectedIndex = 0
        End If

        For i = 0 To AxVideoCap1.GetVideoInputCount - 1
            cbovideoinput.Items.Add(AxVideoCap1.GetVideoInputName(i))
        Next

        If cbovideoinput.Items.Count > 0 Then
            cbovideoinput.SelectedIndex = 0
        End If


        For i = 0 To AxVideoCap1.GetVideoFormatCount - 1
            cbovideoformat.Items.Add(AxVideoCap1.GetVideoFormatName(i))
        Next

        If cbovideoformat.Items.Count > 0 Then
            cbovideoformat.SelectedIndex = 0
        End If


    End Sub

    Private Sub btnstart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstart.Click
        AxVideoCap1.Device = cbovideodevice.SelectedIndex
        AxVideoCap1.VideoFormat = cbovideoformat.SelectedIndex
        AxVideoCap1.VideoInput = cbovideoinput.SelectedIndex
        AxVideoCap1.Start()
    End Sub

    Private Sub btnsnapshot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsnapshot.Click
        PictureBox1.Image = AxVideoCap1.SnapShot2Picture()

    End Sub

    Private Sub cbovideodevice_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbovideodevice.SelectedIndexChanged
        Dim i As Integer

        AxVideoCap1.Device = cbovideodevice.SelectedIndex

        cbovideoformat.Items.Clear()

        AxVideoCap1.RefreshVideoDevice(cbovideodevice.SelectedIndex)


        For i = 0 To AxVideoCap1.GetVideoInputCount - 1
            cbovideoinput.Items.Add(AxVideoCap1.GetVideoInputName(i))
        Next

        If cbovideoinput.Items.Count > 0 Then
            cbovideoinput.SelectedIndex = 0
        End If

        For i = 0 To AxVideoCap1.GetVideoFormatCount - 1
            cbovideoformat.Items.Add(AxVideoCap1.GetVideoFormatName(i))
        Next

        If cbovideoformat.Items.Count > 0 Then
            cbovideoformat.SelectedIndex = 0
        End If

    End Sub

  

   
End Class
