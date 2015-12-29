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
    Friend WithEvents btnpreview As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbovideostand As System.Windows.Forms.ComboBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnstopcapture As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents cboAudioDevice As System.Windows.Forms.ComboBox
    Friend WithEvents cboaudioinput As System.Windows.Forms.ComboBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents AxVideoCap1 As AxVIDEOCAPLib.AxVideoCap
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtcustomwidth As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtcustomheight As System.Windows.Forms.TextBox
    Friend WithEvents chkusecustomvideo As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ChkDualDisplay As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbovideodevice = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbovideoinput = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbovideoformat = New System.Windows.Forms.ComboBox()
        Me.btnpreview = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbovideostand = New System.Windows.Forms.ComboBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnstopcapture = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.cboAudioDevice = New System.Windows.Forms.ComboBox()
        Me.cboaudioinput = New System.Windows.Forms.ComboBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.AxVideoCap1 = New AxVIDEOCAPLib.AxVideoCap()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chkusecustomvideo = New System.Windows.Forms.CheckBox()
        Me.txtcustomheight = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtcustomwidth = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ChkDualDisplay = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.AxVideoCap1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
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
        Me.btnpreview.Location = New System.Drawing.Point(8, 280)
        Me.btnpreview.Name = "btnpreview"
        Me.btnpreview.Size = New System.Drawing.Size(120, 24)
        Me.btnpreview.TabIndex = 7
        Me.btnpreview.Text = "Preview"
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
        Me.btnstopcapture.Location = New System.Drawing.Point(160, 280)
        Me.btnstopcapture.Name = "btnstopcapture"
        Me.btnstopcapture.Size = New System.Drawing.Size(128, 24)
        Me.btnstopcapture.TabIndex = 17
        Me.btnstopcapture.Text = "Stop Capture"
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
        'AxVideoCap1
        '
        Me.AxVideoCap1.Enabled = True
        Me.AxVideoCap1.Location = New System.Drawing.Point(8, 312)
        Me.AxVideoCap1.Name = "AxVideoCap1"
        Me.AxVideoCap1.OcxState = CType(resources.GetObject("AxVideoCap1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVideoCap1.Size = New System.Drawing.Size(392, 272)
        Me.AxVideoCap1.TabIndex = 55
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkusecustomvideo)
        Me.GroupBox5.Controls.Add(Me.txtcustomheight)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.txtcustomwidth)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Location = New System.Drawing.Point(408, 80)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(368, 40)
        Me.GroupBox5.TabIndex = 59
        Me.GroupBox5.TabStop = False
        '
        'chkusecustomvideo
        '
        Me.chkusecustomvideo.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.chkusecustomvideo.Location = New System.Drawing.Point(8, 8)
        Me.chkusecustomvideo.Name = "chkusecustomvideo"
        Me.chkusecustomvideo.Size = New System.Drawing.Size(144, 24)
        Me.chkusecustomvideo.TabIndex = 61
        Me.chkusecustomvideo.Text = "Use Custom Video Format"
        '
        'txtcustomheight
        '
        Me.txtcustomheight.Enabled = False
        Me.txtcustomheight.Location = New System.Drawing.Point(320, 16)
        Me.txtcustomheight.Name = "txtcustomheight"
        Me.txtcustomheight.Size = New System.Drawing.Size(40, 20)
        Me.txtcustomheight.TabIndex = 3
        Me.txtcustomheight.Text = "240"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label11.Location = New System.Drawing.Point(264, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 16)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Height"
        '
        'txtcustomwidth
        '
        Me.txtcustomwidth.Enabled = False
        Me.txtcustomwidth.Location = New System.Drawing.Point(224, 16)
        Me.txtcustomwidth.Name = "txtcustomwidth"
        Me.txtcustomwidth.Size = New System.Drawing.Size(32, 20)
        Me.txtcustomwidth.TabIndex = 1
        Me.txtcustomwidth.Text = "320"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label10.Location = New System.Drawing.Point(176, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Width"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(648, 24)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Make sure you have multimonitor display card and selected extend my Window Deskto" & _
    "p onto monitor 2 in Display Properties"
        '
        'ChkDualDisplay
        '
        Me.ChkDualDisplay.Checked = True
        Me.ChkDualDisplay.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkDualDisplay.Location = New System.Drawing.Point(16, 248)
        Me.ChkDualDisplay.Name = "ChkDualDisplay"
        Me.ChkDualDisplay.Size = New System.Drawing.Size(112, 16)
        Me.ChkDualDisplay.TabIndex = 61
        Me.ChkDualDisplay.Text = "Dual Display"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(304, 240)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 24)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "Hide Screen of Monitor 2"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(304, 272)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(152, 24)
        Me.Button2.TabIndex = 63
        Me.Button2.Text = "Show Screen of Monitor 2"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(974, 614)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ChkDualDisplay)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.AxVideoCap1)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.cboaudioinput)
        Me.Controls.Add(Me.cboAudioDevice)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.btnstopcapture)
        Me.Controls.Add(Me.cbovideostand)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnpreview)
        Me.Controls.Add(Me.cbovideoformat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbovideoinput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbovideodevice)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Dual Display"
        CType(Me.AxVideoCap1, System.ComponentModel.ISupportInitialize).EndInit()
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

    

    Public Function Color2Uint32(ByVal clr As Color) As UInt32
        Dim t As Int32
        Dim a() As Byte

        t = ColorTranslator.ToOle(clr)


        a = BitConverter.GetBytes(t)

        Return BitConverter.ToUInt32(a, 0)


    End Function
    Private Sub btnpreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpreview.Click

        AxVideoCap1.UseDualDisplay = ChkDualDisplay.Checked
        AxVideoCap1.Device = cbovideodevice.SelectedIndex
        AxVideoCap1.VideoInput = cbovideoinput.SelectedIndex
        AxVideoCap1.VideoFormat = cbovideoformat.SelectedIndex
        AxVideoCap1.VideoStandard = cbovideostand.SelectedIndex
        AxVideoCap1.AudioInputPin = cboaudioinput.SelectedIndex

 
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

    Private Sub btncapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)




    End Sub

    Private Sub btnstopcapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstopcapture.Click
        Dim iDateFormat As Integer
        AxVideoCap1.CaptureMode = False
        AxVideoCap1.Stop()
        AxVideoCap1.Start()
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

   

   



    Private Sub cborotate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub




    Private Sub cbovideodevice_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbovideodevice.SelectedIndexChanged

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


   


    Private Sub RadioButtonMouse_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

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


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AxVideoCap1.ShowDualScreen(False)
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AxVideoCap1.ShowDualScreen(True)
    End Sub
End Class
