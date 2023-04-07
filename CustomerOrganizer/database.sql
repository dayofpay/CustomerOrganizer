-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Време на генериране:  7 апр 2023 в 04:39
-- Версия на сървъра: 10.4.27-MariaDB
-- Версия на PHP: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данни: `vdevsonl_customer_organizer`
--

-- --------------------------------------------------------

--
-- Структура на таблица `customers`
--

CREATE TABLE `customers` (
  `firstName` varchar(256) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `secondName` varchar(256) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `thirdName` varchar(256) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `phone_number` varchar(256) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `fax` varchar(256) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `email` varchar(256) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `address` varchar(256) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `age` int(200) NOT NULL,
  `sex` varchar(256) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `id` int(200) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Схема на данните от таблица `customers`
--

INSERT INTO `customers` (`firstName`, `secondName`, `thirdName`, `phone_number`, `fax`, `email`, `address`, `age`, `sex`, `id`) VALUES
('First Name', 'Second Name', 'Third Name', 'Phone Number', 'Fax', 'Email', 'Address', 53, 'Sex', 1),
('First Name', 'Second Name', 'Third Name', 'Phone Number', 'FAX', 'Email', 'Address', 53, 'Sex', 2);

--
-- Indexes for dumped tables
--

--
-- Индекси за таблица `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
