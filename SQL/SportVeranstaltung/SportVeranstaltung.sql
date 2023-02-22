-- Lernen der SQL-Grundlagen zum Thema:
-- DDL -> Data Definition Language (Create, Alter, Drop)
-- DML -> Data Manipulation Language (Select, Insert, Update, Delete)


-- Datenbank erstellen
CREATE DATABASE `sportveranstaltung`;



-- Tabellen erstellen
CREATE TABLE `sportveranstaltung`.`mannschaft` (
  `MannschaftID` INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `Vereinsname` VARCHAR(45) NULL,
  `Vereinssitz` VARCHAR(45) NULL,
  `Ergebnis` VARCHAR(45) NULL,
  `Sportart` INT);


  
  CREATE TABLE `sportveranstaltung`.`teilnehmer` (
  `TeilnehmerID` INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `Vorname` VARCHAR(45) NULL,
  `Nachname` VARCHAR(45) NULL,
  `Alter` INT NULL,
  `Adresse` VARCHAR(45) NULL,
  `Telefonnummer` VARCHAR(45) NULL,
  `Mannschaft` INT);
  
CREATE TABLE `sportveranstaltung`.`sportart` (
  `SportartID` INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `Sportart` VARCHAR(45) NULL,
  `Sportbereich` INT NULL);
  
CREATE TABLE `sportveranstaltung`.`sportbereich` (
  `SportbereichID` INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
  `Sportbereich` VARCHAR(45) NULL);
  
  
  -- Relationen herstellen
ALTER TABLE `sportveranstaltung`.`sportart` 
ADD CONSTRAINT `Sportart-Sportbereich`
	FOREIGN KEY (`Sportbereich`)
	REFERENCES `sportveranstaltung`.`sportbereich` (`SportbereichID`);

ALTER TABLE `sportveranstaltung`.`mannschaft` 
ADD CONSTRAINT `Mannschaft-Sportart`
	FOREIGN KEY (`Sportart`)
	REFERENCES `sportveranstaltung`.`sportart` (`SportartID`);
  
ALTER TABLE `sportveranstaltung`.`teilnehmer` 
ADD CONSTRAINT `Teilnehmer-Mannschaft`
  FOREIGN KEY (`Mannschaft`)
  REFERENCES `sportveranstaltung`.`mannschaft` (`MannschaftID`);  
 
 -- Daten in Tabllen einfügen
 -- Sportbereich-Tabelle
INSERT INTO `sportveranstaltung`.`sportbereich` (`Sportbereich`) VALUES ('Leichtatlethik');
INSERT INTO `sportveranstaltung`.`sportbereich` (`Sportbereich`) VALUES ('Ballsport');
INSERT INTO `sportveranstaltung`.`sportbereich` (`Sportbereich`) VALUES ('Schwimmen');

-- Sportart-Tabelle
INSERT INTO `sportveranstaltung`.`sportart` (`Sportart`, `Sportbereich`) VALUES ('Fussbball', '2');
INSERT INTO `sportveranstaltung`.`sportart` (`Sportart`, `Sportbereich`) VALUES ('Basketball', '2');
INSERT INTO `sportveranstaltung`.`sportart` (`Sportart`, `Sportbereich`) VALUES ('Volleyball', '2');
INSERT INTO `sportveranstaltung`.`sportart` (`Sportart`, `Sportbereich`) VALUES ('Weitsprung', '1');
INSERT INTO `sportveranstaltung`.`sportart` (`Sportart`, `Sportbereich`) VALUES ('100-Meter-Lauf', '1');
INSERT INTO `sportveranstaltung`.`sportart` (`Sportart`, `Sportbereich`) VALUES ('Hochsprung', '1');
INSERT INTO `sportveranstaltung`.`sportart` (`Sportart`, `Sportbereich`) VALUES ('Staffellauf', '1');
INSERT INTO `sportveranstaltung`.`sportart` (`Sportart`, `Sportbereich`) VALUES ('Wasserball', '3');
INSERT INTO `sportveranstaltung`.`sportart` (`Sportart`, `Sportbereich`) VALUES ('Brustschwimmen', '3');
INSERT INTO `sportveranstaltung`.`sportart` (`Sportart`, `Sportbereich`) VALUES ('Hindernissschwimmen', '3');
INSERT INTO `sportveranstaltung`.`sportart` (`Sportart`, `Sportbereich`) VALUES ('Wasserspringen', '3');

-- Manschaft-Tabelle
INSERT INTO `sportveranstaltung`.`mannschaft` (`Vereinsname`, `Vereinssitz`, `Ergebnis`, `Sportart`) VALUES ('Hannover 96', 'Hannover', 'Gold', '1');
INSERT INTO `sportveranstaltung`.`mannschaft` (`Vereinsname`, `Vereinssitz`, `Ergebnis`, `Sportart`) VALUES ('TSV Holzheim', 'Holzheim', 'Bronze', '11');
INSERT INTO `sportveranstaltung`.`mannschaft` (`Vereinsname`, `Vereinssitz`, `Ergebnis`, `Sportart`) VALUES ('Al-Ahly', 'Kairo', 'Gold', '1');
INSERT INTO `sportveranstaltung`.`mannschaft` (`Vereinsname`, `Vereinssitz`, `Ergebnis`, `Sportart`) VALUES ('TUG Göppingen', 'Göppingen', 'Silber', '5');
INSERT INTO `sportveranstaltung`.`mannschaft` (`Vereinsname`, `Vereinssitz`, `Ergebnis`, `Sportart`) VALUES ('VfB Stuttgart', 'Stuttgart', 'Silber', '1');
INSERT INTO `sportveranstaltung`.`mannschaft` (`Vereinsname`, `Vereinssitz`, `Ergebnis`, `Sportart`) VALUES ('Welzheimer Sterne', 'Welzheim', 'Bronze', '8');

-- Teilnehmer-Tabelle
INSERT INTO `sportveranstaltung`.`teilnehmer` (`Vorname`, `Nachname`, `Alter`, `Adresse`, `Telefonnummer`, `Mannschaft`) VALUES ('Hesham', 'Osman', '30', 'Palmenwaldstr. 58', '0176 86949095', '3');
INSERT INTO `sportveranstaltung`.`teilnehmer` (`Vorname`, `Nachname`, `Alter`, `Adresse`, `Telefonnummer`, `Mannschaft`) VALUES ('Henrik', 'Heiser', '18', 'Köngenstr. 9', '0176 87439256', '4');
INSERT INTO `sportveranstaltung`.`teilnehmer` (`Vorname`, `Nachname`, `Alter`, `Adresse`, `Telefonnummer`, `Mannschaft`) VALUES ('Luca', 'Schäuffele', '20', 'Kirchheimstr. 5', '0156 47923751', '5');
INSERT INTO `sportveranstaltung`.`teilnehmer` (`Vorname`, `Nachname`, `Alter`, `Adresse`, `Telefonnummer`, `Mannschaft`) VALUES ('Merve', 'Günes', '20', 'Palmenwaldstr. 58', '0176 52515253', '1');
INSERT INTO `sportveranstaltung`.`teilnehmer` (`Vorname`, `Nachname`, `Alter`, `Adresse`, `Telefonnummer`, `Mannschaft`) VALUES ('Sven', 'Dexler', '16', 'Filderstadtstr. 117', '0176 78797576', '6');








  