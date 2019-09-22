using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;
using System.Data;
using System.Data.SqlClient;

namespace Persistencia
{
    public class PersistenciaCompra
    {
        public static void Comprar (Compra pCompra)
        {
            SqlConnection oConexion = new SqlConnection(CONEXION.STR);
            SqlCommand oComando = new SqlCommand("sp_RealizarCompra", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;

            oComando.Parameters.AddWithValue("@nrotarjeta", pCompra.NroTarjeta);
            oComando.Parameters.AddWithValue("@fechacompra", pCompra.FechaCompra);
            oComando.Parameters.AddWithValue("@importe", pCompra.Importe);

            SqlParameter oRetorno = new SqlParameter("@Retorno", SqlDbType.Int);
            oRetorno.Direction = ParameterDirection.ReturnValue;
            oComando.Parameters.Add(oRetorno);

            try
            {
                oConexion.Open();
                oComando.ExecuteNonQuery();

                if ((int)oRetorno.Value == -3)
                    throw new Exception("Error al agregar tarjeta!");
                else if ((int)oRetorno.Value == -1)
                    throw new Exception("Importe excede saldo de la tareta!");
                else if ((int)oRetorno.Value == -2)
                    throw new Exception("Importe excede limite de la tarjeta!");
                else if ((int)oRetorno.Value == 0)
                    throw new Exception("Tarjeta no existe!");
                               
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


        public static List<Compra> ListadoComprasXCliente(int oCi)
        {
            int oNroCompra = 0;
            double oImporte = 0;
            DateTime oFechaCompra;
            int oNroT = 0;



            List<Compra> oListarComprasXCliente = new List<Compra>();
            SqlDataReader oReader;


            SqlConnection oConexion = new SqlConnection(CONEXION.STR);
            SqlCommand oCommando = new SqlCommand("exec sp_ListarComprasXCliente " + oCi, oConexion);


            try
            {
                oConexion.Open();
                oReader = oCommando.ExecuteReader();

                while (oReader.Read())
                {

                    oNroCompra = Convert.ToInt32((int)(oReader["IDCompra"]));
                    oImporte = (Double)(oReader["Importe"]);
                    oFechaCompra = (DateTime)oReader["FechaCompra"];
                    oNroT = Convert.ToInt32((int)(oReader["NroT"]));

                    Compra c = new Compra (oNroT, oNroCompra, oFechaCompra, oImporte);
                    oListarComprasXCliente.Add(c);
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
            return oListarComprasXCliente;
        }
    }
}
