using System;
namespace vrp.Model 
{
    class Encomenda 
    {
        private string uid { set; get;}
        private string tipo { set; get;}
        private double quantidade { set; get;}
        private Ponto origem { set; get;}
        private Ponto destino { set; get;}
    }
}