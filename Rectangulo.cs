public class Rectangulo : Forma
{
    private int ancho;
    private int alto;

    public Rectangulo(int ancho, int alto, IDibujante dibujante) : base(dibujante)
    {
        this.ancho = ancho;
        this.alto = alto;
    }

    public override void Dibujar()
    {
        dibujante.DibujarRectangulo(ancho, alto);
    }
}
////Las clases concretas Circulo y Rectangulo heredan de la clase abstracta Forma. En su implementación del método Dibujar(), delegan la responsabilidad de dibujar a la interfaz IDibujante.