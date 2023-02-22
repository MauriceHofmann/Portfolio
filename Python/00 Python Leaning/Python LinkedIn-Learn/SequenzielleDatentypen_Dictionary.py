person = ["Hans", "Otto"]
print(person[0])

# Es werden sprechende Indixes verwendet
person2 = {"vorname" : "Otto", "nachname" : "Hans"}
print(person2["vorname"])


for v in person2:
    print(v)

for v in person2.values():
    print(v)

for v in person2.keys():
    print(v)

person2.update({"vorname": "Willi"})
for v in person2.values():
    print(v)