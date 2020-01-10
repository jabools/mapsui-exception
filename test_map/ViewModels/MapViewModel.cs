namespace test_map.ViewModels
{
    public class MapViewModel : BaseViewModel
    {
        public MySkiaView MapView { get; set; }
        
        public MapViewModel()
        {
            Title = "Mapa";

            SetupMap();
        }

        private void SetupMap()
        {
            MapView = new MySkiaView();
        }
    }
}