/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package micawber;

/**
 *
 * @author rimpey
 */
public class Micawber {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        double income = 20;
        double expenditure;
        expenditure = 19.975;
        //expenditure = 20.025;
        String result;
        
        if (income > expenditure) {
            result = "Happiness";
        } else {
            result = "Misery";
        }
        
        System.out.printf(
            "Income: %.3f\tExpenditure: %.3f\tResult: %s\n",
            income,
            expenditure,
            result
        );
    }
}
