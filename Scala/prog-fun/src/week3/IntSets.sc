package week3

object IntSets {
  val t1 = new NonEmpty(3, Empty, Empty)          //> t1  : week3.NonEmpty = {.3.}
  val t2 = t1 incl 4                              //> t2  : week3.NonEmpty = {.3{.4.}}
  val t3 = t2 incl 2                              //> t3  : week3.NonEmpty = {{.2.}3{.4.}}
  val t4 = new NonEmpty(5, Empty, Empty)          //> t4  : week3.NonEmpty = {.5.}
  
  t1 union t2                                     //> res0: week3.IntSet = {.3{.4.}}
  t2 union t1                                     //> res1: week3.IntSet = {.3{.4.}}
  
  t1 union t3                                     //> res2: week3.IntSet = {{.2.}3{.4.}}
  t4 union t3                                     //> res3: week3.IntSet = {{.2.}3{.4{.5.}}}
}

abstract class IntSet {
	def incl(x: Int) : IntSet
	def contains(x: Int) : Boolean
	def union(other: IntSet) : IntSet
}

object Empty extends IntSet {
	def incl(x: Int) = new NonEmpty(x, Empty, Empty)
	def contains(x: Int) = false
	def union(other : IntSet) = other
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
		
	def union(other: IntSet) =
		((left union right) union other) incl elem
	
	override def toString = "{" + left + elem + right + "}"
}