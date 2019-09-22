using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    public class Credito : Tarjeta
    {
        //atributos 
        private int limite;
        private string categoria;


        //propiedades
        public int Limite
        {
            get { return limite; }
            set { limite = value; }

        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }

        }


        //constructor
        public Credito(int pNroTarjeta, Cliente pCli, DateTime pFechaVencimiento, bool pPersonalizada, int pLimite, string pCategoria)
            : base(pNroTarjeta, pCli, pFechaVencimiento, pPersonalizada)
        {
            Limite = pLimite;
            Categoria = pCategoria;

        }

        //operaciones
        public override string ToString()
        {
            return base.ToString() + " - " + " Limite: "  + limite + " - " + " Categoria: " + categoria;
        }
    }
}
