var variableEins = 1;
var stringZwei = "Zwei";  

//Mit der Methode log() der console-Klasse können Werte in der Konsole im Webbrowser ausgegeben werden.
console.log(variableEins);
console.log(stringZwei);
console.log(variableEins, stringZwei);

//Es muss jedoch keine Variable erzeugt werden. Es kann der Methode auch ein Ausdruck übergeben werden.
console.log("Hallo,möchtest du JavaScript erlernen?")

//Beachtet muss jedoch trotzdem werden, dass wenn es sich um einen string handelt werden Anfürhungszeichen 
//benötigt, beim Datentyp number keine.

//Wird eine nicht bereits initialisierte Variable versucht in der Konsole auszugeben für das zu einem Error:
//VariablenName is not defined - Variable wurde noch nicht erstellt
console.log(variableDrei);