-- MySQL dump 10.13  Distrib 5.7.12, for Win32 (AMD64)
--
-- Host: localhost    Database: up_smirnov
-- ------------------------------------------------------
-- Server version	5.7.21-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `registration`
--

DROP TABLE IF EXISTS `registration`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `registration` (
  `RegistrationId` int(11) NOT NULL AUTO_INCREMENT,
  `RunnerId` int(11) NOT NULL,
  `RegistrationDateTime` datetime NOT NULL,
  `RaceKitOptionId` char(1) NOT NULL,
  `RegistrationStatusId` tinyint(4) NOT NULL,
  `Cost` decimal(10,2) NOT NULL,
  `CharityId` int(11) NOT NULL,
  `SponsorshipTarget` decimal(10,2) NOT NULL,
  PRIMARY KEY (`RegistrationId`),
  KEY `RunnerId` (`RunnerId`),
  KEY `RaceKitOptionId` (`RaceKitOptionId`),
  KEY `RegistrationStatusId` (`RegistrationStatusId`),
  KEY `CharityId` (`CharityId`),
  CONSTRAINT `registration_ibfk_1` FOREIGN KEY (`RunnerId`) REFERENCES `runner` (`RunnerId`),
  CONSTRAINT `registration_ibfk_2` FOREIGN KEY (`RaceKitOptionId`) REFERENCES `racekitoption` (`RaceKitOptionId`),
  CONSTRAINT `registration_ibfk_3` FOREIGN KEY (`RegistrationStatusId`) REFERENCES `registrationstatus` (`RegistrationStatusId`),
  CONSTRAINT `registration_ibfk_4` FOREIGN KEY (`CharityId`) REFERENCES `charity` (`CharityId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `registration`
--

LOCK TABLES `registration` WRITE;
/*!40000 ALTER TABLE `registration` DISABLE KEYS */;
/*!40000 ALTER TABLE `registration` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-06-18 15:55:15
