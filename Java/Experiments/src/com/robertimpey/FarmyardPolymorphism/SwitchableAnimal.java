/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package com.robertimpey.FarmyardPolymorphism;

/**
 *
 * @author robert
 */
public class SwitchableAnimal {
    String species;
    
    public SwitchableAnimal(String species) {
        this.species = species;
    }
    
    public String speak() throws Exception {
        switch (species) {
            case "dog" -> {
                return "Woof!";
            }
            case "cat" -> {
                return "Meow!";
            }
            default -> throw new Exception("I'm not sure what I am!");
        }
    }
}
