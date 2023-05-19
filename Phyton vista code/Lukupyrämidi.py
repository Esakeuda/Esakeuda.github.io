kerrosten_lukumaara = int(input("Syötä pyramidin kerrosten lukumäärä: "))

for i in range(1, kerrosten_lukumaara + 1):
    for j in range(1, i + 1):
        print(j, end=" ")
    print()
