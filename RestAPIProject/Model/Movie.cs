using System.ComponentModel.DataAnnotations;
using System.Runtime.Versioning;

namespace RestAPIProject.Model
{
    public class Movie
    {

        public int MovieId { get; set; }

        [Required(ErrorMessage ="Please Enter the Movie name")]
        public string MovieName {  get; set; }

        public string Lang {  get; set; }
        public int Year {  get; set; }

        [Required(ErrorMessage = "Please Enter the Actor")]
        public string Actor { get; set; }

        [Required(ErrorMessage = "Please Enter the Director")]
        public string Director { get; set; }
    }
}
