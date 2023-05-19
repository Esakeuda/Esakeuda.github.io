rahasumma_euroina = float(input("Syötä rahasumma euroina: "))

# Muunnokset
rahasumma_dollareina = rahasumma_euroina * 1.22
rahasumma_punniiksi = rahasumma_euroina * 0.86

# Tulostus
print("Rahasumma euroina: {:0.2f} €".format(rahasumma_euroina))
print("Rahasumma dollareina: {:0.2f} $".format(rahasumma_dollareina))
print("Rahasumma punniksi: {:0.2f} £".format(rahasumma_punniiksi))
input("Paina Enter lopettaaksesi...")
