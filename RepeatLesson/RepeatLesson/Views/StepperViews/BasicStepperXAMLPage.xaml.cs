using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RepeatLesson.Views.StepperViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasicStepperXAMLPage : ContentPage
    {
        public BasicStepperXAMLPage()
        {
            InitializeComponent();
        }

        private void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;
            _rotatingLabel.Rotation = value;
            _displayLabel.Text = string.Format("The Stepper value is {0}", value);
        }
    }
}