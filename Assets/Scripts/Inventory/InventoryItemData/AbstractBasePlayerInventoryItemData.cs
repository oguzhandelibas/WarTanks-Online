using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace TopDownShooter.Inventory
{
    public abstract class AbstractBasePlayerInventoryItemData : ScriptableObject
    {
        private PlayerInventoryController _inventoryController;
        protected CompositeDisposable _compositeDisposible;

        public virtual void Initialize(PlayerInventoryController targetPlayerInventory)
        {
            _inventoryController = targetPlayerInventory;
            _compositeDisposible = new CompositeDisposable();
        }

        public virtual void Destroy()
        {
            //means that we are unsubscribing from all the events we add to this
            _compositeDisposible.Dispose();
            Destroy(this);
        }
    }
}
