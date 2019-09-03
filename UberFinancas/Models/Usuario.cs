using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UberFinancas.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        [DisplayFormat(DataFormatString ="{0:F2}")]
        public double Preco { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        public Usuario()
        {

        }

        public Usuario(int usuarioId, string nome, int idade, double preco, DateTime date)
        {
            UsuarioId = usuarioId;
            Nome = nome;
            Idade = idade;
            Preco = preco;
            Date = date;
        }
    }
}
