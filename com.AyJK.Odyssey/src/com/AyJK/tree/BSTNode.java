package com.AyJK.tree;

/**
 * Clase en la que se crea el Nodo del BST.
 * 
 * @author LKJ
 * 
 * @param <T>
 */
public class BSTNode<T extends Comparable<T>> {

    /**
     * Variables de la clase.
     */
    private T data;
    private BSTNode<T> left;
    private BSTNode<T> right;

    /**
     * Constructor de la clase.
     * 
     * @param data:
     *            dato que recibirá el nodo del árbol.
     */
    public BSTNode(T data) {
	this.data = data;
	this.right = null;
	this.left = null;
    }

    /**
     * Constructor de la clase.
     * 
     * @param data:
     *            dato que se almacenara en el nodo.
     * @param left:
     *            nodo izquierdo del nuevo nodo.
     * @param right:
     *            nodo derecho del nuevo nodo.
     */
    public BSTNode(T data, BSTNode<T> left, BSTNode<T> right) {
	this.data = data;
	this.left = left;
	this.right = right;
    }

    /**
     * Getters y Setters de la clase.
     */
    public T getData() {
	return data;
    }

    public void setData(T data) {
	this.data = data;
    }

    public BSTNode<T> getRight() {
	return right;
    }

    public void setRight(BSTNode<T> right) {
	this.right = right;
    }

    public BSTNode<T> getLeft() {
	return left;
    }

    public void setLeft(BSTNode<T> left) {
	this.left = left;
    }
}