-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 22 Ara 2021, 20:11:27
-- Sunucu sürümü: 10.4.18-MariaDB
-- PHP Sürümü: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `staj`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `class`
--

CREATE TABLE `class` (
  `id` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `class`
--

INSERT INTO `class` (`id`, `Name`) VALUES
(1, 'A ŞUBESİ'),
(2, 'B ŞUBESİ');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `discontinuity`
--

CREATE TABLE `discontinuity` (
  `id` int(255) NOT NULL,
  `StudentNo` varchar(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Gender` varchar(50) NOT NULL,
  `Program` varchar(255) NOT NULL,
  `Lesson` varchar(255) NOT NULL,
  `Tarih` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `discontinuity`
--

INSERT INTO `discontinuity` (`id`, `StudentNo`, `Name`, `Gender`, `Program`, `Lesson`, `Tarih`) VALUES
(1, '200130070', 'Buse', 'KIZ', 'Bilgisayar Programcılığı', 'Nesne Tabanlı Programlama', '2021-12-12'),
(2, '200130070', 'Buse', 'KIZ', 'Bilgisayar Programcılığı', 'İnternet Programcılığı', '2021-12-12'),
(3, '200130070', 'Buse', 'KIZ', 'Bilgisayar Programcılığı', 'İnternet Programcılığı', '2021-12-06'),
(4, '200130071', 'Ayşe', 'KIZ', 'Bilgisayar Programcılığı', 'İnternet Programcılığı', '2021-12-06'),
(5, '200130071', 'Ayşe', 'KIZ', 'Bilgisayar Programcılığı', 'Mesleki Yabancı Dil', '2021-12-17'),
(6, '200130080', 'Ahmet', 'ERKEK', 'Bilgisayar Programcılığı', 'Nesne Tabanlı Programlama', '2021-12-23'),
(7, '200130080', 'Ahmet', 'ERKEK', 'Bilgisayar Programcılığı', 'İnternet Programcılığı', '2021-12-05'),
(8, '200130087', 'Eymen', 'ERKEK', 'Bilgisayar Programcılığı', 'Mesleki Yabancı Dil', '2021-12-05'),
(9, '200130087', 'Eymen', 'ERKEK', 'Bilgisayar Programcılığı', 'Nesne Tabanlı Programlama', '2021-12-05'),
(10, '200121070', 'Fatma', 'KIZ', 'Bilgisayar Programcılığı', 'İnternet Programcılığı', '2021-12-05'),
(11, '200121070', 'Fatma', 'KIZ', 'Bilgisayar Programcılığı', 'İnternet Programcılığı', '2021-12-08'),
(12, '200121070', 'Fatma', 'KIZ', 'Bilgisayar Programcılığı', 'Nesne Tabanlı Programlama', '2021-12-06'),
(13, '200120070', 'Fadime', 'KIZ', 'Bilgisayar Programcılığı', 'Nesne Tabanlı Programlama', '2021-12-06'),
(14, '200120070', 'Fadime', 'KIZ', 'Bilgisayar Programcılığı', 'Kriptolojinin Temelleri', '2021-12-06'),
(15, '210120071', 'Haydar', 'ERKEK', 'Bilgisayar Mühendisliği', 'Bilgisayar Müh  Giriş', '2021-12-06'),
(16, '210120070', 'Osman', 'ERKEK', 'Bilgisayar Mühendisliği', 'Bilgisayar Müh  Giriş', '2021-12-06'),
(17, '200120070', 'Fadime', 'KIZ', 'Bilgisayar Programcılığı', 'İnternet Programcılığı', '2021-12-14');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `gender`
--

CREATE TABLE `gender` (
  `id` int(11) NOT NULL,
  `Gender` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `gender`
--

INSERT INTO `gender` (`id`, `Gender`) VALUES
(1, 'ERKEK'),
(2, 'KIZ');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `lesson`
--

CREATE TABLE `lesson` (
  `id` int(255) NOT NULL,
  `Program` varchar(255) NOT NULL,
  `Lesson` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `lesson`
--

INSERT INTO `lesson` (`id`, `Program`, `Lesson`) VALUES
(1, 'Bilgisayar Programcılığı', 'Nesne Tabanlı Programlama'),
(2, 'Bilgisayar Programcılığı', 'İnternet Programcılığı'),
(3, 'Bilgisayar Programcılığı', 'Mesleki Yabancı Dil'),
(4, 'Bilgisayar Programcılığı', 'Kriptolojinin Temelleri'),
(5, 'Bilgisayar Mühendisliği', 'Bilgisayar Biliminin Temelleri'),
(6, 'Bilgisayar Mühendisliği', 'Bilgisayar Müh  Giriş'),
(7, 'Bilgisayar Mühendisliği', 'Algoritma Ve Programlama'),
(8, 'Bilgisayar Mühendisliği', 'Mesleki İngilizce'),
(9, 'Bilgisayar Mühendisliği', 'Fizik 1'),
(10, 'Bilgisayar Mühendisliği', 'Matematik 1'),
(11, 'Yazılım Mühendisliği', 'Algoritma'),
(12, 'Yazılım Mühendisliği', 'İleri Matematik'),
(13, 'Yazılım Mühendisliği', 'İleri Fizik'),
(14, 'Yazılım Mühendisliği', 'Nesne Tabanlı Programlama'),
(15, 'Yazılım Mühendisliği', 'Veri Analizi');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `notes`
--

CREATE TABLE `notes` (
  `id` int(255) NOT NULL,
  `StudentNo` varchar(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Surname` varchar(255) NOT NULL,
  `Gender` varchar(50) NOT NULL,
  `Program` varchar(255) NOT NULL,
  `Lesson` varchar(100) NOT NULL,
  `Note` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `notes`
--

INSERT INTO `notes` (`id`, `StudentNo`, `Name`, `Surname`, `Gender`, `Program`, `Lesson`, `Note`) VALUES
(1, '200130070', 'Buse', 'Telli', 'KIZ', 'Bilgisayar Programcılığı', 'Nesne Tabanlı Programlama', 100),
(2, '200130070', 'Buse', 'Telli', 'KIZ', 'Bilgisayar Programcılığı', 'İnternet Programcılığı', 70),
(3, '200130070', 'Buse', 'Telli', 'KIZ', 'Bilgisayar Programcılığı', 'Mesleki Yabancı Dil', 64),
(4, '200130070', 'Buse', 'Telli', 'KIZ', 'Bilgisayar Programcılığı', 'Kriptolojinin Temelleri', 89),
(5, '200130071', 'Ayşe', 'Telli', 'KIZ', 'Bilgisayar Programcılığı', 'Kriptolojinin Temelleri', 54),
(6, '200130071', 'Ayşe', 'Telli', 'KIZ', 'Bilgisayar Programcılığı', 'Mesleki Yabancı Dil', 60),
(7, '200130071', 'Ayşe', 'Telli', 'KIZ', 'Bilgisayar Programcılığı', 'İnternet Programcılığı', 56),
(8, '200130071', 'Ayşe', 'Telli', 'KIZ', 'Bilgisayar Programcılığı', 'Nesne Tabanlı Programlama', 80),
(9, '200130080', 'Ahmet', 'Yıldız', 'ERKEK', 'Bilgisayar Programcılığı', 'Nesne Tabanlı Programlama', 10),
(10, '200130080', 'Ahmet', 'Yıldız', 'ERKEK', 'Bilgisayar Programcılığı', 'İnternet Programcılığı', 50),
(11, '200130080', 'Ahmet', 'Yıldız', 'ERKEK', 'Bilgisayar Programcılığı', 'Mesleki Yabancı Dil', 70),
(12, '200130080', 'Ahmet', 'Yıldız', 'ERKEK', 'Bilgisayar Programcılığı', 'Kriptolojinin Temelleri', 50),
(13, '210120070', 'Osman', 'Telli', 'ERKEK', 'Bilgisayar Mühendisliği', 'Bilgisayar Müh  Giriş', 65),
(14, '200130070', 'Buse', 'Telli', 'KIZ', 'Bilgisayar Programcılığı', 'İnternet Programcılığı', 100);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `notice`
--

CREATE TABLE `notice` (
  `id` int(255) NOT NULL,
  `Subject` varchar(255) NOT NULL,
  `Content` varchar(255) NOT NULL,
  `MailTo` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `notice`
--

INSERT INTO `notice` (`id`, `Subject`, `Content`, `MailTo`) VALUES
(1, 'wdwd', 'dwdw', 'erenyildizd@gmail.com;');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `program`
--

CREATE TABLE `program` (
  `id` int(255) NOT NULL,
  `Name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `program`
--

INSERT INTO `program` (`id`, `Name`) VALUES
(1, 'Bilgisayar Programcılığı'),
(2, 'Bilgisayar Mühendisliği'),
(3, 'Yazılım Mühendisliği');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `students`
--

CREATE TABLE `students` (
  `StudentNo` int(255) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Surname` varchar(50) NOT NULL,
  `Gender` varchar(20) NOT NULL,
  `Mail` varchar(100) NOT NULL,
  `Tel` varchar(50) NOT NULL,
  `Program` varchar(50) NOT NULL,
  `Class` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `students`
--

INSERT INTO `students` (`StudentNo`, `Name`, `Surname`, `Gender`, `Mail`, `Tel`, `Program`, `Class`) VALUES
(2103, 'Hatice', 'Telli', 'KIZ', 'mail@mail.com', '05005408520', 'Yazılım Mühendisliği', 'B ŞUBESİ'),
(200120070, 'Fadime', 'Telli', 'KIZ', 'mail@mail.com', '05005408520', 'Bilgisayar Programcılığı', 'B ŞUBESİ'),
(200121070, 'Fatma', 'Telli', 'KIZ', 'mail@mail.com', '05005408520', 'Bilgisayar Programcılığı', 'B ŞUBESİ'),
(200130032, 'Eren ', 'Yıldız', 'ERKEK', 'erenyildizd@gmail.com', '0525050505', 'Bilgisayar Programcılığı', 'B ŞUBESİ'),
(200130070, 'Buse', 'Telli', 'KIZ', 'mail@mail.com', '05005408520', 'Bilgisayar Programcılığı', 'A ŞUBESİ'),
(200130071, 'Ayşe', 'Telli', 'KIZ', 'mail@mail.com', '05005408520', 'Bilgisayar Programcılığı', 'A ŞUBESİ'),
(200130080, 'Ahmet', 'Yıldız', 'ERKEK', 'mail@mail.com', '05005408520', 'Bilgisayar Programcılığı', 'A ŞUBESİ'),
(200130087, 'Eymen', 'Karabudak', 'ERKEK', 'zeyteymen@gmail.com', '05459052651', 'Bilgisayar Programcılığı', 'A ŞUBESİ'),
(205261025, 'emrecan', 'uncu', 'ERKEK', 'aldasdhas@gmail.com', '021256545', 'Yazılım Mühendisliği', 'A ŞUBESİ'),
(210120070, 'Osman', 'Telli', 'ERKEK', 'mail@mail.com', '05005408520', 'Bilgisayar Mühendisliği', 'A ŞUBESİ'),
(210120071, 'Haydar', 'Telli', 'ERKEK', 'mail@mail.com', '05005408520', 'Bilgisayar Mühendisliği', 'A ŞUBESİ'),
(210121710, 'Büşra', 'Telli', 'KIZ', 'mail@mail.com', '05005408520', 'Yazılım Mühendisliği', 'B ŞUBESİ'),
(210122070, 'Hatice', 'Telli', 'KIZ', 'mail@mail.com', '05005408520', 'Bilgisayar Mühendisliği', 'B ŞUBESİ'),
(210421710, 'Buğra', 'Telli', 'ERKEK', 'mail@mail.com', '05005408520', 'Yazılım Mühendisliği', 'A ŞUBESİ'),
(210421730, 'Deniz', 'Telli', 'ERKEK', 'mail@mail.com', '05005408520', 'Yazılım Mühendisliği', 'A ŞUBESİ'),
(2101220710, 'Hatice', 'Telli', 'KIZ', 'mail@mail.com', '05005408520', 'Bilgisayar Mühendisliği', 'B ŞUBESİ');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `class`
--
ALTER TABLE `class`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `discontinuity`
--
ALTER TABLE `discontinuity`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `gender`
--
ALTER TABLE `gender`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `lesson`
--
ALTER TABLE `lesson`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `notes`
--
ALTER TABLE `notes`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `notice`
--
ALTER TABLE `notice`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `program`
--
ALTER TABLE `program`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`StudentNo`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `class`
--
ALTER TABLE `class`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Tablo için AUTO_INCREMENT değeri `discontinuity`
--
ALTER TABLE `discontinuity`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- Tablo için AUTO_INCREMENT değeri `gender`
--
ALTER TABLE `gender`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Tablo için AUTO_INCREMENT değeri `lesson`
--
ALTER TABLE `lesson`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- Tablo için AUTO_INCREMENT değeri `notes`
--
ALTER TABLE `notes`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- Tablo için AUTO_INCREMENT değeri `notice`
--
ALTER TABLE `notice`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Tablo için AUTO_INCREMENT değeri `program`
--
ALTER TABLE `program`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
