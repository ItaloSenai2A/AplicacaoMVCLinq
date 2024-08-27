using AplicacaoMVClinq.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicacaoMVClinq.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            new Cliente { Id = 1, Nome = "Alice", Email = "alice@example.com", Telefone = "1234-5678", "2000-12-06" }, 
     new Cliente { Id = 2, Nome = "Bob", Email = "bob@example.com", Telefone = "2345-6789".  "2001-10-06" }, 
     new Cliente { Id = 3, Nome = "Charlie", Email = "charlie@example.com", Telefone = "3456-7890", "1999-12-06" }, 
     new Cliente { Id = 4, Nome = "David", Email = "david@example.com", Telefone = "4567-8901", "2000-12-01" }, 
     new Cliente { Id = 5, Nome = "Eve", Email = "eve@example.com", Telefone = "5678-9012", "2000-12-06" };

            return View();
        }
    }
}
