package com.AyJK.list;

import com.AyJK.tree.BTreeNode;


/**
 * Clase en la que se crea una lista simplemente enlazada y sus m�todos para
 * agregar, eliminar, buscar, imprimir.
 * 
 * @author LKJ
 *
 * @param <T>:
 *            Par�metro gen�rico de la lista.
 */
public class SimpleLL<T> {

    private Node<T> head;
    private int size;
    private int size2;
    private int count = 0;

    

    /**
     * Constructor de la clase.
     */
    public SimpleLL() {
	head = null;
	size = 0;
    }
    
    public SimpleLL(int size) {
    	this.size = size;
    	size2 = 0;
        }

    /**
     * M�todo para agregar un Nodo que recibe como par�metro el dato que desea
     * agregar.
     * 
     * @param data:
     *            dato que ser� agregado.
     * @return true: el dato ha sido agregado correctamente.
     * 
     */
    public boolean add(T data) {
    	if (this.size != 0 && count == 0) {
    		Node<T> node = new Node<T>(data);
    		if (size2 == 0) {
    			head = node;
    			size2++;
    		} else if (size2 < this.size) {
    			Node<T> temp = head;
    			while (temp.getNext() != null) {
    				temp = temp.getNext();
    			}
    			temp.setNext(node);
    			size2++;
    		}
    	} else {
    		count++;
    		Node<T> node = new Node<T>(data);
    		if (size == 0) {
    			head = node;
    			size++;
    		} else {
    			Node<T> temp = head;
    			while (temp.getNext() != null) {
    				temp = temp.getNext();
    			}
    			temp.setNext(node);
    			size++;
    		}
    	}
    	return true;
    }
    

    /**
     * Metodo que puede imprimir el o los nodos que han sido agregados en consola.
     * 
     */
    public void show() {
	int i = 0;
	if (size == 0) {
	    System.out.println("Empty");
	} else {
	    Node<T> temp = head;
	    while (temp.getNext() != null) {
		System.out.println("Node " + i + ": " + temp.getData());
		i++;
		temp = temp.getNext();
	    }
	    System.out.println("Node " + i + ": " + temp.getData());
	}
    }

    /**
     * Metodo para eliminar que recibe como par�metro el dato que se desea eliminar.
     * 
     * @param erase:
     *            dato a eliminar.
     */
    public void delete(T erase) {
	if (head.getData() == erase) {
	    head = head.getNext();
	} else {
	    Node<T> current = this.head;
	    while (current != null) {
		if (current.getNext().getData() == erase) {
		    current.setNext(current.getNext().getNext());
		    break;
		}
		current = current.getNext();
	    }
	}
    }

    // public T getData(int data) {
    // Node<T> temp = this.getHead();
    // int i = 0;
    // while (i != data) {
    // temp = temp.getNext();
    // i++;
    // }
    // return temp.getData();
    // }

    /**
     * M�todo que nos retorna un valor verdadero o falso si la lista est� o no
     * vac�a.
     * 
     * @return
     */
    public boolean isEmpty() {
    	return false;
    }

    /**
     * M�todo para obtener un dato en la posici�n deseada.
     * 
     * @param index:
     *            posici�n en la que se encuentra el dato que se desea obtener.
     * @return El dato deseado.
     */
    public T getDatai(int index) {
	Node<T> temp = this.getHead();
	while (index != 0) {
	    temp = temp.getNext();
	    index--;
	}
	return temp.getData();

    }
    
//    public BTreeNode<T> getDataiN(int index) {
//    	Node<T> temp = this.getHead();
//    	while (index != 0) {
//    	    temp = temp.getNext();
//    	    index--;
//    	}
//    	return ((Node<T>) temp).getNode();
//
//		
//	}

    /**
     * M�todo para insertar un valor en la posici�n indicada.
     * 
     * @param index:
     *            Posici�n en la cu�l se desea ingresar el valor.
     * @param value:
     *            Valor que ser� agregado.
     */
    public void setDatai(int index, T value) {
	Node<T> temp = this.getHead();
	while (index != 0) {
		if(temp != null) {
		    temp = temp.getNext();
		    index--;
		}else {
			System.out.println("No est� llegando");
		}
	}
	if(temp.getPrevious() != null || temp.getNext() != null && temp != this.getHead()) {
		temp.setData(value);
	}
	
	
    }
    
    public void setDatai(int index, BTreeNode<T> value) {
    	Node<T> temp = this.getHead();
    	while (index != 0) {
    	    temp = temp.getNext();
    	    index--;
    	}
    	temp.setNode(value);
        }
//    
//    public Node<T> getDataa(int index) {
//    	Node<T> temp = this.getHead();
//    	while (index != 1) {
//    	    temp = temp.getNext();
//    	    index--;
//    	}
//    	return temp.getList();
//        }

    /**
     * M�todo para limpiar la lista.
     */
    public void clear() {
	this.setHead(null);
	this.setSize(0);

    }

    /**
     * M�todo para eliminar un dato ingresando la posici�n en la que se encuentra.
     * 
     * @param i:
     *            Posici�n en la que se encuentra el dato a eliminar.
     */
    public void deleteValue(int i) {
	if (this.isEmpty()) {
	    System.out.println("There is no data to erase.");
	} else {
	    Node<T> temp = this.head;
	    if (i == 0) {
		this.head = this.head.getNext();
		size--;
	    } else if (i < size) {
		int j = 0;
		while ((i - 1) != j) {
		    temp = temp.getNext();
		    j++;
		}
		temp.setNext(temp.getNext().getNext());
		this.size--;
	    } else {
		System.out.println("The index was no found.");
	    }
	}
    }

    /**
     * M�todos get y set.
     * 
     * @param
     */
    public void setHead(Node<T> head) {
	this.head = head;
    }

    public void setSize(int size) {
	this.size = size;
    }

    public int getSize() {
	return size;
    }

    public Node<T> getHead() {
	return head;
    }

	
}
