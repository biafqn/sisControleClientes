using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade
{
    public class Clientes
    {
        public string nome { get; set; }
        public string endereco { get; set; }
        public float valor { get; set; }
        public float valor_Imposto { get; protected set; }
        public float total { get; protected set; }

        public virtual void Pagar_Imposto(float v)
        {
            this.valor = v;
            this.valor_Imposto = this.valor * 0.1f;
            this.total = this.valor + this.valor_Imposto;
        }
        
    }
}