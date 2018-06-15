using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoYoutuber
{
    [Serializable]
    class CadastroYoutuberRepository
    {
        List<Model> youtubersteen = new List<Model>();

        public CadastroYoutuberRepository()
        {
            if (File.Exists(CadastroYoutuber.NOME_ARQUIVO))
            {
                BinaryFormatter binaryReader = new BinaryFormatter();
                Stream stream = File.OpenRead(CadastroYoutuber.NOME_ARQUIVO);
                youtubersteen = ((CadastroYoutuberRepository)binaryReader.Deserialize(stream)).ObterTeens();
                stream.Close();
                int maiorCodigo = int.MinValue;
                foreach (Model salvar in youtubersteen)
                {
                    maiorCodigo = salvar.GetCodigo() > maiorCodigo ? salvar.GetCodigo() : maiorCodigo;
                }
                if (Model.UltimoCodigo == 0)
                {
                    Model.UltimoCodigo = maiorCodigo;
                }
            }
        }
        private void EscreverNoArquivoDoCadastroYoutubers()
        {
            BinaryFormatter binaryWrite = new BinaryFormatter();
            Stream stream = new FileStream(CadastroYoutuber.NOME_ARQUIVO, FileMode.Create, FileAccess.Write);
            binaryWrite.Serialize(stream, this);
            stream.Close();
        }
        public void AdicionarYoutuber(Model youtubers)
        {
            youtubers.SetCodigo(++Model.UltimoCodigo);
            youtubersteen.Add(youtubers);

            EscreverNoArquivoDoCadastroYoutubers();
        }

        internal void EditarYoutuber(Model youtubers, int posicao)
        {
            for (int i = 0; i < youtubersteen.Count(); i++)
            {
                Model youtuberTeenAux = youtubersteen[i];
                if (youtuberTeenAux.GetCodigo() == posicao)
                {
                    youtubersteen[i] = youtubers;
                    EscreverNoArquivoDoCadastroYoutubers();
                    return;

                }
            }

        }

       
        public List<Model> ObterTeens()
        {
            return youtubersteen;
        }



        internal void Apagar(int codigo)
        {
            foreach (Model apagar in youtubersteen)
            {
                if (apagar.GetCodigo() == codigo)
                {
                    youtubersteen.Remove(apagar);
                    EscreverNoArquivoDoCadastroYoutubers();
                    return;
                }
            }
        }
        private int Codigo;
        public int GetCodigo()
        {
            return Codigo;
        }
        public void SetCodigo(int codigo)
        {
            this.Codigo = codigo;
        }



    }
}
