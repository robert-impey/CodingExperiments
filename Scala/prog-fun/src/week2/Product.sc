package week2

object Product {
  def product(f: Int => Int)(a: Int, b: Int): Int =
    if (a > b) 1 else f(a) * product(f)(a + 1, b) //> product: (f: Int => Int)(a: Int, b: Int)Int

  def fact(n: Int) = product(x => x)(1, n)        //> fact: (n: Int)Int

  fact(6)                                         //> res0: Int = 720
  
  product (x => x * x) (3, 4)                     //> res1: Int = 144
}