using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestDemo.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.WebClient;


namespace RestDemo
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class OrdersView : ContentPage
  {
    public OrdersView()
    {
      InitializeComponent();
    }

    public async Task GetClientOrderAsync(string customerId)
    {
      try
      {
        string url = @"";
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(url);
        var response = await client.GetAsync(client.BaseAddress);
        response.EnsureSuccessStatusCode();
        var JsonResult = response.Content.ReadAsStringAsync().Result;
        var orders = JsonConvert.DeserializeObject<ODataOrder>(JsonResult);
        List<Order> listeOrders = orders.Value;
        ListeOrders.ItemsSource = listeOrders;
      }
      catch (Exception exception)
      {
        await DisplayAlert("Erreur", exception.Message, "OK");
      }
    }
  }
}