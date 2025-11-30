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

/*
 2. **Herencia / Polimorfismo**
    - Crear una clase base `Empleado` con propiedades `Nombre`, `Salario`. Luego una clase derivada
     `Programador` que herede de `Empleado` y agregue una propiedad extra como `LenguajesConocidos` 
     (una lista o array de strings). Hacer instancias, asignar valores y mostrar información.
 */

//class Empleado
//{
//    public string nombre { get; set;}
//    public int salario { get; set; }

//}

//class Programador : Empleado
//{
//    public List<string> lenguajesConocidos {  get; set; } = new List<string>();
//}

/*
 3. **Manejo de colecciones más complejas**
    - Crear una lista de `Programador`, permitir añadir nuevos programadores por consola. 
    Luego mostrar todos los programadores cuyo salario sea mayor a cierto umbral.
 */
//class Empleado
//{
//    public string nombre { get; set; }
//    public int salario { get; set; }

//}

//class Programador : Empleado
//{
//    public List<string> lenguajesConocidos { get; set; } = new List<string>();

//}

/*
 4. **Simulación de lógica / mini-negocio**
    - Simular un sistema sencillo de “créditos” (inspirado en lo que vos hiciste en Python):
        - Clase `Cliente` con propiedades como `Nombre`, `DeudaActual`, `Estado` (string).
        - lógica para calcular si un cliente es “Excelente”, “Bueno”, “Remolón”, “Malo” según reglas simplificadas (por ejemplo: sin deuda → “Excelente”, deuda > 0 y < X → “Bueno”, deuda > X → “Malo”).
        - Pedir datos por consola, permitir crear varios clientes, mostrar listado con su estado.
 */

//class Cliente
//{
//    public string nombre { get; set; }
//    public int deuda { get; set; }
//    public string estado { get; set; }


//    public void calcularEstado(int deuda)
//    {
//        if (deuda <= 0)
//        {
//            estado = "Excelente";
//        }
//        else if (deuda >= 1 && deuda < 50000)
//        {
//            estado = "Bueno";
//        }
//        else if (deuda >= 50000 && deuda < 100000)
//        {
//            estado = "Remolon";
//        }
//        else
//        {
//            estado = "Malo";
//        }

//    }
//}