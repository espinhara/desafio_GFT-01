using System;
using System.Collections.Generic;
using System.Text;


namespace teste_02
{
    class Transporte
    {
        public  Transporte(Carga carga)
        {
            decimal calculaFrete()
            {
                decimal frete;
                frete = carga.peso* 20/100+ carga.valor *10/100;
                return frete;
            }
        }
    }
}
