var fruits = Seq("apple", "bAnAnA", "orange")
println(fruits.map(_.toLowerCase))
println(fruits.flatMap(_.toUpperCase))
