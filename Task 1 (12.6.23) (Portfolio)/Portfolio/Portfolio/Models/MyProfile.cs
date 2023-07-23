using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class MyProfile
    {
        public string Name { get; set; }
        public string Dob { get; set; }
        public string Nation { get; set; }
        public string BGroup { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public List<string> Hobbies { get; set; }
    }
}