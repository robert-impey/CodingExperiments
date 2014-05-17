package week2

object Rationals {
  val x = new Rational(1, 3)                      //> x  : week2.Rational = 1/3
  val y = new Rational(5, 7)                      //> y  : week2.Rational = 5/7
  val z = new Rational(3, 2)                      //> z  : week2.Rational = 3/2

  x.add(y)                                        //> res0: week2.Rational = 22/21
  x.sub(y)                                        //> res1: week2.Rational = -8/21
  x.mult(y)                                       //> res2: week2.Rational = 5/21
  x.div(y)                                        //> res3: week2.Rational = 7/15
  y.div(x)                                        //> res4: week2.Rational = 15/7
  
  x.sub(y).sub(z)                                 //> res5: week2.Rational = -79/42
}

class Rational(x: Int, y: Int) {
  def numer = x
  def denom = y

  override def toString() = {
    numer + "/" + denom
  }

  def add(that: Rational) = {
    new Rational(this.numer * that.denom + that.numer * this.denom, this.denom * that.denom)
  }
  
  def sub(that: Rational) = {
  	new Rational(this.numer * that.denom - that.numer * this.denom, this.denom * that.denom)
  }
  
  def mult(that: Rational) = {
  	new Rational(this.numer * that.numer, this.denom * that.denom)
  }
  
  def div(that: Rational) = {
  	new Rational(this.numer * that.denom, this.denom * that.numer)
  }
}