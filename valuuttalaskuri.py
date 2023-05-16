rahasumma_euroina = float(input("Syötä rahasumma euroina: "))
valuutta = input("Valitse valuutta (dollari tai punta): ")

# Muunnokset
if valuutta == "dollari":
    rahasumma_muunnos = rahasumma_euroina * 1.22
    valuuttamerkki = "$"
elif valuutta == "punta":
    rahasumma_muunnos = rahasumma_euroina * 0.86
    valuuttamerkki = "£"
else:
    print("Virheellinen valuuttavalinta!")
    input("Paina Enter lopettaaksesi...")
    exit()

# Tulostus
print("Rahasumma euroina: {:.2f} €".format(rahasumma_euroina))
print("Rahasumma {}: {:.2f} {}".format(valuutta, rahasumma_muunnos, valuuttamerkki))
input("Paina Enter lopettaaksesi...")
