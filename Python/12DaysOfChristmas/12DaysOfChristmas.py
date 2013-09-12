totalGifts = 0

for dayOfChristmas in range(1, 12 + 1):
    for gifts in range(1, dayOfChristmas + 1):
        totalGifts += gifts

print "The total number of gifts: ", totalGifts
