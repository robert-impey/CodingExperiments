object FlatMapExamples {
  var fruits = Seq("apple", "banana", "orange")   //> fruits  : Seq[String] = List(apple, banana, orange)
  fruits.map(_.toUpperCase)                       //> res0: Seq[String] = List(APPLE, BANANA, ORANGE)
  fruits.flatMap(_.toUpperCase)                   //> res1: Seq[Char] = List(A, P, P, L, E, B, A, N, A, N, A, O, R, A, N, G, E)
}