using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    public class Compra
    {
        //atributos
        private int nroTarjeta;
        private int idCompra;
        private DateTime fechaCompra;
        private double importe;


        //propiedades

        public int IdCompra
        {
            get { return idCompra; }
            set { idCompra = value; }

        }

        public int NroTarjeta
        {
            get { return nroTarjeta; }
            set { nroTarjeta = value; }

        }

        public DateTime FechaCompra
        {
            get { return fechaCompra; }
            set
            {
                if (DateTime.Now > value)
                {
                    fechaCompra = value;
                }
                else
                {
                    throw new Exception("Las compras no pueden exceder la fecha de hoy");
                }
            }
        }

        public double Importe
        {
            get { return importe; }
            set { importe = value; }

        }


        //constructores
        public Compra(int pNroTarjeta, int pIdCompra, DateTime pFechaCompra, double pImporte)
        {
            NroTarjeta = pNroTarjeta;
            IdCompra = pIdCompra;
            FechaCompra = pFechaCompra;
            Importe = pImporte;

        }


        //operaciones

        public override string ToString()
        {
            return "Nro. Tarjeta: " + nroTarjeta + "ID Compra: " + idCompra + "Fecha de compra: " + fechaCompra + "Importe: " + importe;
        }

    }
}
