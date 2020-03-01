using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RepeatLesson.Views.SwitchViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwitchMainPage : ContentPage
    {
        public ICommand NavigateCommand { get; private set; }
        public SwitchMainPage()
        {
            InitializeComponent();
            NavigateCommand = new Command<Type>(async (Type pageType) =>
            {
                Page page = (Page)Activator.CreateInstance(pageType);
                await Navigation.PushAsync(page);
            });
            BindingContext = this;
        }
        
    }
}