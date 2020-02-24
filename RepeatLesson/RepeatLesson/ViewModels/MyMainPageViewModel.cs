using System;
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

        public ICommand PageStructCommand
        {

            get => new Command(GoToPageStructPageAsync);
        }

        private async void GoToPageStructPageAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PageStructPage());
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
