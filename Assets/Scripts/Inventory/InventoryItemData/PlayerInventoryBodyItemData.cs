using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Inventory
{
    [CreateAssetMenu(menuName = "Topdown Shooter/Inventory/Player Inventory Body Item Data")]
    public class PlayerInventoryBodyItemData : AbstractPlayerInventoryItemData<PlayerInventoryBodyItemMono>
    {
        public override void Initialize(PlayerInventoryController targetPlayerInventory)
        {
            var instantiated = InstantiateAndInitializePrefab(targetPlayerInventory.Parent);
            Debug.Log("THIS CLASS IS PLAYER NVETORY BODY ITEM DATA");
        }
    }
}
