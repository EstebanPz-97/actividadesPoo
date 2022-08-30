using Actividad3;
using Actividad3.Computadores;
using Actividad3.Perifericos;


//crear vehiculo
Iaccesorio accesorio= new SoporteCelular();
Iaccesorio accesorio1 = new BateriaExterna();


carro carro= new carro(accesorio, accesorio1);