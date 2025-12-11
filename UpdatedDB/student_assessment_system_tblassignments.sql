-- MySQL dump 10.13  Distrib 8.0.44, for Win64 (x86_64)
--
-- Host: localhost    Database: student_assessment_system
-- ------------------------------------------------------
-- Server version	8.0.44

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
-- Table structure for table `tblassignments`
--

DROP TABLE IF EXISTS `tblassignments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblassignments` (
  `Assignment_ID` int NOT NULL AUTO_INCREMENT,
  `Employee_ID` int DEFAULT NULL,
  `Course_ID` int DEFAULT NULL,
  `Subject_ID` int DEFAULT NULL,
  `Term_ID` int DEFAULT NULL,
  `Section_ID` int DEFAULT NULL,
  `Assignment_Schedule` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Assignment_ID`),
  KEY `Employee_ID` (`Employee_ID`),
  KEY `Course_ID` (`Course_ID`),
  KEY `Subject_ID` (`Subject_ID`),
  KEY `Term_ID` (`Term_ID`),
  KEY `Section_ID` (`Section_ID`),
  CONSTRAINT `tblassignments_ibfk_1` FOREIGN KEY (`Employee_ID`) REFERENCES `tblemployee` (`Employee_ID`),
  CONSTRAINT `tblassignments_ibfk_2` FOREIGN KEY (`Course_ID`) REFERENCES `tblcourse` (`Course_ID`),
  CONSTRAINT `tblassignments_ibfk_3` FOREIGN KEY (`Subject_ID`) REFERENCES `tblsubject` (`Subject_ID`),
  CONSTRAINT `tblassignments_ibfk_4` FOREIGN KEY (`Term_ID`) REFERENCES `tblacademictermmanagement` (`Term_ID`),
  CONSTRAINT `tblassignments_ibfk_5` FOREIGN KEY (`Section_ID`) REFERENCES `tblsection` (`Section_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblassignments`
--

LOCK TABLES `tblassignments` WRITE;
/*!40000 ALTER TABLE `tblassignments` DISABLE KEYS */;
/*!40000 ALTER TABLE `tblassignments` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-12-11 22:07:12
