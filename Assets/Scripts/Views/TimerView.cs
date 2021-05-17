using TMPro;
using UnityEngine;

namespace Assets.Scripts.Views
{
    public class TimerView : MonoBehaviour
    {
        private TextMeshProUGUI _timer;
        private float _currentTime = 0;
        public static bool isTicking = true;

        void Awake()
        {
            _timer = GetComponentInChildren<TextMeshProUGUI>();
        }
        
        void Update()
        {
            if(isTicking)
                _currentTime += Time.deltaTime;
            _timer.SetText(_currentTime.ToString("#.#"));
        }
    }
}
