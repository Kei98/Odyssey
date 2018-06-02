package com.AyJK.server;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import java.net.ServerSocket;
import java.net.Socket;
/**
 * 
 * @author AyJK
 * Servidor, crea un socket para recibir al cliente
 *
 */
public class Server implements Runnable {
	
	
	@Override
	public void run() {
		try {
			
			@SuppressWarnings("resource")
			ServerSocket server = new ServerSocket(12000);
			while(true) {
				System.out.println("Esperando....");
				Socket socket= server.accept();
				System.out.println("Recibido");
				BufferedReader entrada = new BufferedReader(new InputStreamReader(socket.getInputStream()));
				String texto= entrada.readLine();
				System.out.println(texto);
				socket.close();
			}
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
	
	public void send() {
		try {
			@SuppressWarnings({ "unused", "resource" })
			ServerSocket server = new ServerSocket(13000);
			while(true) {
				
			}
		}catch(IOException e){
			
		}
	}
	
	
}

