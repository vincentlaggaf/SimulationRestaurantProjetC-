-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Client :  127.0.0.1
-- Généré le :  Mar 11 Décembre 2018 à 10:40
-- Version du serveur :  5.7.14
-- Version de PHP :  7.0.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `bdd_projet_restaurant`
--

-- --------------------------------------------------------

--
-- Structure de la table `commande`
--

CREATE TABLE `commande` (
  `ID_Plat` int(11) NOT NULL,
  `ID_Table` int(11) NOT NULL,
  `Quantite` int(11) NOT NULL,
  `PrixTotal` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `compose`
--

CREATE TABLE `compose` (
  `ID_Plat` int(11) NOT NULL,
  `ID_Ingredient` int(11) NOT NULL,
  `Quantite` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `ingredients`
--

CREATE TABLE `ingredients` (
  `ID_Ingredient` int(11) NOT NULL,
  `Nom` varchar(255) NOT NULL,
  `Quantite` int(11) NOT NULL,
  `Dlc` int(11) NOT NULL,
  `ID_Stock` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `ingredients`
--

INSERT INTO `ingredients` (`ID_Ingredient`, `Nom`, `Quantite`, `Dlc`, `ID_Stock`) VALUES
(1, 'oeuf', 7, 15, 1),
(2, 'tofu', 7, 15, 1);

-- --------------------------------------------------------

--
-- Structure de la table `materielcommun`
--

CREATE TABLE `materielcommun` (
  `ID_MaterielCommun` int(11) NOT NULL,
  `Nom` varchar(255) NOT NULL,
  `Quantite` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `materielcommun`
--

INSERT INTO `materielcommun` (`ID_MaterielCommun`, `Nom`, `Quantite`) VALUES
(1, 'plate', 50),
(2, 'fork', 50),
(3, 'knife', 50),
(4, 'spoon', 50),
(5, 'glass', 50);

-- --------------------------------------------------------

--
-- Structure de la table `materielsallerestau`
--

CREATE TABLE `materielsallerestau` (
  `ID_MaterielSalleRestau` int(11) NOT NULL,
  `Nom` varchar(255) NOT NULL,
  `Quantite` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `plat`
--

CREATE TABLE `plat` (
  `ID_Plat` int(11) NOT NULL,
  `Type` varchar(255) NOT NULL,
  `Nom` varchar(255) NOT NULL,
  `Prix` int(11) NOT NULL,
  `Preparation` double NOT NULL,
  `Cuisson` double NOT NULL,
  `NbrePersonne` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `plat`
--

INSERT INTO `plat` (`ID_Plat`, `Type`, `Nom`, `Prix`, `Preparation`, `Cuisson`, `NbrePersonne`) VALUES
(1, 'normal', 'omelette', 10, 3, 2, 1),
(2, 'végétarien', 'tofu', 15, 3, 2, 1);

-- --------------------------------------------------------

--
-- Structure de la table `pose`
--

CREATE TABLE `pose` (
  `ID_Table` int(11) NOT NULL,
  `ID_MaterielSalleRestau` int(11) NOT NULL,
  `Quantite` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `tables`
--

CREATE TABLE `tables` (
  `ID_Table` int(11) NOT NULL,
  `Places` int(11) NOT NULL,
  `occuper` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `tables`
--

INSERT INTO `tables` (`ID_Table`, `Places`, `occuper`) VALUES
(1, 4, 1),
(2, 4, 1),
(3, 4, 1),
(4, 4, 1);

-- --------------------------------------------------------

--
-- Structure de la table `utilise`
--

CREATE TABLE `utilise` (
  `ID_Plat` int(11) NOT NULL,
  `ID_MaterielCommun` int(11) NOT NULL,
  `Quantite` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `zone_stockage`
--

CREATE TABLE `zone_stockage` (
  `ID_Stock` int(11) NOT NULL,
  `Nom` varchar(255) NOT NULL,
  `Temperature` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `zone_stockage`
--

INSERT INTO `zone_stockage` (`ID_Stock`, `Nom`, `Temperature`) VALUES
(1, 'frais', 4);

--
-- Index pour les tables exportées
--

--
-- Index pour la table `commande`
--
ALTER TABLE `commande`
  ADD PRIMARY KEY (`ID_Plat`,`ID_Table`),
  ADD KEY `Commande_Table0_FK` (`ID_Table`);

--
-- Index pour la table `compose`
--
ALTER TABLE `compose`
  ADD PRIMARY KEY (`ID_Plat`,`ID_Ingredient`),
  ADD KEY `Compose_Ingredients0_FK` (`ID_Ingredient`);

--
-- Index pour la table `ingredients`
--
ALTER TABLE `ingredients`
  ADD PRIMARY KEY (`ID_Ingredient`),
  ADD KEY `Ingredients_Zone_Stockage_FK` (`ID_Stock`);

--
-- Index pour la table `materielcommun`
--
ALTER TABLE `materielcommun`
  ADD PRIMARY KEY (`ID_MaterielCommun`);

--
-- Index pour la table `materielsallerestau`
--
ALTER TABLE `materielsallerestau`
  ADD PRIMARY KEY (`ID_MaterielSalleRestau`);

--
-- Index pour la table `plat`
--
ALTER TABLE `plat`
  ADD PRIMARY KEY (`ID_Plat`);

--
-- Index pour la table `pose`
--
ALTER TABLE `pose`
  ADD PRIMARY KEY (`ID_Table`,`ID_MaterielSalleRestau`),
  ADD KEY `POSE_MaterielSalleRestau0_FK` (`ID_MaterielSalleRestau`);

--
-- Index pour la table `tables`
--
ALTER TABLE `tables`
  ADD PRIMARY KEY (`ID_Table`);

--
-- Index pour la table `utilise`
--
ALTER TABLE `utilise`
  ADD PRIMARY KEY (`ID_Plat`,`ID_MaterielCommun`),
  ADD KEY `Utilise_MaterielCommun0_FK` (`ID_MaterielCommun`);

--
-- Index pour la table `zone_stockage`
--
ALTER TABLE `zone_stockage`
  ADD PRIMARY KEY (`ID_Stock`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `ingredients`
--
ALTER TABLE `ingredients`
  MODIFY `ID_Ingredient` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT pour la table `materielcommun`
--
ALTER TABLE `materielcommun`
  MODIFY `ID_MaterielCommun` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT pour la table `materielsallerestau`
--
ALTER TABLE `materielsallerestau`
  MODIFY `ID_MaterielSalleRestau` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT pour la table `plat`
--
ALTER TABLE `plat`
  MODIFY `ID_Plat` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT pour la table `tables`
--
ALTER TABLE `tables`
  MODIFY `ID_Table` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT pour la table `zone_stockage`
--
ALTER TABLE `zone_stockage`
  MODIFY `ID_Stock` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `commande`
--
ALTER TABLE `commande`
  ADD CONSTRAINT `Commande_Plat_FK` FOREIGN KEY (`ID_Plat`) REFERENCES `plat` (`ID_Plat`),
  ADD CONSTRAINT `Commande_Table0_FK` FOREIGN KEY (`ID_Table`) REFERENCES `tables` (`ID_Table`);

--
-- Contraintes pour la table `compose`
--
ALTER TABLE `compose`
  ADD CONSTRAINT `Compose_Ingredients0_FK` FOREIGN KEY (`ID_Ingredient`) REFERENCES `ingredients` (`ID_Ingredient`),
  ADD CONSTRAINT `Compose_Plat_FK` FOREIGN KEY (`ID_Plat`) REFERENCES `plat` (`ID_Plat`);

--
-- Contraintes pour la table `ingredients`
--
ALTER TABLE `ingredients`
  ADD CONSTRAINT `Ingredients_Zone_Stockage_FK` FOREIGN KEY (`ID_Stock`) REFERENCES `zone_stockage` (`ID_Stock`);

--
-- Contraintes pour la table `pose`
--
ALTER TABLE `pose`
  ADD CONSTRAINT `POSE_MaterielSalleRestau0_FK` FOREIGN KEY (`ID_MaterielSalleRestau`) REFERENCES `materielsallerestau` (`ID_MaterielSalleRestau`),
  ADD CONSTRAINT `POSE_Table_FK` FOREIGN KEY (`ID_Table`) REFERENCES `tables` (`ID_Table`);

--
-- Contraintes pour la table `utilise`
--
ALTER TABLE `utilise`
  ADD CONSTRAINT `Utilise_MaterielCommun0_FK` FOREIGN KEY (`ID_MaterielCommun`) REFERENCES `materielcommun` (`ID_MaterielCommun`),
  ADD CONSTRAINT `Utilise_Plat_FK` FOREIGN KEY (`ID_Plat`) REFERENCES `plat` (`ID_Plat`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
