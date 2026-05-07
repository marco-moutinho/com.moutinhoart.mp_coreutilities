using UnityEngine;
// created at 07-Apr-2026
namespace MP_CoreUtilities.Data
{

    [CreateAssetMenu(fileName = "GameplayUtilitiesData", menuName = "[ MP_CoreUtilities]/GameplayUtilitiesData")]
    public class GameplayUtilitiesData : ScriptableObject
    {
        [Header("[ Layers Mask ]")]
        
        [Header("Characters")]
        public LayerMask playerCharacter;
        public LayerMask characterLayer;
        public LayerMask npcLayer;

        [Header("Objects")]
        public LayerMask itemsLayer;
        public LayerMask projectileLayer;

        [Header("World")]
        public LayerMask groundLayer;
        public LayerMask buildingLayer;

        [Header("Others")]
        public LayerMask vehiclesLayer;
    }
}