using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gameficacao01.API.Models
{
    public class ClienteModel
    {
      // Propriedades
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } // Identificador único para cada cliente
        public string Nome { get; set; }
        public string? Email { get; set; } // Como parte das informações de contato
        public string? Telefone { get; set; } // Como parte das informações de contato

        // Construtor
        public ClienteModel()
        {
            // Valores padrão ou inicialização, se necessário
        }

        // Métodos (se você precisar adicionar funcionalidades específicas para um cliente)
        public string ObterInformacoesDeContato()
        {
            return $"Email: {Email}, Telefone: {Telefone}";
        }     
    }
}