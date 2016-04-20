using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcCalculator_1.Models
{
    public class FormValues
    {
        [Required(ErrorMessage = "Please enter a numeric value")]
        [Range(double.MinValue, double.MaxValue, ErrorMessage = "Please enter valid number")]
        public double Input1 { get; set; }

        [Required(ErrorMessage = "Please enter a numeric value")]
        [Range(double.MinValue, double.MaxValue, ErrorMessage = "Please enter valid number")]
        public double Input2 { get; set; }

        public string Operator { get; set; }
    }
    
}