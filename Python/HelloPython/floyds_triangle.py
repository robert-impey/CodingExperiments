rows = int(input("How many rows?"))

number = 1
row = 0
columns = 1

while row < rows:
    current_column = 0
    
    while current_column < columns:
        print(number, end=' ')
        number += 1
        current_column += 1

    print()
    
    columns += 1
    row += 1
