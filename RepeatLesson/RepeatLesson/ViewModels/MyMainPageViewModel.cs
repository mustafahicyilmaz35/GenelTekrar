using System.Windows.Input;
using RepeatLesson.Views;
using Xamarin.Forms;

namespace RepeatLesson.ViewModels
{
    class MyMainPageViewModel
    {
        //private ICommand _layoutCommand;

        public ICommand LayoutCommand
        {
            get => new Command(GoToLayoutsPageAsync);
        }

        private async void GoToLayoutsPageAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new LayoutsPage());
        }

        public MyMainPageViewModel()
        {
            
        }
    }
}
