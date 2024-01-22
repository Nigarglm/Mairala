using Mairala.DAL;
using Mairala.Models;
using Mairala.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mairala.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context= context;
        }
        public async Task<IActionResult> Index()
        {
            List<Employee> employees = await _context.Employees.Include(e=>e.Position).ToListAsync();
            List<Project> projects = await _context.Projects.Include(p=>p.Category).ToListAsync();
            List<Service> services = await _context.Services.ToListAsync();

            HomeVM home = new HomeVM()
            {
                Employees = employees,
                Projects = projects,
                Services = services
            };

            return View(home);
        }
    }
}
