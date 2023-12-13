public class DibujanteColor : IDibujante
{
    public void DibujarCirculo(int radio)
    {
        Console.WriteLine($"Dibujando círculo de color con radio {radio}");
    }

    public void DibujarRectangulo(int ancho, int alto)
    {
        Console.WriteLine($"Dibujando rectángulo de color con ancho {ancho} y alto {alto}");
    }
}
//Estas clases implementan la interfaz IDibujante y proporcionan las implementaciones específicas de cómo dibujar círculos y rectángulos en diferentes estilos.