// See https://aka.ms/new-console-template for more information
using Listas_Genericas_y_No_Genericas;
using System.Collections;

Persona oPersona1 = new Persona("6869086", "Kevin Cuba");


int dato1 = 100;
int dato2 = 200;
int dato3 = 320;


ArrayList listaNG = new ArrayList();
listaNG.Add(dato1);
listaNG.Add(dato2);
listaNG.Add(dato3);


List<int> listaPersonas = new List<int>();
listaPersonas.Add(dato1);
listaPersonas.Add(dato2);
listaPersonas.Add(dato3);

foreach (var dato in listaPersonas)
{
    Console.WriteLine("Numero: " + dato);
}
