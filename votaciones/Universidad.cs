
namespace votaciones
{
    public class Universidad
    {
        public Universidad(string nombre, int aceptan, int rechazan, int blancos, int nulos)
        {
            Nombre = nombre;
            Aceptan = aceptan;
            Rechazan = rechazan;
            Blancos = blancos;
            Nulos = nulos;
        }

        public string Nombre { get; set; }
        public int Aceptan { get; set; }
        public int Rechazan { get; set; }
        public int Blancos { get; set; }
        public int Nulos { get; set; }
        public string Ganador { get; set; }

        public void TomarDesicion (){
            if (Aceptan > Rechazan && Aceptan > Blancos && Aceptan > Nulos){
                Ganador = "Aceptan";
            }
            else if (Rechazan > Aceptan && Rechazan > Blancos && Rechazan > Nulos){
                Ganador = "Rechazan";
            }
            else if (Rechazan == Aceptan){
                Ganador = "Empate";
            } else {
                Ganador = "";
            }
        }
        
    }

    

    
}