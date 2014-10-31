xs = [ 1, 2, 3, 4, 5]

libLastOfXs = last xs

myLast xs = 
	head (drop (length xs - 1) xs)

myLastOfXs = myLast xs

