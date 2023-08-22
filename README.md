# IntelliQuestSystem
## Introduction
IntelliQuestSystem est un plugin Unity robuste et flexible conçu pour permettre aux développeurs de créer des missions et des quêtes complexes et engageantes. Avec une interface utilisateur intuitive et un puissant backend programmable, IntelliQuest offre un équilibre parfait entre facilité d'utilisation et contrôle pour les développeurs de tous niveaux.

## Caractéristiques
- Création Facile de Quêtes : Créez des quêtes rapidement grâce à notre éditeur graphique.
- Quêtes Dynamiques : Générez des quêtes en temps réel en fonction du comportement du joueur.
- Objectifs Multiples : Définissez des objectifs multiples et des dépendances entre les quêtes.
- Récompenses Personnalisables : Attribuez des récompenses uniques pour chaque quête.

## Installation
1. Téléchargez le Package : Téléchargez le fichier .unitypackage depuis les releases de ce dépôt GitHub.
2. Importez dans Unity : Ouvrez votre projet Unity et importez le package via Assets > Import Package > Custom Package.

## Utilisation
### Ajout d'une Quête
1. Ouvrez le panneau IntelliQuestSystem via Window > IntelliQuestSystem Editor.
2. Cliquez sur New Quest et remplissez les détails.
3. Ajoutez des objectifs et des récompenses selon vos besoins.
4. Sauvegardez la quête et utilisez-la dans votre jeu.

### API Programmable
Vous pouvez également interagir avec les quêtes via l'API:

```csharp
QuestManager questManager = FindObjectOfType<QuestManager>();
questManager.AddQuest(new Quest("Trouve le trésor caché", "Trouve le trésor caché au fond de la cave mystérieuse", 100));
```

Voir `API_REFERENCE.md` pour la documentation complète de l'API.
