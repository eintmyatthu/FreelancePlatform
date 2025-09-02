-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: localhost    Database: freelancer_platform
-- ------------------------------------------------------
-- Server version	8.0.31

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
-- Table structure for table `bid`
--

DROP TABLE IF EXISTS `bid`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bid` (
  `bid_id` int NOT NULL AUTO_INCREMENT,
  `freelancer_id` int DEFAULT NULL,
  `project_id` int DEFAULT NULL,
  `bid_amount` decimal(10,2) DEFAULT NULL,
  `estimated_days` int DEFAULT NULL,
  `status` enum('Pending','Accepted','Rejected','Completed') DEFAULT NULL,
  PRIMARY KEY (`bid_id`),
  KEY `freelancer_id` (`freelancer_id`),
  KEY `project_id` (`project_id`),
  CONSTRAINT `bid_ibfk_1` FOREIGN KEY (`freelancer_id`) REFERENCES `freelancer` (`freelancer_id`),
  CONSTRAINT `bid_ibfk_2` FOREIGN KEY (`project_id`) REFERENCES `project` (`project_id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bid`
--

LOCK TABLES `bid` WRITE;
/*!40000 ALTER TABLE `bid` DISABLE KEYS */;
INSERT INTO `bid` VALUES (1,3,1,2500.00,60,'Completed'),(2,3,2,6000.00,90,'Accepted'),(3,3,4,2500.00,90,'Completed'),(4,4,5,6000.00,120,'Completed'),(5,4,6,7000.00,240,'Completed'),(6,4,6,7000.00,240,'Pending'),(7,8,3,5000.00,420,'Accepted'),(8,5,14,250.00,30,'Pending'),(9,5,16,200.00,45,'Accepted');
/*!40000 ALTER TABLE `bid` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `client`
--

DROP TABLE IF EXISTS `client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `client` (
  `client_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `company` text NOT NULL,
  `contactNo` text NOT NULL,
  PRIMARY KEY (`client_id`),
  UNIQUE KEY `user_id` (`user_id`),
  CONSTRAINT `client_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `user` (`user_id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client`
--

LOCK TABLES `client` WRITE;
/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client` VALUES (5,4,'ExpertDev','+959123456789'),(6,6,'Build Your Dream','+959789456123');
/*!40000 ALTER TABLE `client` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `freelancer`
--

DROP TABLE IF EXISTS `freelancer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `freelancer` (
  `freelancer_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `skills` text NOT NULL,
  `portfolio` text NOT NULL,
  `expertise` text NOT NULL,
  `pastwork` text NOT NULL,
  PRIMARY KEY (`freelancer_id`),
  UNIQUE KEY `user_id` (`user_id`),
  CONSTRAINT `freelancer_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `user` (`user_id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `freelancer`
--

LOCK TABLES `freelancer` WRITE;
/*!40000 ALTER TABLE `freelancer` DISABLE KEYS */;
INSERT INTO `freelancer` VALUES (3,2,'Java, C#, Python','I am good at coding and can work with team.','Java, C#','Java Development'),(4,3,'Java, iOS','Crafting reliable Java applications and beautiful, user-focused iOS apps','Java, iOS','iOS Developer'),(5,1,'JavaScript, HTML, CSS','I am frontend designer','UI, UX','UI, UX'),(7,5,'Python, JavaScript, Html, CSS','I have experience in Data Science.','Python','Data Science'),(8,7,'Kotlin, Java, Python','I am expert in coding.','Java, Python','Mobile Application'),(10,8,'Java, Kotlin, Python, PHP','Skilled and detail-oriented Java & Kotlin developer with experience building robust backend systems and modern Android applications. I specialize in writing clean, maintainable code with a focus on performance and user experience.','Java, PHP','Java Development');
/*!40000 ALTER TABLE `freelancer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `project`
--

DROP TABLE IF EXISTS `project`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `project` (
  `project_id` int NOT NULL AUTO_INCREMENT,
  `client_id` int DEFAULT NULL,
  `title` varchar(255) NOT NULL,
  `description` text,
  `budget` decimal(10,2) NOT NULL,
  `deadline` date DEFAULT NULL,
  `requiredSkills` varchar(255) NOT NULL,
  `status` enum('Open','ongoing','completed') DEFAULT NULL,
  `freelancer_id` int DEFAULT NULL,
  PRIMARY KEY (`project_id`),
  KEY `client_id` (`client_id`),
  KEY `freelancer_id` (`freelancer_id`),
  CONSTRAINT `project_ibfk_1` FOREIGN KEY (`client_id`) REFERENCES `client` (`client_id`),
  CONSTRAINT `project_ibfk_2` FOREIGN KEY (`freelancer_id`) REFERENCES `freelancer` (`freelancer_id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `project`
--

LOCK TABLES `project` WRITE;
/*!40000 ALTER TABLE `project` DISABLE KEYS */;
INSERT INTO `project` VALUES (1,5,'Java Development','Maintain and upgrade the existing projects',2500.00,'2025-05-31','Java, Spring boot, Javascript','completed',3),(2,5,'C# Developer','Project for Education',5000.00,'2025-07-30','C#, .Net','ongoing',3),(3,5,'Java','Website for translator freelancer',5000.00,'2025-09-30','Java, Spring ','ongoing',8),(4,5,'Python','Data ',2500.00,'2024-09-30','Python','completed',3),(5,6,'iOS Developer','You have to create iOS application.',6000.00,'2024-12-31','Swift','completed',4),(6,6,'Java Development','I provide robust and scalable Java development services tailored to meet the specific needs of your business. With extensive experience in both core Java and modern Java frameworks, I can build efficient backend systems, web applications, APIs, and enterprise-grade software.',7000.00,'2024-10-30','Java EE,Spring,SQL ','completed',4),(7,6,'Full-Stack Web Application (Java Backend + PHP Module)\n\n','I’m looking for two skilled developers to work on a full-stack web application.\n\nThe Java Developer will build the backend using Spring Boot, creating secure RESTful APIs and handling business logic, authentication, and data management with MySQL.\n\nThe PHP Developer will work on a legacy module written in PHP that needs to be maintained and integrated into the new system. This includes fixing bugs and creating API bridges with the Java backend.',500.00,'2025-08-31','Java, Spring Boot, REST API, MySQL\n\nPHP, MySQL, API Integration, Legacy Code Maintenance\n\nGit/GitHub for version control','Open',NULL),(8,6,'Android Expense Tracker App','A sleek and intuitive expense tracking mobile app allowing users to log daily expenses, view spending graphs, and set monthly budgets. Built with Jetpack Compose and local Room database, with optional cloud sync via Firebase.',1500.00,'2025-09-30','Kotlin, Android Jetpack(Room,LiveData, ViewModel), Firebase(optional for cloud sync), Material Design','Open',NULL),(9,6,'Java Spring Boot REST API for E-Commerce','Developed a secure and scalable backend system for an online store. Includes user authentication, product catalog, shopping cart, and order history using REST APIs and JWT-based login.',400.00,'2025-06-30','Java, Spring Boot, RESTful API, JWT Authentication, MySQL, Swagger','Open',NULL),(10,5,'Kotlin-Based To-Do App with Notifications','An Android productivity app with a modern UI, offline storage, daily task reminders, and recurring task support. Uses WorkManager to send daily push notifications.',180.00,'2025-05-31','Kotlin, Android SDK, WorkManager, MVVM Architecture, SQLite, UI/UX (basic)','Open',NULL),(11,5,' Java Desktop App for Library Management','A real-time weather forecasting app with location-based updates, 5-day forecasts, and dynamic UI animations. Data is pulled from OpenWeather API with offline caching support.',200.00,'2025-07-31','Java, JavaFX or Swing, SQLite, MVC Design Pattern, PDF Export(e.g. using iText or JasperReports)','Open',NULL),(12,5,' Kotlin Weather App with OpenWeather API','A real-time weather forecasting app with location-based updates, 5-day forecasts, and dynamic UI animations. Data is pulled from OpenWeather API with offline caching support.',250.00,'2025-06-30','Kotlin, Retrofit, MVVM Architecture, API Integration, Android UI Animations, Caching','Open',NULL),(13,5,'PHP Project: Online Booking System','A web-based appointment booking system for salons, clinics, or freelance services. Users can register, log in, book time slots, and get email confirmations. Admin panel included.',300.00,'2025-04-30','PHP (Larvel), MySQL, HTML, CSS, JavaScript/jQuery, Email integration','Open',NULL),(14,5,'Mobile App Design for Food Delivery','Create a clean and modern UI/UX design for a food delivery app, covering login, menu browsing, checkout, and delivery tracking. Deliverables include Figma mockups or Adobe XD prototypes.',250.00,'2025-04-28','UI/UX Design, Figma or Adobe XD, Mobile-first design, Wireframing & prototyping, User Flow optimization','Open',NULL),(15,6,'Inventory Management Desktop App','A Windows application to manage product inventory, sales reports, and supplier records. Includes login, data validation, and printable reports.',350.00,'2025-05-31','C#, WinForms or WPF, .Net Framework, SQL Server, Crystal Reports (optional)','Open',NULL),(16,6,'Responsive Portfolio Website','Develop a responsive personal portfolio website with smooth animations, contact form, and project showcase. Fully optimized for mobile and tablet.',200.00,'2025-08-31','HTML, CSS, JavaScript, Bootstrap or Tailwind CSS, Responsive Design, GSAP or AOS (for animation), Formspree or similar (for contact form)','ongoing',5);
/*!40000 ALTER TABLE `project` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `review`
--

DROP TABLE IF EXISTS `review`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `review` (
  `review_id` int NOT NULL AUTO_INCREMENT,
  `project_id` int NOT NULL,
  `freelancer_id` int NOT NULL,
  `client_id` int NOT NULL,
  `rating` int DEFAULT NULL,
  `review_text` text,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`review_id`),
  KEY `project_id` (`project_id`),
  KEY `freelancer_id` (`freelancer_id`),
  KEY `client_id` (`client_id`),
  CONSTRAINT `review_ibfk_1` FOREIGN KEY (`project_id`) REFERENCES `project` (`project_id`),
  CONSTRAINT `review_ibfk_2` FOREIGN KEY (`freelancer_id`) REFERENCES `freelancer` (`freelancer_id`),
  CONSTRAINT `review_ibfk_3` FOREIGN KEY (`client_id`) REFERENCES `client` (`client_id`),
  CONSTRAINT `review_chk_1` CHECK ((`rating` between 1 and 5))
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `review`
--

LOCK TABLES `review` WRITE;
/*!40000 ALTER TABLE `review` DISABLE KEYS */;
INSERT INTO `review` VALUES (1,1,3,5,4,'Expert in the coding','2025-04-03 09:05:41'),(2,4,3,5,3,'You need to know more about Python.','2025-04-06 11:10:25'),(3,5,4,6,5,'Working with you was a fantastic experience. They took our rough app concept and turned it into a fully functional iOS application with a clean UI and smooth performance. Communication was clear, timelines were met, and the final product exceeded our expectations. We especially appreciated the attention to detail with SwiftUI animations and seamless integration with Firebase. Highly recommended!','2025-04-07 12:24:44'),(4,6,4,6,5,'Working with you on our Java development project was a great experience. He demonstrated deep technical knowledge of Java, Spring Boot, and RESTful APIs, and delivered clean, scalable backend code on time. His ability to understand complex requirements and turn them into efficient solutions really stood out. Communication was smooth throughout the project, and any changes we requested were handled quickly and professionally. We’re very happy with the results and will definitely hire him again for future Java-based projects.','2025-04-07 14:18:59');
/*!40000 ALTER TABLE `review` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `user_id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password` varchar(12) NOT NULL,
  `usertype` varchar(50) NOT NULL,
  PRIMARY KEY (`user_id`),
  UNIQUE KEY `username` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'helen','Helen@123','Freelancer'),(2,'emt','Emt@1234','Freelancer'),(3,'emery','Emery@123','Freelancer'),(4,'john','John@1234','Client'),(5,'jame','Jame@123','Freelancer'),(6,'Karen','Karen@123','Client'),(7,'Peter','Peter@123','Freelancer'),(8,'Charles','Charles123','Freelancer'),(9,'Kevin','Kevin@123','Freelancer');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-04-08 17:26:23
