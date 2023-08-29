using Tweens.Core;
using UnityEngine;

namespace Tweens {
  public sealed class LightRangeTween : Tween<Light, float> {
    internal sealed override float Current(Light component) {
      return component.range;
    }

    internal sealed override float Lerp(float from, float to, float time) {
      return Mathf.LerpUnclamped(from, to, time);
    }

    internal sealed override void Apply(Light component, float value) {
      component.range = value;
    }
  }
}