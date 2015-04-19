object FlatMapExamples {
  var fruits = Seq("apple", "banana", "orange")   //> fruits  : Seq[String] = List(apple, banana, orange)
  println(fruits.map(_.toUpperCase))              //> List(APPLE, BANANA, ORANGE)
  println(fruits.flatMap(_.toUpperCase))          //> List(A, P, P, L, E, B, A, N, A, N, A, O, R, A, N, G, E)
}