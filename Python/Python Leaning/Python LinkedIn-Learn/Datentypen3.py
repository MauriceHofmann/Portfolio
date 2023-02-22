# Bestimmen des Datentyps einer Variablen
# Beim schreiben von Python-Code wirkt es als nutzen wir primitive Datentypen... Allerdings arbeitet Python im Hintergrund objektorientiert und mach daraus einen Referenztypen. 
var1 = 7
print(type(var1))

# Umwandlung von Datentypen
var2 = "3"
print(var1 + int(var2))
print(str(var1) + var2)
print(type(float(var1)))