using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepeatLesson.Views.MasterDetailViews;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RepeatLesson.Views.TabbedPageViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPageMenu : TabbedPage
    {
        public TabbedPageMenu()
        {
            InitializeComponent();
            //this.Children.Add(new FirstPage());
            //this.Children.Add(new NavigationPage(new FirstPage()));

        }
    }
}