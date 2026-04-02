-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 15, 2026 at 08:24 AM
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
-- Database: `pos_sys`
--
CREATE DATABASE IF NOT EXISTS `pos_sys` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `pos_sys`;

-- --------------------------------------------------------

--
-- Table structure for table `employees`
--

CREATE TABLE `employees` (
  `employee_id` int(100) NOT NULL,
  `employee_name` varchar(32) NOT NULL,
  `job_title` varchar(32) NOT NULL,
  `email` varchar(64) NOT NULL,
  `password` varchar(16) NOT NULL,
  `date_modified` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `date_created` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `employees`
--

INSERT INTO `employees` (`employee_id`, `employee_name`, `job_title`, `email`, `password`, `date_modified`, `date_created`) VALUES
(0, 'it_admin_account', 'admin_account', 'N/A', 'password123', '2026-03-12 16:56:47', '2026-03-12 10:29:46'),
(1, 'Francis Adriane Pada-on', 'General Manager', 'padaonfrancis@gmail.com', 'FAPadaon123', '2026-03-12 10:28:28', '2026-03-10 04:14:49'),
(2, 'Norbert Francis Baylon', 'IT Director', 'nfcbaylon@gmail.com', 'NFBaylon123', '2026-03-12 10:28:39', '2026-03-10 04:15:27'),
(3, 'Jeremiah Hidalgo', 'Admin Secretary', 'jbhh524@gmail.com', 'JHidalgo123', '2026-03-12 16:54:02', '2026-03-10 04:20:42');

-- --------------------------------------------------------

--
-- Table structure for table `inventory`
--

CREATE TABLE `inventory` (
  `item_sku` int(100) NOT NULL,
  `description` varchar(64) NOT NULL,
  `reg_price` int(100) NOT NULL,
  `quantity` int(100) NOT NULL,
  `date_created` timestamp NOT NULL DEFAULT current_timestamp(),
  `date_modified` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `inventory`
--

INSERT INTO `inventory` (`item_sku`, `description`, `reg_price`, `quantity`, `date_created`, `date_modified`) VALUES
(1, 'Ballpen Blu', 8, 94, '2026-03-08 07:51:08', '2026-03-12 10:20:44'),
(2, 'Ballpen Blk', 8, 115, '2026-03-08 07:51:08', '2026-03-10 14:44:04'),
(3, 'Ballpen Red', 8, 100, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(4, 'Ballpen Grn', 8, 74, '2026-03-08 07:51:08', '2026-03-14 14:08:10'),
(5, 'GelPen Blu', 18, 56, '2026-03-08 07:51:08', '2026-03-12 08:47:47'),
(6, 'GelPen Blk', 18, 61, '2026-03-08 07:51:08', '2026-03-08 15:25:00'),
(7, 'GelPen Red', 18, 51, '2026-03-08 07:51:08', '2026-03-10 04:36:23'),
(8, 'GelPen Set', 50, 40, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(9, 'MechPencil', 35, 41, '2026-03-08 07:51:08', '2026-03-14 14:08:10'),
(10, 'MechPen Pro', 65, 30, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(11, 'Pencil No2', 7, 151, '2026-03-08 07:51:08', '2026-03-10 04:37:57'),
(12, 'JumboPencil', 12, 90, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(13, 'Lead0.5 Ref', 20, 70, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(14, 'Lead0.7 Ref', 22, 70, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(15, 'CharcoalPen', 25, 35, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(16, 'Eraser Sm', 6, 118, '2026-03-08 07:51:08', '2026-03-12 10:20:44'),
(17, 'Eraser Lg', 12, 80, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(18, 'CleanErase', 15, 60, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(19, 'CorrTape Mn', 35, 50, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(20, 'CorrTape Std', 45, 45, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(21, 'Corr Fluid', 40, 40, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(22, 'Highlite Y', 35, 60, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(23, 'Highlite P', 35, 48, '2026-03-08 07:51:08', '2026-03-12 10:20:44'),
(24, 'Highlite G', 35, 50, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(25, 'Highlite B', 35, 50, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(26, 'Hilite Set4', 120, 25, '2026-03-08 07:51:08', '2026-03-08 08:09:14'),
(27, 'PermMark B', 40, 40, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(28, 'PermMark Bl', 40, 40, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(29, 'WBMark B', 45, 35, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(30, 'WBMark Bl', 45, 35, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(31, 'WBMark R', 45, 35, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(32, 'WBMark Set', 120, 20, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(33, 'Crayons 8', 45, 45, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(34, 'Crayons12', 60, 40, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(35, 'Crayons24', 110, 30, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(36, 'ClrPencil12', 75, 35, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(37, 'ClrPencil24', 140, 23, '2026-03-08 07:51:08', '2026-03-12 10:20:44'),
(38, 'OilPastel12', 85, 30, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(39, 'OilPastel24', 150, 20, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(40, 'WaterClr12', 180, 15, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(41, 'Brush Sm', 25, 60, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(42, 'Brush Med', 30, 50, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(43, 'Brush Lg', 40, 40, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(44, 'SketchPad A4', 95, 30, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(45, 'SketchPad A3', 150, 20, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(46, 'Notebook Reg', 28, 100, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(47, 'Notebook S', 40, 70, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(48, 'Notebook L', 55, 58, '2026-03-08 07:51:08', '2026-03-12 10:20:44'),
(49, 'CompNote', 45, 50, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(50, 'JournalNote', 120, 25, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(51, 'YPad Short', 32, 80, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(52, 'YPad Long', 38, 75, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(53, 'InterPad', 42, 60, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(54, 'Index3x5', 45, 40, '2026-03-08 07:51:08', '2026-03-10 14:44:04'),
(55, 'Index4x6', 55, 35, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(56, 'Bond Short', 200, 51, '2026-03-08 07:51:08', '2026-03-10 14:43:08'),
(57, 'Bond A4/216', 210, 50, '2026-03-08 07:51:08', '2026-03-08 08:10:01'),
(58, 'Bond Long', 220, 40, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(59, 'ColorPaperPk', 95, 30, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(60, 'ConstrPaper', 120, 25, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(61, 'FolderPl S', 10, 100, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(62, 'FolderPl L', 12, 90, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(63, 'ClipFolder', 25, 60, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(64, 'ExpFolder', 85, 30, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(65, 'Binder1in', 120, 25, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(66, 'Binder2in', 150, 20, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(67, 'ClearBook20', 90, 30, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(68, 'ClearBook40', 140, 25, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(69, 'Env LongW', 7, 120, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(70, 'Env LongB', 8, 120, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(71, 'Env LargeB', 15, 80, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(72, 'DocEnv Tie', 18, 60, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(73, 'PaperClip S', 25, 70, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(74, 'PaperClip L', 35, 60, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(75, 'BindClip S', 18, 50, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(76, 'BindClip M', 28, 45, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(77, 'BindClip L', 40, 40, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(78, 'Stapler S', 85, 25, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(79, 'Stapler M', 120, 20, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(80, 'Stapler HD', 280, 10, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(81, 'Staple No10', 20, 70, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(82, 'Staple Std', 28, 60, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(83, 'StapleRem', 22, 30, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(84, 'Punch1Hole', 65, 25, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(85, 'Punch2Hole', 120, 20, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(86, 'Scissor S', 45, 40, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(87, 'Scissor M', 55, 35, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(88, 'Scissor L', 75, 30, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(89, 'Cutter Sm', 35, 40, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(90, 'Cutter Lg', 60, 30, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(91, 'BladeRefill', 30, 55, '2026-03-08 07:51:08', '2026-03-12 16:05:06'),
(92, 'GlueStick S', 25, 60, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(93, 'GlueStick L', 40, 45, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(94, 'WGlue Sm', 25, 50, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(95, 'WGlue Med', 45, 40, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(96, 'WGlue Lg', 65, 30, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(97, 'ClrTape S', 20, 60, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(98, 'ClrTape L', 35, 50, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(99, 'MaskTape S', 30, 50, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(100, 'MaskTape L', 45, 40, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(101, 'DSide Tape', 55, 30, '2026-03-08 07:51:08', '2026-03-08 08:10:39'),
(102, 'TapeDisp', 90, 20, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(103, 'Ruler12in', 18, 70, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(104, 'SteelRuler', 55, 40, '2026-03-08 07:51:08', '2026-03-08 07:51:08'),
(105, 'TriRulerSet', 65, 25, '2026-03-08 07:51:09', '2026-03-08 07:51:09'),
(106, 'Protractor', 20, 35, '2026-03-08 07:51:09', '2026-03-08 07:51:09'),
(107, 'CompassSet', 85, 25, '2026-03-08 07:51:09', '2026-03-08 07:51:09'),
(108, 'MathKit Reg', 120, 20, '2026-03-08 07:51:09', '2026-03-08 07:56:23'),
(109, 'Sharpener S', 10, 80, '2026-03-08 07:51:09', '2026-03-08 07:51:09'),
(110, 'Sharpener D', 18, 60, '2026-03-08 07:51:09', '2026-03-08 07:51:09'),
(111, 'SharpCont', 25, 40, '2026-03-08 07:51:09', '2026-03-08 07:51:09'),
(112, 'Desk Orgnzr', 150, 15, '2026-03-08 07:51:09', '2026-03-08 08:08:39'),
(113, 'PenHolder', 65, 30, '2026-03-08 07:51:09', '2026-03-08 07:51:09'),
(114, 'StickyNote S', 40, 50, '2026-03-08 07:51:09', '2026-03-08 07:51:09'),
(115, 'StickyNote M', 55, 40, '2026-03-08 07:51:09', '2026-03-08 07:51:09'),
(116, 'StickyNote L', 75, 30, '2026-03-08 07:51:09', '2026-03-08 07:51:09'),
(117, 'StickyFlags', 65, 30, '2026-03-08 07:51:09', '2026-03-10 08:29:44'),
(118, 'WBEraser', 45, 30, '2026-03-08 07:51:09', '2026-03-08 07:51:09'),
(119, 'Mini/S WB', 180, 15, '2026-03-08 07:51:09', '2026-03-08 07:56:13'),
(120, 'Desk Calc', 95, 20, '2026-03-08 07:51:09', '2026-03-08 07:55:53'),
(122, 'Ylwpad 100s', 45, 100, '2026-03-12 15:54:30', '2026-03-12 15:54:30'),
(124, '', 0, 0, '2026-03-15 04:24:21', '2026-03-15 04:24:21');

-- --------------------------------------------------------

--
-- Table structure for table `item_purchases`
--

CREATE TABLE `item_purchases` (
  `purchase_id` int(100) NOT NULL,
  `payment_id` int(100) NOT NULL,
  `item_sku` int(100) NOT NULL,
  `purchase_qty` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `item_purchases`
--

INSERT INTO `item_purchases` (`purchase_id`, `payment_id`, `item_sku`, `purchase_qty`) VALUES
(8, 1, 1, 2),
(9, 1, 16, 2),
(10, 1, 23, 2),
(11, 1, 37, 2),
(12, 1, 48, 2),
(13, 2, 4, 6),
(14, 2, 9, 5);

-- --------------------------------------------------------

--
-- Table structure for table `payment_records`
--

CREATE TABLE `payment_records` (
  `payment_id` int(100) NOT NULL,
  `payment_total` decimal(30,2) NOT NULL,
  `gross_total` decimal(30,2) NOT NULL,
  `vat_total` decimal(30,2) NOT NULL,
  `customer` varchar(32) NOT NULL,
  `employee_id` int(100) NOT NULL,
  `date_transaction` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `payment_records`
--

INSERT INTO `payment_records` (`payment_id`, `payment_total`, `gross_total`, `vat_total`, `customer`, `employee_id`, `date_transaction`) VALUES
(1, 546.56, 488.00, 58.56, 'Ally', 1, '2026-03-12 10:20:44'),
(2, 249.76, 223.00, 26.76, 'Jerome', 0, '2026-03-14 14:08:10');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`employee_id`),
  ADD UNIQUE KEY `employee_name` (`employee_name`);

--
-- Indexes for table `inventory`
--
ALTER TABLE `inventory`
  ADD PRIMARY KEY (`item_sku`);

--
-- Indexes for table `item_purchases`
--
ALTER TABLE `item_purchases`
  ADD PRIMARY KEY (`purchase_id`);

--
-- Indexes for table `payment_records`
--
ALTER TABLE `payment_records`
  ADD PRIMARY KEY (`payment_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `employees`
--
ALTER TABLE `employees`
  MODIFY `employee_id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `inventory`
--
ALTER TABLE `inventory`
  MODIFY `item_sku` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=125;

--
-- AUTO_INCREMENT for table `item_purchases`
--
ALTER TABLE `item_purchases`
  MODIFY `purchase_id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `payment_records`
--
ALTER TABLE `payment_records`
  MODIFY `payment_id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
