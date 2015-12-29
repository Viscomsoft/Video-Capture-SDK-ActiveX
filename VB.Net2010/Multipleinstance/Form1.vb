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
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents AxVideoCap1 As AxVIDEOCAPLib.AxVideoCap
    Friend WithEvents AxVideoCap2 As AxVIDEOCAPLib.AxVideoCap
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbovideoformat2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbovideoinput2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbovideodevice2 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbovideodevice = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbovideoinput = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbovideoformat = New System.Windows.Forms.ComboBox()
        Me.btnpreview = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.AxVideoCap1 = New AxVIDEOCAPLib.AxVideoCap()
        Me.AxVideoCap2 = New AxVIDEOCAPLib.AxVideoCap()
        Me.cbovideoformat2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbovideoinput2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbovideodevice2 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.AxVideoCap1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxVideoCap2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnpreview.Location = New System.Drawing.Point(346, 155)
        Me.btnpreview.Name = "btnpreview"
        Me.btnpreview.Size = New System.Drawing.Size(144, 26)
        Me.btnpreview.TabIndex = 7
        Me.btnpreview.Text = "Preview"
        '
        'SaveFileDialog1
        '
        '
        'AxVideoCap1
        '
        Me.AxVideoCap1.Enabled = True
        Me.AxVideoCap1.Location = New System.Drawing.Point(19, 190)
        Me.AxVideoCap1.Name = "AxVideoCap1"
        Me.AxVideoCap1.OcxState = CType(resources.GetObject("AxVideoCap1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVideoCap1.Size = New System.Drawing.Size(471, 292)
        Me.AxVideoCap1.TabIndex = 55
        '
        'AxVideoCap2
        '
        Me.AxVideoCap2.Enabled = True
        Me.AxVideoCap2.Location = New System.Drawing.Point(538, 190)
        Me.AxVideoCap2.Name = "AxVideoCap2"
        Me.AxVideoCap2.OcxState = CType(resources.GetObject("AxVideoCap2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVideoCap2.Size = New System.Drawing.Size(470, 292)
        Me.AxVideoCap2.TabIndex = 56
        '
        'cbovideoformat2
        '
        Me.cbovideoformat2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovideoformat2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbovideoformat2.Location = New System.Drawing.Point(672, 95)
        Me.cbovideoformat2.Name = "cbovideoformat2"
        Me.cbovideoformat2.Size = New System.Drawing.Size(326, 20)
        Me.cbovideoformat2.TabIndex = 62
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(528, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 25)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Video Format"
        '
        'cbovideoinput2
        '
        Me.cbovideoinput2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovideoinput2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbovideoinput2.Location = New System.Drawing.Point(672, 60)
        Me.cbovideoinput2.Name = "cbovideoinput2"
        Me.cbovideoinput2.Size = New System.Drawing.Size(326, 20)
        Me.cbovideoinput2.TabIndex = 60
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(528, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 25)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Video Input"
        '
        'cbovideodevice2
        '
        Me.cbovideodevice2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovideodevice2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbovideodevice2.Location = New System.Drawing.Point(672, 26)
        Me.cbovideodevice2.Name = "cbovideodevice2"
        Me.cbovideodevice2.Size = New System.Drawing.Size(326, 20)
        Me.cbovideodevice2.TabIndex = 58
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(528, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 25)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Video Device"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(854, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 26)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "Preview"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(1085, 614)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbovideoformat2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbovideoinput2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbovideodevice2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.AxVideoCap2)
        Me.Controls.Add(Me.AxVideoCap1)
        Me.Controls.Add(Me.btnpreview)
        Me.Controls.Add(Me.cbovideoformat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbovideoinput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbovideodevice)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Multiple instance"
        CType(Me.AxVideoCap1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxVideoCap2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer

        For i = 0 To AxVideoCap1.GetDeviceCount - 1
            cbovideodevice.Items.Add(AxVideoCap1.GetDeviceName(i))
            cbovideodevice2.Items.Add(AxVideoCap1.GetDeviceName(i))
        Next

        If cbovideodevice.Items.Count > 0 Then
            cbovideodevice.SelectedIndex = 0
            cbovideodevice2.SelectedIndex = 0
        End If

        For i = 0 To AxVideoCap1.GetVideoInputCount- 1
            cbovideoinput.Items.Add(AxVideoCap1.GetVideoInputName(i))
            cbovideoinput2.Items.Add(AxVideoCap1.GetVideoInputName(i))
        Next

        If cbovideoinput.Items.Count > 0 Then
            cbovideoinput.SelectedIndex = 0
            cbovideoinput2.SelectedIndex = 0
        End If


        For i = 0 To AxVideoCap1.GetVideoFormatCount - 1
            cbovideoformat.Items.Add(AxVideoCap1.GetVideoFormatName(i))
            cbovideoformat2.Items.Add(AxVideoCap1.GetVideoFormatName(i))
        Next

        If cbovideoformat.Items.Count > 0 Then
            cbovideoformat.SelectedIndex = 0
            cbovideoformat2.SelectedIndex = 0
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

       AxVideoCap1.Device = cbovideodevice.SelectedIndex
        AxVideoCap1.VideoInput = cbovideoinput.SelectedIndex
        AxVideoCap1.VideoFormat = cbovideoformat.SelectedIndex
       
 
        AxVideoCap1.Start()



    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub

    Private Sub btncapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)




    End Sub

    Private Sub btnstopcapture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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



    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        AxVideoCap2.Device = cbovideodevice2.SelectedIndex
        AxVideoCap2.VideoInput = cbovideoinput2.SelectedIndex
        AxVideoCap2.VideoFormat = cbovideoformat2.SelectedIndex


        AxVideoCap2.Start()


    End Sub

    Private Sub cbovideodevice2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbovideodevice2.SelectedIndexChanged
        Dim i As Integer
        cbovideoinput2.Items.Clear()
        cbovideoformat2.Items.Clear()
        AxVideoCap2.RefreshVideoDevice(cbovideodevice2.SelectedIndex)

        For i = 0 To AxVideoCap2.GetVideoInputCount- 1
            cbovideoinput2.Items.Add(AxVideoCap2.GetVideoInputName(i))
        Next

        If cbovideoinput2.Items.Count > 0 Then
            cbovideoinput2.SelectedIndex = 0
        End If


        For i = 0 To AxVideoCap2.GetVideoFormatCount- 1
            cbovideoformat2.Items.Add(AxVideoCap2.GetVideoFormatName(i))
        Next

        If cbovideoformat2.Items.Count > 0 Then
            cbovideoformat2.SelectedIndex = 0
        End If
    End Sub
End Class
