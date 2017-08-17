using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NotasUnopar.Classes
{
    /**
     * Os dois tipos de questões da prova presencial, tem um somatorio de
     * 100 pontos, sendo 50 para as questões objetivas e 25 para cada questão
     * discursiva, sendo este somatorio, a porcentagem de acertos na prova.
     * 
     * Tabela de porcentagem:
     * 
     * EX - Excelente - equivalente entre 90% a 100%.
     * MB - Muito Bom - equivalente entre 80% a 89%.
     * B - Bom - equivalente entre 70% a 79%.
     * S - Suficiente - equivalente entre 60% a 69%.
     * I - Insuficiente - até 59%.
     * 
     **/
    class ProvaPresencial
    {
        public Double NotaGeral { get; set; }
        public Double Discursivas { get; set; }
        public Double Objetivas { get; set; }

        //Calcular média geral
        public void calcularGeral(Int32 qtd_objetivas, String q11, String q12)
        {
            try
            {
                this.NotaGeral = this.Discursivas + this.Objetivas;
                String conceito = verificaConceito();
                //MessageBox.Show("Acertos: " + this.NotaGeral.ToString() + ", Conceito: " + conceito);
            }
            catch (Exception)
            {
                MessageBox.Show("Valores invalidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Calcular media das questões objetivas
        public Double calcularObjetivas(Int32 qtd_acertos) {

            QuestoesObjetivas q = new QuestoesObjetivas();
            this.Objetivas = q.calcular(qtd_acertos);

            //MessageBox.Show(this.Objetivas.ToString());

            return 0;
        }

        //Calcular media das questões discursivas
        public Double calcularDiscursivas(String q11, String q12)
        {

            QuestoesDiscursivas q = new QuestoesDiscursivas();

            this.Discursivas = q.calcular(q11, q12);
            //MessageBox.Show("Resultado: " + this.Discursivas.ToString());

            return 0;
        }

        //Metodo que retorna o conceito referente a procentagem da soma das notas
        public String verificaConceito()
        {

            if (this.NotaGeral <= 59)
            {
                return "Insuficiente";
            }
            else if (this.NotaGeral >= 60 && this.NotaGeral <= 69)
            {
                return "Suficiente";
            }
            else if (this.NotaGeral >= 70 && this.NotaGeral <= 79)
            {
                return "Bom";
            }
            else if (this.NotaGeral >= 80 && this.NotaGeral <= 89)
            {
                return "Muito Bom";
            }
            else if (this.NotaGeral >= 90 && this.NotaGeral <= 100)
            {
                return "Excelente";
            }

            return null;
        }
    }

    /*
    * Calculo de medias com pesos:
       m= (n1*2+n2*3+n3*4+n4*1)/10;
       printf("Media: %.1f\n", m);
    */
}
