using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Views
{
    public class LevelProgressView : MonoBehaviour
    {
        private TextMeshProUGUI _text;
        private Image _fillImage;

        void Awake()
        {
            _text = GetComponentInChildren<TextMeshProUGUI>();
            _fillImage = GetComponentInChildren<Image>();
        } 
        
        public void UpdateView(int currentPoints, int requiredPoints)
        {
            _text.SetText($"{currentPoints}/{requiredPoints}");
            _fillImage.fillAmount = (float)currentPoints / requiredPoints;
        } 
    }
}
