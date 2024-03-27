using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorApp.Models;

namespace RazorApp.Pages
{
    public class DetailsModel : PageModel
    {
        [BindProperty]
        public List<PersonModel> People { get; set; } = new List<PersonModel>();

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; } = "";

        [BindProperty]
        public PersonModel NewPerson { get; set; } = new PersonModel();

        public ActionResult OnGet()
        {
            List<PersonModel> output = new List<PersonModel>();

            output.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            output.Add(new PersonModel { FirstName = "Mike", LastName = "Sunders" });
            output.Add(new PersonModel { FirstName = "Jake", LastName = "Millers" });

            if (!string.IsNullOrWhiteSpace(SearchTerm))
            {
                People = output.Where(x => x.FirstName.StartsWith(SearchTerm)).ToList();
            }
            else
            {
                People = output;
            }
            return Page();
        }

        public void OnPost()
        {

        }


        public void OnPostDelete()
        {

        }

    }
}
