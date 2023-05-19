pituus_cm = float(input("Syötä pituus senttimetreinä: "))

# Muunnokset
pituus_metreina = pituus_cm / 100
pituus_maileina = pituus_cm * 0.0000062137
pituus_jaardeina = pituus_cm * 0.010936
pituus_tuumina = pituus_cm * 0.39370

# Tulostus
print("Pituus metreinä: {:.2f}".format(pituus_metreina))
print("Pituus maileina: {:.2f}".format(pituus_maileina))
print("Pituus jaardeina: {:.2f}".format(pituus_jaardeina))
print("Pituus tuumina: {:.2f}".format(pituus_tuumina))
input("Paina Enter lopettaaksesi...")
