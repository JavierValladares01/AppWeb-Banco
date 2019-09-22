using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;
using Persistencia;

namespace Logica
{
    public class LogicaCompra
    {
        public static void RealizarCompra (Compra pCompra)
        {
            PersistenciaCompra.Comprar((Compra)pCompra);
        }

        public static List<Compra> ListadoComprasXCliente(int pCi)
        {
            List<Compra> oAux = PersistenciaCompra.ListadoComprasXCliente(pCi);


            return oAux;
        }
    }
}
