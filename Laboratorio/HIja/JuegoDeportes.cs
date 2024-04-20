using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio.HIja
{
    internal class JuegoDeportes : VideoJuego
    {
        private string equipos;
        private string tiempo;
        private string reglas;

        public JuegoDeportes (string reglas, string tiempo, string equipos)
            {
            this.reglas = reglas;      
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

    }
    
    
}
