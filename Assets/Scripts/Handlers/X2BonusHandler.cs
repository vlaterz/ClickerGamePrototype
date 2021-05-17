using System;
using System.Collections;
using Assets.Scripts.Managers;
using Assets.Scripts.Views;
using UnityEngine;

namespace Assets.Scripts.Handlers
{
    [Serializable]
    public class X2BonusHandler
    {
        public float X2BonusTime = 5f;

        public IEnumerator X2Bonus()
        {
            BonusView.Instance.SetRed(true);
            PlayerManager.Instance.PointsForAction *= 2;
            yield return new WaitForSeconds(X2BonusTime);
            PlayerManager.Instance.PointsForAction /= 2;
            BonusView.Instance.SetRed(false);
        }
    }
}
