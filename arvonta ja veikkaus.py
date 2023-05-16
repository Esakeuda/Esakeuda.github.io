import random

oikea_vastaus = random.randint(1, 12)
yritykset = 5

for i in range(yritykset):
    arvaus = int(input("Arvaa luku väliltä 1-12: "))

    if arvaus == oikea_vastaus:
        print("Onneksi olkoon, arvasit oikein!")
        break
    else:
        if i == yritykset - 1:
            print("Arvasit väärin!")
            print("Se oli viimeinen yrityksesi!")
            print("Oikea vastaus oli", oikea_vastaus)
        else:
            print("Arvasit väärin!")

