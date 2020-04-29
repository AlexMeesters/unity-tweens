using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens.TweenDrivers {
  [AddComponentMenu ("")]
  public class LocalEulerAnglesXTweenDriver : TweenDriver<float> {
    private Quaternion quaternionValueFrom;
    private Quaternion quaternionValueTo;

    public override bool OnInitialize () {
      return true;
    }

    public override float OnGetFrom () {
      return this.transform.localEulerAngles.x;
    }

    public override void OnUpdate (float easedTime) {
      this.quaternionValueFrom = Quaternion.Euler (this.valueFrom, this.transform.localEulerAngles.y, this.transform.localEulerAngles.z);
      this.quaternionValueTo = Quaternion.Euler (this.valueTo, this.transform.localEulerAngles.y, this.transform.localEulerAngles.z);
      this.transform.localRotation = Quaternion.Lerp (this.quaternionValueFrom, this.quaternionValueTo, easedTime);
    }
  }
}