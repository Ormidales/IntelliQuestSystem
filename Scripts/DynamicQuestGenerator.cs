using UnityEngine;
using System.Collections.Generic;

public class DynamicQuestGenerator : MonoBehaviour
{
    private QuestManager questManager;

    // Conditions et paramètres pour la génération de quêtes
    public List<string> potentialObjectives;
    public List<string> potentialRewards;

    private void Start()
    {
        questManager = GetComponent<QuestManager>();
    }

    // Générer une quête en fonction de certains critères
    public Quest GenerateQuest()
    {
        // Choisissez un objectif et une récompense aléatoirement
        string objective = potentialObjectives[Random.Range(0, potentialObjectives.Count)];
        string reward = potentialRewards[Random.Range(0, potentialRewards.Count)];

        // Créez la quête
        Quest quest = new Quest
        {
            questName = "Dynamic Quest",
            description = "Complete the following objective: " + objective,
            requiredProgress = 1 // Cela pourrait être adapté en fonction de l'objectif
        };

        // Vous pourriez ajouter des logiques supplémentaires ici pour personnaliser la quête en fonction des actions du joueur, de l'état du monde, etc.

        // Ajoutez la quête au QuestManager
        questManager.AddQuest(quest);

        return quest;
    }
}
