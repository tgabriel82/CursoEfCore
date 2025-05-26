

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace CursoEfCore.Domain
{
    [Table("Clientes")] // indica que no banco de dados a tabela é Clientes, e não Cliente
    public class Cliente
    {
        [Key] 
        public int Id { get; set; }
        
        [Required]
        public string Nome { get; set; }

        [Column("Phone")] //indica que no banco de Dados a coluna será Phone, e não Telefone
        public string Telefone { get; set; }

        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
    } 
}
