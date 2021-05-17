using Assets.Scripts.Views;
using UnityEngine;

namespace Assets.Scripts.Controllers
{
    public class LevelInfoController : MonoBehaviour
    {
        private LevelInfoView _levelInfoView;

        void Awake()
        {
            _levelInfoView = GetComponentInChildren<LevelInfoView>();
        }

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
