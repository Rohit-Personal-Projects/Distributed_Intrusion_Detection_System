import java.rmi.Naming; 
import java.rmi.RemoteException; 
import java.net.MalformedURLException; 
import java.rmi.NotBoundException; 
import java.io.*; 
import javax.swing.*;
import java.awt.*; 
import java.awt.event.*;
import java.util.*;
import java.awt.Dimension;
import java.util.*;
import java.awt.Insets;

import javax.swing.Box;
import javax.swing.BoxLayout;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.SwingUtilities;
import javax.swing.border.EmptyBorder;
import java.net.*;
 class CalculatorClient extends JFrame implements ActionListener,java.io.Serializable
{
	Calculator c;
BufferedReader br;
PrintWriter pw;
Socket s;
OutputStream out;
JFrame f=new JFrame();
        JPanel panel = new JPanel();
        JPanel panel1=new JPanel();
        //panel1.setLayout(null);
        //panel.setLayout(null);
        JTextArea textArea = new JTextArea(40,50);
 JScrollPane scrollPane = new JScrollPane(textArea);
//scrollPane.setVerticalScrollBarPolicy(ScrollPaneConstants.VERTICAL_SCROLLBAR_ALWAYS);

        
JButton Regmon=new JButton("    Registry monitor    ");//
       
       
       JButton Proc=new JButton("         Process kill         ");
       
        JButton Hw=new JButton("          H/W Detect          ");//
       
        
        JButton Usb=new JButton("               USB                  ");
        

JButton File=new JButton("        Installations         ");

JButton Port=new JButton("        Port Scanner        ");

JButton Dld=new JButton("Secure File Download");//

//JButton Att=new JButton("      Prevent attacks     ");

JButton log1=new JButton("            View log1           ");
JButton log2=new JButton("            View log2           ");
JButton log3=new JButton("            View log3           ");
JButton log4=new JButton("            View log4           ");

//JButton dd=new JButton("       Download logs       ");

JButton scan=new JButton("      Packet analysis     ");




  public CalculatorClient()   // the constructor
  {
  	 try { 
        	
        Scanner src=new Scanner(System.in);
        
 JMenuBar menubar = new JMenuBar();
  JMenu filemenu = new JMenu("File");
  filemenu.add(new JSeparator());
  JMenu editmenu = new JMenu("Edit");
  editmenu.add(new JSeparator());
  JMenuItem fileItem1 = new JMenuItem("New");
  JMenuItem fileItem2 = new JMenuItem("Open");
  JMenuItem fileItem3 = new JMenuItem("Close");
  fileItem3.add(new JSeparator());
  JMenuItem fileItem4 = new JMenuItem("Save");
  JMenuItem editItem1 = new JMenuItem("Cut");
  JMenuItem editItem2 = new JMenuItem("Copy");
  editItem2.add(new JSeparator());
  JMenuItem editItem3 = new JMenuItem("Paste");
  JMenuItem editItem4 = new JMenuItem("Insert");
  filemenu.add(fileItem1);
  filemenu.add(fileItem2);
  filemenu.add(fileItem3);
  filemenu.add(fileItem4);
  editmenu.add(editItem1);
  editmenu.add(editItem2);
  editmenu.add(editItem3);
  editmenu.add(editItem4);
  menubar.add(filemenu);
  menubar.add(editmenu);
   textArea.setEditable(true);
   textArea.setLineWrap(true);
    panel.setLayout(new BoxLayout(panel, BoxLayout.Y_AXIS));
    Regmon.addActionListener(this); // register button listener
    
    Proc.addActionListener(this); 
    	Hw.addActionListener(this); 
    		Usb.addActionListener(this); 
    		scan.addActionListener(this);	
    		 Port.addActionListener(this);
    		  Dld.addActionListener(this);
    	//	   Att.addActionListener(this);
    		    File.addActionListener(this);	
    			log1.addActionListener(this);
    			log2.addActionListener(this);
    			log3.addActionListener(this);
    			log4.addActionListener(this);
   panel.setBorder(new EmptyBorder(new Insets(40, 60, 40, 60)));
    panel.add(Regmon);
        panel.add(Box.createRigidArea(new Dimension(0,20)));
    panel.add(Proc);
        panel.add(Box.createRigidArea(new Dimension(0, 20)));
   
    panel.add(Hw);
        panel.add(Box.createRigidArea(new Dimension(0, 20)));
        panel.add(Usb);
         panel.add(Box.createRigidArea(new Dimension(0, 20)));
        panel.add(File);
        
       panel.add(Box.createRigidArea(new Dimension(0, 20)));
        panel.add(Port); 
        
        panel.add(Box.createRigidArea(new Dimension(0, 20)));
        panel.add(Dld);
        
        panel.add(Box.createRigidArea(new Dimension(0, 20)));
 //       panel.add(Att);
 //        panel.add(Box.createRigidArea(new Dimension(0, 20)));
        panel.add(scan);
       panel.add(Box.createRigidArea(new Dimension(0, 20)));
       panel.add(log1);
        panel.add(Box.createRigidArea(new Dimension(0, 20)));
       panel.add(log2);
        panel.add(Box.createRigidArea(new Dimension(0, 20)));
       panel.add(log3);
        panel.add(Box.createRigidArea(new Dimension(0, 20)));
       panel.add(log4); 
      
       // panel1.add(scrollPane);
        
        panel1.add(scrollPane);
        //JScrollPane scrollPane = new JScrollPane(panel1);
        // frame.setJMenuBar(menubar)
         	add(menubar,BorderLayout.NORTH);
        add(panel,BorderLayout.EAST);
        add(panel1,BorderLayout.WEST);
        pack();

        setTitle("IDS Administrator");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLocationRelativeTo(null);
        
        
        
 c=(Calculator)Naming.lookup( "rmi://localhost/CalculatorService");
  }
  	 //}
    catch(Exception e)
    {
    	System.out.println(e);
    	System.exit(0);
    }
  }
  
  	 
  // here is the basic event handler
  public void actionPerformed(ActionEvent event)
  {
  	try

  {
  	BufferedReader log=null;
 FileReader logg=null;
 String line=null;
  	  textArea.setText("");
  textArea.setLineWrap(true);  
 textArea.setWrapStyleWord(true); 
    Object source=event.getSource();
    if (source==Regmon)
    {
     c.sub();
      

     textArea.insert("The Windows API provides a function RegNotifyChangeKeyValue, which notifies the caller about changes to attributes or the content of a specified registry key. Unfortunately, this function is not provided by the Microsoft.Win32.RegistryKey class. Because we needed that functionality, we've written a simple wrapper class.",0);  
    }
    
    
   if (source==Proc)
    {
      c.add();
      textArea.insert("The Process Explorer display consists of two sub-windows. The top window always shows a list of the currently active processes, including the names of their owning accounts, whereas the information displayed in the bottom window depends on the mode that Process Explorer is in: if it is in handle mode you'll see the handles that the process selected in the top window has opened; if Process Explorer is in DLL mode you'll see the DLLs and memory-mapped files that the process has loaded. Process Explorer also has a powerful search capability that will quickly show you which processes have particular handles opened or DLLs loaded.",0);  
    }
     if (source==Hw)
    {
      c.mul();
     textArea.insert("Hot-pluggable device is now a big threat to IT security. In this article, we will try to develop a user-mode application to detect device change on the system, i.e. plug-in a USB drive, iPod, USB wireless network card, etc. The program can also disable any newly plugged devices. We will get a basic idea on how this works and talk about its limitations at the end of this article.",0);  
    
    
    
    
    }
     if (source==Usb)
    {
      c.div();
      textArea.insert("USB storage devices (flash drives, USB sticks etc.) offer many advantages for us. However, at the same time, they cause security problems because it is easy to copy a lot of files to a tiny USB memory in a few seconds. We might have some secure data on our PC which we do not want other users to copy through the USB. Therefore, we many need to define a USB storage policy to make USB drives write protected or not to be accessed through the system.",0); 
    }
    
    if(source==File)
    {
    	c.abc();
    textArea.insert("This is a module which enables to view the installations on a particular computer and if any of the installed softwares are changes the administrator is notified.",0);
    }
    
    if(source==Port)
    {
    	c.def();
     textArea.insert("A port scanner is a software application designed to probe a server or host for open ports. This is often used by administrators to verify security policies of their networks and by attackers to identify running services on a host with the view to compromise it.A port scan or portscan is An attack that sends client requests to a range of server port addresses on a host, with the goal of finding an active port and exploiting a known vulnerability of that service.To portsweep is to scan multiple hosts for a specific listening port. The latter is typically used in searching for a specific service, for example, an SQL-based computer worm may portsweep looking for hosts listening on TCP port 1433.",0);  
    }
    
   
  if(source==scan)
  {
  c.ghi();
  textArea.insert("A packet analyzer (also known as a network analyzer, protocol analyzer, or sniffer, or for particular types of networks, an Ethernet sniffer or wireless sniffer) is a computer program or a piece of computer hardware that can intercept and log traffic passing over a digital network or part of a network.As data streams flow across the network, the sniffer captures each packet and, if needed, decodes the packet's raw data, showing the values of various fields in the packet, and analyzes its content according to the appropriate RFC or other specifications.",0)	;
  }
  if(source==Dld)
  {
  	textArea.insert("A secure file download utility lets you to securely download any files over a LAN without viruses and any kind of malware.It also includes integrity check to make the transaction tamper-proof",0);
  	Runtime.getRuntime().exec("java -jar FTPclient\\rohit.jar");
  	
  }
  	
  	
  	
  if(source==log1)
  {
  	
  	logg =new FileReader("E:\\IDS final\\IDS Client\\FTPclient\\RegLog.txt");
  	log = new BufferedReader(logg);
  	while((line = log.readLine()) != null) {
    textArea.append(line);
}
log.close();

  }
  
 if(source==log2)
  {
  		logg =new FileReader("E:\\IDS final\\IDS Client\\FTPclient\\ProcLog.txt");
  	log = new BufferedReader(logg);
  	while((line = log.readLine()) != null) {
    textArea.append(line);
}
log.close();
  } 
  
  if(source==log3)
  {
  		logg =new FileReader("E:\\IDS final\\IDS Client\\FTPclient\\filename.txt");
  	log = new BufferedReader(logg);
  	while((line = log.readLine()) != null) {
    textArea.append(line);
}
log.close();
  	
  }
  if(source==log4)
  {
  	/*	logg =new FileReader("C:\\IDS final\\IDS Client\\FTPclient\\FileLog.txt");
  	log = new BufferedReader(logg);
  	while((line = log.readLine()) != null) {
    textArea.append(line);*/
    File file = new File("E:\\IDS final\\IDS Client\\FTPclient\\FileLog.txt");
Scanner scanner = new Scanner(file);
            while (scanner.hasNextLine()) {
                 line = scanner.nextLine();
                textArea.append(line);
                textArea.append("\n");
            }
}

  
  }
  catch(Exception e)
  {
  	System.out.println(e);
  	System.exit(0);
  }
  
}




public static void main(String[] args) {

        SwingUtilities.invokeLater(new Runnable() {

            public void run() {
                CalculatorClient ex = new CalculatorClient();
                ex.setVisible(true);
            }
        });
    }
}













