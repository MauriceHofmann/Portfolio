-- Aufgabe 3 - DB-Modellierung

-- Aufgabe 3.1
SELECT * FROM lager
WHERE stueck > 100 AND stueck < 200;
## 2/2


-- Aufgabe 3.2.3
-- Tabelle mit E-Mail-Adressen erstellen
CREATE TABLE `strichpunkt`.`e-mail` (
  `E-Mail` VARCHAR(45) PRIMARY KEY NOT NULL);
  

-- Tabellenspalte E-Mail in Mitarbeiter-Tabelle einfügen  
ALTER TABLE `strichpunkt`.`mitarbeiter` 
ADD COLUMN `email` VARCHAR(45);

-- Relation zwischen der Tabelle Mitarbeiter und Tabelle E-Mail herstellen
ALTER TABLE `strichpunkt`.`mitarbeiter` 
ADD CONSTRAINT `Mitarbeiter-Email`
  FOREIGN KEY (`email`)
  REFERENCES `strichpunkt`.`e-mail` (`E-Mail`);
## 3/3

-- Aufgabe 3.3
-- Tabelle Lieferantenzufriedenheit anlegen
CREATE TABLE `strichpunkt`.`lieferantenzufriedenheit` (
  `LieferantenzufriedenheitID` INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `Zuverlässigkeit` VARCHAR(45) NULL);

-- Tabellenspalte Zuverlässigkeit in der Tabelle Lieferanten anlegen
ALTER TABLE `strichpunkt`.`lieferanten` 
ADD COLUMN `zuverlässigkeit` INT;

-- Relation zwsichen den Tabellen Lieferanten und Lieferantenzuverlässigkeit herstellen
ALTER TABLE `strichpunkt`.`lieferanten` 
ADD CONSTRAINT `lieferant-zufriedenheit`
  FOREIGN KEY (`zuverlässigkeit`)
  REFERENCES `strichpunkt`.`lieferantenzufriedenheit` (`LieferantenzufriedenheitID`);
  
-- Datensätze in Tabelle Lieferantenzufriedenheiten einfügen
INSERT INTO `strichpunkt`.`lieferantenzufriedenheit` (`Zuverlässigkeit`) VALUES ('Volle Zufriedenheit');
INSERT INTO `strichpunkt`.`lieferantenzufriedenheit` (`Zuverlässigkeit`) VALUES ('Normal');
INSERT INTO `strichpunkt`.`lieferantenzufriedenheit` (`Zuverlässigkeit`) VALUES ('Nur im Notfall bestellen');

# 7/7