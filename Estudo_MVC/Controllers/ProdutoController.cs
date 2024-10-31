using Estudo_MVC.Interface;
using Estudo_MVC.Models;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Estudo_MVC.Controllers
{
	public class ProdutoController : Controller
	{
		
		public readonly IProdutoService _produtoService;

		public ProdutoController(IProdutoService produtoService)
		{
			_produtoService = produtoService;
		}

		public IActionResult Index()
		{
			return View();
		}

		// GET: api/<ProdutoController>
		[HttpGet("api/produto/obtertodos")]
		public IActionResult ObterTodos() => Ok(_produtoService.ObterTodos());
		

		// GET api/<ProdutoController>/5
		[HttpGet("api/produtos/{id}")]
		public IActionResult ObterPorId(int id) => Ok(_produtoService.ObterPorId(id));

		// POST api/<ProdutoController>
		[HttpPost("api/produto/inserir")]
		public IActionResult Inserir ([FromBody] Produto produto)
		{

			_produtoService.Inserir(produto);
			return Ok();
		}

		// PUT api/<ProdutoController>/5
		[HttpPut("api/produtos/atualizar")]
		public IActionResult Atualizar ([FromBody] Produto produto)
		{
			_produtoService.Atualizar(produto);
			return Ok();
		}

		// DELETE api/<ProdutoController>/5
		[HttpDelete("api/produto/{id}")]
		public IActionResult Deletar (int id)
		{
			_produtoService.Deletar(id);
			return Ok();
		}
	}
}
