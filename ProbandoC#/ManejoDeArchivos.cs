using System.IO;


class Cliente
{
    public string nombre { get; set; }
    public int deuda { get; set; }
    public string estado { get; set; }



    private string rutaArchivo = "C:\\Users\\Marcos\\source\\repos\\ProbandoC#\\ProbandoC#\\Data\\pruebaDB.csv";
    private string rutaGuardar = "C:\\Users\\Marcos\\source\\repos\\ProbandoC#\\ProbandoC#\\Data\\conEstado.csv";


    // Crear lógica para convertir CSV en Objetos
    // 1. Leer archivo
    // 2. Calcular Estado 
    // 3. Cargar archivo 


    // Leer archivo
    public List<Cliente> LeerArchivo()
    {
        List<Cliente> clientes = new List<Cliente>();

        // Leer el archivo

        string[] archivo = File.ReadAllLines(rutaArchivo);

        // Recorrer los datos con un for

        for(int i = 1; i < archivo.Length; i++)
        {
            string[] datos = archivo[i].Split(",");

            var cliente = new Cliente
            {
                nombre = datos[0],
                deuda = int.Parse(datos[1]),
            };

            clientes.Add(cliente);
 
        }
            return clientes;

        // Retorna una matriz con objetos tipo Cliente
    }

    // Calcular Estado

    public List<Cliente> calcularEstado(List<Cliente> clientes)
    {

        for (int i = 0; i < clientes.Count; i++)
        {

            if (clientes[i].deuda <= 0) {
                clientes[i].estado = "Bueno";
            }
            else if (clientes[i].deuda > 0)
            {
                clientes[i].estado = "Deudor";
            }
        }

        return clientes;

    }


    public void crearArchivo(List<Cliente> clientes)
    {

        List<string> lineas = new List<string>();

        // Opcional: Encabezado del CSV
        lineas.Add("Nombre,Deuda,Estado");

        for (int i = 0; i < clientes.Count; i++)
        {
            string linea = $"{clientes[i].nombre},{clientes[i].deuda},{clientes[i].estado}";
            lineas.Add(linea);
        }

        File.WriteAllLines(rutaGuardar, lineas);
        
        Console.WriteLine("Archivo creado correctamente en: " + rutaGuardar);

    }


    //public override string ToString()
    //{
    //    return $"{nombre} - {deuda} - {estado}";
    //}


}

