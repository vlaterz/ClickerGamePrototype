using System.Collections.Generic;
using Assets.Scripts.Handlers;
using UnityEngine;

namespace Assets.Scripts.Managers
{
    public class BonusManager: MonoBehaviour
    {
        private static BonusManager _instance;
        public static BonusManager Instance => _instance;

        [SerializeField] private List<GameObject> _bonusesRefs;

        [SerializeField] private float _bonusSpawnTimer = 3f;
        [SerializeField][Range(0,100)] private float _bonusSpawnChance = 50f;

        [SerializeField] private X2BonusHandler _x2Handler;
        [SerializeField] private FreezeBonusHandler _freezeHandler;
        [SerializeField] private ResizeBonusHandler _resizeHandler;

        private float _currentTimer = 0f;

        public void StartX2Bonus() => StartCoroutine(_x2Handler.X2Bonus());

        public void StartFreezeBonus() => StartCoroutine(_freezeHandler.FreezeBonus());

        public void StartResizeBonus() => StartCoroutine(_resizeHandler.ResizeBonus());

        void Awake() =>_instance = this;
        
        void Update()
        {
            if (_currentTimer >= _bonusSpawnTimer)
            {
                _currentTimer = 0;
                RollForPlaceRandomBonus();
            }
            _currentTimer += Time.deltaTime;
        }

        public void RollForPlaceRandomBonus()
        {
            if (Random.Range(0, 100) >= _bonusSpawnChance) return;

            Transform bonus = _bonusesRefs[Random.Range(0, _bonusesRefs.Count)].transform;

            if (bonus.gameObject.activeSelf) return;

            ItemPlacementManager.Instance.PlaceObjectRandomly(bonus.transform);
            bonus.gameObject.SetActive(true);
        }
    }
}
