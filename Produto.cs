namespace Estágio___Oak_Tecnologia;

internal class Produto
{

    List<string> listaDeProduto = new List<string>();
    List<double> listaDeValor = new List<double>();
    List<(string produto, double valor)> produtosEValores = new List<(string, double)>(); //Essa terceira lista serve para unir as primeiras duas.
                                                                    //Eu achei melhor fazer dessa forma para trabalhar com as outras duas de maneira distinta

    public void AdicionaProduto(string a, double b) //Metódo para adicionar os produtos na lista (string a se refere ao nome, double b ao preço)
    {
        listaDeProduto.Add(a);
        listaDeValor.Add(b);
        produtosEValores.Add((a,b));
    }

    public void AdicionaProdutoCompleto (string nome, double valor, string descricao, bool disp) //Metódo para exibição completa do produto que é executada logo após da adição de um produto
    {
        Console.WriteLine($"Produto: {nome}");
        Console.WriteLine($"Valor do produto: R${valor}");
        Console.WriteLine($"Descrição do produto: {descricao}");
        if (disp == true)
        {
            Console.WriteLine("Disponível para compra");
        } else
        {
            Console.WriteLine("Indisponível para compra");
        }
    }

    public void ListagemDeProduto() //Metódo que lista os produtos e caso o usuário queira adicionar mais algum produto existe a opção também
    {
        for (int i=0; i<listaDeProduto.Count; i++)
        {
            Console.WriteLine($"Produto: {listaDeProduto[i]} || Preço: R${listaDeValor[i]}");
        }

        Console.WriteLine("Deseja cadastrar mais algum produto? (S/N)");
        string resposta = Console.ReadLine()!;
        while (resposta.ToLower() == "s")
        {
            Console.Clear();
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

            AdicionaProdutoCompleto(nomeDoProduto, valorDoProduto, descricaoDoProduto, disponivelParaCompra);

            AdicionaProduto(nomeDoProduto, valorDoProduto);
            Thread.Sleep(2000);
            Console.WriteLine("Produto adicionado com sucesso!");

            Console.WriteLine("Deseja cadastrar mais algum produto? (S/N)");
            resposta = Console.ReadLine()!;

            ListagemDeProduto();
        }
    }

    public void OrdenaPreco() //Metódo para a ordenação de preço dos produtos
    {
        produtosEValores.Sort((x, y) => x.valor.CompareTo(y.valor));
        foreach (var item in produtosEValores)
        {
            Console.WriteLine($"Produto: {item.produto} || Preço: R${item.valor}");
        }        

    }
}
