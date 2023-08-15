[System.Serializable]
public class Reward
{
    public enum RewardType { Experience, Item, Money, Custom }
    public RewardType type;
    public int amount;
    public string itemName; // Utilisé si le type est 'Item'

    // Vous pouvez ajouter un constructeur pour faciliter la création de récompenses
    public Reward(RewardType type, int amount, string itemName = "")
    {
        this.type = type;
        this.amount = amount;
        this.itemName = itemName;
    }

    // Appliquer la récompense à un personnage joueur ou autre cible
    public void ApplyReward(PlayerCharacter player)
    {
        switch (type)
        {
            case RewardType.Experience:
                player.GainExperience(amount);
                break;
            case RewardType.Item:
                player.GiveItem(itemName, amount);
                break;
            case RewardType.Money:
                player.GiveMoney(amount);
                break;
            case RewardType.Custom:
                // Vous pouvez gérer des récompenses personnalisées ici
                ApplyCustomReward(player);
                break;
        }
    }

    // Une méthode pour gérer des récompenses personnalisées
    private void ApplyCustomReward(PlayerCharacter player)
    {
        // La logique personnalisée pour appliquer la récompense
        // Cela pourrait inclure l'appel de méthodes spécifiques sur le joueur,
        // déclencher des événements, etc.
    }
}