using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Pro3.Models
{
    public class FileModel
    {
        [Required(ErrorMessage ="Choose a file that you to upload")]
        [Display(Name ="Browse file")]
        public HttpPostedFileBase[] files { get; set; }
    }
}