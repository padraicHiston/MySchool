using System.ComponentModel.DataAnnotations;

namespace MySchool.Models
{
    public class School
    {
        public int Id { get; set; }

        [Required]
        public string RollNumber { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        
        public County County { get; set; }

        [Required]
        [Display(Name = "County")]
        public byte CountyId { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Email { get; set; }

        //public List<Teacher> Teachers { get; set; }
        //public List<Pupil> Pupils { get; set; }
        //public List<Parent> Parents { get; set; }
        public int NumberOfBoys { get; set; }
        public int NumberOfGirls { get; set; }
        public int TotalPupilPopulation { get; set; }
        public int NumberOfTeachers { get; set; }

        
        public Ethos Ethos { get; set; }

        [Required]
        [Display(Name = "Ethos")]
        public byte EthosId { get; set; }

        public string ImageFileName
        {
            get { return Name.Replace(" ", "").ToLower() + ".jpg"; }
        }
    }
}