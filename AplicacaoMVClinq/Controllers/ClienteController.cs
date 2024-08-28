using AplicacaoMVClinq.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicacaoMVClinq.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetCliente()
        {
            Cliente c1 = new Cliente(1, "Ítalo Francesco", "italo.francesco@gmail.com", "1234-5678", new DateOnly(2008, 3, 28));
            Cliente c2 = new Cliente(2, "Emanuelly Lima", "manu.lima@gmail.com", "1234-5678", new DateOnly(2008, 1, 25));
            Cliente c3 = new Cliente(3, "Rayssa Nanclares", "rayssa.nanclares@gmail.com", "1234-5678", new DateOnly(2007, 12, 19));
            Cliente c4 = new Cliente(4, "Bruno Martins", "bruno.martins@gmail.com", "1234-5678", new DateOnly(2007, 8, 28));
            Cliente c5 = new Cliente(5, "Alice Gusman", "alice.gusman@gmail.com", "1234-5678", new DateOnly(2000, 6, 1));

            List<Cliente> listaClientes = new List<Cliente>();
            listaClientes.Add(c1);
            listaClientes.Add(c2);
            listaClientes.Add(c3);
            listaClientes.Add(c4);
            listaClientes.Add(c5);

            return View(listaClientes);
        }
    }
}
