using Estudo_MVC.Data;
using Estudo_MVC.Interface;
using Estudo_MVC.Models;

namespace Estudo_MVC.Service
{
	public class ProdutoService : IProdutoService
	{
		private readonly AppDbContext _context;

		public ProdutoService(AppDbContext context)
		{
			_context = context;
		}

		public IEnumerable<Produto> ObterTodos() => _context.produtos.ToList();

		public Produto ObterPorId(int id) => _context.produtos.Find();

		public void Inserir(Produto produto)
		{
			_context.produtos.Add(produto);
			_context.SaveChanges();
		}

		public void Atualizar(Produto produto)
		{
			_context.produtos.Update(produto);
			_context.SaveChanges();
		}

		public void Deletar(int id)
		{
			var Produto = ObterPorId(id);
			if (Produto != null)
			{
				_context.produtos.Remove(Produto);
				_context.SaveChanges();
			}
		}
	}
}
