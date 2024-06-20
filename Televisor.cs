using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3A2
{
    internal class Televisor
    {
       private string marca;
       private string modelo;
       private int pulgadas;
       private bool estado;
       private int canal;

        // Constructor
        public Televisor(string marca, string modelo, int pulgadas)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.pulgadas = pulgadas;
            this.estado = false;
            this.canal = 1;
        }

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Pulgadas { get => pulgadas; set => pulgadas = value; }
        public bool Estado { get => estado; set => estado = value; }
        public int Canal { get => canal; set => canal = value; }

        public override string ToString()
        {
            return "Marca:" + marca + " Modelo:" + modelo ;
        }



        // Devuelve un valor entero con el número de canal que esta visualizándose en ese momento.
        public int obtenerCanalActual()
        {
            return this.canal;
        }

        // Cambia el canal al número de canal que reciba por parámetro
        public bool cambiarCanal(int nuevoCanal)
        {
            if (estado && canal >=1 && canal <= 150)
            {

                canal = nuevoCanal;
                Console.WriteLine($"Cambiando al canal {canal}.");
                return true;
            }
            else
            {
                Console.WriteLine("No se puede cambiar de canal");
                return false;
            }
        }
        
        // Informa con un verdadero si el televisor está encendido o falso en caso contrario.
        public bool verPrendido()
        {
            if (estado)
            {
                Console.WriteLine($"El televisor esta prendido");
                return true;

            }
            else
            {
                Console.WriteLine("El televisor esta apagodo");
                return false;   
            }
        }
      
        public void cambiarEstado()
        {
            if (estado)
            {
                this.estado = false;
                Console.WriteLine($"Televisor Apagado: {estado}");
               
            }
            else
            {
                this.estado = true;
                Console.WriteLine($"Televisor Encendido: {estado}");
            }
        }
    }
}
