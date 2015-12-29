Option Strict Off
Option Explicit On
Friend Class Form1
	Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
		If m_vb6FormDefInstance Is Nothing Then
			If m_InitializingDefInstance Then
				m_vb6FormDefInstance = Me
			Else
				Try 
					'For the start-up form, the first instance created is the default instance.
					If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
						m_vb6FormDefInstance = Me
					End If
				Catch
				End Try
			End If
		End If
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents List1 As System.Windows.Forms.ListBox
	Public WithEvents Option3 As System.Windows.Forms.RadioButton
	Public WithEvents Option2 As System.Windows.Forms.RadioButton
	Public WithEvents Option1 As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cbovideoformat As System.Windows.Forms.ComboBox
	Public WithEvents cbovideodevice As System.Windows.Forms.ComboBox
	Public WithEvents Command1 As System.Windows.Forms.Button
    Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents AxVideoCap1 As AxVIDEOCAPLib.AxVideoCap
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Command2 = New System.Windows.Forms.Button()
        Me.List1 = New System.Windows.Forms.ListBox()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Option3 = New System.Windows.Forms.RadioButton()
        Me.Option2 = New System.Windows.Forms.RadioButton()
        Me.Option1 = New System.Windows.Forms.RadioButton()
        Me.cbovideoformat = New System.Windows.Forms.ComboBox()
        Me.cbovideodevice = New System.Windows.Forms.ComboBox()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AxVideoCap1 = New AxVIDEOCAPLib.AxVideoCap()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Frame1.SuspendLayout()
        CType(Me.AxVideoCap1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(440, 24)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(81, 33)
        Me.Command2.TabIndex = 12
        Me.Command2.Text = "Stop"
        Me.Command2.UseVisualStyleBackColor = False
        '
        'List1
        '
        Me.List1.BackColor = System.Drawing.SystemColors.Window
        Me.List1.Cursor = System.Windows.Forms.Cursors.Default
        Me.List1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.List1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.List1.ItemHeight = 14
        Me.List1.Location = New System.Drawing.Point(304, 120)
        Me.List1.Name = "List1"
        Me.List1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.List1.Size = New System.Drawing.Size(241, 60)
        Me.List1.TabIndex = 10
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.Option3)
        Me.Frame1.Controls.Add(Me.Option2)
        Me.Frame1.Controls.Add(Me.Option1)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(16, 88)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(265, 113)
        Me.Frame1.TabIndex = 6
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "frame grabber"
        '
        'Option3
        '
        Me.Option3.BackColor = System.Drawing.SystemColors.Control
        Me.Option3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Option3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Option3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Option3.Location = New System.Drawing.Point(24, 72)
        Me.Option3.Name = "Option3"
        Me.Option3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Option3.Size = New System.Drawing.Size(97, 17)
        Me.Option3.TabIndex = 9
        Me.Option3.TabStop = True
        Me.Option3.Text = "To Clipboard"
        Me.Option3.UseVisualStyleBackColor = False
        '
        'Option2
        '
        Me.Option2.BackColor = System.Drawing.SystemColors.Control
        Me.Option2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Option2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Option2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Option2.Location = New System.Drawing.Point(24, 40)
        Me.Option2.Name = "Option2"
        Me.Option2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Option2.Size = New System.Drawing.Size(159, 25)
        Me.Option2.TabIndex = 8
        Me.Option2.TabStop = True
        Me.Option2.Text = "To Bitmap Handle"
        Me.Option2.UseVisualStyleBackColor = False
        '
        'Option1
        '
        Me.Option1.BackColor = System.Drawing.SystemColors.Control
        Me.Option1.Checked = True
        Me.Option1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Option1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Option1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Option1.Location = New System.Drawing.Point(24, 16)
        Me.Option1.Name = "Option1"
        Me.Option1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Option1.Size = New System.Drawing.Size(105, 25)
        Me.Option1.TabIndex = 7
        Me.Option1.TabStop = True
        Me.Option1.Text = "To Picture Box"
        Me.Option1.UseVisualStyleBackColor = False
        '
        'cbovideoformat
        '
        Me.cbovideoformat.BackColor = System.Drawing.SystemColors.Window
        Me.cbovideoformat.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbovideoformat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovideoformat.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbovideoformat.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbovideoformat.Location = New System.Drawing.Point(120, 48)
        Me.cbovideoformat.Name = "cbovideoformat"
        Me.cbovideoformat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbovideoformat.Size = New System.Drawing.Size(225, 22)
        Me.cbovideoformat.TabIndex = 5
        '
        'cbovideodevice
        '
        Me.cbovideodevice.BackColor = System.Drawing.SystemColors.Window
        Me.cbovideodevice.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbovideodevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovideodevice.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbovideodevice.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbovideodevice.Location = New System.Drawing.Point(120, 16)
        Me.cbovideodevice.Name = "cbovideodevice"
        Me.cbovideodevice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbovideodevice.Size = New System.Drawing.Size(225, 22)
        Me.cbovideodevice.TabIndex = 3
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(352, 24)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(81, 33)
        Me.Command1.TabIndex = 1
        Me.Command1.Text = "Start"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(304, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(113, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Recieved Sample"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(89, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Video Format"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(89, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Video Device"
        '
        'AxVideoCap1
        '
        Me.AxVideoCap1.Enabled = True
        Me.AxVideoCap1.Location = New System.Drawing.Point(24, 208)
        Me.AxVideoCap1.Name = "AxVideoCap1"
        Me.AxVideoCap1.OcxState = CType(resources.GetObject("AxVideoCap1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVideoCap1.Size = New System.Drawing.Size(296, 240)
        Me.AxVideoCap1.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(356, 220)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(308, 228)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(4, 11)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(710, 482)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.AxVideoCap1)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.List1)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cbovideoformat)
        Me.Controls.Add(Me.cbovideodevice)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Frame Grabber"
        Me.Frame1.ResumeLayout(False)
        CType(Me.AxVideoCap1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As Form1
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As Form1
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New Form1()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(value As Form1)
            m_vb6FormDefInstance = value
        End Set
    End Property
#End Region
    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        AxVideoCap1.Device = cbovideodevice.SelectedIndex
        AxVideoCap1.VideoFormat = cbovideoformat.SelectedIndex

        AxVideoCap1.Start()


    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
        AxVideoCap1.Stop()
    End Sub

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim i As Integer


        AxVideoCap1.SampleBufferMode = 4

        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

        For i = 0 To AxVideoCap1.GetDeviceCount - 1
            cbovideodevice.Items.Add(AxVideoCap1.GetDeviceName(i))
        Next

        If cbovideodevice.Items.Count > 0 Then
            cbovideodevice.SelectedIndex = 0
        End If



        For i = 0 To AxVideoCap1.GetVideoFormatCount - 1
            cbovideoformat.Items.Add(AxVideoCap1.GetVideoFormatName(i))
        Next


        If cbovideoformat.Items.Count > 0 Then
            cbovideoformat.SelectedIndex = 0
        End If





    End Sub




    Private Sub Option1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Option1.Click
        AxVideoCap1.SampleBufferMode = 4
    End Sub

    Private Sub Option2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Option2.Click
        AxVideoCap1.SampleBufferMode = 5
    End Sub

    Private Sub Option3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Option3.Click
        AxVideoCap1.SampleBufferMode = 2
    End Sub

    Private Sub AxVideoCap1_Capturing(ByVal sender As System.Object, ByVal e As AxVIDEOCAPLib._DVideoCapEvents_CapturingEvent) Handles AxVideoCap1.Capturing

    End Sub



    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        AxVideoCap1.Stop()
    End Sub



    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub AxVideoCap1_SampleBuffer2(sender As Object, e As AxVIDEOCAPLib._DVideoCapEvents_SampleBuffer2Event) Handles AxVideoCap1.SampleBuffer2
        List1.Items.Add(Str(e.iwidth) & "x" & Str(e.iheight) & " resolution sample received")

        If AxVideoCap1.SampleBufferMode = 4 Then
            PictureBox1.Image = AxVideoCap1.SampleBuffer2Picture
            AxVideoCap1.DeleteSampleBufferPicture()
        End If

        If AxVideoCap1.SampleBufferMode = 5 Then

            Dim myImage As Image
            Dim iHandle As Long

            iHandle = AxVideoCap1.SampleBuffer2HBITMAP()
            myImage = Image.FromHbitmap(iHandle)

            PictureBox1.Image = myImage
            AxVideoCap1.DeleteImageHandle(iHandle)

        End If

    End Sub

    Private Sub Option1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Option1.CheckedChanged

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class