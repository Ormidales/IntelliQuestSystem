// Classe pour gérer l'ensemble des quêtes
public class QuestManager : MonoBehaviour
{
    public List<Quest> quests = new List<Quest>();

    // Ajouter une nouvelle quête
    public void AddQuest(Quest quest)
    {
        quests.Add(quest);
    }

    // Trouver et retourner une quête par son nom
    public Quest GetQuestByName(string name)
    {
        return quests.Find(q => q.questName == name);
    }

    // Mettre à jour la progression d'une quête par son nom
    public void UpdateQuestProgress(string questName, int progressAmount)
    {
        Quest quest = GetQuestByName(questName);
        if (quest != null && !quest.isCompleted)
        {
            quest.UpdateProgress(progressAmount);
        }
    }

    // Vous pouvez ajouter des méthodes supplémentaires pour gérer des choses comme sauver/charger les quêtes, etc.
}