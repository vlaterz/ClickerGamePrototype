using TMPro;
using UnityEngine;

namespace Assets.Scripts.Views
{
    public class NamingAndDifficultyView : MonoBehaviour
    {
        private TextMeshProUGUI _namingText;

        void Awake() => _namingText = GetComponentInChildren<TextMeshProUGUI>();

        public void UpdateView(string levelName, int difficulty)
        {
            _namingText.SetText(levelName);
            var difficultyStarsView = GetComponentInChildren<DifficultyStarsView>();
            difficultyStarsView.SetDifficulty(difficulty);
        }
    }
}
