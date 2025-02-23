import scala.annotation.tailrec

val data = List(1.0, 2, 3, 4, 5, 6, 7, 8, 9, 10)

@tailrec
def findDiffsAcc(list: List[Double], prev: Double, acc: List[Double]): List[Double] = list match {
  case Nil => acc.reverse
  case head :: tail => findDiffsAcc(tail, head, (head - prev) :: acc)
}

def findDifferences(list: List[Double]): List[Double] = list match {
  case Nil => List.empty[Double]
  case head :: tail => findDiffsAcc(tail, head, List.empty[Double])
}

findDifferences(data)
