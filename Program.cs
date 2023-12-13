class Program
{
    static void Main()
    {
        IDibujante dibujanteColor = new DibujanteColor();
        colorRojo colorRojo = new colorRojo();
        IDibujante dibujanteBlancoNegro = new DibujanteBlancoYNegro();

        Forma circuloColorRojo = new Circulo(5,"colorRojo", dibujanteColor);
        Forma rectanguloBlancoNegro = new Rectangulo(4, 6, dibujanteBlancoNegro);

        circuloColorRojo.Dibujar();
        rectanguloBlancoNegro.Dibujar();
    }
}
//En el programa principal, se crean instancias de formas y estilistas de dibujo, y se asignan a las formas. Al llamar al método Dibujar() en cada forma, se delega la operación de dibujo al estilista de dibujo asociado.