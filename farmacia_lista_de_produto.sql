-- MySQL dump 10.13  Distrib 8.0.25, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: farmacia
-- ------------------------------------------------------
-- Server version	8.0.25

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
-- Table structure for table `lista_de_produto`
--

DROP TABLE IF EXISTS `lista_de_produto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lista_de_produto` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `ID_List` int DEFAULT NULL,
  `Cod` varchar(45) DEFAULT NULL,
  `Produto` varchar(45) DEFAULT NULL,
  `Quantidade` varchar(45) DEFAULT NULL,
  `EAN` varchar(45) DEFAULT NULL,
  `Fornecedor` varchar(45) DEFAULT NULL,
  `Categoria` varchar(45) DEFAULT NULL,
  `Valor_Atual` varchar(45) DEFAULT NULL,
  `Valor_Anterior` varchar(45) DEFAULT NULL,
  `Valor_Total` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=181 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lista_de_produto`
--

LOCK TABLES `lista_de_produto` WRITE;
/*!40000 ALTER TABLE `lista_de_produto` DISABLE KEYS */;
INSERT INTO `lista_de_produto` VALUES (3,1,'1','Creme Dental Colgate 45g Menta','1','78989521463','PeG','Creme Dental','7,45','0',NULL),(6,1,'1','Creme Dental Colgate 45g Menta','2','78989521463','PeG','Creme Dental','7,45','0',NULL),(8,2,'1','Creme Dental Colgate 45g Menta','5','78989521463','PeG','Creme Dental','7,45','0',NULL),(9,1,'1425','Sabonete Liquido 100ml','2','78952896354','Lux','Sabonete','5,99','0',NULL),(10,2,'1425','Sabonete Liquido 100ml','2','78952896354','Lux','Sabonete','5,99','0',NULL),(12,2,'1425','Sabonete Liquido 100ml','2','78952896354','Lux','Sabonete','5,99','0',NULL),(13,2,'1425','Sabonete Liquido 100ml','2','78952896354','Lux','Sabonete','5,99','0',NULL),(14,3,'1','Creme Dental Colgate 45g Menta','1','78989521463','PeG','Creme Dental','7,45','0',NULL),(15,3,'1425','Sabonete Liquido 100ml','1','78952896354','Lux','Sabonete','5,99','0',NULL),(16,4,'256325','Fralda Pampers Tam. G 56 un','2','78989521452','PeG','Fralda','48,52','0',NULL),(17,4,'1422','Fralda Pampers Tam. P 72 un','1','78989523652','PeG','Fralda','36,89','0',NULL),(19,1,'256325','Fralda Pampers Tam. G 56 un','1','78989521452','PeG','Fralda','48,52','0',NULL),(20,1,'256325','Fralda Pampers Tam. G 56 un','1','78989521452','PeG','Fralda','48,52','0',NULL),(21,1,'256325','Fralda Pampers Tam. G 56 un','1','78989521452','PeG','Fralda','48,52','0',NULL),(22,1,'256325','Fralda Pampers Tam. G 56 un','1','78989521452','PeG','Fralda','48,52','0',NULL),(24,1,'256325','Fralda Pampers Tam. G 56 un','1','78989521452','PeG','Fralda','48,52','0',NULL),(25,1,'256325','Fralda Pampers Tam. G 56 un','1','78989521452','PeG','Fralda','48,52','0',NULL),(26,4,'1422','Fralda Pampers Tam. P 72 un','2','78989523652','PeG','Fralda','36,89','0',NULL),(27,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(28,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(29,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(30,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(31,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(32,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(33,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(34,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(35,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(36,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(37,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(38,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(39,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(40,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(41,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(42,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(43,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(44,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(45,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(46,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(47,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(48,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(49,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(50,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(51,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(52,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(53,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(54,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(55,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(56,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(57,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(58,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(59,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(60,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(61,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(62,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(63,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(64,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(65,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(66,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(67,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(68,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(69,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(70,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(71,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(72,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(73,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(74,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(75,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(76,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(77,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(78,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(79,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(80,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(81,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(82,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(83,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(84,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(85,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(86,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(87,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(88,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(89,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(90,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(91,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(92,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(93,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(94,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(95,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(96,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(97,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(98,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(99,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(100,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(101,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(102,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(103,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(104,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(105,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(106,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(107,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(108,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(109,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(110,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(111,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(112,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(113,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(114,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(115,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(116,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(117,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(118,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(119,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(120,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(121,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(122,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(123,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(124,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(125,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(126,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(127,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(128,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(129,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(130,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(131,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(132,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(133,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(134,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(135,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(136,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(137,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(138,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(139,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(140,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(141,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(142,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(143,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(144,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(145,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(146,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(147,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(148,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(149,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(150,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(151,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(152,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(153,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(154,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(155,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(156,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(157,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(158,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(159,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(160,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(161,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(162,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(163,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(164,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(165,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(166,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(167,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(168,1,'1422','Fralda Pampers Tam. P 72 un','5','78989523652','PeG','Fralda','36,89','0',NULL),(169,4,'1425','Sabonete Liquido 100ml','2','78952896354','Lux','Sabonete','5,99','0',NULL),(170,10,'1452','Sabonete Protex 25g Rosa','5','785252632541','Arcon','Sabonete','1,25','0',NULL),(171,10,'1452','Sabonete Protex 25g Rosa','5','785252632541','Arcon','Sabonete','1,25','0',NULL),(172,10,'1452','Sabonete Protex 25g Rosa','2','785252632541','Arcon','Sabonete','1,25','0',NULL),(175,9,'1','Creme Dental Colgate 45g Menta','1','78989521463','PeG','Creme Dental','7,45','0',NULL),(177,13,'1425','Sabonete Liquido 100ml','1','78952896354','Lux','Sabonete','5,99','0',NULL),(179,13,'1','Creme Dental Colgate 45g Menta','3','78989521463','PeG','Creme Dental','7,45','0','22,35'),(180,13,'256325','Fralda Pampers Tam. G 56 un','1','78989521452','PeG','Fralda','48,52','0','48,52');
/*!40000 ALTER TABLE `lista_de_produto` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-06-25 11:19:42