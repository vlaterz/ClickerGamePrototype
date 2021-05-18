using Assets.Scripts.Interfaces;
using Assets.Scripts.Managers;
using UnityEngine;

namespace Assets.Scripts.Components
{
    public class FreezeBonus : MonoBehaviour, IClickable
    {
        public void Interact()
        {
            Debug.Log("freeze click");
            BonusManager.Instance.StartFreezeBonus();
            gameObject.SetActive(false);
        }
    }
}