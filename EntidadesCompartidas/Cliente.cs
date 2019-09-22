using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    public class Cliente
    {
        //atributos
        private int cedula;
        private string nombre;
        private string apellido;
        private int telefono;



        //propiedades
        public int Cedula
        {
            get { return cedula; }

            set
            {
                if (value <= 99999999)
                    cedula = value;
                else
                    throw new Exception("Número de documento invalido!");

            }
        }

        public string Nombre
        {
            get { return nombre; }

            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }

           set { apellido = value; }
        }

        public int Telefono
        {
            get { return telefono; }

            set { telefono = value; }
        }


        //constructor
        public Cliente(int pCedula, string pNombre, string pApellido, int pTelefono)
        {

            Cedula = pCedula;
            Nombre = pNombre;
            Apellido = pApellido;
            Telefono = pTelefono;

        }

        public string DatosCliente
        {
            get { return this.ToString(); }
        }

        //operaciones

        public override string ToString()
        {
            return cedula + " - " + nombre + " " + apellido;
        }
    }
}
