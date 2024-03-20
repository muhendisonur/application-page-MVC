using System.ComponentModel.DataAnnotations;

namespace BtkAkademi.Models
{
    public class Candidate
    {
        [Required(ErrorMessage = "Email is required!")]
        public string? email {get; set;} = String.Empty;
        [Required(ErrorMessage = "Firstname is required!")]
        public String? firstName {get; set; } = String.Empty;
        [Required(ErrorMessage = "Lastname is required!")]
        public String? lastName {get; set; } = String.Empty;
        public String? fullName => $"{firstName} {lastName}";
        public int? age {get; set; }
        public String selectedCourse {get; set; } = String.Empty;
        public DateTime applyAt {get; set;}

        public Candidate()
        {
            applyAt = DateTime.Now;
        }
    }
}