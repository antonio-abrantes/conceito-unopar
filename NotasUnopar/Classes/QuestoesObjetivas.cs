using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NotasUnopar.Classes
{
    /*
     * Peso das 10 questões 50%
     * Cada questão = 5
     */
    
    class QuestoesObjetivas
    {        
        public Double Pontuacao { get; set; }

        public Double calcular(Int32 qtd) {
            this.Pontuacao = qtd;

            Double resultado = this.Pontuacao * 5;

            return resultado;
        }
    }
}
