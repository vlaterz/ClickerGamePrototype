using Assets.Scripts.Interfaces;
using Assets.Scripts.Managers;
using UnityEngine;

namespace Assets.Scripts.Components
{
    public class ResizeBonus : MonoBehaviour, IClickable
    {
        public void Interact()
        {
            Debug.Log("Resize click");
            BonusManager.Instance.StartResizeBonus();
            gameObject.SetActive(false);
        }
    }
}