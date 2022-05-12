using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Cliente : Persona 
    {

        private int codigo;
        private double limite;
        private Cuenta cuenta;  //el cliente tiene una sola cuenta 

        private int Codigo { get => codigo; set => codigo = value; }
        private double Limite { get => limite; set => limite = value; }
        internal Cuenta Cuenta { get => cuenta; set => cuenta = value; }


        public Cliente() : base()
        {
            codigo = 0;
            limite = 0;
            cuenta = null;
          
        }

        public Cliente(string nombre, int dni, int sexo, int codigo, double limite, int numero, int tipoCuenta, double
            saldo) 
            :base(nombre, dni, sexo)
        {
            this.codigo = codigo;
            this.limite = limite;
            this.cuenta = new Cuenta( numero, tipoCuenta,saldo); //tiene una sola cuenta 
        }


        public override string ToString()
        {
     
            return $"Nombre: {base.pNombre} Dni: {base.pDni} Sexo: {base.pSexo} Codigo: {codigo} Limite: {limite} Cuenta: {cuenta.ToString()}";
        }

        

    }
}
