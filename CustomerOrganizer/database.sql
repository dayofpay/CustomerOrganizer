-- phpMyAdmin SQL Dump
-- version 4.9.7
-- https://www.phpmyadmin.net/
--
-- Хост: localhost:3306
-- Време на генериране: 26 дек 2022 в 01:17
-- Версия на сървъра: 10.3.36-MariaDB-log-cll-lve
-- Версия на PHP: 7.4.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
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
  `firstName` varchar(256) CHARACTER SET utf8 NOT NULL,
  `secondName` varchar(256) CHARACTER SET utf8 NOT NULL,
  `thridName` varchar(256) CHARACTER SET utf8 NOT NULL,
  `phone_number` varchar(256) CHARACTER SET utf8 NOT NULL,
  `fax` varchar(256) CHARACTER SET utf8 NOT NULL,
  `email` varchar(256) CHARACTER SET utf8 NOT NULL,
  `address` varchar(256) CHARACTER SET utf8 NOT NULL,
  `age` int(200) NOT NULL,
  `sex` varchar(256) CHARACTER SET utf8 NOT NULL,
  `id` int(200) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Схема на данните от таблица `customers`
--

INSERT INTO `customers` (`firstName`, `secondName`, `thridName`, `phone_number`, `fax`, `email`, `address`, `age`, `sex`, `id`) VALUES
('First Name', 'Second Name', 'Third Name', 'Phone Number', 'Fax', 'Email', 'Address', 53, 'Sex', 1);

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
