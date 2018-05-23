package com.AyJK.sort;

import com.AyJK.list.Node;
import com.AyJK.list.SimpleLL;

/**
 * Clase en la que se crea el método de ordenamiento BubbleSort.
 * 
 * @author LKJ
 *
 * @param <T>:
 *            Parámetro genérico del BubbleSort.
 */
public class BubbleSort<T extends Comparable<T>> {

    /**
     * Variables que serán utilizadas en la clase.
     */
    private T temp;

    /**
     * Constructor de la clase.
     */
    public BubbleSort() {
    }

    /**
     * Método que recibe como parámetro una lista simple que ordenará utilizando la
     * lógica del BubbleSort.
     * 
     * @param list:
     *            lista que se desear ordenar mediante BubbleSort.
     */
    public void bubbleSort(SimpleLL<T> list) {
	for (int i = 0; i < list.getSize() - 1; i++) {
	    Node<T> aux = list.getHead();
	    Node<T> next = list.getHead().getNext();
	    for (int j = 1; j < list.getSize() - 1; j++) {
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
     * Método que se encarga de mostrar en consola el arreglo.
     * 
     * @param list:
     *            arreglo que se desea imprimir.
     */
    public void printL(SimpleLL<T> list) {
	System.out.print("[");
	for (int i = 0; i < list.getSize() - 1; i++) {
	    System.out.print(list.getDatai(i) + ", ");
	}
	System.out.print(list.getDatai(list.getSize() - 1));
	System.out.print("]");
	System.out.println(" ");
    }
}
