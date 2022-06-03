namespace ServicioSOA.Modelo
{
    public class Producto
    {
        //atributos
        public int id {get;set;}
        public string nombre {get;set;}
        public decimal pvp {get;set;}
        public int cantidad {get;set;}

        //constructor
        public Producto(int id, string nombre, decimal pvp, int cantidad)
        {
            this.id = id;
            this.nombre = nombre;
            this.pvp = pvp;
            this.cantidad = cantidad;
        }

    }
}
