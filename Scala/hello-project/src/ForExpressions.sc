object ForExpressions {
  def isPrime(n: Int) = (2 until n) forall (n % _ != 0)

  val n = 10

  var pairs0 = ((1 until n) map (i =>
    (1 until i) map (j => (i, j)))).flatten filter (pair =>
    isPrime(pair._1 + pair._2))

  val pairs1 = (1 until n) flatMap (i =>
    (1 until i) map (j => (i, j))) filter (pair =>
    isPrime(pair._1 + pair._2))

  var pairs2 = for {
    i <- 1 until n
    j <- 1 until i
    if isPrime(i + j)
  } yield (i, j)

  val xs = 1 until 4
  val ys = 6 until 10

  val scalarProduct = (for {
    i <- xs
    j <- ys
  } yield i * j).sum //> scalarProduct  : Int = 180
}