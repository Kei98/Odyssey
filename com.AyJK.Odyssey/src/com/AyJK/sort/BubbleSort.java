package com.AyJK.sort;

import com.AyJK.list.Node;
import com.AyJK.list.SimpleLL;

/**
 * Clase en la que se crea el m�todo de ordenamiento BubbleSort.
 * 
 * @author LKJ
 *
 * @param <T>:
 *            Par�metro gen�rico del BubbleSort.
 */
public class BubbleSort<T extends Comparable<T>> {

    /**
     * Variables que ser�n utilizadas en la clase.
     */
    private T temp;

    /**
     * Constructor de la clase.
     */
    public BubbleSort() {
    }

    /**
     * M�todo que recibe como par�metro una lista simple que ordenar� utilizando la
     * l�gica del BubbleSort.
     * 
     * @param array:
     *            lista que se desear ordenar mediante BubbleSort.
     */
    public void bubbleSort(SimpleLL<T> array) {
	for (int i = 0; i < array.getSize() - 1; i++) {
	    Node<T> aux = array.getHead();
	    Node<T> next = array.getHead().getNext();
	    for (int j = 1; j < array.getSize() - 1; j++) {
		if (aux.getData().compareTo(next.getData()) > 0) {
		    temp = aux.getData();
		    aux.setData(next.getData());
		    next.setData(temp);
		}
		aux = next;
		next = next.getNext();
	    }
	}
    }

    /**
     * M�todo que se encarga de mostrar en consola el arreglo.
     * 
     * @param array:
     *            arreglo que se desea imprimir.
     */
    public void printL(SimpleLL<T> array) {
	System.out.print("[");
	for (int i = 0; i < array.getSize() - 1; i++) {
	    System.out.print(array.getDatai(i) + ", ");
	}
	System.out.print(array.getDatai(array.getSize() - 1));
	System.out.print("]");
	System.out.println(" ");
    }
}
