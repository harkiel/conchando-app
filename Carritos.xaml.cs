using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace XFGoogleMapSample
{
    public partial class Carritos : ContentPage
    {
        public Carritos()
        {
            InitializeComponent();

            var polyline = new Polyline();  // metro
            polyline.Positions.Add(new Position(18.450929, -69.927689));
            polyline.Positions.Add(new Position(18.451705, -69.927635));
            polyline.Positions.Add(new Position(18.451705, -69.927343));

            polyline.IsClickable = true;
            polyline.StrokeColor = Color.Blue;
            polyline.StrokeWidth = 5f;

            map.Polylines.Add(polyline);

            var kennedy = new Polyline();
            kennedy.Positions.Add(new Position(18.479121, -69.967632));
            kennedy.Positions.Add(new Position(18.480016, -69.962311));
            kennedy.Positions.Add(new Position(18.481237, -69.956818));
            kennedy.Positions.Add(new Position(18.481888, -69.954329));
            kennedy.Positions.Add(new Position(18.482051, -69.949865));
            kennedy.Positions.Add(new Position(18.482051, -69.946604));
            kennedy.Positions.Add(new Position(18.482865, -69.943514));
            kennedy.Positions.Add(new Position(18.483761, -69.940853));
            kennedy.Positions.Add(new Position(18.484086, -69.939051));
            kennedy.Positions.Add(new Position(18.482865, -69.932957));
            kennedy.Positions.Add(new Position(18.482458, -69.926605));
            kennedy.Positions.Add(new Position(18.481807, -69.912357));
            kennedy.Positions.Add(new Position(18.481481, -69.908237));
            kennedy.Positions.Add(new Position(18.482458, -69.905319));
            kennedy.Positions.Add(new Position(18.4849, -69.904375));
            kennedy.Positions.Add(new Position(18.488808, -69.904375));

            kennedy.IsClickable = true;
            kennedy.StrokeColor = Color.Red;
            kennedy.StrokeWidth = 5f;

            map.Polylines.Add(kennedy);
            //=================================
            var luperon_parque_ind = new Polyline();
            luperon_parque_ind.Positions.Add(new Position(18.427909, -69.99042));
            luperon_parque_ind.Positions.Add(new Position(18.428723, -69.984498));
            luperon_parque_ind.Positions.Add(new Position(18.429863, -69.976602));
            luperon_parque_ind.Positions.Add(new Position(18.431818, -69.967675));
            luperon_parque_ind.Positions.Add(new Position(18.434423, -69.95995));
            luperon_parque_ind.Positions.Add(new Position(18.437233, -69.955187));
            luperon_parque_ind.Positions.Add(new Position(18.439431, -69.948235));
            luperon_parque_ind.Positions.Add(new Position(18.442037, -69.942226));
            luperon_parque_ind.Positions.Add(new Position(18.44395, -69.938064));
            luperon_parque_ind.Positions.Add(new Position(18.446067, -69.934416));
            luperon_parque_ind.Positions.Add(new Position(18.44851, -69.931412));
            luperon_parque_ind.Positions.Add(new Position(18.4514, -69.92712));
            luperon_parque_ind.Positions.Add(new Position(18.453191, -69.923902));
            luperon_parque_ind.Positions.Add(new Position(18.454616, -69.9224));
            luperon_parque_ind.Positions.Add(new Position(18.455389, -69.919739));
            luperon_parque_ind.Positions.Add(new Position(18.456122, -69.916992));
            luperon_parque_ind.Positions.Add(new Position(18.456448, -69.914975));
            luperon_parque_ind.Positions.Add(new Position(18.45775, -69.912271));
            luperon_parque_ind.Positions.Add(new Position(18.459745, -69.909568));
            luperon_parque_ind.Positions.Add(new Position(18.461577, -69.905663));
            luperon_parque_ind.Positions.Add(new Position(18.463694, -69.901586));
            luperon_parque_ind.Positions.Add(new Position(18.465688, -69.897294));
            luperon_parque_ind.Positions.Add(new Position(18.466869, -69.895535));
            luperon_parque_ind.Positions.Add(new Position(18.468456, -69.894247));
            luperon_parque_ind.Positions.Add(new Position(18.470329, -69.892874));


            luperon_parque_ind.IsClickable = true;
            luperon_parque_ind.StrokeColor = Color.Black;
            luperon_parque_ind.StrokeWidth = 5f;
            map.Polylines.Add(luperon_parque_ind);
            //=========================================


            //================================================================

            //=-=================================================================

            //===================================================================
            //var polygon = new Polygon();
            //polygon.Positions.Add(new Position(40.85d, -73.96d));
            //polygon.Positions.Add(new Position(40.87d, -74.00d));
            //polygon.Positions.Add(new Position(40.78d, -74.06d));
            //polygon.Positions.Add(new Position(40.77d, -74.02d));
            //polygon.IsClickable = true;
            //polygon.StrokeColor = Color.Green;
            //polygon.StrokeWidth = 3f;
            //polygon.FillColor = Color.FromRgba(255, 0, 0, 64);
            //map.Polygons.Add(polygon);

            //var circle = new Circle();
            //circle.Center = new Position(40.72d, -73.89d);
            //circle.Radius = Distance.FromMeters(3000f);
            //circle.StrokeColor = Color.Purple;
            //circle.StrokeWidth = 6f;
            //circle.FillColor = Color.FromRgba(0, 0, 255, 32);
            //map.Circles.Add(circle); 

            //var pinNewYork = new Pin()
            //{
            //    Type = PinType.Place,
            //    Label = "Central Park NYC",
            //    Address = "New York City, NY 10022",
            //    Position = new Position(40.78d, -73.96d),
            //    IsDraggable = true
            //};



            //map.Pins.Add(pinNewYork);
            //map.SelectedPin = pinNewYork;

            map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(18.488808, -69.904375), Distance.FromMeters(10000)), false);
        }

        void Polyline_Clicked(object sender, EventArgs e)
        {
            var polyline = (Polyline)sender;
            DisplayAlert("Polyline", $"{(string)polyline.Tag} Clicked!", "Close");


        }
    }
}

