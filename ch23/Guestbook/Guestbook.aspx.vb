' Fig. 23.36: Guestbook.aspx.vb
' Code-behind file that defines event handlers for the guestbook.
Partial Class Guestbook
   Inherits System.Web.UI.Page

   ' Submit Button adds a new guestbook entry to the database,
   ' clears the form and displays the updated list of guestbook entries
   Protected Sub submitButton_Click(ByVal sender As Object, _
      ByVal e As System.EventArgs) Handles submitButton.Click

      ' create dictionary of parameters for inserting
      Dim insertParameters As New ListDictionary()

      ' add current date and the user's name, e-mail address and message
      ' to dictionary of insert parameters                              
      insertParameters.Add("Date", Date.Now.ToShortDateString())
      insertParameters.Add("Name", nameTextBox.Text)
      insertParameters.Add("Email", emailTextBox.Text)
      insertParameters.Add("Message", messageTextBox.Text)

      ' execute an INSERT LINQ statement to add a new entry to the      
      ' Messages table in the Guestbook data context that contains the  
      ' current date and the user's name, e-mail address and message    
      messagesLinqDataSource.Insert(insertParameters)

      ' clear the TextBoxes
      nameTextBox.Text = String.Empty
      emailTextBox.Text = String.Empty
      messageTextBox.Text = String.Empty

      ' update the GridView with the new database table contents
      messagesGridView.DataBind()
   End Sub ' submitButton_Click

   ' Clear Button clears the Web Form's TextBoxes
   Protected Sub clearButton_Click(ByVal sender As Object, _
      ByVal e As System.EventArgs) Handles clearButton.Click
      nameTextBox.Text = String.Empty
      emailTextBox.Text = String.Empty
      messageTextBox.Text = String.Empty
   End Sub ' clearButton_Click
End Class ' Guestbook

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

