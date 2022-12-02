-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 03, 2022 at 12:51 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `website_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `feed_back`
--

CREATE TABLE `feed_back` (
  `srno` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `phone_no` bigint(12) NOT NULL,
  `email_id` varchar(255) NOT NULL,
  `feedback` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `feed_back`
--

INSERT INTO `feed_back` (`srno`, `name`, `phone_no`, `email_id`, `feedback`) VALUES
(1, 'Harshit', 1234567890, 'harshitc286@gmail.com', 'is awesome !'),
(2, 'Muhammed', 5656485656, 'harshitc286@gmail.com', 'is overpower !!'),
(3, 'Harshit', 5656455546, 'harshitc286@gmail.com', 'is Good'),
(4, 'Tony Stark', 5649564356, 'harshitc286@gmail.com', 'Awesome Website Database created');

-- --------------------------------------------------------

--
-- Table structure for table `insert_link`
--

CREATE TABLE `insert_link` (
  `srno` int(11) NOT NULL,
  `webname` varchar(255) NOT NULL,
  `link` varchar(255) NOT NULL,
  `web_use` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `insert_link`
--

INSERT INTO `insert_link` (`srno`, `webname`, `link`, `web_use`) VALUES
(1, 'Temp Mail', 'https://temp-mail.org/en/', 'Temp Mail provides temporary, secure, anonymous, free, disposable email address.'),
(2, 'I Have Been Pwned', 'https://haveibeenpwned.com/', 'Check if your email or phone is in a data breach'),
(3, 'MX Tool Box', 'https://mxtoolbox.com/emailhealth', 'Your Email Health Report or Ip blacklist etc.'),
(4, 'Domain Dossier', 'https://centralops.net/co/DomainDossier.aspx', 'The Domain Dossier Tool Shows You from public records about domain names and IP addresses, investigate cybercrime and Much More'),
(5, 'IP Location', 'https://www.iplocation.net/ip-lookup', 'Track Your City, Country, ISP did you using, and much more.'),
(6, 'Spoon Bill Twitter', 'https://spoonbill.io/', 'Spoonbill lets you see profile changes from the people you follow on Twitter or other social networks And much more.'),
(7, 'Open Railway Map', 'https://www.openrailwaymap.org/index.php', 'Check the World Railway Tracks and much More.'),
(8, 'Instant Street View', 'https://www.instantstreetview.com/', 'Get 3D Street View'),
(9, 'Flight Radar 24Hour', 'https://www.flightradar24.com/19.07,72.89/6', 'Track Flight Radar 24Hours'),
(10, 'Web Archive', 'https://web.archive.org/', 'Track Website Update with Timeline.'),
(11, 'Global Terrorism DataBase', 'https://www.start.umd.edu/gtd/', 'Search in Database Check Attack Type and much More.'),
(12, 'Js Beautify', 'https://beautifier.io/', 'Beautify JavaScript, JSON, React.js, HTML, CSS, SCSS, and SASS'),
(13, 'Barcode Reader', 'https://online-barcode-reader.inliteresearch.com/', 'Free Online Barcode Reader'),
(14, 'Functions Online DeCode AnyThing', 'https://www.functions-online.com/', 'Execute and test several functions of the programming one of the categories array, cryptography, custom, date and time, general, math, regular expression, string or URL, Have Much Fun !'),
(15, 'Fake Name Generator', 'https://www.fakenamegenerator.com/', 'Create Your Fake Name'),
(16, 'Pexels', 'https://www.pexels.com/', 'The best free stock photos, royalty free images & videos shared by creators.'),
(17, 'Privacy Tools', 'https://www.privacytools.io/', 'Privacy Tools: Software Alternatives and Encryption'),
(21, 'Github', 'https://github.com/', 'To Store Code '),
(22, 'Vidyalankar College', 'https://vpt.edu.in/diploma/polytechnic/index.html', 'VP polytechnic'),
(23, 'Call Bomber', 'https://callbombers.com/', 'Here is the first working call bomber. You can just put your friends’ numbers and bomb them. It’s now possible to send unlimited calls, without any restrictions. '),
(24, 'Youtube', 'https://www.youtube.com/', 'Free Online Courses or Videos eetc...'),
(25, 'Tinkercad Projects', 'https://www.tinkercad.com/', 'Get Hand on Projects !');

-- --------------------------------------------------------

--
-- Table structure for table `userid`
--

CREATE TABLE `userid` (
  `srno` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `phoneno` bigint(12) NOT NULL,
  `email_id` varchar(255) NOT NULL,
  `user_id` varchar(255) NOT NULL,
  `user_paswd` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `userid`
--

INSERT INTO `userid` (`srno`, `name`, `phoneno`, `email_id`, `user_id`, `user_paswd`) VALUES
(1, 'Muhammed', 5656455648, 'harshitc286@gmail.com', 'muhammed@123', '123456'),
(2, 'harshit', 8956467979, 'harshitc286@gmail.com', 'harshit', '123456'),
(3, 'Harshit', 5646494646, 'harshitc286@gmail.com', 'harshit@123', '123456789'),
(4, 'Tony Stark', 5656495623, 'harshitc286@gmail.com', 'tony@ironman', 'loveyou3000');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `feed_back`
--
ALTER TABLE `feed_back`
  ADD PRIMARY KEY (`srno`);

--
-- Indexes for table `insert_link`
--
ALTER TABLE `insert_link`
  ADD PRIMARY KEY (`srno`);

--
-- Indexes for table `userid`
--
ALTER TABLE `userid`
  ADD PRIMARY KEY (`srno`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `feed_back`
--
ALTER TABLE `feed_back`
  MODIFY `srno` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `insert_link`
--
ALTER TABLE `insert_link`
  MODIFY `srno` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT for table `userid`
--
ALTER TABLE `userid`
  MODIFY `srno` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
