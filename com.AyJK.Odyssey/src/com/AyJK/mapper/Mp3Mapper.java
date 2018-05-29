
package com.AyJK.mapper;
import com.AyJK.server.*;


import java.io.FileInputStream;
import java.util.Base64;


import java.io.File;
import java.io.FileNotFoundException;
import java.io.IOException;





public class Mp3Mapper {
	
	public static void main(String[] args) throws FileNotFoundException, IOException {
		
		//Mp3toString("C:\\Users\\HP\\Desktop\\EPICA - Storm The Sorrow (OFFICIAL VIDEO).mp3");
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
			System.out.println(encode);
           //System.out.println(encode);
            


		} catch (IOException e) {
			e.printStackTrace();
		} 

		return bytesArray;

    }
	
	
	public static void play() {
		
	}

}

//	 public static void main(String[] args) {
//		 try{
//
//			 FileInputStream fis = new FileInputStream("C:\\Users\\HP\\Desktop\\EPICA - Storm The Sorrow (OFFICIAL VIDEO).mp3");
//			 Player playMP3 = new Player(fis);
//
//			 playMP3.play();
//
//		 }  catch(Exception e){
//			 System.out.println(e);
//		 }
//	 } 
		 
//		 String songName = "EPICA - Storm The Sorrow (OFFICIAL VIDEO).mp3";
//		 String pathToMp3 = System.getProperty("C:\\Users\\HP\\Desktop") +"/"+ songName;
//		 BasicPlayer player = new BasicPlayer();
//		 try {
//		     player.open(new URL("file:///" + pathToMp3));
//		     player.play();
//		 } catch (BasicPlayerException | MalformedURLException e) {
//		     e.printStackTrace();
//		 }
	 
	 
//	 public static void testPlay(String mp3) {
//		    try {
//		        File file = new File(mp3);
//		        AudioInputStream in = AudioSystem.getAudioInputStream(file);
//		        AudioInputStream din = null;
//		        AudioFormat baseFormat = in.getFormat();
//		        AudioFormat decodedFormat = new AudioFormat(AudioFormat.Encoding.PCM_SIGNED,
//		                baseFormat.getSampleRate(),
//		                16,
//		                baseFormat.getChannels(),
//		                baseFormat.getChannels() * 2,
//		                baseFormat.getSampleRate(),
//		                false);
//		        din = AudioSystem.getAudioInputStream(decodedFormat, in);
//
//		        play(decodedFormat, din);
//		        //spi(decodedFormat, in);
//		        in.close();
//		    } catch (Exception e) {
//		        System.out.println("MP3");
//		    }
//
//		}
//
//		private static void play(AudioFormat targetFormat, AudioInputStream din) throws IOException, LineUnavailableException {
//
//		    ByteArrayOutputStream out = new ByteArrayOutputStream();
//		    byte[] data = new byte[4096];
//		   // SourceDataLine line = getLine(targetFormat);
//
//		        int nBytesRead = 0, nBytesWritten = 0;
//		        while (nBytesRead != -1) {
//		            nBytesRead = din.read(data, 0, data.length);
//		            if (nBytesRead != -1) {
//		                //nBytesWritten = line.write(data, 0, nBytesRead);
//		                out.write(data, 0, nBytesRead);
//		                
//		            }
//
//		        }
//
//		       byte[] audio = out.toByteArray();
//
//		}
	
//}

