using System;

/*
 1. **Clases básicas**
    - Crear una clase `Persona` con propiedades `Nombre`, `Edad`, `Altura`. Instanciar varios objetos `Persona`, pedir datos por consola, almacenarlos en una lista y luego imprimir un listado con sus datos.
    - Agregar un método en la clase `Persona`, por ejemplo `Presentarse()` que imprima un saludo incluyendo su nombre.
 */
class Persona
{
    public string nombre { get; set; }
    public int edad {  get; set; }
    public double altura { get; set; }

    public void Presentarse()
    {
        Console.WriteLine($"Hola, mucho gusto soy {nombre}");
    }

}