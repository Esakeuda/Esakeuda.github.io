luku = int(input("Syötä luku väliltä 1 ja 10: "))

print("Laskutoimitukset luvun", luku, "kanssa:")

for i in range(1, 6):
    kertolasku = luku * i
    jakolasku = luku / i
    jakojäännös = luku % i
    
    print(luku, "*", i, "=", kertolasku)
    print(luku, "/", i, "=", jakolasku)
    print(luku, "%", i, "=", jakojäännös)
    print()

input("Paina Enter lopettaaksesi...")
