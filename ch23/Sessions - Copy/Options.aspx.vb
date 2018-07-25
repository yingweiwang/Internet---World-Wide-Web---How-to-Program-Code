' Fig. 23.28: Options.aspx.vb
' Processes user's selection of a programming language by displaying
' links and writing information in an HttpSessionState object.
Partial Class Options
   Inherits System.Web.UI.Page
   ' stores values to represent books
   Private books As New Dictionary(Of String, String)

   ' initializes the Dictionary of values to be stored in a Session 
   Protected Sub Page_Init(ByVal sender As Object,
      ByVal e As System.EventArgs) Handles Me.Init
      books.Add("Visual Basic", "0-13-215213-4")
      books.Add("Visual C#", "0-13-605322-X")
      books.Add("C", "0-13-612356-2")
      books.Add("C++", "0-13-611726-0")
      books.Add("Java", "0-13-605306-8")
   End Sub ' Page_Init

   ' if postback, hide form and display links to make additional
   ' selections or view recommendations
   Protected Sub Page_Load(ByVal sender As Object,
      ByVal e As System.EventArgs) Handles Me.Load

      If IsPostBack Then
         ' user has submitted information, so display message
         ' and appropriate hyperlinks
         responseLabel.Visible = True
         idLabel.Visible = True
         timeoutLabel.Visible = True
         languageLink.Visible = True
         recommendationsLink.Visible = True

         ' hide other controls used to make language selection
         promptLabel.Visible = False
         languageList.Visible = False
         submitButton.Visible = False

         ' if the user made a selection, display it in responseLabel
         If languageList.SelectedItem IsNot Nothing Then
            responseLabel.Text &= " You selected " &
               languageList.SelectedItem.Text
         Else
            responseLabel.Text &= "You did not select a language."
         End If

         ' display session ID                                            
         idLabel.Text = "Your unique session ID is: " & Session.SessionID

         ' display the timeout                                          
         timeoutLabel.Text = "Timeout: " & Session.Timeout & " minutes."
      End If
   End Sub ' Page_Load

   ' record the user's selection in the Session 
   Protected Sub submitButton_Click(ByVal sender As Object,
      ByVal e As System.EventArgs) Handles submitButton.Click
      ' if the user made a selection
      If languageList.SelectedItem IsNot Nothing Then
         Dim language As String = languageList.SelectedItem.Text

         ' get ISBN number of book for the given language
         Dim ISBN As String = books(language)

         Session.Add(language, ISBN) ' add name/value pair to Session
      End If
   End Sub ' submitButton_Click
End Class ' Options

'**************************************************************************
'* (C) Copyright 1992-2011 by Deitel & Associates, Inc. and               *
'* Pearson Education, Inc. All Rights Reserved.                           *
'*                                                                        *
'* DISCLAIMER: The authors and publisher of this book have used their     *
'* best efforts in preparing the book. These efforts include the          *
'* development, research, and testing of the theories and programs        *
'* to determine their effectiveness. The authors and publisher make       *
'* no warranty of any kind, expressed or implied, with regard to these    *
'* programs or to the documentation contained in these books. The authors *
'* and publisher shall not be liable in any event for incidental or       *
'* consequential damages in connection with, or arising out of, the       *
'* furnishing, performance, or use of these programs.                     *
'**************************************************************************

