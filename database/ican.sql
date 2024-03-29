-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 05 Mei 2017 pada 05.02
-- Versi Server: 10.1.19-MariaDB
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
-- Struktur dari tabel `absensi`
--

CREATE TABLE `absensi` (
  `id_absensi` int(11) NOT NULL,
  `NIS` int(11) NOT NULL,
  `kd_mapel` varchar(20) NOT NULL,
  `status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `berita`
--

CREATE TABLE `berita` (
  `id_berita` int(11) NOT NULL,
  `judul` text NOT NULL,
  `isi` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `berita`
--

INSERT INTO `berita` (`id_berita`, `judul`, `isi`) VALUES
(1, 'Uparaca Hari Senin Libur', 'Diberitahukan Kepada Seluruh Siswa bahwa Uacara Hari Senin diliburkan karena Banjir, Pindah Tempat, Konslet');

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
(1, 50, '1101154646', 'Jalan Sukabirus', '87553443211'),
(2, 51, '1101154647', 'Jalan Maju Mundur', '85785016740'),
(3, 52, '1101154648', 'Jalan Kenangan', '89117256372'),
(4, 53, '1101154649', 'Jalan Telekomunikasi', '88934627362'),
(5, 54, '1101154650', 'Jalan Informatika', '89348372837'),
(6, 55, '1101154651', 'Jalan Soekarno', '89732763724'),
(7, 56, '1101154652', 'Jalan Serikat', '89434232133'),
(8, 57, '1101154653', 'jalan Kh. Ahmad Dahlan', '85323221244'),
(9, 58, '1101154654', 'Jalan Motion', '87865745342'),
(10, 59, '1101154655', 'Jalan Computing', '86553443211');

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
(1, '07:00:00', 'Senin', 'KU-001-002'),
(2, '08:00:00', 'Selasa', 'KU-001-003'),
(3, '09:00:00', 'Rabu', 'KU-001-004'),
(4, '10:00:00', 'Kamis', 'KU-001-005'),
(5, '11:00:00', 'Jum''at', 'KU-001-006'),
(6, '13:00:00', 'Sabtu', 'KU-001-007'),
(7, '14:00:00', 'Senin', 'KU-001-008'),
(8, '09:00:00', 'Selasa', 'KU-001-009'),
(9, '08:00:00', 'Rabu', 'KU-001-010'),
(10, '10:00:00', 'Kamis', 'KU-001-011');

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
(1, 1, 'X-IPA 1'),
(2, 2, 'X-IPS 1'),
(3, 3, 'X-BAHASA 1'),
(4, 4, 'XI-IPA 1'),
(5, 5, 'XI-IPS 4'),
(6, 6, 'XI-BAHASA 3'),
(7, 7, 'XII-IPA 2'),
(8, 8, 'XII-IPA 3'),
(9, 9, 'XII-IPS 2'),
(10, 10, 'XII-BAHASA 1');

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
('ARB-002', 'Bahasa Arab', 58, 9, 9),
('ARB-007', 'Bahasa Arab', 4, 4, 7),
('ARB-009', 'Bahasa Arab', 4, 4, 4),
('BIN-001', 'Bahasa Indonesia', 57, 8, 8),
('BIN-002', 'Bahasa Indonesia', 3, 3, 4),
('BIO-003', 'Biologi', 8, 8, 8),
('BIO-008', 'Biologi', 53, 4, 4),
('EKO-001', 'Ekonomi Makro', 55, 6, 6),
('EKO-006', 'Ekonomi', 1, 1, 4),
('FIS-001', 'Fisika', 52, 3, 3),
('FIS-009', 'Fisika', 5, 5, 5),
('GEO-001', 'Geografi', 54, 5, 5),
('GEO-003', 'Geografi', 9, 9, 7),
('GEO-008', 'Geografi', 7, 7, 8),
('JPN-001', 'Bahasa Jepang', 56, 7, 7),
('KIM-001', 'Kimia', 1, 1, 1),
('KWN-001', 'Pendidikan Kewarganegaraan', 50, 1, 1),
('MTK-001', 'Matematika', 51, 2, 2),
('TIK-001', 'Teknologi Informasi', 59, 10, 10);

-- --------------------------------------------------------

--
-- Struktur dari tabel `nilai`
--

CREATE TABLE `nilai` (
  `id_nilai` int(11) NOT NULL,
  `kd_mapel` varchar(20) NOT NULL,
  `NIS` int(11) NOT NULL,
  `nama_nilai` text NOT NULL,
  `skor` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `nilai`
--

INSERT INTO `nilai` (`id_nilai`, `kd_mapel`, `NIS`, `nama_nilai`, `skor`) VALUES
(11, 'KIM-001', 1202160218, 'UJIAN STENGAH SERIUS', 50),
(12, 'KIM-001', 1202160360, 'UJIAN STENGAH SERIUS', 70),
(13, 'KIM-001', 1202164121, 'UJIAN STENGAH SERIUS', 80),
(14, 'KIM-001', 1202164194, 'UJIAN STENGAH SERIUS', 99),
(15, 'KIM-001', 1302150054, 'UJIAN STENGAH SERIUS', 1);

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
(1202150003, 3, 1, 2, 'Bandung', '13/01/1997', 'Islam', 'Jalan Merpati'),
(1202150257, 27, 0, 6, 'Depok', '06/02/1997', 'Islam', 'Jalan Merpati'),
(1202160009, 4, 1, 3, 'jakarta', '14/01/1997', 'Islam', 'Jalan Adipati'),
(1202160041, 28, 0, 7, 'Jakarta Pusat', '07/02/1997', 'Islam', 'Jalan Adipati'),
(1202160057, 29, 0, 8, 'Bandung', '08/02/1997', 'Islam', 'Jalan Soekarno'),
(1202160089, 30, 0, 9, 'bogor', '09/02/1997', 'Islam', 'Jalan Biru'),
(1202160105, 5, 1, 4, 'Riau', '15/01/1997', 'Islam', 'Jalan Soekarno'),
(1202160121, 31, 0, 10, 'Bandung', '10/02/1997', 'Islam', 'Jalan Ungu'),
(1202160153, 6, 1, 5, 'Maluku', '16/01/1997', 'Islam', 'Jalan Biru'),
(1202160178, 7, 1, 6, 'Makassar', '17/01/1997', 'Islam', 'Jalan Ungu'),
(1202160186, 8, 1, 7, 'Yogyakarta', '18/01/1997', 'Islam', 'Jalan Sunda'),
(1202160202, 9, 1, 8, 'Sleman', '19/01/1997', 'Islam', 'Jalan Merpati'),
(1202160210, 10, 1, 9, 'Bandung', '20/01/1997', 'Islam', 'Jalan Adipati'),
(1202160218, 32, 0, 1, 'Bandung', '11/02/1997', 'Islam', 'Jalan Sunda'),
(1202160251, 11, 1, 10, 'Bandung', '21/01/1997', 'Islam', 'Jalan Soekarno'),
(1202160268, 33, 0, 2, 'Depok', '12/02/1997', 'Islam', 'Jalan Merpati'),
(1202160352, 13, 1, 2, 'Bandung', '23/01/1997', 'Kristen', 'Jalan Ungu'),
(1202160360, 12, 1, 1, 'Bandung', '22/01/1997', 'Islam', 'Jalan Biru'),
(1202160380, 14, 1, 3, 'Sleman', '24/01/1997', 'Kristen', 'Jalan Sunda'),
(1202160398, 15, 1, 4, 'Jayapura', '25/01/1997', 'Kristen', 'Jalan Merpati'),
(1202162097, 16, 1, 5, 'Lamongan', '26/01/1997', 'Kristen', 'Jalan Adipati'),
(1202162137, 17, 1, 6, 'Lamongan', '27/01/1997', 'Kristen', 'Jalan Soekarno'),
(1202162369, 18, 1, 7, 'bogor', '28/01/1997', 'Kristen', 'Jalan Biru'),
(1202162389, 34, 0, 3, 'Jakarta Pusat', '13/02/1997', 'Islam', 'Jalan Adipati'),
(1202163170, 35, 0, 4, 'Bandung', '14/02/1997', 'Islam', 'Jalan Soekarno'),
(1202164001, 36, 0, 5, 'bogor', '15/02/1997', 'Islam', 'Jalan Biru'),
(1202164017, 19, 1, 8, 'Bogor', '29/01/1997', 'Kristen', 'Jalan Ungu'),
(1202164025, 20, 1, 9, 'Depok', '30/01/1997', 'Islam', 'Jalan Sunda'),
(1202164033, 21, 1, 10, 'Depok', '31/01/1997', 'Islam', 'Jalan Merpati'),
(1202164049, 37, 0, 6, 'Bandung', '16/02/1997', 'Islam', 'Jalan Ungu'),
(1202164065, 38, 0, 7, 'Bandung', '17/02/1997', 'Islam', 'Jalan Sunda'),
(1202164073, 39, 0, 8, 'Depok', '18/02/1997', 'Islam', 'Jalan Merpati'),
(1202164081, 40, 0, 9, 'Jakarta Pusat', '19/02/1997', 'Islam', 'Jalan Adipati'),
(1202164113, 41, 0, 10, 'Bandung', '20/02/1997', 'Islam', 'Jalan Soekarno'),
(1202164121, 42, 0, 1, 'bogor', '21/02/1997', 'Islam', 'Jalan Biru'),
(1202164161, 43, 0, 2, 'Bandung', '22/02/1997', 'Islam', 'Jalan Ungu'),
(1202164194, 22, 1, 1, 'Jakarta Pusat', '01/02/1997', 'Islam', 'Jalan Adipati'),
(1202164226, 44, 0, 3, 'Bandung', '23/02/1997', 'Islam', 'Jalan Sunda'),
(1202164235, 23, 1, 2, 'Bandung', '02/02/1997', 'Islam', 'Jalan Soekarno'),
(1202164260, 24, 1, 3, 'bogor', '03/02/1997', 'Islam', 'Jalan Biru'),
(1202164276, 25, 1, 4, 'Bandung', '04/02/1997', 'Islam', 'Jalan Ungu'),
(1202164301, 26, 1, 5, 'Bandung', '05/02/1997', 'Islam', 'Jalan Sunda'),
(1202164309, 45, 0, 4, 'Depok', '24/02/1997', 'Islam', 'Jalan Merpati'),
(1202164318, 46, 0, 5, 'Jakarta Pusat', '25/02/1997', 'Islam', 'Jalan Adipati'),
(1202164328, 47, 0, 6, 'Bandung', '26/02/1997', 'Islam', 'Jalan Soekarno'),
(1302150054, 2, 1, 1, 'Lamongan', '12/01/1997', 'Islam', 'Jalan Sunda'),
(1302150055, 62, 0, -1, 'Cikaso', '10/04/2017 00.00.00', 'Islam', 'Jalan Cikaso'),
(1302150056, 63, 1, 3, 'jakardah', '06/04/2017 00.00.00', 'Konghuchu', 'ciamisganteng');

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
(2, 'andhikaik', 'siswaican', 'ANDHIKA IKHSAN', 'siswa'),
(3, 'raflyzulf', 'siswaican', 'RAFLY ZULFI ROBBIANSYAH', 'siswa'),
(4, 'denyusuf', 'siswaican', 'DEN YUSUF RAMDHANI', 'siswa'),
(5, 'dodiyusup', 'siswaican', 'DODI YUSUP HARAHAP', 'siswa'),
(6, 'abdurrahma', 'siswaican', 'ABDURRAHMAN YASKUR', 'siswa'),
(7, 'fadelachm', 'siswaican', 'FADEL ACHMED GANESHA', 'siswa'),
(8, 'irwanadit', 'siswaican', 'IRWAN ADITAMA', 'siswa'),
(9, 'revofaris', 'siswaican', 'REVO FARIS SAIFUDDIN', 'siswa'),
(10, 'muhammada', 'siswaican', 'MUHAMMAD ALWAN HANIF', 'siswa'),
(11, 'leonardot', 'siswaican', 'LEONARDO TAUFAN SONTANI', 'siswa'),
(12, 'tegarkurn', 'siswaican', 'TEGAR KURNIA FAJAR', 'siswa'),
(13, 'ilhamfann', 'siswaican', 'ILHAM FANNANI', 'siswa'),
(14, 'ranggapat', 'siswaican', 'RANGGA PATRA PRATIKTIO', 'siswa'),
(15, 'hendrikea', 'siswaican', 'HENDRIKE ALQARNI', 'siswa'),
(16, 'agungrian', 'siswaican', 'AGUNG RIANSYAH', 'siswa'),
(17, 'naufaldiy', 'siswaican', 'NAUFALDI YUSUF HENDRIAWAN', 'siswa'),
(18, 'mastaufiq', 'siswaican', 'MAS TAUFIQ DIRGA PRASTICARYA', 'siswa'),
(19, 'dewanggap', 'siswaican', 'DEWANGGA PUTRA YUDHISTIRA', 'siswa'),
(20, 'muhammadi', 'siswaican', 'MUHAMMAD IQBAL MUTTAQIN', 'siswa'),
(21, 'muhammadf', 'siswaican', 'MUHAMMAD FATHONI', 'siswa'),
(22, 'bagasadi', 'siswaican', 'BAGAS ADI NUGROHO', 'siswa'),
(23, 'arethafat', 'siswaican', 'ARETHA FATHARANI', 'siswa'),
(24, 'karinafar', 'siswaican', 'KARINA FARIZKI SALMAWATI', 'siswa'),
(25, 'agistidea', 'siswaican', 'AGISTI DEA SAVANA', 'siswa'),
(26, 'adillaama', 'siswaican', 'ADILLA AMALIA AFRI', 'siswa'),
(27, 'reneitara', 'siswaican', 'RENEITA RAHMA CHAIDIR', 'siswa'),
(28, 'muthiaghn', 'siswaican', 'MUTHI AGHNIA TRILEVA', 'siswa'),
(29, 'khoirotun', 'siswaican', 'KHOIROTUN NISA`', 'siswa'),
(30, 'prilidinta', 'siswaican', 'PRILIDINTA MEIDIANTI', 'siswa'),
(31, 'anindyaty', 'siswaican', 'ANINDYA TYAS WULANDARI', 'siswa'),
(32, 'amelliabr', 'siswaican', 'AMELLIA BRILIANT OKTAVIA', 'siswa'),
(33, 'nurinriya', 'siswaican', 'NUR INRIYANI RUSDI', 'siswa'),
(34, 'melliaary', 'siswaican', 'MELLIA ARYA AMINNANDA', 'siswa'),
(35, 'destyhari', 'siswaican', 'DESTY HARISDAYANTI', 'siswa'),
(36, 'adifanuru', 'siswaican', 'ADIFA NURUL RAMADHANTI', 'siswa'),
(37, 'tannimais', 'siswaican', 'TANNI MAISARI', 'siswa'),
(38, 'annisadwi', 'siswaican', 'ANNISA DWIAYU RAMADHANTY', 'siswa'),
(39, 'andinasal', 'siswaican', 'ANDINA SALAMAH', 'siswa'),
(40, 'ismariase', 'siswaican', 'ISMARIA SEKAR MUSTIKA', 'siswa'),
(41, 'shafirafi', 'siswaican', 'SHAFIRA FITRI MAULANI', 'siswa'),
(42, 'fithripeb', 'siswaican', 'FITHRI PEBRINA HARAHAP', 'siswa'),
(43, 'ernynurse', 'siswaican', 'ERNY NURSETYAWATI', 'siswa'),
(44, 'muhammadh', 'siswaican', 'MUHAMMAD HAFIZH SURIAGANDA', 'siswa'),
(45, 'muhammadr', 'siswaican', 'MUHAMMAD RAFIDAN', 'siswa'),
(46, 'rinaldyja', 'siswaican', 'RINALDY JABAR SETIA', 'siswa'),
(47, 'azolladhi', 'siswaican', 'AZOLLA DHIGO PRASETYA', 'siswa'),
(48, 'username', 'password', 'nama', 'role'),
(50, 'daniagung', 'daniagung', 'Dani Agung Prastiyo', 'guru'),
(51, 'ipat', 'ipat', 'Faishal Rachman', 'guru'),
(52, 'rama', 'rama', 'Rama Aditya Maulana', 'guru'),
(53, 'salma', 'salma', 'Salma', 'guru'),
(54, 'rany', 'rany', 'Maharani padma Utami', 'guru'),
(55, 'nana', 'nana', 'Nana Kalsum', 'guru'),
(56, 'aziza', 'aziza', 'Aziza Dwi', 'guru'),
(57, 'adi', 'adi', 'Adi Nugroho', 'guru'),
(58, 'amin', 'amin', 'Amin Dian', 'guru'),
(59, 'aulia', 'aulia', 'Aulia Akbar', 'guru'),
(60, 'admin', 'admin', 'admin ganteng', 'admin'),
(61, 'ipatz', '', '1212', 'siswa'),
(62, 'dummy', '', '', 'siswa');

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_absensi`
--
CREATE TABLE `v_absensi` (
`id_absensi` int(11)
,`NIS` int(11)
,`kd_mapel` varchar(20)
,`nama_mapel` text
,`nama` text
,`status` int(11)
);

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
,`id_guru` int(11)
,`kd_mapel` varchar(20)
,`nama_mapel` text
,`id_kelas` int(11)
,`id_user` int(11)
,`NIP` varchar(20)
,`alamat` text
,`no_hp` varchar(13)
,`jam` time
,`hari` text
,`ruangan` text
,`id` int(11)
,`username` varchar(50)
,`password` text
,`nama` text
,`role` varchar(10)
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
-- Stand-in structure for view `v_nilai`
--
CREATE TABLE `v_nilai` (
`NIS` int(11)
,`kd_mapel` varchar(20)
,`id_nilai` int(11)
,`nama_nilai` text
,`skor` double
,`nama_mapel` text
,`id_guru` int(11)
,`id_kelas` int(11)
,`id_jadwal` int(11)
,`id_user` int(11)
,`nama` text
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_siswa`
--
CREATE TABLE `v_siswa` (
`id_kelas` int(11)
,`NIS` int(11)
,`id_user` int(11)
,`jenis_kelamin` tinyint(1)
,`tempat_lahir` text
,`tanggal_lahir` text
,`agama` text
,`alamat` text
,`id_guru` int(11)
,`nama_kelas` text
,`id` int(11)
,`username` varchar(50)
,`password` text
,`nama` text
,`role` varchar(10)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_walikelas`
--
CREATE TABLE `v_walikelas` (
`id_kelas` int(11)
,`id_guru` int(11)
,`nama_kelas` text
,`NIP` varchar(20)
,`nama` text
,`alamat` text
,`no_hp` varchar(13)
);

-- --------------------------------------------------------

--
-- Struktur untuk view `v_absensi`
--
DROP TABLE IF EXISTS `v_absensi`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_absensi`  AS  select `absensi`.`id_absensi` AS `id_absensi`,`absensi`.`NIS` AS `NIS`,`absensi`.`kd_mapel` AS `kd_mapel`,`mapel`.`nama_mapel` AS `nama_mapel`,`user`.`nama` AS `nama`,`absensi`.`status` AS `status` from (((`absensi` join `siswa` on((`absensi`.`NIS` = `siswa`.`NIS`))) join `user` on((`siswa`.`id_user` = `user`.`id`))) join `mapel` on((`absensi`.`kd_mapel` = `mapel`.`kd_mapel`))) ;

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

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_jadwalmapel`  AS  select `mapel`.`id_jadwal` AS `id_jadwal`,`mapel`.`id_guru` AS `id_guru`,`mapel`.`kd_mapel` AS `kd_mapel`,`mapel`.`nama_mapel` AS `nama_mapel`,`mapel`.`id_kelas` AS `id_kelas`,`guru`.`id_user` AS `id_user`,`guru`.`NIP` AS `NIP`,`guru`.`alamat` AS `alamat`,`guru`.`no_hp` AS `no_hp`,`jadwal`.`jam` AS `jam`,`jadwal`.`hari` AS `hari`,`jadwal`.`ruangan` AS `ruangan`,`user`.`id` AS `id`,`user`.`username` AS `username`,`user`.`password` AS `password`,`user`.`nama` AS `nama`,`user`.`role` AS `role` from (((`mapel` join `guru` on((`mapel`.`id_guru` = `guru`.`id_guru`))) join `jadwal` on((`mapel`.`id_jadwal` = `jadwal`.`id_jadwal`))) join `user` on((`guru`.`id_user` = `user`.`id`))) WITH CASCADED CHECK OPTION ;

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
-- Struktur untuk view `v_nilai`
--
DROP TABLE IF EXISTS `v_nilai`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_nilai`  AS  select `nilai`.`NIS` AS `NIS`,`nilai`.`kd_mapel` AS `kd_mapel`,`nilai`.`id_nilai` AS `id_nilai`,`nilai`.`nama_nilai` AS `nama_nilai`,`nilai`.`skor` AS `skor`,`mapel`.`nama_mapel` AS `nama_mapel`,`mapel`.`id_guru` AS `id_guru`,`mapel`.`id_kelas` AS `id_kelas`,`mapel`.`id_jadwal` AS `id_jadwal`,`siswa`.`id_user` AS `id_user`,`user`.`nama` AS `nama` from (((`nilai` join `mapel` on((`nilai`.`kd_mapel` = `mapel`.`kd_mapel`))) join `siswa` on((`nilai`.`NIS` = `siswa`.`NIS`))) join `user` on((`user`.`id` = `siswa`.`id_user`))) ;

-- --------------------------------------------------------

--
-- Struktur untuk view `v_siswa`
--
DROP TABLE IF EXISTS `v_siswa`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_siswa`  AS  select `siswa`.`id_kelas` AS `id_kelas`,`siswa`.`NIS` AS `NIS`,`siswa`.`id_user` AS `id_user`,`siswa`.`jenis_kelamin` AS `jenis_kelamin`,`siswa`.`tempat_lahir` AS `tempat_lahir`,`siswa`.`tanggal_lahir` AS `tanggal_lahir`,`siswa`.`agama` AS `agama`,`siswa`.`alamat` AS `alamat`,`kelas`.`id_guru` AS `id_guru`,`kelas`.`nama_kelas` AS `nama_kelas`,`user`.`id` AS `id`,`user`.`username` AS `username`,`user`.`password` AS `password`,`user`.`nama` AS `nama`,`user`.`role` AS `role` from ((`siswa` join `kelas` on((`siswa`.`id_kelas` = `kelas`.`id_kelas`))) join `user` on((`user`.`id` = `siswa`.`id_user`))) ;

-- --------------------------------------------------------

--
-- Struktur untuk view `v_walikelas`
--
DROP TABLE IF EXISTS `v_walikelas`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_walikelas`  AS  select `kelas`.`id_kelas` AS `id_kelas`,`kelas`.`id_guru` AS `id_guru`,`kelas`.`nama_kelas` AS `nama_kelas`,`v_guru`.`NIP` AS `NIP`,`v_guru`.`nama` AS `nama`,`v_guru`.`alamat` AS `alamat`,`v_guru`.`no_hp` AS `no_hp` from (`kelas` join `v_guru` on((`kelas`.`id_guru` = `v_guru`.`id_guru`))) ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `absensi`
--
ALTER TABLE `absensi`
  ADD PRIMARY KEY (`id_absensi`);

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
-- AUTO_INCREMENT for table `absensi`
--
ALTER TABLE `absensi`
  MODIFY `id_absensi` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `berita`
--
ALTER TABLE `berita`
  MODIFY `id_berita` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `guru`
--
ALTER TABLE `guru`
  MODIFY `id_guru` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `jadwal`
--
ALTER TABLE `jadwal`
  MODIFY `id_jadwal` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `kelas`
--
ALTER TABLE `kelas`
  MODIFY `id_kelas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `nilai`
--
ALTER TABLE `nilai`
  MODIFY `id_nilai` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
--
-- AUTO_INCREMENT for table `siswa`
--
ALTER TABLE `siswa`
  MODIFY `NIS` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1302150057;
--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=64;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
