using System;
namespace vrp.Model 
{
    class Cliente
    {
        private string uid { set; get;}
        private string nome { set; get;}
        private Encomenda demanda { set; get;}
        private Ponto localizacao { set; get;} 
    }
}