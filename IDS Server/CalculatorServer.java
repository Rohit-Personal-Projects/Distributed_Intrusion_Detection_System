import java.rmi.Naming;
import java.io.Serializable;
public class CalculatorServer implements java.io.Serializable{

   public CalculatorServer() {
     try {
       Calculator c = new CalculatorImpl();
       Naming.rebind("rmi://localhost:1099/CalculatorService", c);
     } catch (Exception e) {
       System.out.println("Trouble: " + e);
     }
   }

   public static void main(String args[]) {
     new CalculatorServer();
   }
}
