using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using RepeatLesson.Views;
using Xamarin.Forms;

namespace RepeatLesson.ViewModels
{
    class LayoutPageViewModel
    {
        public ICommand CommandAbsoluteLayout
        {
            get => new Command(GoToAbsoluteLayoutPageAsync);
        }

        public ICommand CommandFlexLayout
        {
            get => new Command(GoToFlexLayoutPageAsync);
        }

        public ICommand CommandGridLayout
        {
            get => new Command(GoToGridLayoutPageAsync);
        }

        public ICommand CommandRelativeLayout
        {
            get => new Command(GoToRelativeLayoutPageAsync);
        }

        public ICommand CommandStackLayout
        {
            get => new Command(GoToStackLayoutPageAsync);
        }

        private async void GoToStackLayoutPageAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new StackLayoutPage());
        }

        private async void GoToRelativeLayoutPageAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new RelativeLayoutPage());
        }

        private async void GoToGridLayoutPageAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new GridLayoutPage());
        }

        private async void GoToFlexLayoutPageAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new FlexLayoutPage());
        }

        private async void GoToAbsoluteLayoutPageAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AbsoluteLayoutPage());
        }

        public LayoutPageViewModel()
        {
            
        }
    }
}
