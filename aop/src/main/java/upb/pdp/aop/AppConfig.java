package upb.pdp.aop;

import org.springframework.context.annotation.ComponentScan;
import org.springframework.context.annotation.Configuration;
import org.springframework.context.annotation.EnableAspectJAutoProxy;

@Configuration
@ComponentScan(basePackages = "upb.pdp.aop")
@EnableAspectJAutoProxy
public class AppConfig {
}
