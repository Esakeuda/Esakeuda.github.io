kerrokset = int(input("Syötä pyramidin kerrosten lukumäärä: "))

for i in range(1, kerrokset + 1):
    for j in range(kerrokset - i):
        print(" ", end="")
    for k in range(2 * i - 1):
        print("*", end="")
    print()

input("Paina Enter lopettaaksesi...")
