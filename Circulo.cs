using System.Drawing;

public class Circulo : Forma
{
    private int radio;
    
    public Circulo(int radio, string color, IDibujante dibujante) : base(dibujante)
    {
        this.radio = radio;
    }

    public override void Dibujar()
    {
        dibujante.DibujarCirculo(radio);
    }
}
//Las clases concretas Circulo y Rectangulo heredan de la clase abstracta Forma. En su implementación del método Dibujar(), delegan la responsabilidad de dibujar a la interfaz IDibujante.