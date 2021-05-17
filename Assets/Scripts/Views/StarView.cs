using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Views
{
    public class StarView : MonoBehaviour
    {
        [SerializeField] private Image _activeImage;

        public void SetStarActive(bool isActive)
        {
            _activeImage.enabled = isActive;
        }
    }
}
