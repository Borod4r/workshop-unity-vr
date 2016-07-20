using UnityEngine;

namespace Borodar.WorkshopVR
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField]
        private float _speed = 2f;

        private bool _isWalking;
        private CharacterController _controller;

        //---------------------------------------------------------------------
        // Messages
        //---------------------------------------------------------------------

        public void Awake()
        {
            _controller = GetComponent<CharacterController>();
        }

        public void Update()
        {
            if (GvrViewer.Instance.Triggered) _isWalking = !_isWalking;

            var headDirection = GvrViewer.Controller.Head.transform.forward;
            var motion = (_isWalking) ? new Vector3(headDirection.x, 0, headDirection.z) * _speed * Time.deltaTime : Vector3.zero;

            _controller.Move(Physics.gravity + motion);
        }
    }
}
