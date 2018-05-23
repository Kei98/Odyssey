package com.AyJK.tree;

import com.AyJK.list.SimpleLL;

public class BTreeNode<T> {
	static int t_order;  //variable to determine order of tree

	int count; // number of keys in node

	SimpleLL<T> key;  // array of key values

	SimpleLL<T> child; //array of references

	boolean leaf; //is node a leaf or not

	BTreeNode<T> parent;  //parent of current node.

// ----------------------------------------------------
// this will be default constructor for new node      |
// ----------------------------------------------------

	public BTreeNode()
	{}
// ----------------------------------------------------
// initial value constructor for new node             |
// will be called from BTree.java                     |
// ----------------------------------------------------

	public BTreeNode(int t, BTreeNode<T> parent)
	{
		BTreeNode.t_order = t;  //assign size

		this.parent = parent; //assign parent

		key = new SimpleLL<>();  // array of proper size

		child = new SimpleLL<>(); // array of refs proper size

		leaf = true; // everynode is leaf at first;

		count = 0; //until we add keys later.
	}

// -----------------------------------------------------
// this is method to return key value at index position|
// -----------------------------------------------------

	public T getValue(int index)
	{
		return (T) key.getDatai(index);
	}

// ----------------------------------------------------
// this is method to get ith child of node            |
// ----------------------------------------------------

	@SuppressWarnings("unchecked")
	public BTreeNode<T> getChild(int index)
	{
		return (BTreeNode<T>) child.getDatai(index);
	}
}
