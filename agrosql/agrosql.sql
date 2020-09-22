CREATE DATABASE  IF NOT EXISTS `agriculture` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `agriculture`;
-- MySQL dump 10.13  Distrib 8.0.18, for Win64 (x86_64)
--
-- Host: localhost    Database: agriculture
-- ------------------------------------------------------
-- Server version	8.0.18

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `crop_culture`
--

DROP TABLE IF EXISTS `crop_culture`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `crop_culture` (
  `id_crop` int(11) NOT NULL AUTO_INCREMENT,
  `id_l` int(11) NOT NULL,
  `id_sc1` int(11) NOT NULL,
  `width_y` double NOT NULL,
  `data_c` datetime DEFAULT NULL,
  `data_y` datetime DEFAULT NULL,
  `yield` double NOT NULL,
  PRIMARY KEY (`id_crop`),
  KEY `id_l1_idx` (`id_l`),
  KEY `id_sc7_idx` (`id_sc1`),
  CONSTRAINT `id_l1` FOREIGN KEY (`id_l`) REFERENCES `land` (`id_l`),
  CONSTRAINT `id_sc7` FOREIGN KEY (`id_sc1`) REFERENCES `sort_culture` (`id_sc1`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `crop_culture`
--

LOCK TABLES `crop_culture` WRITE;
/*!40000 ALTER TABLE `crop_culture` DISABLE KEYS */;
INSERT INTO `crop_culture` VALUES (1,1,1,2000,'2020-09-20 20:00:00',NULL,54.3),(2,2,2,4000,'2020-09-20 18:00:00',NULL,78.5),(3,3,3,2000,'2019-09-20 20:00:00',NULL,23.4),(4,4,4,1000,'2017-09-20 17:00:00',NULL,47.2),(5,5,5,400,'2019-09-20 20:00:00',NULL,74.3),(6,6,6,800,'2018-09-20 20:00:00',NULL,32.4),(7,1,7,300,'2017-09-20 19:00:00',NULL,54.4);
/*!40000 ALTER TABLE `crop_culture` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `culture`
--

DROP TABLE IF EXISTS `culture`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `culture` (
  `id_c` int(11) NOT NULL AUTO_INCREMENT,
  `name_c` varchar(45) NOT NULL,
  `yield_avr` double DEFAULT NULL,
  PRIMARY KEY (`id_c`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `culture`
--

LOCK TABLES `culture` WRITE;
/*!40000 ALTER TABLE `culture` DISABLE KEYS */;
INSERT INTO `culture` VALUES (1,'Пшеница озимая	',32.87),(2,'соняшник',15.62),(3,'Соя',12.34),(4,'Кукуруза',56.26),(5,'Просо',9.78),(6,'Ячмінь',20.22),(7,'Ячмінь яровий',24.14),(8,'Овес',59.5),(9,'Горох',42.2);
/*!40000 ALTER TABLE `culture` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `delivery`
--

DROP TABLE IF EXISTS `delivery`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `delivery` (
  `id_d` int(11) NOT NULL AUTO_INCREMENT,
  `date_p` datetime NOT NULL,
  `manager` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`id_d`)
) ENGINE=InnoDB AUTO_INCREMENT=45 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `delivery`
--

LOCK TABLES `delivery` WRITE;
/*!40000 ALTER TABLE `delivery` DISABLE KEYS */;
INSERT INTO `delivery` VALUES (1,'2020-09-20 20:00:00','Петрук'),(2,'2020-09-20 20:00:00','Петрук'),(3,'2020-09-20 20:00:00','Петрук'),(4,'2020-09-20 20:00:00','Петрук'),(5,'2020-09-20 20:00:00','Петрук'),(11,'2020-09-19 00:00:00','Петрук'),(12,'2020-09-19 00:00:00','Петрук'),(13,'2020-09-19 00:00:00','Петрук'),(14,'2020-09-19 00:00:00','Петрук'),(15,'2020-09-19 00:00:00','Петрук'),(16,'2020-09-19 00:00:00','Петрук'),(17,'2020-09-19 00:00:00','Петрук'),(18,'2020-09-19 00:00:00','Петрук'),(19,'2020-09-19 00:00:00','Петрук'),(27,'2020-09-19 00:00:00','Петрук'),(28,'2020-09-12 00:00:00','Петрук'),(29,'2020-09-19 00:00:00','Петрук'),(30,'2020-09-19 00:00:00','Петрук'),(31,'2020-09-19 00:00:00','Петрук'),(32,'2020-09-19 00:00:00','Петрук'),(33,'2020-09-19 00:00:00','Петрук'),(34,'2020-09-19 00:00:00','Петрук'),(35,'2020-09-19 00:00:00','Петрук'),(36,'2020-09-19 00:00:00','Петрук'),(37,'2020-09-19 00:00:00','Petruk'),(38,'2020-09-19 00:00:00','Petruk'),(39,'2020-09-19 00:00:00','Петрук'),(40,'2020-09-21 00:00:00','Ткаченко Игорь Васильевич'),(41,'2020-09-21 00:00:00','Петрук'),(42,'2020-09-22 00:00:00','ПІБ'),(43,'2020-09-21 00:00:00','Петрук'),(44,'2020-09-21 00:00:00','Петрук');
/*!40000 ALTER TABLE `delivery` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `delivery_cultures`
--

DROP TABLE IF EXISTS `delivery_cultures`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `delivery_cultures` (
  `id_dc` int(11) NOT NULL AUTO_INCREMENT,
  `id_d` int(11) NOT NULL,
  `weight_d` double NOT NULL,
  `id_sc1` int(11) NOT NULL,
  `sum_der` double NOT NULL,
  PRIMARY KEY (`id_dc`),
  KEY `id_d2_idx` (`id_d`),
  KEY `id_ref_idx` (`id_sc1`),
  CONSTRAINT `id_d2` FOREIGN KEY (`id_d`) REFERENCES `delivery` (`id_d`),
  CONSTRAINT `id_ref` FOREIGN KEY (`id_sc1`) REFERENCES `sort_culture` (`id_sc1`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `delivery_cultures`
--

LOCK TABLES `delivery_cultures` WRITE;
/*!40000 ALTER TABLE `delivery_cultures` DISABLE KEYS */;
INSERT INTO `delivery_cultures` VALUES (1,1,800,1,0),(2,2,900,2,0),(3,3,1000,3,0),(4,3,300,4,0),(5,11,20,4,0),(6,12,20,7,0),(7,19,20,1,0),(8,27,20,1,0),(9,27,22,7,0),(10,32,300,2,0),(11,33,1050,3,0),(12,34,1030,3,0),(13,34,100,1,0),(14,35,300,6,0),(15,35,200,7,0),(16,35,400,6,0),(17,36,300,6,0),(18,36,100,7,0),(19,39,300,6,3000),(20,39,300,6,3000),(21,41,1300,3,6500),(22,42,77,2,0),(23,43,1000,3,5000),(24,43,10,1,0),(25,44,1000,6,10000);
/*!40000 ALTER TABLE `delivery_cultures` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `land`
--

DROP TABLE IF EXISTS `land`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `land` (
  `id_l` int(11) NOT NULL AUTO_INCREMENT,
  `number` double NOT NULL,
  `size` double NOT NULL,
  PRIMARY KEY (`id_l`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `land`
--

LOCK TABLES `land` WRITE;
/*!40000 ALTER TABLE `land` DISABLE KEYS */;
INSERT INTO `land` VALUES (1,1,120.1),(2,2,100.3),(3,3,78.4),(4,4,223.2),(5,5,224.3),(6,6,58.5),(7,7,300.2);
/*!40000 ALTER TABLE `land` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sort`
--

DROP TABLE IF EXISTS `sort`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sort` (
  `id_s` int(11) NOT NULL AUTO_INCREMENT,
  `name_s` enum('перший','другий','вищий') NOT NULL,
  PRIMARY KEY (`id_s`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sort`
--

LOCK TABLES `sort` WRITE;
/*!40000 ALTER TABLE `sort` DISABLE KEYS */;
INSERT INTO `sort` VALUES (1,'перший'),(2,'другий'),(3,'вищий');
/*!40000 ALTER TABLE `sort` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sort_culture`
--

DROP TABLE IF EXISTS `sort_culture`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sort_culture` (
  `id_sc1` int(11) NOT NULL AUTO_INCREMENT,
  `id_s` int(11) NOT NULL,
  `id_c` int(11) NOT NULL,
  `price` double NOT NULL,
  `width_z` double NOT NULL,
  PRIMARY KEY (`id_sc1`),
  KEY `id_s_idx` (`id_s`),
  KEY `id_c_idx` (`id_c`),
  CONSTRAINT `id_c` FOREIGN KEY (`id_c`) REFERENCES `culture` (`id_c`),
  CONSTRAINT `id_s` FOREIGN KEY (`id_s`) REFERENCES `sort` (`id_s`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sort_culture`
--

LOCK TABLES `sort_culture` WRITE;
/*!40000 ALTER TABLE `sort_culture` DISABLE KEYS */;
INSERT INTO `sort_culture` VALUES (1,1,1,600,700),(2,2,2,440,600),(3,3,3,100,1000),(4,1,4,770,2000),(5,2,5,300,1200),(6,3,6,200,300),(7,1,7,800,400),(8,1,9,1100,500),(9,1,2,550,800);
/*!40000 ALTER TABLE `sort_culture` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-09-22 15:26:37
