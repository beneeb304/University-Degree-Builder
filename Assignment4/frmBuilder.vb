Imports System.ComponentModel

Public Class frmBuilder
    Private Sub frmBuilder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '------------------------------------------------------------
        '-            Subprogram Name: frmBuilder_Load              -
        '------------------------------------------------------------
        '-                Written By: Benjamin Neeb                 -
        '-                Written On: Febrary 4, 2021               -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This Subroutine clears all items from the Builder's      -
        '- listboxes. Then, populates them with the degree, course, -
        '- and program dictionaries.                                -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender – Identifies which particular control raised the  -
        '-          click event                                     -
        '- e – Holds the EventArgs object sent to the routine       -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'First, clear all items
        lstDegrees.Items.Clear()
        lstCourses.Items.Clear()

        'Populate the degree listbox with the degree dictionary
        For Each degree In frmManager.dctDegrees
            lstDegrees.Items.Add(degree.Key & " - " & degree.Value)
        Next

        'Populate the course listbox with the course dictionary
        For Each course In frmManager.dctCourses
            lstCourses.Items.Add(course.Key & " - " & course.Value)
        Next
    End Sub

    Private Sub UpdateListBoxes()
        '------------------------------------------------------------
        '-            Subprogram Name: UpdateListBoxes              -
        '------------------------------------------------------------
        '-                Written By: Benjamin Neeb                 -
        '-                Written On: Febrary 4, 2021               -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This Subroutine takes the data contained in the          -
        '- dictionaries and visually represents it by populating    -
        '- the listboxes. This is achieved by firstly clearing the  -
        '- listboxes. Then, the listboxes are populated from        -
        '- scratch, directly from the dictionaries.                 -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- (None)                                                   -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- blnEmpty:        Boolean variable that is flagged if the -
        '-                  program has courses added to it.        -
        '------------------------------------------------------------

        'Then, clear all items
        lstDegreeCourses.Items.Clear()

        Dim blnEmpty As Boolean = True

        'Cycle through degrees in programs
        For Each degree In frmManager.dctPrograms
            'If the degree key matches what is currently selected...
            If degree.Key = frmManager.strSelectedDegree Then
                'Cycle through courses in degree
                For Each course In degree.Value
                    'Add course to listbox
                    lstDegreeCourses.Items.Add(course.Key & " - " & course.Value)

                    'Set empty flag to false, since found a course
                    blnEmpty = False
                    lstDegreeCourses.Enabled = True
                Next
            End If
        Next

        'If the degree doesn't exist yet in programs (no degree courses), alert user and disable listbox
        If blnEmpty Then
            lstDegreeCourses.Items.Add("No Courses Added Yet")
            lstDegreeCourses.Enabled = False
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        '------------------------------------------------------------
        '-            Subprogram Name: btnBack_Click                -
        '------------------------------------------------------------
        '-                Written By: Benjamin Neeb                 -
        '-                Written On: Febrary 4, 2021               -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This Subroutine shows the Manager form, then closes the  -
        '- Builder form.                                            -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender – Identifies which particular control raised the  -
        '-          click event                                     -
        '- e – Holds the EventArgs object sent to the routine       -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        frmManager.Show()
        Me.Close()
    End Sub

    Private Sub frmBuilder_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        '------------------------------------------------------------
        '-            Subprogram Name: frmBuilder_Closing           -
        '------------------------------------------------------------
        '-                Written By: Benjamin Neeb                 -
        '-                Written On: Febrary 4, 2021               -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This Subroutine closes the hidden Manager form if the    -
        '- user clicks the close X on the Builder form.             -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender – Identifies which particular control raised the  -
        '-          click event                                     -
        '- e – Holds the EventArgs object sent to the routine       -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Close program if frmManager isn't visible and user clicks X
        If Not (frmManager.btnBuildDegree.Visible) Then
            frmManager.Close()
        End If
    End Sub

    Private Sub lstDegrees_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDegrees.SelectedIndexChanged
        '------------------------------------------------------------
        '-      Subprogram Name: lstDegrees_SelectedIndexChanged    -
        '------------------------------------------------------------
        '-                Written By: Benjamin Neeb                 -
        '-                Written On: Febrary 4, 2021               -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This Subroutine clears any errors if the user selects    -
        '- a degree from the degree listbox. Then, it updates the   -
        '- global variable strSelectedDegree by giving it the value -
        '- of the selected degree's designator. Lastly, it calls    -
        '- the Sub UpdateListBoxes since the user clicked on a      -
        '- degree.                                                  -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender – Identifies which particular control raised the  -
        '-          click event                                     -
        '- e – Holds the EventArgs object sent to the routine       -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Only continue if an existing row was selected
        If lstDegrees.SelectedIndex > -1 Then
            'First, reset any errors.
            ErrorProviderBuilder.Clear()

            'Change the selected degree variable by grabbing the degree prefix (before hyphen) from listbox
            frmManager.strSelectedDegree = lstDegrees.SelectedItem.ToString.Substring(0, lstDegrees.SelectedItem.ToString.IndexOf("-") - 1)

            'Populate degree-course listbox
            UpdateListBoxes()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        '------------------------------------------------------------
        '-            Subprogram Name: btnAdd_Click                 -
        '------------------------------------------------------------
        '-                Written By: Benjamin Neeb                 -
        '-                Written On: Febrary 4, 2021               -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This Subroutine firstly clears any errors. Then, it adds -
        '- whatever course(s) the user has selected to the current  -
        '- degree to make a program. If there are no errors (which  -
        '- are handled and alerted to the user), the program        -
        '- dictionary is updated accordingly. Then, the listboxes   -
        '- are updated by calling UpdateListBoxes.                  -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender – Identifies which particular control raised the  -
        '-          click event                                     -
        '- e – Holds the EventArgs object sent to the routine       -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- dctTemp:         Dictionary used temporarily to add to   -
        '-                  the program dictionary.                 -
        '------------------------------------------------------------

        'First, reset any errors.
        ErrorProviderBuilder.Clear()

        'If the user selected a course and degree, add it to the program
        If lstCourses.SelectedIndex > -1 And lstDegrees.SelectedIndex > -1 Then

            'Cycle through each item in the course listbox
            For i As Integer = 0 To lstCourses.Items.Count - 1

                'If we hit a course that is currently selected (allows mass addition)...
                If lstCourses.SelectedItems.Contains(lstCourses.Items.Item(i)) Then

                    'If the degree was already added to the programs dictionary, add the course to it.
                    'Otherwise, add both the degree and course to program
                    If frmManager.dctPrograms.ContainsKey(frmManager.strSelectedDegree) Then

                        'Cycle through each degree in programs
                        For Each degree In frmManager.dctPrograms

                            'if the degree equals the selected degree
                            If degree.Key = frmManager.strSelectedDegree Then
                                Try
                                    'add to that dictionary
                                    degree.Value.Add(frmManager.dctCourses.Keys.ElementAt(i), frmManager.dctCourses.Values.ElementAt(i))
                                Catch ex As Exception
                                    ErrorProviderBuilder.SetError(Me.lstCourses, "Already added")
                                End Try
                            End If
                        Next
                    Else
                        'Create a temporary dictionary and add the selected course to the temp dictionary
                        Dim dctTemp As New SortedDictionary(Of String, String) From {
                            {frmManager.dctCourses.Keys.ElementAt(lstCourses.SelectedIndex), frmManager.dctCourses.Values.ElementAt(i)}
                        }

                        'Add the designator and temp dictionary to program dictionary
                        frmManager.dctPrograms.Add(frmManager.strSelectedDegree, dctTemp)
                    End If
                End If
            Next
        Else
            'User did not select a course. Alert them.
            ErrorProviderBuilder.SetError(Me.lstCourses, "Select a course")
        End If

        'Clear the course selection in the listbox
        lstCourses.ClearSelected()

        'Update the course list
        UpdateListBoxes()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        '------------------------------------------------------------
        '-            Subprogram Name: btnRemove_Click              -
        '------------------------------------------------------------
        '-                Written By: Benjamin Neeb                 -
        '-                Written On: Febrary 4, 2021               -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This Subroutine firstly clears any errors. Then, it      -
        '- removes whatever course(s) the user has selected from    -
        '- the current program. If there are no errors (which are   -
        '- handled and alerted to the user), the program dictionary -
        '- is updated accordingly. Then, the listboxes are updated  -
        '- by calling UpdateListBoxes.                              -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender – Identifies which particular control raised the  -
        '-          click event                                     -
        '- e – Holds the EventArgs object sent to the routine       -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'First, reset any errors.
        ErrorProviderBuilder.Clear()

        'If the user selected a degree course remove it from the program
        If lstDegreeCourses.SelectedIndex > -1 Then
            'Cycle through each degree in programs
            For Each degree In frmManager.dctPrograms
                'if the degree equals the selected degree
                If degree.Key = frmManager.strSelectedDegree Then
                    'Cycle through each selected item in the listbox
                    For Each selection In lstDegreeCourses.SelectedItems
                        'Remove the selected courses
                        degree.Value.Remove(selection.ToString.Substring(0, selection.ToString.IndexOf("-") - 1))
                    Next
                End If
            Next
        Else
            'User did not select a course. Alert them.
            ErrorProviderBuilder.SetError(Me.lstDegreeCourses, "Select a course")
        End If

        'Clear the course selection in the listbox
        lstDegreeCourses.ClearSelected()

        'Update the course list
        UpdateListBoxes()
    End Sub
End Class