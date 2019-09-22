using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;
using Persistencia;

namespace Logica
{
    public class LogicaCliente
    {
        public static void Agregar(Cliente pCliente)
        {
            PersistenciaCliente.Agregar((Cliente)pCliente);

        }

        public static Cliente Buscar(int pCedula)
        {
            Cliente c = PersistenciaCliente.Buscar(pCedula);

            return c;
        }

        public static void Modificar(Cliente pCliente)
        {
            PersistenciaCliente.Modificar((Cliente)pCliente);
        }

        public static void Eliminar(Cliente pCliente)
        {
            PersistenciaCliente.Eliminar(pCliente);
        }

        public static List<Cliente> ListarClientes()
        {
            return PersistenciaCliente.ListarClientes();
        }

    }
}
