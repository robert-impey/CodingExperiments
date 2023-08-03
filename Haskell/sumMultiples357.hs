sumMultiplesOf357 max = sum(filter(\x -> (mod x 3 == 0) || (mod x 5 == 0) || (mod x 7 == 0) )[1 .. max])

main = do
    print (sumMultiplesOf357 1)
    print (sumMultiplesOf357 3)
    print (sumMultiplesOf357 5)
    print (sumMultiplesOf357 7)
    print (sumMultiplesOf357 10)
    print (sumMultiplesOf357 50)
    print (sumMultiplesOf357 100)
    