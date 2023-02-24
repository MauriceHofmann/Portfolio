class Tier:
    # Initialisierungmethode
    # Deklaration der Eigenschaften selbst, erfolgt bereits in der magischen Funktion
    def __init__(self, name, alter, typ):
        self.typ = typ
        self.name = name
        self.alter = alter

    def lautgeben(self, text):
        print(text)

# Erzeugen des Objekts
tier1 = Tier("Herby", 6, "Katze")

# Ausgabe
print(tier1.name)
tier1.lautgeben("Ich gebe einen Laut")