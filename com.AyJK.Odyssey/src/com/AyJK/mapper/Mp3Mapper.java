
package com.AyJK.mapper;

//import java.io.FileInputStream;
//import java.net.MalformedURLException;
//import java.net.URL;
//
//import javazoom.jlgui.basicplayer.BasicPlayer;
//import javazoom.jlgui.basicplayer.BasicPlayerException;

//import javazoom.jl.player.Player;

//import java.io.ByteArrayOutputStream;
//import java.io.File;
//import java.io.FileInputStream;
//import java.io.FileNotFoundException;
//import java.io.FileOutputStream;
//import java.io.IOException;
//import javax.sound.sampled.AudioFormat;
//import javax.sound.sampled.AudioInputStream;
//import javax.sound.sampled.AudioSystem;
//import javax.sound.sampled.LineUnavailableException;




public class Mp3Mapper {
//	 public static void main(String[] args) throws FileNotFoundException, IOException {
//	        File file = new File("C:\\Users\\lucia\\Desktop\\BTS.mp3");
//	 
//	        FileInputStream fis = new FileInputStream(file);
//	        //System.out.println(file.exists() + "!!");
//	        //InputStream in = resource.openStream();
//	        ByteArrayOutputStream bos = new ByteArrayOutputStream();
//	        byte[] buf = new byte[1024];
//	        try {
//	            for (int readNum; (readNum = fis.read(buf)) != -1;) {
//	                bos.write(buf, 0, readNum); //no doubt here is 0,
//	                //Writes len bytes from the specified byte array starting at offset off to this byte array output stream.
//	                System.out.println("read " + readNum + " bytes,");
//	                System.out.println(bos.toByteArray());
//	            }
//	        } catch (IOException ex) {
//	           System.out.println("Pos catch");
//	        }
//	        byte[] bytes = bos.toByteArray();
//	 
//	        //below is the different part
//	        File someFile = new File("java2.pdf");
//	        FileOutputStream fos = new FileOutputStream(someFile);
//	        fos.write(bytes);
//	        fos.flush();
//	        fos.close();
	        //https://stackoverflow.com/questions/4280535/java-mp3-inputstream-to-byte-array
	        //https://stackoverflow.com/questions/8316018/java-mp3-decoding-and-storing-it-to-an-array-of-bytes
	        //audio format audio input stream method undefined
	        //https://stackoverflow.com/questions/10591852/how-to-cast-from-inputstream-to-audioinputstream
	        //https://www.programcreek.com/java-api-examples/?class=javax.sound.sampled.AudioSystem&method=getLine
	        //mp3 mapper with org.farng.mp3.*
//	 }
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
	 }
	 
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
