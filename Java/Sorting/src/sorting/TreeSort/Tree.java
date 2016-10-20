/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package sorting.TreeSort;

import java.util.ArrayList;

/**
 *
 * @author Robert
 */
public class Tree {

    private final int value;

    private Tree left;
    private Tree right;

    public Tree(int value) {
        this.value = value;
    }

    public void add(int other) {
        if (this.value > other) {
            if (this.left == null) {
                this.left = new Tree(other);
            } else {
                this.left.add(other);
            }
        } else if (this.right == null) {
            this.right = new Tree(other);
        } else {
            this.right.add(other);
        }
    }

    public ArrayList<Integer> traverse() {
        ArrayList<Integer> collectedValues;
        collectedValues = new ArrayList<Integer>();
        
        if (this.left != null) {
            collectedValues.addAll(this.left.traverse());
        }
        
        collectedValues.add(this.value);
        
        if (this.right != null) {
            collectedValues.addAll(this.right.traverse());
        }
        
        return collectedValues;
    }
}
