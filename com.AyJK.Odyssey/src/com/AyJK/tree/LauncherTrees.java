/**
 * 
 */
package com.AyJK.tree;

/**
 * @author LKJ
 *
 */
public class LauncherTrees {

    public static <T> void main(String[] args) {
    	
    	BTree tree = new BTree<>(5);
    	tree.insert(8);
    	tree.insert(3);
    	tree.insert(74);
    	tree.insert(52);
    	tree.insert(84);
    	tree.insert(31);
    	tree.print(tree.root);

    }
}