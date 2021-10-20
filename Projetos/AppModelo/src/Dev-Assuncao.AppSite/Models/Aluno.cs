using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dev_Assuncao.AppSite.Models
{
    public class Aluno
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }


        public Aluno()
        {
            Id = Guid.NewGuid();
        }
    }


}
