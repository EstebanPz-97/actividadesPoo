// See https://aka.ms/new-console-template for more information
using Actividad6.Clubes;
using Actividad6.Entities;

Console.WriteLine("Hello, World!");

Entity jugador = new Jugadores("123","delantero");

Entity entrenador = new Entrenadores("", "fisioterapia");

Equipo<Entrenadores> equipo = new Equipo<Entrenadores>();

equipo.Inscribir((Entrenadores)(entrenador));

Console.WriteLine(equipo);

