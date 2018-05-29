
package com.AyJK.mapper;
import com.AyJK.server.*;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.util.Base64;



public class Mp3Mapper {
	
	 public static void main(String[] args) throws FileNotFoundException, IOException {
		 
		 Mp3toString("C:\\Users\\lucia\\Desktop\\BTS.mp3");
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
            String encode = Base64.getEncoder().encodeToString(bytesArray);
           //System.out.println(encode);
            

        } catch (IOException e) {
            e.printStackTrace();
        } 

        return bytesArray;

    }
	
	
	public static void StringtoMp3(String mp3) throws IOException {	
		
	    			
	}
	
	public static void play() {
		
		
	}


	
	      			
	
			
}