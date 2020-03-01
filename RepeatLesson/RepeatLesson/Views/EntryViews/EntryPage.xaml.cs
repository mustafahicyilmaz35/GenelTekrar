using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RepeatLesson.Views.EntryViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryPage : ContentPage
    {
        public EntryPage()
        {
            InitializeComponent();
        }

        void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        void Entry_Completed(object sender, EventArgs e)
        {
        }
    }
}