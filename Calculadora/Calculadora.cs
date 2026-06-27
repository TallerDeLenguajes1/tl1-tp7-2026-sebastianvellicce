using Microsoft.VisualBasic;

namespace EspacioCalculadora;

public class Calculadora
{
    private double dato;        //Privado ya que solo se puede modificar al dato mediante los metodos publicos.

    public Calculadora()    //Constructor.
    {
        dato = 0;
    }

    //DEFINO TODOS LOS METODOS:
    public void Sumar(double termino)
    {
        dato += termino;
    }
    public void Restar(double termino)
    {
        dato -= termino;
    }
    public void Multiplicar(double termino)
    {
        dato *= termino;
    }
    public void Dividir(double termino)
    {
        if (termino != 0)
        {
            dato /= termino;
        }
    }
    public void Limpiar()
    {
        dato = 0;
    }

    //Como todos los metodos son void, creo una propiedad para poder ver los resultados:

    public double Resultado
    {
        get => dato;
    }

}