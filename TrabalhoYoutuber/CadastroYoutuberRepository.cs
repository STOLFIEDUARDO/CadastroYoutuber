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
            youtubersteen.Add(youtubers);

            EscreverNoArquivoDoCadastroYoutubers();
        }

        internal void EditarYoutuber(Model youtubers, string posicao)
        {
            for (int i = 0; i < youtubersteen.Count(); i++)
            {
                Model youtuberTeenAux = youtubersteen[i];
                if (youtuberTeenAux.GetNomeCanal() == posicao)
                {
                    youtubersteen[i] = youtubers;
                    EscreverNoArquivoDoCadastroYoutubers();
                    return;

                }
            }

        }

        internal void ApagarPersonagem(string nome)
        {
            foreach (Model youtubersteens in youtubersteen)
            {
                if (youtubersteens.GetNomeCanal() == nome)
                {
                    youtubersteen.Remove(youtubersteens);
                    EscreverNoArquivoDoCadastroYoutubers();
                    return;
                }
            }
        }

        public List<Model> ObterTeens()
        {
            return youtubersteen;
        }



        internal void Apagar(string nome)
        {
            foreach (Model apagar in youtubersteen)
            {
                if (apagar.GetNomeCanal() == nome)
                {
                    youtubersteen.Remove(apagar);
                    EscreverNoArquivoDoCadastroYoutubers();
                    return;
                }
            }
        }

        internal void SetNomeCanal(string linhaSelecionada)
        {
            if (linhaSelecionada.Trim().Count() < 2)
            {
                throw new Exception("NomeDoCanal deve conter mais de 2 letras");
            }
            if (linhaSelecionada.Trim().Count() > 120)
            {
                throw new Exception("NomeDoCanal deve conter no maximo 120 letras");
            }
             
        }
    }
}
