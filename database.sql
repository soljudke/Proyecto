CREATE DATABASE  IF NOT EXISTS `database` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `database`;
-- MySQL dump 10.13  Distrib 5.6.13, for Win32 (x86)
--
-- Host: 127.0.0.1    Database: database
-- ------------------------------------------------------
-- Server version	5.6.17

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
-- Table structure for table `armando`
--

DROP TABLE IF EXISTS `armando`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `armando` (
  `IdPalabra` int(11) NOT NULL AUTO_INCREMENT,
  `Palabra` varchar(45) DEFAULT NULL,
  `CantidadDeLetras` int(11) DEFAULT NULL,
  `Silabas` varchar(45) DEFAULT NULL,
  `Foto` varchar(45) DEFAULT NULL,
  `NIvel` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`IdPalabra`),
  UNIQUE KEY `IdPalabra_UNIQUE` (`IdPalabra`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `armando`
--

LOCK TABLES `armando` WRITE;
/*!40000 ALTER TABLE `armando` DISABLE KEYS */;
INSERT INTO `armando` VALUES (1,'flor',4,' ','flor.png','1'),(2,'casa',4,'ca-sa','casa.png','1'),(3,'perro',5,'pe-rro','perro.png','1'),(4,'gato',4,'ga-to','gato.png','1'),(5,'colectivo',9,'co-lec-ti-vo','colectivo.png','2'),(6,'mariposa',8,'ma-ri-po-sa','mariposa.png','2'),(7,'estrella',8,'es-tre-lla','estrella.png','2'),(8,'elefante',8,'e-le-fan-te','elefante.png','2'),(9,'jirafa',6,'ji-ra-fa','jirafa.png','1');
/*!40000 ALTER TABLE `armando` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-05-04 15:37:50
