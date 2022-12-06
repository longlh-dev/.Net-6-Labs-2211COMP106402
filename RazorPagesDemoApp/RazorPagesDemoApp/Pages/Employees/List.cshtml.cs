using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesDemoApp.Data;

namespace RazorPagesDemoApp.Pages.Employees
{
    public class ListModel : PageModel
    {
        //note
        private readonly RazorPagesDemoDbContext dbContext;
        public List<Model.Domain.Employee> Employees { get; set; }
        public ListModel(RazorPagesDemoDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void OnGet()
        {
            Employees = dbContext.Employees.ToList();
        }
    }
}
