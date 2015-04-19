object FlatMapExamples {
  var fruits = Seq("apple", "banana", "orange")   //> fruits  : Seq[String] = List(apple, banana, orange)
  println(fruits.map(_.toUpperCase))              //> List(APPLE, BANANA, ORANGE)
}