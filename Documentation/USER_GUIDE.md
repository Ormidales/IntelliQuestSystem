Guide de l'Utilisateur IntelliQuest System
Table des Matières
Introduction
Installation
Création de Quêtes
L'Éditeur de Quêtes
Ajout d'Objectifs
Définir des Récompenses
Quêtes Dynamiques
Intégration dans le Jeu
Support et Contact
Introduction
IntelliQuest System est conçu pour simplifier la création et la gestion de quêtes dans Unity. Ce guide vous guidera à travers toutes les fonctionnalités du plugin, de l'installation à la création de quêtes complexes.

Installation
Pour installer IntelliQuest System, suivez ces étapes:

Téléchargez le fichier .unitypackage depuis les releases de ce dépôt GitHub.
Ouvrez votre projet Unity et importez le package via Assets > Import Package > Custom Package.
Création de Quêtes
L'Éditeur de Quêtes
Pour ouvrir l'éditeur de quêtes, allez à Window > IntelliQuest Editor. Ici, vous pouvez créer, éditer et supprimer des quêtes.

Ajout d'Objectifs
Sélectionnez une quête existante ou créez-en une nouvelle.
Utilisez le bouton Add Objective pour ajouter un nouvel objectif.
Remplissez les détails de l'objectif, tels que le nom, la description et les critères de réussite.
Définir des Récompenses
Sélectionnez une quête existante.
Utilisez le bouton Add Reward pour ajouter une nouvelle récompense.
Définissez les détails de la récompense, tels que le type et la quantité.
Quêtes Dynamiques
IntelliQuest System vous permet de générer des quêtes dynamiquement en fonction des actions du joueur. Consultez la section de l'API dans le fichier API_REFERENCE.md pour en savoir plus sur l'utilisation de cette fonctionnalité.

Intégration dans le Jeu
Pour intégrer les quêtes dans votre jeu:

Placez le prefab QuestManager dans votre scène.
Utilisez le QuestManager pour interagir avec les quêtes à partir de vos scripts.