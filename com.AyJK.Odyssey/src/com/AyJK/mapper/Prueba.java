package com.AyJK.mapper;

import java.io.File;
import java.io.IOException;

import com.fasterxml.jackson.core.JsonGenerationException;
import com.fasterxml.jackson.databind.JsonMappingException;
import com.fasterxml.jackson.databind.ObjectMapper;

public class Prueba {

    public static void main(String[] args) throws JsonGenerationException, JsonMappingException, IOException {

	POJOCancion canciones = new POJOCancion();

	canciones.setAlbum("One-X");
	canciones.setArtist("Three Days Grace");
	canciones.setGenre("Ni idea");
	canciones.setLength(249);
	canciones.setName("It's All Over");

	ObjectMapper mapper = new ObjectMapper();

	mapper.writeValue(new File("jkl.json"), canciones);

    }
}