package com.AyJK.tree;

//import com.AyJK.list.SimpleLL;

public class BTreeNode<T> {
	static int t_order; 

	int count; 
	
	String key[];  

	BTreeNode<T> child[]; 

	boolean leaf; 

	BTreeNode<T> parent;  



	public BTreeNode()
	{}


	@SuppressWarnings({ "unchecked", "static-access" })
	public BTreeNode(int t, BTreeNode<T> parent)
	{
		this.t_order = t;
		
		this.parent = parent;

		key = new String[2*t-1];  

		child = new BTreeNode[2*t]; 

		leaf = true; 
		
		count = 0; 
	}



	public String getValue(int index)
	{
		return key[index];
	}


	public BTreeNode<T> getChild(int index)
	{
		return child[index];
	}
}
