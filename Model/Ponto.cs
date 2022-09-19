using System;
namespace vrp.Model
{
    class Ponto {
        public double x;
        public double y;
        public static double ToRadians (double angleIn10thofaDegree) {
            // Angle in 10th of a degree
            return (angleIn10thofaDegree * Math.PI)/180; 
        }
        public double distancia (Ponto p2) {
            double Raio = 6371;
            // double Raio = 3959;
            double dLat = ToRadians(p2.x - this.x);
            double dLon = ToRadians(p2.y - this.y);
            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) + Math.Cos(ToRadians(this.x))* Math.Cos(ToRadians(p2.x)) * Math.Sin(dLon/2) * Math.Sin(dLon/2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1-a));

            double distancia = c * Raio;
            return distancia;
        }
    }
}
