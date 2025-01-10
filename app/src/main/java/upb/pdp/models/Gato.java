package upb.pdp.models;

public class Gato extends Animal {

    public Gato(String nombre, int edad) {
        super(nombre, edad);
    }

    @Override
    public String toString() {
        return String.format("Meow %s %d", this.getNombre(), this.getEdad());
    }
}
