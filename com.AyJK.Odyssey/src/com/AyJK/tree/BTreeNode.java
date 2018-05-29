package com.AyJK.tree;

import com.AyJK.list.SimpleLL;

public class BTreeNode<T> {
	static int t_order; 

	int count; 
	SimpleLL<T> key;  

	SimpleLL<T> child; 

	boolean leaf; 

	BTreeNode<T> parent;  



	public BTreeNode()
	{}


	public BTreeNode(int t, BTreeNode<T> parent)
	{
		BTreeNode.t_order = t;  
		this.parent = parent;

		key = new SimpleLL<>();  

		child = new SimpleLL<>(); 

		leaf = true; 
		count = 0; 
	}



	public T getValue(int index)
	{
		return (T) key.getDatai(index);
	}


	@SuppressWarnings("unchecked")
	public BTreeNode<T> getChild(int index)
	{
		return (BTreeNode<T>) child.getDatai(index);
	}
}
