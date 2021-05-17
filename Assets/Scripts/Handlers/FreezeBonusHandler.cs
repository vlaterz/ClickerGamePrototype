using System;
using System.Collections;
using Assets.Scripts.Components;
using Assets.Scripts.Views;
using UnityEngine;

namespace Assets.Scripts.Handlers
{
    [Serializable]
    public class FreezeBonusHandler
    {
        public float _freezeBonusTime = 5f;

        public IEnumerator FreezeBonus()
        {
            BonusView.Instance.SetBlue(true);
            MainClickedObject.IsFrozen = true;
            yield return new WaitForSeconds(_freezeBonusTime);
            MainClickedObject.IsFrozen = false;
            BonusView.Instance.SetBlue(false);
        }
    }
}
