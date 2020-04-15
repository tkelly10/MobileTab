using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TabbedPageWithNavigationPage
{
    public partial class TOS : ContentPage
    {
        public TOS()
        {
            InitializeComponent();

            Accept.Clicked += removeModal;
            Deny.Clicked += removeModal;
        }

        private void removeModal(object sender, EventArgs e)
        {
            this.Navigation.PopModalAsync();
        }
    }
}
