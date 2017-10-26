object ForExpressions {
	def isPrime(n : Int) = (2 until n) forall (n % _ != 0)
                                                  //> isPrime: (n: Int)Boolean
	val n = 10                                //> n  : Int = 10
	
	var pairs0 = ((1 until n) map (i =>
		(1 until i) map (j => (i, j)))).flatten filter (pair =>
			isPrime(pair._1 + pair._2))
                                                  //> pairs0  : scala.collection.immutable.IndexedSeq[(Int, Int)] = Vector((2,1), 
                                                  //| (3,2), (4,1), (4,3), (5,2), (6,1), (6,5), (7,4), (7,6), (8,3), (8,5), (9,2),
                                                  //|  (9,4), (9,8))
		
	val pairs1 = (1 until n) flatMap (i =>
		(1 until i) map (j => (i, j))) filter (pair =>
			isPrime(pair._1 + pair._2))
                                                  //> pairs1  : scala.collection.immutable.IndexedSeq[(Int, Int)] = Vector((2,1), 
                                                  //| (3,2), (4,1), (4,3), (5,2), (6,1), (6,5), (7,4), (7,6), (8,3), (8,5), (9,2),
                                                  //|  (9,4), (9,8))
	var pairs2 = for {
		i <- 1 until n
		j <- 1 until i
		if isPrime(i + j)
		} yield(i, j)                     //> pairs2  : scala.collection.immutable.IndexedSeq[(Int, Int)] = Vector((2,1), 
                                                  //| (3,2), (4,1), (4,3), (5,2), (6,1), (6,5), (7,4), (7,6), (8,3), (8,5), (9,2),
                                                  //|  (9,4), (9,8))
 	val xs = 1 until 4                        //> xs  : scala.collection.immutable.Range = Range(1, 2, 3)
 	val ys = 6 until 10                       //> ys  : scala.collection.immutable.Range = Range(6, 7, 8, 9)
 	
 	val scalarProduct = (for {
 		i <- xs
 		j <- ys
 	} yield (i * j)).sum                      //> scalarProduct  : Int = 180
}