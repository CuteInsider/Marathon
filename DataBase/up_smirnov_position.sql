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
-- Table structure for table `position`
--

DROP TABLE IF EXISTS `position`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `position` (
  `Position_ID` int(11) NOT NULL,
  `Position_Name` varchar(24) DEFAULT NULL,
  `Position_Description` varchar(76) DEFAULT NULL,
  `Pay_Period` varchar(1) DEFAULT NULL,
  `Pay_Rate` int(11) DEFAULT NULL,
  PRIMARY KEY (`Position_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `position`
--

LOCK TABLES `position` WRITE;
/*!40000 ALTER TABLE `position` DISABLE KEYS */;
INSERT INTO `position` VALUES (1,'Helpdesk Advisor','Works on the helpdesk','H',68),(2,'Administrative Clerk','Provides administrative support','H',55),(3,'HR Clerk','Provides support to the HR Manager','H',35),(4,'Finance Clerk','Provides support to the Finance Manager','H',62),(5,'Marketing Assistant','Provides support to the Marketing Manager','H',56),(6,'Social Media Assistant','Provides support to the Social Media Coordinator','H',45),(7,'Assistant','Works  in any number of areas','H',40),(8,'Workforce Support','Provides support to the Workforce Manager','H',65),(9,'CEO','Chief Executive Officer','Y',75000),(10,'Volunteer Coordinator','Coordinates  recruitment and role allocation of volunteers','Y',90000),(11,'Sponsorship Coordinator','Identifies, develops and maintains effective relationships with all sponsors','Y',70000),(13,'Social Media Coordinator','Manages content across social media platforms','Y',78000),(14,'Operations Manager','Oversees all logistical aspects of bringing the marathon together','Y',110000),(16,'IT Manager','Oversees the planning and coordinating of technological solutions','Y',130000),(19,'Administrative Manager','Oversees the administrative functions of the organisation','Y',65000),(20,'HR Manager','Manages the recruitment, retention and development of staff','Y',70000),(21,'Finance Manager','Responsible for the financial health of Marathon Skills','Y',115000),(23,'Workforce Manager','Responsible for coordinating the workforce at the venue','Y',130);
/*!40000 ALTER TABLE `position` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-06-18 15:55:19
