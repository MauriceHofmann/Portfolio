# Closure: Funktion innerhalb einer Funktion
def rechnen(a):
    potenz = 3

    def innen():
        text = "Das Ergebnis ist"
        print(text, a ** potenz)
    
    innen()

rechnen(4)
rechnen(5)
rechnen(7)