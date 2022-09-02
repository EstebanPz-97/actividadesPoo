

using trabajo2.Entities;
using trabajo2.entities1;

Entity ve = new VehiculoElectrico(id:"1",placa: "hap589", horasCarga: 50.1);

var vel = (VehiculoElectrico)ve;
Console.WriteLine(vel.HorasCarga);


Entity vg = new VehiculoGasolina(id: "2", placa: "csr483");
var vg1 = (VehiculoGasolina)vg;

vg1.ImprimirValores();


Entity1 vehiculo = new VehiculoElectrico1();
vehiculo.Arrancar();

Entity1 vehiculo2 = new VehiculoGasolina1();
vehiculo2.Arrancar();

Entity1 per = new Persona();
per.Arrancar();

