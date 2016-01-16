import java.io.*;
import java.net.*;
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import java.lang.*;
import java.sql.Timestamp;
import java.util.Date;
import java.io.FileInputStream;
import java.security.MessageDigest;


   public class FileServer2 
   	{   
   		static boolean vf=false;
    public static void main(String args[])throws Exception
    { 
        ServerSocket ss=null;
        try
        {  
            ss=new ServerSocket(8081);
        }
        catch(IOException e)
        { 
            System.out.println("couldn't listen");
            System.exit(0);
        }
        Socket cs=null;
        try
        { 
            cs=ss.accept();
            System.out.println("Connection established"+cs);
        }
        catch(Exception e)
        { 
            System.out.println("Accept failed");
            System.exit(1);
        } 
        PrintWriter put=new PrintWriter(cs.getOutputStream(),true);
        BufferedReader st=new BufferedReader(new InputStreamReader(cs.getInputStream()));
        String s=st.readLine();
        System.out.println("The requested file is : "+s);
        File f=new File(s);
/*
		File f1=new File("d:\\ids\\","New Text Document.txt"); 
		System.out.println("ssssssss="+f1);  
*/	
	    
//************************* Start main logic *********************   
     
        if(f.exists())
        {
        	int r=sp(s);
        	System.out.println(s+" returned:"+r);
        	sigsplit(s);
        	
//important        	        	
        	if(r==1)
        	{ 
        		if(!vf)
        		{
        		
		            BufferedInputStream d=new BufferedInputStream(new FileInputStream(s));
		            BufferedOutputStream outStream = new BufferedOutputStream(cs.getOutputStream());
		            byte buffer[] = new byte[1024];
		            int read;
		            while((read = d.read(buffer))!=-1)
		            {
		                outStream.write(buffer, 0, read);
		                outStream.flush();
		            }
		            
//sha		            
					MessageDigest md = MessageDigest.getInstance("SHA-256");
			        FileInputStream fis = new FileInputStream(f);
			 
			        byte[] dataBytes = new byte[1024];
			 
			        int nread = 0; 
			        while ((nread = fis.read(dataBytes)) != -1)
			        {
			        	md.update(dataBytes, 0, nread);
			        }
			        byte[] mdbytes = md.digest();
			 
			        //convert the byte to hex format
			        StringBuffer sb = new StringBuffer();
			        for (int i = 0; i < mdbytes.length; i++)
			        {
			        	sb.append(Integer.toString((mdbytes[i] & 0xff) + 0x100, 16).substring(1));
			        } 		
			 		String hex1=sb.toString();
			        System.out.println("\nHex format : " + hex1); 
		            		            		           		            
//sha end
		            
		            
		            d.close();
		            
		            System.out.println(".File transfered");
		            cs.close();
		            ss.close();
		            
//new socket for sha
	
					System.out.println("socket2 starts");
				
				try
      {
      	 BufferedReader inFromUser = new BufferedReader(new InputStreamReader(System.in));
      	 Socket clientSoc=new Socket("localhost",8082);
      	 DataOutputStream outToServer=new DataOutputStream(clientSoc.getOutputStream());
      	 outToServer.writeBytes(hex1);
      	 clientSoc.close();
      }
      catch(IOException e3)
      {
         e3.printStackTrace();
      }	

// end socket for sha		            
		            
	        	}
        		else
        		{
       // 			System.out.println("VIRUS");
		        	
		        	BufferedInputStream d=new BufferedInputStream(new FileInputStream("virus.txt"));
		            BufferedOutputStream outStream = new BufferedOutputStream(cs.getOutputStream());
		            byte buffer[] = new byte[1024];
		            int read;
		            while((read = d.read(buffer))!=-1)
		            {
		                outStream.write(buffer, 0, read);
		                outStream.flush();
		            }
		            		            
//sha		            
					MessageDigest md = MessageDigest.getInstance("SHA-256");
			        FileInputStream fis = new FileInputStream(f);
			 
			        byte[] dataBytes = new byte[1024];
			 
			        int nread = 0; 
			        while ((nread = fis.read(dataBytes)) != -1)
			        {
			        	md.update(dataBytes, 0, nread);
			        }
			        byte[] mdbytes = md.digest();
			 
			        //convert the byte to hex format
			        StringBuffer sb = new StringBuffer();
			        for (int i = 0; i < mdbytes.length; i++)
			        {
			        	sb.append(Integer.toString((mdbytes[i] & 0xff) + 0x100, 16).substring(1));
			        } 		
			 		String hex1=sb.toString();
			        System.out.println("\nHex format : " + hex1); 
		            		            		           		            
//sha end
		            
		            
		            d.close();
		            
		            System.out.println(".File transfered");
		            cs.close();
		            ss.close();
		            
//new socket for sha
	
					System.out.println("socket2 starts");
				
				try
      {
      	 BufferedReader inFromUser = new BufferedReader(new InputStreamReader(System.in));
      	 Socket clientSoc=new Socket("localhost",8082);
      	 DataOutputStream outToServer=new DataOutputStream(clientSoc.getOutputStream());
      	 outToServer.writeBytes(hex1);
      	 clientSoc.close();
      }
      catch(IOException e3)
      {
         e3.printStackTrace();
      }	

// end socket for sha		            

        		}
	        }
	        else
	        	if(r==0)
		        {
		        	System.out.println("No permissions");
		        	
		        	BufferedInputStream d=new BufferedInputStream(new FileInputStream("sorry.txt"));
		            BufferedOutputStream outStream = new BufferedOutputStream(cs.getOutputStream());
		            byte buffer[] = new byte[1024];
		            int read;
		            while((read = d.read(buffer))!=-1)
		            {
		                outStream.write(buffer, 0, read);
		                outStream.flush();
		            }
		            		            
//sha		            
					MessageDigest md = MessageDigest.getInstance("SHA-256");
			        FileInputStream fis = new FileInputStream(f);
			 
			        byte[] dataBytes = new byte[1024];
			 
			        int nread = 0; 
			        while ((nread = fis.read(dataBytes)) != -1)
			        {
			        	md.update(dataBytes, 0, nread);
			        }
			        byte[] mdbytes = md.digest();
			 
			        //convert the byte to hex format
			        StringBuffer sb = new StringBuffer();
			        for (int i = 0; i < mdbytes.length; i++)
			        {
			        	sb.append(Integer.toString((mdbytes[i] & 0xff) + 0x100, 16).substring(1));
			        } 		
			 		String hex1=sb.toString();
			        System.out.println("\nHex format : " + hex1); 
		            		            		           		            
//sha end
		            
		            
		            d.close();
		            
		            System.out.println("Sorry File transfered");
		            cs.close();
		            ss.close();
		            
//new socket for sha
	
					System.out.println("socket2 starts");
				
				try
      {
      	 BufferedReader inFromUser = new BufferedReader(new InputStreamReader(System.in));
      	 Socket clientSoc=new Socket("localhost",8082);
      	 DataOutputStream outToServer=new DataOutputStream(clientSoc.getOutputStream());
      	 outToServer.writeBytes(hex1);
      	 clientSoc.close();
      }
      catch(IOException e3)
      {
         e3.printStackTrace();
      }	

// end socket for sha		            

		        }
			else
				System.out.println("Errrorr");
        }
        else
        	System.out.println("Nooooooooo. File does not exist...");  
    }  
    	
//**************************************************************************
    	
    public static int sp(String f)
    {
    	System.out.println("\t//Protected files list starts for "+f);
		try
		{
//protected files list read (always acl.txt)
			FileInputStream fstream = new FileInputStream("acl.txt");
			DataInputStream in = new DataInputStream(fstream);
			BufferedReader br = new BufferedReader(new InputStreamReader(in));
			String strLine,s="";
			while ((strLine = br.readLine()) != null)
				s+=strLine;
				
//split method
			String[] temp;
			String delimiter = "-";
			temp = s.split(delimiter);
			
			int i =0;
			for(i =0; i < temp.length ; i++)
				System.out.println("\t\tprotected file "+i+"="+temp[i]);
			System.out.println();
			
			for(int j=0;j<temp.length;j++)
				if(temp[j].contains(f))
					return 0;
			return 1;			
		}
		catch (Exception e)
	  	{
			System.out.println("Error: " + e.getMessage());
		}
		return 2;
    }
    
//*********************************************************

	public static void sigsplit(String f)
	{
	//	System.out.println("//sigsplit starts");
		try
		{
//signature read (always sig.txt)
			FileInputStream fstream = new FileInputStream("sig.txt");
			DataInputStream in = new DataInputStream(fstream);
			BufferedReader br = new BufferedReader(new InputStreamReader(in));
			String strLine,s="";
			while ((strLine = br.readLine()) != null)
				s+=strLine;
				
//split method
			String[] temp;
			String delimiter = "-";
			temp = s.split(delimiter);
			
//call infile to tokenize received file			
			infile(temp,f);
    		in.close();	
    	}    	
		catch (Exception e)
	  	{
			System.out.println("Error: " + e.getMessage());
		}
	}//sigsplit	
//**************************************************************************************
	public static void infile(String v[],String f)
	{
		try
		{
//file read
			FileInputStream fstream = new FileInputStream(f);
			System.out.println(f);
			DataInputStream in = new DataInputStream(fstream);
			BufferedReader br = new BufferedReader(new InputStreamReader(in));
			String strLine,s="";
			while ((strLine = br.readLine()) != null)
				s+=strLine;
				
//split method
			String[] temp2;
			String delimiter = "[., {}();=\t$\"!?\n]+";
			temp2 = s.split(delimiter);
			for(int i =0; i < temp2.length ; i++)
				System.out.println("file token "+i+"="+temp2[i]);;
			System.out.println();
			
//call compare
			compare(v,s,f);
    		in.close();	
    	}
    	
		catch (Exception e)
	  	{
			System.out.println("Error: " + e.getMessage());
		}
	}//infile()	
//**************************************************************************************
	public static void compare(String virus[],String fin,String f)
	{		
		int i=0,j=0;
		boolean flag=false;
			
	//	System.out.print("virus signature tokens: ");
	//	for(i=0;i<virus.length;i++)
	//		System.out.print(virus[i]+"  ");
	//	System.out.println();

		System.out.print("file string: "+fin);
		System.out.println("\n");
		
		int o0=fin.indexOf(virus[0]);
		int o1=fin.indexOf(virus[1]);
		int o2=fin.indexOf(virus[2]);
		int o3=fin.indexOf(virus[3]);
		int o4=fin.indexOf(virus[4]);
	/*	System.out.println("index0="+o0);
		System.out.println("index1="+o1);
		System.out.println("index2="+o2);
		System.out.println("index2="+o3);
		System.out.println("index2="+o4);
	*/	System.out.println();
		
//check if index is found
		if(o0>-1 || o1>-1 || o2>-1 || o3>-1 || o4>-1)
			flag=true;
		found(flag,f);	
	}//compare	
//**************************************************************************************
	public static void found(boolean b,String f)
	{
		System.out.print("File :"+f);
		if(b)
		{
//			System.out.println("\nvirus found"+vf);
			vf=true;
//			deletefile(f);
		}
//		else
//			System.out.println("\nvirus not found");
//		System.exit(0);
	}//found
}