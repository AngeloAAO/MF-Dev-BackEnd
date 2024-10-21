using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MF_Dev_BackEnd.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar o nome do veículo!")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar a Placa do veículo!")]
        public string Placa { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar o Ano de Fabricação do veículo!")]
        public int AnoFabricacao { get; set; }
    
        [Required(ErrorMessage = "Obrigatório informar o Ano do Modelo do veículo!")]
        public int AnoModelo { get; set; }
    }
}
