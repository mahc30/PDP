package upb.pdp.aop.aspects;

import org.aspectj.lang.JoinPoint;
import org.aspectj.lang.ProceedingJoinPoint;
import org.aspectj.lang.annotation.*;
import org.springframework.stereotype.Component;
import upb.pdp.aop.models.Animal;

@Aspect
@Component
public class AnimalAspect {

    // Definir un Pointcut que capture los métodos getNombre y setNombre
    @Pointcut("execution(* upb.pdp.aop.models.Animal.get*(..))")
    public void getterPointcut() {}

    @Pointcut("execution(public void toStringCustom())")
    public void toStringCustomPointcut(){}

    @Pointcut("execution(public void registrar())")
    public void registrarPointcut(){}

    // Lógica antes de la ejecución del método getNombre
    @Before("getterPointcut()")
    public void beforeGet() {
        System.out.println("Before get...");
    }

    // Lógica después de la ejecución del método getNombre
    @After("getterPointcut()")
    public void afterGet() {
        System.out.println("After get...");
    }

    @Before("toStringCustomPointcut()")
    public void beforeToStringvCustom(){
        System.out.println("========////////////===========//////////=========");
    }

    @After("toStringCustomPointcut()")
    public void afterToStringCustom(){
        System.out.println("////////==========///////////=========/////////");
    }

    @Around("registrarPointcut()")
    public void aroundRegistrar(ProceedingJoinPoint joinPoint) throws Throwable {
        System.out.println("----> Registro Iniciado <----");
        joinPoint.proceed();
        System.out.println("----> Registro Finalizado <----");
    }

}
