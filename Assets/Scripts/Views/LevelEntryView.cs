using System;
using Assets.Scripts.Controllers;
using Assets.Scripts.ScriptableObjects;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Views
{
    public class LevelEntryView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _nameTextp;
        [SerializeField] private Image _backgroundImage;
        [SerializeField] private DifficultyStarsView _difficultyStarsView;

        private LevelData _entryLevelData;
        private Button _button;

        void Awake()
        {
            _button = GetComponent<Button>();
        }

        public void UpdateEntryData(LevelData data)
        {
            _entryLevelData = data;
            _nameTextp.SetText(data.LevelName);
            _backgroundImage.sprite = data.Background;
            _difficultyStarsView.SetDifficulty(data.Difficulty);
        }

        public void SetLevelEntryButton(GameObject scrollrectRef, GameObject levelInfoPanelRef)
        {
            if(_button == null) throw new Exception("Button is null");

            _button.onClick.AddListener(() =>
            {
                scrollrectRef.SetActive(false);
                levelInfoPanelRef.SetActive(true);
                UiController.Instance.ActivateLevelInfoWithLevelData(_entryLevelData);
            });
        }
    }
}
