aurinko_paistaa = input("Paistaako aurinko? (K/E): ")
sataa = input("Sataako? (K/E): ")
lampotila = float(input("Syötä lämpötila: "))

# Tulostus säähän liittyvän kommentin perusteella
if aurinko_paistaa == "K" and sataa == "K" and lampotila > 0:
    print("Aurinko paistaa ja vettä sataa, taitaa tulla kesä")
elif aurinko_paistaa == "E" and sataa == "K" and lampotila > 0:
    print("Syksy saapui tuuli vei lehdet mennessään")
elif aurinko_paistaa == "E" and sataa == "E" and lampotila > 0:
    print("Jo joutui armas aika ja suvi suloinen")
elif aurinko_paistaa == "K" and sataa == "E" and lampotila < 0:
    print("Keväinen talvi kesän tuo")
else:
    print("Ompa erikoinen sää!")

input("Paina Enter lopettaaksesi...")