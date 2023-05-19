hedelmat = ["omena", "banaani", "luumu", "mansikka", "apelsiini"]

monta_hedelmaa = int(input("Monta hedelmää haluat tulostaa? "))

for i in range(monta_hedelmaa):
    hedelma = hedelmat[i % len(hedelmat)]
    print(hedelma)
