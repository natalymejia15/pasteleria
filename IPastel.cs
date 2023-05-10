namespace pasteleria;

public interface Pastel
{
    string Nombre { get; set; }
    string Tamano { get; set; }
    List<Ingrediente> Ingredientes { get; }
    void AgregarIngrediente(Ingrediente ingrediente);
    int CantidadIngredientes();
    string ListaIngredientes();
    decimal CalcularCosto();
}

 public class Ingrediente 
{
    public string Nombre { get; }
    public int Cantidad { get; }
    public decimal Precio { get; }

    public Ingrediente(string nombre, int cantidad, decimal precio)
    {
        Nombre = nombre;
        Cantidad = cantidad;
        Precio = precio;
    }
}
