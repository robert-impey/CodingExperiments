xs = [ 1, 2, 3, 4, 5 ]

libInitOfXs = init xs

myInit xs =
	reverse (tail (reverse xs))

myInitOfXs = myInit xs

myInitWithDrop xs =
	reverse (drop 1 (reverse xs))

myInitWithDropOfXs = myInitWithDrop xs

