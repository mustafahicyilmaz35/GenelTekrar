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

        public ICommand UserControlsCommand
        {

            get => new Command(GoToUserControlsPageAsync);
        }

        public ICommand PageStructedCommand
        {

            get => new Command(GoToUserPageStructedPageAsync);
        }

        private async void GoToUserPageStructedPageAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PageStructedPage());
        }

        private async void GoToUserControlsPageAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new UserControlsPage());
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
