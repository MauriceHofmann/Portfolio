-- phpMyAdmin SQL Dump
-- version 3.3.9
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Erstellungszeit: 09. April 2018 um 23:17
-- Server Version: 5.5.8
-- PHP-Version: 5.3.5

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Datenbank: `strichpunkt`
--

CREATE DATABASE `strichpunkt` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `strichpunkt`;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `abteilungen`
--

CREATE TABLE IF NOT EXISTS `abteilungen` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) DEFAULT NULL,
  `o_id` int(5) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `o_id` (`o_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Daten für Tabelle `abteilungen`
--

INSERT INTO `abteilungen` (`id`, `name`, `o_id`) VALUES
(1, 'Einkauf', 17),
(2, 'Marketing', 7),
(3, 'Verkauf', 17),
(4, 'Produktion', 7),
(5, 'Organisation', 7);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `artikel`
--

CREATE TABLE IF NOT EXISTS `artikel` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL DEFAULT '',
  `code` varchar(30) NOT NULL DEFAULT '',
  `vk_preis` float NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=94 ;

--
-- Daten für Tabelle `artikel`
--

INSERT INTO `artikel` (`id`, `name`, `code`, `vk_preis`) VALUES
(22, 'Bleistift B (10 Stück)', '3423', 22),
(23, 'Bleistift H (10 Stück)', '3123', 10),
(33, 'Füllhalter P1', '4346', 8.5),
(35, 'Füllhalter P', '4344', 15.5),
(38, 'Füllhalter P2 rechtshänder', '4322', 8.5),
(43, 'Kugelschreiber KG1', '5232', 2.5),
(44, 'Kugelschreiber KG2', '5223', 2.5),
(45, 'Bleistift HB (10 Stück)', '4342', 3),
(46, 'Füllhalter P2 linkshänder', '4323', 8.5),
(47, 'Füllhalter', '4333', 15.5),
(48, 'Kugelschreiber KG5', '5222', 2.5),
(49, 'Kugelschreiber Edel', '5233', 34),
(50, 'Fineliner (10 Stück)', '4444', 34),
(53, 'Bildschirm 22''''', '6565', 100),
(56, 'SW Duplexdrucker', '6464', 200),
(57, 'Q-Connect Klebestift 10g (25 Stk.)', '4578', 13.5),
(64, 'Textmarker 4er Set', '3365', 1.99),
(65, 'Ordner PVC mit 2 Ringen, 70mm, A4', '9354', 3),
(68, '12x Post-it Haftnotizen Super Sticky', '6223', 16.5),
(69, 'Register, blanko A4 aus Karton, farbig markiert', '9455', 1.5),
(70, 'Lineal Kunstoff 15 cm', '2231', 0.89),
(71, 'Zeichendreieck mit Griff, klar, 25 cm', '2233', 5.99),
(72, 'Geodreieck 16 cm flexibel', '2232', 1.99),
(73, 'Briefkorb quer, stapelbar', '7844', 8.5),
(74, 'Briefkorb längs, stapelbar', '7845', 8.5),
(75, 'Klemmbrett, natur, Hartfaser 23 x 32 cm', '6649', 3.75),
(76, 'Schere Gripy 17,5 cm', '7455', 2.5),
(77, 'Post-it Index Standard', '7888', 3.3),
(78, 'Korrekturstift Tipp-Ex Shake''n Squeeze 8ml', '8980', 2.5),
(79, 'Taschenkalender 2018 A6', '3477', 6.8),
(80, 'Ordner PVC 50mm A4', '9355', 1.75),
(81, 'Bürobuttler transparent, 4 Fächer', '7431', 7.5),
(82, 'Stempelkissen Größe 2, 5 Farben Set', '8512', 9.95),
(83, 'Heftgerät blau metallic Leitz', '6695', 13.25),
(84, 'Locher blau metallic Leitz', '6696', 7.5),
(85, 'Notizbox klar, ca. 700 Blatt', '3262', 2.8),
(86, 'Rollkartei Adresskartei 500 Karteikarten, inkl. Register', '3138', 35),
(87, 'Stempelkissen 70 x 50 mm blau', '8510', 4.5),
(88, 'Bänderstempel Datum', '8520', 3.6),
(89, 'Stempel mit Text BEZAHLT', '8525', 2.5),
(90, 'Tesa Tischabroller schwarz', '2442', 9.99),
(91, 'Stehsammler, Pappe, 5 Stk.', '1311', 4.5),
(92, 'Stehsammler, Hartfaser, 5 Stk.', '1312', 8.5),
(93, 'Buchkalender 2018, A4', '6366', 13.5);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `artikel_lieferanten`
--

CREATE TABLE IF NOT EXISTS `artikel_lieferanten` (
  `a_id` int(11) NOT NULL,
  `L_id` int(11) NOT NULL DEFAULT '0',
  `ek_preis` float NOT NULL,
  PRIMARY KEY (`a_id`,`L_id`),
  KEY `L_id` (`L_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Daten für Tabelle `artikel_lieferanten`
--

INSERT INTO `artikel_lieferanten` (`a_id`, `L_id`, `ek_preis`) VALUES
(22, 1, 16),
(22, 5, 14.5),
(22, 12, 15),
(23, 1, 9),
(23, 8, 7.5),
(33, 1, 7),
(33, 10, 7.5),
(33, 11, 7.2),
(35, 2, 12.5),
(35, 3, 12),
(38, 1, 7.5),
(38, 7, 7),
(38, 11, 8),
(43, 1, 1.3),
(43, 2, 1.5),
(43, 3, 1.75),
(44, 2, 2),
(44, 11, 2.2),
(45, 1, 2),
(45, 4, 2.2),
(45, 5, 2.5),
(46, 1, 7),
(46, 4, 6.5),
(46, 6, 7),
(47, 2, 10),
(47, 6, 11),
(48, 2, 2),
(48, 6, 3),
(48, 7, 2),
(49, 2, 22),
(49, 3, 22),
(49, 4, 23),
(50, 2, 22),
(50, 3, 21),
(50, 10, 23),
(53, 3, 75),
(53, 7, 65),
(53, 11, 85),
(56, 3, 100),
(56, 7, 85),
(57, 6, 9.5),
(57, 10, 10),
(57, 12, 9.5),
(64, 4, 1),
(64, 5, 2.5),
(64, 11, 1.3),
(65, 5, 1.5),
(65, 7, 2),
(65, 9, 1),
(68, 6, 12.5),
(68, 7, 12),
(68, 8, 13),
(69, 4, 1.1),
(69, 6, 1),
(70, 7, 0.2),
(70, 8, 0.15),
(70, 10, 0.35),
(71, 7, 2.5),
(71, 8, 2),
(71, 9, 2.3),
(72, 5, 1.5),
(72, 7, 1),
(72, 9, 1.2),
(73, 5, 3.5),
(73, 9, 3.8),
(74, 2, 8),
(74, 5, 7),
(74, 10, 7.3),
(75, 1, 2.75),
(75, 5, 2.3),
(75, 8, 2),
(76, 3, 1.3),
(76, 5, 1),
(76, 10, 1.5),
(77, 6, 1),
(77, 12, 1.3),
(78, 9, 1.75),
(78, 10, 1),
(78, 11, 1.5),
(79, 10, 3),
(79, 11, 2.5),
(79, 12, 3.5),
(80, 2, 1),
(80, 4, 0.75),
(80, 8, 2.2),
(81, 4, 8),
(81, 5, 6),
(81, 6, 6.5),
(82, 1, 3),
(82, 4, 3.5),
(83, 5, 9.5),
(83, 9, 8.2),
(83, 12, 10),
(84, 8, 3.5),
(84, 10, 3),
(84, 12, 3.5),
(85, 4, 1.5),
(85, 5, 1),
(85, 9, 1),
(86, 1, 17.5),
(86, 3, 19),
(86, 6, 20),
(87, 1, 1.4),
(87, 3, 2),
(87, 8, 2),
(88, 7, 1.3),
(88, 11, 1),
(89, 2, 1.5),
(89, 7, 1),
(89, 9, 1.1),
(90, 6, 3.3),
(90, 7, 3),
(90, 10, 3.33),
(91, 3, 3),
(91, 10, 2),
(91, 11, 2.1),
(92, 1, 5.5),
(92, 3, 5),
(93, 8, 7.99),
(93, 9, 7);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `lager`
--

CREATE TABLE IF NOT EXISTS `lager` (
  `a_id` int(11) NOT NULL,
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `stueck` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `a_id` (`a_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=80 ;

--
-- Daten für Tabelle `lager`
--

INSERT INTO `lager` (`a_id`, `id`, `stueck`) VALUES
(22, 1, 267),
(23, 2, 100),
(33, 3, 134),
(38, 4, 89),
(45, 5, 156),
(46, 6, 322),
(47, 7, 46),
(48, 8, 245),
(49, 9, 144),
(50, 10, 45),
(53, 11, 20),
(56, 12, 10),
(35, 57, 25),
(43, 58, 55),
(44, 59, 57),
(57, 60, 3),
(64, 61, 38),
(65, 62, 15),
(68, 63, 22),
(69, 64, 36),
(70, 65, 5),
(72, 66, 12),
(73, 67, 11),
(74, 68, 14),
(75, 69, 6),
(78, 70, 39),
(79, 71, 4),
(80, 72, 6),
(82, 73, 17),
(83, 74, 6),
(84, 75, 5),
(85, 76, 1),
(86, 77, 5),
(89, 78, 12),
(88, 79, 23);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `lieferanten`
--

CREATE TABLE IF NOT EXISTS `lieferanten` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(150) DEFAULT NULL,
  `plz` varchar(5) NOT NULL,
  `str` varchar(100) DEFAULT NULL,
  `hnr` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `plz` (`plz`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=13 ;

--
-- Daten für Tabelle `lieferanten`
--

INSERT INTO `lieferanten` (`id`, `name`, `plz`, `str`, `hnr`) VALUES
(1, 'Klix', '64688', 'Blumenstr.', '3'),
(2, 'Klecks', '80802', 'Beyerstr.', '13'),
(3, 'Reiher', '63368', 'Opernstr.', '33'),
(4, 'Strehle', '81671', 'Bahnhofstr.', '22'),
(5, 'Wolters Büro', '20099', 'Klause', '13'),
(6, 'Kratz', '07548', 'Schillerstr.', '35'),
(7, 'Katzmeier', '60385', 'Carl-Zeiss-Weg', '5'),
(8, 'Glaser', '88079', 'Kremmlerstr.', '63'),
(9, 'Tremm', '04159', 'Kurze Straße', '2'),
(10, 'Adler', '19059', 'Ringstr.', '105'),
(11, 'Breitner', '47803', 'Adenauerstr.', '17'),
(12, 'Gerung', '80337', 'Kriegstr.', '41');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `mitarbeiter`
--

CREATE TABLE IF NOT EXISTS `mitarbeiter` (
  `id` int(11) NOT NULL DEFAULT '0',
  `name` varchar(50) DEFAULT NULL,
  `vname` varchar(50) DEFAULT NULL,
  `str` varchar(150) DEFAULT NULL,
  `hnr` varchar(5) DEFAULT NULL,
  `plz` varchar(5) NOT NULL,
  `abt_id` int(11) DEFAULT NULL,
  `gebdat` date DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `plz` (`plz`),
  KEY `abt_id` (`abt_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Daten für Tabelle `mitarbeiter`
--

INSERT INTO `mitarbeiter` (`id`, `name`, `vname`, `str`, `hnr`, `plz`, `abt_id`, `gebdat`) VALUES
(1, 'Heinrichs', 'Harry', 'Ringstr.', '14', '04651', 1, '1965-01-12'),
(2, 'Kunkel', 'Silke', 'Kauterbacher Str.', '2', '04651', 1, '1968-05-14'),
(3, 'Kroner', 'Bart', 'Waldstr.', '26', '04651', 1, '1975-12-12'),
(4, 'Schubert', 'Klaus', 'Albert-Schweitzer-Str.', '3', '82528', 10, '1969-07-08'),
(5, 'Grinter', 'Frank', 'Reichersdorfer Str.', '19', '04651', 1, '1972-06-25'),
(6, 'Füller', 'Gerd', 'Neue Landstr.', '16', '04651', 1, '1968-04-03'),
(7, 'Hellmass', 'Paul', 'Colditz-Str.', '5', '04651', 1, '1979-01-05'),
(8, 'Körner', 'Laura', 'Ringstr.', '23', '04651', 1, '1981-08-09'),
(9, 'Brauer', 'Claudia', 'Oeder Weg', '3', '63368', 156, '1971-04-28'),
(11, 'Engelhardt', 'Josef', 'Berliner Str.', '5', '82528', 2, '1983-06-18'),
(12, 'Lauf', 'Heinz', 'Riedstr.', '27', '82528', 2, '1974-08-14'),
(13, 'Müller', 'Roberta', 'Pestalozzistr.', '30', '82528', 2, '1971-05-24'),
(14, 'Uhlig', 'Bernd', 'Alte Dorfstr.', '3', '04448', 2, '1962-09-13'),
(15, 'Ulmer', 'Karin', 'In den Weingärten', '1', '82528', 2, '1963-12-23'),
(16, 'Buser', 'Peter', 'Arndtstr.', '52', '12489', 3, '1961-11-11'),
(17, 'Nüsert', 'Hannelore', 'Gruberzeile', '23', '13593', 3, '1976-01-05'),
(18, 'Franzen', 'Britta', 'Ackerstr.', '1', '10115', 3, '1974-07-09'),
(19, 'Pflüger', 'Susi', 'Ratiborstr.', '11', '10999', 3, '1988-06-18'),
(20, 'Pfennig', 'Veronika', 'Bahnhofstr.', '25', '12305', 3, '1984-09-12'),
(21, 'Hahnert', 'Lisa', 'Stillerzeile', '39', '12587', 3, '1963-06-04'),
(22, 'Heilemann', 'Lutz', 'Weimarer Str.', '28', '10625', 3, '1977-05-07'),
(23, 'Schubert', 'Ernst', 'Lauenburger Str.', '10', '12157', 3, '1963-01-26'),
(24, 'Eilmann', 'Gretchen', 'Briesestr.', '33', '12053', 4, '1959-12-14'),
(25, 'Hellstern', 'Dieter', 'Fehrbelliner Str.', '35', '10119', 4, '1984-02-12'),
(26, 'Hannemann', 'Helmut', 'Savignyplatz', '11', '10623', 4, '1986-08-08'),
(27, 'Kersten', 'Bernd', 'Borkheider Str.', '15', '12689', 4, '1972-11-05'),
(28, 'Krämer', 'Gino', 'Hennigsdorfer Str.', '35 a', '13503', 4, '1964-05-05'),
(29, 'Schuster', 'Gabriele', 'Maienweg', '89', '22297', 4, '1968-05-06'),
(30, 'Schubert', 'Wolfgang', 'Ellenbogen', '13', '20144', 4, '1972-06-08'),
(31, 'Hahne', 'Klaus', 'Schedestr.', '9', '20251', 4, '1976-03-16'),
(32, 'Heim', 'Michael', 'Bredowstr.', '33', '22113', 4, '1978-03-09'),
(33, 'Hellmann', 'Manuela', 'Stresemannallee', '54 a ', '22529', 4, '1982-11-25'),
(34, 'Heyne', 'Hermann', 'Bauerberg', '27', '22111', 4, '1981-10-29'),
(35, 'Schneider', 'Bert', 'Grandweg', '3', '22529', 4, '1980-12-24'),
(36, 'Schulze', 'Norbert', 'Pilatuspool', '16', '20355', 4, '1976-12-15'),
(37, 'Engelke', 'Luisa', 'Keplerstr.', '23', '22763', 4, '1973-01-05'),
(38, 'Möller', 'Jochen', 'St. Georgs Kirchhof', '23', '20099', 4, '1978-09-19'),
(39, 'Zürcher', 'Steven', 'Mühlenweg', '1', '21465', 4, '1982-07-18'),
(40, 'Hahnemann', 'Eva', 'Canisiusstr.', '24', '47803', NULL, '1955-05-16'),
(41, 'Buschert', 'Ernesto', 'Potsdamer Str.', '9', '47800', NULL, '1952-04-12'),
(42, 'Lüchner', 'Marga', 'Westparkstr.', '24', '47803', NULL, '1959-06-15'),
(43, 'Mopfert', 'Kerstin', 'Osterather Weg', '32', '47807', NULL, '1959-07-08'),
(44, 'Müller', 'Harry', 'Ritterstr.', '229', '47805', NULL, '1963-06-24'),
(45, 'Körner', 'Claudia', 'Calvisiusstr.', '24', '47803', NULL, '1984-06-27'),
(46, 'Benkert', 'Heidelore', 'Moosweg', '22', '88079', NULL, '1987-12-05'),
(47, 'Sattler', 'Ulrike', 'Hauptstr.', '32', '88079', NULL, '1974-06-24'),
(48, 'Peters', 'Heiner', 'Kieselbuchweg', '3', '88079', NULL, '1976-05-26'),
(49, 'Glauber', 'Bernd', 'Danziger Weg', '15', '88079', NULL, '1981-02-23'),
(50, 'Aldag', 'Iris', 'Hemigkofener Str.', '18', '88079', NULL, '1981-05-06'),
(51, 'Uhlig', 'Dirk', 'Am Nonnenbach', '5', '88079', NULL, '1974-09-18'),
(52, 'Steinfeld', 'Matthias', 'Schillerstr.', '16', '88079', NULL, '1972-06-18'),
(53, 'Hauer', 'Siegfried', 'Dünenstr.', '73', '18609', NULL, '1964-05-09'),
(54, 'Griepke', 'Ina', 'Ringstr.', '4', '18609', NULL, '1959-04-16'),
(55, 'Beckert', 'Denise', 'Proraer Chaussee', '7', '18609', NULL, '1959-06-18'),
(56, 'Degen', 'Otto', 'Wandastr.', '3', '18609', NULL, '1956-07-12'),
(57, 'Blengert', 'Ernst', 'Margaretenstr.', '4', '18609', NULL, '1962-12-04'),
(58, 'Küfner', 'Beate', 'Putbuser Str.', '27', '18609', NULL, '1975-06-23'),
(59, 'Dorn', 'Elfriede', 'Südstr.', '23', '18609', NULL, '1965-04-15'),
(60, 'Eckner', 'Paul', 'Kleiststr.', '7', '07545', NULL, '1962-03-25'),
(61, 'Meyer', 'Angelika', 'Industriestr.', '3', '07546', NULL, '1964-04-02'),
(62, 'Engelbert', 'Torsten', 'Fliederweg', '9', '07546', NULL, '1963-02-25'),
(63, 'Ullrich', 'Hermann', 'Puschkinplatz', '4', '07545', NULL, '1956-08-24'),
(64, 'Drescher', 'Klaus', 'Ernseer Str.', '1', '07548', NULL, '1964-08-27'),
(65, 'Mehnert', 'Karin', 'Turmstraße', '19', '07546', NULL, '1963-06-30'),
(66, 'Schäfer', 'Daniela', 'Keplerstr.', '10', '07549', NULL, '1968-02-28'),
(67, 'Johannsen', 'Ilona', 'Dorfstr.', '80 a', '07639', NULL, '1956-01-31'),
(68, 'Heinert', 'Frank', 'Leipziger Str.', '14', '07545', NULL, '1965-09-30'),
(69, 'Laufert', 'Ingo', 'Am Sportplatz', '24', '07552', NULL, '1975-05-31'),
(70, 'Eifert', 'Hans', 'Alte Dorfstr.', '3', '04448', NULL, '1976-05-21'),
(71, 'Horstmann', 'Uwe', 'Brackestr.', '33', '04207', NULL, '1966-02-26'),
(72, 'Meinert', 'Heiner', 'Annaberger Str.', '4', '04159', NULL, '1956-04-24'),
(73, 'Maierl', 'Kurt', 'Aurelienstr.', '15', '04177', NULL, '1984-08-26'),
(74, 'Ferner', 'Bruno', 'Husemannstr.', '3', '04315', NULL, '1987-06-30'),
(75, 'Bader', 'Gustav', 'Merkwitzer Str.', '24', '04356', NULL, '1982-04-12'),
(76, 'Fleischhauer', 'Kuno', 'Bernhard-Göring-Str.', '118', '04275', NULL, '1976-06-04'),
(77, 'Fellmann', 'Guido', 'Robert-Schumann-Str.', '5', '04107', NULL, '1973-09-21'),
(78, 'Gerber', 'Cornelia', 'Richard-Lehmann-Str.', '36', '04275', NULL, '1967-06-21'),
(79, 'Nagel', 'Brigitte', 'Könneritzstr.', '75', '04229', NULL, '1959-06-13'),
(80, 'Opitz', 'Janine', 'Straße des 18. Oktobers', '26', '04315', NULL, '1976-05-26'),
(81, 'Kampner', 'Roswita', 'Härtelstr.', '4', '04107', NULL, '1981-05-08'),
(82, 'Schubert', 'Bruno', 'Maistr.', '31', '80337', NULL, '1958-06-03'),
(83, 'Gruner', 'Christian', 'Rosenheimer Str.', '145 a', '81671', NULL, '1976-05-16'),
(84, 'Henze', 'Michael', 'Melusinenstr.', '2', '81671', NULL, '1986-02-04'),
(85, 'Schuster', 'Marcus', 'Nikolaistr', '5', '80802', NULL, '1984-09-19'),
(86, 'Cäsar', 'Harald', 'Lessingstr.', '16', '19059', NULL, '1958-02-02'),
(87, 'Behr', 'Luise', 'Kösliner Str.', '9', '44581', NULL, '1983-06-27'),
(88, 'Plüschke', 'Dora', 'Wasserwerkstr.', '33', '44575', NULL, '1972-09-25'),
(89, 'Lehmann', 'Gertrud', 'Wuppertaler Str.', '33', '19063', NULL, '1969-08-15'),
(90, 'Uhlisch', 'Manfred', 'Güstrower Str.', '11', '19055', NULL, '1983-11-25'),
(91, 'Walter', 'Kurt', 'Alte Dorfstr.', '39', '19063', NULL, '1986-06-09'),
(92, 'Vogel', 'Kerstin', 'Eschenbachstr.', '12', '81549', NULL, '1972-08-19'),
(93, 'Krämer', 'Inge', 'Kurhausstr.', '21', '25999', NULL, '1976-04-16'),
(94, 'Auster', 'Leon', 'Stieglitzweg', '4', '25999', NULL, '1956-08-15'),
(95, 'Buchwald', 'Marlies', 'Börderstich', '3 b', '25999', NULL, '1983-06-30'),
(96, 'Schnurpel', 'Wolfgang', 'Zur Düne', '7', '25999', NULL, '1986-09-25'),
(97, 'Zetsche', 'Marion', 'Theresienstr.', '155', '80333', NULL, '1984-09-24'),
(98, 'Schieler', 'Helena', 'Domagkstr.', '24', '80807', NULL, '1972-05-19'),
(99, 'Fläming', 'Johannes', 'Schönfeldstr.', '10', '80539', NULL, '1964-03-06'),
(100, 'Wolter', 'Axel', 'Im Hagen', '6', '44581', NULL, '1964-08-16'),
(105, 'Illner', 'Hans', 'Rochlitzer Str.', '1', '04651', 55, '1972-05-19'),
(106, 'Meier', 'Susi', 'Königswarterstr.', '2', '60316', 4, '1972-04-21'),
(107, 'Apelt', 'Auguste', 'Melemstr.', '4', '60322', 24, '1964-08-29'),
(108, 'Backhaus', 'Erna', 'Heidestr.', '1', '60385', 150, '1957-08-14');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `orte`
--

CREATE TABLE IF NOT EXISTS `orte` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `ort` varchar(55) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=23 ;

--
-- Daten für Tabelle `orte`
--

INSERT INTO `orte` (`id`, `ort`) VALUES
(1, 'Leipzig'),
(2, 'Wiederitzsch'),
(3, 'Bad Lausick'),
(4, 'Gera'),
(5, 'Ernsee'),
(6, 'Tautenhain'),
(7, 'Berlin'),
(9, 'Ostseebad Binz'),
(10, 'Schwerin'),
(11, 'Hamburg'),
(12, 'Reinbek'),
(13, 'Kampen'),
(14, 'Castrop-Rauxel'),
(15, 'Krefeld'),
(16, 'Nierstein'),
(17, 'Frankfurt'),
(18, 'Tuxhausen'),
(19, 'Trautheim'),
(20, 'München'),
(21, 'Niederdorf'),
(22, 'Kressbronn');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `plzorte`
--

CREATE TABLE IF NOT EXISTS `plzorte` (
  `plz` varchar(5) NOT NULL,
  `o_id` int(11) NOT NULL,
  PRIMARY KEY (`plz`),
  KEY `o_id` (`o_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Daten für Tabelle `plzorte`
--

INSERT INTO `plzorte` (`plz`, `o_id`) VALUES
('04107', 1),
('04159', 1),
('04177', 1),
('04207', 1),
('04229', 1),
('04275', 1),
('04315', 1),
('04356', 1),
('04448', 2),
('04651', 3),
('07545', 4),
('07546', 4),
('07549', 4),
('07552', 4),
('07548', 5),
('07639', 6),
('10115', 7),
('10119', 7),
('10623', 7),
('10625', 7),
('10999', 7),
('12053', 7),
('12157', 7),
('12305', 7),
('12489', 7),
('12587', 7),
('12689', 7),
('13503', 7),
('13593', 7),
('18609', 9),
('19055', 10),
('19059', 10),
('19063', 10),
('20099', 11),
('20144', 11),
('20251', 11),
('20355', 11),
('22111', 11),
('22113', 11),
('22297', 11),
('22529', 11),
('22763', 11),
('21465', 12),
('25999', 13),
('44575', 14),
('44581', 14),
('47800', 15),
('47803', 15),
('47805', 15),
('47807', 15),
('55283', 16),
('60316', 17),
('60318', 17),
('60322', 17),
('60385', 17),
('63368', 18),
('64688', 19),
('80333', 20),
('80337', 20),
('80539', 20),
('80802', 20),
('80807', 20),
('81549', 20),
('81671', 20),
('82528', 21),
('88079', 22);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `projekt_mitarbeiter`
--

CREATE TABLE IF NOT EXISTS `projekt_mitarbeiter` (
  `ma_id` int(11) NOT NULL,
  `p_id` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ma_id`,`p_id`),
  KEY `p_id` (`p_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Daten für Tabelle `projekt_mitarbeiter`
--

INSERT INTO `projekt_mitarbeiter` (`ma_id`, `p_id`) VALUES
(2, 1),
(5, 1),
(11, 1),
(8, 2),
(25, 2),
(17, 4),
(47, 4),
(59, 4);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `projekte`
--

CREATE TABLE IF NOT EXISTS `projekte` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) DEFAULT NULL,
  `beginn` date DEFAULT NULL,
  `ende` date DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Daten für Tabelle `projekte`
--

INSERT INTO `projekte` (`id`, `name`, `beginn`, `ende`) VALUES
(1, 'Buchprojekt', '2018-07-01', '2018-08-20'),
(2, 'Renovierung des Pausenraumes', '2018-07-01', '2018-07-10'),
(3, 'Anlegen eines Pflichtenheftes', '2018-03-10', '2018-04-12'),
(4, 'Werbeaktion', '2018-04-01', '2018-04-30');

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `abteilungen`
--
ALTER TABLE `abteilungen`
  ADD CONSTRAINT `abteilungen_ibfk_1` FOREIGN KEY (`o_id`) REFERENCES `orte` (`id`);

--
-- Constraints der Tabelle `artikel_lieferanten`
--
ALTER TABLE `artikel_lieferanten`
  ADD CONSTRAINT `artikel_lieferanten_ibfk_1` FOREIGN KEY (`a_id`) REFERENCES `artikel` (`id`),
  ADD CONSTRAINT `artikel_lieferanten_ibfk_2` FOREIGN KEY (`L_id`) REFERENCES `lieferanten` (`id`);

--
-- Constraints der Tabelle `lager`
--
ALTER TABLE `lager`
  ADD CONSTRAINT `lager_ibfk_1` FOREIGN KEY (`a_id`) REFERENCES `artikel` (`id`);

--
-- Constraints der Tabelle `lieferanten`
--
ALTER TABLE `lieferanten`
  ADD CONSTRAINT `lieferanten_ibfk_1` FOREIGN KEY (`plz`) REFERENCES `plzorte` (`PLZ`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints der Tabelle `mitarbeiter`
--
ALTER TABLE `mitarbeiter`
  ADD CONSTRAINT `mitarbeiter_ibfk_1` FOREIGN KEY (`plz`) REFERENCES `plzorte` (`PLZ`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints der Tabelle `plzorte`
--
ALTER TABLE `plzorte`
  ADD CONSTRAINT `plzorte_ibfk_1` FOREIGN KEY (`o_id`) REFERENCES `orte` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints der Tabelle `projekt_mitarbeiter`
--
ALTER TABLE `projekt_mitarbeiter`
  ADD CONSTRAINT `projekt_mitarbeiter_ibfk_1` FOREIGN KEY (`ma_id`) REFERENCES `mitarbeiter` (`id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `projekt_mitarbeiter_ibfk_2` FOREIGN KEY (`p_id`) REFERENCES `projekte` (`id`) ON DELETE NO ACTION ON UPDATE CASCADE;
