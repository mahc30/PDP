package upb.pdp.models;

public class Perro extends Animal {
    public Perro(String nombre, int edad) {
        super(nombre,  edad);
    }

    public Perro(String nombre){
        super(nombre, 3);
    }

     @Override
    public String toString(){
        return "soy un perro " + getNombre() + " guau";
     }
}
