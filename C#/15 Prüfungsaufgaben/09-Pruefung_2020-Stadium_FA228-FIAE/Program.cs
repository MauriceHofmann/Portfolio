using _09_Pruefung_2020_Stadium_FA228_FIAE;

VIPKunde vipFreund1 = new VIPKunde("Markus Berger", "0761 9721398");
VIPKunde vipFreund2 = new VIPKunde("Georg Maier", "0117 9882139");

List<VIPKunde> vipFreunde = new List<VIPKunde>();
vipFreunde.Add(vipFreund1);
vipFreunde.Add(vipFreund2);

VIPKunde vipKunde = new VIPKunde("Hans Huber", "0924 9872341", vipFreunde);


DateTime kauftag = new DateTime(2020, 06, 01);
DateTime spieltag1 = new DateTime(2020, 07, 04);
DateTime spieltag2 = new DateTime(2020, 06, 06);

vipKunde.KaufeKarte(24.50, kauftag, spieltag1);
vipKunde.KaufeKarte(24.50, kauftag, spieltag2);

//Die Methode des VIPKunden ruft die Methode BerechneKartenPreis der abstrakten Klasse Kunde auf
//und itteriert durch alle gekauften Karten und liefert den Gesamtpreis zurück. In der Methode des
//VIPKunden wird der Rabatt mit eingerechnet.
double gesamtPreis = vipKunde.BerechneKartenPreis();
Console.WriteLine("Die Karten kosten: " + gesamtPreis);

Console.ReadKey();