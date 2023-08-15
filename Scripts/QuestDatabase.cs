using UnityEngine;
using System.Collections.Generic;
using System.IO;

public class QuestDatabase : MonoBehaviour
{
    public List<Quest> quests;
    private string path;

    private void Start()
    {
        path = Path.Combine(Application.persistentDataPath, "quests.json");
        LoadQuests();
    }

    public void AddQuest(Quest quest)
    {
        quests.Add(quest);
        SaveQuests();
    }

    public void RemoveQuest(Quest quest)
    {
        quests.Remove(quest);
        SaveQuests();
    }

    public void SaveQuests()
    {
        string json = JsonUtility.ToJson(new QuestContainer(quests));
        File.WriteAllText(path, json);
    }

    public void LoadQuests()
    {
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            QuestContainer questContainer = JsonUtility.FromJson<QuestContainer>(json);
            quests = questContainer.quests;
        }
        else
        {
            quests = new List<Quest>();
        }
    }

    // Classe auxiliaire pour aider à la sérialisation des quêtes
    [System.Serializable]
    private class QuestContainer
    {
        public List<Quest> quests;

        public QuestContainer(List<Quest> quests)
        {
            this.quests = quests;
        }
    }
}