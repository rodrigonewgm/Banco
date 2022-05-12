using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Banco
    {
        private Cliente[] clientes;

        private Cliente[] Clientes { get => clientes; set => clientes = value; }

        public Banco()
        {
            clientes = new Cliente[5];
        }


        public void AgregarUnCliente(Cliente cliente)
        {
            for (int i = 0; i < clientes.Length; i++)
            {
                if (clientes[i] != null)
                {
                    clientes[i] = cliente;
                    break;
                }
            }
        }


        public string MostrarClientes()
        {
            string salida = "";
            for (int i = 0; i < clientes.Length; i++)
            {
                if (clientes != null)
                {
                    salida += Clientes[i].ToString();
                    salida += "\n";
                }
            }
            return salida;
        }



        public int CantidadCajasDeAhorro()
        {
            int contCajasDeAhorro = 0;
            for (int i = 0; i < clientes.Length; i++)
            {
                if (clientes[i] != null && clientes[i].Cuenta.Numero == 1)
                {
                    contCajasDeAhorro++;
                }
            }
            return contCajasDeAhorro;
        }

        public int CantidadCuentaCorriente()
        {
            int contCuentaCorriente = 0;
            for (int i = 0; i < clientes.Length; i++)
            {
                if (clientes[i] != null && clientes[i].Cuenta.Numero == 2)
                {
                    contCuentaCorriente++;
                }
            }
            return contCuentaCorriente;
        }

        public double PorcFemenino()
        {
            double porcFemenino = 0;
            double acumFemenino = 0;
            int cantidadClientes = 0;
            for (int i = 0; i < clientes.Length; i++)
            {
                if (clientes[i] != null)
                {
                    cantidadClientes++;
                    if (clientes[i].pSexo == 1)
                    {
                        acumFemenino++;
                    }
                }

            }
            porcFemenino = acumFemenino * 100 / cantidadClientes;
            return porcFemenino;
            // promFemenino = acumFemenino / cantidadClientes
        }

        public double PromedioSaldoCajaDeAhorro()
        {
            double promedioSaldo = 0;
            double acuCA = 0;
            double contCA = 0;
            for (int i = 0; i < clientes.Length; i++)
            {
                if (clientes[i] != null && clientes[i].Cuenta.TipoCuenta().Equals("caja de ahorro"))
                {
                    acuCA = acuCA + clientes[i].Cuenta.Saldo;
                    contCA++;
                }
            }
            promedioSaldo = acuCA / contCA;
            return promedioSaldo;
        }


        public double PromedioSaldoCuentaCorriente()
        {
            double promedioSaldo = 0;
            double acuCC = 0;
            double contCC = 0;
            for (int i = 0; i < clientes.Length; i++)
            {
                if (clientes[i] != null && clientes[i].Cuenta.TipoCuenta().Equals("cuenta corriente"))
                {
                    acuCC = acuCC + clientes[i].Cuenta.Saldo;
                    contCC++;
                }
            }
            promedioSaldo = acuCC / contCC;
            return promedioSaldo;
        }

        public double SaldoGeneral()
        {
            double saldoGeneral = 0;
            double acumGeneral = 0;
            double contGeneral = 0;
            for (int i = 0; i < clientes.Length; i++)
            {
                if (clientes[i] != null)
                {
                    acumGeneral = acumGeneral + clientes[i].Cuenta.Saldo;
                    contGeneral++;
                }

            }
            saldoGeneral = acumGeneral / contGeneral;
            return saldoGeneral;
        }

        //public string ClienteMayor()
        //{
        //    Cliente elMayorLimite = clientes[0];
        //    for (int i = 1; i < clientes.Length; i++)
        //    {
        //        if (clientes[i] != null && clientes[i])
        //        {

        //        }
        //    }


        //}



        //        Jugador elMejorJugador = jugadores[0];
        //            for (int i = 1; i<jugadores.Length; i++)
        //            {
        //                if (jugadores[i] != null && jugadores[i].pPosicion.Equals("Delantero"))
        //                {
        //                    if (elMejorJugador.Valoracion() < jugadores[i].Valoracion())
        //                    {
        //                        elMejorJugador = jugadores[i];
        //                    }
        //}
        //            }
        //            return elMejorJugador.Valoracion();
    }
}