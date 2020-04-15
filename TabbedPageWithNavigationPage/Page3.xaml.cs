using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TabbedPageWithNavigationPage
{
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();

            TosModal.Clicked += Modal;
        }

        private void Modal(object sender, EventArgs e)
        {
            TOS t = new TOS();
            this.Navigation.PushModalAsync(t);
        }
    }
}
