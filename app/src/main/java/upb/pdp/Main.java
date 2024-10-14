package upb.pdp;

import upb.pdp.models.Animal;
import upb.pdp.models.AnimalFactory;

public class Main {
    public static void main(String[] args) {

        Animal[] animals = new Animal[3];

        animals[0] = AnimalFactory.crearAnimal("Rufus");
        animals[1] = AnimalFactory.crearAnimal(true, "Carlos", 5);
        animals[2] = AnimalFactory.crearAnimal(false, "Alirio", 4);
        for (Animal animal : animals) {
            System.out.println(animal.toString());
        }
    }
}