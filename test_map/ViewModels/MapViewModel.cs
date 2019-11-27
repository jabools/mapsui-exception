using BruTile.Predefined;
using BruTile.Web;
using Mapsui;
using Mapsui.Layers;
using Mapsui.UI.Forms;

namespace test_map.ViewModels
{
    public class MapViewModel : BaseViewModel
    {
        public MapView MapView { get; set; }
        
        public MapViewModel()
        {
            Title = "Mapa";

            SetupMap();
        }

        private void SetupMap()
        {
            MapView = new MapView
            {
                IsMyLocationButtonVisible = false,
                IsNorthingButtonVisible = false,
                IsZoomButtonVisible = true,
                MyLocationLayer =
                {
                    Enabled = false
                }
            };

            var map = new Map();
            map.Layers.Add(CreateTileLayer());
            map.RotationLock = true;
        }

        private TileLayer CreateTileLayer()
        {
            return new TileLayer(CreateTileSource()) { Name = "OpenStreetMap" };
        }

        private HttpTileSource CreateTileSource()
        {
            return new HttpTileSource(new GlobalSphericalMercator(2, 19),
                "https://tile.openstreetmap.org/{z}/{x}/{y}.png",
                new[] { "a", "b", "c" }, name: "OpenStreetMap");
        }
    }
}