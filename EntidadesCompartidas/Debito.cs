using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    public class Debito : Tarjeta
    {
        //atributos
        private double saldo;
        private int cantCuentas;


        //operaciones
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public int CantCuentas
        {

            get { return cantCuentas; }
            set { cantCuentas = value; }

        }

        //constructor
        public Debito(int pNroTarjeta, Cliente pCli, DateTime pFechaVencimiento, bool pPersonalizada, double pSaldo, int pCantCuentas)
            : base(pNroTarjeta, pCli, pFechaVencimiento, pPersonalizada)
        {
            Saldo = pSaldo;
            CantCuentas = pCantCuentas;
        }


        //operaciones
        public override string ToString()
        {
            return base.ToString() + " - " + " Saldo: " + saldo + " - " + "Cant. cuentas: " + cantCuentas;
        }


    }
}
