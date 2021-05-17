using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Controllers
{
    public class PlayerClickController : MonoBehaviour
    {
        void Update()
        {
            if (!Input.GetMouseButtonDown(0)) return;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);

            if (hit.collider != null)
            {
                IClickable clickTarget = hit.collider.GetComponent<IClickable>();
                if (clickTarget == null) return;
                clickTarget.Interact();
            }
        }
    }
}
