using System;
using System.Collections;
using Assets.Scripts.Components;
using Assets.Scripts.Views;
using UnityEngine;

namespace Assets.Scripts.Handlers
{
    [Serializable]
    public class ResizeBonusHandler
    {
        public float ResizeBonusTime = 5f;
        public float ResizeMultiplier = 2f;

        public IEnumerator ResizeBonus()
        {
            BonusView.Instance.SetYellow(true);
            MainClickedObject.Instance.transform.localScale = new Vector3(ResizeMultiplier, ResizeMultiplier, ResizeMultiplier);
            yield return new WaitForSeconds(ResizeBonusTime);
            MainClickedObject.Instance.transform.localScale = new Vector3(1, 1, 1);
            BonusView.Instance.SetYellow(false);
        }
    }
}
