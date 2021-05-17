using Assets.Scripts.ScriptableObjects;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts.Views
{
    public class LevelInfoView : MonoBehaviour
    {
        [SerializeField] private Image _backgroundImage;
        private NamingAndDifficultyView _namingAndDiffView;
        private LeaderboardListView _leadersListView;
        private Button _confirmButton;
        void Awake()
        {
            _namingAndDiffView = GetComponentInChildren<NamingAndDifficultyView>();
            _leadersListView = GetComponentInChildren<LeaderboardListView>();
            _confirmButton = GetComponentInChildren<Button>();
        }

        public void UpdateView(LevelData data)
        {
            _backgroundImage.sprite = data.Background;
            _namingAndDiffView.UpdateView(data.LevelName, data.Difficulty);
            _leadersListView.BuildLeaderboard(data.Leaders);
            _confirmButton.onClick.AddListener(() =>
            {
                GameLoader.Instance.SelectedLevel = data;
                SceneManager.LoadScene("ClickerScene");
            });
        }
    }
}
