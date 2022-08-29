using Actividad3;
using Actividad3.Computadores;
using Actividad3.Perifericos;


//crear perifericos
IPeriferico periferico = new Teclado();
IPeriferico periferico1 = new TagetExternal();


Computador computadora = new Computador(periferico, periferico1);