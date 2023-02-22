pattern = "@"
sequenz1 = "Ralph.Mayer@gmx.net"
print(pattern in sequenz1)          # Ist das @-Zeichen in der Zeichfolge
print(pattern not in sequenz1)      # Ist das @-Zeichen nicht in der Zeichfolge

sequenz2 = "Ralph.Mayer@gmx.net"
print("sequenz1 is sequenz2", sequenz1 is sequenz2)
print("sequenz1 == sequenz2", sequenz1 == sequenz2)

z1 = [2, 3, 5]
z2 = [2, 3, 5]
print("z1 is z2", z1 is z2)
print("z1 == z2", z1 == z2)


z1 = 2
a = z1 << 1 # Binärdarstellung wird um eine Stelle nach links verschoben 
b = z1 >> 1 # Binärdarstellung wird um eine Stelle nach rechts verschoben 
print("Der Wert von 2 << 1: ", a)
print("Der Wert von 2 >> 1: ", b)