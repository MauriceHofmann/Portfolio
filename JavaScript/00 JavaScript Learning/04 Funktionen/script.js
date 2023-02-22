//Funktionen werden benötigt um verschiedene, zusammengehörige Anweisungen zu bündeln und diese an beliebiger Stelle
//so oft man sie benötigt, aufzurufen.
//Dadruch wird viel Schreibarbeit, bei sich wiederholenden Anweisungen gespart. Zugleich wird der Quellcode struktierter
//und übersichtlicher (Modularisierung).

//Erstellen einer Funktion - Deklaration
//Schlüsselwort function + individueller Funktionsname(mögl. Parameter)
//Zwischen dem geschweiften Klammerpaar kann nun der Code gebüdelt werden, der beim Aufruf dieser Funktion ausgeführt werden soll.
function a()
{
    var variableEins = 1;
    console.log(variableEins);
}

//Die Funktion a zeigt den Wert der variableEins noch nicht in der Konsole an. Das liegt daran, dass sie erst deklariert wurde.
//Die Funktion muss zusätzlich allerdings aufgerufen werden, damit der jeweilige Anweisungsblock ausgeführt wird.
//Aufgerufen wird eine Funktion wie folgt:
//Funktionsname(mögl. Argumente übergeben); 
a();

//Die Funktion kann auch schon im Quellcode überhalb der Deklaration der Methode aufgerufen werden.

//Werte die die Funktion liefert, können auch in neuen Variablen gespeichert werden.
var variableZwei = a();

//Rückgabewerte einer Funktion
//In einer Funktion kann ich, wie bereit gelernt, Anweisungen ausführen. Zusätzlich liefert eine Funktion auch immer einen Rückgabewert.
//Dieser Rückgabewert wird im Beispiel (Zeile 24) in eine neue Variable gespeichert.
//Ein Rückgabewert kann mit dem Schlüsselwort return explizit innerhalb der Anweisungen definiert werden.
//Der Rückgabewert kann eine zahl, ein string oder einen Wert einer Variablen zurückgeben.
function funktionMitRückgabewert()
{
    return 5;
}

//Der Rückgabewert der Funktion wird nun in die Variable gespeichert und anschließend in der Konsole ausgegeben.
var rückgabeWertDerFunktion = funktionMitRückgabewert();
console.log(rückgabeWertDerFunktion);

//Die Return-Anweisung kann auch verwendet werden ohnen einen Wert zu definieren. Dies liefert dann den Datentyp undefined zurück.
//Dasselbe passiert auch wenn kein return-Schlüsselwort verwendet wird, wie bei variableZwei (Zeile 24).
console.log(variableZwei);

//Wird eine return-Anweisung in einer Funktion verwendet, wird diese in diesem Zuge auch beendet und es wird wieder in den
//fortlaufenden Code gesprungen.
function nachReturn()
{
    var variableTest = "Test";
    return variableTest;
    console.log(variableTest);          //unerreichbarer Code => Diese Zeile wird nicht mehr ausgeführt, da durch das return-Schlüsselwort aus der Funktion gesprungen wird.
}


//=========================================================================================================================================================================================
//Funktion, die die Summer zweier hardcodierten Zahlen berechnet und in der Konsole ausgibt:
function summe()
{
    var variable1 = 1;
    var variable2 = 3;
    var summe = variable1 + variable2;
    console.log(summe);
}
//Funktionsaufruf
summe();

//Es sollen keine Hardcodierten Werte verwendet werden. Funktionen sollen weitgehend allgemeingültig geschrieben werden. Daher werden nun die zwei
//Variablen variable1 und variable2 nicht mehr mit festgelegten Werten angegeben, sondern es werden Parameter der Funktion hinzugefügt sogenannte 
//welcher beim Funktionsaufruf Argumente übergeben werden.
//Die Parameter (a,b)werden in die Runden Klammern geschrieben.
function summeParameter(a,b)
{
    //Übergebene Parameter werden addiert
    var summe = a + b;
    console.log(summe);
}

//In den Parametern stecken bislang noch keine Werte. Daher muss beim Funktionsaufruf Argumente übergeben werden, die hier in diesem Beispiel
//die Werte darstellen, die im Anweisungsblock der Funktion als Parameter a,b addiert werden.
//a = 1   b = 3       => 1 + 3 = 4 
summeParameter(1,3);
//Nun ist die Funktion allgemeingültiger und somit auch deutlich nutzbarer. Sie kann nun mit individuellen Werten gefüllt werden und es muss nicht
//für alle Werte, die benötigt werden, eine Funktion geschrieben werden.
summeParameter(21,22);
summeParameter(10, 12);
summeParameter(3.1, 5.4);

//Werden mehr Argumente übergeben als in der Funktionsdeklaration angegeben, werden die ersten benötigten Arguemnte genommen, die wo zu viel sind werden ignoriert.
//Werden weniger Argumente übergeben als in der Funktionsdeklaration angegeben, wird ein Fehler aufgezeigt, da benötigte Parameter fehlen(Fehlendes Argument vom Typ undifined).