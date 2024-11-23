using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // Instancia do tipo cliente
        Cliente cliente1 = new Cliente (01, "Arthur A. Ferreira", "025.258.178-32", "arthur@sp.senai.br", "Madruga");
        Cliente cliente2 = new Cliente (02, "Jefferson R. Ferreira", "025.258.178-16", "jefferson@sp.senai.br", "Bug");
        Cliente cliente3 = new Cliente (03, "Rodrigo", "025.258.178-18", "Rodrigues@sp.senai.br", "Atena");
        Cliente cliente4 = new Cliente (04, "Silva", "025.258.178-24", "Silva@sp.senai.br", "Arroz");
        Cliente cliente5 = new Cliente (05, "Stalone", "025.258.178-50", "Silvestre@sp.senai.br", "Pinguim");

        //Lista de Clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        //Instancia do tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A", "14.144.444/0001-52", "C#@C#.com.br");
        Fornecedor fornecedor2 = new Fornecedor(02, "Alvorada Pets S/A", "14.144.444/0001-60", "Alvorada@pets.com.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "Pets BR S/A", "14.144.444/0001-70", "Pets@pets.com.br");
        Fornecedor fornecedor4 = new Fornecedor(04, "Arroz BR S/A", "14.144.444/0001-71", "filial@pets.com.br");
        Fornecedor fornecedor5 = new Fornecedor(05, "Tudo para Pets BR S/A", "14.144.444/0001-89", "tudo@pets.com.br");

         //Lista de Fornecedor 
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);
       
        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
