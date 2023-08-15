# Guide de l'Utilisateur IntelliQuest System

## Introduction
IntelliQuest System est conçu pour simplifier la création et la gestion de quêtes dans Unity. Ce guide vous guidera à travers toutes les fonctionnalités du plugin, de l'installation à la création de quêtes complexes.

## Installation
Pour installer IntelliQuest System, suivez ces étapes:

1. Téléchargez le fichier `.unitypackage` depuis les releases de ce dépôt GitHub.
2. Ouvrez votre projet Unity et importez le package via `Assets > Import Package > Custom Package`.

## Création de Quêtes
### L'Éditeur de Quêtes
Pour ouvrir l'éditeur de quêtes, allez à Window > IntelliQuest Editor. Ici, vous pouvez créer, éditer et supprimer des quêtes.

### Ajout d'Objectifs
1. Sélectionnez une quête existante ou créez-en une nouvelle.
2. Utilisez le bouton `Add Objective` pour ajouter un nouvel objectif.
3. Remplissez les détails de l'objectif, tels que le nom, la description et les critères de réussite.

### Définir des Récompenses
1. Sélectionnez une quête existante.
2. Utilisez le bouton `Add Reward` pour ajouter une nouvelle récompense.
3. Définissez les détails de la récompense, tels que le type et la quantité.

### Quêtes Dynamiques
IntelliQuest System vous permet de générer des quêtes dynamiquement en fonction des actions du joueur. Consultez la section de l'API dans le fichier API_REFERENCE.md pour en savoir plus sur l'utilisation de cette fonctionnalité.

### Intégration dans le Jeu
Pour intégrer les quêtes dans votre jeu:
1. Placez le prefab `QuestManager` dans votre scène.
2. Utilisez le QuestManager pour interagir avec les quêtes à partir de vos scripts.
