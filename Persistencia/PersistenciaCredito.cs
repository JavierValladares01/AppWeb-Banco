using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;
using System.Data;
using System.Data.SqlClient;

namespace Persistencia
{
    public class PersistenciaCredito
    {

        public static void Agregar(Credito pCredito)
        {
            SqlConnection oConexion = new SqlConnection(CONEXION.STR);
            SqlCommand oComando = new SqlCommand("sp_AgregarTarjetaCredito", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;

            oComando.Parameters.AddWithValue("@ci", pCredito.Cli.Cedula);
            oComando.Parameters.AddWithValue("@fechaven", pCredito.FechaVencimiento);
            oComando.Parameters.AddWithValue("@per", pCredito.Personalizada);
            oComando.Parameters.AddWithValue("@cat", pCredito.Categoria);
            oComando.Parameters.AddWithValue("@lim", pCredito.Limite);

            SqlParameter oRetorno = new SqlParameter("@Retorno", SqlDbType.Int);
            oRetorno.Direction = ParameterDirection.ReturnValue;
            oComando.Parameters.Add(oRetorno);


            try
            {
                oConexion.Open();
                oComando.ExecuteNonQuery();

                 if ((int)oRetorno.Value == 0)
                    throw new Exception("Cedula no existe!");

                else if ((int)oRetorno.Value == -1)
                    throw new Exception("Error al agregar tarjeta!");
                

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

        public static List<Tarjeta> ListarVencidasCredito()
        {
            int oNroT;
            Boolean oPersonalizada;
            DateTime oFechaVen;
            Cliente Cli;
            int oLimite;
            string oCategoria;

            List<Tarjeta> oListadoTarjetasVencidas = new List<Tarjeta>();
            Credito c;

            SqlDataReader oReader;


            SqlConnection oConexion = new SqlConnection(CONEXION.STR);
            SqlCommand oComando = new SqlCommand("sp_ListarTarjetasCreditoVencidas", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;

            try
            {
                oConexion.Open();
                oReader = oComando.ExecuteReader();


                while (oReader.Read())
                {
                    oNroT = Convert.ToInt32((int)oReader["NroT"]);
                    Cli = PersistenciaCliente.Buscar(Convert.ToInt32((int)oReader["CI"]));
                    oFechaVen = Convert.ToDateTime((DateTime)oReader["FechaVencimiento"]);                    
                    oPersonalizada = (bool)oReader["Personalizada"];
                    oLimite = Convert.ToInt32((int)oReader["Limite"]);
                    oCategoria = (string)oReader["Categoria"];
                                        

                    c = new Credito(oNroT, Cli, oFechaVen, oPersonalizada, oLimite, oCategoria);
                    oListadoTarjetasVencidas.Add(c);
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
            return oListadoTarjetasVencidas;
        }

        public static List<Credito> ListarCreditoCliente(int oci)
        {
            int oNroT;
            Boolean oPersonalizada;
            DateTime oFechaVen;
            Cliente Cli;

            int oLimite;
            string oCategoria;

            List<Credito> oListadoTarjetasCredito = new List<Credito>();
            SqlDataReader oReader;

            SqlConnection oConexion = new SqlConnection(CONEXION.STR);
            SqlCommand oComando = new SqlCommand("exec sp_ListarTarjetaCredito " + oci, oConexion);


            
            try
            {
                oConexion.Open();
                oReader = oComando.ExecuteReader();

                if (oReader.HasRows)

                {
                    while (oReader.Read())
                    {
                        oNroT = Convert.ToInt32((int)oReader["NroT"]);
                        oFechaVen = (DateTime)oReader["FechaVencimiento"];
                        Cli = PersistenciaCliente.Buscar(Convert.ToInt32((int)oReader["CI"]));
                        oPersonalizada = (bool)oReader["Personalizada"];
                        oLimite = Convert.ToInt32((int)oReader["Limite"]);
                        oCategoria = (string)oReader["Categoria"];

                        Credito c = new Credito(oNroT, Cli, oFechaVen, oPersonalizada, oLimite, oCategoria);
                        oListadoTarjetasCredito.Add(c);
                    }
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
            return oListadoTarjetasCredito;
        }

    }
}
