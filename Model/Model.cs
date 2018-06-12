using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   [Serializable]
   public class Model
   {
    private static int UltimoCodigo;
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

    public void SetNomeCanal(string nomeCANAL)
    {
        if (nomeCANAL.Trim().Count() < 2)
        {
            throw new Exception("NomeDoCanal deve conter mais de 2 letras");
        }
        if (nomeCANAL.Trim().Count() > 120)
        {
            throw new Exception("NomeDoCanal deve conter no maximo 120 letras");
        }
        NomeCanal = nomeCANAL;
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

   
}
