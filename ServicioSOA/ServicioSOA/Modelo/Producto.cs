namespace ServicioSOA.Modelo
{
    public class Producto
    {
        //atributos
        public int id {get;set;}
        public string nombre {get;set;}
        public double pvp {get;set;}
        public int cantidad {get;set;}

        //constructor
        public Producto(int id, string nombre, double pvp, int cantidad)
        {
            this.id = id;
            this.nombre = nombre;
            this.pvp = pvp;
            this.cantidad = cantidad;
        }

    }
}
