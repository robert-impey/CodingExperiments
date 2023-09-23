def isMultiple(n : Int) = n % 3 == 0 || n % 5 == 0 || n % 7 == 0

def sumIf356(n: Int) =
  val xs = 0 until n + 1

  val multiples = for {
    x <- xs
    if isMultiple(x)
  } yield x

  multiples.sum

val testNs = List(0, 1, 3, 5, 7, 10, 50, 100)

for {
  n <- testNs
} yield sumIf356(n)
