namespace pasteleria;
class Programa
{
    static void Main(string[] args)
    {
        Pastel pastel = new Pastel1();
        pastel.Nombre = "Pastel de chocolate";
        pastel.Tamano = "Mediano";
        pastel.AgregarIngrediente(new Ingrediente("Azucar x libra", 1, 2));
        pastel.AgregarIngrediente(new Ingrediente("Harina x libra", 2, 1));
        pastel.AgregarIngrediente(new Ingrediente("Huevos x unidad", 6, 1));
        pastel.AgregarIngrediente(new Ingrediente("Polvo de cacao x unidad", 1, 2));
        pastel.AgregarIngrediente(new Ingrediente("Agua x vaso ", 3, 1));
        Console.WriteLine($"\nNombre del pastel: {pastel.Nombre}");
        Console.WriteLine($"Tamaño del pastel: {pastel.Tamano}");
        Console.WriteLine($"Ingredientes:\n{pastel.ListaIngredientes()}");
        Console.WriteLine($"Cantidad de ingredientes: {pastel.CantidadIngredientes()}");
        Console.WriteLine($"Valor del pastel: {pastel.CalcularCosto()}$\n");
    }
}