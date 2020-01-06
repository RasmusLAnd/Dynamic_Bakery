using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test__Backery.Models
{
    public class Review
    {
        public Review() { }
               
        public int ReviewId { get; set; }

        [Range(1,5)]
        [Required (ErrorMessage = "Please enter your rating, 1-5")]
        [Display(Name = "Number of Stars")]
        public int Stars { get; set; }

        public string ReviewComm { get; set; }

        public int PastriesId { get; set; }
        //public List<ReviewDetail> ReviewDetails { get; set; }
               
        
    }
}
