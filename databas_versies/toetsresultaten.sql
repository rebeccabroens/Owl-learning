-- phpMyAdmin SQL Dump
-- version 4.5.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jan 19, 2017 at 01:18 PM
-- Server version: 5.7.11
-- PHP Version: 5.6.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `owl-learn`
--

-- --------------------------------------------------------

--
-- Table structure for table `toetsresultaten`
--

CREATE TABLE `toetsresultaten` (
  `ToetsResultaatID` int(11) NOT NULL COMMENT 'Toets resultaat id',
  `UserID` int(11) NOT NULL COMMENT 'User id',
  `LesonderwerpID` int(11) NOT NULL COMMENT 'Lesonderwerp id',
  `Resultaat` double NOT NULL COMMENT 'Het cijfer/resultaat'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `toetsresultaten`
--

INSERT INTO `toetsresultaten` (`ToetsResultaatID`, `UserID`, `LesonderwerpID`, `Resultaat`) VALUES
(4, 1, 6, 9.2);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `toetsresultaten`
--
ALTER TABLE `toetsresultaten`
  ADD PRIMARY KEY (`ToetsResultaatID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `toetsresultaten`
--
ALTER TABLE `toetsresultaten`
  MODIFY `ToetsResultaatID` int(11) NOT NULL AUTO_INCREMENT COMMENT 'Toets resultaat id', AUTO_INCREMENT=5;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
