package greeter

object WS {
  println("Welcome to the Scala worksheet!")       //> Welcome to the Scala worksheet
  val x = 6                                       //> x  : Int = 4
  def increase(i: Int) = i + 3                    //> increase: (i: Int)Int
  increase(x)                                     //> res0: Int = 5
}