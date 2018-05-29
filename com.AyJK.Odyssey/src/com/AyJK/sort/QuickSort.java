package com.AyJK.sort;

import com.AyJK.list.SimpleLL;

/**
 * Clase en la que se crea el método de ordenamiento QuickSort.
 * 
 * @author LKJ
 *
 * @param <T>:
 *            Parámetro genérico del QuickSort.
 */
public class QuickSort<T extends Comparable<T>> {

    /**
     * Variables que serán utilizadas en la clase.
     */
    private int i;
    private int j;
    private T pivot;
    private T temp;

    /**
     * Constructor de la clase.
     */
    public QuickSort() {
    }

    /**
     * Método que se encarga de ordenar una lista utilizando la lógica del metodo de
     * ordenamiento QuickSort.
     * 
     * @param array:
     *            arreglo al cual se le desea ordenar mediante el método QuickSort.
     */
    public void quickSort(SimpleLL<T> array) {
	quickSort(array, 0, array.getSize() - 1);
    }

    /**
     * Método que se encarga de ordenar un arreglo de la forma QuickSort.
     * 
     * @param array:
     *            arreglo que se desea ordenar.
     * @param first:
     *            primera pocisión en el arreglo.
     * @param last:
     *            última posición en el arreglo.
     */
    private void quickSort(SimpleLL<T> array, int first, int last) {
	i = first;
	j = last;
	pivot = array.getDatai((int) ((i + j) / 2));

	do {
	    while (array.getDatai(i).compareTo(pivot) < 0) {
		i++;
	    }
	    while (array.getDatai(j).compareTo(pivot) > 0) {
		j--;
	    }
	    if (i <= j) {
		temp = array.getDatai(i);
		array.setDatai(i, array.getDatai(j));
		array.setDatai(j, temp);
		i++;
		j--;
	    }
	} while (i <= j);
	if (first < j) {
	    quickSort(array, first, j);
	}
	if (i < last) {
	    quickSort(array, i, last);
	}
    }

    /**
     * Método que se encarga de mostrar en consola el arreglo.
     * 
     * @param array:
     *            arreglo que se desea imprimir en consola.
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