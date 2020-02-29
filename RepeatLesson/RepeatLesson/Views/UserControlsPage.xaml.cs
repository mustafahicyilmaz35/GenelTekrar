using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepeatLesson.Models;
using RepeatLesson.Views.UserUIViews;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RepeatLesson.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserControlsPage : ContentPage
    {
        public UserControlsPage()
        {
            InitializeComponent();
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
            switch ((e.SelectedItem as Controls)?.Name)
            {
                case "Label":
                    Navigation.PushAsync(new LabelPage());
                    break;
                case "Image":
                    Navigation.PushAsync(new ImagePage());
                    break;
                case "BoxView":
                    Navigation.PushAsync(new BoxViewPage());
                    break;
                case "OpenGLView":
                    Navigation.PushAsync(new OpenGLPage());
                    break;
            }

        }
    }
}