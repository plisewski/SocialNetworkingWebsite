using SocialNetworkingWebsite.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SocialNetworkingWebsite.ViewModels
{
    public class TuneFormViewModel
    {
        [Required]
        public string Venue { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }

        [Required]
        [ValidTime]
        public string Time { get; set; }

        [Required]
        public byte Genre { get; set; }


        public IEnumerable<Genre> Genres { get; set; }


        //public GetDateTime GetDateTime => GetDateTime.Parse(string.Format($"{Date} {Time}"));

        public DateTime GetDateTime()
        {
            //return GetDateTime.Parse(string.Format("{0} {1}", Date, Time));
            return DateTime.Parse(string.Format($"{Date} {Time}"));     
        }
    }
}