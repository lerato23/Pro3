using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pro3.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string TitleName { get; set; }
        public DateTime Created { get; set; }

        public List<string> Tags { get; set; }
    }
}