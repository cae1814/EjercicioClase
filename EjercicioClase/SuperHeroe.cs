using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase
{
    internal class SuperHeroe : SuperPoder
    {
        private string nombre;
        private string identidadSecreta;
        private string superPoder;
        private string ciudad;
        private Boolean puedeVolar;

        public string Nombre
        {
            get { 
                return nombre; 
            }
            set {
                nombre = value; 
            }
        }

        public string IdentidadSecreta
        {
            get
            {
                return identidadSecreta;
            }
            set
            {
                identidadSecreta = value;
            }
        }

        public string SuperPoder
        {
            get
            {
                return superPoder;
            }
            set
            {
                superPoder = value;
            }
        }

        public string Ciudad
        {
            get
            {
                return ciudad;
            }
            set
            {
                ciudad = value;
            }
        }

        public Boolean PuedeVolar
        {
            get
            {
                return puedeVolar;
            }
            set
            {
                puedeVolar = value;
            }
        }

        public void imprimir() {
            Console.WriteLine("Nombre: "+nombre);
            Console.WriteLine("Identidad Secreta: "+IdentidadSecreta);
            Console.WriteLine("Ciudad: "+ciudad);
            Console.WriteLine("Puede volar: "+puedeVolar);
            Console.WriteLine("Super poder: "+SuperPoder);
            Console.WriteLine("Descripcion: "+Descripcion);
            Console.WriteLine("Nivel: "+Nivel);
        }
    }
}
