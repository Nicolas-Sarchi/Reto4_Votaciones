// La CONFECH, en su afán de agilizar el proceso de recuento de las votaciones, le ha encargado el
// desarrollo de un programa de registro de votación por universidades.
// Primero, el programa debe solicitar al usuario ingresar la cantidad de universidades que participan
// en el proceso.
// Luego, para cada una de las universidades, el usuario debe ingresar el nombre de la universidad y
// los votos de sus alumnos, que pueden ser: aceptar (A), rechazar (R), nulo (N) o blanco (B). El término
// de la votación se indica ingresando una X, tras lo cual se debe mostrar los totales de votos de la
// universidad, con el formato que se muestra en el ejemplo.
// Finalmente, el programa debe mostrar el resultado de la votación, indicando la cantidad de
// universidades que aceptan, que rechazan y en las que hubo empate entre estas dos opciones.



using votaciones;

Console.WriteLine("Ingrese el número de universidades que participan en el proceso: ");
int cantidad= Convert.ToInt32(Console.ReadLine());

List<Universidad> universidades = new ();

for(int i = 1; i <= cantidad; i++)
{
    Console.WriteLine("Ingrese el nombre de la universidad: ");
        string nombre = Console.ReadLine();
        
        int acepta = 0;
        int rechaza = 0;
        int blanco = 0;
        int nulo= 0;
        string voto = "";
    do
    {
        Console.WriteLine("Ingrese su voto");
         voto = Console.ReadLine();

        if (voto.ToLower().Equals("a"))
        {
            acepta ++;
        }
        else if (voto.ToLower().Equals("r"))
        {
            rechaza ++;

        }else if (voto.ToLower().Equals("b"))
        {
            blanco ++;

        }else if (voto.ToLower().Equals("n"))
        {
            nulo ++;
        }
        else if (voto.ToLower().Equals("x"))
        {
            break;
        }
        else {
            Console.Write("Ingrese una opción válida");
            break;
        }

        

    } while (voto.ToLower() != "x");
    Universidad universidad = new (nombre,acepta,rechaza,blanco,nulo);
    universidad.TomarDesicion();
    Console.WriteLine($"{universidad.Nombre}: Aceptan {universidad.Aceptan}, Rechazan {universidad.Rechazan}, {universidad.Blancos} blancos, {universidad.Nulos} nulos");
    universidades.Add(universidad);
}
int aceptan = 0;
int rechazan = 0;
int empatan = 0;

foreach (var i in universidades){
    if (i.Ganador.ToLower().Equals("aceptan"))
    {
        aceptan +=1;
    }
    else if (i.Ganador.ToLower().Equals("rechazan"))
    {
        rechazan +=1;
    }
    else if (i.Ganador.ToLower().Equals("empate"))
    {
        empatan +=1;
    }
}

Console.WriteLine($"Universidades que aceptan:{aceptan}");
Console.WriteLine($"Universidades que rechazan:{rechazan}");
Console.WriteLine($"Universidades con empate:{empatan}");
