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
    public class PageStructedPageViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Pages> _pageses;

        public ObservableCollection<Pages> Pageses
        {
            get => _pageses;
            set
            {
                _pageses = value;
                OnPropertyChanged(nameof(Pageses));
            }
        }

        public PageStructedPageViewModel()
        {
               Pageses = new ObservableCollection<Pages>
               {
                   new Pages{PageName = "Content Page"},
                   new Pages{PageName = "MasterDetail Page"},
                   new Pages{PageName = "Navigation Page"},
                   new Pages{PageName = "Tabbed Page"},
                   new Pages{PageName = "Carousel Page"},
                   new Pages{PageName = "Modal Page"},
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
