    using System;
public interface IDibujante
{
    void DibujarCirculo(int radio);
    void DibujarRectangulo(int ancho, int alto);
    
}
//La interfaz IDibujante define la implementación del dibujo, pero no se preocupa por cómo se aplica. Es el puente que permite que las formas se dibujen de diferentes maneras.