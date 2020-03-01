using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RepeatLesson.Views.ActivityIndicatorViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivityIndicatorXamlPage : ContentPage
    {

        bool isTaskRunning;

        public ActivityIndicatorXamlPage()
        {
            InitializeComponent();
            UpdateUiState();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            isTaskRunning = !isTaskRunning;
            UpdateUiState();
        }

        void UpdateUiState()
        {
            runningStatusLabel.Text = isTaskRunning ? "A task is in progress." : "All tasks complete!";
            defaultActivityIndicator.IsRunning = isTaskRunning;
            styledActivityIndicator.IsRunning = isTaskRunning;
        }
    }
}