using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace XFGoogleMapSample
{
    public partial class ShapesWithInitializePage : ContentPage
    {
        public ShapesWithInitializePage()
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
            var guagua_kennedy23 = new Polyline();

            guagua_kennedy23.Positions.Add(new Position(18.509482, -69.875793));
            guagua_kennedy23.Positions.Add(new Position(18.501099, -69.888239));
            guagua_kennedy23.Positions.Add(new Position(18.494099, -69.898367));
            guagua_kennedy23.Positions.Add(new Position(18.489784, -69.904032));
            guagua_kennedy23.Positions.Add(new Position(18.484982, -69.904203));
            guagua_kennedy23.Positions.Add(new Position(18.482133, -69.906006));
            guagua_kennedy23.Positions.Add(new Position(18.481807, -69.907894));
            guagua_kennedy23.Positions.Add(new Position(18.482051, -69.912701));
            guagua_kennedy23.Positions.Add(new Position(18.482702, -69.92609));
            guagua_kennedy23.Positions.Add(new Position(18.482947, -69.9333));
            guagua_kennedy23.Positions.Add(new Position(18.484493, -69.939394));
            guagua_kennedy23.Positions.Add(new Position(18.482458, -69.947376));
            guagua_kennedy23.Positions.Add(new Position(18.481237, -69.95759));
            guagua_kennedy23.Positions.Add(new Position(18.479202, -69.966602));
            guagua_kennedy23.Positions.Add(new Position(18.479283, -69.96995));
            guagua_kennedy23.Positions.Add(new Position(18.481644, -69.973297));
            guagua_kennedy23.Positions.Add(new Position(18.484819, -69.976387));
            guagua_kennedy23.Positions.Add(new Position(18.491087, -69.983082));
            guagua_kennedy23.Positions.Add(new Position(18.496459, -69.990377));
            guagua_kennedy23.Positions.Add(new Position(18.502645, -69.998274));

            guagua_kennedy23.IsClickable = true;
            guagua_kennedy23.StrokeColor = Color.Yellow;
            guagua_kennedy23.StrokeWidth = 5f;
            map.Polylines.Add(guagua_kennedy23);
            //========================================================
            var guagua_kennedy27 = new Polyline();

            guagua_kennedy27.Positions.Add(new Position(18.509482, -69.875793));
            guagua_kennedy27.Positions.Add(new Position(18.501099, -69.888239));
            guagua_kennedy27.Positions.Add(new Position(18.494099, -69.898367));
            guagua_kennedy27.Positions.Add(new Position(18.489784, -69.904032));
            guagua_kennedy27.Positions.Add(new Position(18.484982, -69.904203));
            guagua_kennedy27.Positions.Add(new Position(18.482133, -69.906006));
            guagua_kennedy27.Positions.Add(new Position(18.481807, -69.907894));
            guagua_kennedy27.Positions.Add(new Position(18.482051, -69.912701));
            guagua_kennedy27.Positions.Add(new Position(18.482702, -69.92609));
            guagua_kennedy27.Positions.Add(new Position(18.482947, -69.9333));
            guagua_kennedy27.Positions.Add(new Position(18.484493, -69.939394));
            guagua_kennedy27.Positions.Add(new Position(18.482458, -69.947376));
            guagua_kennedy27.Positions.Add(new Position(18.481237, -69.95759));
            guagua_kennedy27.Positions.Add(new Position(18.479202, -69.966602));
            guagua_kennedy27.Positions.Add(new Position(18.479283, -69.96995));
            guagua_kennedy27.Positions.Add(new Position(18.481644, -69.973297));
            guagua_kennedy27.Positions.Add(new Position(18.484819, -69.976387));
            guagua_kennedy27.Positions.Add(new Position(18.491087, -69.983082));
            guagua_kennedy27.Positions.Add(new Position(18.496459, -69.990377));
            guagua_kennedy27.Positions.Add(new Position(18.502645, -69.998274));
            guagua_kennedy27.Positions.Add(new Position(18.504721, -70.001321));
            guagua_kennedy27.Positions.Add(new Position(18.510052, -70.007501));
            guagua_kennedy27.Positions.Add(new Position(18.512453, -70.008831));
            guagua_kennedy27.Positions.Add(new Position(18.520144, -70.010076));

            guagua_kennedy27.IsClickable = true;
            guagua_kennedy27.StrokeColor = Color.Yellow;
            guagua_kennedy27.StrokeWidth = 5f;
            map.Polylines.Add(guagua_kennedy27);
            //===========================================
            var guagua_haina_paruqe_ind = new Polyline();

            guagua_haina_paruqe_ind.Positions.Add(new Position(18.426851, -70.008445));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.426769, -70.004582));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.426199, -70.001214));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.426097, -69.997244));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.427013, -69.993446));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.42797, -69.989841));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.428642, -69.984305));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.429762, -69.977009));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.431085, -69.971237));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.432245, -69.965529));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.433365, -69.962289));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.435054, -69.959071));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.436866, -69.955723));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.438006, -69.952998));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.439044, -69.949136));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.440876, -69.945531));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.442708, -69.940982));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.444703, -69.936798));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.446148, -69.93418));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.448225, -69.931755));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.450586, -69.928493));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.452296, -69.925447));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.454046, -69.922979));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.455043, -69.920983));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.455776, -69.918108));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.456326, -69.91564));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.457058, -69.913387));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.458483, -69.911392));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.460396, -69.908066));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.46231, -69.904439));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.464365, -69.900041));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.465932, -69.896843));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.468232, -69.89444));
            guagua_haina_paruqe_ind.Positions.Add(new Position(18.470614, -69.892616));

            guagua_haina_paruqe_ind.Tag = "Guagua Haina Parque INdep";
            guagua_haina_paruqe_ind.IsClickable = true;
            guagua_haina_paruqe_ind.StrokeColor = Color.Purple;
            guagua_haina_paruqe_ind.StrokeWidth = 5f;
            map.Polylines.Add(guagua_haina_paruqe_ind);

            guagua_haina_paruqe_ind.Clicked += Polyline_Clicked;
            //=======================================================

            var mini_Pind_pulga = new Polyline();

            mini_Pind_pulga.Positions.Add(new Position(18.471631, -69.893131));
            mini_Pind_pulga.Positions.Add(new Position(18.467398, -69.911156));
            mini_Pind_pulga.Positions.Add(new Position(18.463246, -69.90871));
            mini_Pind_pulga.Positions.Add(new Position(18.463246, -69.90871));
            mini_Pind_pulga.Positions.Add(new Position(18.462269, -69.909611));
            mini_Pind_pulga.Positions.Add(new Position(18.45771, -69.91961));
            mini_Pind_pulga.Positions.Add(new Position(18.453191, -69.928794));
            mini_Pind_pulga.Positions.Add(new Position(18.44851, -69.934974));
            mini_Pind_pulga.Positions.Add(new Position(18.445904, -69.934802));
            mini_Pind_pulga.Positions.Add(new Position(18.440774, -69.945617));
            mini_Pind_pulga.Positions.Add(new Position(18.437803, -69.953513));
            mini_Pind_pulga.Positions.Add(new Position(18.434505, -69.960294));
            mini_Pind_pulga.Positions.Add(new Position(18.431248, -69.970164));
            mini_Pind_pulga.Positions.Add(new Position(18.428968, -69.981108));

            mini_Pind_pulga.Tag = "Minibus Paruque Ind Pulga";
            mini_Pind_pulga.IsClickable = true;
            mini_Pind_pulga.StrokeColor = Color.Green;
            mini_Pind_pulga.StrokeWidth = 5f;
            map.Polylines.Add(mini_Pind_pulga);

            mini_Pind_pulga.Clicked += Polyline_Clicked;
            //==========================================

            var mini_pulga_9 = new Polyline();

            mini_pulga_9.Positions.Add(new Position(18.429131, -69.989862));
            mini_pulga_9.Positions.Add(new Position(18.435482, -69.983597));
            mini_pulga_9.Positions.Add(new Position(18.441263, -69.978189));
            mini_pulga_9.Positions.Add(new Position(18.447695, -69.975872));
            mini_pulga_9.Positions.Add(new Position(18.450057, -69.973984));
            mini_pulga_9.Positions.Add(new Position(18.451603, -69.973812));
            mini_pulga_9.Positions.Add(new Position(18.454372, -69.971924));
            mini_pulga_9.Positions.Add(new Position(18.459175, -69.970121));
            mini_pulga_9.Positions.Add(new Position(18.463246, -69.96892));
            mini_pulga_9.Positions.Add(new Position(18.471306, -69.968319));

            mini_pulga_9.Tag = "Minibus desde La Pulga hasta el 9";
           
            mini_pulga_9.IsClickable = true;
            mini_pulga_9.StrokeColor = Color.Pink;
            mini_pulga_9.StrokeWidth = 5f;
            map.Polylines.Add(mini_pulga_9);

            mini_pulga_9.Clicked += Polyline_Clicked;
            //=======================================
            var omsa27America = new Polyline();

           omsa27America.Positions.Add(new Position(18.505006, -69.999046));
            omsa27America.Positions.Add(new Position(18.500122, -69.999218));
            omsa27America.Positions.Add(new Position(18.494424, -69.999561));
            omsa27America.Positions.Add(new Position(18.488726, -69.999561));
            omsa27America.Positions.Add(new Position(18.485307, -69.999733));
            omsa27America.Positions.Add(new Position(18.4814, -69.997158));
            omsa27America.Positions.Add(new Position(18.47619, -69.995785));
            omsa27America.Positions.Add(new Position(18.471794, -69.994583));
            omsa27America.Positions.Add(new Position(18.466421, -69.994583));
            omsa27America.Positions.Add(new Position(18.461536, -69.992008));
            omsa27America.Positions.Add(new Position(18.459257, -69.986687));
            omsa27America.Positions.Add(new Position(18.455674, -69.981537));
            omsa27America.Positions.Add(new Position(18.451929, -69.981194));
            omsa27America.Positions.Add(new Position(18.450301, -69.976559));
            omsa27America.Positions.Add(new Position(18.449649, -69.972954));
            omsa27America.Positions.Add(new Position(18.449975, -69.968662));
            omsa27America.Positions.Add(new Position(18.451115, -69.963169));
            omsa27America.Positions.Add(new Position(18.455349, -69.953213));
            omsa27America.Positions.Add(new Position(18.459582, -69.941883));
            omsa27America.Positions.Add(new Position(18.467072, -69.927979));
            omsa27America.Positions.Add(new Position(18.473748, -69.917336));
            omsa27America.Positions.Add(new Position(18.475702, -69.907207));
            omsa27America.Positions.Add(new Position(18.479609, -69.897938));
            omsa27America.Positions.Add(new Position(18.486935, -69.888153));
            omsa27America.Positions.Add(new Position(18.486121, -69.877167));
            omsa27America.Positions.Add(new Position(18.484819, -69.864292));
            omsa27America.Positions.Add(new Position(18.485145, -69.853306));
            omsa27America.Positions.Add(new Position(18.482214, -69.847469));
            omsa27America.Positions.Add(new Position(18.481237, -69.838886));
            omsa27America.Positions.Add(new Position(18.474888, -69.833908));
            omsa27America.Positions.Add(new Position(18.468538, -69.829102));
            omsa27America.Positions.Add(new Position(18.464956, -69.817944));
            omsa27America.Positions.Add(new Position(18.464956, -69.804897));
            omsa27America.Positions.Add(new Position(18.466258, -69.790649));
            omsa27America.Positions.Add(new Position(18.465363, -69.779963));
            omsa27America.Positions.Add(new Position(18.465322, -69.778762));
            omsa27America.Positions.Add(new Position(18.4733, -69.778247));
            omsa27America.Positions.Add(new Position(18.475457, -69.777474));
            omsa27America.Positions.Add(new Position(18.475986, -69.778161));
            omsa27America.Positions.Add(new Position(18.479161, -69.777861));

            omsa27America.Tag = "Minibus desde La Pulga hasta el 9";

            omsa27America.IsClickable = true;
            omsa27America.StrokeColor = Color.Pink;
            omsa27America.StrokeWidth = 5f;
            map.Polylines.Add(omsa27America);

            omsa27America.Clicked += Polyline_Clicked;

            //=========================================

            var omsaHipVillamella = new Polyline();

            omsaHipVillamella.Positions.Add(new Position(18.480057, -69.775393));
            omsaHipVillamella.Positions.Add(new Position(18.479629, -69.776573));
            omsaHipVillamella.Positions.Add(new Position(18.479589, -69.777925));
            omsaHipVillamella.Positions.Add(new Position(18.475885, -69.77814));
            omsaHipVillamella.Positions.Add(new Position(18.475783, -69.778805));
            omsaHipVillamella.Positions.Add(new Position(18.473707, -69.77829));
            omsaHipVillamella.Positions.Add(new Position(18.465607, -69.778934));
            omsaHipVillamella.Positions.Add(new Position(18.466258, -69.793653));
            omsaHipVillamella.Positions.Add(new Position(18.464711, -69.80258));
            omsaHipVillamella.Positions.Add(new Position(18.465037, -69.817085));
            omsaHipVillamella.Positions.Add(new Position(18.466991, -69.825411));
            omsaHipVillamella.Positions.Add(new Position(18.470003, -69.830303));
            omsaHipVillamella.Positions.Add(new Position(18.49825, -69.823523));
            omsaHipVillamella.Positions.Add(new Position(18.50004, -69.823866));
            omsaHipVillamella.Positions.Add(new Position(18.525841, -69.838715));
            omsaHipVillamella.Positions.Add(new Position(18.531619, -69.845409));
            omsaHipVillamella.Positions.Add(new Position(18.534955, -69.847212));
            omsaHipVillamella.Positions.Add(new Position(18.54293, -69.858456));
            omsaHipVillamella.Positions.Add(new Position(18.543012, -69.862318));
            omsaHipVillamella.Positions.Add(new Position(18.54586, -69.86661));
            omsaHipVillamella.Positions.Add(new Position(18.544639, -69.872618));
            omsaHipVillamella.Positions.Add(new Position(18.548789, -69.885235));
            omsaHipVillamella.Positions.Add(new Position(18.545534, -69.89562));
            omsaHipVillamella.Positions.Add(new Position(18.545616, -69.90077));

            omsaHipVillamella.Tag = "Minibus desde La Pulga hasta el 9";

            omsaHipVillamella.IsClickable = true;
            omsaHipVillamella.StrokeColor = Color.Pink;
            omsaHipVillamella.StrokeWidth = 5f;
            map.Polylines.Add(omsaHipVillamella);

            omsaHipVillamella.Clicked += Polyline_Clicked;

            //================================================================
            var metroRuta1 = new Polyline();

            metroRuta1.Positions.Add(new Position(18.547243, -69.901199));
            metroRuta1.Positions.Add(new Position(18.545209, -69.900126));
            metroRuta1.Positions.Add(new Position(18.543663, -69.900727));
            metroRuta1.Positions.Add(new Position(18.543052, -69.903131));
            metroRuta1.Positions.Add(new Position(18.540652, -69.904118));
            metroRuta1.Positions.Add(new Position(18.538251, -69.905062));
            metroRuta1.Positions.Add(new Position(18.535851, -69.906735));
            metroRuta1.Positions.Add(new Position(18.53288, -69.906907));
            metroRuta1.Positions.Add(new Position(18.530602, -69.907465));
            metroRuta1.Positions.Add(new Position(18.528404, -69.909439));
            metroRuta1.Positions.Add(new Position(18.526614, -69.915404));
            metroRuta1.Positions.Add(new Position(18.523277, -69.91725));
            metroRuta1.Positions.Add(new Position(18.520754, -69.916134));
            metroRuta1.Positions.Add(new Position(18.519289, -69.914846));
            metroRuta1.Positions.Add(new Position(18.515912, -69.914975));
            metroRuta1.Positions.Add(new Position(18.511028, -69.91519));
            metroRuta1.Positions.Add(new Position(18.507732, -69.91549));
            metroRuta1.Positions.Add(new Position(18.503947, -69.915705));
            metroRuta1.Positions.Add(new Position(18.498006, -69.915276));
            metroRuta1.Positions.Add(new Position(18.491331, -69.914889));
            metroRuta1.Positions.Add(new Position(18.483801, -69.914246));
            metroRuta1.Positions.Add(new Position(18.480464, -69.914246));
            metroRuta1.Positions.Add(new Position(18.475417, -69.913259));
            metroRuta1.Positions.Add(new Position(18.469677, -69.911628));
            metroRuta1.Positions.Add(new Position(18.465932, -69.910555));
            metroRuta1.Positions.Add(new Position(18.463449, -69.909654));
            metroRuta1.Positions.Add(new Position(18.461292, -69.911757));
            metroRuta1.Positions.Add(new Position(18.459664, -69.915447));
            metroRuta1.Positions.Add(new Position(18.457343, -69.920425));
            metroRuta1.Positions.Add(new Position(18.454657, -69.925404));
            metroRuta1.Positions.Add(new Position(18.453476, -69.926519));
            metroRuta1.Positions.Add(new Position(18.452418, -69.927378));

            metroRuta1.Tag = "Metro ruta 1";

            metroRuta1.IsClickable = true;
            metroRuta1.StrokeColor = Color.Pink;
            metroRuta1.StrokeWidth = 5f;
            map.Polylines.Add(metroRuta1);

            metroRuta1.Clicked += Polyline_Clicked;
            //=-=================================================================

            var metroRuta2 = new Polyline();

            metroRuta2.Positions.Add(new Position(18.458992, -69.935725));
            metroRuta2.Positions.Add(new Position(18.478714, -69.968319));
            metroRuta2.Positions.Add(new Position(18.479935, -69.962826));
            metroRuta2.Positions.Add(new Position(18.481726, -69.955015));
            metroRuta2.Positions.Add(new Position(18.482295, -69.94772));
            metroRuta2.Positions.Add(new Position(18.484086, -69.93948));
            metroRuta2.Positions.Add(new Position(18.482784, -69.93227));
            metroRuta2.Positions.Add(new Position(18.482458, -69.925404));
            metroRuta2.Positions.Add(new Position(18.481644, -69.912357));
            metroRuta2.Positions.Add(new Position(18.481888, -69.905748));
            metroRuta2.Positions.Add(new Position(18.48547, -69.904289));
            metroRuta2.Positions.Add(new Position(18.489459, -69.904289));
            metroRuta2.Positions.Add(new Position(18.494017, -69.898024));
            metroRuta2.Positions.Add(new Position(18.49882, -69.891071));


            metroRuta2.Tag = "Metro ruta 1";

            metroRuta2.IsClickable = true;
            metroRuta2.StrokeColor = Color.Pink;
            metroRuta2.StrokeWidth = 5f;
            map.Polylines.Add(metroRuta2);

            metroRuta2.Clicked += Polyline_Clicked;
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

