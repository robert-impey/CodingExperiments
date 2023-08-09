/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package com.robertimpey.FarmyardPolymorphism;

/**
 *
 * @author robert
 */
public class Dog implements Animal {
    @Override
    public String speak() {
        return "Woof!";
    }
}
