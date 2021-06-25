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
-- Table structure for table `lista_de_pedido`
--

DROP TABLE IF EXISTS `lista_de_pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lista_de_pedido` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Nome_do_Pedido` varchar(45) DEFAULT NULL,
  `Nome_do_Comprador` varchar(45) DEFAULT NULL,
  `Data` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lista_de_pedido`
--

LOCK TABLES `lista_de_pedido` WRITE;
/*!40000 ALTER TABLE `lista_de_pedido` DISABLE KEYS */;
INSERT INTO `lista_de_pedido` VALUES (1,'Pedido de Sabonete','Adriano','20/06/2021'),(2,'Pedido Pasta de Dente','Bruna','21/06/2021'),(3,'Pedido de Desodorante','Adriano','21/06/2021 17:37:02'),(4,'Pedido de Fralda','Bruna','21/06/2021 17:42:16'),(5,'Pedido Esmalte','Adriano','21/06/2021 17:50:57'),(6,'Pedido Creme','Bruna','21/06/2021 17:53:48'),(7,'Pedido de Lenço','Adriano','22/06/2021 11:44:40'),(8,'Pedido de Remedio','Adriano','22/06/2021 11:45:32'),(9,'Pedido Teste 1','Adriano','22/06/2021 12:29:52'),(10,'Pedido de Sabonete','Bruna','24/06/2021 00:34:06'),(11,'Pedido Teste 2','Adriano','24/06/2021 12:01:02'),(12,'Pedido Teste 3','Adriano','24/06/2021 12:02:55'),(13,'Teste 4','teste','24/06/2021 12:05:21');
/*!40000 ALTER TABLE `lista_de_pedido` ENABLE KEYS */;
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
