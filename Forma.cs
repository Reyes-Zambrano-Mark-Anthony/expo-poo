    public abstract class Forma
{
    protected IDibujante dibujante;

    public Forma(IDibujante dibujante)
    {
        this.dibujante = dibujante;
    }

    public abstract void Dibujar();
}
//La clase abstracta Forma representa la abstracción. Contiene un miembro IDibujante que actúa como el puente entre la abstracción y la implementación.