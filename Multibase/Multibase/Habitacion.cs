using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multibase
{
    class Habitacion
    {
        int Numhabit;
        int tipo;
        bool edo;

        Habitacion()
        {

        }

        public void setEdo(bool edo)
        {
            this.edo = edo;
        }

        public void setNumhabit(int Numhabit)
        {
            this.Numhabit = Numhabit;
        }

        public void setTipo(int tipo)
        {
            this.tipo = tipo;
        }

        public int getNumhabit()
        {
            return Numhabit;
        }

        public int getTipo()
        {
            return tipo;
        }

        public bool getEdo()
        {
            return edo;
        }
    }
}
