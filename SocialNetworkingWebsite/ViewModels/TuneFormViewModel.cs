using SocialNetworkingWebsite.Models;
using System;
using System.Collections.Generic;

namespace SocialNetworkingWebsite.ViewModels
{
    public class TuneFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public DateTime DateTime
        {
            get
            {
                //return DateTime.Parse(string.Format("{0} {1}", Date, Time));
                return DateTime.Parse(string.Format($"{Date} {Time}"));
            }
        }
    }
}