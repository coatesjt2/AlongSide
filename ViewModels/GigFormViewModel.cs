using AlongSide.Models;
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
        //public IEnumerable<Genre> Genres { get; set; }
    }
}