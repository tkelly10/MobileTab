using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TabbedPageWithNavigationPage
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        public int result;
        public string message = "";

        public void CheckDriveYear(object sender, EventArgs e)
        {
            var currentYear = DateTime.Now.Year;
            int enteredYear = int.Parse(((Entry)sender).Text);

            if(currentYear - enteredYear > 16)
            {
                result = currentYear - enteredYear - 16;
                message = "You've been driving for " + result + " years";
            }
            else if(currentYear - enteredYear == 16)
            {
                result = 0;
                message = "Congrats you can try driving ";
            }
            else 
            {
                message = "You can't drive yet";
            }

            Message.Text = message;
        }
    }
}
