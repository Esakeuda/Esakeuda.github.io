print("Numerot alkaen aloitusluvusta ja päättyen nollaan")
print("---------------------------------------------")

aloitusluku = int(input("Syötä aloitusluku: "))

for luku in range(aloitusluku, -1, -1):
    print(luku)

input("Paina Enter lopettaaksesi...")
