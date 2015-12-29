VERSION 5.00
Object = "{F15158C8-31F4-4D02-A18E-FFDF0FFFE433}#1.0#0"; "VideoCap.ocx"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.Form Form1 
   Caption         =   "Camera Control "
   ClientHeight    =   9675
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7515
   BeginProperty Font 
      Name            =   "Tahoma"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   LinkTopic       =   "Form1"
   ScaleHeight     =   9675
   ScaleWidth      =   7515
   StartUpPosition =   3  'Windows Default
   Begin VIDEOCAPLib.VideoCap VideoCap1 
      Height          =   2775
      Left            =   240
      TabIndex        =   24
      Top             =   120
      Width           =   3135
      _Version        =   65536
      _ExtentX        =   5530
      _ExtentY        =   4895
      _StockProps     =   0
   End
   Begin VB.ComboBox cboVideoInput 
      Height          =   315
      Left            =   4920
      TabIndex        =   22
      Top             =   360
      Width           =   2175
   End
   Begin VB.CommandButton cmdProPage 
      Caption         =   "Show VideoCapture Property Page"
      Enabled         =   0   'False
      Height          =   615
      Left            =   3600
      TabIndex        =   21
      Top             =   1320
      Width           =   3015
   End
   Begin MSComctlLib.Slider BrightnessSlider1 
      Height          =   615
      Left            =   1920
      TabIndex        =   1
      Top             =   3600
      Width           =   5055
      _ExtentX        =   8916
      _ExtentY        =   1085
      _Version        =   393216
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Preview"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   3600
      TabIndex        =   0
      Top             =   720
      Width           =   975
   End
   Begin MSComctlLib.Slider ContrastSlider1 
      Height          =   615
      Left            =   1920
      TabIndex        =   3
      Top             =   4200
      Width           =   5055
      _ExtentX        =   8916
      _ExtentY        =   1085
      _Version        =   393216
   End
   Begin MSComctlLib.Slider HueSlider1 
      Height          =   615
      Left            =   1920
      TabIndex        =   6
      Top             =   4800
      Width           =   5055
      _ExtentX        =   8916
      _ExtentY        =   1085
      _Version        =   393216
   End
   Begin MSComctlLib.Slider SaturationSlider1 
      Height          =   615
      Left            =   1920
      TabIndex        =   7
      Top             =   5400
      Width           =   5055
      _ExtentX        =   8916
      _ExtentY        =   1085
      _Version        =   393216
   End
   Begin MSComctlLib.Slider SharpnessSlider1 
      Height          =   615
      Left            =   1920
      TabIndex        =   9
      Top             =   6000
      Width           =   5055
      _ExtentX        =   8916
      _ExtentY        =   1085
      _Version        =   393216
   End
   Begin MSComctlLib.Slider GammaSlider1 
      Height          =   615
      Left            =   1920
      TabIndex        =   12
      Top             =   6600
      Width           =   5055
      _ExtentX        =   8916
      _ExtentY        =   1085
      _Version        =   393216
   End
   Begin MSComctlLib.Slider ColorEnableSlider1 
      Height          =   615
      Left            =   1920
      TabIndex        =   13
      Top             =   7200
      Width           =   5055
      _ExtentX        =   8916
      _ExtentY        =   1085
      _Version        =   393216
   End
   Begin MSComctlLib.Slider WhiteBalanceSlider1 
      Height          =   615
      Left            =   1920
      TabIndex        =   15
      Top             =   7800
      Width           =   5055
      _ExtentX        =   8916
      _ExtentY        =   1085
      _Version        =   393216
   End
   Begin MSComctlLib.Slider BacklightCompensationSlider1 
      Height          =   615
      Left            =   1920
      TabIndex        =   17
      Top             =   8400
      Width           =   5055
      _ExtentX        =   8916
      _ExtentY        =   1085
      _Version        =   393216
   End
   Begin MSComctlLib.Slider GainSlider1 
      Height          =   615
      Left            =   1920
      TabIndex        =   20
      Top             =   9000
      Width           =   5055
      _ExtentX        =   8916
      _ExtentY        =   1085
      _Version        =   393216
   End
   Begin VB.Label Label11 
      Caption         =   "Video Input"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   3600
      TabIndex        =   23
      Top             =   360
      Width           =   1095
   End
   Begin VB.Label Label10 
      Caption         =   $"Form1.frx":0000
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   0
      TabIndex        =   19
      Top             =   9000
      Width           =   1935
   End
   Begin VB.Label Label9 
      Caption         =   "BacklightCompensation"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   0
      TabIndex        =   18
      Top             =   8400
      Width           =   1935
   End
   Begin VB.Label Label8 
      Caption         =   "WhiteBalance"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   0
      TabIndex        =   16
      Top             =   7800
      Width           =   1095
   End
   Begin VB.Label Label7 
      Caption         =   "Color Enable"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   0
      TabIndex        =   14
      Top             =   7200
      Width           =   1095
   End
   Begin VB.Label Label6 
      Caption         =   "Gamma"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   0
      TabIndex        =   11
      Top             =   6600
      Width           =   1095
   End
   Begin VB.Label Label5 
      Caption         =   "Sharpness"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   0
      TabIndex        =   10
      Top             =   6000
      Width           =   1095
   End
   Begin VB.Label Label4 
      Caption         =   "Saturation"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   0
      TabIndex        =   8
      Top             =   5400
      Width           =   1095
   End
   Begin VB.Label Label3 
      Caption         =   "Hue"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   0
      TabIndex        =   5
      Top             =   4800
      Width           =   1095
   End
   Begin VB.Label Label2 
      Caption         =   "Contrast"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   0
      TabIndex        =   4
      Top             =   4200
      Width           =   1095
   End
   Begin VB.Label Label1 
      Caption         =   "Brightness"
      BeginProperty Font 
         Name            =   "Verdana"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   0
      TabIndex        =   2
      Top             =   3600
      Width           =   1095
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False


Private Sub BacklightCompensationSlider1_Scroll()

Me.VideoCap1.BacklightCompensation = Me.BacklightCompensationSlider1.Value
End Sub

Private Sub BrightnessSlider1_Scroll()

Me.VideoCap1.Brightness = Me.BrightnessSlider1.Value
End Sub


Private Sub cmdProPage_Click()
Me.VideoCap1.ShowVideoCapturePropertyPage Me.hWnd
End Sub

Private Sub ColorEnableSlider1_Scroll()
Me.VideoCap1.ColorEnable = Me.ColorEnableSlider1.Value
End Sub

Private Sub Command1_Click()
   On Error Resume Next
   
   

strVideoInput = cboVideoInput.List(cboVideoInput.ListIndex)
videoinputindex = Me.VideoCap1.VideoInputs.FindVideoInput(strVideoInput)

If videoinputindex <> -1 Then
        VideoCap1.VideoInput = videoinputindex
End If
   

Me.VideoCap1.Start

cmdProPage.Enabled = True





If Me.VideoCap1.Brightness.Available Then
            Me.BrightnessSlider1.Min = Me.VideoCap1.Brightness.Min
          Me.BrightnessSlider1.Max = Me.VideoCap1.Brightness.Max
          Me.BrightnessSlider1.Value = Me.VideoCap1.Brightness.Value
Else
    Me.BrightnessSlider1.Enabled = False
End If

       
       
If Me.VideoCap1.Contrast.Available Then
       Me.ContrastSlider1.Min = Me.VideoCap1.Contrast.Min
      Me.ContrastSlider1.Max = Me.VideoCap1.Contrast.Max
      Me.ContrastSlider1.Value = Me.VideoCap1.Contrast.Value
Else
      Me.ContrastSlider1.Enabled = False
End If
        
If Me.VideoCap1.Hue.Available Then
      Me.HueSlider1.Min = Me.VideoCap1.Hue.Min
      Me.HueSlider1.Max = Me.VideoCap1.Hue.Max
      Me.HueSlider1.Value = Me.VideoCap1.Hue.Value
Else
      Me.HueSlider1.Enabled = False
End If
        
If Me.VideoCap1.Saturation.Available Then
      Me.SaturationSlider1.Min = Me.VideoCap1.Saturation.Min
      Me.SaturationSlider1.Max = Me.VideoCap1.Saturation.Max
      Me.SaturationSlider1.Value = Me.VideoCap1.Saturation.Value
Else
      Me.SaturationSlider1.Enabled = False
End If
        

If Me.VideoCap1.Sharpness.Available Then
    Me.SharpnessSlider1.Min = Me.VideoCap1.Sharpness.Min
    Me.SharpnessSlider1.Max = Me.VideoCap1.Sharpness.Max
    Me.SharpnessSlider1.Value = Me.VideoCap1.Sharpness.Value
 Else
    Me.SharpnessSlider1.Enabled = False
End If


If Me.VideoCap1.Gamma.Available Then
    Me.GammaSlider1.Min = Me.VideoCap1.Gamma.Min
    Me.GammaSlider1.Max = Me.VideoCap1.Gamma.Max
    Me.GammaSlider1.Value = Me.VideoCap1.Gamma.Value
 Else
    Me.GammaSlider1.Enabled = False
End If

If Me.VideoCap1.ColorEnable.Available Then
    Me.ColorEnableSlider1.Min = Me.VideoCap1.ColorEnable.Min
    Me.ColorEnableSlider1.Max = Me.VideoCap1.ColorEnable.Max
    Me.ColorEnableSlider1.Value = Me.VideoCap1.ColorEnable.Value
 Else
    Me.ColorEnableSlider1.Enabled = False
End If

If Me.VideoCap1.WhiteBalance.Available Then
    Me.WhiteBalanceSlider1.Min = Me.VideoCap1.WhiteBalance.Min
    Me.WhiteBalanceSlider1.Max = Me.VideoCap1.WhiteBalance.Max
    Me.WhiteBalanceSlider1.Value = Me.VideoCap1.WhiteBalance.Value
 Else
    Me.WhiteBalanceSlider1.Enabled = False
End If

If Me.VideoCap1.BacklightCompensation.Available Then
    Me.BacklightCompensationSlider1.Min = Me.VideoCap1.BacklightCompensation.Min
    Me.BacklightCompensationSlider1.Max = Me.VideoCap1.BacklightCompensation.Max
    Me.BacklightCompensationSlider1.Value = Me.VideoCap1.BacklightCompensation.Value
 Else
    Me.BacklightCompensationSlider1.Enabled = False
End If


If Me.VideoCap1.Gain.Available Then
    Me.GainSlider1.Min = Me.VideoCap1.Gain.Min
    Me.GainSlider1.Max = Me.VideoCap1.Gain.Max
    Me.GainSlider1.Value = Me.VideoCap1.Gain.Value
 Else
    Me.GainSlider1.Enabled = False
End If


    



           
End Sub


Private Sub Command2_Click()
Me.VideoCap1.ShowVideoCapturePropertyPage
End Sub

Private Sub ContrastSlider1_Scroll()
    Me.VideoCap1.Contrast = Me.ContrastSlider1.Value
End Sub



Private Sub Form_Load()


For Each myVideoInput In Me.VideoCap1.VideoInputs
        cboVideoInput.AddItem myVideoInput.Name
Next

If cboVideoInput.ListCount > 0 Then
        cboVideoInput.ListIndex = 0
 End If

End Sub

Private Sub GainSlider1_Scroll()

Me.VideoCap1.Gain = Me.GainSlider1.Value
End Sub

Private Sub GammaSlider1_Scroll()
    Me.VideoCap1.Gamma = Me.GammaSlider1.Value
End Sub

Private Sub HueSlider1_Scroll()
    Me.VideoCap1.Hue = Me.HueSlider1.Value
End Sub


Private Sub SaturationSlider1_Scroll()
  Me.VideoCap1.Saturation = Me.SaturationSlider1.Value
End Sub


Private Sub SharpnessSlider1_Scroll()
    Me.VideoCap1.Sharpness = Me.SharpnessSlider1.Value
End Sub


Private Sub WhiteBalanceSlider1_Scroll()
    Me.VideoCap1.WhiteBalance = Me.WhiteBalanceSlider1.Value
    
 End Sub
