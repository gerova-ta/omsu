-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: localhost    Database: fitness
-- ------------------------------------------------------
-- Server version	8.0.41

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
-- Table structure for table `clients`
--

DROP TABLE IF EXISTS `clients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clients` (
  `client_id` int NOT NULL AUTO_INCREMENT,
  `client_name` varchar(150) DEFAULT NULL,
  `client_number` varchar(45) DEFAULT NULL,
  `ticket_start` date DEFAULT NULL,
  `ticket_end` date DEFAULT NULL,
  `tickets_ticket_id` int NOT NULL,
  PRIMARY KEY (`client_id`,`tickets_ticket_id`),
  KEY `fk_clients_tickets_idx` (`tickets_ticket_id`),
  CONSTRAINT `fk_clients_tickets` FOREIGN KEY (`tickets_ticket_id`) REFERENCES `tickets` (`ticket_id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clients`
--

LOCK TABLES `clients` WRITE;
/*!40000 ALTER TABLE `clients` DISABLE KEYS */;
INSERT INTO `clients` VALUES (1,'Иванова Наталья Юрьевна','+7 111 111 11 11','2024-03-03','2025-03-02',1),(2,'Королев Сергей Павлович','+7 222 222 22 22','2025-01-15','2025-06-14',2),(3,'Денисов Денис Денисович','+7 222 222 22 22','2025-03-17','2025-04-16',3),(4,'Косолапова Дарья Олеговна','+7 333 333 33 33','2025-02-11','2026-02-10',4),(5,'Тимошенко Павел Евгеньевич','+7 444 444 44 44','2025-01-15','2026-01-14',5),(6,'Борисова Елена Федоровна','+7 555 555 55 55','2024-05-15','2025-05-14',1),(7,'Николаев Петр Андреевич','+7 666 666 66 66','2024-12-15','2025-05-14',2),(8,'Юдина Наталья Борисовна','+7 777 777 77 77','2025-03-20','2025-04-19',3),(9,'Юдин Константин Борисович','+7 888 888 88 88','2025-01-30','2026-01-29',4),(10,'Соколов Виталий Петрович','+7 999 999 99 99','2025-03-09','2026-03-08',5);
/*!40000 ALTER TABLE `clients` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gym`
--

DROP TABLE IF EXISTS `gym`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `gym` (
  `gym_id` int NOT NULL AUTO_INCREMENT,
  `gym_name` varchar(45) DEFAULT NULL,
  `gym_date` date DEFAULT NULL,
  `gym_start` time DEFAULT NULL,
  `gym_end` time DEFAULT NULL,
  PRIMARY KEY (`gym_id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gym`
--

LOCK TABLES `gym` WRITE;
/*!40000 ALTER TABLE `gym` DISABLE KEYS */;
INSERT INTO `gym` VALUES (1,'Силовая тренировка','2025-03-10','09:00:00','10:00:00'),(2,'Силовая тренировка','2025-03-10','09:00:00','10:00:00'),(3,'Кардио тренировка','2025-03-10','10:00:00','11:00:00'),(4,'Растяжка + МФР','2025-03-10','11:00:00','12:00:00'),(5,'Группа здоровья','2025-03-10','16:00:00','17:00:00'),(6,'Табата','2025-03-10','19:00:00','20:00:00'),(7,'Силовая тренировка','2025-03-11','09:00:00','10:00:00'),(8,'Кардио тренировка','2025-03-11','10:00:00','11:00:00'),(9,'Растяжка + МФР','2025-03-11','11:00:00','12:00:00'),(10,'Группа здоровья','2025-03-11','16:00:00','17:00:00'),(11,'Табата','2025-03-11','19:00:00','20:00:00');
/*!40000 ALTER TABLE `gym` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tickets`
--

DROP TABLE IF EXISTS `tickets`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tickets` (
  `ticket_id` int NOT NULL AUTO_INCREMENT,
  `ticket_name` varchar(45) DEFAULT NULL,
  `ticket_price` int DEFAULT NULL,
  `ticket_condition` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`ticket_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tickets`
--

LOCK TABLES `tickets` WRITE;
/*!40000 ALTER TABLE `tickets` DISABLE KEYS */;
INSERT INTO `tickets` VALUES (1,'Годовой',20000,'Без ограничений'),(2,'6 месяцев',13000,'Без ограничений'),(3,'1 месяц',3000,'Без ограничений'),(4,'Утренний год',15000,'Посещение с 7 до 12'),(5,'Дневной год',17000,'Посещение с 7 до 17');
/*!40000 ALTER TABLE `tickets` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `user_id` int NOT NULL AUTO_INCREMENT,
  `user_role` varchar(45) DEFAULT NULL,
  `user_login` varchar(45) DEFAULT NULL,
  `user_password` varchar(45) DEFAULT NULL,
  `is_blocked` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'Администратор','admin','admin',0),(2,'Менеджер','manager','man1',0);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-06-05 14:50:56
