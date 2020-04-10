using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace StudentExercisesMVC.Models.ViewModels
{
    public class InstructorFormViewModel
    {
        public int InstructorId { get; set; }

        [Display(Name = "First Name")]
        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is Required")]
        [MinLength(3, ErrorMessage = "Last Name should be at least 3 characters")]
        public string LastName { get; set; }

        [Display(Name = "Cohort")]
        [Required]
        public int CohortId { get; set; }

        [Display(Name = "Slack Handle")]
        [Required]
        public string SlackHandle { get; set; }

        [Display(Name = "Specialty")]
        [Required]
        public string Specialty { get; set; }
        public List<SelectListItem> CohortOptions { get; set; }
    }
}