package week1

object Factorial {
	def factorial(x: Int) : Int =
		if (x == 0) 1 else x * factorial(x - 1)
                                                  //> factorial: (x: Int)Int
	
	factorial(0)                              //> res0: Int = 1
	factorial(1)                              //> res1: Int = 1
	factorial(6)                              //> res2: Int = 720
}