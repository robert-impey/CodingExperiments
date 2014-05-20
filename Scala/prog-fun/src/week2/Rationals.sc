package week2

object Rationals {
  val x = new Rational(1, 3)                      //> x  : week2.Rational = 1/3
  val y = new Rational(5, 7)                      //> y  : week2.Rational = 5/7
  val z = new Rational(3, 2)                      //> z  : week2.Rational = 3/2

  x + y                                           //> res0: week2.Rational = 22/21
  x - y                                           //> res1: week2.Rational = 8/-21
  x * y                                           //> res2: week2.Rational = 5/21
  x / y                                           //> res3: week2.Rational = 7/15
  y / x                                           //> res4: week2.Rational = 15/7

  x - y - z                                       //> res5: week2.Rational = -79/42

  -x                                              //> res6: week2.Rational = 1/-3
  y + y                                           //> res7: week2.Rational = 10/7
}

class Rational(x: Int, y: Int) {
  private def gcd(a: Int, b: Int): Int =
    if (b == 0) a else gcd(b, a % b)
  val numer = x
  val denom = y
  val g = gcd(numer, denom)

  override def toString() = {
    numer / g + "/" + denom / g
  }

  def +(that: Rational) = {
    new Rational(this.numer * that.denom + that.numer * this.denom, this.denom * that.denom)
  }

  def -(that: Rational) = {
    this + -that
  }

  def *(that: Rational) = {
    new Rational(this.numer * that.numer, this.denom * that.denom)
  }

  def /(that: Rational) = {
    new Rational(this.numer * that.denom, this.denom * that.numer)
  }

  def unary_- : Rational = {
    new Rational(-1 * this.numer, this.denom)
  }
}