package week2

object HigherOrderFunctions {
  def sum(f: Int => Int, a: Int, b: Int): Int = {
    if (a > b) 0
    else f(a) + sum(f, a + 1, b)
  } //> sum: (f: Int => Int, a: Int, b: Int)Int

  def sumId(a: Int, b: Int) = sum(x => x, a, b) //> sumId: (a: Int, b: Int)Int

  sumId(1, 10) //> res0: Int = 55

  def sumCube(a: Int, b: Int) = sum(x => x * x * x, a, b)
  //> sumCube: (a: Int, b: Int)Int

  sumCube(1, 10) //> res1: Int = 3025
}