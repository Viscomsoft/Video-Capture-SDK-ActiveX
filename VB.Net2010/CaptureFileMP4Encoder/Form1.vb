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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnpreview As System.Windows.Forms.Button
    Friend WithEvents btncapture As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbovideostand As System.Windows.Forms.ComboBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnstopcapture As System.Windows.Forms.Button
    Friend WithEvents btnpause As System.Windows.Forms.Button
    Friend WithEvents btnresume As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents cboAudioDevice As System.Windows.Forms.ComboBox
    Friend WithEvents cboaudioinput As System.Windows.Forms.ComboBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtmp4videobitrate As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents cboaudiosamplerate As System.Windows.Forms.ComboBox
    Friend WithEvents txtmp4audiobitrate As System.Windows.Forms.TextBox
    Friend WithEvents txtmp4width As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtmp4height As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtmp4audiochannels As System.Windows.Forms.TextBox
    Friend WithEvents txtmp4videoframe As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents AxVideoCap1 As AxVIDEOCAPLib.AxVideoCap
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btncapture = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbovideostand = New System.Windows.Forms.ComboBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnstopcapture = New System.Windows.Forms.Button()
        Me.btnpause = New System.Windows.Forms.Button()
        Me.btnresume = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.cboAudioDevice = New System.Windows.Forms.ComboBox()
        Me.cboaudioinput = New System.Windows.Forms.ComboBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtmp4videobitrate = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.cboaudiosamplerate = New System.Windows.Forms.ComboBox()
        Me.AxVideoCap1 = New AxVIDEOCAPLib.AxVideoCap()
        Me.txtmp4audiobitrate = New System.Windows.Forms.TextBox()
        Me.txtmp4width = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtmp4height = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtmp4audiochannels = New System.Windows.Forms.TextBox()
        Me.txtmp4videoframe = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.AxVideoCap1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Video Device"
        '
        'cbovideodevice
        '
        Me.cbovideodevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovideodevice.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbovideodevice.Location = New System.Drawing.Point(128, 24)
        Me.cbovideodevice.Name = "cbovideodevice"
        Me.cbovideodevice.Size = New System.Drawing.Size(272, 20)
        Me.cbovideodevice.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Video Input"
        '
        'cbovideoinput
        '
        Me.cbovideoinput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovideoinput.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbovideoinput.Location = New System.Drawing.Point(128, 56)
        Me.cbovideoinput.Name = "cbovideoinput"
        Me.cbovideoinput.Size = New System.Drawing.Size(272, 20)
        Me.cbovideoinput.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Video Format"
        '
        'cbovideoformat
        '
        Me.cbovideoformat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovideoformat.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbovideoformat.Location = New System.Drawing.Point(128, 88)
        Me.cbovideoformat.Name = "cbovideoformat"
        Me.cbovideoformat.Size = New System.Drawing.Size(272, 20)
        Me.cbovideoformat.TabIndex = 6
        '
        'btnpreview
        '
        Me.btnpreview.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpreview.Location = New System.Drawing.Point(8, 208)
        Me.btnpreview.Name = "btnpreview"
        Me.btnpreview.Size = New System.Drawing.Size(64, 24)
        Me.btnpreview.TabIndex = 7
        Me.btnpreview.Text = "Preview"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(408, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Video Bitrate"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(408, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Audio Sample rate"
        '
        'btncapture
        '
        Me.btncapture.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncapture.Location = New System.Drawing.Point(80, 208)
        Me.btncapture.Name = "btncapture"
        Me.btncapture.Size = New System.Drawing.Size(64, 24)
        Me.btncapture.TabIndex = 12
        Me.btncapture.Text = "Capture"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Video Stand"
        '
        'cbovideostand
        '
        Me.cbovideostand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovideostand.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbovideostand.Location = New System.Drawing.Point(128, 120)
        Me.cbovideostand.Name = "cbovideostand"
        Me.cbovideostand.Size = New System.Drawing.Size(272, 20)
        Me.cbovideostand.TabIndex = 16
        '
        'SaveFileDialog1
        '
        '
        'btnstopcapture
        '
        Me.btnstopcapture.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstopcapture.Location = New System.Drawing.Point(160, 208)
        Me.btnstopcapture.Name = "btnstopcapture"
        Me.btnstopcapture.Size = New System.Drawing.Size(72, 24)
        Me.btnstopcapture.TabIndex = 17
        Me.btnstopcapture.Text = "Stop Capture"
        '
        'btnpause
        '
        Me.btnpause.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpause.Location = New System.Drawing.Point(248, 208)
        Me.btnpause.Name = "btnpause"
        Me.btnpause.Size = New System.Drawing.Size(64, 24)
        Me.btnpause.TabIndex = 18
        Me.btnpause.Text = "Pause"
        '
        'btnresume
        '
        Me.btnresume.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnresume.Location = New System.Drawing.Point(328, 208)
        Me.btnresume.Name = "btnresume"
        Me.btnresume.Size = New System.Drawing.Size(64, 24)
        Me.btnresume.TabIndex = 19
        Me.btnresume.Text = "Resume"
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(8, 152)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(72, 16)
        Me.Label38.TabIndex = 51
        Me.Label38.Text = "Audio Device"
        '
        'cboAudioDevice
        '
        Me.cboAudioDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAudioDevice.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAudioDevice.Location = New System.Drawing.Point(128, 152)
        Me.cboAudioDevice.Name = "cboAudioDevice"
        Me.cboAudioDevice.Size = New System.Drawing.Size(272, 20)
        Me.cboAudioDevice.TabIndex = 52
        '
        'cboaudioinput
        '
        Me.cboaudioinput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboaudioinput.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboaudioinput.Location = New System.Drawing.Point(128, 184)
        Me.cboaudioinput.Name = "cboaudioinput"
        Me.cboaudioinput.Size = New System.Drawing.Size(272, 20)
        Me.cboaudioinput.TabIndex = 53
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(8, 184)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(72, 16)
        Me.Label39.TabIndex = 54
        Me.Label39.Text = "Audio Input"
        '
        'txtmp4videobitrate
        '
        Me.txtmp4videobitrate.Location = New System.Drawing.Point(525, 20)
        Me.txtmp4videobitrate.Name = "txtmp4videobitrate"
        Me.txtmp4videobitrate.Size = New System.Drawing.Size(87, 20)
        Me.txtmp4videobitrate.TabIndex = 58
        Me.txtmp4videobitrate.Text = "4600000"
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(640, 18)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(100, 23)
        Me.Label48.TabIndex = 59
        Me.Label48.Text = "Audio Bitrate"
        '
        'cboaudiosamplerate
        '
        Me.cboaudiosamplerate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboaudiosamplerate.FormattingEnabled = True
        Me.cboaudiosamplerate.Location = New System.Drawing.Point(528, 83)
        Me.cboaudiosamplerate.Name = "cboaudiosamplerate"
        Me.cboaudiosamplerate.Size = New System.Drawing.Size(84, 21)
        Me.cboaudiosamplerate.TabIndex = 63
        '
        'AxVideoCap1
        '
        Me.AxVideoCap1.Enabled = True
        Me.AxVideoCap1.Location = New System.Drawing.Point(8, 238)
        Me.AxVideoCap1.Name = "AxVideoCap1"
        Me.AxVideoCap1.OcxState = CType(resources.GetObject("AxVideoCap1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVideoCap1.Size = New System.Drawing.Size(719, 312)
        Me.AxVideoCap1.TabIndex = 66
        '
        'txtmp4audiobitrate
        '
        Me.txtmp4audiobitrate.Location = New System.Drawing.Point(737, 17)
        Me.txtmp4audiobitrate.Name = "txtmp4audiobitrate"
        Me.txtmp4audiobitrate.Size = New System.Drawing.Size(89, 20)
        Me.txtmp4audiobitrate.TabIndex = 67
        Me.txtmp4audiobitrate.Text = "224000"
        '
        'txtmp4width
        '
        Me.txtmp4width.Location = New System.Drawing.Point(525, 45)
        Me.txtmp4width.Name = "txtmp4width"
        Me.txtmp4width.Size = New System.Drawing.Size(86, 20)
        Me.txtmp4width.TabIndex = 68
        Me.txtmp4width.Text = "720"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(413, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "Width"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(642, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "Height"
        '
        'txtmp4height
        '
        Me.txtmp4height.Location = New System.Drawing.Point(741, 45)
        Me.txtmp4height.Name = "txtmp4height"
        Me.txtmp4height.Size = New System.Drawing.Size(56, 20)
        Me.txtmp4height.TabIndex = 71
        Me.txtmp4height.Text = "480"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(643, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Audio Channels"
        '
        'txtmp4audiochannels
        '
        Me.txtmp4audiochannels.Location = New System.Drawing.Point(740, 75)
        Me.txtmp4audiochannels.Name = "txtmp4audiochannels"
        Me.txtmp4audiochannels.Size = New System.Drawing.Size(56, 20)
        Me.txtmp4audiochannels.TabIndex = 73
        Me.txtmp4audiochannels.Text = "2"
        '
        'txtmp4videoframe
        '
        Me.txtmp4videoframe.Location = New System.Drawing.Point(530, 132)
        Me.txtmp4videoframe.Name = "txtmp4videoframe"
        Me.txtmp4videoframe.Size = New System.Drawing.Size(81, 20)
        Me.txtmp4videoframe.TabIndex = 74
        Me.txtmp4videoframe.Text = "25"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(414, 131)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 13)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "Video Frame Rate"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(921, 562)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtmp4videoframe)
        Me.Controls.Add(Me.txtmp4audiochannels)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtmp4height)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtmp4width)
        Me.Controls.Add(Me.txtmp4audiobitrate)
        Me.Controls.Add(Me.AxVideoCap1)
        Me.Controls.Add(Me.cboaudiosamplerate)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.txtmp4videobitrate)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.cboaudioinput)
        Me.Controls.Add(Me.cboAudioDevice)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.btnresume)
        Me.Controls.Add(Me.btnpause)
        Me.Controls.Add(Me.btnstopcapture)
        Me.Controls.Add(Me.cbovideostand)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btncapture)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnpreview)
        Me.Controls.Add(Me.cbovideoformat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbovideoinput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbovideodevice)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Capture MP4 File Sample"
        CType(Me.AxVideoCap1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public clrHashBrushBackColor As Color
    Public clrHashBrushForeColor As Color
    Public clrTranColor As Color

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        AxVideoCap1.Stop()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim i As Integer
        Dim strVideoCompName As String
        Dim strAudioCompName As String
        Dim bFindDivx As Boolean
        Dim strApp As String
        Dim iFindIndex As Integer

        strApp = Application.ExecutablePath
        iFindIndex = strApp.IndexOf("Examples")

       


        cboaudiosamplerate.Items.Add("48000")
        cboaudiosamplerate.Items.Add("44100")
        cboaudiosamplerate.SelectedIndex = 0

      


        clrHashBrushForeColor = Color.FromArgb(255, 255, 255)
        clrHashBrushBackColor = Color.FromArgb(0, 0, 0)

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

      


     



    End Sub

    Private Sub btnpreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpreview.Click
        Dim iDateFormat As Integer

        AxVideoCap1.Device = cbovideodevice.SelectedIndex
        AxVideoCap1.VideoInput = cbovideoinput.SelectedIndex
        AxVideoCap1.VideoFormat = cbovideoformat.SelectedIndex
        AxVideoCap1.VideoStandard = cbovideostand.SelectedIndex
        AxVideoCap1.AudioInputPin = cboaudioinput.SelectedIndex

        AxVideoCap1.CaptureMode = False


        AxVideoCap1.SyncMode = 1

        AxVideoCap1.Start()



    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub

    Private Sub btncapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncapture.Click
        Dim strApp As String
        Dim iFindIndex As Integer

        Dim iresult As Integer
        Dim iDateFormat As Integer




        SaveFileDialog1.Filter = "MP4 file (*.mp4)|*.mp4||"
        SaveFileDialog1.DefaultExt = "mp4"
        AxVideoCap1.UseMp4EncoderPlugin = True
        AxVideoCap1.Mp4Videobitrate = Val(txtmp4videobitrate.Text)
        AxVideoCap1.Mp4Audiobitrate = Val(txtmp4audiobitrate.Text)
        AxVideoCap1.Mp4AudioSamplerate = Val(cboaudiosamplerate.Items.Item(cboaudiosamplerate.SelectedIndex))
        AxVideoCap1.Mp4Width = Val(txtmp4width.Text)
        AxVideoCap1.Mp4Height = Val(txtmp4height.Text)
        AxVideoCap1.Mp4FrameRate = Val(txtmp4videoframe.Text)
        AxVideoCap1.Mp4Audiochannel = Val(txtmp4audiochannels.Text)

        SaveFileDialog1.ShowDialog()

        AxVideoCap1.CaptureFileName = SaveFileDialog1.FileName
        AxVideoCap1.CaptureMode = True
        AxVideoCap1.CaptureAudio = True
        AxVideoCap1.CaptureVideo = True

        AxVideoCap1.Device = cbovideodevice.SelectedIndex
        AxVideoCap1.VideoInput = cbovideoinput.SelectedIndex
        AxVideoCap1.VideoFormat = cbovideoformat.SelectedIndex
        AxVideoCap1.VideoStandard = cbovideostand.SelectedIndex
        AxVideoCap1.AudioInputPin = cboaudioinput.SelectedIndex
        AxVideoCap1.SyncMode = 1
      
        iresult = AxVideoCap1.Start()

        If iresult = -1 Then
            MessageBox.Show("Capture failure, selected wrong video/audio compressor ")

        ElseIf iresult = -3 Then

            MessageBox.Show("MP4 plugin support on windows 7 and windows 8 only")

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

    Private Sub chkuseaudiocomp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chkusevideocomp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

  

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chkshowdatetime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



   

   

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    


    Private Sub cbowmv9profile_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cbowmv9profile_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub


    Public Function Color2Uint32(ByVal clr As Color) As UInt32
        Dim t As Int32
        Dim a() As Byte

        t = ColorTranslator.ToOle(clr)


        a = BitConverter.GetBytes(t)

        Return BitConverter.ToUInt32(a, 0)


    End Function

   


    Private Sub cboAudioDevice_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAudioDevice.Click
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

    Private Sub cbovideodevice_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbovideodevice.Click
        Dim i As Integer
        cbovideoinput.Items.Clear()
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
