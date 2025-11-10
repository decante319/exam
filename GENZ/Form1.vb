Public Class Form1
    Private Function validates() As Boolean
        If idtxt.Text = "" Or Not IsNumeric(idtxt.Text) Then MsgBox("Enter A valid ID Number") : idtxt.Focus() : Return False
        If nametxt.Text = "" Or IsNumeric(nametxt.Text) Then MsgBox("Enter A valid Name") : nametxt.Focus() : Return False
        If gendertxt.Text = "" Then MsgBox("Select Gender") : gendertxt.Focus() : Return False
        If agetxt.Text = "" Or Not IsNumeric(agetxt.Text) Then MsgBox("Enter A valid Age") : agetxt.Focus() : Return False
        If locationtxt.Text = "" Or IsNumeric(locationtxt.Text) Then MsgBox("Enter A valid Location") : locationtxt.Focus() : Return False
        If phonetxt.Text = "" Or Not IsNumeric(phonetxt.Text) Then MsgBox("Enter A valid Phone Number") : phonetxt.Focus() : Return False
        If worktxt.Text = "" Then MsgBox("Select Occupation") : worktxt.Focus() : Return False
        Return True

        End Function
    Private Sub display_Click(sender As Object, e As EventArgs) Handles display.Click
        If Not validates() Then Exit Sub
        Dim ID, NAME, GENDER, AGE, LOCATION, PHONE, WORK As String

        ID = idtxt.Text
        NAME = nametxt.Text
        GENDER = gendertxt.Text
        AGE = agetxt.Text
        LOCATION = locationtxt.Text
        PHONE = phonetxt.Text
        WORK = worktxt.Text

        Dim output As String =
            "----- Patient Details -----" & vbCrLf &
            "ID Number: " & ID & vbCrLf &
            "Name: " & NAME & vbCrLf &
            "Gender: " & GENDER & vbCrLf &
            "Age: " & AGE & vbCrLf &
            "Location: " & LOCATION & vbCrLf &
            "Phone Number: " & PHONE & vbCrLf &
            "Occupation: " & WORK

        MessageBox.Show(output)


    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        idtxt.Text = ""
        nametxt.Text = ""
        gendertxt.Text = ""

        agetxt.Text = ""
        locationtxt.Text = ""
        phonetxt.Text = ""
        worktxt.Text = ""
    End Sub
End Class
