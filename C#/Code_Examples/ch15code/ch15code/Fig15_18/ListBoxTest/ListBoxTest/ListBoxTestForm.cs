// Fig. 15.18: ListBoxTestForm.cs
// Program to add, remove and clear ListBox items
using System;
using System.Windows.Forms;

namespace ListBoxTest
{
   // Form uses a TextBox and Buttons to add,
   // remove, and clear ListBox items
   public partial class ListBoxTestForm : Form
   {
      // constructor
      public ListBoxTestForm()
      {
         InitializeComponent();
      } // end constructor

      // add new item to ListBox (text from input TextBox)
      // and clear input TextBox
      private void addButton_Click( object sender, EventArgs e )
      {
         displayListBox.Items.Add( inputTextBox.Text );
         inputTextBox.Clear();
      } // end method addButton_Click

      // remove item if one is selected
      private void removeButton_Click( object sender, EventArgs e )
      {
         // check whether item is selected; if so, remove
         if ( displayListBox.SelectedIndex != -1 )
            displayListBox.Items.RemoveAt( 
               displayListBox.SelectedIndex );
      } // end method removeButton_Click

      // clear all items in ListBox
      private void clearButton_Click( object sender, EventArgs e )
      {
         displayListBox.Items.Clear();
      } // end method clearButton_Click

      // exit application
      private void exitButton_Click( object sender, EventArgs e )
      {
         Application.Exit();
      } // end method exitButton_Click
   } // end class ListBoxTestForm
} // end namespace ListBoxTest

/**************************************************************************
 * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
