using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoYoutuber
{
    public partial class Inicial : Form
    {
        public static string NOME_ARQUIVO = "CadastrosYoutuber.bin";
        public Inicial()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            CadastroYoutuber youtubersteens = new CadastroYoutuber();
            youtubersteens.ShowDialog();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Apagar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um campo para editar");
                return;
            }

            string linhaSelecionada = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();

            new CadastroYoutuber(linhaSelecionada).ShowDialog();
        }

       

        

        private void Apagar()
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione algo neste grid");
                return;
            }

            string nome = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            CadastroYoutuberRepository youtube = new CadastroYoutuberRepository();
            youtube.Apagar(nome);
            MessageBox.Show(nome + " apagado com sucesso.");
        
            
        }

        

        

        private void AtualizarListaYoutubers()
        {
            CadastroYoutuberRepository obtem = new CadastroYoutuberRepository();
            dataGridView1.Rows.Clear();

            foreach (Model dgv in obtem.ObterTeens())
            {
                dataGridView1.Rows.Add(new Object[]
                {
                
                    dgv.GetNome(),
                    dgv.GetQuantosStrikes(),
                    dgv.GetQuantidadeVisualizacoes(),
                    dgv.GetQuantidadeInscritos(),
                    dgv.GetApelido()
                });
            }
        }

        private void Inicial_Activated(object sender, EventArgs e)
        {
            AtualizarListaYoutubers();
        }

       

        

    }
}
