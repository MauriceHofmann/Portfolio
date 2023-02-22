-- Aufgaben zur Tabellen-Manupulation DML -> Data Manipulation Language (Anlegen, Ändern, Löschen)
-- Erstellen Sie mit der Workbench (oder einem anderen DB-Management-Tool) eine Test-Datenbank.
-- Verwenden Sie die Oberfläche des DB-Tools, um das entsprechende Skript automatisch zu generieren. Fügen Sie das generierte Skrpit
-- unten passend zu den Aufgaben ein.
CREATE DATABASE testdatenbank;

-- 1.	Erstellen Sie die beiden Tabellen Schüler und Klassenlehrer mit referenzieller Integrität. Erstellen Sie sinnvolle Spalten.
--       Hier gilt: 
--      "Ein Klassenlehrer betreut EIN ODER MEHRERE Schüler. Ein Schüler wird von EINEM Klassenlehrer betreut."
--      Welche Art der Beziehung besteht hier? => 1-n-Beziehung

CREATE TABLE lehrer (
  idlehrer INT PRIMARY KEY AUTO_INCREMENT,
  Vorname VARCHAR(45),
  Nachname VARCHAR(45)
  );

CREATE TABLE schueler (
  idschueler INT PRIMARY KEY AUTO_INCREMENT,
  Vorname VARCHAR(45),
  Nachname VARCHAR(45),
  Lehrer INT,
  CONSTRAINT SchuelerLehrerRelation 
  FOREIGN KEY (Lehrer) REFERENCES lehrer(idlehrer));
  
-- 2.	Fügen Sie in die Tabelle Schüler die Spalten „Straße, Hausnummer, PLZ und Ort“ mit einem passenden Datentyp hinzu.
ALTER TABLE schueler 
ADD COLUMN Strasse VARCHAR(45),
ADD COLUMN `Haunummer` VARCHAR(20),
ADD COLUMN `PLZ` INT,
ADD COLUMN `Ort` VARCHAR(45);

-- 3.	Ändern Sie den Datentyp des Merkmals Hausnummer in VARCHAR (5) um.
ALTER TABLE schueler 
CHANGE COLUMN Haunummer Hausnummer VARCHAR(5);

-- 4.	Löschen Sie eine Spalte.
ALTER TABLE schueler
DROP COLUMN Ort;

-- 5.   Ändern Sie die Eigenschaften der Tabellenspalten so, dass die DB auf korrekte Primärschlüssel achtet. Führen Sie weitere
--      Sicherheitseinstellungen (UNIQUE, NOT NULL,...) durch. 

-- 6.	Fügen Sie in die Tabellen Datensätze ein.
-- Zuerst müssen die Lehrer eingefügt werden, da sonst der FK in der Schülertabelle keinen passenden Eintrag in der Tabelle Lehrer findet

-- Lehrer: 
INSERT INTO lehrer (Vorname, Nachname) 
VALUES ('Rüdiger', 'Berg');

INSERT INTO lehrer (Vorname, Nachname) 
VALUES ('Carsten', 'Ockert');


-- Schüler:
INSERT INTO schueler (Vorname, Nachname, Lehrer, Strasse, Hausnummer, PLZ) 
VALUES ('Maurice', 'Hofmann', '1', 'Ahornweg', '3/1', '74357');

INSERT INTO schueler (Vorname, Nachname, Lehrer, Strasse, Hausnummer, PLZ) 
VALUES ('Hesham', 'Osman', '1', 'Palmenwaldstraße', '58', '73733');


-- 6b.  Fügen Sie Datensätze mit selben Namen ein.
INSERT INTO schueler (Vorname, Nachname, Lehrer, Strasse, Hausnummer, PLZ) 
VALUES ('Hesham', 'Osman', '1', 'Palmenwaldstraße', '58', '73733');

-- 7.	Ihr Klassenlehrer ändert seinen Nachnamen auf „Norris“. Erstellen Sie eine Update Abfrage. 
UPDATE lehrer 
SET Nachname = 'Norris' 
WHERE idlehrer = '2';

-- 8.	Löschen Sie einen Schüler anhand seines Primärschlüssels. 
DELETE FROM schueler
 WHERE idschueler = '3';
