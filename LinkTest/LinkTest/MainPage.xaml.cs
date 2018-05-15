using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LinkTest
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            PhoneLabel.ActionTagTapped += ActionTagTapped;
            EmailLabel.ActionTagTapped += ActionTagTapped;
        }

        private void ActionTagTapped(object sender, Forms9Patch.ActionTagEventArgs e)
        {
            var toast = Forms9Patch.Toast.Create("Link Tapped", "The [" + e.Id + "] link was tapped.  It has the following href: [" + e.Href + "]");
        }

    }
}
