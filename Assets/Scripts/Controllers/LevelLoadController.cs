using Assets.Scripts.ScriptableObjects;
using UnityEngine;

namespace Assets.Scripts
{
    [RequireComponent(typeof(LevelLoaderView))]
    public class LevelLoadController : MonoBehaviour
    {
        private static LevelLoadController _instance;
        public static LevelLoadController Instance => _instance;
         
        private LevelData _model;
        private LevelLoaderView _view;

        public int PointsRequired => _model.NumberOfTaps;

        void Awake()
        {
            _instance = this;
            _view = GetComponent<LevelLoaderView>();
        }

        public void Start()
        {
            _model = GameLoader.Instance.SelectedLevel;
            _view.LoadLevelIntoScene(_model);
        }
    }
}
