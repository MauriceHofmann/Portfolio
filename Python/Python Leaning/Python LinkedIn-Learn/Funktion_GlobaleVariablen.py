a = 42

def ausgabe():
    # Lokale Variable wird bevorzugt -> Gibt es keine wird die globale Variable verwendet
    #a = 1
    #print(a)

    # Möchte ich dennoch auf die globle Variable zugreifen, kann das Schlüsselwort global verwendet werden, dadurch kann die Variable auch manipuliert werden
    global a 
    a += 1
    print(a)

ausgabe()
print(a)