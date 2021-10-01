Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class frmManager
    '------------------------------------------------------------
    '-                File Name : frmManager.vb                 - 
    '-                Part of Project: Assignment4              -
    '------------------------------------------------------------
    '-                Written By: Benjamin Neeb                 -
    '-                Written On: February 4, 2021              -
    '------------------------------------------------------------
    '- File Purpose:                                            -
    '-                                                          -
    '- This file contains the Manager portion of the program.   -
    '- The Manager keeps track Of all the degrees And classes   -
    '- offered via dictionaries. From this file, the user can   -
    '- add and delete both degrees and courses. The file loads  -
    '- with several degreed and classes already existing. Error -
    '- handling, dictionary manipulation, and control updates   -
    '- are all performed in this file.                          -
    '------------------------------------------------------------
    '- Program Purpose:                                         -
    '- This program keeps track of all degrees and courses      -
    '- offered. Then, the user can compile programs build from  -
    '- those existing degrees and courses. The program helps    -
    '- keep track of degrees and courses that exist, and        -
    '- eliminates hassle. The program visually represents the   -
    '- dictionaries via listboxes. The user performs all        -
    '- interaction with the dictionaries through the listboxes. -
    '------------------------------------------------------------
    '- Global Variable Dictionary (alphabetically):             -
    '- dctCourses:      Sorted dictionary to hold all courses   -
    '-                  offered.                                -
    '- dctDegrees:      Sorted dictionary to hold all degrees   -
    '-                  offered.                                -
    '- dctPrograms:     Sorted dictionary to hold all programs  -
    '-                  offered. Programs are comprised of a    -
    '-                  key (from degree dictionary) and a      -
    '-                  value (from course dictionary)          -
    '- strSelecteDegree: String variable that keeps track of    -
    '-                   the Key for which degree is            -
    '-                   currently selected on the Builder.     -
    '------------------------------------------------------------

    '---------------------------------------------------------------------------------------
    '--- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES ---
    '--- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES ---
    '--- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES --- GLOBAL VARIABLES ---
    '---------------------------------------------------------------------------------------

    'Sorted Dictionary to keep track of all degrees offered
    Public dctDegrees As New SortedDictionary(Of String, String)
    'Sorted Dictionary to keep track of all courses offered
    Public dctCourses As New SortedDictionary(Of String, String)
    'Sorted Dictionary to keep track of all programs offered
    Public dctPrograms As New SortedDictionary(Of String, SortedDictionary(Of String, String))
    'String to hold the currently selected degree on Builder page
    Public strSelectedDegree As String = ""

    '-----------------------------------------------------------------------------------
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '--- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS --- SUBPROGRAMS ---
    '-----------------------------------------------------------------------------------

    Private Sub frmManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '------------------------------------------------------------
        '-            Subprogram Name: frmManager_Load              -
        '------------------------------------------------------------
        '-                Written By: Benjamin Neeb                 -
        '-                Written On: Febrary 4, 2021               -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This Subroutine intially adds several degrees and        -
        '- courses to the Dictionaries. Once added, the             -
        '- dictionaries are visually represented after updating the -
        '- listboxes.                                               -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender – Identifies which particular control raised the  -
        '-          click event                                     -
        '- e – Holds the EventArgs object sent to the routine       -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Create some initial degrees (4)
        dctDegrees.Add("ACCT", "Accounting")
        dctDegrees.Add("CIS", "Computer Information Systems")
        dctDegrees.Add("CS", "Computer Science")
        dctDegrees.Add("MATH", "Mathematics")

        'Create some initial courses (12)
        dctCourses.Add("ACCT213", "Managerial Accounting")
        dctCourses.Add("ACCT214", "Financial Accounting")
        dctCourses.Add("CIS311", "Windows Programming with VB.NET")
        dctCourses.Add("CIS422", "Systems Analysis and Design")
        dctCourses.Add("CIS424", "Systems Design and Implementation")
        dctCourses.Add("CS116", "Computer Programming 1")
        dctCourses.Add("CS216", "Computer Programming 2")
        dctCourses.Add("CS146", "Visual Basic.NET Programming")
        dctCourses.Add("MATH 120B", "Algebraic Methods: Finite Math")
        dctCourses.Add("MATH 161", "Calculus 1")
        dctCourses.Add("MATH 223", "Matrix Algebra")
        dctCourses.Add("MATH 300", "Descrete Math Structures")

        'Populate Manager Page ListBoxes
        UpdateListBoxes()
    End Sub

    Private Sub UpdateListBoxes()
        '------------------------------------------------------------
        '-            Subprogram Name: UpdateListboxes              -
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
        '- (None)                                                   -
        '------------------------------------------------------------

        'First, clear all items from listboxes
        lstDegrees.Items.Clear()
        lstCourses.Items.Clear()

        'Populate the degree listbox with the degree dictionary
        For Each degree In dctDegrees
            lstDegrees.Items.Add(degree.Key & " - " & degree.Value)
        Next

        'Populate the course listbox with the course dictionary
        For Each course In dctCourses
            lstCourses.Items.Add(course.Key & " - " & course.Value)
        Next
    End Sub

    Private Sub btnAddDegree_Click(sender As Object, e As EventArgs) Handles btnAddDegree.Click
        '------------------------------------------------------------
        '-            Subprogram Name: btnAddDegree_Click           -
        '------------------------------------------------------------
        '-                Written By: Benjamin Neeb                 -
        '-                Written On: Febrary 4, 2021               -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This Subroutine takes the data entered in text boxes by  -
        '- the user and adds it to the degree dictionary. The Sub   -
        '- will catch any errors and alert the user of them. Once   -
        '- the degree information (designator and name) are         -
        '- successfully captured and entered into the degree        -
        '- dictionary, the listboxes are updated to reflect this    -
        '- addition.                                                -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender – Identifies which particular control raised the  -
        '-          click event                                     -
        '- e – Holds the EventArgs object sent to the routine       -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- strDesignator:   String variable used to capture the     -
        '-                  text from the designator textbox. Once  -
        '-                  the designator has been captured, the   -
        '-                  String is cast to uppercase.            -
        '- strName:         String variable used to capture the     -
        '-                  text from the name textbox.             -
        '------------------------------------------------------------

        'First, reset any errors.
        ErrorProviderManager.Clear()

        'Make sure designator is cast to uppercase, then read textboxes into tring variables
        Dim strDesignator As String = txtDegreeDesignator.Text.ToUpper
        Dim strName As String = txtDegreeName.Text

        'If either textbox does not meet requirements, use errorprovider
        If Not (Regex.IsMatch(strDesignator, "^[A-Z]+$")) Then
            'Check if the user provided a valid designator
            ErrorProviderManager.SetError(Me.txtDegreeDesignator, "Enter Valid Degree Designator")
            'REGEX must match: only letters allowed (CIS, CS, MATH, etc...)
        ElseIf strName = "" Then
            'Check if the user provided a valid name
            ErrorProviderManager.SetError(Me.txtDegreeName, "Cannot be empty")
        ElseIf dctDegrees.ContainsKey(strDesignator) Or dctDegrees.ContainsValue(strName) Then
            'If the designator is found in the textbox, alert
            If dctDegrees.ContainsKey(strDesignator) Then
                ErrorProviderManager.SetError(Me.txtDegreeDesignator, "Already Exists")
            End If

            'If the name is found in the textbox, alert
            If dctDegrees.ContainsValue(strName) Then
                ErrorProviderManager.SetError(Me.txtDegreeName, "Already Exists")
            End If
        Else
            'Add the degree to dictionary
            dctDegrees.Add(strDesignator, strName)

            'Update the listboxes
            UpdateListBoxes()

            'Empty textboxes
            txtDegreeDesignator.Text = ""
            txtDegreeName.Text = ""
        End If
    End Sub

    Private Sub btnDeleteDegree_Click(sender As Object, e As EventArgs) Handles btnDeleteDegree.Click
        '------------------------------------------------------------
        '-            Subprogram Name: btnDeleteDegree_Click        -
        '------------------------------------------------------------
        '-                Written By: Benjamin Neeb                 -
        '-                Written On: Febrary 4, 2021               -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This Subroutine takes the degree listbox entries         -
        '- highlighted by the user and deletes them from the degree -
        '- dictionary. The Sub will catch any errors and alert the  -
        '- user of them. Once the degree entry is successfully      -
        '- removed from the degree dictionary, the listboxes are    -
        '- updated to reflect this subtraction.                     -
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
        ErrorProviderManager.Clear()

        'If the user selected something
        If lstDegrees.SelectedIndex > -1 Then
            'Cycle through each selected degree in the listbox
            For Each selection In lstDegrees.SelectedItems
                'Remove the degree whose designator matches the listbox selection
                dctDegrees.Remove(selection.ToString.Substring(0, selection.ToString.IndexOf("-") - 1))

                'Remove the program degree whose designator matches the listbox selection
                dctPrograms.Remove(selection.ToString.Substring(0, selection.ToString.IndexOf("-") - 1))
            Next

            'Update the listboxes
            UpdateListBoxes()
        Else
            'User did not select a degree. Alert them.
            ErrorProviderManager.SetError(Me.btnDeleteDegree, "Select a Degree to Delete")
        End If
    End Sub

    Private Sub btnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click
        '------------------------------------------------------------
        '-            Subprogram Name: btnAddCourse_Click           -
        '------------------------------------------------------------
        '-                Written By: Benjamin Neeb                 -
        '-                Written On: Febrary 4, 2021               -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This Subroutine takes the data entered in text boxes by  -
        '- the user and adds it to the course dictionary. The Sub   -
        '- will catch any errors and alert the user of them. Once   -
        '- the course information (designator and name) are         -
        '- successfully captured and entered into the course        -
        '- dictionary, the listboxes are updated to reflect this    -
        '- addition.                                                -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender – Identifies which particular control raised the  -
        '-          click event                                     -
        '- e – Holds the EventArgs object sent to the routine       -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- strDesignator:   String variable used to capture the     -
        '-                  text from the designator textbox. Once  -
        '-                  the designator has been captured, the   -
        '-                  String is cast to uppercase.            -
        '- strName:         String variable used to capture the     -
        '-                  text from the name textbox.             -
        '------------------------------------------------------------

        'First, reset any errors.
        ErrorProviderManager.Clear()

        'Make sure designator is cast to uppercase, then read textboxes into tring variables
        Dim strDesignator As String = txtCourseDesignator.Text.ToUpper
        Dim strName As String = txtCourseName.Text

        'If either textbox does not meet requirements, use errorprovider
        If Not (Regex.IsMatch(strDesignator, "^[A-Za-z0-9]+$")) Then
            'Check if the user provided a valid designator
            ErrorProviderManager.SetError(Me.txtCourseDesignator, "Enter Valid Course Designator")
            'REGEX must match: only letters and numbers allowed (CIS311, CS213, MATH120B, etc...)
        ElseIf strName = "" Then
            'Check if the user provided a valid name
            ErrorProviderManager.SetError(Me.txtCourseName, "Cannot be empty")
        ElseIf dctCourses.ContainsKey(strDesignator) Or dctCourses.ContainsValue(strName) Then
            'If the designator is found in the textbox, alert
            If dctCourses.ContainsKey(strDesignator) Then
                ErrorProviderManager.SetError(Me.txtCourseDesignator, "Already Exists")
            End If

            'If the name is found in the textbox, alert
            If dctCourses.ContainsValue(strName) Then
                ErrorProviderManager.SetError(Me.txtCourseName, "Already Exists")
            End If
        Else
            'Add the course to dictionary
            dctCourses.Add(strDesignator, strName)

            'Update the listboxes
            UpdateListBoxes()

            'Empty textboxes
            txtCourseDesignator.Text = ""
            txtCourseName.Text = ""
        End If
    End Sub

    Private Sub btnDeleteCourse_Click(sender As Object, e As EventArgs) Handles btnDeleteCourse.Click
        '------------------------------------------------------------
        '-            Subprogram Name: btnDeleteCourse_Click        -
        '------------------------------------------------------------
        '-                Written By: Benjamin Neeb                 -
        '-                Written On: Febrary 4, 2021               -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This Subroutine takes the course listbox entries         -
        '- highlighted by the user and deletes them from the course -
        '- dictionary. The Sub will catch any errors and alert the  -
        '- user of them. Once the course entry is successfully      -
        '- removed from the course dictionary, the listboxes are    -
        '- updated to reflect this subtraction.                     -
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
        ErrorProviderManager.Clear()

        'If the user selected something
        If lstCourses.SelectedIndex > -1 Then
            'Cycle through each selected course in the listbox
            For Each selection In lstCourses.SelectedItems
                'Remove the course whose designator matches the listbox selection
                dctCourses.Remove(selection.ToString.Substring(0, selection.ToString.IndexOf("-") - 1))

                'Cycle through each degree in programs to remove the course from any programs
                For Each degree In dctPrograms
                    'if the degree contains the deleted course, remove that course from the degree program
                    degree.Value.Remove(selection.ToString.Substring(0, selection.ToString.IndexOf("-") - 1))
                Next
            Next

            'Update the listboxes
            UpdateListBoxes()
        Else
            'User did not select a course. Alert them.
            ErrorProviderManager.SetError(Me.btnDeleteCourse, "Select a Course to Delete")
        End If
    End Sub

    Private Sub btnBuildDegree_Click(sender As Object, e As EventArgs) Handles btnBuildDegree.Click
        '------------------------------------------------------------
        '-            Subprogram Name: btnBuildDegree_Click         -
        '------------------------------------------------------------
        '-                Written By: Benjamin Neeb                 -
        '-                Written On: Febrary 4, 2021               -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This Subroutine clears any errors on the Manager form,   -
        '- then shows the Builder form. After showing the Builder   -
        '- form, the Manager for is hidden                          -
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
        ErrorProviderManager.Clear()

        'Show Builder form
        frmBuilder.Show()

        'Hide current form
        Me.Hide()
    End Sub
End Class