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
	Public WithEvents chkimageback As System.Windows.Forms.CheckBox
	Public WithEvents WMVProfileEditor1 As AxWMVPROFILEEDITORLib.AxWMVProfileEditor
	Public WithEvents chkcapturetowmv As System.Windows.Forms.CheckBox
	Public WithEvents Command3 As System.Windows.Forms.Button
	Public WithEvents txtalphaimage As System.Windows.Forms.TextBox
	Public WithEvents txtImage As System.Windows.Forms.TextBox
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox

	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents cboDevice As System.Windows.Forms.ComboBox
	Public WithEvents cbovideoformat As System.Windows.Forms.ComboBox
	Public WithEvents cboAudioDevice As System.Windows.Forms.ComboBox
	Public WithEvents cboaudioinput As System.Windows.Forms.ComboBox
	Public WithEvents txtalphavideo As System.Windows.Forms.TextBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents VideoCap1 As AxVIDEOCAPLib.AxVideoCap
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkimageback = New System.Windows.Forms.CheckBox()
        Me.WMVProfileEditor1 = New AxWMVPROFILEEDITORLib.AxWMVProfileEditor()
        Me.chkcapturetowmv = New System.Windows.Forms.CheckBox()
        Me.Command3 = New System.Windows.Forms.Button()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.txtalphaimage = New System.Windows.Forms.TextBox()
        Me.txtImage = New System.Windows.Forms.TextBox()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.cboDevice = New System.Windows.Forms.ComboBox()
        Me.cbovideoformat = New System.Windows.Forms.ComboBox()
        Me.cboAudioDevice = New System.Windows.Forms.ComboBox()
        Me.cboaudioinput = New System.Windows.Forms.ComboBox()
        Me.txtalphavideo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.VideoCap1 = New AxVIDEOCAPLib.AxVideoCap()
        CType(Me.WMVProfileEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.VideoCap1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkimageback
        '
        Me.chkimageback.BackColor = System.Drawing.SystemColors.Control
        Me.chkimageback.Checked = True
        Me.chkimageback.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkimageback.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkimageback.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkimageback.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkimageback.Location = New System.Drawing.Point(488, 232)
        Me.chkimageback.Name = "chkimageback"
        Me.chkimageback.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkimageback.Size = New System.Drawing.Size(288, 25)
        Me.chkimageback.TabIndex = 22
        Me.chkimageback.Text = "Image on background, video capture on foreground"
        Me.chkimageback.UseVisualStyleBackColor = False
        '
        'WMVProfileEditor1
        '
        Me.WMVProfileEditor1.Enabled = True
        Me.WMVProfileEditor1.Location = New System.Drawing.Point(728, 264)
        Me.WMVProfileEditor1.Name = "WMVProfileEditor1"
        Me.WMVProfileEditor1.OcxState = CType(resources.GetObject("WMVProfileEditor1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.WMVProfileEditor1.Size = New System.Drawing.Size(33, 33)
        Me.WMVProfileEditor1.TabIndex = 21
        '
        'chkcapturetowmv
        '
        Me.chkcapturetowmv.BackColor = System.Drawing.SystemColors.Control
        Me.chkcapturetowmv.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkcapturetowmv.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkcapturetowmv.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkcapturetowmv.Location = New System.Drawing.Point(488, 208)
        Me.chkcapturetowmv.Name = "chkcapturetowmv"
        Me.chkcapturetowmv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkcapturetowmv.Size = New System.Drawing.Size(137, 17)
        Me.chkcapturetowmv.TabIndex = 20
        Me.chkcapturetowmv.Text = "Capture to WMV 9"
        Me.chkcapturetowmv.UseVisualStyleBackColor = False
        '
        'Command3
        '
        Me.Command3.BackColor = System.Drawing.SystemColors.Control
        Me.Command3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command3.Location = New System.Drawing.Point(480, 336)
        Me.Command3.Name = "Command3"
        Me.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command3.Size = New System.Drawing.Size(216, 41)
        Me.Command3.TabIndex = 19
        Me.Command3.Text = "Stop"
        Me.Command3.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.txtalphaimage)
        Me.Frame2.Controls.Add(Me.txtImage)
        Me.Frame2.Controls.Add(Me.Command1)
        Me.Frame2.Controls.Add(Me.Label7)
        Me.Frame2.Controls.Add(Me.Label5)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(336, 8)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(449, 177)
        Me.Frame2.TabIndex = 13
        Me.Frame2.TabStop = False
        '
        'txtalphaimage
        '
        Me.txtalphaimage.AcceptsReturn = True
        Me.txtalphaimage.BackColor = System.Drawing.SystemColors.Window
        Me.txtalphaimage.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtalphaimage.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalphaimage.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtalphaimage.Location = New System.Drawing.Point(128, 72)
        Me.txtalphaimage.MaxLength = 0
        Me.txtalphaimage.Name = "txtalphaimage"
        Me.txtalphaimage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtalphaimage.Size = New System.Drawing.Size(65, 20)
        Me.txtalphaimage.TabIndex = 18
        Me.txtalphaimage.Text = "255"
        '
        'txtImage
        '
        Me.txtImage.AcceptsReturn = True
        Me.txtImage.BackColor = System.Drawing.SystemColors.Window
        Me.txtImage.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtImage.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImage.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtImage.Location = New System.Drawing.Point(8, 40)
        Me.txtImage.MaxLength = 0
        Me.txtImage.Name = "txtImage"
        Me.txtImage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtImage.Size = New System.Drawing.Size(361, 20)
        Me.txtImage.TabIndex = 15
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(368, 40)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(80, 25)
        Me.Command1.TabIndex = 14
        Me.Command1.Text = "Select Image"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(8, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(104, 25)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Alpha Value(0-255)"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(8, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(81, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Image"
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(480, 280)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(216, 41)
        Me.Command2.TabIndex = 1
        Me.Command2.Text = "Start Picture in Picture with moving effect"
        Me.Command2.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.cboDevice)
        Me.Frame1.Controls.Add(Me.cbovideoformat)
        Me.Frame1.Controls.Add(Me.cboAudioDevice)
        Me.Frame1.Controls.Add(Me.cboaudioinput)
        Me.Frame1.Controls.Add(Me.txtalphavideo)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.Label6)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 8)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(321, 177)
        Me.Frame1.TabIndex = 2
        Me.Frame1.TabStop = False
        '
        'cboDevice
        '
        Me.cboDevice.BackColor = System.Drawing.SystemColors.Window
        Me.cboDevice.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDevice.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDevice.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboDevice.Location = New System.Drawing.Point(104, 16)
        Me.cboDevice.Name = "cboDevice"
        Me.cboDevice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboDevice.Size = New System.Drawing.Size(209, 22)
        Me.cboDevice.TabIndex = 7
        '
        'cbovideoformat
        '
        Me.cbovideoformat.BackColor = System.Drawing.SystemColors.Window
        Me.cbovideoformat.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbovideoformat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovideoformat.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbovideoformat.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbovideoformat.Location = New System.Drawing.Point(104, 48)
        Me.cbovideoformat.Name = "cbovideoformat"
        Me.cbovideoformat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbovideoformat.Size = New System.Drawing.Size(209, 22)
        Me.cbovideoformat.TabIndex = 6
        '
        'cboAudioDevice
        '
        Me.cboAudioDevice.BackColor = System.Drawing.SystemColors.Window
        Me.cboAudioDevice.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboAudioDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAudioDevice.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAudioDevice.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboAudioDevice.Location = New System.Drawing.Point(104, 80)
        Me.cboAudioDevice.Name = "cboAudioDevice"
        Me.cboAudioDevice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboAudioDevice.Size = New System.Drawing.Size(209, 22)
        Me.cboAudioDevice.TabIndex = 5
        '
        'cboaudioinput
        '
        Me.cboaudioinput.BackColor = System.Drawing.SystemColors.Window
        Me.cboaudioinput.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboaudioinput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboaudioinput.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboaudioinput.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboaudioinput.Location = New System.Drawing.Point(104, 112)
        Me.cboaudioinput.Name = "cboaudioinput"
        Me.cboaudioinput.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboaudioinput.Size = New System.Drawing.Size(209, 22)
        Me.cboaudioinput.TabIndex = 4
        '
        'txtalphavideo
        '
        Me.txtalphavideo.AcceptsReturn = True
        Me.txtalphavideo.BackColor = System.Drawing.SystemColors.Window
        Me.txtalphavideo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtalphavideo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalphavideo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtalphavideo.Location = New System.Drawing.Point(120, 144)
        Me.txtalphavideo.MaxLength = 0
        Me.txtalphavideo.Name = "txtalphavideo"
        Me.txtalphavideo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtalphavideo.Size = New System.Drawing.Size(65, 20)
        Me.txtalphavideo.TabIndex = 3
        Me.txtalphavideo.Text = "255"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Video Device"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Video Format"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Audio Device"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Audio Input"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(8, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(104, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Alpha Value(0-255)"
        '
        'VideoCap1
        '
        Me.VideoCap1.Enabled = True
        Me.VideoCap1.Location = New System.Drawing.Point(30, 215)
        Me.VideoCap1.Name = "VideoCap1"
        Me.VideoCap1.OcxState = CType(resources.GetObject("VideoCap1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.VideoCap1.Size = New System.Drawing.Size(418, 334)
        Me.VideoCap1.TabIndex = 23
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(787, 633)
        Me.Controls.Add(Me.VideoCap1)
        Me.Controls.Add(Me.chkimageback)
        Me.Controls.Add(Me.WMVProfileEditor1)
        Me.Controls.Add(Me.chkcapturetowmv)
        Me.Controls.Add(Me.Command3)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Picture in Picture Video Capture + Image"
        CType(Me.WMVProfileEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.VideoCap1, System.ComponentModel.ISupportInitialize).EndInit()
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
        Set(ByVal value As Form1)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region
    Dim tmpWMVFilePath As String

    Sub WMV9ProfileSetting()
        Dim iLangIndex As Integer
        Dim iAudioFormatIndex As Integer
        Dim iAudioCodecIndex As Integer
        Dim iVideoCodecIndex As Integer


        iVideoCodecIndex = WMVProfileEditor1.FindVideoCodec("Windows Media Video 9")



        If iVideoCodecIndex = -1 Then
            iVideoCodecIndex = 0
        End If



        iAudioCodecIndex = WMVProfileEditor1.FindAudioCodec("Windows Media Audio 9.2")



        If iAudioCodecIndex = -1 Then
            iAudioCodecIndex = 0
        End If


        iAudioFormatIndex = WMVProfileEditor1.FindAudioFormat("160 kbps, 44 kHz, stereo CBR")


        If iAudioFormatIndex = -1 Then
            iAudioFormatIndex = 0
        End If

        'english
        iLangIndex = 34

        '2500kbps
        WMVProfileEditor1.AddVideoStream(iVideoCodecIndex, 500000, 100, 720, 480, 15, 1, 0, 0, 0, 500000, 0, False, iLangIndex)

        If cboAudioDevice.Items.Count > 0 Then
            WMVProfileEditor1.AddAudioStream(iAudioCodecIndex, iAudioFormatIndex, 3000, False, iLangIndex)
        End If


        tmpWMVFilePath = WMVProfileEditor1.GetTempPath

        tmpWMVFilePath = tmpWMVFilePath & "\temp.prx"

        WMVProfileEditor1.Save("test", "", tmpWMVFilePath)



    End Sub

    Private Sub cboAudioDevice_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAudioDevice.Click
        Dim i As Integer
        cboaudioinput.Items.Clear()

        VideoCap1.RefreshAudioInputPin(cboAudioDevice.SelectedIndex)

        For i = 0 To VideoCap1.GetAudioInputPinCount - 1
            cboaudioinput.Items.Add(VideoCap1.GetAudioInputPinName(i))
        Next

            If cboaudioinput.Items.Count > 0 Then
                cboaudioinput.SelectedIndex = 0
            End If

    End Sub



    Private Sub cboAudioDevice_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboAudioDevice.SelectedIndexChanged
        
    End Sub

    Private Sub cboDevice_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDevice.Click
        Dim i As Integer
        cbovideoformat.Items.Clear()


        VideoCap1.RefreshVideoDevice(cboDevice.SelectedIndex)



        For i = 0 To VideoCap1.GetVideoFormatCount - 1
            cbovideoformat.Items.Add(VideoCap1.GetVideoFormatName(i))
        Next

        If cbovideoformat.Items.Count > 0 Then
            cbovideoformat.SelectedIndex = 0
        End If

    End Sub

    Private Sub cboDevice_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDevice.SelectedIndexChanged
        
    End Sub

    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        OpenFileDialog1.Filter = "Bitmap File (*.bmp)|*.bmp|JPEG File (*.jpg)|*.jpg|TGA File (*.tga)|*.tga"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtImage.Text = OpenFileDialog1.FileName

        End If


    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
        Dim bresult As Object

        If txtImage.Text = "" Then

            MessageBox.Show("Please input image file")
            Exit Sub

        End If

        If chkcapturetowmv.Checked Then

            Me.VideoCap1.AudioDevice = cbovideoformat.SelectedIndex
            Me.VideoCap1.AudioInputPin = cboaudioinput.SelectedIndex

            SaveFileDialog1.Filter = "WMV File (*.wmv)|*.wmv"
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

                Me.VideoCap1.CaptureMode = True
                WMV9ProfileSetting()
                Me.VideoCap1.OutputWMV = True

                Me.VideoCap1.CaptureFileName = Me.SaveFileDialog1.FileName
                Me.VideoCap1.WMVCustomFileName = tmpWMVFilePath
            End If

        Else
            Me.VideoCap1.CaptureMode = False

        End If


        Me.VideoCap1.PIPInitDisplayArea(640, 480)


        If chkimageback.Checked Then


            bresult = Me.VideoCap1.PIPAddImage(txtImage.Text, 0, CShort(txtalphaimage.Text))
            If bresult <> True Then
                MessageBox.Show("failed")
            End If


            Me.VideoCap1.PIPAddPIPEffect(0, 9999, 0, 0, 640, 480)

            bresult = Me.VideoCap1.PIPAddVideoDevice(cboDevice.SelectedIndex, cbovideoformat.SelectedIndex, 0, CShort(txtalphavideo.Text))

            If bresult <> True Then
                MessageBox.Show("failed")
            End If

            MovingEffects()
            Me.VideoCap1.PIPAddPIPEffect(0, 9999, 0, 0, 320, 240)


        Else

            bresult = Me.VideoCap1.PIPAddVideoDevice(cboDevice.SelectedIndex, cbovideoformat.SelectedIndex, 0, CShort(txtalphavideo.Text))
            If bresult <> True Then
                MessageBox.Show("failed")
            End If

            Me.VideoCap1.PIPAddPIPEffect(0, 9999, 0, 0, 640, 480)

            bresult = Me.VideoCap1.PIPAddImage(txtImage.Text, 0, CShort(txtalphaimage.Text))
            If bresult <> True Then
                MessageBox.Show("failed")
            End If

            MovingEffects()
            Me.VideoCap1.PIPAddPIPEffect(0, 9999, 0, 0, 320, 240)


        End If



        Me.VideoCap1.PIPStart()


    End Sub

    Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
        VideoCap1.PIPStop()
    End Sub

    Sub MovingEffects()
        Dim iX As Integer
        Dim iY As Integer

        Me.VideoCap1.PIPChangePos(1, 0, 0, 320, 240)
        Me.VideoCap1.PIPChangePos(2, 100, 0, 320, 240)
        Me.VideoCap1.PIPChangePos(3, 200, 0, 320, 240)
        Me.VideoCap1.PIPChangePos(4, 300, 0, 320, 240)
        Me.VideoCap1.PIPChangePos(5, 400, 0, 320, 240)
        Me.VideoCap1.PIPChangePos(6, 500, 0, 320, 240)
        Me.VideoCap1.PIPChangePos(7, 600, 0, 320, 240)
        Me.VideoCap1.PIPChangePos(8, 700, 0, 320, 240)
        Me.VideoCap1.PIPChangePos(9, 0, 240, 320, 240)
        Me.VideoCap1.PIPChangePos(12, 0, 300, 0, 0)



        iX = 320 - 320 / 2
        iY = 240 - 240 / 2

        Me.VideoCap1.PIPChangePos(13, iX, iY, 320, 240)

    End Sub

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        VideoCap1.Stop()
    End Sub

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim i As Integer

        For i = 0 To VideoCap1.GetDeviceCount - 1
            cboDevice.Items.Add(VideoCap1.GetDeviceName(i))
        Next

        If cboDevice.Items.Count > 0 Then
            cboDevice.SelectedIndex = 0
        End If

        For i = 0 To VideoCap1.GetAudioDeviceCount - 1
            cboAudioDevice.Items.Add(VideoCap1.GetAudioDeviceName(i))
        Next



        cboAudioDevice.SelectedIndex = 0


        For i = 0 To VideoCap1.GetVideoFormatCount - 1
            cbovideoformat.Items.Add(VideoCap1.GetVideoFormatName(i))
        Next

        If cbovideoformat.Items.Count > 0 Then
            cbovideoformat.SelectedIndex = 0
        End If

        For i = 0 To VideoCap1.GetAudioInputPinCount - 1
            cboaudioinput.Items.Add(VideoCap1.GetAudioInputPinName(i))
        Next
        If cboaudioinput.Items.Count > 0 Then
            cboaudioinput.SelectedIndex = 0
        End If


    End Sub

     Private Sub Form1_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        Me.WMVProfileEditor1.DeleteTempFile(tmpWMVFilePath)
    End Sub

    Private Sub VideoCap1_Capturing(ByVal sender As System.Object, ByVal e As AxVIDEOCAPLib._DVideoCapEvents_CapturingEvent)

    End Sub
End Class