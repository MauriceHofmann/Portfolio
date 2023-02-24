class Katze:
    # Eigenschaften
    name = "Herbi"
    alter = 6

    # Methoden
    # Funktion analogie zu Methoden, nur Methoden werden in einer Klasse
    # definiert und Funktionen in der prozeduralen Programmierung 
    # Bei einer Methode wird als erster Parameter immer 'self' übergeben, das
    # ist eine Objekreferenz. Beim Aufruf der Methode wird dafür kein Wert genommen.
    # Der Parameter 'self' verweist immer auf das aktuelle objekt und beim Aufruf der Methode
    # wird dieser Parameter automatisch gefüllt.
    # Python -> self; C#, Java -> this
    def lautgeben(self):
        print("Miau")


# Erzeugung eines Objekts
# Objektzuweisung einer Variable
katze1 = Katze()
print(type(katze1))

# Methodenaufruf eines Objekts
katze1.lautgeben()

# Eigenschaften lesen
print(katze1.alter)