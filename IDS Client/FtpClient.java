//FtpClient.java

import java.net.*;
import java.io.*;
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import java.lang.*;
import java.sql.Timestamp;
import java.util.Date;
import java.io.FileInputStream;
import java.security.MessageDigest;


class FtpClient extends JFrame implements ActionListener
{
	String fn,filenm;
	String fc;
	String dir="C:\\IDS final\\IDS Client\\FTPclient\\";
	JPanel pnl;
	JLabel lbltle,lblud;
	Font fnt;
	JTextField txtfn;
	JButton btnu,btnd;
	Socket s;
	InputStreamReader in;
	OutputStream out;
	BufferedReader br;
	PrintWriter pw;
	
//*********************************************************
	public FtpClient()
	{
		super("CLIENT");

		pnl=new JPanel(null);

		fnt=new Font("Times New Roman",Font.BOLD,25);

		lbltle=new JLabel("CLIENT");
		lbltle.setFont(fnt);
		lbltle.setBounds(225,35,200,30);
		pnl.add(lbltle);

		lblud=new JLabel("ENTER  FILE-NAME :");
		lblud.setBounds(100,100,150,35);
		pnl.add(lblud);

		txtfn=new JTextField();
		txtfn.setBounds(300,100,200,25);
		pnl.add(txtfn);

		btnu=new JButton("UPLOAD");
		btnu.setBounds(150,200,120,35);
		pnl.add(btnu);


		btnd=new JButton("DOWNLOAD");
		btnd.setBounds(320,200,120,35);

		pnl.add(btnd);

		btnu.addActionListener(this);
		btnd.addActionListener(this);
		getContentPane().add(pnl);

		try
		{
			s=new Socket("localhost",8081);
			br=new BufferedReader(new InputStreamReader(s.getInputStream()));
			pw=new PrintWriter(s.getOutputStream(),true);
			out=s.getOutputStream();
		}
		catch(Exception e)
		{
			System.out.println("ExCEPTION :"+e.getMessage());
		}
	}//FtpClient()

//*********************************************************
	public void actionPerformed(ActionEvent e)
	{
	try
	{
	//************************  BTNU  *************************
	
/*		if(e.getSource()==btnu)
		{
	   
			filenm=txtfn.getText();
			pw.println(filenm);
	   		FileInputStream  fis=new FileInputStream(filenm);
	   		byte[] buffer=new byte[1024];
	   		int bytes=0;
	
	   		while((bytes=fis.read(buffer))!=-1)
	   		{
	    		out.write(buffer,0,bytes);
	   		}
	   		fis.close();
	  		}
	  		catch(Exception exx)
	  		{
	   			System.out.println(exx.getMessage());
	  		}
	  	}
*/
	//************************  BTND  *************************
	
	  if(e.getSource()==btnd)
	  {
			InputStreamReader get2=new InputStreamReader(s.getInputStream());
			String u,f;		
			f=txtfn.getText();
	//filename is 'f' along wit extension		
			pw.println(f);
			String fname="";
			String ext="";
			int mid= f.lastIndexOf(".");
			fname=f.substring(0,mid);
			ext=f.substring(mid+1,f.length()); 
		//	String c="D:\\cc\\"+fname+"."+ext;
			String c=dir+fname+"."+ext;
	//f1 is created file which i need to delete if virus
			File f1=new File(c);
			FileOutputStream  fs=new FileOutputStream(f1);
	    
			BufferedInputStream d=new BufferedInputStream(s.getInputStream());
			BufferedOutputStream outStream = new BufferedOutputStream(new FileOutputStream(f1));
			byte buffer[] = new byte[1024];
			int read;
			pw.println("yippppppiiiieeee");
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
			        System.out.println("receiver's	hex : " + hex1); 
		            		            
		            
//sha end

//socket2		
			
		try
        {  
           ServerSocket welcomeSocket=new ServerSocket(8082);
           while(true)
           {
           		Socket connectionSocket=welcomeSocket.accept();
           		BufferedReader inFromClient=new BufferedReader(new InputStreamReader(connectionSocket.getInputStream()));
           		DataOutputStream outToClient=new DataOutputStream(connectionSocket.getOutputStream());
           		String clientSentence=inFromClient.readLine();
           		System.out.println("sender's	hex : "+clientSentence);
           		
          		System.out.println("\ncomparing hex values:");
		     	if(hex1.equals(clientSentence))
		     		System.out.println("hex values match...\nFile Integrity Proper");
		     	else
		     		System.out.println("hex values match...\nFile Integrity ImProper");
		     	
           		welcomeSocket.close();
           		
           }
        }
        catch(Exception e1)
        { 
         //   System.out.println("couldn't listen");
         //   System.out.println(e1);
      //      System.exit(0);
        }
     /*   Socket cs=null;
        try
        { 
            cs=ss.accept();
            System.out.println("Connection established"+cs);
        }
        catch(Exception e2)
        { 
            System.out.println("Accept failed");
            System.exit(1);
        } 
        PrintWriter put=new PrintWriter(cs.getOutputStream(),true);
        BufferedReader st=new BufferedReader(new InputStreamReader(cs.getInputStream()));
        String s=st.readLine();
     */  
     	
		System.out.println("\n"+s);
		
//socket2 end			
			
	//		fs.close();
			System.out.println("File received");
	//		s.close();
			
			
	//inserting my logic here
			sigsplit(f);
			pw.println("yippppppiiiieeee");
			
//popup call code
					
						
	  }//if(BTND) 
	}//try
	
	  catch(Exception exx)
	  {}
	  }//actionPerformed
//*********************************************************

	public static void sigsplit(String f)
	{
		System.out.println("//sigsplit starts");
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
			for(int i =0; i < temp.length ; i++)
				System.out.println("Virus signature "+i+"="+temp[i]);;
			System.out.println();
			
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
			System.out.println(f);
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
	public static void compare(String virus[],String fin,String f) throws Exception
	{		
		int i=0,j=0;
		boolean flag=false;
			
/*		System.out.print("virus signature tokens: ");
		for(i=0;i<virus.length;i++)
			System.out.print(virus[i]+"  ");
		System.out.println();

		System.out.print("file string: "+fin);
*/		System.out.println("\n");

//search virus substring				
		int o0=fin.indexOf(virus[0]);
		int o1=fin.indexOf(virus[1]);
		int o2=fin.indexOf(virus[2]);
		int o3=fin.indexOf(virus[3]);
		int o4=fin.indexOf(virus[4]);
		System.out.println("index0="+o0);
		System.out.println("index1="+o1);
		System.out.println("index2="+o2);
		System.out.println("index3="+o3);
		System.out.println("index4="+o4);
		System.out.println();
		
//		for(i=0;i<virus.length;i++)
//			System.out.println("index"+i+" ="+fin.indexOf(virus[i]));
		
//check if index is found
		if(o0>-1 || o1>-1 || o2>-1 || o3>-1 || o4>-1)
			flag=true;
		found(flag,f);	
	}//compare	
//**************************************************************************************
	public static void found(boolean b,String f) throws IOException
	{
		System.out.print("File :"+f);
		java.util.Date date= new java.util.Date();
	 	Timestamp t=new Timestamp(date.getTime());
//	 	Time t2=new Time(date.getTime());	 	
//	 	String t=Timestamp(t1);
//	 	String t3=t2;
		if(b)
		{
			System.out.println("\nvirus found");
//			deletefile(f);
//write to file
			
			try
			{
				BufferedWriter out = new BufferedWriter(new FileWriter("filename.txt", true));
				out.write("\n\n");
				out.write("	$$	"+f+" : virus found : "+t);
				out.close();
			}
			catch (IOException e)
			{}			  			
  			System.out.println("Your file has been logged");			
		}
		else
		{
			System.out.println("\nvirus not found");
//write to file
			try
			{
				BufferedWriter out = new BufferedWriter(new FileWriter("filename.txt", true));
				out.write("\n\n");
				out.write("	$$	"+f+" : virus not found : "+t);
				out.close();
			}
			catch (IOException e)
			{}	
  			System.out.println("Your file has been logged");			
		}
			
			
		
		System.exit(0);
	}//found
	
//**************************************************************************************
	static void deletefile(String file)
	{
		System.out.println(file);
		File f1 = new File(file);
		boolean success = f1.delete();
//		System.out.print(success);
		if (!success)
		{
	  		System.out.println("\nDeletion failed.");
			System.exit(0);
		}
		else
			System.out.println("\nFile deleted.");
	}//deletefile
//**************************************************************************************
	public static void main(String args[])
{
  FtpClient ftpc=new FtpClient();
  ftpc.setSize(600,300);
  ftpc.show();
}
}
