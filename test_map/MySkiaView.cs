using SkiaSharp.Views.Forms;
using System;
using Xamarin.Forms;

namespace test_map
{
    public class MySkiaView : SKGLView
    {
        public MySkiaView()
        {
            PaintSurface += OnPaintSurface;
        }

        void OnPaintSurface(object sender, SKPaintGLSurfaceEventArgs skPaintSurfaceEventArgs)
        {
            Console.WriteLine(CanvasSize.Width);
        }
    }
}
