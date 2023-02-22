# Funktion mit optionalem Parameter b
def rechnen(a, b = 8):
    print(a * b)

# Funktion mit Parameterliste mit variaber Länge b
def multiplizieren(a, *b):
    erg = a

    for i in b:
        erg *= i

    print(erg)

rechnen(2)
rechnen(3, 4)

multiplizieren(3)
multiplizieren(3, 5)
multiplizieren(3, 5, 7, 11)