using Borodar.WorkshopVR.Helpers;
using UnityEngine;
using UnityEngine.UI;

namespace Borodar.WorkshopVR
{
    public class GameManager : Singleton<GameManager>
    {
        [SerializeField]
        private int _crystalsLeft = 3;

        [Space(10)]

        [SerializeField]
        private Sprite _crystalIcon;
        [SerializeField]
        private Sprite _crystalIconDisabled;

        [Space(10)]

        [SerializeField] private Image[] _crystalImages;

        //---------------------------------------------------------------------
        // Public
        //---------------------------------------------------------------------

        public void CollectCrystal()
        {
            if (_crystalsLeft <= 0) return;
            _crystalsLeft--;

            for (var i = 0; i < _crystalImages.Length; i++)
            {
                var image = _crystalImages[i];
                image.sprite = (_crystalImages.Length - i) > _crystalsLeft ? _crystalIcon : _crystalIconDisabled;
            }
        }
    }
}
