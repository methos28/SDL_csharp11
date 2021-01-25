-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 25, 2021 at 07:41 PM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 7.4.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sdl_database`
--

-- --------------------------------------------------------

--
-- Table structure for table `dbs_personal`
--

CREATE TABLE `dbs_personal` (
  `ID` int(200) NOT NULL,
  `Username` varchar(200) NOT NULL,
  `Password` varchar(200) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Contact` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `dbs_personal`
--

INSERT INTO `dbs_personal` (`ID`, `Username`, `Password`, `Email`, `Contact`) VALUES
(1, 'methos', 'dms231259', 'pmdhupkar@gmail.com', '8655873988'),
(2, 'mohan', 'dms231259', 'msdhupkar@gmail.com', '9766358228');

-- --------------------------------------------------------

--
-- Table structure for table `foodorder`
--

CREATE TABLE `foodorder` (
  `ID` int(100) NOT NULL,
  `Catagory` varchar(200) NOT NULL,
  `ItemName` varchar(200) NOT NULL,
  `Cost` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `foodorder`
--

INSERT INTO `foodorder` (`ID`, `Catagory`, `ItemName`, `Cost`) VALUES
(2, 'South Indian', 'Dosa', '100'),
(3, 'American', 'Cheese Burger(jumbo)', '150'),
(4, 'Punjabi', 'paneer matar masala', '150'),
(5, 'Punjabi', 'Veg Makkhanwala', '180'),
(6, 'Punjabi', 'Veg Chana masala', '180'),
(7, 'Punjabi', 'Veg Paneer Tikka', '180'),
(8, 'Mexican', 'Cheese Tacos', '250'),
(9, 'Mexican', 'Mexican Tortilla with salsa', '260'),
(10, 'Italian', 'Spaghetti', '190'),
(11, 'Italian', 'Calzone', '200'),
(12, 'Italian', 'Pizza(medium)', '200'),
(13, 'Deserts', 'Sundayz Butturscotch Flavor', '200'),
(14, 'Deserts', 'Kharvas', '150'),
(15, 'Softdrinks', 'Mazza', '50'),
(16, 'Softdrinks', 'Coke', '50'),
(17, 'Softdrinks', 'Appy Fizz', '30'),
(18, 'Softdrinks', 'Red bull', '100'),
(19, 'Chinese', 'HackkaNUBdle', '69');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `dbs_personal`
--
ALTER TABLE `dbs_personal`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Unique` (`Username`) USING BTREE;

--
-- Indexes for table `foodorder`
--
ALTER TABLE `foodorder`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Unique` (`ItemName`) USING BTREE;

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `dbs_personal`
--
ALTER TABLE `dbs_personal`
  MODIFY `ID` int(200) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `foodorder`
--
ALTER TABLE `foodorder`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
