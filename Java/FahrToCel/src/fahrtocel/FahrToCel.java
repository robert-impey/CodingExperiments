package fahrtocel;

/**
 * @author rimpey
 */
public class FahrToCel {
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        if (args.length == 0) {
            System.err.println("Give me a number!");
        } else {
            try {
                for (int i = 0; i < args.length; i++) {
                    double fahr = Double.parseDouble(args[i]);
                    double cel = Conversions.fahrToCel(fahr);
                    System.out.println(cel);
                }
            } catch (Exception e) {
                System.err.println(e);
                System.err.println("A number, I said!");
            }
        }
    }
}
