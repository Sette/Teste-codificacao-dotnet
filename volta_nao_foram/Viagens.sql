-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: 26-Out-2018 às 22:58
-- Versão do servidor: 10.1.36-MariaDB
-- versão do PHP: 7.2.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `Viagens`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `Motorista`
--

CREATE TABLE `Motorista` (
  `MotoristaId` int(11) NOT NULL,
  `Nome` varchar(60) COLLATE utf8_unicode_ci NOT NULL,
  `Idade` int(11) NOT NULL,
  `Cpf` varchar(11) COLLATE utf8_unicode_ci NOT NULL,
  `Celular` varchar(15) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Extraindo dados da tabela `Motorista`
--

INSERT INTO `Motorista` (`MotoristaId`, `Nome`, `Idade`, `Cpf`, `Celular`) VALUES
(1, 'Jossan', 26, '68045465042', '65999400521'),
(2, 'Allan', 40, '08849949022', '65994562345'),
(3, 'Luan', 30, '70204536006', '65994563456'),
(4, 'Luciano', 33, '74465873000', '65987656574'),
(5, 'Wagner', 32, '80834431076', '65986757875');

-- --------------------------------------------------------

--
-- Estrutura da tabela `Veiculo`
--

CREATE TABLE `Veiculo` (
  `VeiculoId` int(11) NOT NULL,
  `Placa` varchar(7) COLLATE utf8_unicode_ci NOT NULL,
  `Cor` varchar(30) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Extraindo dados da tabela `Veiculo`
--

INSERT INTO `Veiculo` (`VeiculoId`, `Placa`, `Cor`) VALUES
(1, 'QAQ1234', 'Verde'),
(2, 'DED2341', 'Branco'),
(3, 'QAD4567', 'Branco'),
(4, 'DSD4213', 'Vermelho');

-- --------------------------------------------------------

--
-- Estrutura da tabela `Viagem`
--

CREATE TABLE `Viagem` (
  `ViagemID` int(11) NOT NULL,
  `MotoristaID` int(11) NOT NULL,
  `VeiculoID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Extraindo dados da tabela `Viagem`
--

INSERT INTO `Viagem` (`ViagemID`, `MotoristaID`, `VeiculoID`) VALUES
(1, 1, 1),
(2, 3, 2),
(3, 4, 3),
(4, 2, 4),
(5, 1, 2);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Motorista`
--
ALTER TABLE `Motorista`
  ADD PRIMARY KEY (`MotoristaId`);

--
-- Indexes for table `Veiculo`
--
ALTER TABLE `Veiculo`
  ADD PRIMARY KEY (`VeiculoId`);

--
-- Indexes for table `Viagem`
--
ALTER TABLE `Viagem`
  ADD PRIMARY KEY (`ViagemID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `Motorista`
--
ALTER TABLE `Motorista`
  MODIFY `MotoristaId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `Veiculo`
--
ALTER TABLE `Veiculo`
  MODIFY `VeiculoId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `Viagem`
--
ALTER TABLE `Viagem`
  MODIFY `ViagemID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
