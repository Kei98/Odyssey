package com.AyJK.sort;

import java.util.Arrays;

import com.AyJK.list.SimpleLL;

public class RadixSort {

	private char lower = '$';
	private char upper = 'z';
	private int a;
	private String[] array = new String[a];

	public void radixSort(@SuppressWarnings("rawtypes") SimpleLL list) {

		String[] arr = new String[list.getSize()];
		for (int i = 0; i < list.getSize(); i++) {
			arr[i] = (String) list.getDatai(i);
		}

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

	
	
	public void countingSort(String[] arr, int index) {
		this.a = arr.length;
		int[] countArray = new int[(this.upper - this.lower) + 2];
		String[] tempArray = new String[arr.length];
		Arrays.fill(countArray, 0);

		// increase count for char at index
		for (int i = 0; i < arr.length; i++) {
			int charIndex = (arr[i].length() - 1 < index) ? 0 : ((arr[i].charAt(index) - lower) + 1);
			countArray[charIndex]++;
		}

		// sum up countArray;countArray will hold last index for the char at each
		// strings index
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
	}

	public void print() {
		for (int i = 0; i < this.array.length; i++) {
			System.out.println(array[i]);
		}
	}
}
