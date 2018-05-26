package com.AyJK.mapper;

import static org.junit.Assert.assertNotNull;
import static org.junit.Assert.assertTrue;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;

import org.junit.jupiter.api.Test;

import com.fasterxml.jackson.dataformat.xml.XmlMapper;

public class SimpleBean {
	
	
	private String Artista = "BTS";
	private String Cancion = "Fire";

	public String getArtista() {
		return Artista;
	}


	public void setArtista(String artista) {
		Artista = artista;
	}


	public String getCancion() {
		return Cancion;
	}


	public void setCancion(String cancion) {
		Cancion = cancion;
	}


	public SimpleBean(){

	}

	//objetos a xml, funca B)
	@Test
	public void whenJavaSerializedToXmlFile_thenCorrect() throws IOException {
		XmlMapper xmlMapper = new XmlMapper();
		xmlMapper.writeValue(new File("sb.xml"), new SimpleBean());
		xmlMapper.writerWithDefaultPrettyPrinter();
		File file = new File("sb.xml");
		assertNotNull(file);
	}
	
	//xml a objetos, funca B)
	@Test
	public void whenJavaGotFromXmlFile_thenCorrect() throws IOException {
	    File file = new File("sb.xml");
	    XmlMapper xmlMapper = new XmlMapper();
	    String xml = inputStreamToString(new FileInputStream(file));
	    SimpleBean value = xmlMapper.readValue(xml, SimpleBean.class);
	    assertTrue(value.getArtista() == "BTS" && value.getCancion() == "Fire");
	}
	
	
	public static String inputStreamToString(InputStream is) throws IOException {
	    StringBuilder sb = new StringBuilder();
	    String line;
	    BufferedReader br = new BufferedReader(new InputStreamReader(is));
	    while ((line = br.readLine()) != null) {
	        sb.append(line);
	    }
	    br.close();
	    return sb.toString();
	}

}
