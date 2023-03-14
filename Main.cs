using System;
namespace Central
{
    class Centralita
    {
        private int numLlamadas = 0;
        private double facturacionTotal = 0.0;

        public void registrarLlamada(Llamada llamada)
        {
            Console.WriteLine(llamada.ToString());
            this.numLlamadas++;
            this.facturacionTotal += llamada.costo;
        }

        public void informe()
        {
            Console.WriteLine("Total de Llamadas: " + this.numLlamadas);
            Console.WriteLine("Total del Costo: " + this.facturacionTotal + " euros.");
        }
    }
}
