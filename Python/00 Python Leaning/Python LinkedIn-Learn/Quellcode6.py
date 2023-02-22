# input() -> Liefert string zurück daher 4+2=42 --> Muss in Int gecastet werden
# + Operator verhält sich polymorph (Bei String: Verkettung, Bei Int: Addition)
z1 = int(input("Bitte Zahl1 eingeben: "))
z2 = int(input("Bitte Zahl2 eingeben: "))

print(z1 + z2)