package upb.pdp.aop.models;

import org.springframework.stereotype.Component;

@Component
public class Animal {
    private String nombre;

    private int edad;

    public Animal() {}

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

    public void toStringCustom() {
        System.out.println(String.format("Animal: %s\nEdad: %d", this.nombre, this.edad));
    }

    public void registrar(){
        System.out.println("Animal Registrado");
    }
}
