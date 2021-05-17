using Assets.Scripts.ScriptableObjects;
using Assets.Scripts.Views;
using UnityEngine;

namespace Assets.Scripts.Controllers
{
    public class UIController : MonoBehaviour
    {
        private static UIController _instance;
        public static UIController Instance => _instance;
        void Awake() => _instance = this;

        public LevelListView LevelListView;
        public LevelInfoView LevelInfoView;

        void Start()
        {
            LevelListView.AddListEntries(LevelList.Instance.Levels); 
        }

        public void ActivateLevelInfoWithLevelData(LevelData data)
        {
            LevelInfoView.UpdateView(data);
        }
    }
}
