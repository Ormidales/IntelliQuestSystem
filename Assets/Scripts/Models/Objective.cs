[System.Serializable]
public class Objective
{
    public string description; // Description de l'objectif
    public bool isCompleted; // État de l'objectif
    public int requiredAmount; // Quantité requise pour compléter l'objectif (peut être utilisé pour des objectifs de collecte, etc.)
    public int currentAmount; // Progression actuelle vers la complétion

    // Constructeur pour initialiser l'objectif
    public Objective(string description, int requiredAmount)
    {
        this.description = description;
        this.requiredAmount = requiredAmount;
        this.isCompleted = false;
        this.currentAmount = 0;
    }

    // Méthode pour mettre à jour la progression de l'objectif
    public void UpdateProgress(int amount)
    {
        currentAmount += amount;
        if (currentAmount >= requiredAmount)
        {
            CompleteObjective();
        }
    }

    // Marquer l'objectif comme complété
    private void CompleteObjective()
    {
        isCompleted = true;
        // Vous pouvez également ajouter une logique supplémentaire ici pour déclencher des événements, etc.
    }

    // Méthode pour réinitialiser l'objectif
    public void Reset()
    {
        currentAmount = 0;
        isCompleted = false;
    }
}