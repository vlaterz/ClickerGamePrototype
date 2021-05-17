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
        [SerializeField] public bool sound;
        [SerializeField] public bool music;
    }

    public class SaveManager : MonoBehaviour
    {
        [SerializeField] private Toggle _soundToggleRef;
        [SerializeField] private Toggle _musicToggleRef;

        static readonly BinaryFormatter Formatter = new BinaryFormatter();

        [SerializeField] private static string _SettingsSaveFileName = "SettingsData.binary";

        private SoundSettings Settings = new SoundSettings()
        {
            music = true,
            sound = true
        };

        void Start()
        {
            LoadSettings();
        }

        public void SaveSettings()
        {
            var data = JsonUtility.ToJson(Settings);
            var path = Application.persistentDataPath + $"/{_SettingsSaveFileName}";
            var stream = new FileStream(path, FileMode.Create);
            Formatter.Serialize(stream, data);
            stream.Close();
            Debug.Log($"Settings saved to {path}");
        }

        public void LoadSettings()
        {
            var path = Application.persistentDataPath + $"/{_SettingsSaveFileName}";
            if (!File.Exists(path))
            {
                Debug.Log("SettingsData file does not exist");
                return;
            }
        
            var stream = new FileStream(path, FileMode.Open);
            var sss = Formatter.Deserialize(stream);
            Settings = JsonUtility.FromJson<SoundSettings>((string)sss);
            stream.Close();
            _soundToggleRef.isOn = Settings.sound;
            _musicToggleRef.isOn = Settings.music;
        }

        public void UpdateSettingsMusic(bool isOn)
        {
            Settings.music = isOn;
            SaveSettings();
        } 

        public void UpdateSettingsSound(bool isOn)
        {
            Settings.sound = isOn;
            SaveSettings();
        }
    }
}