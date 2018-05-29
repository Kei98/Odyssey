/**
 * 
 */
package com.AyJK.tree;

/**
 * Clase en la que se crea el nodo del árbol Splay.
 * 
 * @author LKJ
 *
 * @param <T>
 */
public class SplayNode<T extends Comparable<T>> {

    /**
     * Variables de la clase,
     */
    private T data;
    private SplayNode<T> left;
    private SplayNode<T> right;
    private SplayNode<T> parent;

    /**
     * Constructor de la clase.
     */
    public SplayNode() {
	this(null, null, null, null);
    }

    /**
     * Constructor de la clase.
     * 
     * @param data:
     *            elemento a ingresar al nodo.
     */
    public SplayNode(T data) {
	this(data, null, null, null);
    }

    /**
     * Constructor de la clase.
     * 
     * @param data:
     *            dato a ingresar al nodo.
     * @param left:
     *            nodo izquierdo del nuevo nodo.
     * @param right:
     *            nodo derecho del nuevo nodo.
     * @param parent:
     *            nodo padre del nuevo nodo.
     */
    public SplayNode(T data, SplayNode<T> left, SplayNode<T> right, SplayNode<T> parent) {
	this.left = left;
	this.right = right;
	this.parent = parent;
	this.data = data;
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

    public SplayNode<T> getLeft() {
	return left;
    }

    public void setLeft(SplayNode<T> left) {
	this.left = left;
    }

    public SplayNode<T> getRight() {
	return right;
    }

    public void setRight(SplayNode<T> right) {
	this.right = right;
    }

    public SplayNode<T> getParent() {
	return parent;
    }

    public void setParent(SplayNode<T> parent) {
	this.parent = parent;
    }
}