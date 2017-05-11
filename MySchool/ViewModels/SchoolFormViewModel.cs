using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MySchool.Models;

namespace MySchool.ViewModels
{
    public class SchoolFormViewModel
    {
        public School School { get; set; }

        public int? Id { get; set; }

        [Required]
        public string RollNumber { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        public IEnumerable<County> Counties { get; set; }

        [Display(Name = "County")]
        public byte CountyId { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Email { get; set; }

        public int NumberOfBoys { get; set; }

        public int NumberOfGirls { get; set; }

        public int? TotalPupilPopulation { get; set; }

        public int NumberOfTeachers { get; set; }

        public IEnumerable<Ethos> Ethos { get; set; }

        public byte EthosId { get; set; }

        public string ImageFileName
        {
            get { return Name.Replace(" ", "").ToLower() + ".jpg"; }
        }

        public string Title
        {
            get { return Id != 0 ? "Edit School" : "New School"; }
        }

        public SchoolFormViewModel()
        {
            Id = 0;
        }

        public SchoolFormViewModel(School school)
        {
            Id = school.Id;
            Name = school.Name;
            RollNumber = school.RollNumber;
            Address = school.Address;
            CountyId = school.CountyId;
            PhoneNumber = school.PhoneNumber;
            Email = school.Email;
            EthosId = school.EthosId;
        }
    }
}