etunimi = input("Syötä etunimesi: ")
sukunimi = input("Syötä sukunimesi: ")

tuloste = """
Tervetuloa!

Etunimi: {}
Sukunimi: {}

print(tuloste.format(etunimi, sukunimi))
input("Paina Enter lopettaaksesi...")
