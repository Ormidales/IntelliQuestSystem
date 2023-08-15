Référence API IntelliQuest System
Table des Matières
Introduction
Classes Principales
Quest
Objective
Reward
QuestManager
QuestDatabase
Introduction
Cette référence API documente toutes les classes et méthodes publiques de l'IntelliQuest System. Elle est destinée aux développeurs qui souhaitent interagir avec le système de quêtes via la programmation.

Classes Principales
Quest
Représente une quête dans le jeu.

Constructeur: Quest(string name, string description, int experienceReward)
Propriétés:
Name : Le nom de la quête.
Description : La description de la quête.
Objectives : La liste des objectifs de la quête.
Rewards : La liste des récompenses de la quête.
Méthodes:
AddObjective(Objective objective) : Ajoute un objectif à la quête.
RemoveObjective(Objective objective) : Supprime un objectif de la quête.
Objective
Représente un objectif de quête.

Constructeur: Objective(string description, int requiredAmount)
Propriétés:
Description : La description de l'objectif.
RequiredAmount : La quantité requise pour compléter l'objectif.
CurrentAmount : La quantité actuelle.
Reward
Représente une récompense de quête.

Constructeur: Reward(string type, int amount)
Propriétés:
Type : Le type de récompense (ex. "Gold", "Experience").
Amount : La quantité de récompense.
QuestManager
Gère les quêtes pour un joueur.

Méthodes:
AddQuest(Quest quest) : Ajoute une quête à la liste du joueur.
RemoveQuest(Quest quest) : Supprime une quête de la liste du joueur.
GetQuests() : Retourne la liste des quêtes actuelles du joueur.
QuestDatabase
Gère le stockage et le chargement des quêtes.

Méthodes:
SaveQuests() : Sauvegarde toutes les quêtes.
LoadQuests() : Charge toutes les quêtes depuis le stockage.