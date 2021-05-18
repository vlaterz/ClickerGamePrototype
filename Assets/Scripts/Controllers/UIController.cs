using Assets.Scripts.ScriptableObjects;
using Assets.Scripts.Views;
using UnityEngine;

namespace Assets.Scripts.Controllers
{
    public class UiController : MonoBehaviour
    {
        private static UiController _instance;
        public static UiController Instance => _instance;
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
