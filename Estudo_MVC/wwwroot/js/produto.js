async function obterProdutos() {
    const response = await fetch('/api/produto');
    const produtos = await response.json();
    document.getElementById('listaProdutos').innerHTML = produtos.map(p => `
        <div>
            ${p.nome} - ${p.descricao} - R$${p.preco.toFixed(2)} - ${p.quantidade} unidades
            <button onclick="carregarProduto(${p.id})">Editar</button>
            <button onclick="deletarProduto(${p.id})">Deletar</button>
        </div>
    `).join('');
}


async function CarregarProduto(id) {
    const response = await fetch('/api/produto/${id}');
    const produto = await response.json();
    document.getElementById('produtoId').value = produto.id;
    document.getElementById('produtoNome').value = produto.nome;
    document.getElementById('produtoDescricao').valeu = produto.descricao;
    document.getElementById('produtoPreco').value = produto.preco;
    document.getElementById('produtoQuantidade').value = produto.quantidade;
}

async function SalvarProduto() {
    const produto = {
        id: document.getElementById('produtoId').value || 0,
        nome: document.getElementById('produtoNome').value,
        descricao: document.getElementById('ProdutoDescricao').value,
        preco: parseFloat(document.getElementById('prosutoPreco').value),
        quantidade: parseInt(document.getElementById('produtoQuantidade').value)
    };

    const method = produto.id ? 'PUT' : 'POST';
    await fetch('/api/produto', {
        method,
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(produto)
    });
    limparFormulario();
    obterProdutos()
}

async function deletarProduto(id) {
    await fetch('/api/produto/${id}', { method: 'DELETE' });
    obterProdutos();
}

function limparFormulario() {
    document.getElementById('produtoForm').reset();
    document.getElementById('produtoId').value = '';
}