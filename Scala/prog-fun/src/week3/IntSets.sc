package week3

object IntSets {
  println("Welcome to the Scala worksheet")       //> Welcome to the Scala worksheet
  val t1 = new NonEmpty(3, Empty, Empty)          //> t1  : week3.NonEmpty = {.3.}
  val t2 = t1 incl 4                              //> t2  : week3.NonEmpty = {.3{.4.}}
  val t3 = t2 incl 2                              //> t3  : week3.NonEmpty = {{.2.}3{.4.}}
}

abstract class IntSet {
	def incl(x: Int) : IntSet
	def contains(x: Int) : Boolean
}

object Empty extends IntSet {
	def incl(x: Int) = new NonEmpty(x, Empty, Empty)
	def contains(x: Int) = false
	override def toString = "."
}

class NonEmpty(elem: Int, left : IntSet, right : IntSet) extends IntSet {
	def incl(x: Int) =
		if (x < elem) new NonEmpty(elem, left incl x, right)
		else if (x > elem) new NonEmpty(elem, left, right incl x)
		else this
	def contains(x : Int) =
		if (x < elem) left contains x
		else if (x > elem) right contains x
		else true
	override def toString = "{" + left + elem + right + "}"
}