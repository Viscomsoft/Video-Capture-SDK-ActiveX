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
	Public WithEvents cboTunerMode As System.Windows.Forms.ComboBox
	Public WithEvents cbotunerinput As System.Windows.Forms.ComboBox
	Public WithEvents VideoCap1 As AxVIDEOCAPLib.AxVideoCap
	Public WithEvents cmdChange As System.Windows.Forms.Button
	Public WithEvents cbovideostand As System.Windows.Forms.ComboBox
	Public WithEvents cboVideoFormat As System.Windows.Forms.ComboBox
	Public WithEvents cboVideoInput As System.Windows.Forms.ComboBox
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents Command5 As System.Windows.Forms.Button
	Public WithEvents Check1 As System.Windows.Forms.CheckBox
	Public WithEvents Command4 As System.Windows.Forms.Button
	Public WithEvents Command3 As System.Windows.Forms.Button
	Public WithEvents cboDevice As System.Windows.Forms.ComboBox
	Public WithEvents Picture1 As System.Windows.Forms.PictureBox
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents List1 As System.Windows.Forms.ListBox
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cboTunerMode = New System.Windows.Forms.ComboBox
        Me.cbotunerinput = New System.Windows.Forms.ComboBox
        Me.VideoCap1 = New AxVIDEOCAPLib.AxVideoCap
        Me.cmdChange = New System.Windows.Forms.Button
        Me.cbovideostand = New System.Windows.Forms.ComboBox
        Me.cboVideoFormat = New System.Windows.Forms.ComboBox
        Me.cboVideoInput = New System.Windows.Forms.ComboBox
        Me.Text1 = New System.Windows.Forms.TextBox
        Me.Command5 = New System.Windows.Forms.Button
        Me.Check1 = New System.Windows.Forms.CheckBox
        Me.Command4 = New System.Windows.Forms.Button
        Me.Command3 = New System.Windows.Forms.Button
        Me.cboDevice = New System.Windows.Forms.ComboBox
        Me.Picture1 = New System.Windows.Forms.PictureBox
        Me.Command2 = New System.Windows.Forms.Button
        Me.List1 = New System.Windows.Forms.ListBox
        Me.Command1 = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        CType(Me.VideoCap1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboTunerMode
        '
        Me.cboTunerMode.BackColor = System.Drawing.SystemColors.Window
        Me.cboTunerMode.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboTunerMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTunerMode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTunerMode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboTunerMode.Location = New System.Drawing.Point(112, 168)
        Me.cboTunerMode.Name = "cboTunerMode"
        Me.cboTunerMode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboTunerMode.Size = New System.Drawing.Size(153, 22)
        Me.cboTunerMode.TabIndex = 25
        '
        'cbotunerinput
        '
        Me.cbotunerinput.BackColor = System.Drawing.SystemColors.Window
        Me.cbotunerinput.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbotunerinput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotunerinput.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbotunerinput.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbotunerinput.Location = New System.Drawing.Point(112, 136)
        Me.cbotunerinput.Name = "cbotunerinput"
        Me.cbotunerinput.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbotunerinput.Size = New System.Drawing.Size(89, 22)
        Me.cbotunerinput.TabIndex = 23
        '
        'VideoCap1
        '
        Me.VideoCap1.Enabled = True
        Me.VideoCap1.Location = New System.Drawing.Point(8, 200)
        Me.VideoCap1.Name = "VideoCap1"
        Me.VideoCap1.OcxState = CType(resources.GetObject("VideoCap1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.VideoCap1.Size = New System.Drawing.Size(377, 281)
        Me.VideoCap1.TabIndex = 21
        '
        'cmdChange
        '
        Me.cmdChange.BackColor = System.Drawing.SystemColors.Control
        Me.cmdChange.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdChange.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdChange.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdChange.Location = New System.Drawing.Point(280, 32)
        Me.cmdChange.Name = "cmdChange"
        Me.cmdChange.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdChange.Size = New System.Drawing.Size(73, 25)
        Me.cmdChange.TabIndex = 20
        Me.cmdChange.Text = "Change"
        '
        'cbovideostand
        '
        Me.cbovideostand.BackColor = System.Drawing.SystemColors.Window
        Me.cbovideostand.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbovideostand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovideostand.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbovideostand.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbovideostand.Location = New System.Drawing.Point(112, 80)
        Me.cbovideostand.Name = "cbovideostand"
        Me.cbovideostand.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbovideostand.Size = New System.Drawing.Size(257, 22)
        Me.cbovideostand.TabIndex = 19
        '
        'cboVideoFormat
        '
        Me.cboVideoFormat.BackColor = System.Drawing.SystemColors.Window
        Me.cboVideoFormat.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboVideoFormat.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVideoFormat.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboVideoFormat.Location = New System.Drawing.Point(112, 56)
        Me.cboVideoFormat.Name = "cboVideoFormat"
        Me.cboVideoFormat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboVideoFormat.Size = New System.Drawing.Size(257, 22)
        Me.cboVideoFormat.TabIndex = 16
        '
        'cboVideoInput
        '
        Me.cboVideoInput.BackColor = System.Drawing.SystemColors.Window
        Me.cboVideoInput.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboVideoInput.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVideoInput.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboVideoInput.Location = New System.Drawing.Point(112, 32)
        Me.cboVideoInput.Name = "cboVideoInput"
        Me.cboVideoInput.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboVideoInput.Size = New System.Drawing.Size(161, 22)
        Me.cboVideoInput.TabIndex = 14
        '
        'Text1
        '
        Me.Text1.AcceptsReturn = True
        Me.Text1.AutoSize = False
        Me.Text1.BackColor = System.Drawing.SystemColors.Window
        Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1.Location = New System.Drawing.Point(112, 104)
        Me.Text1.MaxLength = 0
        Me.Text1.Name = "Text1"
        Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1.Size = New System.Drawing.Size(97, 19)
        Me.Text1.TabIndex = 11
        Me.Text1.Text = "1"
        '
        'Command5
        '
        Me.Command5.BackColor = System.Drawing.SystemColors.Control
        Me.Command5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command5.Location = New System.Drawing.Point(392, 440)
        Me.Command5.Name = "Command5"
        Me.Command5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command5.Size = New System.Drawing.Size(153, 33)
        Me.Command5.TabIndex = 10
        Me.Command5.Text = "VideoCapture Property Page"
        '
        'Check1
        '
        Me.Check1.BackColor = System.Drawing.SystemColors.Control
        Me.Check1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Check1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Check1.Location = New System.Drawing.Point(520, 168)
        Me.Check1.Name = "Check1"
        Me.Check1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Check1.Size = New System.Drawing.Size(65, 25)
        Me.Check1.TabIndex = 9
        Me.Check1.Text = "Mute"
        '
        'Command4
        '
        Me.Command4.BackColor = System.Drawing.SystemColors.Control
        Me.Command4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command4.Enabled = False
        Me.Command4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command4.Location = New System.Drawing.Point(520, 0)
        Me.Command4.Name = "Command4"
        Me.Command4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command4.Size = New System.Drawing.Size(96, 25)
        Me.Command4.TabIndex = 8
        Me.Command4.Text = "Stop Capture"
        '
        'Command3
        '
        Me.Command3.BackColor = System.Drawing.SystemColors.Control
        Me.Command3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command3.Enabled = False
        Me.Command3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command3.Location = New System.Drawing.Point(440, 0)
        Me.Command3.Name = "Command3"
        Me.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command3.Size = New System.Drawing.Size(73, 25)
        Me.Command3.TabIndex = 6
        Me.Command3.Text = "Capture"
        '
        'cboDevice
        '
        Me.cboDevice.BackColor = System.Drawing.SystemColors.Window
        Me.cboDevice.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDevice.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDevice.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboDevice.Location = New System.Drawing.Point(112, 8)
        Me.cboDevice.Name = "cboDevice"
        Me.cboDevice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboDevice.Size = New System.Drawing.Size(161, 22)
        Me.cboDevice.TabIndex = 5
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.SystemColors.Control
        Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Picture1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Picture1.Location = New System.Drawing.Point(480, 32)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture1.Size = New System.Drawing.Size(73, 65)
        Me.Picture1.TabIndex = 3
        Me.Picture1.TabStop = False
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.Enabled = False
        Me.Command2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(360, 0)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(73, 25)
        Me.Command2.TabIndex = 2
        Me.Command2.Text = "SnapShot"
        '
        'List1
        '
        Me.List1.BackColor = System.Drawing.SystemColors.Window
        Me.List1.Cursor = System.Windows.Forms.Cursors.Default
        Me.List1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.List1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.List1.ItemHeight = 14
        Me.List1.Location = New System.Drawing.Point(392, 200)
        Me.List1.Name = "List1"
        Me.List1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.List1.Size = New System.Drawing.Size(217, 144)
        Me.List1.TabIndex = 1
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(280, 0)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(73, 25)
        Me.Command1.TabIndex = 0
        Me.Command1.Text = "Start"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(8, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(81, 17)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Tuner Mode"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(8, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(81, 17)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Tuner Input"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(8, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(97, 25)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Video Standard"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(8, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(89, 25)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Video Format"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(8, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(73, 25)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Video Input"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(224, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(297, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "if you do not know your country code ,see the help file"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Country Code"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(392, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "TV Channel No."
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Video Device"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(4, 11)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(648, 536)
        Me.Controls.Add(Me.cboTunerMode)
        Me.Controls.Add(Me.cbotunerinput)
        Me.Controls.Add(Me.VideoCap1)
        Me.Controls.Add(Me.cmdChange)
        Me.Controls.Add(Me.cbovideostand)
        Me.Controls.Add(Me.cboVideoFormat)
        Me.Controls.Add(Me.cboVideoInput)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.Command5)
        Me.Controls.Add(Me.Check1)
        Me.Controls.Add(Me.Command4)
        Me.Controls.Add(Me.Command3)
        Me.Controls.Add(Me.cboDevice)
        Me.Controls.Add(Me.Picture1)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.List1)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "TV Tuner Demo"
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
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	
	
	
	
	
	
	Private Sub cmdChange_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdChange.Click
        Me.VideoCap1.Start()
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Dim IsTVDevice As Object
		Dim videoinputindex As Object
		Dim strVideoInput As Object
		
		Dim myTVChannel As VIDEOCAPLib.TVChannel
		
		If videoinputindex <> -1 Then
            VideoCap1.VideoInput = cboVideoInput.SelectedIndex
        End If

        Me.VideoCap1.TunerInput = cbotunerinput.SelectedIndex

        If cboTunerMode.SelectedIndex = 0 Then
            Me.VideoCap1.TunerMode = -1
        Else
            Me.VideoCap1.TunerMode = cboTunerMode.SelectedIndex - 1
        End If


        Me.VideoCap1.CountryCode = Val(Text1.Text)
        Me.VideoCap1.Start()



        VideoCap1.VideoStandard = cbovideostand.SelectedIndex


        IsTVDevice = VideoCap1.ScanTVChannels

        If IsTVDevice = False Then
            MsgBox("No TV Tuner found")
        End If


        cmdChange.Enabled = True



        For Each myTVChannel In VideoCap1.TVChannels    ''  ?can't find 

            If myTVChannel.SignalStatus <> 0 Then

                Me.List1.Items.Add(myTVChannel.ChannelNo)
            End If


        Next myTVChannel




        Me.Command1.Enabled = False
        Me.cboDevice.Enabled = False

        Me.Command2.Enabled = True
        Me.Command3.Enabled = True
		
		
		
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
        Dim result As Boolean

        Dim strFileName As String

        SaveFileDialog1.Filter = "BMP file (*.bmp)|*.bmp||"

        SaveFileDialog1.DefaultExt = "bmp"

        
        Me.SaveFileDialog1.ShowDialog()
		
        result = Me.VideoCap1.SnapShot(SaveFileDialog1.FileName)

        strFileName = SaveFileDialog1.FileName
        MsgBox("save to " + strFileName)
		
		
	End Sub
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		
        Me.SaveFileDialog1.Filter = "Avi File (*.avi)|*.avi"
        Me.SaveFileDialog1.ShowDialog()
		
		Me.VideoCap1.CaptureVideo = True
		Me.VideoCap1.CaptureAudio = True
		Me.VideoCap1.ShowPreview = True
		Me.VideoCap1.UseVideoCompressor = False
		Me.VideoCap1.UseAudioCompressor = False
		Me.VideoCap1.CaptureMode = True
        Me.VideoCap1.CaptureFileName = Me.SaveFileDialog1.FileName
		Me.VideoCap1.Start()
		
        Me.Command3.Enabled = False
		Me.Command4.Enabled = True
		
		
	End Sub
	
	Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
		
		Me.Command1.Enabled = True
		Me.cboDevice.Enabled = True
		
		Me.VideoCap1.Stop()
		
		Me.VideoCap1.CaptureMode = False
		Me.VideoCap1.Start()
		
		Me.Command4.Enabled = False
		Me.Command3.Enabled = True
		
	End Sub
	
	Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command5.Click
        Me.VideoCap1.ShowVideoCapturePropertyPage(0)
	End Sub
	
	Private Sub Command6_Click()
		Me.VideoCap1.Start()
	End Sub
	
	Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim i As Integer

		cbotunerinput.Items.Add("Cable")
		cbotunerinput.Items.Add("Antenna")
		cbotunerinput.SelectedIndex = 0
		
		cboTunerMode.Items.Add("Default")
		cboTunerMode.Items.Add("TV")
		cboTunerMode.Items.Add("FM Radio")
		cboTunerMode.Items.Add("AM Radio")
		cboTunerMode.Items.Add("Digital Satellite Service")
		cboTunerMode.SelectedIndex = 0
		
		cbovideostand.Items.Add(("Digital sensor"))
		cbovideostand.Items.Add(("NTSC (M) standard, 7.5 IRE black"))
		cbovideostand.Items.Add(("NTSC (M) standard, 0 IRE black (Japan)"))
		cbovideostand.Items.Add(("NTSC-433"))
		cbovideostand.Items.Add(("PAL -B standard"))
		cbovideostand.Items.Add(("PAL (D) standard"))
		cbovideostand.Items.Add(("PAL (H) standard"))
		cbovideostand.Items.Add(("PAL (I) standard"))
		cbovideostand.Items.Add(("PAL (M) standard"))
		cbovideostand.Items.Add(("PAL (N) standard"))
		cbovideostand.Items.Add(("PAL-60 standard"))
		cbovideostand.Items.Add(("SECAM (B) standard"))
		cbovideostand.Items.Add(("SECAM (D) standard"))
		cbovideostand.Items.Add(("SECAM (G) standard"))
		cbovideostand.Items.Add(("SECAM (H) standard"))
		cbovideostand.Items.Add(("SECAM (K) standard"))
		cbovideostand.Items.Add(("SECAM (K1) standard"))
		cbovideostand.Items.Add(("SECAM (L) standard"))
		cbovideostand.Items.Add(("SECAM (L1) standard"))
		cbovideostand.Items.Add(("Combination (N) PAL standard (Argentina) "))
		
		cbovideostand.SelectedIndex = 0
		
		
		cmdChange.Enabled = False
		
		
		
		
		
        For i = 0 To VideoCap1.GetVideoInputCount - 1 '1
            cboVideoInput.Items.Add(VideoCap1.GetVideoInputName(i))
        Next

        If cboVideoInput.Items.Count > 0 Then
            cboVideoInput.SelectedIndex = 0
        End If

        For i = 0 To VideoCap1.GetDeviceCount - 1 '2
            cboDevice.Items.Add(VideoCap1.GetDeviceName(i))
        Next

        If cboDevice.Items.Count > 0 Then
            cboDevice.SelectedIndex = 0
        End If


        For i = 0 To VideoCap1.GetVideoFormatCount - 1 '3
            cboVideoFormat.Items.Add(VideoCap1.GetVideoFormatName(i))
        Next

        If cboVideoFormat.Items.Count > 0 Then
            cboVideoFormat.SelectedIndex = 0
        End If

		
	End Sub
	
	

    Private Sub List1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles List1.Click
        Dim strNO As String
        strNO = List1.Items(List1.SelectedIndex)
        Me.VideoCap1.Channel = CShort(strNO)

    End Sub

    Private Sub cbovideostand_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbovideostand.Click
        VideoCap1.VideoStandard = cbovideostand.SelectedIndex
    End Sub

    Private Sub cboVideoInput_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboVideoInput.Click
        VideoCap1.VideoInput = cboVideoInput.SelectedIndex
    End Sub

    Private Sub Check1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Check1.Click
        If Check1.Checked Then
            Me.VideoCap1.TVMute = True
        Else
            Me.VideoCap1.TVMute = False
        End If
    End Sub

    Private Sub cboVideoFormat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboVideoFormat.Click
        VideoCap1.VideoFormat = cboVideoFormat.SelectedIndex

    End Sub
End Class