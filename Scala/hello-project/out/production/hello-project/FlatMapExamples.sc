object FlatMapExamples {
  var fruits = Seq("apple", "bAnAnA", "orange")   //> fruits  : Seq[String] = List(apple, bAnAnA, orange)
  println(fruits.map(_.toLowerCase))              //> List(apple, banana, orange)
  println(fruits.flatMap(_.toUpperCase))          //> List(A, P, P, L, E, B, A, N, A, N, A, O, R, A, N, G, E)
}