package upb.pdp;

import upb.pdp.models.*;

public class Main {
    public static void main(String[] args) {

        Animal animal = new Animal("Eduardo", 4);
        Perro perro = new Perro("Bolt", 5);
        Gato gato = new Gato("Misifus", 8);

        System.out.println(animal.toString());
        System.out.println(perro.toString());
        System.out.println(gato.toString());

        System.out.print("Animal: ");
        animal.moverse();
        System.out.print("Perro: ");
        perro.moverse();
        System.out.print("Gato: ");
        gato.moverse();
    }
}