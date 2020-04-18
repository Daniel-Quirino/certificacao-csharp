using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{

    interface IGPS
    {
        bool EstaNoHemisferioNorte();
    }

    struct PosicaoGPS : IGPS
            {
                public double Latitude;
                public double Longitude;

                public PosicaoGPS(double latitude, double longitude)
                {
                    Latitude = latitude;
                    Longitude = longitude;
                }

                public bool EstaNoHemisferioNorte()
                {
                    return Latitude > 0;
                }
            }

    class Estruturas : IAulaItem
    {
        public void Executar()
        {

            PosicaoGPS localizacao = new PosicaoGPS(23.6, 21.9);
            Console.WriteLine(localizacao.Latitude);
        }
    }
}
