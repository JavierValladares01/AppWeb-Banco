using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    public abstract class Tarjeta
    {
        //atributos
        private int nroTarjeta;
        private Cliente cli;
        private DateTime fechaVencimiento;
        private bool personalizada;

        //propiedades
        public int NroTarjeta
        {
            get { return nroTarjeta; }
            set { nroTarjeta = value; }

        }



  
       public Cliente Cli
        {
            get { return cli; }
            set { cli = value; }
        }




        public DateTime FechaVencimiento
        {
            get { return fechaVencimiento; }
            set { fechaVencimiento = value; }

        }

        public bool Personalizada
        {
            get { return personalizada; }
            set { personalizada = value; }

        }

        //constructor

        public Tarjeta(int pNroTarjeta, Cliente pCli, DateTime pFechaVencimiento, bool pPersonalizada)
        {
            NroTarjeta = pNroTarjeta;
            Cli = pCli;
            FechaVencimiento = pFechaVencimiento;
            Personalizada = pPersonalizada;

        }

        //Operaciones

        public override string ToString()
        {
            string MuestroCliente = "Nro: " + nroTarjeta + " - " + " FechaVenc: " + fechaVencimiento.ToString("dd/MM/yyyy") + " - " + Cli.ToString();

            if (personalizada)
                MuestroCliente += " - Personalizada?: Si";
            else
                MuestroCliente += " - Personalizada?: No";
                       
            return MuestroCliente;
        }


    }
}
