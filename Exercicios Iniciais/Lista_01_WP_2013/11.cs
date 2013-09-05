using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_01_WP_2013
{   
    /// <summary>
    /// This method implements a Car.
    /// </summary>
    class Carro
    {
        //Instance variables.
        private double _consumo;
                
        public double consumo
        {
            get { return _consumo; }
            set { _consumo = value; }
        }

        private double _tanque;

        public double tanque
        {
            get { return _tanque; }
            set { _tanque = value; }
        }

        private int _maxTank;

        public int maxTank
        {
            get { return _maxTank; }
            set { _maxTank = value; }
        }      

        /// <summary>
        /// Constructor for the class Carro.
        /// </summary>
        /// <param name="l">It takes an amount of gas as liters.</param>
        public Carro(int l)
        {
            this.consumo = l;
        }

        /// <summary>
        /// This method implements the drive funcionality. It reduces the amount of gas in the tank, by calculating the
        /// consuption of gas based on the distance traveled.
        /// </summary>
        /// <param name="m">It takes the distance traveled in meters.</param>
        public void andar(double m)
        {
            this.tanque = this.tanque -  ( (m / 1000) / this.consumo);
        }

        /// <summary>
        /// This method implements the gas increase funcionality.
        /// </summary>
        /// <param name="l">It takes the amount of gas received.</param>
        public void adicionarGasolina(int l)
        {
            if (this.tanque == this.maxTank)
            {
                System.Console.WriteLine("Tanque cheio!");
                return;
            }
    
            for (int i = 0; i < l; i++)
            {
                if (this.tanque == this.maxTank)
                    return;
                else
                    this.tanque = this.tanque + i;
            }   
        }

        /// <summary>
        /// This method returns the amount of gas in the tank.
        /// </summary>
        /// <returns></returns>
        public double obterGasolina()
        {
            return this.tanque;
        }   
    }
}
