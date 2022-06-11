namespace Eppical.Solid.S
{

    #region Good
    public class Item : IItem
    {
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }

        public Item(Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }      

        public double Subtotal()
        {
            return Cantidad * Producto.Precio;
        }
    }

    #endregion

    #region Bad

    //public class Item
    //{
    //    public Producto Producto { get; set; }
    //    public int Cantidad { get; set; }

    //    public Item(Producto producto, int cantidad)
    //    {
    //        Producto = producto;
    //        Cantidad = cantidad;
    //    }

    //}

    #endregion
}