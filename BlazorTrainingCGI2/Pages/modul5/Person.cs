using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTrainingCGI2.Pages.modul5
{
    public class Person
    {
        [Required(ErrorMessage ="da muss was rein")]
        [Range(minimum:150,maximum:200,ErrorMessage ="Keine Achterbahn")]
        public int Gross { get; set; }
        [Required(ErrorMessage = "da muss was rein")]
        [StringLength( maximumLength:20, ErrorMessage = "zu lange")]
        public string Name { get; set; }
        public DateTime GebDat { get; set; }
    }
}
