﻿

using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace RepeatLesson.Views.UserUIViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OpenGLPage : ContentPage
    {
       // private float red,green,blue;
       
        public OpenGLPage()
        {
            InitializeComponent();
            //var view = new OpenGLView { HasRenderLoop = true };
            //var toggle = new Switch{IsToggled = true};
            //var button = new Button {Text = "Display"};

            //view.WidthRequest = 300;
            //view.HeightRequest = 300;
            //view.OnDisplay = r =>
            //{
            //    GL.ClearColor(red, green, blue, 1.0f);
            //    GL.Clear((ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit));

            //    red += 0.01f;
            //    if (red >= 1.0f)
            //        red -= 1.0f;
            //    green += 0.02f;
            //    if (green >= 1.0f)
            //        green -= 1.0f;
            //    blue += 0.03f;
            //    if (blue >= 1.0f)
            //        blue -= 1.0f;
            //};

            //toggle.Toggled += (s, a) =>
            //{
            //    view.HasRenderLoop = toggle.IsToggled;
            //};
            //button.Clicked += (s, a) => view.Display();
            //var stack = new StackLayout
            //{
            //    Padding = new Size(20,20),
            //    Children = { view,toggle,button}
                
            //};
            //Content = stack;
        }

       

        
    }
}