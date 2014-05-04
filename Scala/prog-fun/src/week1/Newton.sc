package week1

object Newton {
  def sqrt(x: Double): Double =
    {
      def abs(x: Double): Double = if (x < 0) -x else x
      def isGoodEnough(guess: Double): Boolean =
        abs(guess * guess - x) / x < 1e-3
      def improve(guess: Double): Double =
        (guess + (x / guess)) / 2
      def sqrtIter(guess: Double): Double =
        if (isGoodEnough(guess)) guess else
          sqrtIter(improve(guess))
      sqrtIter(1)
    }                                             //> sqrt: (x: Double)Double
  sqrt(2)                                         //> res0: Double = 1.4142156862745097
  sqrt(4)                                         //> res1: Double = 2.000609756097561
  sqrt(1e-6)                                      //> res2: Double = 0.0010000001533016628
  sqrt(1e60)                                      //> res3: Double = 1.0000788456669446E30
  // WTF?
  sqrt(-2)                                        //> res4: Double = 1.0
}