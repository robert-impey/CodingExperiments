package week1

object Euclid {
  def gcd (a: Int, b: Int) : Int =
  	if (b == 0) a else gcd(b, a % b)          //> gcd: (a: Int, b: Int)Int
  	
  gcd(14, 21)                                     //> res0: Int = 7
  gcd(21,14)                                      //> res1: Int = 7
  gcd(21, 84)                                     //> res2: Int = 21
  gcd(21, 70)                                     //> res3: Int = 7
  gcd(13, 17)                                     //> res4: Int = 1
}