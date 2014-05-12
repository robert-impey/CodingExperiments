package week2

object HigherOrderFunctions {
  def sum(f: Int => Int, a: Int, b: Int): Int = {
    if (a > b) 0
    else f(a) + sum(f, a + 1, b)
  }                                               //> sum: (f: Int => Int, a: Int, b: Int)Int

  def sumId(a: Int, b: Int) = sum(x => x, a, b)   //> sumId: (a: Int, b: Int)Int

  sumId(1, 10)                                    //> res0: Int = 55

  def sumCube(a: Int, b: Int) = sum(x => x * x * x, a, b)
                                                  //> sumCube: (a: Int, b: Int)Int

  sumCube(1, 10)                                  //> res1: Int = 3025

  def sumTr(f: Int => Int, a: Int, b: Int): Int = {
    def loop(a: Int, acc: Int): Int = {
      if (a > b) acc
      else loop(a + 1, f(a) + acc)
    }

    loop(a, 0)
  }                                               //> sumTr: (f: Int => Int, a: Int, b: Int)Int
	
  def sumTrId(a: Int, b: Int) = sumTr(x => x, a, b)
                                                  //> sumTrId: (a: Int, b: Int)Int

  sumTrId(1, 10)                                  //> res2: Int = 55

  def sumTrCube(a: Int, b: Int) = sumTr(x => x * x * x, a, b)
                                                  //> sumTrCube: (a: Int, b: Int)Int

  sumTrCube(1, 10)                                //> res3: Int = 3025
}