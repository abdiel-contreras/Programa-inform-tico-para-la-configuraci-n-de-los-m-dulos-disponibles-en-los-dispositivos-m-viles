using Microsoft.Maui.Devices.Sensors;
using Microsoft.Maui.Networking;

namespace ConfiguracionModulos;

public partial class MainPage : ContentPage
{
    public MainPage() { InitializeComponent(); }

    private async void OnGetLocationClicked(object sender, EventArgs e)
    {
        var location = await Geolocation.Default.GetLocationAsync();
        if (location != null)
            lblGPS.Text = $"Lat: {location.Latitude}, Lon: {location.Longitude}";
    }

    private void OnCheckNetworkClicked(object sender, EventArgs e)
    {
        lblRed.Text = $"Conexión: {Connectivity.Current.NetworkAccess}";
    }
}
