/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package farmyardpolymorphism;

import java.util.LinkedList;
import java.util.List;

/**
 *
 * @author robert
 */
public class FarmyardPolymorphism {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        System.out.println("Doing it with a switch statement.");
        SwitchableAnimal aDog = new SwitchableAnimal("dog");
        SwitchableAnimal aCat = new SwitchableAnimal("cat");
        
        try {
            System.out.println(aDog.speak());
            System.out.println(aCat.speak());
        } catch (Exception e) {
            System.err.println(e.getMessage());
        }
        
        System.out.println("With polymorphism.");
        List<Animal> animals;
        animals = new LinkedList<>();
        
        animals.add(new Cat());
        animals.add(new Dog());
        
        for (Animal animal : animals) {
            System.out.println(animal.speak());
        }
    }
}
