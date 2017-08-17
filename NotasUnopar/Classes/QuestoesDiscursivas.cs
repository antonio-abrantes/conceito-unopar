using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NotasUnopar.Classes
{
    /*
     * Peso das duas questões = 50%
     * Insuficiente 	= 7
     * Suficiente	= 17
     * Bom		= 20
     * Muito Bom	= 23
     * Excelente	= 25
     */

    class QuestoesDiscursivas
    {
        private Dictionary<String, Int32> Conceitos = new Dictionary<String, Int32>();
        public Double q11 { get; set; }
        public Double q12 { get; set; }

        public QuestoesDiscursivas() {
            this.iniciaConceitos();
        }

        public Dictionary<String, String> validarNtDiscursiva(){

            return null;
        }

        public Double calcular(String q11, String q12) {

            this.q11 = Conceitos[q11];
            this.q12 = Conceitos[q12];

            Double resultato = this.q11 + this.q12;

            return resultato;
        }

        private void iniciaConceitos()
        {
            Conceitos.Add("Sem Conceito", 0);
            Conceitos.Add("Insuficiente", 7);
            Conceitos.Add("Suficiente", 17);
            Conceitos.Add("Bom", 20);
            Conceitos.Add("Muito Bom", 23);
            Conceitos.Add("Excelente", 25);
        }
    }
}
