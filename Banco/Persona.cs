using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Persona
    {
        private string nombre;
        private int dni;
        private int sexo;

        public Persona()
        {
            nombre = "";
            dni = 0;
            sexo = 0;
        }

        public Persona(string nombre, int dni, int sexo)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.sexo = sexo;
        }

        public string pNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int pDni
        {
            get { return dni; }
            set { dni = value; }
        }
        public int pSexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string Sexo()
        {
            if (sexo == 1)
            {
                return "femenino";

            }
            else
            {
                return "masculino";
            }
            
        }

        public override string ToString()
        {
            return "nombre: " + pNombre + "|dni: " + pDni + "|sexo: " + Sexo();
        }
    }
}
