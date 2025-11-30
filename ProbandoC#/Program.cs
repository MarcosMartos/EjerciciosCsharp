/*
 1. **“Hola mundo” y tipos de datos**
    - Crear un programa de consola que imprima “Hola, mundo!” por pantalla.
    - Declarar variables de distintos tipos (int, double, bool, string, char). Asignar valores y mostrarlos.
*/
using System;

class holaMundo
{
    static void Main(string[] args)
    {

        Cliente instancia = new Cliente();
        List<Cliente> clientes = instancia.LeerArchivo();
        List<Cliente> estado = instancia.calcularEstado(clientes);

        instancia.crearArchivo(estado);


    }


}








    //List<Cliente> clientes = new List<Cliente>();

    //for (int i = 0; i < 5; i++) {

    //    Cliente cliente = new Cliente();

    //    Console.WriteLine("Nombre: ");
    //    cliente.nombre = Console.ReadLine();
    //    Console.WriteLine("Deuda: ");
    //    cliente.deuda = int.Parse(Console.ReadLine());
    //    cliente.calcularEstado(cliente.deuda);

    //    clientes.Add(cliente);

    //}

    //foreach(Cliente cliente in clientes)
    //{
    //    Console.WriteLine(cliente.nombre+": "+cliente.estado);
    //}



    //List<Programador> programadores = new List<Programador>();


    //for (int i = 0; i < 3; i++)
    //{
    //    Programador programador = new Programador();

    //    Console.WriteLine("Ingrese su nombre: ");
    //    programador.nombre = Console.ReadLine();
    //    Console.WriteLine("Ingrese su salario: ");
    //    programador.salario = int.Parse(Console.ReadLine());


    //    programadores.Add(programador);
    //}

    //foreach (Programador programador in programadores)
    //{
    //    if(programador.salario > 650000)
    //    {
    //        Console.WriteLine(programador.nombre+" "+programador.salario);
    //    }
    //}


    //List<Persona> personas = new List<Persona>();

    //for(int i = 0;i < 3; i++)
    //{
    //    Persona persona = new Persona();

    //    Console.WriteLine("Ingrese su nombre: ");
    //    persona.nombre = Console.ReadLine();
    //    Console.WriteLine("Ingrese su edad: ");
    //    persona.edad = int.Parse(Console.ReadLine());
    //    Console.WriteLine("Ingrese su altura");
    //    persona.altura = double.Parse(Console.ReadLine());

    //    personas.Add(persona);

    //    persona.Presentarse();

    //}

    //foreach (Persona persona in personas)
    //{
    //    Console.WriteLine(persona.nombre + ", " + persona.edad +", "+ persona.altura);
    //}



    //var saludo = new holaMundo();
    //saludo.Saludar();
    //var resultado = new operacionesBasicas();
    //resultado.Operaciones(57, 71);
    //var numeros = new almacenarNumeros();
    //numeros.GuardarNumeros();
    //var instancia = new funcionesVarias();
    //instancia.sumar(4, 5);
    //instancia.restar(6, 3);
    //instancia.multiplicar(2, 3);
    //instancia.dividir(8, 4);
    //instancia.promedio(new List<int> { 1, 5, 8, 4, 6, 4 });


    //public void Saludar()
    //{
    //    Console.WriteLine("Hola Mundo!");

    //    string texto = "Soy un texto";
    //    Console.WriteLine(texto);
    //    int numero = 5;
    //    Console.WriteLine(numero);
    //    double conComa = 2.5;
    //    Console.WriteLine(conComa);
    //    bool booleano = true;
    //    Console.WriteLine(booleano);
    //    char letra = 'a';
    //    Console.WriteLine(letra);
    //}

/*
 2. **Operaciones básicas + condicionales**
    - Escribir un programa que pida al usuario dos números enteros, los sume, reste, multiplique y divida (si el segundo número no es cero), e imprima los resultados.
    - Agregar una condición: si el resultado de la suma es mayor que 100, mostrar un mensaje especial (“Gran suma”).
*/

//class operacionesBasicas
//{
//    public void Operaciones(int a, int b)
//    {
//            Console.WriteLine(a + b);
//        if (a + b > 100)
//        {
//            Console.WriteLine("Wow, gran suma!");
//        }
//            Console.WriteLine(a - b);
//            Console.WriteLine(a * b);
//        if(b != 0)
//        {
//            Console.WriteLine(a / b);
//        }



//    }
//}

/*
 - Hacer un programa que pida al usuario 10 números, los almacene en un array o lista, y luego calcule e imprima: el promedio, el máximo, el mínimo.
- Modificarlo para que si el usuario ingresa un número negativo, lo ignore y continúe pidiendo hasta tener 10 números positivos válidos.
 */

//class almacenarNumeros
//{
//    public void GuardarNumeros()
//    {
//        // Instanciamos un array
//        int[] numeros = new int[5];

//        //Inicializamos una variable contadora
//        int contador = 0;

//        // Usamos un ciclo while para pedir datos al usuario
//        while(contador < 5)
//        {
//            Console.WriteLine("Ingrese un número entero");
//            int numero = int.Parse(Console.ReadLine());
//            if(numero < 0)
//            {
//                Console.WriteLine("Solo se pueden ingresar números enteros, ingrese otro por favor.");
//                numero = int.Parse(Console.ReadLine());
//                numeros[contador] = numero;
//                contador++;
//            }
//            else
//            {
//                numeros[contador] = numero;
//                contador++;
//            }

//        }

//        // Iniciamos las variables de resultados
//        int suma = 0;
//        int maximo = numeros[0];
//        int minimo = numeros[0];

//        // Usamos foreach para recorrer la matriz y calcular los valores
//        foreach (int numero in numeros)
//        {
//            suma += numero;
//            if(numero > maximo)
//            {
//                maximo = numero;
//            }
//            if(numero < minimo)
//            {
//                minimo = numero;
//            }
//        }
//        double promedio = (double)suma / numeros.Length;

//        Console.WriteLine("Suma total: " + suma);
//        Console.WriteLine("Promedio: " + promedio);
//        Console.WriteLine("Número máximo: " + maximo);
//        Console.WriteLine("Número mínimo: " + minimo);

//        //foreach (int numero in numeros)
//        //{
//        //    Console.WriteLine(numero);
//        //}

//    }
//}

/*
 4. **Funciones / Métodos**
    - Crear funciones/métodos separados para: sumar, restar, multiplicar, dividir, calcular promedio de una lista de números. Luego usar esas funciones desde el `Main`.
 */

//class funcionesVarias
//{
//    public void sumar(int a, int b)
//    {
//        Console.WriteLine(a + b);
//    }

//    public void restar(int a, int b)
//    {
//        Console.WriteLine(a - b);
//    }

//    public void multiplicar (int a, int b)
//    {
//        Console.WriteLine(a * b);
//    }

//    public void dividir(int a, int b)
//    {
//        Console.WriteLine(a / b);
//    }

//    public void promedio(List<int> listaNumeros)
//    {
//        int resultado = 0;
//        foreach(int numero in listaNumeros)
//        {
//         resultado += numero;   
//        } 
//        int promedio = resultado / listaNumeros.Count;

//        Console.WriteLine("Tu promedio es:" + promedio);
//    }
//}