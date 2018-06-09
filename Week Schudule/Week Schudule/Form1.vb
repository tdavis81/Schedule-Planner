Public Class Form1
#Region "Variables"
    Dim FILE_NAME As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Schudule"
    Dim Admin As String = FILE_NAME & "\Admin"
    Dim Student As String = FILE_NAME & "\Student"
    Dim mon As String = Student & "\Monday.txt"
    Dim tue As String = Student & "\Tuesday.txt"
    Dim wen As String = Student & "\Wendnesday.txt"
    Dim thu As String = Student & "\Thursday.txt"
    Dim fri As String = Student & "\Friday.txt"
    Dim sat As String = Student & "\Saturday.txt"
    Dim sun As String = Student & "\Sunday.txt"
    Dim extra As String = Student & "\extra.txt"
    Dim oldIndex As Integer
#End Region

#Region "Remove ButtoN"
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        ListBox3.Items.RemoveAt(ListBox3.SelectedIndex)
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        ListBox1.Items.RemoveAt(ListBox4.SelectedIndex)
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        ListBox5.Items.RemoveAt(ListBox5.SelectedIndex)
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        ListBox6.Items.RemoveAt(ListBox6.SelectedIndex)
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        ListBox7.Items.RemoveAt(ListBox7.SelectedIndex)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        ListBox8.Items.RemoveAt(ListBox8.SelectedIndex)
    End Sub
#End Region

#Region "Clear"
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ListBox2.Items.Clear()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        ListBox3.Items.Clear()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        ListBox4.Items.Clear()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        ListBox5.Items.Clear()
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        ListBox6.Items.Clear()
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        ListBox7.Items.Clear()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ListBox8.Items.Clear()
    End Sub
#End Region

#Region "Add Button"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text)
    End Sub


    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        ListBox2.Items.Add(TextBox2.Text)
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        ListBox3.Items.Add(TextBox3.Text)
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        ListBox4.Items.Add(TextBox4.Text)
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        ListBox5.Items.Add(TextBox5.Text)
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        ListBox6.Items.Add(TextBox6.Text)
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        ListBox7.Items.Add(TextBox7.Text)
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        ListBox8.Items.Add(TextBox8.Text)
    End Sub
#End Region


#Region "listBoxPrint"
    Private Sub listBoxPrint(ByVal listBoxSaved, ByVal fileLocation)
        Dim array(listBoxSaved.items.count) As String
        For i = 0 To listBoxSaved.Items.Count - 1
            array(i) = listBoxSaved.Items.Item(i)
            IO.File.WriteAllLines(fileLocation, array)
        Next

    End Sub
#End Region

#Region "listBoxRead"
    Private Sub listBoxRead(ByVal listBoxSaved, ByVal fileLocation)
        Dim array() As String
        array = IO.File.ReadAllLines(fileLocation)
        For i = 0 To array.Count - 1
            If array(i) IsNot "" Then
                listBoxSaved.Items.Add(array(i))
            End If
        Next
    End Sub
#End Region

#Region "Creating Files"
    Private Sub CreateFiles()
        'base files
        If IO.File.Exists(FILE_NAME & "\all files created.txt") = False Then
            MkDir(FILE_NAME)
            IO.File.CreateText(FILE_NAME & "\all files created.txt")
        End If
        If IO.File.Exists(Admin & "\all files created.txt") = False Then
            MkDir(Admin)
            IO.File.CreateText(Admin & "\all files created.txt")
        End If
        If IO.File.Exists(Student & "\all files created.txt") = False Then
            MkDir(Student)
            IO.File.CreateText(Student & "\all files created.txt")
        End If
    End Sub
#End Region

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CreateFiles()
        AcceptButton = Button1
        TextBox1.Select()
        If IO.File.Exists(Student) = True Then
            listBoxRead(ListBox1, mon)
            listBoxRead(ListBox2, tue)
            listBoxRead(ListBox3, wen)
            listBoxRead(ListBox4, thu)
            listBoxRead(ListBox5, fri)
            listBoxRead(ListBox6, sat)
            listBoxRead(ListBox7, sun)
            listBoxRead(ListBox8, extra)
        End If
     

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        listBoxPrint(ListBox1, mon)
        listBoxPrint(ListBox2, tue)
        listBoxPrint(ListBox3, wen)
        listBoxPrint(ListBox4, thu)
        listBoxPrint(ListBox5, fri)
        listBoxPrint(ListBox6, sat)
        listBoxPrint(ListBox7, sun)
        listBoxPrint(ListBox8, extra)
        MessageBox.Show("Records have been saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
