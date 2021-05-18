using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Managers
{
    [Serializable]
    public class SoundSettings
    {
        [SerializeField] public bool Sound;
        [SerializeField] public bool Music;
    }

    public class SaveManager : MonoBehaviour
    {
        [SerializeField] private Toggle _soundToggleRef;
        [SerializeField] private Toggle _musicToggleRef;

        static readonly BinaryFormatter Formatter = new BinaryFormatter();

        [SerializeField] private static string _SettingsSaveFileName = "SettingsData.binary";

        private SoundSettings _settings = new SoundSettings()
        {
            Music = true,
            Sound = true
        };

        void Start()
        {
            LoadSettings();
        }

        public void SaveSettings()
        {
            var data = JsonUtility.ToJson(_settings);
            var path = Application.persistentDataPath + $"/{_SettingsSaveFileName}";
            var stream = new FileStream(path, FileMode.Create);
            Formatter.Serialize(stream, data);
            stream.Close();
        }

        public void LoadSettings()
        {
            var path = Application.persistentDataPath + $"/{_SettingsSaveFileName}";
            if (!File.Exists(path))
                return;
            
            var stream = new FileStream(path, FileMode.Open);
            var sss = Formatter.Deserialize(stream);
            _settings = JsonUtility.FromJson<SoundSettings>((string)sss);
            stream.Close();
            _soundToggleRef.isOn = _settings.Sound;
            _musicToggleRef.isOn = _settings.Music;
        }

        public void UpdateSettingsMusic(bool isOn)
        {
            _settings.Music = isOn;
            SaveSettings();
        } 

        public void UpdateSettingsSound(bool isOn)
        {
            _settings.Sound = isOn;
            SaveSettings();
        }
    }
}