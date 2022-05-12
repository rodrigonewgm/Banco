using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Cuenta
    {
        private int numero;
        private int tipoCuenta;
        private double saldo;
        //private Cliente cliente;

        public int Numero { get => numero; set => numero = value; }
        public int TipoCuenta1 { get => tipoCuenta; set => tipoCuenta = value; }
        public double Saldo { get => saldo; set => saldo = value; }


        public Cuenta()
        {
            Numero = 0;
            TipoCuenta1 = 0;
            Saldo = 0;
            //cliente = null;
        }

        public Cuenta(int nroCuenta, int tipoCuenta,double saldo)
        {
            this.Numero = nroCuenta;
            this.TipoCuenta1 = tipoCuenta;
            this.Saldo = saldo;
            //this.cliente = cliente;
        }

        //public Cliente pCliente
        //{
        //    get { return cliente; }
        //    set { cliente = value; }
        //}

        public string TipoCuenta()
        {
            if (Numero == 1)
            {
                return "caja de ahorro";
            }
            else return "cuenta corriente";
        }

        public override string ToString()
        {
            return  "|nro cuenta: " + numero + "tipo de cuenta: " + tipoCuenta + "|saldo: " + saldo;
        }
    }
}
