/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package farmyardpolymorphism;

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
