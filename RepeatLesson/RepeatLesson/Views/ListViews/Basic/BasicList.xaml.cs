using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepeatLesson.Models.ListModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RepeatLesson.Views.ListViews.Basic
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasicList : ContentPage
    {
        
        public BasicList()
        {
            InitializeComponent();
            
        }


        private void PersonListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //ListView de seçtiğimiz bir öğeyi tekrar seçebilmemiz için bu kod parçacığını kullanıyoruz.
            if (e.SelectedItem == null) return;

            if (sender is ListView lv) lv.SelectedItem = null;
            string name = (e.SelectedItem as Person).Name;
            DisplayAlert("Merhaba", name, "OK");
        }
    }
}