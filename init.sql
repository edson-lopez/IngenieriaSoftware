-- MySQL dump 10.13  Distrib 5.5.62, for Win64 (AMD64)
--
-- Host: localhost    Database: homestead
-- ------------------------------------------------------
-- Server version	5.7.34

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
-- Table structure for table `brand`
--

DROP TABLE IF EXISTS `brand`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `brand` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `brand`
--

LOCK TABLES `brand` WRITE;
/*!40000 ALTER TABLE `brand` DISABLE KEYS */;
INSERT INTO `brand` VALUES (3,'BMW'),(4,'Toyota'),(5,'Tesla'),(6,'Ferrari');
/*!40000 ALTER TABLE `brand` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `building`
--

DROP TABLE IF EXISTS `building`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `building` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_order_detail` int(11) NOT NULL,
  `id_department` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `building_FK` (`id_department`),
  KEY `building_FK_1` (`id_order_detail`),
  CONSTRAINT `building_FK` FOREIGN KEY (`id_department`) REFERENCES `department` (`id`),
  CONSTRAINT `building_FK_1` FOREIGN KEY (`id_order_detail`) REFERENCES `order_detail` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `building`
--

LOCK TABLES `building` WRITE;
/*!40000 ALTER TABLE `building` DISABLE KEYS */;
/*!40000 ALTER TABLE `building` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `client`
--

DROP TABLE IF EXISTS `client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `client` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `lastname` varchar(100) NOT NULL,
  `phone` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client`
--

LOCK TABLES `client` WRITE;
/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client` VALUES (1,'Omar','Barrios','653982743','momar@gmail.com'),(2,'Dilan','Milla','765389021','milla@gmail.com'),(3,'Genfferson','Caal','827123293','geff@gmail.com'),(4,'Edson','López','45960092','rolanl1996@gmail.com');
/*!40000 ALTER TABLE `client` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `color`
--

DROP TABLE IF EXISTS `color`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `color` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `color`
--

LOCK TABLES `color` WRITE;
/*!40000 ALTER TABLE `color` DISABLE KEYS */;
INSERT INTO `color` VALUES (1,'azul'),(2,'verde'),(3,'negro'),(4,'blanco');
/*!40000 ALTER TABLE `color` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `department`
--

DROP TABLE IF EXISTS `department`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `department` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_factory` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `department_FK` (`id_factory`),
  CONSTRAINT `department_FK` FOREIGN KEY (`id_factory`) REFERENCES `factory` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `department`
--

LOCK TABLES `department` WRITE;
/*!40000 ALTER TABLE `department` DISABLE KEYS */;
INSERT INTO `department` VALUES (1,1,'Pintura'),(2,1,'Textiles'),(3,1,'Exclusividades'),(4,1,'Ingenieria Híbrida'),(5,1,'Ingeniería Eléctrica'),(6,1,'Ingeniería Gasolina');
/*!40000 ALTER TABLE `department` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `factory`
--

DROP TABLE IF EXISTS `factory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `factory` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `factory`
--

LOCK TABLES `factory` WRITE;
/*!40000 ALTER TABLE `factory` DISABLE KEYS */;
INSERT INTO `factory` VALUES (1,'Fábrica de Autos Uneatlantico');
/*!40000 ALTER TABLE `factory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order`
--

DROP TABLE IF EXISTS `order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `order` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_vehicle_model` int(11) NOT NULL,
  `id_client` int(11) NOT NULL,
  `created_at` datetime NOT NULL,
  PRIMARY KEY (`id`),
  KEY `order_FK` (`id_client`),
  KEY `order_FK_1` (`id_vehicle_model`),
  CONSTRAINT `order_FK` FOREIGN KEY (`id_client`) REFERENCES `client` (`id`),
  CONSTRAINT `order_FK_1` FOREIGN KEY (`id_vehicle_model`) REFERENCES `vehicle_model` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order`
--

LOCK TABLES `order` WRITE;
/*!40000 ALTER TABLE `order` DISABLE KEYS */;
/*!40000 ALTER TABLE `order` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order_detail`
--

DROP TABLE IF EXISTS `order_detail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `order_detail` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_order` int(11) NOT NULL,
  `id_vehicle_part` int(11) NOT NULL,
  `color` varchar(100) NOT NULL,
  `material` varchar(100) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `order_detail_FK` (`id_order`),
  KEY `order_detail_FK_1` (`id_vehicle_part`),
  CONSTRAINT `order_detail_FK` FOREIGN KEY (`id_order`) REFERENCES `order` (`id`),
  CONSTRAINT `order_detail_FK_1` FOREIGN KEY (`id_vehicle_part`) REFERENCES `vehicle_part` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order_detail`
--

LOCK TABLES `order_detail` WRITE;
/*!40000 ALTER TABLE `order_detail` DISABLE KEYS */;
/*!40000 ALTER TABLE `order_detail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehicle_model`
--

DROP TABLE IF EXISTS `vehicle_model`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vehicle_model` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_vehicle_type` int(11) NOT NULL,
  `id_brand` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `created_at` datetime NOT NULL,
  `id_color` int(11) NOT NULL,
  `id_motor` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `vehicle_model_FK` (`id_brand`),
  KEY `vehicle_model_FK_1` (`id_vehicle_type`),
  KEY `vehicle_model_FK_2` (`id_color`),
  KEY `vehicle_model_FK_3` (`id_motor`),
  CONSTRAINT `vehicle_model_FK` FOREIGN KEY (`id_brand`) REFERENCES `brand` (`id`),
  CONSTRAINT `vehicle_model_FK_1` FOREIGN KEY (`id_vehicle_type`) REFERENCES `vehicle_type` (`id`),
  CONSTRAINT `vehicle_model_FK_2` FOREIGN KEY (`id_color`) REFERENCES `color` (`id`),
  CONSTRAINT `vehicle_model_FK_3` FOREIGN KEY (`id_motor`) REFERENCES `vehicle_motor` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehicle_model`
--

LOCK TABLES `vehicle_model` WRITE;
/*!40000 ALTER TABLE `vehicle_model` DISABLE KEYS */;
INSERT INTO `vehicle_model` VALUES (23,2,6,'Test Final','2021-06-14 13:13:57',3,3);
/*!40000 ALTER TABLE `vehicle_model` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehicle_motor`
--

DROP TABLE IF EXISTS `vehicle_motor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vehicle_motor` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehicle_motor`
--

LOCK TABLES `vehicle_motor` WRITE;
/*!40000 ALTER TABLE `vehicle_motor` DISABLE KEYS */;
INSERT INTO `vehicle_motor` VALUES (1,'4 Cilindros'),(2,'V8'),(3,'V12'),(4,'V16');
/*!40000 ALTER TABLE `vehicle_motor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehicle_part`
--

DROP TABLE IF EXISTS `vehicle_part`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vehicle_part` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehicle_part`
--

LOCK TABLES `vehicle_part` WRITE;
/*!40000 ALTER TABLE `vehicle_part` DISABLE KEYS */;
INSERT INTO `vehicle_part` VALUES (1,'Rines'),(2,'Pantalla'),(3,'Carroceria'),(4,'Interior'),(5,'Nevera'),(6,'Cortinas para Ventanilla'),(7,'Sistema Antirrobo');
/*!40000 ALTER TABLE `vehicle_part` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehicle_type`
--

DROP TABLE IF EXISTS `vehicle_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vehicle_type` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehicle_type`
--

LOCK TABLES `vehicle_type` WRITE;
/*!40000 ALTER TABLE `vehicle_type` DISABLE KEYS */;
INSERT INTO `vehicle_type` VALUES (1,'Coupé'),(2,'Familiar'),(3,'Deportivo'),(4,'Descapotable');
/*!40000 ALTER TABLE `vehicle_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'homestead'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-06-15 11:17:16
