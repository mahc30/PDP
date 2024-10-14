package upb.pdp.aop;

import org.springframework.context.ApplicationContext;
import org.springframework.context.annotation.AnnotationConfigApplicationContext;
import upb.pdp.aop.models.Animal;
import upb.pdp.aop.models.Perro;

public class AopApplication {

	public static void main(String[] args) {

		// Crear el contexto de Spring
		ApplicationContext context = new AnnotationConfigApplicationContext(AppConfig.class);

		// Obtener el bean de Animal
		Animal animal = context.getBean(Animal.class);
		Perro perro = context.getBean(Perro.class);

		animal.setNombre("Tigre");
		animal.setEdad(11);
		animal.toStringCustom();

		perro.setEdad(13);
		perro.setNombre("Ramiro");
		System.out.println(perro.toString());

		animal.registrar();
		perro.registrar();
	}
}
