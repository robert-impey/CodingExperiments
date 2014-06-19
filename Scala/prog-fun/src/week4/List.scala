package week4

trait List[T] {
  def isEmpty: Boolean
  def head: T
  def tail: List[T]

  override def toString(): String = {
    if (isEmpty) "."
    else head + ", " + tail.toString()
  }

  def count(): Int = {
    if (isEmpty) 0
    else 1 + tail.count()
  }

  def nth(n: Int): T = {
    def loop(list: List[T], n: Int): T = {
      if (n < 0 || list.isEmpty) throw new IndexOutOfBoundsException()
      else if (n == 0) list.head
      else loop(list.tail, n - 1)
    }

    loop(this, n)
  }
}

class Cons[T](val head: T, val tail: List[T]) extends List[T] {
  def isEmpty = false
}

class Nil[T] extends List[T] {
  def isEmpty = true
  def head = throw new NoSuchElementException("Nil.head")
  def tail = throw new NoSuchElementException("Nil.tail")
}

object List {
  def apply[T](): List[T] = new Nil

  def apply[T](it: T): List[T] = new Cons[T](it, new Nil)

  def apply[T](x1: T, x2: T): List[T] = new Cons(x1, new Cons(x2, new Nil))
}