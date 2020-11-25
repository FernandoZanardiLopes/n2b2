using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace n2b2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label1.Text = Program.Tipo;

            if(Program.Tipo == "Marca")
            {
                lblCodigo.Text = "Código";
                lbldescricao.Text = "Descrição";
                lblmarca.Visible = false;
                txtmarca.Visible = false;

            }
            else
            {
                lblCodigo.Text = "Código";
                lbldescricao.Text = "Descrição";
                lblmarca.Text = "Código da Marca";
                
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Program.Tipo == "Marca")
            {
                Marca ma = new Marca();
                ma.Codigo = Convert.ToInt32(txtcodigo.Text.Trim());
                ma.Descricao = txtdescricao.Text.Trim();
                Funcoes.SalvarMarca(ma);
            }
            else
            {
                Modelo mo = new Modelo();
                mo.CodigoM = Convert.ToInt32(txtcodigo.Text.Trim());
                mo.DescricaoM = txtdescricao.Text.Trim();
                mo.Codigo = Convert.ToInt32(txtmarca.Text.Trim());
                Funcoes.SalvarModelo(mo);
            }
            

        }
    }
}
