using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcCalculator_1.Models
{
    public class InputValues
    {
        [Required(ErrorMessage = "Du må nok skrive inn noe, gjerne et tall")]
        [Range(double.MinValue, double.MaxValue, ErrorMessage = "Please enter valid number")]
        public double Input1 { get; set; }

        [Required(ErrorMessage = "Du må nok skrive inn noe, gjerne et tall")]
        [Range(double.MinValue, double.MaxValue, ErrorMessage = "Please enter valid number")]
        public double Input2 { get; set; }

        public string Operator { get; set; }

    }
    
}