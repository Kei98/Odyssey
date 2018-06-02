package com.AyJK.sort;

import java.util.Arrays;

import com.AyJK.list.SimpleLL;

public class RadixSort {
/*
 * variables de la clase
 */
	private char lower = '$';
	private char upper = 'z';
	private int a;
	@SuppressWarnings("unused")
	private String[] array = new String[a];
	private SimpleLL<String> list1 = new SimpleLL<String>();

	/*
	 * Método recibe una lista simple y crea un array de string donde guarda los valores de la lista
	 */
	public void radixSort(@SuppressWarnings("rawtypes") SimpleLL list) {

		String[] arr = new String[list.getSize()];
		for (int i = 0; i < list.getSize(); i++) {
			arr[i] = (String) list.getDatai(i);
		}
	/*
	 *Se toma la longitud de los strings en la lista y se comparan con la variable maxIndex
	 *para así sacar de cuánto es el string más largo 
	 */
		int maxIndex = 0;
		for (int i = 0; i < arr.length; i++) {
			if (arr[i].length() - 1 > maxIndex) {
				maxIndex = arr[i].length() - 1;
			}
		}

		for (int i = maxIndex; i >= 0; i--) {
			countingSort(arr, i);
		}
	}
	
	/*
	 *Método recibe un array y un índice que le indica desde donde se empieza a ordenar 
	 */
	
	public void countingSort(String[] arr, int index) {
		this.a = arr.length;
		int[] countArray = new int[(this.upper - this.lower) + 2];
		String[] tempArray = new String[arr.length];
		Arrays.fill(countArray, 0);

		// se incrementa el contador para el caracter en el índice indicado
		for (int i = 0; i < arr.length; i++) {
			int charIndex = (arr[i].length() - 1 < index) ? 0 : ((arr[i].charAt(index) - lower) + 1);
			countArray[charIndex]++;
		}

		// countArray guarda el valor de la última posición del largo de los strings 
		for (int i = 1; i < countArray.length; i++) {
			countArray[i] += countArray[i - 1];
		}

		for (int i = arr.length - 1; i >= 0; i--) {
			int charIndex = (arr[i].length() - 1 < index) ? 0 : (arr[i].charAt(index) - lower) + 1;
			tempArray[countArray[charIndex] - 1] = arr[i];
			countArray[charIndex]--;
		}

		for (int i = 0; i < tempArray.length; i++) {
			arr[i] = tempArray[i];
		}
		
		this.array = arr;
		
		for (int i = 0; i < arr.length; i++) {
			list1.setDatai(i, arr[i]);
		}
	}
	/*
	 * Método para imprimir la lista ordenada
	 */
	
	public void print() {
		for (int i = 0; i < this.list1.getSize(); i++) {
			System.out.println(list1.getDatai(i));
		}
	}
}
