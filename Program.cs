using System;
using vrp.Model;

namespace vrp
{
    class Program
    {
        static void Main(string[] args)
        {
            Ponto p1 = new Ponto();
            Ponto p2 = new Ponto();
            p1.x = -19.8157f;
            p1.y = -43.9542f;
            p2.x = -23.5489f;
            p2.y = -46.6388f;


            Console.WriteLine("Hello World! {0}", p2.distancia(p1));
        }
    }
}
