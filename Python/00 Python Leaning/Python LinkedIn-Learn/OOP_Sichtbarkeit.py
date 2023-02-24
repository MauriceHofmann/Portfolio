class Person:
    # Private Variable -> durch zwei Unterstriche vor dem Namen einer Eigenschaft gekennzeichnet
    __alter = 42

    def get_alter(self):
        return self.__alter

person = Person()
#print(person.alter) # -> Fehlermeldung, da private Variable
print(person.get_alter())