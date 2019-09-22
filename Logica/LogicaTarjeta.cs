using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;
using Persistencia;

namespace Logica
{
    public class LogicaTarjeta
    {
        public static void Agregar(Tarjeta pTarjeta)
        {
            if (pTarjeta is Credito)
            {
                PersistenciaCredito.Agregar((Credito)pTarjeta);
            }
            else
            {
                PersistenciaDebito.Agregar((Debito)pTarjeta);
            }
        }

        public static List<Tarjeta> ListadoTarjetasCreditoVencidas()
        {
            List<Tarjeta> oAux = PersistenciaCredito.ListarVencidasCredito();


            return oAux;
        }

        public static List<Tarjeta> ListadoTarjetasDebitoVencidas()
        {
            List<Tarjeta> oAux = PersistenciaDebito.ListarVencidasDebito();


            return oAux;
        }

        public static List<Tarjeta> ListadoTarjetasVencidas()
        {
            List<Tarjeta> oAux = PersistenciaCredito.ListarVencidasCredito();
            oAux.AddRange(PersistenciaDebito.ListarVencidasDebito());

            return oAux;
        }

        public static List<Tarjeta> ListadoTarjetasCliente(int CI)
        {
            List<Tarjeta> oAux = new List<Tarjeta>();

            oAux.AddRange(PersistenciaCredito.ListarCreditoCliente(CI));
            oAux.AddRange(PersistenciaDebito.ListarDebitoCliente(CI));


            return oAux;

        }

    }
}
