using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Homeworl2.Pages
{
    public class IndexModel : PageModel
    {
        public string Name { get; set; }
        public void OnGet()
        {
            this.Name = "Index";
        }
    }
}
