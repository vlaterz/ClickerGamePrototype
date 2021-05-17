using Assets.Scripts.Interfaces;
using Assets.Scripts.Managers;
using UnityEngine;

namespace Assets.Scripts.Components
{
    public class MainClickedObject : MonoBehaviour, IClickable
    {
        public static bool IsFrozen = false;
        private static MainClickedObject _instance;
        public static MainClickedObject Instance => _instance;
        void Awake()
        {
            _instance = this;
        }

        public void Interact()
        {
            if(!IsFrozen) ItemPlacementManager.Instance.PlaceObjectRandomly(transform);
            PlayerManager.Instance.AddPointsForAction();
        }
    }
}
