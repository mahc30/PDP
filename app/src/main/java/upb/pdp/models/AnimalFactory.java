package upb.pdp.models;

public class AnimalFactory {
    public static Animal crearAnimal(String nombre){
        return new Animal(nombre, 0);
    }

    public static Animal crearAnimal(boolean esGato, String nombre, int edad) {
        if(esGato){
            return new Gato(nombre, edad);
        }
        else{
            return new Perro(nombre, edad);
        }
    }
}
