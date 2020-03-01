using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RepeatLesson.Views.CheckBoxViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasicCheckBoxVisualStatesPage : ContentPage
    {
        public BasicCheckBoxVisualStatesPage()
        {
            InitializeComponent();
        }

        private void OnItalicCheckBoxChanged(object sender, CheckedChangedEventArgs e)
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

        private void OnBoldCheckBoxChanged(object sender, CheckedChangedEventArgs e)
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

        private void OnUnderlineCheckBoxChanged(object sender, CheckedChangedEventArgs e)
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

        private void OnStrikethroughCheckBoxChanged(object sender, CheckedChangedEventArgs e)
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