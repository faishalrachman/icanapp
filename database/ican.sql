-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 02 Mei 2017 pada 20.07
-- Versi Server: 10.1.19-MariaDB
-- PHP Version: 5.6.28

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
-- Struktur dari tabel `berita`
--

CREATE TABLE `berita` (
  `id_berita` int(11) NOT NULL,
  `judul` text NOT NULL,
  `isi` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `guru`
--

CREATE TABLE `guru` (
  `id_guru` int(11) NOT NULL,
  `id_user` int(11) NOT NULL,
  `NIP` varchar(20) NOT NULL,
  `alamat` text NOT NULL,
  `no_hp` varchar(13) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `guru`
--

INSERT INTO `guru` (`id_guru`, `id_user`, `NIP`, `alamat`, `no_hp`) VALUES
(4, 17, '22', '13', '13'),
(5, 18, '123313', 'F', '083833838');

-- --------------------------------------------------------

--
-- Struktur dari tabel `jadwal`
--

CREATE TABLE `jadwal` (
  `id_jadwal` int(11) NOT NULL,
  `jam` time NOT NULL,
  `hari` text NOT NULL,
  `ruangan` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `jadwal`
--

INSERT INTO `jadwal` (`id_jadwal`, `jam`, `hari`, `ruangan`) VALUES
(2, '06:30:00', 'Selasa', 'X IPA 1');

-- --------------------------------------------------------

--
-- Struktur dari tabel `kelas`
--

CREATE TABLE `kelas` (
  `id_kelas` int(11) NOT NULL,
  `id_guru` int(11) NOT NULL,
  `nama_kelas` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `kelas`
--

INSERT INTO `kelas` (`id_kelas`, `id_guru`, `nama_kelas`) VALUES
(1, 1, 'X IPA 1'),
(2, 1, 'X IPA 2'),
(3, 1, 'X IPA 3'),
(4, 4, 'X IPA 10');

-- --------------------------------------------------------

--
-- Struktur dari tabel `mapel`
--

CREATE TABLE `mapel` (
  `kd_mapel` varchar(20) NOT NULL,
  `nama_mapel` text NOT NULL,
  `id_guru` int(11) NOT NULL,
  `id_kelas` int(11) NOT NULL,
  `id_jadwal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `mapel`
--

INSERT INTO `mapel` (`kd_mapel`, `nama_mapel`, `id_guru`, `id_kelas`, `id_jadwal`) VALUES
('1', 'Matematika', 4, 2, 2),
('INDO-1', 'Bahasa Indonesia', 4, 4, 2);

-- --------------------------------------------------------

--
-- Struktur dari tabel `nilai`
--

CREATE TABLE `nilai` (
  `id_nilai` int(11) NOT NULL,
  `kd_mapel` int(11) NOT NULL,
  `NIS` int(11) NOT NULL,
  `nama_nilai` text NOT NULL,
  `skor` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `siswa`
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
-- Dumping data untuk tabel `siswa`
--

INSERT INTO `siswa` (`NIS`, `id_user`, `jenis_kelamin`, `id_kelas`, `tempat_lahir`, `tanggal_lahir`, `agama`, `alamat`) VALUES
(1310003, 12, 1, 1, 'Bandoeng', '22/08/1997 00.00.00', 'Islam', 'Dimana aja deh gajadi di bandung'),
(1310004, 14, 0, 3, 'Jayapura', '17/08/1945 00.00.00', 'Islam', 'Firdaus');

-- --------------------------------------------------------

--
-- Struktur dari tabel `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` text NOT NULL,
  `nama` text NOT NULL,
  `role` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `user`
--

INSERT INTO `user` (`id`, `username`, `password`, `nama`, `role`) VALUES
(1, 'admin', '123456', 'Faishal Rachman', 'admin'),
(2, 'ipat', '123456', 'Faishal Rachman', 'guru'),
(6, 'admin2', '123456', 'Dani Agung Prasetiyo', 'admin'),
(12, 'ipat2', 'ipatlagi', 'ipatkok', 'siswa'),
(13, 'admin3', '123', 'upil', 'admin'),
(14, 'sarahfl', '123456', 'Sarah Fauzi Bowo', 'siswa'),
(15, '123', '', '123', 'guru'),
(16, 'dws', 'dwsganteng', 'Dodi Wisaksono Sugiharto', 'guru'),
(17, '22', '2', '1313', 'guru'),
(18, 'faishalrachman', '123', 'Faishal R', 'guru');

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_guru`
--
CREATE TABLE `v_guru` (
`id_guru` int(11)
,`id_user` int(11)
,`NIP` varchar(20)
,`nama` text
,`alamat` text
,`no_hp` varchar(13)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_jadwalmapel`
--
CREATE TABLE `v_jadwalmapel` (
`id_jadwal` int(11)
,`id_kelas` int(11)
,`id_guru` int(11)
,`kd_mapel` varchar(20)
,`nama_mapel` text
,`id_user` int(11)
,`NIP` varchar(20)
,`nama` text
,`jam` time
,`hari` text
,`ruangan` text
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_kelas`
--
CREATE TABLE `v_kelas` (
`id_guru` int(11)
,`id_kelas` int(11)
,`nama_kelas` text
,`id_user` int(11)
,`NIP` varchar(20)
,`alamat` text
,`no_hp` varchar(13)
,`id` int(11)
,`username` varchar(50)
,`password` text
,`nama` text
,`role` varchar(10)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_mapel`
--
CREATE TABLE `v_mapel` (
`id_guru` int(11)
,`kd_mapel` varchar(20)
,`nama_mapel` text
,`id_kelas` int(11)
,`id_jadwal` int(11)
,`id_user` int(11)
,`NIP` varchar(20)
,`alamat` text
,`no_hp` varchar(13)
,`id` int(11)
,`username` varchar(50)
,`password` text
,`nama` text
,`role` varchar(10)
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
-- Struktur untuk view `v_guru`
--
DROP TABLE IF EXISTS `v_guru`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_guru`  AS  select `g`.`id_guru` AS `id_guru`,`g`.`id_user` AS `id_user`,`g`.`NIP` AS `NIP`,`u`.`nama` AS `nama`,`g`.`alamat` AS `alamat`,`g`.`no_hp` AS `no_hp` from (`guru` `g` join `user` `u`) where (`g`.`id_user` = `u`.`id`) ;

-- --------------------------------------------------------

--
-- Struktur untuk view `v_jadwalmapel`
--
DROP TABLE IF EXISTS `v_jadwalmapel`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_jadwalmapel`  AS  select `mapel`.`id_jadwal` AS `id_jadwal`,`mapel`.`id_kelas` AS `id_kelas`,`guru`.`id_guru` AS `id_guru`,`mapel`.`kd_mapel` AS `kd_mapel`,`mapel`.`nama_mapel` AS `nama_mapel`,`guru`.`id_user` AS `id_user`,`guru`.`NIP` AS `NIP`,`user`.`nama` AS `nama`,`jadwal`.`jam` AS `jam`,`jadwal`.`hari` AS `hari`,`jadwal`.`ruangan` AS `ruangan` from ((((`mapel` join `guru` on((`mapel`.`id_guru` = `guru`.`id_guru`))) join `kelas` on((`mapel`.`id_kelas` = `kelas`.`id_kelas`))) join `jadwal` on((`mapel`.`id_jadwal` = `jadwal`.`id_jadwal`))) join `user` on((`user`.`id` = `guru`.`id_user`))) ;

-- --------------------------------------------------------

--
-- Struktur untuk view `v_kelas`
--
DROP TABLE IF EXISTS `v_kelas`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_kelas`  AS  select `kelas`.`id_guru` AS `id_guru`,`kelas`.`id_kelas` AS `id_kelas`,`kelas`.`nama_kelas` AS `nama_kelas`,`g`.`id_user` AS `id_user`,`g`.`NIP` AS `NIP`,`g`.`alamat` AS `alamat`,`g`.`no_hp` AS `no_hp`,`u`.`id` AS `id`,`u`.`username` AS `username`,`u`.`password` AS `password`,`u`.`nama` AS `nama`,`u`.`role` AS `role` from ((`kelas` join `guru` `g` on((`kelas`.`id_guru` = `g`.`id_guru`))) join `user` `u` on((`u`.`id` = `g`.`id_user`))) ;

-- --------------------------------------------------------

--
-- Struktur untuk view `v_mapel`
--
DROP TABLE IF EXISTS `v_mapel`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_mapel`  AS  select `m`.`id_guru` AS `id_guru`,`m`.`kd_mapel` AS `kd_mapel`,`m`.`nama_mapel` AS `nama_mapel`,`m`.`id_kelas` AS `id_kelas`,`m`.`id_jadwal` AS `id_jadwal`,`g`.`id_user` AS `id_user`,`g`.`NIP` AS `NIP`,`g`.`alamat` AS `alamat`,`g`.`no_hp` AS `no_hp`,`user`.`id` AS `id`,`user`.`username` AS `username`,`user`.`password` AS `password`,`user`.`nama` AS `nama`,`user`.`role` AS `role` from ((`mapel` `m` join `guru` `g` on((`m`.`id_guru` = `g`.`id_guru`))) join `user` on((`user`.`id` = `g`.`id_user`))) ;

-- --------------------------------------------------------

--
-- Struktur untuk view `v_siswa`
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
-- Indexes for table `mapel`
--
ALTER TABLE `mapel`
  ADD PRIMARY KEY (`kd_mapel`);

--
-- Indexes for table `nilai`
--
ALTER TABLE `nilai`
  ADD PRIMARY KEY (`id_nilai`);

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
  MODIFY `id_guru` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `jadwal`
--
ALTER TABLE `jadwal`
  MODIFY `id_jadwal` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `kelas`
--
ALTER TABLE `kelas`
  MODIFY `id_kelas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `nilai`
--
ALTER TABLE `nilai`
  MODIFY `id_nilai` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `siswa`
--
ALTER TABLE `siswa`
  MODIFY `NIS` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1310005;
--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
