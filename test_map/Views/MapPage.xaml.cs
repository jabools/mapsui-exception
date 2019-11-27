using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_map.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace test_map.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        MapViewModel viewModel;
        
        public MapPage()
        {
            InitializeComponent();
            
            BindingContext = viewModel = new MapViewModel();
        }
    }
}