using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VFX;

public class SphereSceneManager : MonoBehaviour
{
    [SerializeField] private Text _textInfo;
    [SerializeField] private Text _textFPS;

    [SerializeField] private VisualEffect _effect;

    private float _frameRate;

    private void Update()
    {
        _frameRate = 1.0f / Time.deltaTime;
    }

    private void FixedUpdate()
    {
        _textInfo.text = $"Number of particles: {_effect.aliveParticleCount}";
        _textFPS.text = $"FPS: {_frameRate.ToString("F0")}";
    }
}
