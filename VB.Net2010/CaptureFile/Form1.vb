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
    Friend WithEvents cbovideoinput As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbovideoformat As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboaudiocomp As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbovideocomp As System.Windows.Forms.ComboBox
    Friend WithEvents btnpreview As System.Windows.Forms.Button
    Friend WithEvents btncapture As System.Windows.Forms.Button
    Friend WithEvents chkuseaudiocomp As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbovideostand As System.Windows.Forms.ComboBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents chkusevideocomp As System.Windows.Forms.CheckBox
    Friend WithEvents btnstopcapture As System.Windows.Forms.Button
    Friend WithEvents btnpause As System.Windows.Forms.Button
    Friend WithEvents btnresume As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents cbowmvprofile As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents cbowmv9profile As System.Windows.Forms.ComboBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents cboAudioDevice As System.Windows.Forms.ComboBox
    Friend WithEvents cboaudioinput As System.Windows.Forms.ComboBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents AxVideoCap1 As AxVIDEOCAPLib.AxVideoCap
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbosync As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtoffset As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonKey As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonMouse As System.Windows.Forms.RadioButton
    Friend WithEvents cbokey As System.Windows.Forms.ComboBox
    Friend WithEvents cbomousebutton As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtcustomwidth As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtcustomheight As System.Windows.Forms.TextBox
    Friend WithEvents chkusecustomvideo As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbovideodevice = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbovideoinput = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbovideoformat = New System.Windows.Forms.ComboBox()
        Me.btnpreview = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboaudiocomp = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbovideocomp = New System.Windows.Forms.ComboBox()
        Me.btncapture = New System.Windows.Forms.Button()
        Me.chkuseaudiocomp = New System.Windows.Forms.CheckBox()
        Me.chkusevideocomp = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbovideostand = New System.Windows.Forms.ComboBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnstopcapture = New System.Windows.Forms.Button()
        Me.btnpause = New System.Windows.Forms.Button()
        Me.btnresume = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.cbowmvprofile = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.cbowmv9profile = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.cboAudioDevice = New System.Windows.Forms.ComboBox()
        Me.cboaudioinput = New System.Windows.Forms.ComboBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.AxVideoCap1 = New AxVIDEOCAPLib.AxVideoCap()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtoffset = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbosync = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbomousebutton = New System.Windows.Forms.ComboBox()
        Me.cbokey = New System.Windows.Forms.ComboBox()
        Me.RadioButtonMouse = New System.Windows.Forms.RadioButton()
        Me.RadioButtonKey = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chkusecustomvideo = New System.Windows.Forms.CheckBox()
        Me.txtcustomheight = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtcustomwidth = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AxVideoCap1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Video Device"
        '
        'cbovideodevice
        '
        Me.cbovideodevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovideodevice.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbovideodevice.Location = New System.Drawing.Point(154, 26)
        Me.cbovideodevice.Name = "cbovideodevice"
        Me.cbovideodevice.Size = New System.Drawing.Size(326, 20)
        Me.cbovideodevice.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Video Input"
        '
        'cbovideoinput
        '
        Me.cbovideoinput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovideoinput.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbovideoinput.Location = New System.Drawing.Point(154, 60)
        Me.cbovideoinput.Name = "cbovideoinput"
        Me.cbovideoinput.Size = New System.Drawing.Size(326, 20)
        Me.cbovideoinput.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Video Format"
        '
        'cbovideoformat
        '
        Me.cbovideoformat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovideoformat.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbovideoformat.Location = New System.Drawing.Point(154, 95)
        Me.cbovideoformat.Name = "cbovideoformat"
        Me.cbovideoformat.Size = New System.Drawing.Size(326, 20)
        Me.cbovideoformat.TabIndex = 6
        '
        'btnpreview
        '
        Me.btnpreview.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpreview.Location = New System.Drawing.Point(10, 302)
        Me.btnpreview.Name = "btnpreview"
        Me.btnpreview.Size = New System.Drawing.Size(76, 25)
        Me.btnpreview.TabIndex = 7
        Me.btnpreview.Text = "Preview"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(499, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Audio Compressor"
        '
        'cboaudiocomp
        '
        Me.cboaudiocomp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboaudiocomp.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboaudiocomp.Location = New System.Drawing.Point(624, 190)
        Me.cboaudiocomp.Name = "cboaudiocomp"
        Me.cboaudiocomp.Size = New System.Drawing.Size(326, 20)
        Me.cboaudiocomp.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(499, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 24)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Video Compressor"
        '
        'cbovideocomp
        '
        Me.cbovideocomp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovideocomp.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbovideocomp.Location = New System.Drawing.Point(624, 233)
        Me.cbovideocomp.Name = "cbovideocomp"
        Me.cbovideocomp.Size = New System.Drawing.Size(326, 20)
        Me.cbovideocomp.TabIndex = 11
        '
        'btncapture
        '
        Me.btncapture.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncapture.Location = New System.Drawing.Point(96, 302)
        Me.btncapture.Name = "btncapture"
        Me.btncapture.Size = New System.Drawing.Size(77, 25)
        Me.btncapture.TabIndex = 12
        Me.btncapture.Text = "Capture"
        '
        'chkuseaudiocomp
        '
        Me.chkuseaudiocomp.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkuseaudiocomp.Location = New System.Drawing.Point(624, 215)
        Me.chkuseaudiocomp.Name = "chkuseaudiocomp"
        Me.chkuseaudiocomp.Size = New System.Drawing.Size(221, 18)
        Me.chkuseaudiocomp.TabIndex = 13
        Me.chkuseaudiocomp.Text = "Use Audio Compressor When Capture"
        '
        'chkusevideocomp
        '
        Me.chkusevideocomp.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkusevideocomp.Location = New System.Drawing.Point(624, 258)
        Me.chkusevideocomp.Name = "chkusevideocomp"
        Me.chkusevideocomp.Size = New System.Drawing.Size(221, 18)
        Me.chkusevideocomp.TabIndex = 14
        Me.chkusevideocomp.Text = "Use Video Compressor When Capture"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 25)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Video Stand"
        '
        'cbovideostand
        '
        Me.cbovideostand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovideostand.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbovideostand.Location = New System.Drawing.Point(154, 129)
        Me.cbovideostand.Name = "cbovideostand"
        Me.cbovideostand.Size = New System.Drawing.Size(326, 20)
        Me.cbovideostand.TabIndex = 16
        '
        'SaveFileDialog1
        '
        '
        'btnstopcapture
        '
        Me.btnstopcapture.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstopcapture.Location = New System.Drawing.Point(192, 302)
        Me.btnstopcapture.Name = "btnstopcapture"
        Me.btnstopcapture.Size = New System.Drawing.Size(86, 25)
        Me.btnstopcapture.TabIndex = 17
        Me.btnstopcapture.Text = "Stop Capture"
        '
        'btnpause
        '
        Me.btnpause.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpause.Location = New System.Drawing.Point(298, 302)
        Me.btnpause.Name = "btnpause"
        Me.btnpause.Size = New System.Drawing.Size(76, 25)
        Me.btnpause.TabIndex = 18
        Me.btnpause.Text = "Pause"
        '
        'btnresume
        '
        Me.btnresume.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnresume.Location = New System.Drawing.Point(394, 302)
        Me.btnresume.Name = "btnresume"
        Me.btnresume.Size = New System.Drawing.Size(76, 25)
        Me.btnresume.TabIndex = 19
        Me.btnresume.Text = "Resume"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(490, 129)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(470, 52)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Output Type"
        '
        'RadioButton3
        '
        Me.RadioButton3.Location = New System.Drawing.Point(202, 26)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(134, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "WMV 9"
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(106, 26)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(76, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "WMV 8"
        '
        'RadioButton1
        '
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(19, 26)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(58, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "AVI"
        '
        'cbowmvprofile
        '
        Me.cbowmvprofile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbowmvprofile.Enabled = False
        Me.cbowmvprofile.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbowmvprofile.Location = New System.Drawing.Point(624, 276)
        Me.cbowmvprofile.Name = "cbowmvprofile"
        Me.cbowmvprofile.Size = New System.Drawing.Size(394, 20)
        Me.cbowmvprofile.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(499, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 24)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "WMV 8 Profile"
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(499, 310)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(120, 25)
        Me.Label35.TabIndex = 47
        Me.Label35.Text = "WMV 9 Profile"
        '
        'cbowmv9profile
        '
        Me.cbowmv9profile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbowmv9profile.Enabled = False
        Me.cbowmv9profile.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbowmv9profile.Location = New System.Drawing.Point(624, 302)
        Me.cbowmv9profile.Name = "cbowmv9profile"
        Me.cbowmv9profile.Size = New System.Drawing.Size(394, 20)
        Me.cbowmv9profile.TabIndex = 48
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(10, 164)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(86, 17)
        Me.Label38.TabIndex = 51
        Me.Label38.Text = "Audio Device"
        '
        'cboAudioDevice
        '
        Me.cboAudioDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAudioDevice.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAudioDevice.Location = New System.Drawing.Point(154, 164)
        Me.cboAudioDevice.Name = "cboAudioDevice"
        Me.cboAudioDevice.Size = New System.Drawing.Size(326, 20)
        Me.cboAudioDevice.TabIndex = 52
        '
        'cboaudioinput
        '
        Me.cboaudioinput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboaudioinput.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboaudioinput.Location = New System.Drawing.Point(154, 198)
        Me.cboaudioinput.Name = "cboaudioinput"
        Me.cboaudioinput.Size = New System.Drawing.Size(326, 20)
        Me.cboaudioinput.TabIndex = 53
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(10, 198)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(86, 17)
        Me.Label39.TabIndex = 54
        Me.Label39.Text = "Audio Input"
        '
        'AxVideoCap1
        '
        Me.AxVideoCap1.Enabled = True
        Me.AxVideoCap1.Location = New System.Drawing.Point(10, 336)
        Me.AxVideoCap1.Name = "AxVideoCap1"
        Me.AxVideoCap1.OcxState = CType(resources.GetObject("AxVideoCap1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVideoCap1.Size = New System.Drawing.Size(470, 293)
        Me.AxVideoCap1.TabIndex = 55
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtoffset)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cbosync)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 224)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(480, 69)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sync Mode"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(413, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 26)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "ms"
        '
        'txtoffset
        '
        Me.txtoffset.Enabled = False
        Me.txtoffset.Location = New System.Drawing.Point(346, 26)
        Me.txtoffset.Name = "txtoffset"
        Me.txtoffset.Size = New System.Drawing.Size(48, 21)
        Me.txtoffset.TabIndex = 2
        Me.txtoffset.Text = "1"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(259, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 17)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Audio Offset"
        '
        'cbosync
        '
        Me.cbosync.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbosync.Location = New System.Drawing.Point(10, 26)
        Me.cbosync.Name = "cbosync"
        Me.cbosync.Size = New System.Drawing.Size(240, 20)
        Me.cbosync.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Location = New System.Drawing.Point(500, 350)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(443, 206)
        Me.GroupBox3.TabIndex = 57
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Size"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cbomousebutton)
        Me.GroupBox4.Controls.Add(Me.cbokey)
        Me.GroupBox4.Controls.Add(Me.RadioButtonMouse)
        Me.GroupBox4.Controls.Add(Me.RadioButtonKey)
        Me.GroupBox4.Location = New System.Drawing.Point(19, 78)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(336, 94)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Clear Full Screen Type when Full screen mode"
        '
        'cbomousebutton
        '
        Me.cbomousebutton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbomousebutton.Location = New System.Drawing.Point(154, 60)
        Me.cbomousebutton.Name = "cbomousebutton"
        Me.cbomousebutton.Size = New System.Drawing.Size(172, 20)
        Me.cbomousebutton.TabIndex = 3
        '
        'cbokey
        '
        Me.cbokey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbokey.Location = New System.Drawing.Point(154, 26)
        Me.cbokey.Name = "cbokey"
        Me.cbokey.Size = New System.Drawing.Size(172, 20)
        Me.cbokey.TabIndex = 2
        '
        'RadioButtonMouse
        '
        Me.RadioButtonMouse.Location = New System.Drawing.Point(19, 60)
        Me.RadioButtonMouse.Name = "RadioButtonMouse"
        Me.RadioButtonMouse.Size = New System.Drawing.Size(115, 18)
        Me.RadioButtonMouse.TabIndex = 1
        Me.RadioButtonMouse.Text = "Mouse Button"
        '
        'RadioButtonKey
        '
        Me.RadioButtonKey.Checked = True
        Me.RadioButtonKey.Location = New System.Drawing.Point(19, 26)
        Me.RadioButtonKey.Name = "RadioButtonKey"
        Me.RadioButtonKey.Size = New System.Drawing.Size(67, 17)
        Me.RadioButtonKey.TabIndex = 0
        Me.RadioButtonKey.TabStop = True
        Me.RadioButtonKey.Text = "Key"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(19, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 26)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Full Screen"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkusecustomvideo)
        Me.GroupBox5.Controls.Add(Me.txtcustomheight)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.txtcustomwidth)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Location = New System.Drawing.Point(490, 86)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(441, 43)
        Me.GroupBox5.TabIndex = 59
        Me.GroupBox5.TabStop = False
        '
        'chkusecustomvideo
        '
        Me.chkusecustomvideo.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.chkusecustomvideo.Location = New System.Drawing.Point(10, 9)
        Me.chkusecustomvideo.Name = "chkusecustomvideo"
        Me.chkusecustomvideo.Size = New System.Drawing.Size(172, 25)
        Me.chkusecustomvideo.TabIndex = 61
        Me.chkusecustomvideo.Text = "Use Custom Video Format"
        '
        'txtcustomheight
        '
        Me.txtcustomheight.Enabled = False
        Me.txtcustomheight.Location = New System.Drawing.Point(384, 17)
        Me.txtcustomheight.Name = "txtcustomheight"
        Me.txtcustomheight.Size = New System.Drawing.Size(48, 21)
        Me.txtcustomheight.TabIndex = 3
        Me.txtcustomheight.Text = "240"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label11.Location = New System.Drawing.Point(317, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 17)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Height"
        '
        'txtcustomwidth
        '
        Me.txtcustomwidth.Enabled = False
        Me.txtcustomwidth.Location = New System.Drawing.Point(269, 17)
        Me.txtcustomwidth.Name = "txtcustomwidth"
        Me.txtcustomwidth.Size = New System.Drawing.Size(38, 21)
        Me.txtcustomwidth.TabIndex = 1
        Me.txtcustomwidth.Text = "320"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label10.Location = New System.Drawing.Point(211, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Width"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(1062, 622)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.AxVideoCap1)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.cboaudioinput)
        Me.Controls.Add(Me.cboAudioDevice)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.cbowmv9profile)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.cbowmvprofile)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnresume)
        Me.Controls.Add(Me.btnpause)
        Me.Controls.Add(Me.btnstopcapture)
        Me.Controls.Add(Me.cbovideostand)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chkusevideocomp)
        Me.Controls.Add(Me.chkuseaudiocomp)
        Me.Controls.Add(Me.btncapture)
        Me.Controls.Add(Me.cbovideocomp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboaudiocomp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnpreview)
        Me.Controls.Add(Me.cbovideoformat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbovideoinput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbovideodevice)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Capture File Sample"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.AxVideoCap1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer

        For i = 0 To AxVideoCap1.GetDeviceCount - 1
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


        For i = 0 To AxVideoCap1.GetAudioDeviceCount - 1
            cboAudioDevice.Items.Add(AxVideoCap1.GetAudioDeviceName(i))
        Next

        If cboAudioDevice.Items.Count > 0 Then
            cboAudioDevice.SelectedIndex = 0
        End If

        For i = 0 To AxVideoCap1.GetAudioInputPinCount - 1
            cboaudioinput.Items.Add(AxVideoCap1.GetAudioInputPinName(i))
        Next

        If cboaudioinput.Items.Count > 0 Then
            cboaudioinput.SelectedIndex = 0
        End If


        For i = 0 To AxVideoCap1.GetAudioCompressorCount - 1
            cboaudiocomp.Items.Add(AxVideoCap1.GetAudioCompressorName(i))
        Next

        If cboaudiocomp.Items.Count > 0 Then
            cboaudiocomp.SelectedIndex = 0
        End If


        For i = 0 To AxVideoCap1.GetVideoCompressorCount - 1
            cbovideocomp.Items.Add(AxVideoCap1.GetVideoCompressorName(i))
        Next

        If cbovideocomp.Items.Count > 0 Then
            cbovideocomp.SelectedIndex = 0
        End If


        cbovideostand.Items.Add("Digital sensor")
        cbovideostand.Items.Add("NTSC (M) standard, 7.5 IRE black")
        cbovideostand.Items.Add("NTSC (M) standard, 0 IRE black (Japan)")
        cbovideostand.Items.Add("NTSC-433")
        cbovideostand.Items.Add("PAL -B standard")
        cbovideostand.Items.Add("PAL (D) standard")
        cbovideostand.Items.Add("PAL (H) standard")
        cbovideostand.Items.Add("PAL (I) standard")
        cbovideostand.Items.Add("PAL (M) standard")
        cbovideostand.Items.Add("PAL (N) standard")
        cbovideostand.Items.Add("PAL-60 standard")
        cbovideostand.Items.Add("SECAM (B) standard")
        cbovideostand.Items.Add("SECAM (D) standard")
        cbovideostand.Items.Add("SECAM (G) standard")
        cbovideostand.Items.Add("SECAM (H) standard")
        cbovideostand.Items.Add("SECAM (K) standard")
        cbovideostand.Items.Add("SECAM (K1) standard")
        cbovideostand.Items.Add("SECAM (L) standard")
        cbovideostand.Items.Add("SECAM (L1) standard")
        cbovideostand.Items.Add("Combination (N) PAL standard (Argentina) ")

        cbovideostand.SelectedIndex = 0




        For i = 0 To AxVideoCap1.GetWMVProfileCount - 1
            cbowmvprofile.Items.Add(AxVideoCap1.GetWMVProfileName(i))
        Next

        If cbowmvprofile.Items.Count > 0 Then
            cbowmvprofile.SelectedIndex = 0
        End If



        cbowmv9profile.Items.Add("Window Media Video/Audio 9 for 320x240")
        cbowmv9profile.Items.Add("Window Media Video/Audio 9 for 640x480")
        cbowmv9profile.Items.Add("Window Media Video/Audio 9 for 800x600")
        cbowmv9profile.Items.Add("Window Media Video/Audio 9 for 1024x768")
        cbowmv9profile.Items.Add("Window Media Video/Audio 9 for 1280x1024")
        cbowmv9profile.SelectedIndex = 0



        cbosync.Items.Add("No Sync")
        cbosync.Items.Add("Sync with stream offset (Auto Mode)")
        cbosync.Items.Add("Sync with stream offset (Manual Mode)")
        cbosync.SelectedIndex = 1

      
        cbokey.Items.Add("SpaceBar Key")
        cbokey.Items.Add("Q Key")
        cbokey.SelectedIndex = 0

        cbomousebutton.Items.Add("Left ButtonDown")
        cbomousebutton.Items.Add("Left ButtonDblClk")
        cbomousebutton.Items.Add("Right ButtonDown")
        cbomousebutton.Items.Add("Right ButtonDblClk")
        cbomousebutton.SelectedIndex = 0







    End Sub

    Sub Control_Clearfullscreenkey()

        If RadioButtonKey.Checked Then
            Me.AxVideoCap1.ClearFullScreenType = 0

            Select Case Me.cbokey.SelectedIndex
              
                Case 0
                    Me.AxVideoCap1.ClearFullScreenKey = 32 'space bar
                Case 1
                    Me.AxVideoCap1.ClearFullScreenKey = 81 'q key
            End Select


        Else
            Me.AxVideoCap1.ClearFullScreenType = 1
            Me.AxVideoCap1.ClearFullScreenMouseButton = cbomousebutton.SelectedIndex
        End If


    End Sub

    Public Function Color2Uint32(ByVal clr As Color) As UInt32
        Dim t As Int32
        Dim a() As Byte

        t = ColorTranslator.ToOle(clr)


        a = BitConverter.GetBytes(t)

        Return BitConverter.ToUInt32(a, 0)


    End Function
    Private Sub btnpreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpreview.Click
        Dim iDateFormat As Integer

        AxVideoCap1.Device = cbovideodevice.SelectedIndex
        AxVideoCap1.VideoInput = cbovideoinput.SelectedIndex
        AxVideoCap1.VideoFormat = cbovideoformat.SelectedIndex
        AxVideoCap1.VideoStandard = cbovideostand.SelectedIndex
        AxVideoCap1.AudioInputPin = cboaudioinput.SelectedIndex

        AxVideoCap1.VideoCompressor = cbovideocomp.SelectedIndex
        AxVideoCap1.AudioCompressor = cboaudiocomp.SelectedIndex
        AxVideoCap1.UseAudioCompressor = chkuseaudiocomp.Checked
        AxVideoCap1.UseVideoCompressor = chkusevideocomp.Checked

        AxVideoCap1.SyncMode = cbosync.SelectedIndex
        AxVideoCap1.SyncStreamOffset = Me.txtoffset.Text

        If chkusecustomvideo.Checked Then
            AxVideoCap1.UseCustomVideoFormat = True
            AxVideoCap1.CustomVideoWidth = Me.txtcustomwidth.Text
            AxVideoCap1.CustomVideoHeight = Me.txtcustomheight.Text

        Else
            AxVideoCap1.UseCustomVideoFormat = False

        End If
        AxVideoCap1.Start()



    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub

    Private Sub btncapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncapture.Click

        Dim iresult As Integer
        Dim iDateFormat As Integer

        If RadioButton1.Checked Then ' avi
            SaveFileDialog1.Filter = "AVI file (*.avi)|*.avi||"
            SaveFileDialog1.DefaultExt = "avi"
            AxVideoCap1.VideoCompressor = cbovideocomp.SelectedIndex
            AxVideoCap1.AudioCompressor = cboaudiocomp.SelectedIndex

            AxVideoCap1.UseAudioCompressor = chkuseaudiocomp.Checked
            AxVideoCap1.UseVideoCompressor = chkusevideocomp.Checked
            AxVideoCap1.OutputWMV = False

        Else
            SaveFileDialog1.Filter = "WMV file (*.wmv)|*.wmv||"
            SaveFileDialog1.DefaultExt = "wmv"

            AxVideoCap1.WMVProfile = cbowmvprofile.SelectedIndex
            AxVideoCap1.OutputWMV = True

        End If



        SaveFileDialog1.ShowDialog()

        AxVideoCap1.CaptureFileName = SaveFileDialog1.FileName
        AxVideoCap1.CaptureMode = True

        AxVideoCap1.Device = cbovideodevice.SelectedIndex
        AxVideoCap1.VideoInput = cbovideoinput.SelectedIndex
        AxVideoCap1.VideoFormat = cbovideoformat.SelectedIndex
        AxVideoCap1.VideoStandard = cbovideostand.SelectedIndex
        AxVideoCap1.AudioInputPin = cboaudioinput.SelectedIndex

        AxVideoCap1.SyncMode = cbosync.SelectedIndex
        AxVideoCap1.SyncStreamOffset = Me.txtoffset.Text

        If chkusecustomvideo.Checked Then
            AxVideoCap1.UseCustomVideoFormat = True
            AxVideoCap1.CustomVideoWidth = Me.txtcustomwidth.Text
            AxVideoCap1.CustomVideoHeight = Me.txtcustomheight.Text

        Else
            AxVideoCap1.UseCustomVideoFormat = False

        End If

        iresult = AxVideoCap1.Start()

        If iresult = -1 Then
            MsgBox("Capture failure, selected wrong video/audio compressor ")

        End If





    End Sub

    Private Sub btnstopcapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstopcapture.Click
        Dim iDateFormat As Integer
        AxVideoCap1.CaptureMode = False
        AxVideoCap1.Stop()
        AxVideoCap1.Start()
    End Sub


    Private Sub btnpause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpause.Click
        AxVideoCap1.Pause()
    End Sub

    Private Sub btnresume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnresume.Click
        AxVideoCap1.Resume()
    End Sub

    Private Sub chkuseaudiocomp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkuseaudiocomp.CheckedChanged

        If chkuseaudiocomp.Checked Then
            cboaudiocomp.Enabled = True
        Else
            cboaudiocomp.Enabled = False

        End If
    End Sub

    Private Sub chkusevideocomp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkusevideocomp.CheckedChanged
        If chkusevideocomp.Checked Then
            cbovideocomp.Enabled = True
        Else
            cbovideocomp.Enabled = False

        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            cbovideocomp.Enabled = True
            cboaudiocomp.Enabled = True
            cbowmvprofile.Enabled = False
            chkuseaudiocomp.Enabled = True
            chkusevideocomp.Enabled = True
            cbowmv9profile.Enabled = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            cbovideocomp.Enabled = False
            cboaudiocomp.Enabled = False
            cbowmvprofile.Enabled = True
            cbowmv9profile.Enabled = False
            chkuseaudiocomp.Enabled = False
            chkusevideocomp.Enabled = False

        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chktrantext_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chktrantext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chkfontbold_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chkfontbold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chkfontitalic_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chkfontitalic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub chkfontunderline_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chkfontunderline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chkshowdatetime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cbodatefontstyle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub









    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub







    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub







    Private Sub AxVideoCap1_Capturing(ByVal sender As System.Object, ByVal e As AxVIDEOCAPLib._DVideoCapEvents_CapturingEvent)

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            cbovideocomp.Enabled = False
            cboaudiocomp.Enabled = False
            cbowmvprofile.Enabled = False
            cbowmv9profile.Enabled = True
            chkuseaudiocomp.Enabled = False
            chkusevideocomp.Enabled = False
        End If
    End Sub

    Private Sub cbowmvprofile_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbowmvprofile.SelectedIndexChanged

    End Sub

    Private Sub cbowmv9profile_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbowmv9profile.SelectedIndexChanged
        Select Case cbowmv9profile.SelectedIndex
            Case 0
                AxVideoCap1.WMVCustomFileName = "C:\Program Files\VideoCap Pro ActiveX Control\Profiles\320x240.prx"
            Case 1
                AxVideoCap1.WMVCustomFileName = "C:\Program Files\VideoCap Pro ActiveX Control\Profiles\640x480.prx"
            Case 2
                AxVideoCap1.WMVCustomFileName = "C:\Program Files\VideoCap Pro ActiveX Control\Profiles\800x600.prx"
            Case 3
                AxVideoCap1.WMVCustomFileName = "C:\Program Files\VideoCap Pro ActiveX Control\Profiles\1024x768.prx"
            Case 4
                AxVideoCap1.WMVCustomFileName = "C:\Program Files\VideoCap Pro ActiveX Control\Profiles\1280x1024.prx"


        End Select
    End Sub



    Private Sub cborotate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub




    Private Sub cbovideodevice_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbovideodevice.SelectedIndexChanged

        Dim i As Integer
        cbovideoinput.Items.Clear()
        cbovideoformat.Items.Clear()
        AxVideoCap1.RefreshVideoDevice(cbovideodevice.SelectedIndex)
        'For i = 0 To AxVideoCap1.VideoInputs.Count - 1
        '    cbovideoinput.Items.Add(AxVideoCap1.VideoInputs.FindVideoInputName(i))
        'Next
        For i = 0 To AxVideoCap1.GetVideoInputCount - 1
            cbovideoinput.Items.Add(AxVideoCap1.GetVideoInputName(i))
        Next

        If cbovideoinput.Items.Count > 0 Then
            cbovideoinput.SelectedIndex = 0
        End If


        'For i = 0 To AxVideoCap1.VideoFormats.Count - 1
        '    cbovideoformat.Items.Add(AxVideoCap1.VideoFormats.FindVideoFormatName(i))
        'Next
        For i = 0 To AxVideoCap1.GetVideoFormatCount - 1
            cbovideoformat.Items.Add(AxVideoCap1.GetVideoFormatName(i))
        Next


        If cbovideoformat.Items.Count > 0 Then
            cbovideoformat.SelectedIndex = 0
        End If
    End Sub

    Private Sub cboAudioDevice_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAudioDevice.SelectedIndexChanged
        Dim i As Integer
        cboaudioinput.Items.Clear()
        AxVideoCap1.RefreshAudioInputPin(cboAudioDevice.SelectedIndex)

        For i = 0 To AxVideoCap1.GetAudioInputPinCount - 1
            cboaudioinput.Items.Add(AxVideoCap1.GetAudioInputPinName(i))
        Next

        If cboaudioinput.Items.Count > 0 Then
            cboaudioinput.SelectedIndex = 0
        End If
    End Sub


    Private Sub cbosync_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbosync.SelectedIndexChanged
        If cbosync.SelectedIndex = 2 Then
            Me.txtoffset.Enabled = True
        Else
            Me.txtoffset.Enabled = False

        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AxVideoCap1.ShowFullScreen(True)

    End Sub

    Private Sub cbokey_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbokey.SelectedIndexChanged
        Control_Clearfullscreenkey()
    End Sub

    Private Sub cbomousebutton_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbomousebutton.SelectedIndexChanged
        Control_Clearfullscreenkey()
    End Sub

    Private Sub RadioButtonKey_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonKey.CheckedChanged
     
    End Sub

    Private Sub RadioButtonMouse_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonMouse.CheckedChanged
       
    End Sub

    Private Sub RadioButtonKey_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButtonKey.Click
        cbokey.Enabled = True
        cbomousebutton.Enabled = False

        Control_Clearfullscreenkey()
    End Sub

    Private Sub RadioButtonMouse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButtonMouse.Click
        cbokey.Enabled = False
        cbomousebutton.Enabled = True

        Control_Clearfullscreenkey()
    End Sub

    Private Sub chkusecustomvideo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkusecustomvideo.CheckedChanged

    End Sub

    Private Sub chkusecustomvideo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkusecustomvideo.Click
        If chkusecustomvideo.Checked Then
            txtcustomwidth.Enabled = True
            txtcustomheight.Enabled = True
        Else
            txtcustomwidth.Enabled = False
            txtcustomheight.Enabled = False

        End If
    End Sub

    Private Sub AxVideoCap1_Capturing_1(ByVal sender As System.Object, ByVal e As AxVIDEOCAPLib._DVideoCapEvents_CapturingEvent) Handles AxVideoCap1.Capturing

    End Sub

    Private Sub AxVideoCap1_CustomVideoFormatError(ByVal sender As Object, ByVal e As System.EventArgs) Handles AxVideoCap1.CustomVideoFormatError
        MessageBox.Show("Custom video format failed, it does not support this custom resolution")
    End Sub

    Private Sub GroupBox3_Enter_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
End Class
