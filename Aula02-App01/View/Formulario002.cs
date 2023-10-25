using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula02_App01.View
{
    public partial class Formulario002 : Form
    {
        public Formulario002()
        {
            InitializeComponent();
        }


        private void btn_Media_Click(object sender, EventArgs e)
        {
            string Nome = tbx_Nome.Text;
            string DataNasc = dtp_Nascimento.Value.ToString("dd/MM/yyyy");
            string Ativ1 = nud_Ativ01.Value.ToString();
            string Ativ2 = nud_Ativ02.Value.ToString();
            string Ativ3 = nud_Ativ03.Value.ToString();
            string Ativ4 = nud_Ativ04.Value.ToString();
            string resultado;

            decimal media = 0;

            media = (nud_Ativ01.Value + nud_Ativ02.Value + nud_Ativ03.Value + nud_Ativ04.Value) / 4;

            if (media > nud_Media.Value)
            {
                resultado = "Aprovado";
            }
            else
            {
                resultado = "Reprovado";
            }


            lbx_Display.Items.Add("Nome: " + Nome);
            lbx_Display.Items.Add("Data de Nascimento: " + DataNasc);
            lbx_Display.Items.Add("Nota Atividade 1: " + Ativ1);
            lbx_Display.Items.Add("Nota Atividade 2: " + Ativ2);
            lbx_Display.Items.Add("Nota Atividade 3: " + Ativ3);
            lbx_Display.Items.Add("Nota Atividade 4: " + Ativ4);
            lbx_Display.Items.Add("Média: " + media);

        }
    }
}
