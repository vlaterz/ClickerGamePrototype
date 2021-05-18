using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Components
{
    public class MainMenuButton : MonoBehaviour
    {
        void Start()
        {
            GetComponent<Button>().onClick.AddListener(() => GameLoader.Instance.LoadMainMenu());
        }
    }
}
