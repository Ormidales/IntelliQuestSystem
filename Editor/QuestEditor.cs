using UnityEngine;
using UnityEditor;

public class QuestEditor : EditorWindow
{
    private Quest selectedQuest;
    private Vector2 scrollPosition;

    [MenuItem("IntelliQuest/Quest Editor")]
    public static void ShowWindow()
    {
        GetWindow<QuestEditor>("Quest Editor");
    }

    private void OnGUI()
    {
        EditorGUILayout.BeginVertical();
        scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition);

        // Liste des quêtes
        EditorGUILayout.LabelField("Quests", EditorStyles.boldLabel);
        foreach (Quest quest in QuestManager.Instance.quests)
        {
            if (GUILayout.Button(quest.questName))
            {
                selectedQuest = quest;
            }
        }

        // Editeur de quête sélectionnée
        if (selectedQuest != null)
        {
            EditorGUILayout.LabelField("Edit Quest", EditorStyles.boldLabel);
            selectedQuest.questName = EditorGUILayout.TextField("Quest Name", selectedQuest.questName);
            selectedQuest.description = EditorGUILayout.TextArea(selectedQuest.description, GUILayout.Height(100));
            selectedQuest.requiredProgress = EditorGUILayout.IntField("Required Progress", selectedQuest.requiredProgress);
            
            if (GUILayout.Button("Save Quest"))
            {
                // Logic for saving the quest
            }

            if (GUILayout.Button("Delete Quest"))
            {
                // Logic for deleting the quest
            }
        }

        EditorGUILayout.EndScrollView();
        EditorGUILayout.EndVertical();
    }
}
