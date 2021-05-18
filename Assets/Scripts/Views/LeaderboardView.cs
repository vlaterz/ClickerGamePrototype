using UnityEngine;

namespace Assets.Scripts.Views
{
    public class LeaderboardView : MonoBehaviour
    {
        private Canvas _leaderBoardCanvas;
        private LeaderboardListView _leaderboardListView;

        void Awake()
        {
            _leaderBoardCanvas = GetComponent<Canvas>();
            _leaderboardListView = GetComponentInChildren<LeaderboardListView>(includeInactive: true);
        }

        public void ActivateView()
        {
            _leaderBoardCanvas.enabled = true;
            _leaderboardListView.RebuildLeaderboard(GameLoader.Instance.SelectedLevel.Leaders);
        }
    }
}
