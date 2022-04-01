using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace API_CALL
{
    public partial class MainPage : ContentPage
    {
        RestService _restService;
        public MainPage()
        {
            InitializeComponent();
            _restService = new RestService();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            List<Repository> repositories = await _restService.GetRepositoryAsync(Constant._url);
            collectionView.ItemsSource = repositories;
        }
    }
}
