/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package animalfarm;

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author robert
 */
public class AnimalFarm {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        List<Animal> animals = new ArrayList<>();
        
        Dog rover = new Dog();
        Cat kitty = new Cat();
        Cow buttercup = new Cow();
        
        animals.add(rover);
        animals.add(kitty);
        animals.add(buttercup);
        
        for(Animal animal : animals) {
            animal.speak();
        }
    }
}
