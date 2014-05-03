package week1

object Newton {;import org.scalaide.worksheet.runtime.library.WorksheetSupport._; def main(args: Array[String])=$execute{;$skip(440); 
  def sqrt(x: Double): Double =
    {
      def abs(x: Double): Double = if (x < 0) -x else x
      def isGoodEnough(guess: Double): Boolean =
        abs(guess * guess - x) / x < 1e-3
      def improve(guess: Double): Double =
        (guess + (x / guess)) / 2
      def sqrtIter(guess: Double): Double =
        if (isGoodEnough(guess)) guess else
          sqrtIter(improve(guess))
      sqrtIter(1)
    };System.out.println("""sqrt: (x: Double)Double""");$skip(10); val res$0 = 
  sqrt(2);System.out.println("""res0: Double = """ + $show(res$0));$skip(10); val res$1 = 
  sqrt(4);System.out.println("""res1: Double = """ + $show(res$1));$skip(13); val res$2 = 
  sqrt(1e-6);System.out.println("""res2: Double = """ + $show(res$2));$skip(13); val res$3 = 
  sqrt(1e60);System.out.println("""res3: Double = """ + $show(res$3))}
}
