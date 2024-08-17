namespace Practicando_HASHING
{
    internal class CNodo
    {
        // Aqui colocamos el dato o datos que guarda el nodo
        private int llave;
        private string valor;


        // Esta variable de referencia es usada para apuntar al nodo siguiente
        private CNodo siguiente = null;


        // Propiedades que usaremos
        public int Llave { get { return llave; } set { llave = value; } }
        public string Valor { get { return valor; } set { valor = value; } }

        internal CNodo Siguiente { get { return siguiente; } set { siguiente = value; } }

        // Para suu facil impresion
        public override string ToString()
        {
            return string.Format("[{0}, {1}]", llave, valor);
        }
    }
}
