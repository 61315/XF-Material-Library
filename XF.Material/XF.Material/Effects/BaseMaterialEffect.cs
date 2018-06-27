﻿using Xamarin.Forms;

namespace XF.Material.Effects
{
    public abstract class BaseMaterialEffect : RoutingEffect
    {
        public VisualElement MaterialElement { get; set; }

        protected BaseMaterialEffect(string effectId) : base(effectId) { }

        public virtual void ApplyEffect() { }
    }
}
