using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepeatLesson.Utilities.SearchBarUtilities;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RepeatLesson.Views.SearchBarViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchBarRealtimeXamlPage : ContentPage
    {
        public SearchBarRealtimeXamlPage()
        {
            InitializeComponent();
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            searchResults.ItemsSource = DataService.GetSearchResults(e.NewTextValue);
        }
    }
}