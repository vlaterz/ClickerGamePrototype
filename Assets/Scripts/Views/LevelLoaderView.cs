using Assets.Scripts.ScriptableObjects;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class LevelLoaderView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _text;
        [SerializeField] private Image _backgroundImage;
        [SerializeField] private Image _clickedImage;

        public void LoadLevelIntoScene(LevelData data)
        {
            _text.SetText($"0/{data.NumberOfTaps}");
            _backgroundImage.sprite = data.Background;
            _clickedImage.sprite = data.ClickImage;
        }
    }
}
