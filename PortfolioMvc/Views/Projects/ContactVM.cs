using System.ComponentModel.DataAnnotations;

namespace PortfolioMvc.Views.Projects
{
    public class ContactVM
    {
        [Required(ErrorMessage = "Must enter an email address!")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Must enter a valid phone number!")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Must enter a Name!")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Must enter a subject!")]
        public string Subject { get; set; }


        [Required(ErrorMessage = "Enter a message!")]
        public string Message { get; set; }

    }
}
