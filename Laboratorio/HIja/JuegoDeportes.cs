using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio.HIja
{
    internal class JuegoDeportes : VideoJuego
    {
        private string reglas1;
        private string tiempo1;
        private string equipos1;

        public JuegoDeportes (string Reglas, string tiempo, string equipos)
            {
            reglas = Reglas;      
            this.tiempo = tiempo;
            this.equipos = equipos;
            }
        public string reglas
        {
            get { return reglas; }
            set { reglas = value; }
        }
        public string tiempo
        {
            get { return tiempo; }
            set
            {
                if (value >=60)
                {
                    tiempo = value

                }
                else 
                {
                    Console.WriteLine ("El tiempo del juego no puede ser mayor a 60 mim.")
                }
            }
        }
        public string equipos
        {
            get { return equipos; }
            set { equipos = value; }
        }
        public void Mostrarinformacion()
        {
            Console.WriteLine($"reglas:{reglas},equipos:{}")
        }
    }
    
    
}
