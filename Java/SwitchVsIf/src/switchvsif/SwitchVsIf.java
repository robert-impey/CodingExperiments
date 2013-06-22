/*
 * Testing the difference in execution time for
 * switch statements and if statements.
 */
package switchvsif;

import java.util.Random;

/**
 *
 * @author Robert Impey
 */
public class SwitchVsIf {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // Create some random numbers
        
        final int choices = 5;
        final int iterations = (int)Math.pow(10, 6);
        
        Random r = new Random();
        int[] randoms = new int[iterations];        
        for (int i = 0; i < iterations; i++) {
            randoms[i] = r.nextInt(choices);
        }
        
        // Time the case statment
        
        int[] switchCounts = {0, 0, 0, 0, 0};
        final long startCase = System.nanoTime();
        
        for (int i = 0; i < iterations; i++) {
            switch (randoms[i]) {
                case 0:
                    switchCounts[0]++;
                    break;
                case 1:
                    switchCounts[1]++;
                    break;
                case 2:
                    switchCounts[2]++;
                    break;
                case 3:
                    switchCounts[3]++;
                    break;
                case 4:
                    switchCounts[4]++;
                    break;
                default:
                    throw new IndexOutOfBoundsException();
            }
        }
        
        final long endCase = System.nanoTime();
        
        System.out.println("Switch counts: ");
        for (int i = 0; i < choices; i++) {
            System.out.printf("Case: %d\tCounts: %d\n", i, switchCounts[i]);
        }
        
        System.out.printf("Nanoseconds: %d\n", endCase - startCase);
        
        // Time the if statements
        
        int[] ifCounts = {0, 0, 0, 0, 0};
        final long startIf = System.nanoTime();
        
        for (int i = 0; i < iterations; i++) {
            if (randoms[i] == 0) {
                    ifCounts[0]++;
            } else if (randoms[i] == 1) {
                    ifCounts[1]++;
            } else if (randoms[i] == 2) {
                    ifCounts[2]++;
            } else if (randoms[i] == 3) {
                    ifCounts[3]++;
            } else if (randoms[i] == 4) {
                    ifCounts[4]++;
            } else {
                throw new IndexOutOfBoundsException();
            }
        }
        
        final long endIf = System.nanoTime();
        
        System.out.println("If counts: ");
        for (int i = 0; i < choices; i++) {
            System.out.printf("Case: %d\tCounts: %d\n", i, ifCounts[i]);
        }
        
        System.out.printf("Nanoseconds: %d\n", endIf - startIf);
    }
}
