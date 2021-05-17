using Assets.Scripts.ScriptableObjects;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class GameLoader : MonoBehaviour
    {
        private static GameLoader _instance;
        public static GameLoader Instance => _instance;

        public LevelData SelectedLevel;

        void Awake()
        {
            if (_instance != null)
                Destroy(gameObject);
            else
            {
                _instance = this;
                DontDestroyOnLoad(this);
            }
        }
        
        public void LoadMainMenu()
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
