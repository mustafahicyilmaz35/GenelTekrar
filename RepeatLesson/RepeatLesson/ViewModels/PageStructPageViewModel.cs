﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using RepeatLesson.Annotations;
using RepeatLesson.Models;

namespace RepeatLesson.ViewModels
{
    public class PageStructPageViewModel : INotifyPropertyChanged
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


        public PageStructPageViewModel()
        {
            Controls = new ObservableCollection<Controls>
            {
                //28 tane kullanıcı kontrolü vardır.

                new Controls{Name = "Label"},
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
                new Controls{Name = "DataPicker"},
                new Controls{Name = "TimePicker"},
                new Controls{Name = "Entry"},
                new Controls{Name = "Editor"},
                new Controls{Name = "ActivityIndicator"},
                new Controls{Name = "ProgressBar"},
                new Controls{Name = "CarouselView"},
                new Controls{Name = "CollectionView"},
                new Controls{Name = "IndicatorView"},
                new Controls{Name = "ListView"},
                new Controls{Name = "Picker"},
                new Controls{Name = "TableView"},



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
