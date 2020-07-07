using System;
using System.ComponentModel.DataAnnotations;

namespace dotnetcore_mvc.Models
{
    public class ContactViewModel
    {
       [Required]
       [MinLength(5, ErrorMessage="Name is mandatory")]
       public string Name{ get; set; }

       [Required]
       [EmailAddress(ErrorMessage = "Emails address is mandatory")]
       public string Email { get; set; }

        [Required(ErrorMessage = "Subject is mandatory")]
       public string Subject { get; set; }

        [Required]
        [MaxLength(250, ErrorMessage = "The message is too long")]
       public string Message { get; set; }
    }
}