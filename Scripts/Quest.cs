// Classe représentant une quête individuelle
[System.Serializable]
public class Quest
{
    public string questName;
    public string description;
    public bool isCompleted;
    public int currentProgress;
    public int requiredProgress;

    // Appeler cette méthode pour mettre à jour la progression de la quête
    public void UpdateProgress(int amount)
    {
        currentProgress += amount;
        if (currentProgress >= requiredProgress)
        {
            CompleteQuest();
        }
    }

    // Marquer la quête comme terminée
    private void CompleteQuest()
    {
        isCompleted = true;
        // Vous pouvez également ajouter une logique supplémentaire ici pour gérer les récompenses, etc.
    }
}