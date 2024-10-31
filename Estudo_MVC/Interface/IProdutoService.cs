using Estudo_MVC.Models;

namespace Estudo_MVC.Interface
{
	public interface IProdutoService
	{
		IEnumerable<Produto> ObterTodos();
		Produto ObterPorId (int id);
		void Inserir (Produto produto);
		void Atualizar(Produto produto);
		void Deletar(int id);
	}
}
