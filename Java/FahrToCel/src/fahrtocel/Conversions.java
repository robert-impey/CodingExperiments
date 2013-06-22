package fahrtocel;

/**
 * @author rimpey
 */
public class Conversions {
    public static double fahrToCel(double fahr) {
        double cel = ((fahr - 32) / 9) * 5;
        return cel;
    }
}
