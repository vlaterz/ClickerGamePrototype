using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Views
{
    public class BonusView : MonoBehaviour
    {
        private static BonusView _instance;
        public static BonusView Instance => _instance;
        void Awake() => _instance = this;

        [SerializeField] private Image _red;
        [SerializeField] private Image _yellow;
        [SerializeField] private Image _blue;

        public void SetRed(bool isActive) => _red.enabled = isActive;
        public void SetYellow(bool isActive) => _yellow.enabled = isActive;
        public void SetBlue(bool isActive) => _blue.enabled = isActive;
    }
}
