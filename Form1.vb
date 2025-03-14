Public Class Form1
    Private Sub cmd_cal_Click(sender As Object, e As EventArgs) Handles cmd_cal.Click
        Dim gross_pay, net_pay, family_leave, disability, unemployment As Decimal 'Results
        Dim fl_rate, dis_rate, un_rate As Decimal 'Rates
        Dim GP_Char1 As String

        GP_Char1 = txt_grosspay.Text 'Check if first character is a decimal point


        'Data Input
        If txt_grosspay.Text <> "" And GP_Char1.Substring(0) <> "." Then 'Only execute if field isn't blank
            gross_pay = txt_grosspay.Text
            fl_rate = txt_fl_rate.Text
            dis_rate = txt_dis_rate.Text
            un_rate = txt_un_rate.Text



            'Data Processing
            family_leave = Math.Truncate((gross_pay * fl_rate) * 100) / 100
            disability = Math.Truncate((gross_pay * dis_rate) * 100) / 100
            unemployment = Math.Truncate((gross_pay * un_rate) * 100) / 100
            net_pay = gross_pay - (family_leave + disability + unemployment)

            If gross_pay > 0 Then 'Only Execute if a value greater than 0 is entered

                'Data Output
                txt_family_leave.Text = family_leave
                txt_disability.Text = disability
                txt_unemployment.Text = unemployment
                txt_netpay.Text = net_pay

                'Go to Clear Button
                cmd_clear.Focus()
            Else
                MessageBox.Show("Please enter a number greater than 0 into the gross pay field", "WOOPS!")
                txt_grosspay.Text = ""

            End If

        Else
            MessageBox.Show("Please enter a number into the gross pay field", "NU-UH!")
            txt_grosspay.Text = ""

        End If

    End Sub

    Private Sub cmd_clear_Click(sender As Object, e As EventArgs) Handles cmd_clear.Click
        'Clear All Text Boxes
        txt_disability.Text = ""
        txt_family_leave.Text = ""
        txt_grosspay.Text = ""
        txt_netpay.Text = ""
        txt_unemployment.Text = ""

        'Place Cursor Back in Gross Pay Text Box
        txt_grosspay.Focus()



    End Sub

    Private Sub cmd_close_Click(sender As Object, e As EventArgs) Handles cmd_close.Click
        Close()
    End Sub

    Private Sub txt_grosspay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_grosspay.KeyPress
        'Only Accept Numbers
        'Allow decimal points (ASCII Code 46) and Enter Key (ASCII Code 13)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Asc(e.KeyChar) <> 46 AndAlso Asc(e.KeyChar) <> 13 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only", "NOPE!")

            e.Handled = True
        End If
        '
        '
        '
        'Enter Key Will Trigger Calculation Function
        '
        '
        '
        '
        '
        If Asc(e.KeyChar) = 13 Then ' Enter Key = 13


            Dim gross_pay, net_pay, family_leave, disability, unemployment As Decimal
            Dim fl_rate, dis_rate, un_rate As Decimal 'Rates
            Dim GP_Char1 As String


            GP_Char1 = txt_grosspay.Text 'Check if first character is a decimal point


            'Data Input
            If txt_grosspay.Text <> "" And GP_Char1.Substring(0) <> "." Then 'Only execute if field isn't blank
                gross_pay = txt_grosspay.Text
                fl_rate = txt_fl_rate.Text
                dis_rate = txt_dis_rate.Text
                un_rate = txt_un_rate.Text


                'Data Processing
                family_leave = Math.Truncate((gross_pay * fl_rate) * 100) / 100
                disability = Math.Truncate((gross_pay * dis_rate) * 100) / 100
                unemployment = Math.Truncate((gross_pay * un_rate) * 100) / 100
                net_pay = gross_pay - (family_leave + disability + unemployment)

                If gross_pay > 0 Then 'Only Execute if a value greater than 0 is entered

                    'Data Output
                    txt_family_leave.Text = family_leave
                    txt_disability.Text = disability
                    txt_unemployment.Text = unemployment
                    txt_netpay.Text = net_pay

                    'Go to Clear Button
                    cmd_clear.Focus()
                Else
                    MessageBox.Show("Please enter a number greater than 0 into the gross pay field", "WOOPS!")
                    txt_grosspay.Text = ""

                End If

            Else
                MessageBox.Show("Please enter a number into the gross pay field", "NU-UH!")
                txt_grosspay.Text = ""

            End If

        End If

    End Sub



    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim fl_rate As Decimal
        Dim dis_rate As Decimal
        Dim un_rate As Decimal



        'Load From Text File (In Progress)
        Dim reader As New System.IO.StreamReader("C:\BC\bc_save.txt")
        Dim allLines As List(Of String) = New List(Of String)
        Do While Not reader.EndOfStream
            allLines.Add(reader.ReadLine())
        Loop
        reader.Close()
        fl_rate = ReadLine(1, allLines)
        dis_rate = ReadLine(2, allLines)
        un_rate = ReadLine(3, allLines)



        'Apply Saved Rate Values to Text Boxes
        txt_fl_rate.Text = fl_rate
        txt_dis_rate.Text = dis_rate
        txt_un_rate.Text = un_rate

    End Sub

    Public Function ReadLine(lineNumber As Integer, lines As List(Of String)) As String
        Return lines(lineNumber - 1)
    End Function

    Private Sub cmd_reload_Click(sender As Object, e As EventArgs) Handles cmd_reload.Click
        Dim fl_rate As Decimal
        Dim dis_rate As Decimal
        Dim un_rate As Decimal



        'Load From Text File
        Dim reader As New System.IO.StreamReader("C:\BC\bc_save.txt")
        Dim allLines As List(Of String) = New List(Of String)
        Do While Not reader.EndOfStream
            allLines.Add(reader.ReadLine())
        Loop
        reader.Close()
        fl_rate = ReadLine(1, allLines)
        dis_rate = ReadLine(2, allLines)
        un_rate = ReadLine(3, allLines)


        'Apply Saved Rate Values to Text Boxes
        txt_fl_rate.Text = fl_rate
        txt_dis_rate.Text = dis_rate
        txt_un_rate.Text = un_rate
    End Sub

    Private Sub cmd_save_Click(sender As Object, e As EventArgs) Handles cmd_save.Click
        Dim path As String = "C:\BC\bc_save.txt"    '"C:\BC\bc_save.txt"

        'Writing Variables
        Dim write_fl_rate, write_dis_rate, write_un_rate As Decimal

        'Assign Writing Variables with Text Box Values
        write_fl_rate = txt_fl_rate.Text
        write_dis_rate = txt_dis_rate.Text
        write_un_rate = txt_un_rate.Text

        FileOpen(1, path, 2)

        'Writ to file
        WriteLine(1, write_fl_rate)
        WriteLine(1, write_dis_rate)
        WriteLine(1, write_un_rate)

        FileClose(1)



    End Sub
End Class
