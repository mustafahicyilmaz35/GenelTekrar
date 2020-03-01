﻿using System;
using System.Collections.Generic;
using System.Text;
using RepeatLesson.Models.ListModels;

namespace RepeatLesson.ViewModels.ListViewModels
{
    public class ListViewModel
    {

        public List<Person> People { get; set; }

        public ListViewModel()
        {
            People = new List<Person>
            {
                new Person{Name = "Hasan"},
                new Person{Name = "Mustafa"},
                new Person{Name = "Sıla"},
                new Person{Name = "Ebrar"}
            };
        }
    }
}
