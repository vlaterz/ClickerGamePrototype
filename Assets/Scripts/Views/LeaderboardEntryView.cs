using TMPro;
using UnityEngine;

namespace Assets.Scripts.Views
{
    public class LeaderboardEntryView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _playerName;
        [SerializeField] private TextMeshProUGUI _score;

        public void SetEntry(string name, string score)
        {
            _playerName.SetText(name);
            _score.SetText(score);
        }
    }
}
