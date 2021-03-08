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
-- Table structure for table `staff`
--

DROP TABLE IF EXISTS `staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `staff` (
  `Staff_ID_Num` int(11) NOT NULL,
  `Full_Name` varchar(11) DEFAULT NULL,
  `Second_Name` varchar(11) DEFAULT NULL,
  `Date_of_BirtHourlyourly` datetime DEFAULT NULL,
  `Gender` varchar(1) DEFAULT NULL,
  `Position_ID` int(11) DEFAULT NULL,
  `Email_Address` varchar(31) DEFAULT NULL,
  `Comments` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Staff_ID_Num`),
  KEY `PositionID` (`Position_ID`),
  CONSTRAINT `PositionId` FOREIGN KEY (`Position_ID`) REFERENCES `position` (`Position_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff`
--

LOCK TABLES `staff` WRITE;
/*!40000 ALTER TABLE `staff` DISABLE KEYS */;
INSERT INTO `staff` VALUES (1,'LAKISHA ','TOMBLIN','1961-08-06 16:02:12','F',2,'l_tomblin@nnl.com',NULL),(2,'KRIS','SWEELY','1980-12-24 16:02:12','M',3,'k_sweely@yahoo.com',NULL),(3,'ELSIE','ESTELL','1974-07-07 16:02:12','F',8,'elsie.estell@rrg.net',NULL),(4,'TYRELL','ROSENBERG','1965-08-02 16:02:12','M',6,'tyrell_rosenberg@hotmail.com',NULL),(5,'MADELYN ','HOOVER','1962-12-04 16:02:12','F',1,'madelyn_hoover@hotmail.com',NULL),(6,'KENETH ','PARHAM','1967-03-30 16:02:12','M',2,'k_parham@live.com',NULL),(7,'LYLE ','MALLORY','1989-07-06 16:02:12','M',8,'l_mallory@live.com',NULL),(8,'CLIFTON ','FIGUEROA','1956-03-23 16:02:12','M',6,'c_figueroa@live.com',NULL),(9,'MOHAMMAD','RICHEY','1995-07-01 16:02:12','M',2,'mohammad_richey@jcl.net',NULL),(10,'WINIFRED ','DUNCAN','1968-10-20 16:02:12','F',11,'w_duncan@hotmail.com',NULL),(11,'VERNITA ','SEABORN','1993-10-13 16:02:12','F',19,'v_seaborn@gmail.com',NULL),(12,'LENORA','HIGGINS','1997-06-29 16:02:12','F',3,'l_higgins@msv.org',NULL),(13,'DON ','RUSS','1971-10-13 16:02:12','M',4,'don_russ@jcl.net',NULL),(14,'THADDEUS ','STALEY','1992-02-13 16:02:12','M',7,'t_staley@nnl.com',NULL),(15,'WILFORD ','RIVERA','1978-09-21 16:02:12','M',1,'wilford.rivera@gmail.com',NULL),(16,'LANCE','BEYER','1990-09-30 16:02:12','M',5,'l_beyer@rnl.com',NULL),(17,'LASHANDA','SNOWDEN','1983-06-28 16:02:12','F',8,'lashanda.snowden@rrg.net',NULL),(18,'GLORY ','FELDER','1963-11-18 16:02:12','F',3,'glory.felder@hotmail.com',NULL),(19,'ESTELLA ','BLALOCK','1951-10-17 16:02:12','F',7,'e_blalock@ccf.org',NULL),(20,'TRAVIS ','RAMOS','1983-04-21 16:02:12','M',1,'travis_ramos@hotmail.com',NULL),(21,'ILA ','THOMPSON','1979-05-17 16:02:12','F',2,'i_thompson@yahoo.com',NULL),(22,'LORRAINE','MCKEE','1973-10-11 16:02:12','F',6,'l_mckee@hotmail.com',NULL),(23,'SHELLIE ','MONTANO','1974-09-19 16:02:12','F',1,'shellie_montano@hotmail.com',NULL),(24,'ERVIN ','LAWRENCE','1984-12-20 16:02:12','M',8,'ervin_lawrence@hotmail.com',NULL),(25,'GOLDA ','GRANGER','1982-04-28 16:02:12','F',8,'g_granger@msv.org',NULL),(26,'KING','MERCADO','1952-11-26 16:02:12','M',13,'k_mercado@hotmail.com',NULL),(27,'GERARDO ','BOWSER','1953-08-19 16:02:12','M',2,'gerardo_bowser@hotmail.com',NULL),(28,'KARIN ','MCCARTY','1985-10-17 16:02:12','F',3,'k_mccarty@gmail.com',NULL),(29,'MAYRA ','CALLAHAN','1979-08-07 16:02:12','F',6,'m_callahan@live.com',NULL),(30,'CALLAN','MCCONNELL','1958-12-13 16:02:12','M',8,'callan.mcconnell@gmail.com',NULL),(31,'CLAYTON ','MARKS','1988-03-08 16:02:12','M',5,'c_marks@nnl.com',NULL),(32,'TRACY ','CUMMINGS','1991-01-07 16:02:12','F',4,'tracy.cummings@gmail.com',NULL),(33,'NELSON ','CASEY','1986-06-18 16:02:12','M',8,'n_casey@hr.org',NULL),(34,'STAN ','STOVALL','1960-10-07 16:02:12','M',6,'s_stovall@gmail.com',NULL),(35,'EARLENE','HOGAN','1964-02-27 16:02:12','F',8,'e_hogan@gmail.com',NULL),(36,'WAYNE','ROSARIO','1953-06-20 16:02:12','M',5,'w_rosario@gmail.com',NULL),(37,'AUTUMN ','MCCALL','1965-03-11 16:02:12','F',3,'autumn.mccall@rrg.net',NULL),(38,'PRINCESS ','CATT','1970-06-21 16:02:12','F',8,'p_catt@hotmail.com',NULL),(39,'SIBYL ','TAGALA','1998-05-21 16:02:12','F',1,'sibyl.tagala@hotmail.com',NULL),(40,'MILAGROS ','BUSCH','1965-12-20 16:02:12','F',8,'milagros_busch@jcl.net',NULL),(41,'DONNIE ','JENNINGS','1969-10-15 16:02:12','F',1,'d_jennings@msv.org',NULL),(42,'OTIS ','ENRIQUEZ','1986-01-11 16:02:12','M',11,'otis_enriquez@hotmail.com',NULL),(43,'PETE ','REDDING','1988-12-17 16:02:12','M',2,'p_redding@ccf.org',NULL),(44,'VAN','JACK','1967-02-18 16:02:12','M',8,'v_jack@hr.org',NULL),(45,'CYNTHIA ','SOSA','1989-11-08 16:02:12','F',8,'c_sosa@gmail.com',NULL),(46,'LUCIA ','SPICER','1952-09-26 16:02:12','F',7,'l_spicer@yahoo.com',NULL),(47,'TONJA','LEPPALA','1958-05-20 16:02:12','F',8,'t_leppala@yahoo.com',NULL),(48,'RENATO ','CREECH','1967-11-08 16:02:12','M',3,'renato.creech@yahoo.com',NULL),(49,'DESMOND ','JEFFERS','1952-05-31 16:02:12','M',7,'desmond_jeffers@hotmail.com',NULL),(50,'CANDELARIA ','WISE','1967-08-01 16:02:12','F',4,'c_wise@hotmail.com',NULL),(51,'RORY','RODEFER','1995-09-19 16:02:12','M',5,'rory_rodefer@ffrs.gov',NULL),(52,'SHERRI','CRAWFORD','1953-01-24 16:02:12','F',3,'s_crawford@yahoo.com',NULL),(53,'MANUELA ','PRUETT','1964-10-03 16:02:12','F',3,'manuela_pruett@yahoo.com',NULL),(54,'TASHA ','INGRAHAM','1965-10-06 16:02:12','F',1,'t_ingraham@gmail.com',NULL),(55,'TAMIKA ','ESCOBEDO','1951-03-29 16:02:12','F',3,'t_escobedo@msv.org',NULL),(56,'MARTYN ','GLEASON','1979-06-08 16:02:12','M',2,'m_gleason@nnl.com',NULL),(57,'CHRISTOPHER','LANGEVIN','1962-11-12 16:02:12','M',4,'c_langevin@hotmail.com',NULL),(58,'NICHOLAS','FORRESTER','1996-08-29 16:02:12','M',6,'nicholas.forrester@rrg.net',NULL),(59,'MARITA ','ELAM','1984-02-21 16:02:12','F',1,'m_elam@yahoo.com',NULL),(60,'RYAN ','HAHN','1968-04-20 16:02:12','M',7,'ryan_hahn@hotmail.com',NULL),(61,'CHI ','MIMS','1963-08-05 16:02:12','M',7,'c_mims@msv.org',NULL),(62,'SUSAN ','VANCE','1973-09-07 16:02:12','F',2,'s_vance@gmail.com',NULL),(63,'GARETH ','ROBERSON','1978-04-30 16:02:12','M',11,'g_roberson@nnl.com',NULL),(64,'GREIG ','WALTERS','1976-11-03 16:02:12','M',5,'g_walters@hotmail.com',NULL),(65,'ARMANDO ','MOSLEY','1956-01-01 16:02:12','M',3,'a_mosley@hotmail.com',NULL),(66,'JAYSON','MCCLELLAND','1967-03-15 16:02:12','M',3,'j_mcclelland@yahoo.com',NULL),(67,'GRANT ','DOWDY','1955-12-15 16:02:12','M',21,'grant.dowdy@hotmail.com',NULL),(68,'ALVA ','OWEN','1971-08-20 16:02:12','F',5,'a_owen@hotmail.com',NULL),(69,'ELDON','CRAIG','1983-07-15 16:02:12','M',10,'e_craig@gmail.com',NULL),(70,'BOYCE ','WILLIAM','1983-12-06 16:02:12','M',4,'b_william@hotmail.com',NULL),(71,'VITO ','KANIECKI','1965-03-31 16:02:12','M',4,'v_kaniecki@hr.org',NULL),(72,'NAPOLEON ','PEDROZO','1964-04-07 16:02:12','M',2,'n_pedrozo@hotmail.com',NULL),(73,'DARYL ','MASON','1977-08-14 16:02:12','M',5,'d_mason@fin.gov',NULL),(74,'LESLIE ','BOSTON','1995-07-24 16:02:12','M',3,'leslie.boston@yahoo.com',NULL),(75,'MITCHEL ','KIM','1994-12-29 16:02:12','M',2,'m_kim@hotmail.com',NULL),(76,'BERTA','HERMAN','1993-05-24 16:02:12','F',13,'b_herman@gmail.com',NULL),(77,'WILDA ','LAMBERT','1991-09-03 16:02:12','F',6,'w_lambert@yahoo.com',NULL),(78,'NEVA ','CLAY','1978-12-26 16:02:12','F',7,'n_clay@gmail.com',NULL),(79,'CHARLES ','MACK','1975-08-11 16:02:12','M',3,'c_mack@hotmail.com',NULL),(80,'HETTIE ','CARMONA','1996-06-08 16:02:12','F',4,'h_carmona@ccf.org',NULL),(81,'LUCIEN','MURILLO','1965-06-24 16:02:12','M',10,'l_murillo@fin.gov',NULL),(82,'DEVON','GOBERN','1958-09-02 16:02:12','M',8,'d_gobern@ccf.org',NULL),(83,'KRISTA ','EARLY','1985-08-21 16:02:12','F',5,'k_early@hr.org',NULL),(84,'GREIG ','CONN','1993-10-30 16:02:12','M',6,'greig_conn@hotmail.com',NULL),(85,'IRMA','MONTANEZ','1954-11-27 16:02:12','F',8,'i_montanez@gmail.com',NULL),(86,'JERRELL','OHARA','1967-05-16 16:02:12','M',8,'j_ohara@msv.org',NULL),(87,'BRANDON','YANG','1975-10-10 16:02:12','M',5,'brandon.yang@gmail.com',NULL),(88,'MARLENE ','SCHUMACHER','1987-11-05 16:02:12','F',4,'marlene.schumacher@rrg.net',NULL),(89,'CLEMENTINE ','JACKSON','1972-06-13 16:02:12','F',8,'clementine.jackson@gmail.com',NULL),(90,'SHAWANDA ','CANTU','1977-05-02 16:02:12','F',13,'s_cantu@hr.org',NULL),(91,'TAMIKA ','COE','1953-09-02 16:02:12','F',8,'t_coe@fin.gov',NULL),(92,'ABRAHAM ','GATLIN','1987-06-19 16:02:12','M',8,'abraham.gatlin@hotmail.com',NULL),(93,'JANE','HEDRICK','1975-03-05 16:02:12','F',5,'j_hedrick@gmail.com',NULL),(94,'ALONSO','HITCHCOCK','1968-01-29 16:02:12','M',8,'alonso.hitchcock@gmail.com',NULL),(95,'LEO ','VEGA','1957-11-17 16:02:12','M',3,'l_vega@live.com',NULL),(96,'TANA ','HILLMAN','1957-01-20 16:02:12','F',2,'tana_hillman@hotmail.com',NULL),(97,'NELLIE','LINDSEY','1985-06-05 16:02:12','F',2,'n_lindsey@ccf.org',NULL),(98,'KELLEY','DANIEL','1966-06-19 16:02:12','M',7,'kelley.daniel@gmail.com',NULL),(99,'MARGARETTE','STEM','1966-09-12 16:02:12','F',16,'m_stem@ccf.org',NULL),(100,'KELVIN','RULAPAUGH','1983-08-23 16:02:12','M',2,'k_rulapaugh@gmail.com',NULL),(101,'MAYRA ','SMITH','1982-01-17 16:02:12','F',7,'m_smith@yahoo.com',NULL),(102,'JANNA','NICKA','1980-08-07 16:02:12','F',7,'j_nicka@msv.org',NULL),(103,'PAULINE ','NEWCOMB','1957-12-07 16:02:12','F',1,'p_newcomb@gmail.com',NULL),(104,'ELVA ','PATTEN','1983-04-07 16:02:12','F',7,'e_patten@msv.org',NULL),(105,'SHANE ','COLAIZZO','1970-05-30 16:02:12','M',16,'s_colaizzo@fin.gov',NULL),(106,'THERSA','ARREDONDO','1964-02-02 16:02:12','F',2,'t_arredondo@gmail.com',NULL),(107,'AMPARO ','SYKES','1960-02-29 16:02:12','F',16,'a_sykes@ccf.org',NULL),(108,'JORGE ','BLACKWELL','1955-05-08 16:02:12','M',7,'j_blackwell@hotmail.com',NULL),(109,'TYLER ','BOOTH','1972-01-26 16:02:12','M',4,'t_booth@gmail.com',NULL),(110,'JORGE ','WAYMIRE','1988-02-17 16:02:12','M',1,'jorge_waymire@ffrs.gov',NULL),(111,'KENNETH','MEIER','1984-03-17 16:02:12','M',5,'kenneth_meier@ffrs.gov',NULL),(112,'AUBREY ','ERWIN','1960-11-01 16:02:12','M',7,'a_erwin@yahoo.com',NULL),(113,'CHARLES ','STILES','1981-08-25 16:02:12','M',4,'c_stiles@gmail.com',NULL),(114,'LOWELL ','BAER','1951-08-01 16:02:12','M',3,'l_baer@fin.gov',NULL),(115,'TRACEY ','ONOFRIO','1986-01-07 16:02:12','F',1,'t_onofrio@ccf.org',NULL),(116,'STELLA ','HIEBER','1972-07-23 16:02:12','F',2,'stella_hieber@hotmail.com',NULL),(117,'ROSEANNE ','VILLANUEVA','1955-06-14 16:02:12','F',9,'roseanne_villanueva@yahoo.com',NULL),(118,'VALENTIN ','PARRISH','1978-11-22 16:02:12','M',2,'valentin.parrish@rrg.net',NULL),(119,'TERESITA ','RUSH','1991-07-05 16:02:12','F',6,'t_rush@yahoo.com',NULL),(120,'CAREY ','HALEY','1979-02-04 16:02:12','F',5,'c_haley@yahoo.com',NULL),(121,'BURT ','PLATT','1962-02-27 16:02:12','M',23,'b_platt@hotmail.com',NULL),(122,'ZORA ','TATE','1967-06-23 16:02:12','F',7,'zora_tate@jcl.net',NULL),(123,'PENELOPE','ROOT','1963-07-16 16:02:12','F',3,'penelope.root@rrg.net',NULL),(124,'DENNY ','MORALES','1995-03-21 16:02:12','M',7,'denny_morales@hotmail.com',NULL),(125,'DALE','BRANCH','1982-04-06 16:02:12','M',14,'d_branch@live.com',NULL),(126,'LAURENCE ','METCALF','1956-06-13 16:02:12','M',7,'laurence.metcalf@yahoo.com',NULL),(127,'MERYL ','BENNETT','1963-04-25 16:02:12','F',7,'m_bennett@nnl.com',NULL),(128,'BERNARDO','RICHEY','1951-03-07 16:02:12','M',7,'b_richey@live.com',NULL),(129,'DAN','KINNEY','1974-02-12 16:02:12','M',4,'d_kinney@hotmail.com',NULL),(130,'ARCHIE ','ATKINSON','1970-03-06 16:02:12','M',4,'a_atkinson@ccf.org',NULL),(131,'HUGH ','VARRIANO','1958-02-10 16:02:12','M',10,'hugh.varriano@gmail.com',NULL),(132,'SONYA ','HOLBROOK','1969-12-19 16:02:12','F',16,'s_holbrook@rnl.com',NULL),(133,'PATRICA ','OLSEN','1982-09-12 16:02:12','F',5,'p_olsen@gmail.com',NULL),(134,'DELIA ','SHOMO','1986-12-19 16:02:12','F',2,'d_shomo@yahoo.com',NULL),(135,'CARLA','VINSON','1958-01-21 16:02:12','F',7,'c_vinson@ccf.org',NULL),(136,'FRANCIS ','NGUYEN','1986-11-10 16:02:12','F',13,'f_nguyen@live.com',NULL),(137,'WILLARD ','PUTNAM','1958-08-28 16:02:12','M',3,'w_putnam@gmail.com',NULL),(138,'TARSHA ','WILKINSON','1963-04-02 16:02:12','F',2,'t_wilkinson@hr.org',NULL),(139,'DEBBY ','DUNLAP','1974-01-04 16:02:12','F',23,'debby_dunlap@jcl.net',NULL),(140,'GILDA ','PERRY','1993-07-20 16:02:12','F',6,'g_perry@yahoo.com',NULL),(141,'GARRY ','SANTANA','1993-07-02 16:02:12','M',4,'g_santana@live.com',NULL),(142,'NICKOLAS ','NUNEZ','1994-03-03 16:02:12','M',7,'nickolas.nunez@gmail.com',NULL),(143,'PALMA ','GRIER','1962-08-24 16:02:12','F',4,'p_grier@yahoo.com',NULL),(144,'RUSSELL ','WHITTINGTON','1957-09-01 16:02:12','M',8,'russell_whittington@hotmail.com',NULL),(145,'OLIVE','SALMON','1954-05-07 16:02:12','F',23,'o_salmon@ccf.org',NULL),(146,'GARRETT ','BOLLINGER','1970-12-19 16:02:12','M',1,'g_bollinger@gmail.com',NULL),(147,'IGNACIO ','COKLEY','1955-01-23 16:02:12','M',6,'ignacio_cokley@jcl.net',NULL),(148,'NOBLE ','MEINERDING','1950-08-21 16:02:12','M',20,'n_meinerding@ccf.org',NULL),(149,'THELMA ','SKURSKY','1959-04-28 16:02:12','F',5,'t_skursky@rnl.com',NULL),(150,'AL ','BOWLES','1969-02-01 16:02:12','M',1,'al.bowles@hotmail.com',NULL),(151,'CRAIG ','COUSEY','1970-02-16 16:02:12','M',8,'c_cousey@gmail.com',NULL),(152,'TRACI ','BROOKS','1969-02-15 16:02:12','F',1,'traci_brooks@hotmail.com',NULL),(153,'ISABELLA ','WATERMAN','1979-01-01 16:02:12','F',4,'isabella.waterman@rrg.net',NULL),(154,'JEROME ','JACKSON','1956-01-23 16:02:12','M',4,'jerome.jackson@rrg.net',NULL),(155,'SILAS ','DIAS','1997-02-08 16:02:12','M',13,'s_dias@hotmail.com',NULL),(156,'TOD','CLARKE','1964-04-04 16:02:12','M',7,'t_clarke@ccf.org',NULL),(157,'DONNELL ','MYLES','1991-01-02 16:02:12','M',1,'d_myles@gmail.com',NULL),(158,'KEITH ','MEADOWS','1959-08-08 16:02:12','M',2,'k_meadows@live.com',NULL),(159,'JOHNNIE ','PRESTON','1957-09-19 16:02:12','M',4,'johnnie.preston@gmail.com',NULL),(160,'NANETTE ','TALBOT','1994-04-29 16:02:12','F',4,'n_talbot@hotmail.com',NULL),(161,'RENATA ','ENGLISH','1956-01-03 16:02:12','F',7,'r_english@gmail.com',NULL),(162,'SAMMIE','DICKENS','1972-07-05 16:02:12','F',3,'s_dickens@msv.org',NULL),(163,'ANDRA ','CAREY','1987-11-27 16:02:12','F',3,'a_carey@gmail.com',NULL),(164,'GREGOR ','WOLNY','1980-04-30 16:02:12','M',7,'g_wolny@yahoo.com',NULL),(165,'LUTHER ','DOYLE','1998-04-29 16:02:12','M',10,'l_doyle@gmail.com',NULL),(166,'ENOLA ','AUSTIN','1991-11-23 16:02:12','F',4,'e_austin@nnl.com',NULL),(167,'DARIUS ','NOBLE','1959-12-06 16:02:12','M',7,'d_noble@gmail.com',NULL),(168,'WILTON ','SEXTON','1982-12-03 16:02:12','M',2,'w_sexton@msv.org',NULL),(169,'KATHY','KRAMER','1989-02-20 16:02:12','F',7,'kathy_kramer@yahoo.com',NULL),(170,'LUPE ','MAILLARD','1981-04-23 16:02:12','F',1,'lupe_maillard@hotmail.com',NULL),(171,'LEANNE ','NIELSEN','1982-06-22 16:02:12','F',1,'l_nielsen@gmail.com',NULL),(172,'SEYMOUR ','GROVES','1978-05-02 16:02:12','M',4,'seymour.groves@rrg.net',NULL),(173,'GLENNA ','FELTON','1964-06-21 16:02:12','F',2,'g_felton@hotmail.com',NULL),(174,'LIN ','PALAIA','1961-12-03 16:02:12','F',7,'lin.palaia@yahoo.com',NULL),(175,'SHANELL ','ORTIZ','1962-08-29 16:02:12','F',6,'shanell_ortiz@jcl.net',NULL),(176,'NICOLETTE ','DAVISON','1996-05-17 16:02:12','F',3,'n_davison@ccf.org',NULL),(177,'GREGORIA','RYDER','1955-09-21 16:02:12','F',2,'gregoria.ryder@gmail.com',NULL),(178,'KARRIE','TRUJILLO','1990-11-08 16:02:12','F',1,'k_trujillo@hr.org',NULL),(179,'STACEY ','SWITZER','1955-07-23 16:02:12','F',2,'stacey.switzer@hotmail.com',NULL),(180,'KATHERYN ','SPEER','1976-02-11 16:02:12','F',7,'k_speer@gmail.com',NULL),(181,'PRUDENCE ','HACKETT','1950-09-30 16:02:12','F',10,'p_hackett@hotmail.com',NULL),(182,'ROSANNE ','CORCORAN','1977-01-19 16:02:12','F',1,'rosanne_corcoran@jcl.net',NULL),(183,'ROSALIE','STEM','1985-07-15 16:02:12','F',1,'rosalie.stem@hotmail.com',NULL),(184,'GEORGE ','LYONS','1984-03-12 16:02:12','M',6,'george_lyons@ffrs.gov',NULL),(185,'JAYNE ','HARMAN','1982-01-11 16:02:12','F',2,'j_harman@yahoo.com',NULL),(186,'MALLORY ','WORRELL','1992-01-25 16:02:12','F',23,'m_worrell@hotmail.com',NULL),(187,'CAMERON ','NORMAN','1974-12-16 16:02:12','M',7,'cameron.norman@yahoo.com',NULL),(188,'BERNARD ','CROSBY','1977-02-06 16:02:12','M',6,'b_crosby@yahoo.com',NULL),(189,'SHANELL ','VILLALOBOS','1960-03-19 16:02:12','F',7,'s_villalobos@yahoo.com',NULL),(190,'EVELYN ','DEMESA','1961-06-08 16:02:12','F',10,'e_demesa@live.com',NULL),(191,'TY ','LABRECHE','1966-06-25 16:02:12','M',3,'t_labreche@hotmail.com',NULL),(192,'BRANDEE ','MEANS','1962-06-03 16:02:12','F',6,'b_means@nnl.com',NULL),(193,'LARISSA ','COTTRELL','1957-08-10 16:02:12','F',5,'l_cottrell@gmail.com',NULL),(194,'FRIEDA ','BRAND','1965-04-28 16:02:12','F',6,'frieda_brand@hotmail.com',NULL),(195,'DANI ','GRIFFIN','1994-07-24 16:02:12','F',14,'d_griffin@gmail.com',NULL),(196,'LEE ','DOW','1960-12-28 16:02:12','M',11,'l_dow@yahoo.com',NULL),(197,'MEAGAN','BRUCE','1982-03-20 16:02:12','F',5,'m_bruce@live.com',NULL),(198,'JEANETTE ','DOYLE','1989-10-14 16:02:12','F',5,'jeanette_doyle@jcl.net',NULL),(199,'ANTHONY ','SHAW','1977-06-27 16:02:12','M',5,'anthony.shaw@rrg.net',NULL),(200,'ROBYN ','ROSA','1984-05-13 16:02:12','F',3,'r_rosa@msv.org',NULL),(201,'RANDI ','CHAFFINS','1979-08-27 16:02:12','F',4,'r_chaffins@gmail.com',NULL),(202,'MARJORIE ','BLEDSOE','1969-07-13 16:02:12','F',6,'m_bledsoe@gmail.com',NULL),(203,'DALE ','PEARSON','1975-11-01 16:02:12','M',4,'d_pearson@live.com',NULL),(204,'PAULA','BROWER','1960-04-09 16:02:12','F',9,'paula_brower@hotmail.com',NULL),(205,'DEVIN ','MEYERS','1973-07-01 16:02:12','M',3,'d_meyers@nnl.com',NULL),(206,'CHANTEL ','LINDSEY','1972-04-14 16:02:12','F',4,'chantel_lindsey@ffrs.gov',NULL),(207,'TOMAS','ABERNATHY','1958-11-18 16:02:12','M',2,'t_abernathy@hr.org',NULL),(208,'KRISTI ','CROOK','1972-10-16 16:02:12','F',2,'k_crook@hr.org',NULL),(209,'RAMIRO ','HIATT','1952-05-25 16:02:12','M',7,'ramiro.hiatt@yahoo.com',NULL),(210,'MARANDA ','MEIER','1952-08-18 16:02:12','F',2,'m_meier@live.com',NULL),(211,'HESTER ','CARDENAS','1975-01-05 16:02:12','F',8,'h_cardenas@gmail.com',NULL),(212,'JOESPH ','LANKFORD','1993-03-06 16:02:12','M',5,'joesph_lankford@hotmail.com',NULL),(213,'BRANDY ','MUELLER','1972-02-15 16:02:12','F',5,'b_mueller@hotmail.com',NULL),(214,'MAUD ','MORGAN','1971-10-19 16:02:12','F',2,'m_morgan@gmail.com',NULL),(215,'IDA','GUERRERO','1989-11-30 16:02:12','F',6,'i_guerrero@hr.org',NULL),(216,'TOMASA ','HANDY','1956-12-14 16:02:12','F',1,'t_handy@hotmail.com',NULL),(217,'DANNY ','WILLARD','1953-11-26 16:02:12','M',23,'d_willard@hotmail.com',NULL),(218,'DEMETRA','DURHAM','1998-05-01 16:02:12','F',5,'d_durham@rnl.com',NULL),(219,'SAUL ','PYLE','1998-04-26 16:02:12','M',4,'s_pyle@fin.gov',NULL),(220,'CECELIA ','MCDONALD','1968-06-22 16:02:12','F',6,'c_mcdonald@nnl.com',NULL),(221,'JULES ','BLACKMAN','1979-07-01 16:02:12','M',4,'jules_blackman@hotmail.com',NULL),(222,'DEBBY ','NUGENT','1958-11-03 16:02:12','F',4,'d_nugent@rnl.com',NULL),(223,'MARTIN','JIMENEZ','1994-05-05 16:02:12','M',1,'m_jimenez@hotmail.com',NULL),(224,'WARREN ','PINTO','1973-10-16 16:02:12','M',8,'warren.pinto@rrg.net',NULL),(225,'JUDI ','NEWMAN','1961-03-15 16:02:12','F',2,'j_newman@ccf.org',NULL),(226,'BORIS ','LEBLANC','1977-08-28 16:02:12','M',6,'boris_leblanc@jcl.net',NULL),(227,'GERTRUDE ','ALFARO','1972-01-07 16:02:12','F',19,'g_alfaro@rnl.com',NULL),(228,'JONATHON','DELASANCHA','1952-06-17 16:02:12','M',5,'jonathon.delasancha@rrg.net',NULL),(229,'LIZABETH','HUMPHREY','1998-02-08 16:02:12','F',7,'l_humphrey@ccf.org',NULL),(230,'KATHI ','FULTON','1977-06-10 16:02:12','F',1,'k_fulton@yahoo.com',NULL),(231,'DENIS','BUCK','1966-06-05 16:02:12','M',3,'d_buck@hotmail.com',NULL),(232,'BRET ','ACUFF','1951-01-26 16:02:12','M',5,'b_acuff@hotmail.com',NULL),(233,'BEULAH ','OSTOLAZA','1955-10-13 16:02:12','F',7,'b_ostolaza@msv.org',NULL),(234,'RODOLFO ','MERCADO','1954-02-11 16:02:12','M',7,'r_mercado@yahoo.com',NULL),(235,'LEONARDO ','CONNER','1998-05-16 16:02:12','M',3,'l_conner@live.com',NULL),(236,'ARTHUR ','YUM','1957-03-26 16:02:12','M',4,'a_yum@yahoo.com',NULL),(237,'MARSHALL ','CHANG','1984-08-01 16:02:12','M',8,'m_chang@gmail.com',NULL),(238,'CHUN','RYAN','1974-03-02 16:02:12','F',5,'c_ryan@yahoo.com',NULL),(239,'JACK','GRUBB','1973-01-06 16:02:12','M',3,'j_grubb@hr.org',NULL),(240,'BLANCH ','HARDING','1987-07-08 16:02:12','F',7,'b_harding@fin.gov',NULL),(241,'ANGEL ','JERNIGAN','1962-01-20 16:02:12','F',6,'a_jernigan@ccf.org',NULL),(242,'STEPHAINE ','FARRELL','1978-12-10 16:02:12','F',23,'s_farrell@yahoo.com',NULL),(243,'ELIJAH ','SNOW','1990-01-07 16:02:12','M',23,'e_snow@yahoo.com',NULL),(244,'RORY ','HENGEL','1996-05-22 16:02:12','M',7,'r_hengel@hotmail.com',NULL),(245,'JOSEFINA ','CHRISTIAN','1997-01-16 16:02:12','F',5,'josefina.christian@yahoo.com',NULL),(246,'JANNA ','HILLS','1995-10-14 16:02:12','F',5,'janna_hills@hotmail.com',NULL),(247,'QUINCY ','LAMBERT','1977-09-21 16:02:12','M',2,'quincy_lambert@hotmail.com',NULL),(248,'JERRY ','DARLING','1980-02-25 16:02:12','F',6,'j_darling@ccf.org',NULL),(249,'SUSIE ','CARDONA','1986-03-11 16:02:12','F',7,'susie_cardona@yahoo.com',NULL),(250,'ALEXANDRIA ','SMALLS','1980-05-17 16:02:12','F',6,'alexandria.smalls@hotmail.com',NULL),(251,'DESMOND ','STONE','1991-03-28 16:02:12','M',20,'d_stone@gmail.com',NULL);
/*!40000 ALTER TABLE `staff` ENABLE KEYS */;
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