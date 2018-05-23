package com.AyJK.list;

/**
 * Clase en la que se crea el nodo y sus métodos para ser utilizados en la
 * creación de listas de diferente comportamiento.
 * 
 * @author LKJ
 *
 * @param <T>:
 *            Parámetro genérico del nodo.
 */
public class Node<T> {

    /**
     * Variables que serán utilizadas en la clase.
     */
    private Node<T> next;
    private Node<T> previous;
    private T data;

    /**
     * Constructor de la clase.
     * 
     * @param data:
     *            dato que se almacenará en el nodo.
     */
    public Node(T data) {
	this.data = data;
	this.next = null;
	this.previous = null;
    }

    /**
     * Getters y Setters de la clase
     *
     */
    public Node<T> getNext() {
	return next;
    }

    public void setNext(Node<T> next) {
	this.next = next;
    }

    public Node<T> getPrevious() {
	return previous;
    }

    public void setPrevious(Node<T> previous) {
	this.previous = previous;
    }

    public T getData() {
	return data;
    }

    public void setData(T data) {
	this.data = data;
    }
}