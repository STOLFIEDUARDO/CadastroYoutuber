using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   [Serializable]
   public class Model
   {
    public static int UltimoCodigo;
    private int Codigo;
    private string Nome;
    private string Sobrenome;
    private string Apelido;
    private string NomeCanal;
    private long QuantidaDeLikes;
    private int QuantidaDeInscritos;
    private long QuantidaDeVizualicao;
    private int QuantidaDeVideos;
    private string Nacionalidade;
    private bool Patrocinador;
    private bool Anuncios;
    private bool Streamer;
    private string Descricao;
    private double Renda;
    private string LinkDoCanal;
    private int QuantosStrikes;
    private string Categoria;
    private string Plataforma;



    public Model()
    {
        Codigo = ++UltimoCodigo;
    }

  
    public int GetCodigo()
    {
        return Codigo;
    }
    public void SetCodigo(int codigo)
    {
        this.Codigo = codigo;
    }

    public void SetNome(string nome)
    {
        if (nome.Trim().Count() < 2)
        {
            throw new Exception("Nome deve conter mais de 2 letras");
        }
        if (nome.Trim().Count() > 120)
        {
            throw new Exception("Nome deve conter no maximo 120 letras");
        }
        Nome = nome;
    }
    public string GetNome()
    {
        return Nome;
    }




    public void SetSobrenome(string sobrenome)
    {
        if (sobrenome.Trim().Count() < 2)
        {
            throw new Exception("Sobrenome deve conter mais de 2 letras");
        }
        if (sobrenome.Trim().Count() > 120)
        {
            throw new Exception("Sobrenome deve conter no maximo 120 letras");
        }
        Sobrenome = sobrenome;
    }
    public string GetSobrenome()
    {
        return Sobrenome;
    }





    public void SetApelido(string apelido)
    {
        if (apelido.Trim().Count() < 2)
        {
            throw new Exception("Apelido deve conter mais que 2 letras");
        }
        if (apelido.Trim().Count() > 120)
        {
            throw new Exception("Apelido deve conter no maximo 120 letras");
        }
        Apelido = apelido;
    }
    public string GetApelido()
    {
        return Apelido;
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
        NomeCanal = linhaSelecionada;
    }

    
    public string GetNomeCanal()
    {
        return NomeCanal;
    }





    public void SetQuantidaDeLikes(long quantidadeLikes)
    {
        if (quantidadeLikes < 0)
        {
            throw new Exception("Quantidade de likes deve ser igual a 0 ou maior");
        }
        if (quantidadeLikes > long.MaxValue)
        {
            throw new Exception("Quantidade de likes deve ser menor que " + long.MaxValue);
        }
        QuantidaDeLikes = quantidadeLikes;
    }
    public long GetQuantidaDeLikes()
    {
        return QuantidaDeLikes;
    }




    public void SetQuantidadeInscritos(int quantidaDeInscritos)
    {
        if (quantidaDeInscritos < 0)
        {
            throw new Exception("Quantidade de inscritos deve ser igual a 0 ou maior");
        }
        if (quantidaDeInscritos.ToString() == "")
        {
            throw new Exception("Quantidade de inscritos deve ser igual a 0 ou maior");
        }
        if (quantidaDeInscritos > int.MaxValue)
        {
            throw new Exception("Quantidade de likes deve ser menor que " + int.MaxValue);
        }
        QuantidaDeInscritos = quantidaDeInscritos;
    }
    public int GetQuantidadeInscritos()
    {
        return QuantidaDeInscritos;
    }



    public void SetQuantidadeVisualizacoes(long quantidadeVisualizacoes)
    {
        if (quantidadeVisualizacoes < 0)
        {
            throw new Exception("Quantidade de vizualizações deve ser igual a 0 ou maior");
        }
        if (quantidadeVisualizacoes > long.MaxValue)
        {
            throw new Exception("Quantidade de vizualizações deve ser menor que " + long.MaxValue);
        }
        QuantidaDeVizualicao = quantidadeVisualizacoes;
    }
    public long GetQuantidadeVisualizacoes()
    {
        return QuantidaDeVizualicao;
    }



    public void SetQuantidadeVideos(int quantidadeVideos)
    {
        if (quantidadeVideos < 0)
        {
            throw new Exception("Quantidade de videos deve ser igual a 0 ou maior");
        }
        if (quantidadeVideos < 0)
        {
            throw new Exception("Quantidade de videos deve ser menor que " + int.MaxValue);
        }
        QuantidaDeVideos = quantidadeVideos;
    }
    public int GetQuantidadeVideos()
    {
        return QuantidaDeVideos;
    }



    public void SetNacionalidade(string nacionalidade)
    {
        Nacionalidade = nacionalidade;
    }
    public string GetNacionalidade()
    {
        return Nacionalidade;
    }

    public void SetPatrocinador(bool patrocinador)
    {
        Patrocinador = patrocinador;
    }
    public bool GetPatrocinador()
    {
        return Patrocinador;
    }

    public void SetAnuncios(bool anuncios)
    {
        Anuncios = anuncios;
    }
    public bool GetAnuncios()
    {
        return Anuncios;
    }

    public void SetStreamer(bool streamer)
    {
       Streamer = streamer;
    }
    public bool GetStreamer()
    {
       return Streamer;
    }


    public void SetDescricao(string descricao)
    {
        Descricao = descricao;
    } 
    public string GetDescricao()
    {
           return Descricao;
    }



    public void SetLinkDoCanal(string linkDoCanal)
    {
       LinkDoCanal = linkDoCanal;
    }
    public string GetLinkDoCanal()
    {
       return LinkDoCanal;
    }




    public void SetCategoria(string categoria)
    {
       Categoria = categoria;
    }
       public string GetCategoria()
    {
       return Categoria;
    }




    




    public void SetRenda(double renda)
    {
      if (renda < 0)
      {
         throw new Exception("Renda deve ser igual a 0 ou maior");
      }
         Renda = renda;
      }
    public double GetRenda()
    {
       return Renda;
    }

    public void SetQuantosStrikes(int quantosStrikes)
    {
       if (quantosStrikes < 0)
       {
          throw new Exception("Quantidade de strikes deve ser igual a 0 ou maior");

       }
       if (quantosStrikes > 3)
       {
           throw new Exception("Quantidade de strikes deve ser menor ou igual a 3");
       }
           QuantosStrikes = quantosStrikes;

       }
       public int GetQuantosStrikes()
       {
           return QuantosStrikes;
       }

       public void SetPlataforma(string plataforma)
       {
           Plataforma = plataforma;
       }
       public string GetPlataforma()
       {
           return Plataforma;
       }




       







}
