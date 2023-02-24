class Lebewesen:
    alter = 42

# Lebewesen als Superklasse
# Mensch als Subklasse
class Mensch(Lebewesen):
    name = "Hans"

# Erzeugung eines Objekts & Aufruf der Eigenschaft der Super- und Subklasse
mensch = Mensch()
print(mensch.alter, mensch.name)