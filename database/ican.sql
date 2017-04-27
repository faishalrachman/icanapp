-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Apr 27, 2017 at 09:11 AM
-- Server version: 10.1.19-MariaDB
-- PHP Version: 5.6.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ican`
--

-- --------------------------------------------------------

--
-- Table structure for table `berita`
--

CREATE TABLE `berita` (
  `id_berita` int(11) NOT NULL,
  `judul` text NOT NULL,
  `isi` text NOT NULL,
  `status` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `guru`
--

CREATE TABLE `guru` (
  `id_guru` int(11) NOT NULL,
  `id_user` int(11) NOT NULL,
  `NIP` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `guru`
--

INSERT INTO `guru` (`id_guru`, `id_user`, `NIP`) VALUES
(1, 2, '10000145554121');

-- --------------------------------------------------------

--
-- Table structure for table `jadwal`
--

CREATE TABLE `jadwal` (
  `id_jadwal` int(11) NOT NULL,
  `jam` time NOT NULL,
  `hari` text NOT NULL,
  `id_ruangan` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `jadwal`
--

INSERT INTO `jadwal` (`id_jadwal`, `jam`, `hari`, `id_ruangan`) VALUES
(2, '06:30:00', 'Selasa', 1);

-- --------------------------------------------------------

--
-- Table structure for table `kelas`
--

CREATE TABLE `kelas` (
  `id_kelas` int(11) NOT NULL,
  `id_guru` int(11) NOT NULL,
  `nama_kelas` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `kelas`
--

INSERT INTO `kelas` (`id_kelas`, `id_guru`, `nama_kelas`) VALUES
(1, 1, 'X IPA 1'),
(2, 1, 'X IPA 2'),
(3, 1, 'X IPA 3');

-- --------------------------------------------------------

--
-- Table structure for table `ruangan`
--

CREATE TABLE `ruangan` (
  `id_ruangan` int(11) NOT NULL,
  `nama_ruangan` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ruangan`
--

INSERT INTO `ruangan` (`id_ruangan`, `nama_ruangan`) VALUES
(1, 'X IPA 1');

-- --------------------------------------------------------

--
-- Table structure for table `siswa`
--

CREATE TABLE `siswa` (
  `NIS` int(11) NOT NULL,
  `id_user` int(11) NOT NULL,
  `jenis_kelamin` tinyint(1) NOT NULL,
  `id_kelas` int(11) NOT NULL,
  `tempat_lahir` text NOT NULL,
  `tanggal_lahir` text NOT NULL,
  `agama` text NOT NULL,
  `alamat` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `siswa`
--

INSERT INTO `siswa` (`NIS`, `id_user`, `jenis_kelamin`, `id_kelas`, `tempat_lahir`, `tanggal_lahir`, `agama`, `alamat`) VALUES
(1310003, 12, 0, 1, 'Bandoeng', '04/04/2016 00.00.00', 'Katholik', 'Jakartau');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` text NOT NULL,
  `nama` text NOT NULL,
  `role` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `username`, `password`, `nama`, `role`) VALUES
(1, 'admin', '123456', 'Ipat Ganteng Banget', 'admin'),
(2, 'ipat', '123456', 'Faishal Rachman', 'guru'),
(6, 'admin2', '123456', 'Dani ga ganteng2 amat', 'admin'),
(12, 'ipat2', 'ipatlagi', 'ipatkok', 'siswa');

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_guru`
--
CREATE TABLE `v_guru` (
`id_guru` int(11)
,`id_user` int(11)
,`NIP` varchar(20)
,`nama` text
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_siswa`
--
CREATE TABLE `v_siswa` (
`NIS` int(11)
,`id_user` int(11)
,`nama` text
,`jenis_kelamin` tinyint(1)
,`nama_kelas` text
,`tempat_lahir` text
,`tanggal_lahir` text
,`agama` text
,`alamat` text
);

-- --------------------------------------------------------

--
-- Structure for view `v_guru`
--
DROP TABLE IF EXISTS `v_guru`;

CREATE ALGORITHM=MERGE DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_guru`  AS  select `g`.`id_guru` AS `id_guru`,`g`.`id_user` AS `id_user`,`g`.`NIP` AS `NIP`,`u`.`nama` AS `nama` from (`guru` `g` join `user` `u`) where (`g`.`id_user` = `u`.`id`) WITH CASCADED CHECK OPTION ;

-- --------------------------------------------------------

--
-- Structure for view `v_siswa`
--
DROP TABLE IF EXISTS `v_siswa`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_siswa`  AS  select `s`.`NIS` AS `NIS`,`s`.`id_user` AS `id_user`,`u`.`nama` AS `nama`,`s`.`jenis_kelamin` AS `jenis_kelamin`,`k`.`nama_kelas` AS `nama_kelas`,`s`.`tempat_lahir` AS `tempat_lahir`,`s`.`tanggal_lahir` AS `tanggal_lahir`,`s`.`agama` AS `agama`,`s`.`alamat` AS `alamat` from ((`user` `u` join `siswa` `s`) join `kelas` `k`) where ((`s`.`id_user` = `u`.`id`) and (`s`.`id_kelas` = `k`.`id_kelas`)) ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `berita`
--
ALTER TABLE `berita`
  ADD PRIMARY KEY (`id_berita`);

--
-- Indexes for table `guru`
--
ALTER TABLE `guru`
  ADD PRIMARY KEY (`id_guru`),
  ADD UNIQUE KEY `NIP` (`NIP`);

--
-- Indexes for table `jadwal`
--
ALTER TABLE `jadwal`
  ADD PRIMARY KEY (`id_jadwal`);

--
-- Indexes for table `kelas`
--
ALTER TABLE `kelas`
  ADD PRIMARY KEY (`id_kelas`);

--
-- Indexes for table `ruangan`
--
ALTER TABLE `ruangan`
  ADD PRIMARY KEY (`id_ruangan`);

--
-- Indexes for table `siswa`
--
ALTER TABLE `siswa`
  ADD PRIMARY KEY (`NIS`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `berita`
--
ALTER TABLE `berita`
  MODIFY `id_berita` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `guru`
--
ALTER TABLE `guru`
  MODIFY `id_guru` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `jadwal`
--
ALTER TABLE `jadwal`
  MODIFY `id_jadwal` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `kelas`
--
ALTER TABLE `kelas`
  MODIFY `id_kelas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `ruangan`
--
ALTER TABLE `ruangan`
  MODIFY `id_ruangan` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `siswa`
--
ALTER TABLE `siswa`
  MODIFY `NIS` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1310004;
--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
