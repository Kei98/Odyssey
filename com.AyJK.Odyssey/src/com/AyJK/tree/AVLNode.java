package com.AyJK.tree;

/**
 * Clase en la que se crea el Nodo del �rbol AVL.
 * 
 * @author LKJ
 *
 * @param <T>
 */
public class AVLNode<T extends Comparable<T>> implements Comparable<AVLNode<T>> {

    /**
     * Variables de la clase.
     */
    private T data;
    private AVLNode<T> left;
    private AVLNode<T> right;
    public int level;
    private int depth;

    /**
     * Constructor de la clase.
     * 
     * @param data:
     *            dato que recibir� el nodo del �rbol.
     */
    public AVLNode(T data) {
	this(data, null, null);
    }

    /**
     * M�todo que se encarga de agregar un nuevo nodo al �rbol en conjunto con su
     * dato y los nodos izquierdo y derecho que tendr�.
     * 
     * @param data:
     *            dato a ingresar.
     * @param left:
     *            nodo derecho del nuevo nodo.
     * @param right:
     *            nodo izquierdo del nuevo nodo.
     */
    public AVLNode(T data, AVLNode<T> left, AVLNode<T> right) {
	super();
	this.data = data;
	this.left = left;
	this.right = right;

	if (left == null && right == null) {
	    setDepth(1);
	} else if (left == null) {
	    setDepth(right.getDepth() + 1);
	} else if (right == null) {
	    setDepth(left.getDepth() + 1);
	} else {
	    setDepth(Math.max(left.getDepth(), right.getDepth()) + 1);
	}
    }

    /**
     * 
     */
    @Override
    public int compareTo(AVLNode<T> o) {
	return 0;
    }

    /**
     * 
     */
    @Override
    public String toString() {
	return "Level " + level + ": " + data;
    }

    /**
     * Getters y Setters de la clase.
     * 
     * @return
     */
    public T getData() {
	return data;
    }

    public void setData(T data) {
	this.data = data;
    }

    public AVLNode<T> getLeft() {
	return left;
    }

    public void setLeft(AVLNode<T> left) {
	this.left = left;
    }

    public AVLNode<T> getRight() {
	return right;
    }

    public void setRight(AVLNode<T> right) {
	this.right = right;
    }

    public int getDepth() {
	return depth;
    }

    public void setDepth(int depth) {
	this.depth = depth;
    }
}