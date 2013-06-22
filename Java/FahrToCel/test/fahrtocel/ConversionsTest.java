package fahrtocel;

import org.junit.*;
import static org.junit.Assert.assertEquals;

/**
 * @author rimpey
 */
public class ConversionsTest {
    
    public ConversionsTest() {
    }

    @BeforeClass
    public static void setUpClass() throws Exception {
    }

    @AfterClass
    public static void tearDownClass() throws Exception {
    }
    
    @Before
    public void setUp() {
    }
    
    @After
    public void tearDown() {
    }

    /**
     * Test of fahrToCel method, of class Conversions.
     */
    @Test
    public void testFahrToCel() {
        System.out.println("fahrToCel");
        double fahr = 212.0;
        double expResult = 100.0;
        double result = Conversions.fahrToCel(fahr);
        assertEquals(expResult, result, 0.0001);
    }
}
