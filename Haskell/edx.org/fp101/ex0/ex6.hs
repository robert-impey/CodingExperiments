myProduct [] = 1
myProduct (x : xs) = x * myProduct xs

mP = myProduct [ 2, 3, 4]

