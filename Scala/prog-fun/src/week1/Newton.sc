package week1

object Newton {
  1 + 2                                           //> res0: Int(3) = 3
  def abs(x: Double): Double = if (x < 0) -x else x
                                                  //> abs: (x: Double)Double
  def isGoodEnough(guess: Double, x: Double): Boolean =
    abs(guess * guess - x) < 1e-3                 //> isGoodEnough: (guess: Double, x: Double)Boolean
  def improve(guess: Double, x: Double): Double =
    (guess + (x / guess)) / 2                     //> improve: (guess: Double, x: Double)Double
  def sqrtIter(guess: Double, x: Double): Double =
    if (isGoodEnough(guess, x)) guess else
      sqrtIter(improve(guess, x), x)              //> sqrtIter: (guess: Double, x: Double)Double
  def sqrt(x: Double): Double = sqrtIter(1, x)    //> sqrt: (x: Double)Double

  sqrt(2)                                         //> res1: Double = 1.4142156862745097
  sqrt(4)                                         //> res2: Double = 2.0000000929222947
  sqrt(1e-6)                                      //> res3: Double = 0.031260655525445276
  //sqrt(1e60)
}