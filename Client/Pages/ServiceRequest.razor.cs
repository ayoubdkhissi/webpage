using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Client.Pages;

public partial class ServiceRequest
{
    private FelanmalanModel felanmalanModel = new FelanmalanModel();
    private bool isSubmitted = false;

    private void SubmitFelanmälan()
    {
        // Här kan du lägga till kod för att hantera inlämning, t.ex. skicka till en server eller API
        isSubmitted = true;
    }

    public class FelanmalanModel
    {
        [Required]
        [StringLength(500, ErrorMessage = "Beskrivningen får inte vara längre än 500 tecken.")]
        public string Description { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Ange en giltig e-postadress.")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Ange ett giltigt telefonnummer.")]
        public string Phone { get; set; }
    }
}
