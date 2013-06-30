-- http://projecteuler.net/problem=1
-- 2011-12-11

sumMultiplesOf3Or5 max = sum(filter(\x -> (mod x 5 == 0) || (mod x 3 == 0))[1 .. max - 1])
