
namespace Practicando_HASHING
{
    internal class CListaLigada
    {
        // Es el ancla o cabeza de la lista
        private CNodo ancla;

        // Esta variedad de referencia apoya en ciertas operaciones de la lsita
        private CNodo trabajo;

        // Esta variable de referencia apoya en ciertas operaciones de la lsita
        private CNodo trabajo2;

        public CListaLigada()
        {
            // Instanciamos el ancla
            ancla = new CNodo();

            // Como es una lista vacia su siguiente es null
            ancla.Siguiente = null;
        }

        // Recorre toda la lista
        public void Tranversa()
        {
            // Trabajo al inicio
            trabajo = ancla;

            // Recorremos hasta encotnrar el final

            while (trabajo.Siguiente != null)
            {
                // Avanzamos trabajo
                trabajo = trabajo.Siguiente;

                // Obtenemos el dato y lo mostramos
                // int d trabajo.Dato;

                Console.Write("{0}->", trabajo);

            }
        }
        //Bajamos la llinea
        //Console.WriteLine();

        // Adicona un nuevo elemento
        // La adicion siempte va al final
        public void Adicionar(int pLlave, string pValor)
        {
            // Trabajo al inicio
            trabajo = ancla;

            // Recorremos hasta encontrar el final

            while (trabajo.Siguiente != null)
            {
                // Avanzamos trabajo
                trabajo = trabajo.Siguiente;
            }

            // Creamos el nuevo nodo
            CNodo temp = new CNodo();

            // Insertamos el dato
            temp.Llave = pLlave;
            temp.Valor = pValor;

            // Finalizamos correctamente
            temp.Siguiente = null;

            // Ligamos el ultimo nodo encontrado con el recien creado
            trabajo.Siguiente = temp;
        }

        //Vacia la lista
        public void Vaciar()
        {
            ancla.Siguiente = null;

            // En lenguajes no administrados hay que libera la memoria adecuadamente
            // Aqui aprovechamos el recolector de basura
        }

        // Indica si la lista esta vacia o no
        public bool EstaVacio()
        {
            if (ancla.Siguiente == null)
                return true;
            else
                return false;
        }

        // Regresa el nodo con la primera ocurrencia del dato
        public CNodo Buscar(int pLlave)
        {
            if (EstaVacio() == true)
                return null;

            trabajo2 = ancla;


            // Recorremos para ver si lo encontramos
            while (trabajo2.Siguiente != null)
            {
                trabajo2 = trabajo2.Siguiente;

                // Al encontrar lo regresamos
                if (trabajo2.Llave == pLlave)
                    return trabajo2;
            }

            // No se encontro, regresamos un null
            return null;
        }

        //Buscar el indice donde se encuentra la primera ocurrencia del dato
        public int BuscarIndice(int pLlave)
        {
            int n = -1;

            trabajo = ancla;

            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
                n++;

                if (trabajo.Llave == pLlave)
                    return n;
            }

            return -1;
        }

        // Encuentra a nodo anterior
        // Si esta en el primer nodo se regresa el ancla
        // Si el dato no existe se regresa el utlimo nodo
        public CNodo BuscarAnterior(int pLlave)
        {

            trabajo2 = ancla;

            while (trabajo2.Siguiente != null && trabajo2.Siguiente.Llave != pLlave)
                trabajo2 = trabajo2.Siguiente;

            return trabajo2;

        }

        // Borra la primera ocurrencia del dato
        public void Borrar(int pLlave)
        {
            // Verificamos que se tengan datos
            if (EstaVacio() == true)
                return;

            // Buscamos los nodos con los que trabajaremos
            CNodo anterior = BuscarAnterior(pLlave);

            CNodo encontrado = Buscar(pLlave);

            // Si no hay nodo a borrar, salimos
            if (encontrado == null)
                return;


            // Brincamos el nodo
            anterior.Siguiente = encontrado.Siguiente;

            //Quitamos el actual de la lista
            encontrado.Siguiente = null;
        }

        // Inserta el dato pValor despues la primera ocurrencia del dato pasadoo a pDonde

        public void Insertar(int pDonde, int pLlave, string pValor)
        {

            // Encontramos la posicion donde vamos a insertar
            trabajo = Buscar(pDonde);

            // Verificamos que exista donde vamos a insertar
            if (trabajo == null)
                return;

            // Creamos el nodo temporal a insertar

            CNodo temp = new CNodo();
            temp.Llave = pLlave;
            temp.Valor = pValor;

            // Conectamos el teporal a la lista
            temp.Siguiente = temp;
        }

        public void InsertarInicio(int pLlave, string pValor)
        {


            // Creamos el nodo temporal
            CNodo temp = new CNodo();
            temp.Llave = pLlave;
            temp.Valor = pValor;

            // Conectamos el ancla al temporal
            ancla.Siguiente = ancla.Siguiente;

            //Conectamos el ancla al temporal
            ancla.Siguiente = temp;
        }

        // Obtenemos la referencia al nodo dado el indice
        public CNodo ObtenPorIndice(int pIndice)
        {
            CNodo trabajo2 = null;
            int indice = -1;

            trabajo = ancla;

            while (trabajo.Siguiente != null)
            {

                trabajo = trabajo.Siguiente;
                indice++;

                if (indice == pIndice)
                    trabajo2 = trabajo;
            }

            return trabajo2;
        }


        // Creamos un Indexer
        public int this[int pIndice]
        {
            get
            {

                // Esto puede crear una excepcion si trabajo es igual null
                // Colocar codigo de seguridad o usar int?
                trabajo = ObtenPorIndice(pIndice);

                return trabajo.Llave;

            }

            set
            {
                trabajo = ObtenPorIndice(pIndice);
                if (trabajo != null)
                {
                    trabajo.Llave = value;
                }
            }
        }

    }

}
