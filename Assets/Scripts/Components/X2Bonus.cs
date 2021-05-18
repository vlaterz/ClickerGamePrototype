using Assets.Scripts.Interfaces;
using Assets.Scripts.Managers;
using UnityEngine;

namespace Assets.Scripts.Components
{
    public class X2Bonus : MonoBehaviour, IClickable
    {
        public void Interact()
        {
            Debug.Log("x2 click");
            BonusManager.Instance.StartX2Bonus();
            gameObject.SetActive(false);
        }
    }
}
