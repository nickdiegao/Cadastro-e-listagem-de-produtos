using Estágio___Oak_Tecnologia;

Console.Write("Digite quantos produtos você deseja cadastrar: ");
string n = Console.ReadLine()!;
int quantidade = int.Parse(n);

//Inicializa o classe produto vazia
Produto produto = new Produto();    

for (int i = 0; i < quantidade; i++)
{
    Console.WriteLine($"{i+1}º produto");
    Console.Write("Digite o nome do produto: ");
    string nomeDoProduto = Console.ReadLine()!;
    Console.Write("Digite o valor do produto: R$");
    string valor = Console.ReadLine()!;
    double valorDoProduto = double.Parse(valor);
    Console.Write("Digite a descrição do produto: ");
    string descricaoDoProduto = Console.ReadLine()!;
    Console.Write("Está disponível para compra? (true/false) ");
    bool disponivelParaCompra = bool.Parse(Console.ReadLine()!);
    Console.WriteLine();

    produto.AdicionaProdutoCompleto(nomeDoProduto, valorDoProduto, descricaoDoProduto, disponivelParaCompra); //Metódo para exibir todo o produto completo

    produto.AdicionaProduto(nomeDoProduto, valorDoProduto); //Adiciona os produtos em uma lista
    Thread.Sleep(2000); //Espera um segundo para continuar
    Console.WriteLine("Produto adicionado com sucesso!\n");
    
}

produto.ListagemDeProduto(); //Lista os produtos

Console.Write("Deseja ver os produtos ordenados por preço? (S/N) ");
string resp = Console.ReadLine()!;

if (resp.ToLower() == "s")
{
    produto.OrdenaPreco(); //Amostra todos os produtos ordenados pelo preço
} else
{
    Console.WriteLine("Até mais!");
}

