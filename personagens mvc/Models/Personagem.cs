
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http.HttpResults;

namespace personagens_mvc.Models
{
    public abstract class Personagem
    {
        [Key]
        public int idPersonagem { get; set; }
        [Required]
        public string nome { get; set; } = string.Empty;
        private int nivelVerificado;
        [Required]
        public int nivel
        {
            get
            {
                return nivelVerificado;
            }
            set
            {
                if (value > 0)
                {
                    nivelVerificado = value;
                }
                else
                {
                    throw new ArgumentException("Level invalido");
                }
            }
        }
        public abstract double calcularPoder();
        public Personagem() 
        {}

        public Personagem(string nomeConstrutor, int nivelConstrutor)
        {
            nome = nomeConstrutor;
            nivel = nivelConstrutor;
        }

    }
}