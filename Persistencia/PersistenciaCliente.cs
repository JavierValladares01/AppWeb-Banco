using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;
using System.Data;
using System.Data.SqlClient;

namespace Persistencia
{
    public class PersistenciaCliente
    {
        public static void Agregar(Cliente pCliente)
        {
            SqlConnection oConexion = new SqlConnection(CONEXION.STR);
            SqlCommand oComando = new SqlCommand("sp_AgregarCliente", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;

            oComando.Parameters.AddWithValue("@ci", pCliente.Cedula);
            oComando.Parameters.AddWithValue("@nom", pCliente.Nombre);
            oComando.Parameters.AddWithValue("@apell", pCliente.Apellido);
            oComando.Parameters.AddWithValue("@numtelf", pCliente.Telefono);

            SqlParameter oRetorno = new SqlParameter("@Retorno", SqlDbType.Int);
            oRetorno.Direction = ParameterDirection.ReturnValue;
            oComando.Parameters.Add(oRetorno);

            try
            {
                oConexion.Open();
                oComando.ExecuteNonQuery();

                if ((int)oRetorno.Value == 0) 
                    throw new Exception("Cedula ya existe!");
                else if ((int)oRetorno.Value == -1)
                    throw new Exception("Error al agregar cliente");


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                oConexion.Close();
            }



        }
        public static void Modificar(Cliente pCliente)
        {
            SqlConnection oConexion = new SqlConnection(CONEXION.STR);
            SqlCommand oComando = new SqlCommand("sp_ModificarCliente", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;

            oComando.Parameters.AddWithValue("@ci", pCliente.Cedula);
            oComando.Parameters.AddWithValue("@nom", pCliente.Nombre);
            oComando.Parameters.AddWithValue("@apell", pCliente.Apellido);
            oComando.Parameters.AddWithValue("@numtelf", pCliente.Telefono);

            SqlParameter oRetorno = new SqlParameter("@Retorno", SqlDbType.Int);
            oRetorno.Direction = ParameterDirection.ReturnValue;
            oComando.Parameters.Add(oRetorno);

            try
            {
                oConexion.Open();
                oComando.ExecuteNonQuery();

                if ((int)oRetorno.Value == -1)
                    throw new Exception("Cedula no existe - No se modifica");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                oConexion.Close();
            }

        }

        public static Cliente Buscar(int pCedula)
        {
            string oNombre;
            string oApellido;
            int oTelefono;

            Cliente c = null;
            SqlDataReader oReader;

            SqlConnection oConexion = new SqlConnection(CONEXION.STR);
            SqlCommand oComando = new SqlCommand("Exec sp_BuscoCliente " + pCedula, oConexion);

            try
            {
                oConexion.Open();
                oReader = oComando.ExecuteReader();

                if (oReader.HasRows)
                {
                    oReader.Read();
                    oNombre = (string)oReader["Nombre"];
                    oApellido = (string)oReader["Apellido"];
                    oTelefono = Convert.ToInt32(oReader["Numero"]); //OJO!!
                    c = new Cliente(pCedula, oNombre, oApellido, oTelefono);

                }

                oReader.Close();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                oConexion.Close();
            }
            return c;

        }

        public static void Eliminar(Cliente pCliente) //elimina el cliente pero tiene problemas con retorno!!
        {
            SqlConnection oConexion = new SqlConnection(CONEXION.STR);
            SqlCommand oComando = new SqlCommand("sp_BajaCliente", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;

            SqlParameter oCedula = new SqlParameter("@ci", pCliente.Cedula);
            SqlParameter oRetorno = new SqlParameter("@Retorno", SqlDbType.Int);
            oRetorno.Direction = ParameterDirection.ReturnValue;

            oComando.Parameters.Add(oCedula);
            oComando.Parameters.Add(oRetorno);

            try
            {
                oConexion.Open();
                oComando.ExecuteNonQuery();

                int oAfectados = (int)oComando.Parameters["@Retorno"].Value;

                if (oAfectados == 0)
                    throw new Exception("Hay compras asociadas! - no se puede eliminar"); 
                else if (oAfectados == -1)
                    throw new Exception("Error al eliminar credito/debito");

                else if (oAfectados == -2)
                    throw new Exception("Error al eliminar tarjeta");

                else if (oAfectados == -3)
                    throw new Exception("Error al eliminar telefono");

                else if (oAfectados == -4)
                    throw new Exception("Error al eliminar cliente");

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                oConexion.Close();
            }

        }

        public static List<Cliente> ListarClientes()
        {
            int oCi;
            int oTelefono;
            string oNombre;
            string oApellido;


            List<Cliente> oListarClientes = new List<Cliente>();
            SqlDataReader oReader;

            SqlConnection oConexion = new SqlConnection(CONEXION.STR);
            SqlCommand oComando = new SqlCommand("sp_ListarClientes", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;


            try
            {
                oConexion.Open();
                oReader = oComando.ExecuteReader();

                while (oReader.Read())
                {
                    oCi = Convert.ToInt32((int)oReader["Ci"]);
                    oNombre = (string)oReader["Nombre"];
                    oApellido = (string)oReader["Apellido"];
                    oTelefono = Convert.ToInt32((int)oReader["Numero"]);



                    Cliente c = new Cliente (oCi, oNombre, oApellido, oTelefono);
                    oListarClientes.Add(c);
                }

                oReader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                oConexion.Close();
            }
            return oListarClientes;
        }

    }

}

