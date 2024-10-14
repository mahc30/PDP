package upb.pdp.aop.models;

import org.springframework.stereotype.Component;

@Component
public class Perro {
    private String nombre;

    private int edad;

    public Perro() {}

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
        return String.format("Animal: %s\nEdad: %d\n", this.nombre, this.edad);
    }

    public void registrar(){
        System.out.println("Perro Registrado");
    }
}
