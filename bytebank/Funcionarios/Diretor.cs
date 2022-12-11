using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public class Diretor : Funcionario
    {       
        public override double GetBonificacao()
        {
            return this.Salario + base.GetBonificacao();
        }
        public override double PremioSemestral()
        {
            return this.Salario * base.PremioSemestral();
        }

        public Diretor(string cpf, double salario): base(cpf, salario)
        {
            
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}
