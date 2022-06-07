using Microsoft.AspNetCore.Mvc.RazorPages;
using Server.Domian;

namespace Ui.Pages
{
    public class PrivacyModel : PageModel
    {
        public PrivacyModel(IPersonRepository personRepository)
        {
            PersonRepository = personRepository;
        }

        public IPersonRepository PersonRepository { get; set; }

        public void OnGet()
        {
        }
    }
}