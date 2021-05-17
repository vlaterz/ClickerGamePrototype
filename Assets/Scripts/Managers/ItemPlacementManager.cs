using System;
using System.IO;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Assets.Scripts
{
    [Serializable]
    public struct Offsets
    {
        public float Left;
        public float Right;
        public float Top;
        public float Bot;
    }
    
    public class ItemPlacementManager : MonoBehaviour
    {
        [SerializeField] private Offsets _percentOffsets;

        private static ItemPlacementManager _instance;
        public static ItemPlacementManager Instance => _instance;

        private Offsets _pixelOffsets;

        private Vector2 RandomPosition() =>
            Camera.main.ScreenToWorldPoint(new Vector2(Random.Range(_pixelOffsets.Left, _pixelOffsets.Right), Random.Range(_pixelOffsets.Bot, _pixelOffsets.Top)));

        void Awake()
        {
            _instance = this;
            if (!OffsetsAreCorrect()) throw new InvalidDataException("Incorrect offsets");
            CalculateSpawnBounds();
        }

        private void CalculateSpawnBounds()
        {
            _pixelOffsets.Left = Screen.width * _percentOffsets.Left / 100;
            _pixelOffsets.Bot = Screen.height * _percentOffsets.Bot / 100;
            _pixelOffsets.Right = Screen.width - (Screen.width * _percentOffsets.Right / 100);
            _pixelOffsets.Top = Screen.height - (Screen.height * _percentOffsets.Top / 100);
        }

        private bool OffsetsAreCorrect()
        {
            return _percentOffsets.Left < 100 - _percentOffsets.Right
            && _percentOffsets.Bot < 100 - _percentOffsets.Top;
        }

        public void PlaceObjectRandomly(Transform transform)
        {
           Vector2 position = RandomPosition();
           transform.position = new Vector3(position.x, position.y, 0);
        }
    }
}
