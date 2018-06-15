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
    public partial class CadastroYoutuber : Form
    {
        private int CodigoSelecionado = -1;
        public int posicao = -1;
        private Model salvar;
        public static string NOME_ARQUIVO = "CadastrosYoutuber.bin";

        public CadastroYoutuber()
        {
            InitializeComponent();
        }
        
        public CadastroYoutuber(string linhaSelecionada)
        {
            InitializeComponent();
            this.CodigoSelecionado = CodigoSelecionado;
            CadastroYoutuberRepository repositorio = new CadastroYoutuberRepository();

            int quantidade = 0;
            for (int i = 0; i < repositorio.ObterTeens().Count(); i++)
            {
                Model youtubersTeen = repositorio.ObterTeens()[i];
                if (youtubersTeen.GetCodigo() == CodigoSelecionado)
                {
                    txtNome.Text = youtubersTeen.GetNome();
                    txtSobrenome.Text = youtubersTeen.GetSobrenome();
                    txtApelido.Text = youtubersTeen.GetApelido();
                    txtNomeCanal.Text = youtubersTeen.GetNomeCanal();
                    txtLikes.Text = youtubersTeen.GetQuantidaDeLikes().ToString();
                    txtInscritos.Text = youtubersTeen.GetQuantidadeInscritos().ToString();
                    txtVizualizacao.Text = youtubersTeen.GetQuantidadeVisualizacoes().ToString();
                    nudVideos.Value = youtubersTeen.GetQuantidadeVideos();
                    txtNacionalidade.Text = youtubersTeen.GetNacionalidade();
                    chkPatrocinador.Checked = youtubersTeen.GetPatrocinador();
                    chkAnuncio.Checked = youtubersTeen.GetAnuncios();
                    chkStreamer.Checked = youtubersTeen.GetStreamer();
                    txtDescricao.Text = youtubersTeen.GetDescricao();
                    txtRenda.Text = youtubersTeen.GetRenda().ToString();
                    txtLink.Text = youtubersTeen.GetLinkDoCanal();
                    nudStrikes.Value = youtubersTeen.GetQuantosStrikes();
                    cbPlataforma.Text = youtubersTeen.GetPlataforma();
                    cbCategoria.Text = youtubersTeen.GetCategoria();
                    return;
                }
                quantidade++;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarCadastro();
        }
        private void SalvarCadastro()
        {
            salvar = new Model();

            try
            {
                salvar.SetNome(txtNome.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor preencha nome");
                txtNome.Focus();
                return;
            }
            try
            {
                salvar.SetSobrenome(txtSobrenome.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor preencha sobrenome");
                txtSobrenome.Focus();
                return;
            }

            try
            {
                salvar.SetApelido(txtApelido.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor preencha apelido");
                txtApelido.Focus();
                return;
            }
           
            try
            {
                salvar.SetQuantidaDeLikes(Convert.ToInt64(txtLikes.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor preencha quantidade de likes");
                txtLikes.Focus();
                return;
            }
            try
            {
                salvar.SetQuantidadeInscritos(Convert.ToInt32(txtInscritos.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show("Por favor preencha quantidade de inscritos");
                txtInscritos.Focus();
                return;
            }
            try
            {
                salvar.SetQuantidadeVisualizacoes(Convert.ToInt64(txtVizualizacao.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show("Por favor preencha quantidade de vizualições");
                txtVizualizacao.Focus();
                return;
            }
            try
            {
                salvar.SetQuantidadeVideos(Convert.ToInt32(nudVideos.Value));
            }
            catch (Exception ex)
            {

                MessageBox.Show("Por favor preencha quantidade de videos");
                nudVideos.Focus();
                return;
            }
            try
            {
                salvar.SetNacionalidade(txtNacionalidade.Text);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Por favor preencha o campo nacionalidade");
                txtNacionalidade.Focus();
                return;
            }
            if (chkPatrocinador.Checked)
            {
                salvar.SetPatrocinador(true);
            }
            else
            {
                salvar.SetPatrocinador(false);
            }



            if (chkStreamer.Checked)
            {
                salvar.SetStreamer(true);
            }
            else
            {
                salvar.SetStreamer(false);
            }


            if (chkAnuncio.Checked)
            {
                salvar.SetAnuncios(true);
            }
            else
            {
                salvar.SetAnuncios(false);
            }

            try
            {
                salvar. SetDescricao(txtDescricao.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor preencha descrição");
                txtDescricao.Focus();
                return;
            }

            try
            {
                salvar.SetRenda(Convert.ToDouble(txtRenda.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show("Por favor preencha o campo renda");
                txtRenda.Focus();
                return;
            }
            try
            {
                salvar.SetCodigo(Convert.ToInt32(txtCodigo.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show("Por favor preencha o campo codigo");
                txtCodigo.Focus();
                return;
            }


            try
            {
                salvar.SetLinkDoCanal(txtLink.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor preencha link do canal");
                txtLink.Focus();
                return;
            }
            

            try
            {
                salvar.SetQuantosStrikes(Convert.ToInt32(nudStrikes.Value));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                nudStrikes.Focus();
                return;
            }



            if (cbCategoria.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor selecione uma Categoria");
                cbCategoria.DroppedDown = true;
                return;
            }
            try
            {
                salvar.SetCategoria(cbCategoria.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor selecione uma categoria");
                cbCategoria.DroppedDown = true;
                return;
            }

           
            if (cbPlataforma.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor selecione uma plataforma");
                cbPlataforma.DroppedDown = true;
                return;
            }
            try
            {
                salvar.SetPlataforma(cbPlataforma.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor selecione uma plataforma");
                cbPlataforma.DroppedDown = true;
                return;
            }

            CadastroYoutuberRepository tudo = new CadastroYoutuberRepository();
            if (CodigoSelecionado == -1)
            {
                tudo.AdicionarYoutuber(salvar);
                MessageBox.Show("Youtuber cadastrado com sucesso");
            }
            else
            {
                tudo.SetCodigo(CodigoSelecionado);
                tudo.EditarYoutuber(salvar, CodigoSelecionado);
                MessageBox.Show("Youtuber alterado com sucesso");
            }

         
          

            LimparCampos();
        }
        private void LimparCampos()
        {
          

            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtApelido.Text = "";
            txtNomeCanal.Text = "";
            txtLikes.Text = "";
            txtInscritos.Text = "";
            txtVizualizacao.Text = "";
            nudVideos.Value = 0;
            txtNacionalidade.Text = "";
            chkPatrocinador.Checked = false;
            chkAnuncio.Checked = false;
            chkStreamer.Checked = false;
            txtDescricao.Text = "";
            txtRenda.Text = "";
            txtLink.Text = "";
            nudStrikes.Value = 0;
            cbCategoria.SelectedIndex = -1;
            cbPlataforma.SelectedIndex = -1;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void CadastroYoutuber_Load(object sender, EventArgs e)
        {

        }

        private void chkStreamer_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void txtLink_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbPlataforma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeCanal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNacionalidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInscritos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVizualização_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudStrikes_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtLikes_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApelido_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkAnuncio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkPatrocinador_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nudVideos_ValueChanged(object sender, EventArgs e)
        {

        }

       
    }
}
