package upb.pdp.models;

public class Persona {


    private String nombre;

    private String telefono;
    private int edad;

    private String tipoDocumento;
    private String documento;

    @Override
    public String toString() {
        return String.format("Hola soy %s tengo %d mi documento es %s %s y mi teléfono es %s", this.nombre, this.edad, this.tipoDocumento, this.documento, this.telefono);
    }

    public Persona(String nombre, String telefono, int edad, String tipoDocumento, String documento) {
        this.nombre = nombre;
        this.telefono = telefono;
        this.edad = edad;
        this.tipoDocumento = tipoDocumento;
        this.documento = documento;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getTelefono() {
        return telefono;
    }

    public void setTelefono(String telefono) {
        this.telefono = telefono;
    }

    public int getEdad() {
        return edad;
    }

    public void setEdad(int edad) {
        this.edad = edad;
    }

    public String getTipoDocumento() {
        return tipoDocumento;
    }

    public void setTipoDocumento(String tipoDocumento) {
        this.tipoDocumento = tipoDocumento;
    }

    public String getDocumento() {
        return documento;
    }

    public void setDocumento(String documento) {
        this.documento = documento;
    }
}
