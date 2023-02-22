i = 0

while True:
    i += 1
    print("Wert des Schleifenzählers", i)
    break

print("Schleife beendet\n")


i = 0
while True:
    i += 1
    print("Wert des Schleifenzählers", i)
    if i > 5:
        break

print("Schleife beendet\n")


i = 0
while i < 10:
    i += 1
    
    # Mit continue wird alles was unterhalb in der Schleife folgt wird übersprungen und der nächste Schleifendurchgang wird gestartet
    if (i % 2) != 0: continue
    print("Wert des Schleifenzählers", i)

print("Schleife beendet")