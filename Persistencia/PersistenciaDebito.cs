using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;
using System.Data;
using System.Data.SqlClient;

namespace Persistencia
{
    public class PersistenciaDebito
    {

        public static void Agregar(Debito pDebito)
        {
            SqlConnection oConexion = new SqlConnection(CONEXION.STR);
            SqlCommand oComando = new SqlCommand("sp_AgregarTarjetaDebito", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;

            oComando.Parameters.AddWithValue("@ced", pDebito.Cli.Cedula);
            oComando.Parameters.AddWithValue("@fechaVen", pDebito.FechaVencimiento);
            oComando.Parameters.AddWithValue("@per", pDebito.Personalizada);
            oComando.Parameters.AddWithValue("@sal", pDebito.Saldo);
            oComando.Parameters.AddWithValue("@cantc", pDebito.CantCuentas);

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

        public static List<Tarjeta> ListarVencidasDebito()
        {
            int oNroT;
            Boolean oPersonalizada;
            DateTime oFechaVen;
            Cliente Cli;
            double oSaldo;
            int oCantC;

            List<Tarjeta> oListadoTarjetasVencidas = new List<Tarjeta>();
            Debito d;

            SqlDataReader oReader;


            SqlConnection oConexion = new SqlConnection(CONEXION.STR);
            SqlCommand oComando = new SqlCommand("sp_ListarTarjetasDebitoVencidas", oConexion);
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
                    oSaldo = Convert.ToDouble((double)oReader["Saldo"]);
                    oCantC = Convert.ToInt32((int)oReader["CantCuentas"]);


                    d = new Debito (oNroT, Cli, oFechaVen, oPersonalizada, oSaldo, oCantC);
                    oListadoTarjetasVencidas.Add(d);
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
        public static List<Debito> ListarDebitoCliente(int oci)
        {
            int oNroT;
            Boolean oPersonalizada;
            DateTime oFechaVen;
            Cliente Cli;

            Double oSaldo;
            int oCantCuentas;

            List<Debito> oListadoTarjetasDebito = new List<Debito>();
            SqlDataReader oReader;

            SqlConnection oConexion = new SqlConnection(CONEXION.STR);
            SqlCommand oComando = new SqlCommand("exec sp_ListarTarjetaDebito " + oci, oConexion);



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
                        oSaldo = Convert.ToDouble((Double)oReader["Saldo"]);
                        oCantCuentas = Convert.ToInt32((int)oReader["CantCuentas"]);

                        Debito d = new Debito(oNroT, Cli, oFechaVen, oPersonalizada, oSaldo, oCantCuentas);
                        oListadoTarjetasDebito.Add(d);
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
            return oListadoTarjetasDebito;
        }




    }
}
