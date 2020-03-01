using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RepeatLesson.Views.ProgressBarViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgressBarXamlPage : ContentPage
    {
        float progress = 0f;

        public ProgressBarXamlPage()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            progress += 0.2f;

            if (progress > 1)
            {
                progress = 0;
            }

            defaultProgressBar.Progress = progress;
            await styledProgressBar.ProgressTo(progress, 750, Easing.Linear);
        }


    }
}