Imports System.Drawing.Text

Module FontModule
    Public Function GetFont() As Font
        Dim pfc As New PrivateFontCollection()
        pfc.AddFontFile("OpenSans-Regular.ttf")
        Return New Font(pfc.Families(0), 8.25F)
    End Function
End Module
