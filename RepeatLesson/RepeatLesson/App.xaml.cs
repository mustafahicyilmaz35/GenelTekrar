using RepeatLesson.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RepeatLesson
{
    public partial class App : Application
    {
        public App()
        {
            Device.SetFlags(new string[] { "MediaElement_Experimental" });
            InitializeComponent();

            MainPage = new NavigationPage(new MyMainPage());
            
            
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
