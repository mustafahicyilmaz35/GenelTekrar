using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RepeatLesson.Views.CheckBoxViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasicCheckBoxCodePage : ContentPage
    {
        public BasicCheckBoxCodePage()
        {
            InitializeComponent();
        }

        private void İtalicCheckBox_OnCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                label.FontAttributes |= FontAttributes.Italic;
            }
            else
            {
                label.FontAttributes &= ~FontAttributes.Italic;
            }
        }

        private void BoldCheckBox_OnCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                label.FontAttributes |= FontAttributes.Bold;
            }
            else
            {
                label.FontAttributes &= ~FontAttributes.Bold;
            }
        }

        private void UnderLineCheckBox_OnCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                label.TextDecorations |= TextDecorations.Underline;
            }
            else
            {
                label.TextDecorations &= ~TextDecorations.Underline;
            }
        }

        private void StrikethroughCheckbox_OnCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                label.TextDecorations |= TextDecorations.Strikethrough;
            }
            else
            {
                label.TextDecorations &= ~TextDecorations.Strikethrough;
            }
        }
    }
}