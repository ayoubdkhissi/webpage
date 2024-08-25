using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Client.Pages;

public partial class HousingQueue
{
    private BostadskoModel bostadskoModel = new BostadskoModel();
    private bool isSubmitted = false;

    private void SubmitBostadsko()
    {
        // Här kan du lägga till kod för att hantera inlämning, t.ex. skicka till en server eller API
        isSubmitted = true;
    }

    public class BostadskoModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Ange en giltig e-postadress.")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Ange ett giltigt telefonnummer.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Välj önskad lägenhetsstorlek.")]
        public string ApartmentSize { get; set; }
    }
}
