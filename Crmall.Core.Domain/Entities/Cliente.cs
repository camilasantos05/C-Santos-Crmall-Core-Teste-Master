using Crmall.Core.Domain.Entities.Enumeradores;
using System;
using System.ComponentModel.DataAnnotations;

namespace Crmall.Core.Domain.Entities
{
    public class Cliente : Entity
    {
        [Required]
        [StringLength(80)]
        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public EnumSexo Sexo { get; private set; }
        public Endereco Endereco { get; private set; }

        public Cliente() { }

        public Cliente(string nome,
                       DateTime dataNascimento,
                       EnumSexo sexo,
                       Endereco endereco)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Sexo = sexo;
            Endereco = endereco;
        }

        public Cliente(Guid id,
                       string nome,
                       DateTime dataNascimento,
                       EnumSexo sexo,
                       Endereco endereco) : this(nome, dataNascimento, sexo, endereco) 
        {
            Id = id;
        }
    }
}
