using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepeatLesson.Models;
using RepeatLesson.Views.CarouselPageViews;
using RepeatLesson.Views.MasterDetailViews;
using RepeatLesson.Views.TabbedPageViews;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RepeatLesson.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageStructedPage : ContentPage
    {
        public PageStructedPage()
        {
            InitializeComponent();
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            switch ((e.SelectedItem as Pages).PageName)
            {
                case "Content Page":
                    Navigation.PushAsync(new SampleContentPage());
                    break;
                case "MasterDetail Page":
                    Navigation.PushAsync(new MasterDetailPageMenu());
                    break;
                case "Tabbed Page":
                    Navigation.PushAsync(new TabbedPageMenu());
                    break;
                case "Carousel Page":
                    Navigation.PushAsync(new CarouselPageMenu());
                    break;
                case "Navigation Page":
                    Navigation.PushAsync(new AbaoutNavigationPage());
                    break;


        }
        }
    }
}