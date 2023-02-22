text = "Spam. Wonderful spam."
primzahlen = (2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31)
wochentage = ("Mo", "Di", "Mi", "Do", "Fr", "Sa", "So")
matrix = ((1, 2), (3, 4))

# Ansprechen eines Elements
print(text[2])
print([primzahlen[5]])
print(matrix[0][1])
print(wochentage[1])
print(wochentage[1][1])

# Ansprechen mehrerer Elemente
print(text[2:8])
print(primzahlen[3:len(primzahlen)])    #len() liefert die Anzahl der Einträge
