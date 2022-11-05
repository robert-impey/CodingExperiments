number = 1000

print(f'Number is {number}')

count = 0

for n in range(number + 1):
	b1 = n
	b2 = number - n
	b3 = number * n
	total = b1 + b2 + b3
	count += 1
	
	print(f'{b1} + {b2} + {b3} = {total}')

print(f'count is {count}')
