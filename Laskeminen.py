luku = int(input("Syötä luku väliltä 1-10: "))

kertolasku = luku * 2
jakolasku = luku / 2
jakajaannos = luku % 2

tuloste = """
Luku: {}

Kertolasku ({} * 2): {}
Jakolasku ({} / 2): {}
Jakojäännös ({} % 2): {}
"""

print(tuloste.format(luku, luku, kertolasku, luku, jakolasku, luku, jakajaannos))
input("Paina Enter lopettaaksesi...")
