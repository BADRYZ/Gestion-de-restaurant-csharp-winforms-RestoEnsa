-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 03, 2024 at 08:26 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `restoensa`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `id` int(11) NOT NULL,
  `nom` varchar(255) DEFAULT NULL,
  `login` varchar(255) DEFAULT NULL,
  `mdp` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`id`, `nom`, `login`, `mdp`) VALUES
(1, 'Emily Smith', 'admin', 'adminpwd123');

-- --------------------------------------------------------

--
-- Table structure for table `categorie`
--

CREATE TABLE `categorie` (
  `id` int(11) NOT NULL,
  `nom` varchar(255) DEFAULT NULL,
  `description` text DEFAULT NULL,
  `image` longblob DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `categorie`
--

INSERT INTO `categorie` (`id`, `nom`, `description`, `image`) VALUES
(1, 'Entrée', 'Plats légers et appétissants pour commencer un repas.', NULL),
(2, 'Plat Principal', 'Plats principaux consistants et savoureux.', NULL),
(3, 'Dessert', 'Délicieuses douceurs sucrées pour finir en beauté.', NULL),
(4, 'Boisson', 'Une sélection de boissons rafraîchissantes pour accompagner votre repas.', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `chef`
--

CREATE TABLE `chef` (
  `id` int(11) NOT NULL,
  `nom` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `chef`
--

INSERT INTO `chef` (`id`, `nom`) VALUES
(1, 'Jean-Luc Dubois'),
(2, 'Marie-Claire Lefebvre'),
(3, 'Pierre Laroche'),
(4, 'Anne-Marie Lambert');

-- --------------------------------------------------------

--
-- Table structure for table `commande`
--

CREATE TABLE `commande` (
  `id` int(11) NOT NULL,
  `id_table` int(11) DEFAULT NULL,
  `facture` decimal(10,2) DEFAULT NULL,
  `id_chef` int(11) DEFAULT NULL,
  `reglee` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `commande`
--

INSERT INTO `commande` (`id`, `id_table`, `facture`, `id_chef`, `reglee`) VALUES
(8, 1, 29.47, 1, 1),
(9, 2, 6.99, 1, 1),
(10, 3, 16.98, 1, 1),
(11, 4, 25.98, 1, 1),
(12, 4, 9.99, 1, 1),
(13, 2, 28.98, 1, 1),
(14, 1, 37.98, 1, 1),
(15, 4, 10.98, 1, 1),
(16, 4, 13.98, 1, 1),
(17, 3, 37.98, 1, 1),
(18, 4, 28.98, 1, 1),
(19, 3, 13.98, 1, 1),
(20, 2, 51.96, 1, 1),
(22, 1, 13.98, NULL, 1),
(23, 1, 13.98, NULL, 1),
(24, 2, 5.49, NULL, 1),
(25, 3, 13.98, NULL, 1),
(26, 1, 37.98, NULL, 1),
(27, 1, 6.98, NULL, 1),
(28, 2, 28.98, NULL, 1),
(29, 3, 37.98, NULL, 1),
(30, 4, 9.98, NULL, 1),
(31, 4, 0.00, NULL, 1),
(32, 2, 19.98, NULL, 1),
(33, 1, 13.98, NULL, 1),
(34, 1, 43.47, NULL, 1),
(35, 1, 3.49, 2, 1),
(36, 1, 6.99, NULL, 0);

-- --------------------------------------------------------

--
-- Table structure for table `commande_plat`
--

CREATE TABLE `commande_plat` (
  `id_plat` int(11) DEFAULT NULL,
  `id_commande` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `commande_plat`
--

INSERT INTO `commande_plat` (`id_plat`, `id_commande`) VALUES
(1, 1),
(1, 1),
(7, 1),
(3, 7),
(3, 8),
(5, 8),
(7, 8),
(7, 9),
(2, 10),
(6, 11),
(1, 12),
(5, 13),
(4, 14),
(8, 15),
(7, 16),
(4, 17),
(5, 18),
(7, 19),
(7, 20),
(7, 22),
(7, 23),
(8, 24),
(7, 25),
(4, 26),
(11, 27),
(5, 28),
(4, 29),
(12, 30),
(1, 31),
(1, 32),
(7, 33),
(5, 34),
(11, 35),
(7, 36);

-- --------------------------------------------------------

--
-- Table structure for table `plat`
--

CREATE TABLE `plat` (
  `id` int(11) NOT NULL,
  `prix` decimal(10,2) DEFAULT NULL,
  `id_categorie` int(11) DEFAULT NULL,
  `nom` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `plat`
--

INSERT INTO `plat` (`id`, `prix`, `id_categorie`, `nom`) VALUES
(1, 9.99, 1, 'Salade César'),
(2, 8.49, 1, 'Soupe à l\'oignon gratinée'),
(3, 7.99, 1, 'Bruschetta'),
(4, 18.99, 2, 'Steak grillé'),
(5, 14.49, 2, 'Pâtes carbonara'),
(6, 12.99, 2, 'Burger de bœuf'),
(7, 6.99, 3, 'Tarte au citron'),
(8, 5.49, 3, 'Mousse au chocolat'),
(9, 7.99, 3, 'Crème brûlée'),
(10, 2.49, 4, 'Eau minérale'),
(11, 3.49, 4, 'Soda à l\'orange'),
(12, 4.99, 4, 'Thé glacé');

-- --------------------------------------------------------

--
-- Table structure for table `serveur`
--

CREATE TABLE `serveur` (
  `id` int(11) NOT NULL,
  `nom` varchar(255) DEFAULT NULL,
  `login` varchar(255) DEFAULT NULL,
  `mdp` varchar(255) DEFAULT NULL,
  `rendement` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `serveur`
--

INSERT INTO `serveur` (`id`, `nom`, `login`, `mdp`, `rendement`) VALUES
(1, 'Sophie Dupont', 'sophie.dupont', 'motdepasse123', 0),
(2, 'Antoine Martin', 'antoine.martin', 'secretpass456', 3),
(3, 'Laura Dubois', 'laura.dubois', 'mdp12345', 0),
(4, 'Alexandre Girard', 'alexandre.girard', 'password789', 0),
(5, 'm', 'm', '123', NULL),
(6, 'kjs', 'kdj', '5654', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `shift`
--

CREATE TABLE `shift` (
  `id` int(11) NOT NULL,
  `timeslot` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `shift`
--

INSERT INTO `shift` (`id`, `timeslot`) VALUES
(1, 1),
(2, 2),
(3, 1),
(4, 2),
(5, 1),
(6, 2),
(7, 1),
(8, 2),
(9, 1),
(10, 2);

-- --------------------------------------------------------

--
-- Table structure for table `shift_serveur`
--

CREATE TABLE `shift_serveur` (
  `id_shift` int(11) DEFAULT NULL,
  `id_serveur` int(11) DEFAULT NULL,
  `date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `table`
--

CREATE TABLE `table` (
  `id_table` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `table`
--

INSERT INTO `table` (`id_table`) VALUES
(1),
(2),
(3),
(4),
(5),
(6),
(7),
(8);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `categorie`
--
ALTER TABLE `categorie`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `chef`
--
ALTER TABLE `chef`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `commande`
--
ALTER TABLE `commande`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_table` (`id_table`),
  ADD KEY `id_chef` (`id_chef`);

--
-- Indexes for table `commande_plat`
--
ALTER TABLE `commande_plat`
  ADD KEY `id_plat` (`id_plat`),
  ADD KEY `id_commande` (`id_commande`);

--
-- Indexes for table `plat`
--
ALTER TABLE `plat`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_categorie` (`id_categorie`);

--
-- Indexes for table `serveur`
--
ALTER TABLE `serveur`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `shift`
--
ALTER TABLE `shift`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `shift_serveur`
--
ALTER TABLE `shift_serveur`
  ADD KEY `shift_serveur_ibfk_1` (`id_shift`),
  ADD KEY `shift_serveur_ibfk_2` (`id_serveur`);

--
-- Indexes for table `table`
--
ALTER TABLE `table`
  ADD PRIMARY KEY (`id_table`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `categorie`
--
ALTER TABLE `categorie`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `chef`
--
ALTER TABLE `chef`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `commande`
--
ALTER TABLE `commande`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT for table `plat`
--
ALTER TABLE `plat`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `serveur`
--
ALTER TABLE `serveur`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `shift`
--
ALTER TABLE `shift`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `table`
--
ALTER TABLE `table`
  MODIFY `id_table` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `commande`
--
ALTER TABLE `commande`
  ADD CONSTRAINT `commande_ibfk_1` FOREIGN KEY (`id_table`) REFERENCES `table` (`id_table`),
  ADD CONSTRAINT `commande_ibfk_2` FOREIGN KEY (`id_chef`) REFERENCES `chef` (`id`);

--
-- Constraints for table `commande_plat`
--
ALTER TABLE `commande_plat`
  ADD CONSTRAINT `commande_plat_ibfk_1` FOREIGN KEY (`id_plat`) REFERENCES `plat` (`id`),
  ADD CONSTRAINT `commande_plat_ibfk_2` FOREIGN KEY (`id_commande`) REFERENCES `commande` (`id`);

--
-- Constraints for table `plat`
--
ALTER TABLE `plat`
  ADD CONSTRAINT `plat_ibfk_1` FOREIGN KEY (`id_categorie`) REFERENCES `categorie` (`id`);

--
-- Constraints for table `shift_serveur`
--
ALTER TABLE `shift_serveur`
  ADD CONSTRAINT `shift_serveur_ibfk_1` FOREIGN KEY (`id_shift`) REFERENCES `shift` (`id`),
  ADD CONSTRAINT `shift_serveur_ibfk_2` FOREIGN KEY (`id_serveur`) REFERENCES `serveur` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
