using UnityEngine;

namespace Assets.Scripts.Views
{
    public class LeaderboardView : MonoBehaviour
    {
        private Canvas _leaderBoardCanvas;

        void Awake()
        {
            _leaderBoardCanvas = GetComponent<Canvas>();
        }

        public void ActivateView()
        {
            _leaderBoardCanvas.enabled = true;
        }
    }
}
