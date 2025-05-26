using CursoEfCore.Domain;
using CursoEfCore.ValueObjects;
using Microsoft.EntityFrameworkCore;
using CursoEfCore.Data;

class Program
{
    //Console.WriteLine("Hello, World!");
    static void Main(string[] args)
    {
        InserirDados();

    }

    private static void InserirDados()
    {
        var produto = new Produto
        {
            Descricao = "Produto Teste",
            CodigoBarras = "1234567891231",
            Valor = 10m,
            TipoProduto = TipoProduto.MercadoriaParaRevenda,
            Ativo = true
        };

        using var db = new ApplicationContext();

        // todas abaixo: formas diferentes de adicionar produtos:

        //db.Produtos.Add(produto); 
        //db.Set<Produto>().Add(produto); 
        //db.Entry(produto).State = EntityState.Added;
        db.Add(produto);

        var registros = db.SaveChanges(); //retorna 
        Console.WriteLine($"Total Registro(s): {registros}");
    }
}