-- MySQL dump 10.13  Distrib 8.0.25, for Win64 (x86_64)
--
-- Host: localhost    Database: farmacia
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
-- Table structure for table `fornecedor`
--

DROP TABLE IF EXISTS `fornecedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fornecedor` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Empresa` varchar(45) DEFAULT NULL,
  `Vendedor` varchar(45) DEFAULT NULL,
  `Contato` varchar(45) DEFAULT NULL,
  `Obs` longtext,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fornecedor`
--

LOCK TABLES `fornecedor` WRITE;
/*!40000 ALTER TABLE `fornecedor` DISABLE KEYS */;
INSERT INTO `fornecedor` VALUES (1,'PeG','Bruna','(16) 6666-9999','Teste ....'),(2,'Lux','Adriano','(16) 2514-2514','....');
/*!40000 ALTER TABLE `fornecedor` ENABLE KEYS */;
UNLOCK TABLES;

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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lista_de_pedido`
--

LOCK TABLES `lista_de_pedido` WRITE;
/*!40000 ALTER TABLE `lista_de_pedido` DISABLE KEYS */;
INSERT INTO `lista_de_pedido` VALUES (1,'Pedido de Sabonete','Adriano','20/06/2021'),(2,'Pedido Pasta de Dente','Bruna','21/06/2021');
/*!40000 ALTER TABLE `lista_de_pedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lista_de_produto`
--

DROP TABLE IF EXISTS `lista_de_produto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lista_de_produto` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `ID_List` int DEFAULT NULL,
  `Produto` varchar(45) DEFAULT NULL,
  `Quantidade` varchar(45) DEFAULT NULL,
  `Cod` varchar(45) DEFAULT NULL,
  `EAN` varchar(45) DEFAULT NULL,
  `Fornecedor` varchar(45) DEFAULT NULL,
  `Categoria` varchar(45) DEFAULT NULL,
  `Valor_Atual` varchar(45) DEFAULT NULL,
  `Valor_Anterior` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lista_de_produto`
--

LOCK TABLES `lista_de_produto` WRITE;
/*!40000 ALTER TABLE `lista_de_produto` DISABLE KEYS */;
INSERT INTO `lista_de_produto` VALUES (2,1,'Creme Dental Colgate 45g Menta','1','1','78989521463','PeG','Creme Dental','7,45','0'),(3,1,'Creme Dental Colgate 45g Menta','1','1','78989521463','PeG','Creme Dental','7,45','0'),(4,1,'Sabonete Liquido 100ml','10','1425','78952896354','Lux','Sabonete','5,99','0'),(5,1,'Creme Dental Colgate 45g Menta','2','1','78989521463','PeG','Creme Dental','7,45','0'),(6,1,'Creme Dental Colgate 45g Menta','2','1','78989521463','PeG','Creme Dental','7,45','0'),(7,1,'Creme Dental Colgate 45g Menta','2','1','78989521463','PeG','Creme Dental','7,45','0'),(8,2,'Creme Dental Colgate 45g Menta','5','1','78989521463','PeG','Creme Dental','7,45','0');
/*!40000 ALTER TABLE `lista_de_produto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produtos`
--

DROP TABLE IF EXISTS `produtos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `produtos` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Cod` int DEFAULT NULL,
  `EAN` bigint DEFAULT NULL,
  `Produto` varchar(45) DEFAULT NULL,
  `Fornecedor` varchar(45) DEFAULT NULL,
  `Categoria` varchar(45) DEFAULT NULL,
  `PrecoAtual` varchar(45) DEFAULT NULL,
  `PrecoAnterior` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produtos`
--

LOCK TABLES `produtos` WRITE;
/*!40000 ALTER TABLE `produtos` DISABLE KEYS */;
INSERT INTO `produtos` VALUES (1,1,78989521463,'Creme Dental Colgate 45g Menta','PeG','Creme Dental','7,45','0'),(2,1425,78952896354,'Sabonete Liquido 100ml','Lux','Sabonete','5,99','0');
/*!40000 ALTER TABLE `produtos` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-06-20 23:53:23
