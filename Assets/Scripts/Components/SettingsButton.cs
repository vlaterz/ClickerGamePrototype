using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Components
{
    public class SettingsButton : MonoBehaviour
    {
        private Button _button;
        [SerializeField] private GameObject _settings;
        private Animator _animator;

        void Awake()
        {
            _button = GetComponent<Button>();
            _animator = _settings.GetComponent<Animator>();

            _button.onClick.AddListener(() =>
            {
                StartCoroutine(SetActiveWithAnimation());
            });
        }

        private IEnumerator SetActiveWithAnimation()
        {
            if (!_settings.activeSelf)
            {
                _settings.SetActive(true);
                _animator.SetTrigger("PlayEnter");
            }
            else
            {
                _animator.SetTrigger("PlayExit");
                yield return new WaitUntil(() => _animator.GetCurrentAnimatorStateInfo(0).IsName("StayOnLeft"));
                _settings.SetActive(false);
            }
        }
    }
}
