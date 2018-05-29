package com.AyJK.tree;

public class BTree<T extends Comparable<T>> {
	// orden del árbol
		static int order; 

		BTreeNode<T> root;  


		public BTree(int order)
		{
			BTree.order = order;

			root = new BTreeNode<>(order, null);

		}

		/*
		 * método para buscar el nodo donde se quiere insertar el valor
		 * retorna un nodo con el valor insertado
		 */


		public BTreeNode<T> search(BTreeNode<T> root, T key)
		{
			int i = 0;

			while(i < root.count && key.compareTo(root.key.getDatai(i)) > 0) 
	                    							  
					                    			  			{
				i++;
			}

			if(i <= root.count && key.equals(root.key.getDatai(i)))
			{


				return root;
			}

			if(root.leaf) 
			{

				return null ;

			}
			// si no es una hoja, entonces se mueve a los hijos
			else
			{

				return search(root.getChild(i), key);

			}
		}
		
		
		/*
		 * encargado de separar el nodo en el que se quiere insertar
		 */

		private void split(BTreeNode<T> x, int i, BTreeNode<T> y)
		{
			//nodo extra
			BTreeNode<T> z = new BTreeNode<T>(order,null); 

			z.leaf = y.leaf;
			// tamaño de la lista
			z.count = order - 1;

			for(int j = 0; j < order - 1; j++)
			{
				z.key.setDatai(j, y.key.getDatai(j+1)); 

			}
			// si no es una hoja, se reasignan los nodos hijos
			if(!y.leaf)
			{
				for(int k = 0; k < order; k++)
				{
					z.child.setDatai(k, y.child.getDatai(k + order)); 
				}
			}
			// nueva medida de y
			y.count = order - 1; 

			for(int j = x.count ; j> i ; j--)
			{				 

				x.child.setDatai(j+1, x.child.getDatai(j));  
			}
			x.child.setDatai(i+1, z);  
			
			for(int j = x.count; j> i; j--)
			{
				// se intercambian valores
				x.key.setDatai(j+1, x.key.getDatai(j)); 
			}
			// se pone el valor en la raíz
			x.key.setDatai(i, y.key.getDatai(order-1)); 
			// se borra el valor de donde se copió
			y.key.setDatai(order -1, (T) null); 
			
			for(int j = 0; j < order - 1; j++)
			{
				// se borran los valores anteriores
				y.key.setDatai(j + order, (T) null); 
			}


			// 
			x.count ++;  
		}

	/*
	 * método para insertar mientras que el nodo no esté lleno
	 */
//		public void nonfullInsert(T key) {
//			nonfullInsert(this.root, key);
//			
//			
//			
//		}
		private void nonfullInsert(BTreeNode<T> x, T key)
		{
			int i = x.count; 

			if(x.leaf)
			{
				// se busca el lugar donde colocar el valor
				while(i >= 1 && key.compareTo(x.key.getDatai(i-1)) < 0)
				{
					// se cambian los valores para hacer espacio
					x.key.setDatai(i, x.key.getDatai(i-1)); 

					i--;
				}
				// se asigna el valor al nodo
				x.key.setDatai(i, key); 
				x.count ++; 
			}


			else
			{
				int j = 0;
				while(j < x.count  && key.compareTo(x.key.getDatai(j)) > 0) 
				{			             
					j++;
				}
				
				BTreeNode<T> temp = (BTreeNode<T>) x.child.getDataiN(j);
				if(temp.count == order*2 - 1)
				{
					split(x,j,(BTreeNode<T>) x.child.getDataiN(j)); 

					if(key.compareTo(x.key.getDatai(j)) > 0)
					{
						j++;
					}
				}

				nonfullInsert((BTreeNode<T>) x.child.getDataiN(j) ,key);
			}
		}
		public void insert(T key) {
			insert(this, key);
		}
		private void insert(BTree<T> t, T key)
		{
			BTreeNode<T> r = t.root;
			if(r.count == 2*order - 1)
			{
				BTreeNode<T> s = new BTreeNode<T>(order,null);

				t.root = s;   	
				s.leaf = false;
				s.count = 0;   
				s.child.setDatai(0, r); 
				split(s,0,r);

				nonfullInsert(s, key); 
			}
			else
				nonfullInsert(r,key);
		}

	


		public void print(BTreeNode<T> n)
		{
			for(int i = 0; i < n.count; i++)
			{
				System.out.print(n.getValue(i)+" " );
			}

			if(!n.leaf)
			{

				for(int j = 0; j <= n.count  ; j++)
				{				  
					if(n.getChild(j) != null)
					{			 
					System.out.println();	 
					print(n.getChild(j));    
					}
				}
			}
		}


		public void SearchPrintNode(BTree<T> t,T x)
		{
			BTreeNode<T> temp= new BTreeNode<T>(order,null);

			temp= search(t.root,x);

			if (temp==null)
			{

			System.out.println("The Key does not exist in this tree");
			}

			else
			{

			print(temp);
			}


		}

		public void deleteKey(T key) {
			deleteKey(this, key);
		}
		
		private void deleteKey(BTree<T> t, T key)
		{

			BTreeNode<T> temp = new BTreeNode<T>(order,null);
			temp = search(t.root,key);
			if(temp.leaf && temp.count > order - 1)
			{
				int i = 0;

				while( key.compareTo(temp.getValue(i)) > 0)
				{
					i++;
				}
				for(int j = i; j < 2*order - 2; j++)
				{
					temp.key.setDatai(j, temp.getValue(j+1)); 
				}
				temp.count --;

			}
			else
			{
				System.out.println("This node is either not a leaf or has less than order - 1 keys.");
			}
		}
}
