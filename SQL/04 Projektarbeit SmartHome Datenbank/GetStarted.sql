-- Bitte führen Sie das folgende SQL-Skript aus.
-- ====================================================================================================
-- Beschreibung:
-- Dieses Skript legt Ihnen eine Datenbank namens "smarthome" an. Diese Datenbank enthält zwei 
-- Tabellen (Sensorendaten, Sensoren), die in einer 1-n-Relation miteinander stehen, was zusätzlich
-- mithilfe dieses Skripts erstellt werden.
--
-- Autoren: Hesham Osman, Maurice Hofmann, Merve Günes
-- ====================================================================================================

CREATE DATABASE `smarthome`;

USE smarthome;

CREATE TABLE IF NOT EXISTS `smarthome`.`sensorendaten` (
  `TempValue` DOUBLE,
  `HumidValue` DOUBLE,
  `PressureValue` DOUBLE,
  `DatumZeit` DATETIME,
  `SensorID` INT);
  
CREATE TABLE IF NOT EXISTS `smarthome`.`sensoren` (
  `ID` INT,
  `Ort` VARCHAR(30),
  `IPAdresse` VARCHAR(30),
  PRIMARY KEY (`ID`));
  
  
ALTER TABLE `smarthome`.`sensorendaten` 
ADD CONSTRAINT `Sensordaten-sensoren`
  FOREIGN KEY (`SensorID`)
  REFERENCES `smarthome`.`sensoren` (`ID`);  
  
INSERT INTO `smarthome`.`sensoren` (`ID`, `Ort`, `IPAdresse`) VALUES ('1', 'Wohnzimmer', '192.168.1.141');
INSERT INTO `smarthome`.`sensoren` (`ID`, `Ort`, `IPAdresse`) VALUES ('2', 'Küche', '192.168.1.142');
INSERT INTO `smarthome`.`sensoren` (`ID`, `Ort`, `IPAdresse`) VALUES ('3', 'Schlafzimmer', '192.168.1.143');
INSERT INTO `smarthome`.`sensoren` (`ID`, `Ort`, `IPAdresse`) VALUES ('4', 'Balkon', '192.168.1.144');
INSERT INTO `smarthome`.`sensoren` (`ID`, `Ort`, `IPAdresse`) VALUES ('5', 'Badezimmer', '192.168.1.145');