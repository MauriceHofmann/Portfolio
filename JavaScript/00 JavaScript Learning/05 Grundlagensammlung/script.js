//In diesem Projekt dreht sich alles Rund um die Welt von JavaScript. Hier werden die Inhalte der Programmiersprache simpel für Anfänger erklärt.
//Mentor dieses Projekt ist der Kanal: Programmieren lernen mithilfe des folgenden Tutorials: https://www.youtube.com/watch?v=YXHnanpIdNo&t=158s
//==========================================================================================================================================================

//===============================
//Arbeiten mit der Konsole
//===============================

//Jedesmal wenn das Programm ausgeführt wird, wird zunächst der Inhalt Browserkonsole gelöscht.
console.clear();

//Mit diesem Befehl können Zahlen oder Texte in der Browserkonsole ausgegeben.
console.log("Das ist mein ersts Programm!");
console.log("Mein Name ist Maurice");
console.log("Ich bin 20 Jahre alt");



//===============================
//Variablen
//===============================

//Der angegebene Name und das Alter wurden hardcodiert angegeben. Dies soll nun aber dynamisiert werden. Der Name sowie das Alter sollen nun Variabel dargestellt
//werden. Dadruch können sie im laufe des Programms ersetzt werden was das ganze etwas flexibler macht.
//Eine Variable wird mit dem Schlüsselwort var deklariert. Dazu benötigt eine Variable einen selbstwählbaren Namen. Zugleich kann der Variablen auch ein
//Wert zugewiesen werden (Initialisierung).
//Texte müssen hierbei immer in Anführungszeichen angegeben werden.
var name = "Maurice";
//var age = "20";
var age = 20;

//Die Werte dieser Variablen können nun in den Text mit eingebunden werden.
//Dafür wird der Verkettungsoperator (+) eingesetzt. Damit können verschiedene Texte verbunden werden.
console.log("Mein Name ist " + name + ".");
console.log("Ich bin " + age + " Jahre alt.")

//Unterschied var - let - const
//const: Konstante Werte die sich nicht während der Laufzeit ändern können
//var: Variable die von überall zugreifbar ist
//let: Variable die nur im deklarierten Abschnitt zugreifbar ist



//===============================
//Arithmetische Operatoren
//===============================

//Nun ist die vielleicht aufgefallen, dass die 20 bei der Variable age in Anfürhungszeichen steht, worüber bei der Monatsberechnung die 12 ohne Anführungszeichen steht,
//was zusätzlich farblich unterschieden wird. Das liegt am sogenannten Datentyp.
//Es gibt die Zeichenkette (string) => Darin können Buchstaben, Zahlen oder sonstige Zeichen aneinander gehängt werden. Immer Anführungszeichen.
//Es gibt Zahlen (number) => Bei Zahlen, die zum rechnen benötigt werden. Es dürfen hier keine Anführungszeichen gesetzt werden.
//Da es sich beim alter um eine Zahl handelt, mit der wir rechnen möchten, können wir diese Variable nun auskommentieren und als number initialisieren.
//Das Alter soll nun berechnet werden mithilfe der arithmetischen Operatoren:

//Monate berechnen
var months = age * 12;
console.log("Ich bin " + months + " Monate alt.")

//Tage berechnen
var days = age * 365;
console.log("Ich bin " + days + " Tage alt.");

//Stunden berechnen
var hours = days * 24;
console.log("Ich bin " + hours + " Stunden alt.");

//Minuten berechnen
var minutes = hours * 60;
console.log("Ich bin " + minutes + " Minuten alt.");

//Sekunden berechnen
var seconds = minutes * 60;
console.log("Ich bin " + seconds + " Sekunden alt");


//Umgekehrte berechnung von Sekunden aus
//Stunden werden vom Ausgangswert (Sekunden berechnet)
var seconds2 = 100000;
var hours2 = (seconds2 / 60) / 60;
console.log(seconds2 + " Sekunden entsprechen " + hours2 + " Stunden.")

let days2 = hours2 / 24;
console.log(seconds2 + " Sekunden entsprechen " + days2 + " Tage.");

let years2 = days2 / 365;
console.log(seconds2 + " Sekunden entsprechen " + years2 + " Jahre.");


//Addition - Subtraktion - Multiplikation - Division
var a = 5;
var b = 6;

var result = a + b;
console.log(result);



//===============================
//Konstanten
//===============================

//Es gibt jedoch auch Variablen, die nur einmal definiert werden und diesen konstanten Wert halten sollen. Beispiel: Pi
//Hier soll nun eine Kreisberechnung durchgeführt werden.
const pi = 3.1415926;

var radius = 10;
var umfang = pi * 2 * radius;
console.log("Umfang ist: " + umfang);



//===================================
//Primitive vs komplexe Datentypen
//===================================

//Einer Variable können verschiedene Datentypen zugewiesen werden (bsp. Zahl, Text) => primitive Datentypen
//Einer Variable können allerdings auch komplexe Werte zugwiesen werden.

// -----Primitive Datentypen
var name2 = "Maurice"; //string
var alter2 = 20; //number
var isStudent = true; //boolean - true or false

// -----Komplexe Datentypen
//Strukturen mit hilfe deren wir in Variablen mehr speichern können als nur ein Text oder eine Zahl. Zwischen die geschweiften Klammern können nun
//mehrere Informationen gespeichert werden. => JavaScript-Objekt
var contact = {
    firstName: "Maurice",
    lastName: "Hofmann",
    age: 20,
    isStudent: true
};

var contact2 = {
    firstName: "Hans",
    lastName: "Schulz",
    age: 78,
    isStudent: false
};

//Zugriff auf die Variable contact
console.log(contact.firstName + " " + contact.lastName);
console.log(contact2.firstName + " " + contact2.lastName);



//===============================
//Arrays
//===============================

//Es können mehrere Werte hintereinander speicher und dann jeweils auf den Wert zugreifen (Notizbuch)

//Deklarieren eines Arrays
//Angegeben werden die Werte in den Eckigen Klammern hintereinander mit Komma voneinander getrennt
var notebook = [1, 2, 3, 4];
var notebookString =  ["Eier kaufen" , "Mehl kaufen", "Putzen", "Sport machen"];

//Zugriff auf die Werte mit Ausgabe in der Konsole (Start bei Index 0)
console.log("Notiz 1 ist ", notebookString[0]);
console.log("Notiz 2 ist ", notebookString[1]);
console.log("Notiz 3 ist ", notebookString[2]);
console.log("Notiz 4 ist ", notebookString[3]);
console.log("Was passiert wenn eine Notiz zuviel ausgegeben werden soll ", notebookString[4]); // => undifined

//Hinzufügen von Daten zu einem Array
notebookString.push("Milch kaufen");
console.log("Notiz 5 ist ", notebookString[4]);

//Variable in einen Array speichern
var newNote = "Haare waschen";
notebookString.push(newNote);
console.log("Notiz 6 ist ", notebookString[5]);

//Mithilfe dieses Zwischenschrittes kann auch eine Nutzereingabe erfolgen - späteres Kapitel
var newNoteEingabe = prompt(); //=> Nutzereingabefeld öffnet sich
notebookString.push(newNoteEingabe);
console.log("Notiz 7 ist ", notebookString[6]);



//===============================
//Funktionen
//===============================

//Eine Funktion deklarieren
//function individuellerName(Funktionsparameter) - return liefert den Wert der aus der Funktion gegeben werden soll

//An die Funktion wird der Wert 15 (C°) geliefert und nach Fahreheit umgerechnet. Die Gradzahl in Fahrenheit wird dann zurückgeliefert
//und in der Variable result gespeichert. Anchließend wird das ergebnis in der Konsole ausgegeben.
var result = celsiusToFahrenheit(15);
console.log("15 Grad Celsius " + result + " Fahrenheit");

//Funktionen können beliebig oft aufgerufen werden. Dies erspart viel Schreibarbeit, indem logisch zusammenhängende Zeilen Code 
//in eine Funktion geschrieben werden.
var result2 = celsiusToFahrenheit(30)
console.log("30 Grad Celsius " + result2 + " Fahrenheit")

//Die Parameter können beliebig benannt werden, da es sich nur um eine Variable handelt.
function celsiusToFahrenheit(x) {
    //Formel für Celsius nach Fahrenheit: F = C * (9/5) + 32
    return x * (9 / 5) + 32;
}



//===============================
//Texteingabe (prompt)
//===============================

//Der Nutzer kann eine Eingabe tätigen, die dann in einer Variable genutzt werden kann. Dies Erfolgt mit der Methode Promt().
//Anschließend wird die Eingabe der Celsius-Gradzahl in Fahrenheit umgewandelt und in der Konsole ausgegeben.
var inputNutzer = prompt("Bitte Grad Celsius eingeben:"); //=> Nutzereingabefeld öffnet sich mit dem übergebenen Hinweis für den Nutzer, was gefordert wird
var result3 = celsiusToFahrenheit(inputNutzer);
console.log(inputNutzer +" Grad Celsius " + result3 + " Fahrenheit");



//===============================
//Verzweigungen
//===============================

//Je nachdem was für ein Fall eintritt soll etwas anderes passieren.
//if(Bedingung)
//{}
// === -> Entspricht die Zahl einer anderen Zahl
//Beispiel: Je nach dem wie alt wir sind, soll etwas anderes passieren. Es wird eine Funktion geschrieben, welcher ein Alter übergeben wird.
//Im Anschluss wird in der Konsole angegeben, was man mit diesem Alter machen kann.
function whatCanIDo(age) {
    if(age === 15) {
        console.log("Du darfst den Führerschein machen.");
    }

    if(age === 16) {
        console.log("Du darfst vielleicht schon wählen.");
    }

    if(age >= 18) {
        console.log("Du bist Volljährig.");
    } else {
        console.log("Du bist noch nicht volljährig.");
    }
}

whatCanIDo(10); //=> "Du bist noch nicht volljährig."
whatCanIDo(18); //=> "Du bist noch volljährig."
whatCanIDo(15); //=> "Du darfst den Führerschein machen. Du bist noch nicht volljährig."

//Verzeiwgung mit Texten
function sayHello(name) {
    if(name === "Junus") {
        console.log("Sei gegrüßt" + name);
    } else {
        console.log("Hallo" + name);
    }
}

sayHello("Junus");
sayHello("Hans");



//===============================
//For-Schleife
//===============================

//for(Zählervariable - Wo fange ich an zu zählen; Bedingung - Wielange soll der Vorgang wiederholt werden; Verhalten der Zählervariable)
for (let i = 0; i < 9; i++) {
    console.log("Hallo", i);  
}