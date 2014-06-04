package week4

import week4._

object GenericList {
  val l = new Cons[Int](1, new Cons[Int](2, new Cons[Int](3, new Nil[Int])))
                                                  //> l  : week4.Cons[Int] = 1, 2, 3, .
  l.count()                                       //> res0: Int = 3
  l.nth(0)                                        //> res1: Int = 1
  l.nth(1)                                        //> res2: Int = 2
  l.nth(2)                                        //> res3: Int = 3
  //l.nth(-1)
 	// l.nth(3)
}