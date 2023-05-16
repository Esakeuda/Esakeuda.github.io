ika = int(input("Syötä ikä: "))
sukupuoli = input("Syötä sukupuoli (mies/nainen): ")

# Tulostus riippuen iästä ja sukupuolesta
if sukupuoli == "mies":
    if ika < 14:
        print("Mitäs poitsu?")
    elif ika <= 25:
        print("Mitäs nuori mies?")
    elif ika <= 56:
        print("Olet mies parhaassa iässä!")
    else:
        print("Mitäs vanha ukko?")
elif sukupuoli == "nainen":
    if ika < 14:
        print("Mitäs tyttö?")
    elif ika <= 25:
        print("Mitäs nuori nainen?")
    elif ika <= 56:
        print("Olet nainen parhaassa iässä!")
    else:
        print("Mitäs vanha muori?")
else:
    print("Virheellinen sukupuoli!")
    
input("Paina Enter lopettaaksesi...")