﻿using bytebank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public class GerenteDeContas : Autenticavel
    {
        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

        public override bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}