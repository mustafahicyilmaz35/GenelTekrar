using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepeatLesson.Models;
using RepeatLesson.Views.ActivityIndicatorViews;
using RepeatLesson.Views.CareouselViews;
using RepeatLesson.Views.CheckBoxViews;
using RepeatLesson.Views.CollectionViews;
using RepeatLesson.Views.ContentView;
using RepeatLesson.Views.DatePickerViews;
using RepeatLesson.Views.EntryViews;
using RepeatLesson.Views.Frame;
using RepeatLesson.Views.IndicatorViews;
using RepeatLesson.Views.ListViews.Basic;
using RepeatLesson.Views.ListViews.ContextActions;

using RepeatLesson.Views.MapViews;
using RepeatLesson.Views.PickerViews;
using RepeatLesson.Views.ProgressBarViews;
using RepeatLesson.Views.ScrollView;
using RepeatLesson.Views.SearchBarViews;
using RepeatLesson.Views.SliderViews;
using RepeatLesson.Views.StepperViews;
using RepeatLesson.Views.SwitchViews;
using RepeatLesson.Views.TableViews;
using RepeatLesson.Views.TimePickerViews;
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
            //ListView de seçtiğimiz bir öğeyi tekrar seçebilmemiz için bu kod parçacığını kullanıyoruz.
            if (e.SelectedItem == null) return;

            if (sender is ListView lv) lv.SelectedItem = null;

            switch ((e.SelectedItem as Controls)?.Name)
            {
                   
               
                case "Image":
                    Navigation.PushAsync(new ImagePage());
                    break;
                case "BoxView":
                    Navigation.PushAsync(new BoxViewPage());
                    break;
                case "OpenGLView":
                    Navigation.PushAsync(new OpenGLPage());
                    break;
                case "WebView":
                    Navigation.PushAsync(new WebViewPage());
                    break;
                case "MediaElement":
                    Navigation.PushAsync(new MediaElementPage());
                    break;
                case "Map":
                    Navigation.PushAsync(new MapMainPage());
                    break;
                case "ImageButton":
                    Navigation.PushAsync(new ImageButtonPage());
                    break;
                case "RefreshView":
                    Navigation.PushAsync(new RefreshViewPage());
                    break;
                case "SearchBar":
                    Navigation.PushAsync(new SearchBarMainPage());
                    break;
                case "CheckBox":
                    Navigation.PushAsync(new CheckBoxMainPage());
                    break;
                case "Slider":
                    Navigation.PushAsync(new SliderMainPage());
                    break;
                case "Stepper":
                    Navigation.PushAsync(new StepperMainPage());
                    break;
                case "Switch":
                    Navigation.PushAsync(new SwitchMainPage());
                    break;
                case "DatePicker":
                    Navigation.PushAsync(new DatePickerMainPage());
                    break;
                case "TimePicker":
                    Navigation.PushAsync(new TimePickerMainPage());
                    break;
                case "Text Demoları":
                    Navigation.PushAsync(new ListPage());
                    break;
                case "ActivityIndicator":
                    Navigation.PushAsync(new ActivityIndicatorMainPage());
                    break;
                case "ProgressBar":
                    Navigation.PushAsync(new ProgressBarMainPage());
                    break;
                case "CarouselView":
                    Navigation.PushAsync(new CarouselViewMainPage());
                    break;
                case "CollectionView":
                    Navigation.PushAsync(new CollectionViewMainPage());
                    break;
                case "IndicatorView":
                    Navigation.PushAsync(new IndicatorViewMainPage());
                    break;
                case "ListView":
                    Navigation.PushAsync(new BasicList());
                    break;
                case "Picker":
                    Navigation.PushAsync(new PickerMainPage());
                    break;
                case "TableView":
                    Navigation.PushAsync(new TableViewMainPage());
                    break;
                case "ContentView":
                    Navigation.PushAsync(new ContentViewMainPage());
                    break;
                case "Frame":
                    Navigation.PushAsync(new FrameMainPage());
                    break;
                case "ScrollView":
                    Navigation.PushAsync(new ScrollViewMainPage());
                    break;
            }

        }
    }
}