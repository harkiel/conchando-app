using Xamarin.Forms;
using System;
namespace XFGoogleMapSample
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            masterPage.ListView.ItemSelected += OnItemSelected;

            if (Device.OS == TargetPlatform.Windows)
            {
                Master.Icon = "swap.png";
            }
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                masterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}



/*
using Xamarin.Forms;

namespace XFGoogleMapSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            buttonBasicMap.Clicked += (_, e) => Navigation.PushAsync(new BasicMapPage());
            buttonPins.Clicked += (_, e) => Navigation.PushAsync(new PinsPage());
            buttonShapes.Clicked += (_, e) => Navigation.PushAsync(new ShapesPage());
            buttonTiles.Clicked += (_, e) => Navigation.PushAsync(new TilesPage());
            buttonCustomPins.Clicked += (_, e) => Navigation.PushAsync(new CustomPinsPage());
            buttonShapesWithInitialize.Clicked += (_, e) => Navigation.PushAsync(new ShapesWithInitializePage());
            buttonBindingPin.Clicked += (_, e) => Navigation.PushAsync(new BindingPinViewPage());
            buttonGroundOverlays.Clicked += (_, e) => Navigation.PushAsync(new GroundOverlaysPage());
        }
    }
}
*/