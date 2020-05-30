using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto_TLP___Calculo_de_Conjuntos
{
    public partial class Frm_2 : Form
    {

        private HashSet<string> ConjA = new HashSet<string>();
        private HashSet<string> ConjB = new HashSet<string>();
        private HashSet<string> uniao = new HashSet<string>();
        private HashSet<string> interccao = new HashSet<string>();
        private HashSet<string> diferencaAB = new HashSet<string>();
        private HashSet<string> diferencaBA = new HashSet<string>();
        private HashSet<string> simetria = new HashSet<string>();

        frm_conjunto conjuntos;
        public Frm_2()
        {
            InitializeComponent();
        }

        private void Frm_2_Load(object sender, EventArgs e)
        {

        }

        public void obterConjuntoA()
        {
            for (int c = 0; c < this.txt__ConjuntoA.Lines.Count(); c++)
            {
                this.ConjA.Add(this.txt__ConjuntoA.Lines[c]);
            }
        }

        public void obterConjuntoB()
        {
            for (int c = 0; c < this.txt__ConjuntoB.Lines.Count(); c++)
            {
                this.ConjB.Add(this.txt__ConjuntoB.Lines[c]);
            }
        }

        private void btn_operar_Click(object sender, EventArgs e)
        {
            obterConjuntoA();
            obterConjuntoB();

            this.txt__ConjuntoA.Enabled = false;
            this.txt__ConjuntoB.Enabled = false;

            conjuntos = new frm_conjunto(this.ConjA, this.ConjB);
            uniao = conjuntos.uniao();
            interccao = conjuntos.interccao();
            diferencaAB = conjuntos.diferencaAB();
            diferencaBA = conjuntos.diferencaBA();
            simetria = conjuntos.simetria();
            btn_operar.Visible = false;

            showResul();

        }

        public void showResul()
        {

            //união
            if (uniao.Count == 0)
            {
                this.txt_uniao.Text = "Conjunto Vazio";
            }
            else
            {

                foreach (string elemento in uniao)
                {
                    this.txt_uniao.Text += (elemento + " ; ");
                }
            }

            //interceção

            if (interccao.Count == 0)
            {
                this.txt_intersseccao.Text = "Conjunto Vazio";
            }
            else
            {

                foreach (string elemento in interccao)
                {
                    this.txt_intersseccao.Text += (elemento + " ; ");
                }
            }

            //diferencia A-B

            if (diferencaAB.Count == 0)
            {
                this.txx_diferenciaAB.Text = "Conjunto Vazio";
            }
            else
            {

                foreach (string elemento in diferencaAB)
                {
                    this.txx_diferenciaAB.Text += (elemento + " ; ");
                }
            }

            //diferencia B-A

            if (diferencaBA.Count == 0)
            {
                this.txt_diferenciaBA.Text = "Conjunto Vazio";
            }
            else
            {

                foreach (string elemento in diferencaBA)
                {
                    this.txt_diferenciaBA.Text += (elemento + " ; ");
                }
            }

            //simetria

            if (simetria.Count == 0)
            {
                this.txt_simetria.Text = "Conjunto Vazio";
            }
            else
            {

                foreach (string elemento in simetria)
                {
                    this.txt_simetria.Text += (elemento + " ; ");
                }
            }

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            clear();


        }

        private void txt__ConjuntoA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt__ConjuntoB_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void clear()
        {

            this.txt_uniao.Clear();
            this.txt_intersseccao.Clear();
            this.txt_diferenciaBA.Clear();
            this.txx_diferenciaAB.Clear();
            this.txt_simetria.Clear();
            this.txt__ConjuntoA.Clear();
            this.txt__ConjuntoB.Clear();
            this.txt__ConjuntoA.Enabled = true;
            this.txt__ConjuntoB.Enabled = true;
            this.ConjA.Clear();
            this.ConjB.Clear();




            this.uniao.Clear();
            this.interccao.Clear();
            this.diferencaAB.Clear();
            this.diferencaBA.Clear();
            this.simetria.Clear();

            this.btn_operar.Visible = true;

            txt__ConjuntoA.Focus();

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }
    }
}
