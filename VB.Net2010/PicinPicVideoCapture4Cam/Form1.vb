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
	Public WithEvents txtalphavideo2 As System.Windows.Forms.TextBox
	Public WithEvents cbovideoformat2 As System.Windows.Forms.ComboBox
	Public WithEvents cboDevice2 As System.Windows.Forms.ComboBox
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents WMVProfileEditor1 As AxWMVPROFILEEDITORLib.AxWMVProfileEditor
	Public WithEvents chkcapturetowmv As System.Windows.Forms.CheckBox
	Public WithEvents Command3 As System.Windows.Forms.Button
    Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents VideoCap1 As AxVIDEOCAPLib.AxVideoCap
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
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents txtalphavideo3 As System.Windows.Forms.TextBox
    Public WithEvents cbovideoformat3 As System.Windows.Forms.ComboBox
    Public WithEvents cboDevice3 As System.Windows.Forms.ComboBox
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Public WithEvents txtalphavideo4 As System.Windows.Forms.TextBox
    Public WithEvents cbovideoformat4 As System.Windows.Forms.ComboBox
    Public WithEvents cboDevice4 As System.Windows.Forms.ComboBox
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents Label14 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.txtalphavideo2 = New System.Windows.Forms.TextBox()
        Me.cbovideoformat2 = New System.Windows.Forms.ComboBox()
        Me.cboDevice2 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.WMVProfileEditor1 = New AxWMVPROFILEEDITORLib.AxWMVProfileEditor()
        Me.chkcapturetowmv = New System.Windows.Forms.CheckBox()
        Me.Command3 = New System.Windows.Forms.Button()
        Me.Command2 = New System.Windows.Forms.Button()
        Me.VideoCap1 = New AxVIDEOCAPLib.AxVideoCap()
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
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtalphavideo3 = New System.Windows.Forms.TextBox()
        Me.cbovideoformat3 = New System.Windows.Forms.ComboBox()
        Me.cboDevice3 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtalphavideo4 = New System.Windows.Forms.TextBox()
        Me.cbovideoformat4 = New System.Windows.Forms.ComboBox()
        Me.cboDevice4 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Frame2.SuspendLayout()
        CType(Me.WMVProfileEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VideoCap1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.txtalphavideo2)
        Me.Frame2.Controls.Add(Me.cbovideoformat2)
        Me.Frame2.Controls.Add(Me.cboDevice2)
        Me.Frame2.Controls.Add(Me.Label10)
        Me.Frame2.Controls.Add(Me.Label7)
        Me.Frame2.Controls.Add(Me.Label5)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(344, 8)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(328, 177)
        Me.Frame2.TabIndex = 17
        Me.Frame2.TabStop = False
        '
        'txtalphavideo2
        '
        Me.txtalphavideo2.AcceptsReturn = True
        Me.txtalphavideo2.BackColor = System.Drawing.SystemColors.Window
        Me.txtalphavideo2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtalphavideo2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalphavideo2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtalphavideo2.Location = New System.Drawing.Point(112, 80)
        Me.txtalphavideo2.MaxLength = 0
        Me.txtalphavideo2.Name = "txtalphavideo2"
        Me.txtalphavideo2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtalphavideo2.Size = New System.Drawing.Size(65, 20)
        Me.txtalphavideo2.TabIndex = 20
        Me.txtalphavideo2.Text = "255"
        '
        'cbovideoformat2
        '
        Me.cbovideoformat2.BackColor = System.Drawing.SystemColors.Window
        Me.cbovideoformat2.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbovideoformat2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovideoformat2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbovideoformat2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbovideoformat2.Location = New System.Drawing.Point(112, 48)
        Me.cbovideoformat2.Name = "cbovideoformat2"
        Me.cbovideoformat2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbovideoformat2.Size = New System.Drawing.Size(209, 22)
        Me.cbovideoformat2.TabIndex = 19
        '
        'cboDevice2
        '
        Me.cboDevice2.BackColor = System.Drawing.SystemColors.Window
        Me.cboDevice2.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboDevice2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDevice2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDevice2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboDevice2.Location = New System.Drawing.Point(112, 16)
        Me.cboDevice2.Name = "cboDevice2"
        Me.cboDevice2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboDevice2.Size = New System.Drawing.Size(209, 22)
        Me.cboDevice2.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(8, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(112, 17)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Alpha Value(0-255)"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(8, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(73, 17)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Video Format"
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
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Video Device"
        '
        'WMVProfileEditor1
        '
        Me.WMVProfileEditor1.Enabled = True
        Me.WMVProfileEditor1.Location = New System.Drawing.Point(632, 255)
        Me.WMVProfileEditor1.Name = "WMVProfileEditor1"
        Me.WMVProfileEditor1.OcxState = CType(resources.GetObject("WMVProfileEditor1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.WMVProfileEditor1.Size = New System.Drawing.Size(33, 33)
        Me.WMVProfileEditor1.TabIndex = 15
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
        Me.chkcapturetowmv.TabIndex = 14
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
        Me.Command3.Size = New System.Drawing.Size(137, 41)
        Me.Command3.TabIndex = 13
        Me.Command3.Text = "Stop"
        Me.Command3.UseVisualStyleBackColor = False
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
        Me.Command2.Size = New System.Drawing.Size(137, 41)
        Me.Command2.TabIndex = 1
        Me.Command2.Text = "Start Picture in Picture"
        Me.Command2.UseVisualStyleBackColor = False
        '
        'VideoCap1
        '
        Me.VideoCap1.Enabled = True
        Me.VideoCap1.Location = New System.Drawing.Point(8, 192)
        Me.VideoCap1.Name = "VideoCap1"
        Me.VideoCap1.OcxState = CType(resources.GetObject("VideoCap1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.VideoCap1.Size = New System.Drawing.Size(465, 377)
        Me.VideoCap1.TabIndex = 0
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.txtalphavideo3)
        Me.GroupBox1.Controls.Add(Me.cbovideoformat3)
        Me.GroupBox1.Controls.Add(Me.cboDevice3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(688, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(328, 177)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'txtalphavideo3
        '
        Me.txtalphavideo3.AcceptsReturn = True
        Me.txtalphavideo3.BackColor = System.Drawing.SystemColors.Window
        Me.txtalphavideo3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtalphavideo3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalphavideo3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtalphavideo3.Location = New System.Drawing.Point(112, 80)
        Me.txtalphavideo3.MaxLength = 0
        Me.txtalphavideo3.Name = "txtalphavideo3"
        Me.txtalphavideo3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtalphavideo3.Size = New System.Drawing.Size(65, 20)
        Me.txtalphavideo3.TabIndex = 20
        Me.txtalphavideo3.Text = "255"
        '
        'cbovideoformat3
        '
        Me.cbovideoformat3.BackColor = System.Drawing.SystemColors.Window
        Me.cbovideoformat3.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbovideoformat3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovideoformat3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbovideoformat3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbovideoformat3.Location = New System.Drawing.Point(112, 48)
        Me.cbovideoformat3.Name = "cbovideoformat3"
        Me.cbovideoformat3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbovideoformat3.Size = New System.Drawing.Size(209, 22)
        Me.cbovideoformat3.TabIndex = 19
        '
        'cboDevice3
        '
        Me.cboDevice3.BackColor = System.Drawing.SystemColors.Window
        Me.cboDevice3.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboDevice3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDevice3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDevice3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboDevice3.Location = New System.Drawing.Point(112, 16)
        Me.cboDevice3.Name = "cboDevice3"
        Me.cboDevice3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboDevice3.Size = New System.Drawing.Size(209, 22)
        Me.cboDevice3.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(8, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(112, 17)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Alpha Value(0-255)"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(8, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(73, 17)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Video Format"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(8, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(81, 17)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Video Device"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.txtalphavideo4)
        Me.GroupBox2.Controls.Add(Me.cbovideoformat4)
        Me.GroupBox2.Controls.Add(Me.cboDevice4)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(688, 208)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(328, 177)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'txtalphavideo4
        '
        Me.txtalphavideo4.AcceptsReturn = True
        Me.txtalphavideo4.BackColor = System.Drawing.SystemColors.Window
        Me.txtalphavideo4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtalphavideo4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalphavideo4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtalphavideo4.Location = New System.Drawing.Point(112, 80)
        Me.txtalphavideo4.MaxLength = 0
        Me.txtalphavideo4.Name = "txtalphavideo4"
        Me.txtalphavideo4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtalphavideo4.Size = New System.Drawing.Size(65, 20)
        Me.txtalphavideo4.TabIndex = 20
        Me.txtalphavideo4.Text = "255"
        '
        'cbovideoformat4
        '
        Me.cbovideoformat4.BackColor = System.Drawing.SystemColors.Window
        Me.cbovideoformat4.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbovideoformat4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovideoformat4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbovideoformat4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbovideoformat4.Location = New System.Drawing.Point(112, 48)
        Me.cbovideoformat4.Name = "cbovideoformat4"
        Me.cbovideoformat4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbovideoformat4.Size = New System.Drawing.Size(209, 22)
        Me.cbovideoformat4.TabIndex = 19
        '
        'cboDevice4
        '
        Me.cboDevice4.BackColor = System.Drawing.SystemColors.Window
        Me.cboDevice4.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboDevice4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDevice4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDevice4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboDevice4.Location = New System.Drawing.Point(112, 16)
        Me.cboDevice4.Name = "cboDevice4"
        Me.cboDevice4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboDevice4.Size = New System.Drawing.Size(209, 22)
        Me.cboDevice4.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(8, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(112, 17)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Alpha Value(0-255)"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(8, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(73, 17)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Video Format"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(8, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(81, 17)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Video Device"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1128, 633)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.WMVProfileEditor1)
        Me.Controls.Add(Me.chkcapturetowmv)
        Me.Controls.Add(Me.Command3)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.VideoCap1)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "4 cams Picture in Picture Video Capture "
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        CType(Me.WMVProfileEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VideoCap1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
		Set
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
	
	
	
    Private Sub cboAudioDevice_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboAudioDevice.SelectedIndexChanged
        ' Dim myAudioInput As Object
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

    Private Sub cboAudioDevice2_Click()
        ' Dim myAudioInput2 As Object
        Dim cboAudioDevice2 As Object
        Dim cboaudioinput2 As Object
        Dim i As Integer
        cboaudioinput2.Clear()
        VideoCap1.RefreshAudioInputPin(cboAudioDevice2.ListIndex)

      
        For i = 0 To VideoCap1.GetAudioInputPinCount - 1
            cboaudioinput2.AddItem(VideoCap1.GetAudioInputPinName(i))
        Next

        If cboaudioinput2.ListCount > 0 Then
            cboaudioinput2.ListIndex = 0
        End If
    End Sub

    Private Sub cboDevice_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDevice.SelectedIndexChanged
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

    Private Sub Command1_Click()

    End Sub

    Private Sub cboDevice2_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboDevice2.SelectedIndexChanged
        Dim i As Integer
        cbovideoformat2.Items.Clear()


        VideoCap1.RefreshVideoDevice(cboDevice2.SelectedIndex)

    
        
        For i = 0 To VideoCap1.GetVideoFormatCount - 1
            cbovideoformat2.Items.Add(VideoCap1.GetVideoFormatName(i))
        Next


        If cbovideoformat2.Items.Count > 0 Then
            cbovideoformat2.SelectedIndex = 0
        End If

    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
        Dim bresult As Boolean

        If cboDevice.SelectedIndex = cboDevice2.SelectedIndex Then

            MessageBox.Show("You cannot select same video device")
            Exit Sub
        End If


        If chkcapturetowmv.CheckState = 1 Then

            Me.VideoCap1.AudioDevice = cboAudioDevice.SelectedIndex
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



        bresult = Me.VideoCap1.PIPAddVideoDevice(cboDevice.SelectedIndex, cbovideoformat.SelectedIndex, 0, CShort(txtalphavideo.Text))
        If bresult <> True Then
            ' MessageBox.Show("1")
            MessageBox.Show("video device 1 failed")
        End If

        Me.VideoCap1.PIPAddPIPEffect(0, 99999, 0, 0, 320, 240)

    

        bresult = Me.VideoCap1.PIPAddVideoDevice(cboDevice2.SelectedIndex, cbovideoformat2.SelectedIndex, 0, CShort(txtalphavideo2.Text))
        If bresult <> True Then
            MessageBox.Show("video device 2 failed")
        End If

        Me.VideoCap1.PIPAddPIPEffect(0, 99999, 320, 0, 320, 240)
       


        bresult = Me.VideoCap1.PIPAddVideoDevice(cboDevice3.SelectedIndex, cbovideoformat3.SelectedIndex, 0, CShort(txtalphavideo3.Text))
        If bresult <> True Then
            MessageBox.Show("video device 3 failed")
        End If

        Me.VideoCap1.PIPAddPIPEffect(0, 99999, 0, 240, 320, 240)


        bresult = Me.VideoCap1.PIPAddVideoDevice(cboDevice4.SelectedIndex, cbovideoformat4.SelectedIndex, 0, CShort(txtalphavideo4.Text))
        If bresult <> True Then
            MessageBox.Show("video device 4 failed")
        End If

        Me.VideoCap1.PIPAddPIPEffect(0, 99999, 320, 240, 320, 240)





        Me.VideoCap1.PIPStart()


    End Sub

    Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
        VideoCap1.PIPStop()
    End Sub

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'Dim mydevice2 As VIDEOCAPLib.Device
        'Dim myAudioInput As VIDEOCAPLib.AudioInputPin
        'Dim myVideoformat As VIDEOCAPLib.VideoFormat
        'Dim myAudioDevice As VIDEOCAPLib.AudioDevice

        'Dim mydevice As VIDEOCAPLib.Device

        Dim i As Integer
        

        For i = 0 To Me.VideoCap1.GetDeviceCount - 1
            cboDevice.Items.Add(Me.VideoCap1.GetDeviceName(i))
        Next


        If cboDevice.Items.Count > 0 Then
            cboDevice.SelectedIndex = 0
        End If

      

        For i = 0 To Me.VideoCap1.GetAudioDeviceCount - 1
            cboAudioDevice.Items.Add(Me.VideoCap1.GetAudioDeviceName(i))
        Next


        If cboAudioDevice.Items.Count > 0 Then
            cboAudioDevice.SelectedIndex = 0
        End If


        For i = 0 To Me.VideoCap1.GetVideoFormatCount - 1
            cbovideoformat.Items.Add(Me.VideoCap1.GetVideoFormatName(i))
        Next


        If cbovideoformat.Items.Count > 0 Then
            cbovideoformat.SelectedIndex = 0
        End If


        For i = 0 To Me.VideoCap1.GetAudioInputPinCount - 1
            cboaudioinput.Items.Add(Me.VideoCap1.GetAudioInputPinName(i))
        Next


        If cboaudioinput.Items.Count > 0 Then
            cboaudioinput.SelectedIndex = 0
        End If

        '''''''''''''''''''''''''''''''''''''''''''

        For i = 0 To Me.VideoCap1.GetDeviceCount - 1
            cboDevice2.Items.Add(Me.VideoCap1.GetDeviceName(i))   ''''' you can't select the same of video device
        Next


        If cboDevice2.Items.Count > 0 Then
            cboDevice2.SelectedIndex = 0
        End If


        For i = 0 To Me.VideoCap1.GetDeviceCount - 1
            cboDevice3.Items.Add(Me.VideoCap1.GetDeviceName(i))   ''''' you can't select the same of video device
        Next


        If cboDevice3.Items.Count > 0 Then
            cboDevice3.SelectedIndex = 0
        End If


        For i = 0 To Me.VideoCap1.GetDeviceCount - 1
            cboDevice4.Items.Add(Me.VideoCap1.GetDeviceName(i))   ''''' you can't select the same of video device
        Next


        If cboDevice4.Items.Count > 0 Then
            cboDevice4.SelectedIndex = 0
        End If

    End Sub

    Private Sub Form1_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        Me.WMVProfileEditor1.DeleteTempFile(tmpWMVFilePath)
    End Sub

    Private Sub cbovideoformat2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbovideoformat2.SelectedIndexChanged

    End Sub

    Private Sub cboDevice3_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboDevice3.SelectedIndexChanged
        
        Dim i As Integer
        cbovideoformat3.Items.Clear()


        VideoCap1.RefreshVideoDevice(cboDevice3.SelectedIndex)


      

        For i = 0 To VideoCap1.GetVideoFormatCount - 1
            cbovideoformat3.Items.Add(VideoCap1.GetVideoFormatName(i))
        Next


        If cbovideoformat3.Items.Count > 0 Then
            cbovideoformat3.SelectedIndex = 0
        End If

    End Sub

    Private Sub cboDevice4_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboDevice4.SelectedIndexChanged
        Dim i As Integer
        cbovideoformat4.Items.Clear()


        VideoCap1.RefreshVideoDevice(cboDevice4.SelectedIndex)




        For i = 0 To VideoCap1.GetVideoFormatCount - 1
            cbovideoformat4.Items.Add(VideoCap1.GetVideoFormatName(i))
        Next


        If cbovideoformat4.Items.Count > 0 Then
            cbovideoformat4.SelectedIndex = 0
        End If
    End Sub
End Class