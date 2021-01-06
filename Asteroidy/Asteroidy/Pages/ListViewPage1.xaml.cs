using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Asteroidy.Models;
using Nito.AsyncEx;
using System.Net.Http.Json;

namespace Asteroidy.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage1 : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }
        public DataSnatcher ds = new DataSnatcher();
        public ListViewPage1()
        {
            InitializeComponent();
            



            //ConvertedObject obj = convertedObjectTask.Result;
            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
            var result = Task.Run(async () => { await client.GetFromJsonAsync<ConvertedObject>("https://api.nasa.gov/neo/rest/v1/neo/browse?api_key=kTlB1068LXF3IZeIHqWRPhMeFSNgvZVKyPOCRoRd&fbclid=IwAR1AajND0QfAHggvOj60oLoRVcQ5BWZnL3amceYZyQmulvz2DiJrFZ4Ii8Q"); });
            result.GetAwaiter().GetResult();


            Items = new ObservableCollection<string>
            {
                "Item 1",
                "Item 2",
                "Item 3",
                "Item 4",
                "Item 5"
            };

            MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
