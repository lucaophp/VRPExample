using System;
namespace vrp.Model 
{
    class Rota 
    {
        private string uid { set; get;}
        private Cliente[] clientes { set; get;}
        private Veiculo veiculo { set; get;}
        private string[] ordem { set; get;} 
        private double custo { set; get; }
    }
}