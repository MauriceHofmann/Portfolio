# Tupel
primzahlen = (2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31)
print(primzahlen)
#primzahlen[2] = 111 --> Error - Statisch

wochentage = ("Mo", "Di", "Mi", "Do", "Fr", "Sa", "So")
print(wochentage)

matrix = ((1, 2), (3, 4))
print(matrix)

tupel1 = (primzahlen, wochentage)
print(tupel1)


# Listen
primzahlen = [2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31]
print(primzahlen)
#primzahlen[2] = 111 --> Funktioniert - Dynmisch
primzahlen.append(39) 
print(primzahlen) # Anhängen eines Elements

primzahlen.pop(-1) # alt.:primzahlen.pop(len(primzahlen)-1)
print(primzahlen)

matrix = [[1, 2], [3, 4]]
print(matrix)

liste1 = [primzahlen, wochentage]
print(liste1)

