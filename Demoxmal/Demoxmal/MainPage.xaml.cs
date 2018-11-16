using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demoxmal
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        private void Button_OnClicked(object sender, EventArgs e)
        {
            DisplayAlert("Notification", "Do you want more shoes ?", "Yes", "No");
        }
        private void Button_OnClickedReport(object sender, EventArgs e)
        {
            DisplayAlert("Notification", "Coming Soon ", "View", "Dowmload");

        }

        private void Button_OnClickedSend(object sender, EventArgs e)
        {
            DisplayAlert("Notification", "Sent Succesfully ", "Ok", "Cancel");
        }
    }
}
