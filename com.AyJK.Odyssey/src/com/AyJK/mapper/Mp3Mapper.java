
package com.AyJK.mapper;
import com.AyJK.server.*;

//
//import javazoom.jlgui.basicplayer.BasicPlayer;
//import javazoom.jlgui.basicplayer.BasicPlayerException;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
//import java.net.MalformedURLException;
//import java.net.URL;
import java.util.Base64;



public class Mp3Mapper {
	
	 public static void main(String[] args) throws FileNotFoundException, IOException {
		 
		 Mp3toString("C:\\Users\\HP\\Desktop\\STS.mp3");
		 (new Thread(new Server())).start();
		 
	 }
	

		
	public static byte[] Mp3toString(String mp3) throws IOException {	
		FileInputStream fis = null;
        byte[] bytesArray = null;

        try {
            File file = new File(mp3);
            bytesArray = new byte[(int) file.length()];

            //read file into bytes[]
            fis = new FileInputStream(file);
            fis.read(bytesArray);
            fis.close();
            @SuppressWarnings("unused")
			String encode = Base64.getEncoder().encodeToString(bytesArray);
           //System.out.println(encode);
//            play(encode);
            

        } catch (IOException e) {
            e.printStackTrace();
        } 

        return bytesArray;

    }
	
	
//	public static void play(String music) {
//		String pathToMp3 = System.getProperty(music);
//		BasicPlayer player = new BasicPlayer();
//		try {
//			player.open(new URL("file:///" + pathToMp3));
//			player.play();
//			
//		} catch (BasicPlayerException | MalformedURLException e) {
//			e.printStackTrace();
//		}
//
//		
//	}
	
	public static void tusMuertos(String music) {
		
	System.out.println("me cag*");	
		
	}


	
	      			
	
			
}