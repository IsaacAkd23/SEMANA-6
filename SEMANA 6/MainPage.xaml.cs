using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SEMANA_6
{
    public partial class MainPage : ContentPage
    {
        private const string Url = "http://192.168.0.3/moviles/post.php";
        private readonly HttpClient client =new HttpClient();
        private ObservableCollection<SEMANA_6.Datos> _post;
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnGet_Clicked(object sender, EventArgs e)
        {
            var content = await client.GetStringAsync(Url);
            List<SEMANA_6.Datos> posts = JsonConvert.DeserializeObject<List<SEMANA_6.Datos>>(content);
            _post = new ObservableCollection<SEMANA_6.Datos>(posts);
        }
    }
}
