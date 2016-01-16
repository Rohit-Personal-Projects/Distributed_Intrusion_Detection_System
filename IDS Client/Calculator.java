import java.io.*;
import java.io.Serializable;
public interface Calculator extends java.rmi.Remote { 
    public void add() 
        throws java.rmi.RemoteException,IOException; 
 
    public void sub() 
        throws java.rmi.RemoteException,IOException,java.io.WriteAbortedException, java.io.NotSerializableException; 
 
    public void mul() 
        throws java.rmi.RemoteException,IOException; 
 
    public void div() 
        throws java.rmi.RemoteException,IOException; 

public void abc() 
        throws java.rmi.RemoteException,IOException; 
        	
        	public void def() 
        throws java.rmi.RemoteException,IOException; 

public void ghi()
throws java.rmi.RemoteException,IOException; 
} 