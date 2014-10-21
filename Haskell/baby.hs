doubleMe x = x * 2

doubleUs x y = doubleMe x + doubleMe y

quadruple x = doubleMe (doubleMe x)

factorial n = product [1 .. n ]

average ns = sum ns `div` length ns
