using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using RepeatLesson.Annotations;
using RepeatLesson.Models;

namespace RepeatLesson.ViewModels
{
    public class UserControlsPageViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<Controls> _controls;

        public ObservableCollection<Controls> Controls
        {
            get => _controls;
            set
            {
                _controls = value;
                OnPropertyChanged(nameof(Controls));
                
            }
        }


        public UserControlsPageViewModel()
        {
            Controls = new ObservableCollection<Controls>
            {
                //31 tane kullanıcı kontrolü vardır.

               
                new Controls{Name = "Image"},
                new Controls{Name = "BoxView"},
                new Controls{Name = "WebView"},
                new Controls{Name = "OpenGLView"},
                new Controls{Name = "Map"},
                new Controls{Name = "MediaElement"},
                new Controls{Name = "Button"},
                new Controls{Name = "ImageButton"},
                new Controls{Name = "RefreshView"},
                new Controls{Name = "SearchBar"},
                new Controls{Name = "SwipeView"},
                new Controls{Name = "CheckBox"},
                new Controls{Name = "Slider"},
                new Controls{Name = "Stepper"},
                new Controls{Name = "Switch"},
                new Controls{Name = "DatePicker"},
                new Controls{Name = "TimePicker"},
                new Controls{Name = "Text Demoları"},
               
                new Controls{Name = "ActivityIndicator"},
                new Controls{Name = "ProgressBar"},
                new Controls{Name = "CarouselView"},
                new Controls{Name = "CollectionView"},
                new Controls{Name = "IndicatorView"},
                new Controls{Name = "ListView"},
                new Controls{Name = "Picker"},
                new Controls{Name = "TableView"},

                //Bu üç yapı layout yapısına benzeyen kontrollerdir.
                new Controls{Name = "ContentView"},
                new Controls{Name = "Frame"},
                new Controls{Name = "ScrollView"},




            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
