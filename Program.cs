
using pasteleria;
using System.Collections.Generic;

class Pastel1 : Pastel
{
    public string Nombre { get; set; }
    public string Tamano { get; set; }
    private List<Ingrediente> _ingredientes = new List<Ingrediente>();
    public List<Ingrediente> Ingredientes { get { return _ingredientes; } }

    public void AgregarIngrediente(Ingrediente ingrediente)
    {
        _ingredientes.Add(ingrediente);
    }

    public int CantidadIngredientes()
    {
        return _ingredientes.Count;
    }

    public string ListaIngredientes()
    {
        string result = "";
        foreach (Ingrediente ingrediente in _ingredientes)
        {
            result += $"{ingrediente.Nombre} - {ingrediente.Cantidad} - {ingrediente.Precio}$\n";
        }
        return result;
    }

    public decimal CalcularCosto()
    {
        decimal cost = 0;
        foreach (Ingrediente ingrediente in _ingredientes)
        {
            cost += ingrediente.Cantidad * ingrediente.Precio;
        }
        return cost;
    }
}
