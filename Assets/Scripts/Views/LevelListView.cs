using System.Collections.Generic;
using Assets.Scripts.ScriptableObjects;
using UnityEngine;

namespace Assets.Scripts.Views
{
    public class LevelListView : MonoBehaviour
    {
        public GameObject LevelEntryRef;

        [SerializeField] private GameObject _scrollRectRef;
        [SerializeField] private GameObject _levelInfoPanelRef;

        public void AddListEntries(List<LevelData> data)
        {
            foreach (LevelData levelData in data)
                AddLevelEntry(levelData);
        }

        public void AddLevelEntry(LevelData data)
        {
            var levelEntry = Instantiate(LevelEntryRef, transform).GetComponent<LevelEntryView>();
            levelEntry.UpdateEntryData(data);
            levelEntry.SetLevelEntryButton(_scrollRectRef, _levelInfoPanelRef);
        }
    }
}
