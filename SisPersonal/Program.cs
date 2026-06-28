using System;
using EspacioSisPersonal;
Console.WriteLine("Hello, World!");

Empleado[] empleados = new Empleado[3];

empleados[0] = new Empleado();
empleados[0].Nombre = "Juan";
empleados[0].Apellido = "Perez";
empleados[0].FechaNacimiento = new DateTime(1990, 5, 15);
empleados[0].FechaIngreso = new DateTime(2010, 3, 1);
empleados[0].EstadoCivil = 'c';
empleados[0].Cargos = Cargos.Investigador;
empleados[0].SueldoBasico = 3000;

empleados[1] = new Empleado();
empleados[1].Nombre = "Alberto";
empleados[1].Apellido = "Einstein";
empleados[1].FechaNacimiento = new DateTime(1980, 3, 1);
empleados[1].FechaIngreso = new DateTime(2003, 5, 2);
empleados[1].EstadoCivil = 's';
empleados[1].Cargos = Cargos.Ingeniero;
empleados[1].SueldoBasico = 600000;

empleados[2] = new Empleado();
empleados[2].Nombre = "Carlos";
empleados[2].Apellido = "Rodriguez";
empleados[2].FechaNacimiento = new DateTime(2003, 2, 15);
empleados[2].FechaIngreso = new DateTime(2020, 8, 29);
empleados[2].EstadoCivil = 's';
empleados[2].Cargos = Cargos.Auxiliar;
empleados[2].SueldoBasico = 100000;

double montoTotalSalarios = 0;

foreach (Empleado emp in empleados)
{
    montoTotalSalarios += emp.SalarioTotal();
}
Console.WriteLine($"{montoTotalSalarios}\n");

Empleado masProximoJubilarse = empleados[0];

for (int i = 0; i < empleados.Length; i++)
{
    if(masProximoJubilarse.AniosParaJubilarse() > empleados[i].AniosParaJubilarse())
    {
        masProximoJubilarse = empleados [i];
    }
}
Console.WriteLine($"{masProximoJubilarse.Nombre}\n");