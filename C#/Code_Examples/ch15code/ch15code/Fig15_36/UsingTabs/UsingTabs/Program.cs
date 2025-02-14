using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UsingTabs
{
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault( false );
         Application.Run( new UsingTabsForm() );
      }
   }
}

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