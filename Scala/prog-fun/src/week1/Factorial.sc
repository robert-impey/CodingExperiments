package week1

object Factorial {
  def factorial(x: Int): Int =
    if (x == 0) 1 else x * factorial(x - 1)       //> factorial: (x: Int)Int

  factorial(0)                                    //> res0: Int = 1
  factorial(1)                                    //> res1: Int = 1
  factorial(31)                                   //> res2: Int = 738197504

  def trFact(n: Int): Int =
    {
      def loop(acc: Int, n: Int): Int = {
        if (n == 0) acc
        else loop(acc * n, n - 1)
      }
      loop(1, n)
    }                                             //> trFact: (n: Int)Int

  trFact(0)                                       //> res3: Int = 1
  trFact(1)                                       //> res4: Int = 1
  trFact(31)                                      //> res5: Int = 738197504
}