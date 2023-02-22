a = 17
b = 0.3
c = 2
d = 0.65

print(1 * 1)        # Ergebnis: 1
print(1 + 1)        # Ergebnis: 2
print(5 - 1)        # Ergebnis: 4

print(4 / 2)        # Ergebnis: 2.0 (Ganzzahl : Ganzzahl -->Float)
print(5 / 2)        # Ergebnis: 2.5

# Möchte man nicht, das aus einer Ganzzahldivision eine Gleitkommazahl entsteht, kann der doppelte Divisionsoperator verwendet werden //
print(4 // 2)        # Ergebnis: 2
print(5 // 2)        # Ergebnis: 2

print(a % c)        # Ergebnis: 1
print(a % b)        # Modulo funktioniert mit Gleitkomma -> Rundung gefährlich

print(a ** c)       # a hoch c (** --> Potenz)
print(a ** b)   

print("a" + "b")    # String-Verkettung

print(a + 1.9)      # Ganzzahl + Gleitkommazahl --> Gleitkommazahl (18.9)
print(1 + 3.9)      # Ergebnis: 4.9

print(True + False) # 1 + 0 = 1
print(a + True)     # 17 + 1 = 18
