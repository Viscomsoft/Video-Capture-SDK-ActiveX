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
    Public WithEvents Command3 As System.Windows.Forms.Button
    Public WithEvents Command2 As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents cboDevice As System.Windows.Forms.ComboBox
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtheight As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtwidth As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txttop As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtleft As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkfullscreen As System.Windows.Forms.CheckBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents txtcursorfile As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkusesystemcursor As System.Windows.Forms.CheckBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents AxVideoCap1 As AxVIDEOCAPLib.AxVideoCap
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Command3 = New System.Windows.Forms.Button()
        Me.Command2 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboDevice = New System.Windows.Forms.ComboBox()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtcursorfile = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkusesystemcursor = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtheight = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtwidth = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txttop = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtleft = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkfullscreen = New System.Windows.Forms.CheckBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.AxVideoCap1 = New AxVIDEOCAPLib.AxVideoCap()
        Me.Frame1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AxVideoCap1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Command3
        '
        Me.Command3.BackColor = System.Drawing.SystemColors.Control
        Me.Command3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command3.Location = New System.Drawing.Point(175, 348)
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
        Me.Command2.Location = New System.Drawing.Point(14, 348)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(137, 41)
        Me.Command2.TabIndex = 1
        Me.Command2.Text = "Start "
        Me.Command2.UseVisualStyleBackColor = False
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
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.cboDevice)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 8)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(321, 57)
        Me.Frame1.TabIndex = 2
        Me.Frame1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.txtcursorfile)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.chkusesystemcursor)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtheight)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtwidth)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txttop)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtleft)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.chkfullscreen)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(346, 244)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Virtual Screen Capture Area"
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(271, 219)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(68, 24)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Select"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtcursorfile
        '
        Me.txtcursorfile.Location = New System.Drawing.Point(14, 195)
        Me.txtcursorfile.Name = "txtcursorfile"
        Me.txtcursorfile.Size = New System.Drawing.Size(331, 20)
        Me.txtcursorfile.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 14)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Cursor File"
        '
        'chkusesystemcursor
        '
        Me.chkusesystemcursor.AutoSize = True
        Me.chkusesystemcursor.Checked = True
        Me.chkusesystemcursor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkusesystemcursor.Location = New System.Drawing.Point(13, 143)
        Me.chkusesystemcursor.Name = "chkusesystemcursor"
        Me.chkusesystemcursor.Size = New System.Drawing.Size(120, 18)
        Me.chkusesystemcursor.TabIndex = 12
        Me.chkusesystemcursor.Text = "Use System Cursor"
        Me.chkusesystemcursor.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(218, 104)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 30)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Right Click Color"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(112, 104)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 30)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Left Click Color"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 104)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 30)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Highlight Color"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtheight
        '
        Me.txtheight.Enabled = False
        Me.txtheight.Location = New System.Drawing.Point(301, 55)
        Me.txtheight.Name = "txtheight"
        Me.txtheight.Size = New System.Drawing.Size(39, 20)
        Me.txtheight.TabIndex = 8
        Me.txtheight.Text = "480"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(261, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 14)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Height"
        '
        'txtwidth
        '
        Me.txtwidth.Enabled = False
        Me.txtwidth.Location = New System.Drawing.Point(206, 55)
        Me.txtwidth.Name = "txtwidth"
        Me.txtwidth.Size = New System.Drawing.Size(39, 20)
        Me.txtwidth.TabIndex = 6
        Me.txtwidth.Text = "720"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(166, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 14)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Width"
        '
        'txttop
        '
        Me.txttop.Enabled = False
        Me.txttop.Location = New System.Drawing.Point(124, 55)
        Me.txttop.Name = "txttop"
        Me.txttop.Size = New System.Drawing.Size(36, 20)
        Me.txttop.TabIndex = 4
        Me.txttop.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 14)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Top"
        '
        'txtleft
        '
        Me.txtleft.Enabled = False
        Me.txtleft.Location = New System.Drawing.Point(46, 58)
        Me.txtleft.Name = "txtleft"
        Me.txtleft.Size = New System.Drawing.Size(36, 20)
        Me.txtleft.TabIndex = 2
        Me.txtleft.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Left"
        '
        'chkfullscreen
        '
        Me.chkfullscreen.AutoSize = True
        Me.chkfullscreen.Checked = True
        Me.chkfullscreen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkfullscreen.Location = New System.Drawing.Point(11, 24)
        Me.chkfullscreen.Name = "chkfullscreen"
        Me.chkfullscreen.Size = New System.Drawing.Size(80, 18)
        Me.chkfullscreen.TabIndex = 0
        Me.chkfullscreen.Text = "Full Screen"
        Me.chkfullscreen.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'AxVideoCap1
        '
        Me.AxVideoCap1.Enabled = True
        Me.AxVideoCap1.Location = New System.Drawing.Point(408, 24)
        Me.AxVideoCap1.Name = "AxVideoCap1"
        Me.AxVideoCap1.OcxState = CType(resources.GetObject("AxVideoCap1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVideoCap1.Size = New System.Drawing.Size(755, 481)
        Me.AxVideoCap1.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1265, 542)
        Me.Controls.Add(Me.AxVideoCap1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Command3)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Virtual Screen Capture"
        Me.Frame1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AxVideoCap1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Dim tmpWMVFilePath As String










    Private Sub Command1_Click()

    End Sub



    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
        Dim bresult As Boolean

        If chkfullscreen.Checked Then
            Me.AxVideoCap1.VirtualScreenCaptureFullScreen(True)
        Else
            Me.AxVideoCap1.VirtualScreenCaptureFullScreen(False)
            Me.AxVideoCap1.VirtualScreenCaptureArea(txtleft.Text, txttop.Text, txtwidth.Text, txtheight.Text)
        End If

        If chkusesystemcursor.Checked Then
            Me.AxVideoCap1.VirtualScreenShowSystemCursor(True)
        Else
            Me.AxVideoCap1.VirtualScreenShowSystemCursor(False)
            Me.AxVideoCap1.VirtualScreenCursorFile(txtcursorfile.Text)


        End If

        Me.AxVideoCap1.Device = cboDevice.SelectedIndex
        Me.AxVideoCap1.Start()






    End Sub

    Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
        AxVideoCap1.Stop()
    End Sub

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim strName As String
        Dim strApp As String
        Dim iFindIndex As Integer

        For i = 0 To Me.AxVideoCap1.GetDeviceCount - 1
            strName = Me.AxVideoCap1.GetDeviceName(i)
            cboDevice.Items.Add(strName)

            If cboDevice.Items(i) = "Viscomsoft Virtual Screen Capture" Then
                cboDevice.SelectedIndex = i

            End If


        Next

        strApp = Application.ExecutablePath
        iFindIndex = strApp.IndexOf("Examples")
        If iFindIndex <> -1 Then
            strApp = strApp.Substring(0, iFindIndex)
            txtcursorfile.Text = strApp + "\Cursor\hand-icon.ico"
        End If

    End Sub

    Private Sub Form1_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
    End Sub



    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub chkfullscreen_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkfullscreen.CheckedChanged

    End Sub

    Private Sub chkfullscreen_Click(sender As Object, e As System.EventArgs) Handles chkfullscreen.Click
        If chkfullscreen.Checked Then


            txtleft.Enabled = False
            txttop.Enabled = False
            txtwidth.Enabled = False
            txtheight.Enabled = False

        Else
            txtleft.Enabled = True
            txttop.Enabled = True
            txtwidth.Enabled = True
            txtheight.Enabled = True

        End If
    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            AxVideoCap1.VirtualScreenLeftClickColor(Color2Uint32(ColorDialog1.Color))
        End If
    End Sub

    Public Function Color2Uint32(ByVal clr As Color) As UInt32
        Dim t As Int32
        Dim a() As Byte

        t = ColorTranslator.ToOle(clr)


        a = BitConverter.GetBytes(t)

        Return BitConverter.ToUInt32(a, 0)


    End Function

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            AxVideoCap1.VirtualScreenRightClickColor(Color2Uint32(ColorDialog1.Color))
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        OpenFileDialog1.Filter = "Cursor File (*.ico)|*.ico|Cursor File (*.cur)|*.cur||"
        OpenFileDialog1.ShowDialog()
        txtcursorfile.Text = OpenFileDialog1.FileName

    End Sub

    Private Sub chkusesystemcursor_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkusesystemcursor.CheckedChanged

    End Sub

    Private Sub chkusesystemcursor_Click(sender As Object, e As System.EventArgs) Handles chkusesystemcursor.Click
        If chkusesystemcursor.Checked Then
            Button4.Enabled = False
        Else
            Button4.Enabled = True

        End If
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            AxVideoCap1.VirtualScreenHighlightColor(Color2Uint32(ColorDialog1.Color))
        End If
    End Sub
End Class