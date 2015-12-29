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
    Public WithEvents cboVideoInput As System.Windows.Forms.ComboBox
	Public WithEvents cmdProPage As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
    Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
    Public WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbovideoformat As System.Windows.Forms.ComboBox
    Friend WithEvents BrightnessSlider1 As System.Windows.Forms.TrackBar
    Friend WithEvents ContrastSlider1 As System.Windows.Forms.TrackBar
    Friend WithEvents HueSlider1 As System.Windows.Forms.TrackBar
    Friend WithEvents SaturationSlider1 As System.Windows.Forms.TrackBar
    Friend WithEvents SharpnessSlider1 As System.Windows.Forms.TrackBar
    Friend WithEvents GammaSlider1 As System.Windows.Forms.TrackBar
    Friend WithEvents ColorEnableSlider1 As System.Windows.Forms.TrackBar
    Friend WithEvents WhiteBalanceSlider1 As System.Windows.Forms.TrackBar
    Friend WithEvents BacklightCompensationSlider1 As System.Windows.Forms.TrackBar
    Public WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ZoomSlider1 As System.Windows.Forms.TrackBar
    Friend WithEvents AxVideoCap1 As AxVIDEOCAPLib.AxVideoCap
    Friend WithEvents GainSlider1 As System.Windows.Forms.TrackBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cboVideoInput = New System.Windows.Forms.ComboBox()
        Me.cmdProPage = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbovideoformat = New System.Windows.Forms.ComboBox()
        Me.BrightnessSlider1 = New System.Windows.Forms.TrackBar()
        Me.ContrastSlider1 = New System.Windows.Forms.TrackBar()
        Me.HueSlider1 = New System.Windows.Forms.TrackBar()
        Me.SaturationSlider1 = New System.Windows.Forms.TrackBar()
        Me.SharpnessSlider1 = New System.Windows.Forms.TrackBar()
        Me.GammaSlider1 = New System.Windows.Forms.TrackBar()
        Me.ColorEnableSlider1 = New System.Windows.Forms.TrackBar()
        Me.WhiteBalanceSlider1 = New System.Windows.Forms.TrackBar()
        Me.BacklightCompensationSlider1 = New System.Windows.Forms.TrackBar()
        Me.GainSlider1 = New System.Windows.Forms.TrackBar()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ZoomSlider1 = New System.Windows.Forms.TrackBar()
        Me.AxVideoCap1 = New AxVIDEOCAPLib.AxVideoCap()
        CType(Me.BrightnessSlider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContrastSlider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HueSlider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaturationSlider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SharpnessSlider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GammaSlider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorEnableSlider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WhiteBalanceSlider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BacklightCompensationSlider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GainSlider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZoomSlider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxVideoCap1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboVideoInput
        '
        Me.cboVideoInput.BackColor = System.Drawing.SystemColors.Window
        Me.cboVideoInput.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboVideoInput.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVideoInput.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboVideoInput.Location = New System.Drawing.Point(328, 24)
        Me.cboVideoInput.Name = "cboVideoInput"
        Me.cboVideoInput.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboVideoInput.Size = New System.Drawing.Size(145, 22)
        Me.cboVideoInput.TabIndex = 22
        '
        'cmdProPage
        '
        Me.cmdProPage.BackColor = System.Drawing.SystemColors.Control
        Me.cmdProPage.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdProPage.Enabled = False
        Me.cmdProPage.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProPage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdProPage.Location = New System.Drawing.Point(240, 152)
        Me.cmdProPage.Name = "cmdProPage"
        Me.cmdProPage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdProPage.Size = New System.Drawing.Size(201, 32)
        Me.cmdProPage.TabIndex = 21
        Me.cmdProPage.Text = "Show VideoCapture Property Page"
        Me.cmdProPage.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(240, 120)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(65, 25)
        Me.Command1.TabIndex = 0
        Me.Command1.Text = "Preview"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(240, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(73, 25)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Video Input"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(0, 600)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(129, 25)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Gain" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(0, 560)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(129, 25)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "BacklightCompensation"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(0, 520)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(73, 25)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "WhiteBalance"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(0, 480)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(73, 25)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Color Enable"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(0, 440)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(73, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Gamma"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(0, 400)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(73, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Sharpness"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(0, 360)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(73, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Saturation"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(0, 320)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(73, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hue"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(0, 280)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(73, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contrast"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(0, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(73, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Brightness"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(240, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(73, 25)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Video Format"
        '
        'cbovideoformat
        '
        Me.cbovideoformat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovideoformat.Location = New System.Drawing.Point(328, 64)
        Me.cbovideoformat.Name = "cbovideoformat"
        Me.cbovideoformat.Size = New System.Drawing.Size(144, 21)
        Me.cbovideoformat.TabIndex = 26
        '
        'BrightnessSlider1
        '
        Me.BrightnessSlider1.Location = New System.Drawing.Point(96, 232)
        Me.BrightnessSlider1.Name = "BrightnessSlider1"
        Me.BrightnessSlider1.Size = New System.Drawing.Size(376, 45)
        Me.BrightnessSlider1.TabIndex = 27
        '
        'ContrastSlider1
        '
        Me.ContrastSlider1.Location = New System.Drawing.Point(96, 280)
        Me.ContrastSlider1.Name = "ContrastSlider1"
        Me.ContrastSlider1.Size = New System.Drawing.Size(376, 45)
        Me.ContrastSlider1.TabIndex = 28
        '
        'HueSlider1
        '
        Me.HueSlider1.Location = New System.Drawing.Point(96, 320)
        Me.HueSlider1.Name = "HueSlider1"
        Me.HueSlider1.Size = New System.Drawing.Size(376, 45)
        Me.HueSlider1.TabIndex = 29
        '
        'SaturationSlider1
        '
        Me.SaturationSlider1.Location = New System.Drawing.Point(96, 360)
        Me.SaturationSlider1.Name = "SaturationSlider1"
        Me.SaturationSlider1.Size = New System.Drawing.Size(376, 45)
        Me.SaturationSlider1.TabIndex = 30
        '
        'SharpnessSlider1
        '
        Me.SharpnessSlider1.Location = New System.Drawing.Point(96, 400)
        Me.SharpnessSlider1.Name = "SharpnessSlider1"
        Me.SharpnessSlider1.Size = New System.Drawing.Size(376, 45)
        Me.SharpnessSlider1.TabIndex = 31
        '
        'GammaSlider1
        '
        Me.GammaSlider1.Location = New System.Drawing.Point(96, 432)
        Me.GammaSlider1.Name = "GammaSlider1"
        Me.GammaSlider1.Size = New System.Drawing.Size(376, 45)
        Me.GammaSlider1.TabIndex = 32
        '
        'ColorEnableSlider1
        '
        Me.ColorEnableSlider1.Location = New System.Drawing.Point(96, 472)
        Me.ColorEnableSlider1.Name = "ColorEnableSlider1"
        Me.ColorEnableSlider1.Size = New System.Drawing.Size(376, 45)
        Me.ColorEnableSlider1.TabIndex = 33
        '
        'WhiteBalanceSlider1
        '
        Me.WhiteBalanceSlider1.Location = New System.Drawing.Point(96, 512)
        Me.WhiteBalanceSlider1.Name = "WhiteBalanceSlider1"
        Me.WhiteBalanceSlider1.Size = New System.Drawing.Size(376, 45)
        Me.WhiteBalanceSlider1.TabIndex = 34
        '
        'BacklightCompensationSlider1
        '
        Me.BacklightCompensationSlider1.Location = New System.Drawing.Point(120, 552)
        Me.BacklightCompensationSlider1.Name = "BacklightCompensationSlider1"
        Me.BacklightCompensationSlider1.Size = New System.Drawing.Size(376, 45)
        Me.BacklightCompensationSlider1.TabIndex = 35
        '
        'GainSlider1
        '
        Me.GainSlider1.Location = New System.Drawing.Point(96, 600)
        Me.GainSlider1.Name = "GainSlider1"
        Me.GainSlider1.Size = New System.Drawing.Size(376, 45)
        Me.GainSlider1.TabIndex = 36
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(0, 648)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(73, 25)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Zoom"
        '
        'ZoomSlider1
        '
        Me.ZoomSlider1.Location = New System.Drawing.Point(97, 648)
        Me.ZoomSlider1.Name = "ZoomSlider1"
        Me.ZoomSlider1.Size = New System.Drawing.Size(376, 45)
        Me.ZoomSlider1.TabIndex = 38
        '
        'AxVideoCap1
        '
        Me.AxVideoCap1.Enabled = True
        Me.AxVideoCap1.Location = New System.Drawing.Point(8, 16)
        Me.AxVideoCap1.Name = "AxVideoCap1"
        Me.AxVideoCap1.OcxState = CType(resources.GetObject("AxVideoCap1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVideoCap1.Size = New System.Drawing.Size(220, 189)
        Me.AxVideoCap1.TabIndex = 42
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(541, 698)
        Me.Controls.Add(Me.AxVideoCap1)
        Me.Controls.Add(Me.ZoomSlider1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GainSlider1)
        Me.Controls.Add(Me.BacklightCompensationSlider1)
        Me.Controls.Add(Me.WhiteBalanceSlider1)
        Me.Controls.Add(Me.ColorEnableSlider1)
        Me.Controls.Add(Me.GammaSlider1)
        Me.Controls.Add(Me.SharpnessSlider1)
        Me.Controls.Add(Me.SaturationSlider1)
        Me.Controls.Add(Me.HueSlider1)
        Me.Controls.Add(Me.ContrastSlider1)
        Me.Controls.Add(Me.BrightnessSlider1)
        Me.Controls.Add(Me.cbovideoformat)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cboVideoInput)
        Me.Controls.Add(Me.cmdProPage)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Camera Control "
        CType(Me.BrightnessSlider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContrastSlider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HueSlider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaturationSlider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SharpnessSlider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GammaSlider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorEnableSlider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WhiteBalanceSlider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BacklightCompensationSlider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GainSlider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZoomSlider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxVideoCap1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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




    Private Sub cmdProPage_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdProPage.Click
        Me.AxVideoCap1.ShowVideoCapturePropertyPage(0)
    End Sub



    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click

        AxVideoCap1.VideoInput = cboVideoInput.SelectedIndex
        AxVideoCap1.VideoFormat = cbovideoformat.SelectedIndex

        Me.AxVideoCap1.Start()

        cmdProPage.Enabled = True

        If Me.AxVideoCap1.Brightness.Available Then
            Me.BrightnessSlider1.Minimum = Me.AxVideoCap1.Brightness.Min
            Me.BrightnessSlider1.Maximum = Me.AxVideoCap1.Brightness.Max
            Me.BrightnessSlider1.Value = Me.AxVideoCap1.Brightness.Value
        Else
            Me.BrightnessSlider1.Enabled = False
        End If



        If Me.AxVideoCap1.Contrast.Available Then
            Me.ContrastSlider1.Maximum = Me.AxVideoCap1.Contrast.Min
            Me.ContrastSlider1.Maximum = Me.AxVideoCap1.Contrast.Max
            Me.ContrastSlider1.Value = Me.AxVideoCap1.Contrast.Value
        Else
            Me.ContrastSlider1.Enabled = False
        End If

        If Me.AxVideoCap1.Hue.Available Then
            Me.HueSlider1.Minimum = Me.AxVideoCap1.Hue.Min
            Me.HueSlider1.Maximum = Me.AxVideoCap1.Hue.Max
            Me.HueSlider1.Value = Me.AxVideoCap1.Hue.Value
        Else
            Me.HueSlider1.Enabled = False
        End If

        If Me.AxVideoCap1.Saturation.Available Then
            Me.SaturationSlider1.Minimum = Me.AxVideoCap1.Saturation.Min
            Me.SaturationSlider1.Maximum = Me.AxVideoCap1.Saturation.Max
            Me.SaturationSlider1.Value = Me.AxVideoCap1.Saturation.Value
        Else
            Me.SaturationSlider1.Enabled = False
        End If


        If Me.AxVideoCap1.Sharpness.Available Then
            Me.SharpnessSlider1.Minimum = Me.AxVideoCap1.Sharpness.Min
            Me.SharpnessSlider1.Maximum = Me.AxVideoCap1.Sharpness.Max
            Me.SharpnessSlider1.Value = Me.AxVideoCap1.Sharpness.Value
        Else
            Me.SharpnessSlider1.Enabled = False
        End If


        If Me.AxVideoCap1.Gamma.Available Then
            Me.GammaSlider1.Minimum = Me.AxVideoCap1.Gamma.Min
            Me.GammaSlider1.Maximum = Me.AxVideoCap1.Gamma.Max
            Me.GammaSlider1.Value = Me.AxVideoCap1.Gamma.Value
        Else
            Me.GammaSlider1.Enabled = False
        End If

        If Me.AxVideoCap1.ColorEnable.Available Then
            Me.ColorEnableSlider1.Minimum = Me.AxVideoCap1.ColorEnable.Min
            Me.ColorEnableSlider1.Maximum = Me.AxVideoCap1.ColorEnable.Max
            Me.ColorEnableSlider1.Value = Me.AxVideoCap1.ColorEnable.Value
        Else
            Me.ColorEnableSlider1.Enabled = False
        End If

        If Me.AxVideoCap1.WhiteBalance.Available Then
            Me.WhiteBalanceSlider1.Minimum = Me.AxVideoCap1.WhiteBalance.Min
            Me.WhiteBalanceSlider1.Maximum = Me.AxVideoCap1.WhiteBalance.Max
            Me.WhiteBalanceSlider1.Value = Me.AxVideoCap1.WhiteBalance.Value
        Else
            Me.WhiteBalanceSlider1.Enabled = False
        End If

        If Me.AxVideoCap1.BacklightCompensation.Available Then
            Me.BacklightCompensationSlider1.Minimum = Me.AxVideoCap1.BacklightCompensation.Min
            Me.BacklightCompensationSlider1.Maximum = Me.AxVideoCap1.BacklightCompensation.Max
            Me.BacklightCompensationSlider1.Value = Me.AxVideoCap1.BacklightCompensation.Value
        Else
            Me.BacklightCompensationSlider1.Enabled = False
        End If


        If Me.AxVideoCap1.Gain.Available Then
            Me.GainSlider1.Minimum = Me.AxVideoCap1.Gain.Min
            Me.GainSlider1.Maximum = Me.AxVideoCap1.Gain.Max
            Me.GainSlider1.Value = Me.AxVideoCap1.Gain.Value
        Else
            Me.GainSlider1.Enabled = False
        End If


        If Me.AxVideoCap1.Zoom.Available Then
            Me.ZoomSlider1.Minimum = Me.AxVideoCap1.Zoom.Min
            Me.ZoomSlider1.Maximum = Me.AxVideoCap1.Zoom.Max
            Me.ZoomSlider1.Value = Me.AxVideoCap1.Zoom.Value
        Else
            Me.ZoomSlider1.Enabled = False
        End If


    End Sub


    Private Sub Command2_Click()
        Me.AxVideoCap1.ShowVideoCapturePropertyPage(0)
    End Sub





    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim i As Integer


        For i = 0 To AxVideoCap1.GetVideoInputCount - 1
            cboVideoInput.Items.Add(AxVideoCap1.GetVideoInputName(i))
        Next

        If cboVideoInput.Items.Count > 0 Then
            cboVideoInput.SelectedIndex = 0
        End If

        For i = 0 To AxVideoCap1.GetVideoFormatCount - 1
            cbovideoformat.Items.Add(AxVideoCap1.GetVideoFormatName(i))
        Next

        If cbovideoformat.Items.Count > 0 Then
            cbovideoformat.SelectedIndex = 0
        End If

    End Sub


    Private Sub BrightnessSlider1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrightnessSlider1.Scroll
        AxVideoCap1.Brightness().Value = Me.BrightnessSlider1.Value
    End Sub

    Private Sub ContrastSlider1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContrastSlider1.Scroll
        AxVideoCap1.Contrast.Value = Me.ContrastSlider1.Value
    End Sub

    Private Sub HueSlider1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HueSlider1.Scroll
        AxVideoCap1.Hue.Value = Me.HueSlider1.Value
    End Sub

    Private Sub SaturationSlider1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaturationSlider1.Scroll
        AxVideoCap1.Saturation.Value = Me.SaturationSlider1.Value
    End Sub

    Private Sub SharpnessSlider1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SharpnessSlider1.Scroll
        AxVideoCap1.Sharpness.Value = Me.SharpnessSlider1.Value

    End Sub

    Private Sub GammaSlider1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GammaSlider1.Scroll
        AxVideoCap1.Gamma.Value = Me.GammaSlider1.Value
    End Sub

    Private Sub ColorEnableSlider1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorEnableSlider1.Scroll
        AxVideoCap1.ColorEnable.Value = Me.ColorEnableSlider1.Value
    End Sub

    Private Sub WhiteBalanceSlider1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WhiteBalanceSlider1.Scroll
        AxVideoCap1.WhiteBalance.Value = Me.WhiteBalanceSlider1.Value
    End Sub

    Private Sub BacklightCompensationSlider1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BacklightCompensationSlider1.Scroll
        AxVideoCap1.BacklightCompensation.Value = Me.BacklightCompensationSlider1.Value
    End Sub

    Private Sub GainSlider1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GainSlider1.Scroll
        AxVideoCap1.Gain.Value = Me.GainSlider1.Value
    End Sub

    Private Sub ZoomSlider1_Scroll(sender As System.Object, e As System.EventArgs) Handles ZoomSlider1.Scroll
        AxVideoCap1.Zoom.Value = Me.ZoomSlider1.Value
    End Sub

 
End Class