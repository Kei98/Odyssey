package com.AyJK.server;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import java.net.ServerSocket;
import java.net.Socket;

public class Server implements Runnable {
	
	@Override
	public void run() {
		try {
			//se un socket para recibir al cliente 
			@SuppressWarnings("resource")
			ServerSocket server = new ServerSocket(23000);
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
}

