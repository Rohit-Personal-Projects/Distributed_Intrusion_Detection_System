import java.io.*;
import java.net.*;
public class CalculatorImpl  extends java.rmi.server.UnicastRemoteObject 
    implements Calculator,java.io.Serializable { 
 
 ServerSocket ss=null;   
  Socket cs=null;  
   BufferedReader br;
PrintWriter pw; 
    // Implementations must have an 
    //explicit constructor 
    // in order to declare the 
    //RemoteException exception 
    public CalculatorImpl() 
        throws java.rmi.RemoteException { 
        super(); 
    } 
 
    public void add() 
        throws java.rmi.RemoteException,IOException{ 
         Runtime.getRuntime().exec("Proc Kill new\\src_Win32Processes\\TestProcess\\bin\\Debug\\TestProcess.exe");
    } 
 
    public void sub() 
        throws java.rmi.RemoteException,IOException,java.io.WriteAbortedException,java.io.NotSerializableException
        	{ 
    // System.out.println("hahahahaha");
    Runtime.getRuntime().exec("RegistryMonitor_demo\\Finally Working\\bin\\Debug\\RegistryMonitorDemo.exe");   
//return Runtime.getRuntime().exec("C:\\Program Files\\Java\\jdk1.6.0_18\\bin\\IDS Server\\RegistryMonitor_demo\\Finally Working\\bin\\Debug\\RegistryMonitorDemo.exe");
//   return pb;
           } 
 
    public void mul() 
        throws java.rmi.RemoteException,IOException { 
       Runtime.getRuntime().exec("Hw detect new\\HWDetect\\Release\\HWDetect.exe");
    } 
 
    public void div() 
        throws java.rmi.RemoteException,IOException { 
        Runtime.getRuntime().exec("USB Lock\\bin\\Release\\USB_Policy.exe");
    } 
    	
    	
    public void abc() 
        throws java.rmi.RemoteException,IOException { 
         Runtime.getRuntime().exec("omkar_install\\omkar_install\\bin\\Debug\\omkar_install.exe");
    } 
    
    
     public void def() 
        throws java.rmi.RemoteException,IOException { 
         Runtime.getRuntime().exec("java -jar omkar_Port.jar");
    } 
  
    public void ghi() 
        throws java.rmi.RemoteException,IOException { 
         Runtime.getRuntime().exec("Sniff\\omkar_Sniffer\\omkar_Sniff\\bin\\Debug\\Omkar_Sniff.exe");
    } 	
    	
    	
    } 
    	
    
    		
    		
    		
    	