
namespace EspacioSisPersonal;
public enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }
public class Empleado
{
    private string nombre;

    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }
    private string apellido;
    public string Apellido
    {
        get => apellido;
        set => apellido = value;
    }
    private DateTime fechaNacimiento;
    public DateTime FechaNacimiento
    {
        get => fechaNacimiento;
        set => fechaNacimiento = value;
    }
    private char estadoCivil;
    public char EstadoCivil
    {
        get => estadoCivil;
        set =>estadoCivil = value;
    }
    private DateTime fechaIngreso;
    public DateTime FechaIngreso
    {
        get => fechaIngreso;
        set => fechaIngreso = value;
    }
    private double sueldoBasico;
    public double SueldoBasico
    {
        get => sueldoBasico;
        set => sueldoBasico = value;
    }

    private Cargos cargo;
    public Cargos Cargos
    {
        get => cargo;
        set => cargo = value;
    }

    //Defino los métodos que me piden en el apartado 2)
    public int Antiguedad()
    {   
        DateTime hoy = DateTime.Now;
        return hoy.Year - fechaIngreso.Year;
    }
    
    public int Edad()
    {
        int esteAnio = DateTime.Now.Year;
        int esteMes = DateTime.Now.Month;
        int esteDia = DateTime.Now.Day;
        if(fechaNacimiento.Day <= esteDia && fechaNacimiento.Month <= esteMes)
        {
            return  esteAnio - fechaNacimiento.Year;
        }
        else
        {
            return esteAnio - fechaNacimiento.Year -1;
        }
    }

    public int AniosParaJubilarse()
    {
        return 65 - Edad(); 
    }

    public double SalarioTotal()
    {
        double adicional = 0;
        if(Antiguedad() <= 20)
        {
            adicional += sueldoBasico * Antiguedad() / 100;
        }
        else
        {
            adicional += sueldoBasico * 0.25;
        }

        if(cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
        {
            adicional *= 1.5;
        }
        if(estadoCivil == 'c')
        {
            adicional += 150000;
        }
        return sueldoBasico + adicional;
    }
}