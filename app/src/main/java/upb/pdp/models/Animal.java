package upb.pdp.models;

public class Animal {
    private String nombre;

    private int edad;

    public Animal(String nombre, int edad) {
        this.nombre = nombre;
        this.edad = edad;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getEdad() {
        return edad;
    }

    public void setEdad(int edad) {
        this.edad = edad;
    }

    public String toString() {
        return String.format("=======\nAnimal: %s\nEdad: %d\n=======", this.nombre, this.edad);
    }

    public void moverse(){
        System.out.println("Animal se Mueve");
    }
}
