/**
 * 
 */
package com.AyJK.tree;

/**
 * Clase en la que se crea el árbol Splay y sus métodos tales como insertar,
 * eliminar entre otros.
 * 
 * @author LKJ
 *
 * @param <T>
 */
public class SplayTree<T extends Comparable<T>> {

    /**
     * Variables de la clase.
     */
    private SplayNode<T> root;
    private int count = 0;

    /**
     * Constructor de la clase.
     */
    public SplayTree() {
	root = null;
    }

    /**
     * Método que se encarga de recibir un dato a ingresar al árbol.
     * 
     * @param data
     */
    public void insertSplay(T data) {
	SplayNode<T> k = root;
	SplayNode<T> l = null;
	while (k != null) {
	    l = k;
	    if (data.compareTo(l.getData()) < 0) {
		k = k.getRight();
	    } else {
		k = k.getLeft();
	    }
	}
	k = new SplayNode<>();
	k.setData(data);
	k.setParent(l);
	if (l == null) {
	    root = k;
	} else if (data.compareTo(l.getData()) < 0) {
	    l.setRight(k);
	} else {
	    l.setLeft(k);
	}
	splay(k);
	count++;
    }

    /**
     * Método que se encarga de realizar rotaciones zig en el árbol.
     * 
     * @param c:
     *            nodo hijo.
     * @param p:
     *            nodo padre.
     */
    public void zigRotation(SplayNode<T> c, SplayNode<T> p) {
	if ((c == null) || (p == null) || (p.getLeft() != c) || (c.getParent() != p)) {
	    throw new RuntimeException("WRONG");
	}
	if (p.getParent() != null) {
	    if (p == p.getParent().getLeft()) {
		p.getParent().setLeft(c);
	    } else {
		p.getParent().setRight(c);
	    }
	}
	if (c.getRight() != null) {
	    c.getRight().setParent(p);
	}

	c.setParent(p.getParent());
	p.setParent(c);
	p.setLeft(c.getRight());
	c.setRight(p);
    }

    /**
     * Método que se encarga de realizar rotaciones zag en el árbol.
     * 
     * @param c:
     *            nodo hijo.
     * @param p:
     *            nodo padre.
     */
    public void zagRotation(SplayNode<T> c, SplayNode<T> p) {
	if ((c == null) || (p == null) || (p.getRight() != c) || (c.getParent() != p)) {
	    throw new RuntimeException("WRONG");
	}
	if (p.getParent() != null) {
	    if (p == p.getParent().getLeft()) {
		p.getParent().setLeft(c);
	    } else {
		p.getParent().setRight(c);
	    }
	}
	if (c.getLeft() != null) {
	    c.getLeft().setParent(p);
	}

	c.setParent(p.getParent());
	p.setParent(c);
	p.setRight(c.getLeft());
	c.setLeft(p);
    }

    /**
     * Método que se encarga de establecer un nuevo nodo raíz.
     * 
     * @param x:
     *            nodo que será la raíz.
     */
    private void splay(SplayNode<T> x) {
	while (x.getParent() != null) {
	    SplayNode<T> Parent = x.getParent();
	    SplayNode<T> GrandParent = Parent.getParent();
	    if (GrandParent == null) {
		if (x == Parent.getLeft()) {
		    zigRotation(x, Parent);
		} else {
		    zagRotation(x, Parent);
		}
	    } else {
		if (x == Parent.getLeft()) {
		    if (Parent == GrandParent.getLeft()) {
			zigRotation(Parent, GrandParent);
			zigRotation(x, Parent);
		    } else {
			zigRotation(x, x.getParent());
			zagRotation(x, x.getParent());
		    }
		} else {
		    if (Parent == GrandParent.getLeft()) {
			zagRotation(x, x.getParent());
			zigRotation(x, x.getParent());
		    } else {
			zagRotation(Parent, GrandParent);
			zagRotation(x, Parent);
		    }
		}
	    }
	}
	root = x;
    }

    /**
     * Método que se encarga de recibir un dato a eliminar.
     * 
     * @param data:
     *            dato a eliminar del árbol.
     */
    public void deleteSplay(T data) {
	SplayNode<T> node = findNode(data);
	deleteSplay(node);
    }

    /**
     * Método que se encarga de recibir un nodo a eliminar.
     * 
     * @param node:
     *            nodo a eliminar del árbol.
     */
    private void deleteSplay(SplayNode<T> node) {
	if (node == null) {
	    return;
	}
	splay(node);
	if ((node.getLeft() != null) && (node.getRight() != null)) {
	    SplayNode<T> y = node.getLeft();
	    while (y.getRight() != null) {
		y = y.getRight();
	    }
	    y.setRight(node.getRight());
	    node.getRight().setParent(y);
	    node.getLeft().setParent(null);
	    root = node.getLeft();
	} else if (node.getRight() != null) {
	    node.getRight().setParent(null);
	    root = node.getRight();
	} else if (node.getLeft() != null) {
	    node.getLeft().setParent(null);
	    root = node.getLeft();
	} else {
	    root = null;
	}
	node.setParent(null);
	node.setLeft(null);
	node.setRight(null);
	node = null;
	count--;
    }

    /**
     * Método que se encarga de contar la cantidad de nodos.
     * 
     * @return
     */
    public int countNodes() {
	System.out.println("La cantidad de nodos es: " + count);
	return count;
    }

    /**
     * Método que se encarga de recibir un valor a buscar en el árbol.
     * 
     * @param data:
     *            dato a buscar en el árbol.
     * @return
     */
    public boolean search(T data) {
	return findNode(data) != null;
    }

    /**
     * Método que se encarga de buscar un dato en el árbol.
     * 
     * @param data:
     *            dato a buscar en el árbol.
     * @return
     */
    private SplayNode<T> findNode(T data) {
	SplayNode<T> j = root;
	while (j != null) {
	    if (data.compareTo(j.getData()) < 0) {
		j = j.getRight();
	    } else if (data.compareTo(j.getData()) > 0) {
		j = j.getLeft();
	    } else {
		return j;
	    }
	}
	return null;
    }

    /**
     * Método que se encarga de verificar si el árbol está vacío.
     * 
     * @return
     */
    public boolean isEmpty() {
	return root == null;
    }

    /**
     * Método que se encarga de limpiar el árbol.
     */
    public void clear() {
	root = null;
    }

    /**
     * 
     */
    public void inOrder() {
	inOrder(root);
    }

    /**
     * 
     * @param r
     */
    private void inOrder(SplayNode<T> r) {
	if (r != null) {
	    inOrder(r.getLeft());
	    System.out.print(r.getData() + " ");
	    inOrder(r.getRight());
	}
    }

    /**
     * 
     */
    public void preOrder() {
	preOrder(root);
    }

    /**
     * 
     * @param r
     */
    private void preOrder(SplayNode<T> r) {
	if (r != null) {
	    System.out.print(r.getData() + " ");
	    preOrder(r.getLeft());
	    preOrder(r.getRight());
	}
    }

    /**
     * 
     */
    public void postOrder() {
	postOrder(root);
    }

    /**
     * 
     * @param r
     */
    private void postOrder(SplayNode<T> r) {
	if (r != null) {
	    postOrder(r.getLeft());
	    postOrder(r.getRight());
	    System.out.print(r.getData() + " ");
	}
    }
}
