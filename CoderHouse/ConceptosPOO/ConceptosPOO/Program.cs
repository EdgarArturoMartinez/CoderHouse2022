//********* UTILIZAR PRIVATE ES ENCAPSULAR
//********* STATIC ES PARA METODO U OBJETO QUE NO NECESITA APLICAR POO
//********* STATIC NO NECESITA SER INSTANCIADO COMO UN OBJETO, SOLO NOMBRE CLASE Y NOMBRE METODO
//********* EN LA HERENCIA ESTA INCLUIDO EL POLIMORFISMO (RUNTIME POLYIMORPHISM USING VIRTUAL AND OVERRIDE)
//********* C# NO ES MULTIHERENCIA.
//********* DEFAULT CONSTRUCTOR ES AQUEL QUE NO TIENE CODIGO O PARAMETROS (CUANDO LA CLASE NO TIENE CONSTRUCTOR)
//********* PRIVATE STATIC INT PARA ADMINISTRAR VALORES DE CONTADORES EN UNA CLASE COMO BUENA PRACTICA

using ConceptosPOO;

realizarTarea();


static void realizarTarea()
{
    Punto origen = new Punto();

    Punto destino = new Punto(150, 90);

    double distancia = origen.DistanciaHasta(destino);

    Console.WriteLine($"Distancia entre puntos es de: {distancia}");

    //Acceso con nombre de clase a metodo Static
    Console.WriteLine($"Numero de Objetos creados: {Punto.ContadorDeObjetos()}");
    
}
