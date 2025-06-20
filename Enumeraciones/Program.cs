using System;
//1.3

enum DiasSemana
{
    Lunes,
    Martes,
    Miercoles,
    Jueves,
    Viernes,
    Sabado,
    Domingo
}

class Program
{
    static void Main(string[] args)
    {
        DiasSemana hoy = DiasSemana.Miercoles;
       Console.WriteLine("Hoy Es: " + hoy);

        int ValorNumerico = (int)hoy;
        Console.WriteLine("Hoy Es: " + hoy + "Es: " + ValorNumerico);

        DiasSemana otroDia = (DiasSemana)4;
        Console.WriteLine("El Dia 4 Es: " + otroDia);

        Console.ReadKey();
    }
}
