package upb.pdp;

import upb.pdp.models.Persona;

public class Main {
    public static void main(String[] args) {

        String[] nombres = new String[3];
        String[] telefonos = new String[3];
        String[] documentos = new String[3];
        int[] edades = new int[3];

        nombres[0] = "Carlos";
        nombres[1] = "Alirio";
        nombres[2] = "Juana";

        telefonos[0] = "12345";
        telefonos[1] = "54321";
        telefonos[2] = "1251251";

        documentos[0] = "13642513";
        documentos[1] = "353515";
        documentos[2] = "2623626";

        edades[0] = 11;
        edades[1] = 54;
        edades[2] = 23;


        for(int i = 0; i < 3; i++){
            System.out.println("Nombre: " + nombres[i] + " telefono: " + telefonos[i] + " documento: " + documentos[i] + " Edad " + edades[i]);
        }
    }
}