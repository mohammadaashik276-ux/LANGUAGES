
total = 0
items = [1, 5, 12, 8, 3, 10]
count = 0

for item in items:
    if item > 5:
        total = total + item
        count = count +1
        if count == 3:
            break

    else:
        total = total * 2

print(total)