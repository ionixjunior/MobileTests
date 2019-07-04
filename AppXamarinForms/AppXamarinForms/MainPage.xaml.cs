using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace AppXamarinForms
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private readonly DataService _dataService;

        public MainPage()
        {
            InitializeComponent();
            _dataService = new DataService();
        }

        private async void OnLoadDataClicked(object sender, EventArgs e)
        {
            lblData.Text = await _dataService.LoadData();
        }
    }
}
