using Assets.Scripts.Components;
using Assets.Scripts.Controllers;
using Assets.Scripts.Views;
using UnityEngine;

namespace Assets.Scripts.Managers
{
    public class PlayerManager : MonoBehaviour
    {
        private static PlayerManager _instance;
        public static PlayerManager Instance => _instance;

        [SerializeField] private LevelProgressView _levelProgressViewRef;
        [SerializeField] private LeaderboardView _leaderboardViewRef;

        public int CurrentPoints = 0;
        public int PointsForAction = 1;

        void Awake() => _instance = this;

        public void AddPointsForAction()
        {
            CurrentPoints += PointsForAction;
            if (CurrentPoints >= LevelLoadController.Instance.PointsRequired)
            {
                MainClickedObject.Instance.gameObject.SetActive(false);
                _leaderboardViewRef.ActivateView();
            }
            _levelProgressViewRef.UpdateView(CurrentPoints, LevelLoadController.Instance.PointsRequired);
        }
    }
}
