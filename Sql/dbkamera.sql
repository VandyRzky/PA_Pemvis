-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: May 14, 2025 at 10:10 AM
-- Server version: 8.0.30
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbkamera`
--

-- --------------------------------------------------------

--
-- Table structure for table `kameras`
--

CREATE TABLE `kameras` (
  `kodeKamera` varchar(5) NOT NULL,
  `merkKamera` varchar(50) NOT NULL,
  `seriKamera` varchar(50) NOT NULL,
  `harga` int NOT NULL,
  `username` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `kameras`
--

INSERT INTO `kameras` (`kodeKamera`, `merkKamera`, `seriKamera`, `harga`, `username`) VALUES
('2', 'sony', 'a7 iii', 0, 'vandy'),
('3', 'wad', 'dd', 11, NULL),
('4', 'adadad', 'adadad', 1000, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `transaksitb`
--

CREATE TABLE `transaksitb` (
  `id` int NOT NULL,
  `tanggalPinjam` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `tanggalKembali` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `totalHarga` int NOT NULL,
  `statusSewa` varchar(50) NOT NULL,
  `kodeKamera` varchar(5) NOT NULL,
  `username` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `transaksitb`
--

INSERT INTO `transaksitb` (`id`, `tanggalPinjam`, `tanggalKembali`, `totalHarga`, `statusSewa`, `kodeKamera`, `username`) VALUES
(2, '2025-05-10 00:00:00 ', '2025-05-11 00:00:00 ', 2000, 'Selesai', '4', 'dummy');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `username` varchar(15) NOT NULL,
  `password` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`username`, `password`) VALUES
('azril', '123'),
('dummy', 'dummy'),
('dummy2', 'dummy'),
('vandy', 'vandy');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `kameras`
--
ALTER TABLE `kameras`
  ADD PRIMARY KEY (`kodeKamera`) USING BTREE,
  ADD KEY `fkusername` (`username`);

--
-- Indexes for table `transaksitb`
--
ALTER TABLE `transaksitb`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fkusernametransasksi` (`username`),
  ADD KEY `fkkodetransaksi` (`kodeKamera`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `transaksitb`
--
ALTER TABLE `transaksitb`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `kameras`
--
ALTER TABLE `kameras`
  ADD CONSTRAINT `fkusername` FOREIGN KEY (`username`) REFERENCES `users` (`username`) ON DELETE SET NULL;

--
-- Constraints for table `transaksitb`
--
ALTER TABLE `transaksitb`
  ADD CONSTRAINT `fkkodetransaksi` FOREIGN KEY (`kodeKamera`) REFERENCES `kameras` (`kodeKamera`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  ADD CONSTRAINT `fkusernametransasksi` FOREIGN KEY (`username`) REFERENCES `users` (`username`) ON DELETE RESTRICT ON UPDATE RESTRICT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
