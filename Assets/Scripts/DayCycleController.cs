using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

public class DayCycleController : MonoBehaviour {

    [Range(0, 24)]
    public float timeOfDay;

    public float orbitSpeed = 1.0f;

    public Light sun;
    public Light moon;
    public Volume skyVolume;
    private PhysicallyBasedSky sky;
    public AnimationCurve starsCurve;

    private bool isNight;

    void Start() {
        skyVolume.profile.TryGet(out sky);
    }

    void Update() {
        timeOfDay += Time.deltaTime * orbitSpeed / 5;
        if (timeOfDay > 24) {
            timeOfDay = 0;
        }
        UpdateTime();
    }

    private void OnValidate() {
        skyVolume.profile.TryGet(out sky);
        UpdateTime();
    }

    private void UpdateTime() {
        float alpha = (timeOfDay / 24.0f);
        float sunRotation = Mathf.Lerp(-90, 270, alpha);
        float moonRotation = sunRotation - 180;

        sun.transform.rotation = Quaternion.Euler(sunRotation, -150, 0);
        moon.transform.rotation = Quaternion.Euler(moonRotation, -150, 0);

        sky.spaceEmissionMultiplier.value = starsCurve.Evaluate(alpha) * 1.1f;

        CheckNightDayTransition();
    }

    private void CheckNightDayTransition() {
        if (isNight) {
            if(moon.transform.root.eulerAngles.x > 180) {
                StartDay();
            }
        } else {
            if (sun.transform.root.eulerAngles.x > 180) {
                StartNight();
            }
        }
    }

    private void StartDay() {
        isNight = false;
        sun.shadows = LightShadows.Soft;
        moon.shadows = LightShadows.None;
    }

    private void StartNight() {
        isNight = true;
        sun.shadows = LightShadows.None;
        moon.shadows = LightShadows.Soft;
    }
}
