using AlongSide.Models;
using System;
using System.Collections.Generic;

namespace AlongSide.ViewModels
{
    public class GigFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }

        public DateTime DateTime => DateTime.Parse(string.Format("{0} {1}", Date, Time));
    }
}