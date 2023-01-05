using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _sliderText;
    private Slider slider;
    private GlobalVolume GV;
    
    private void Start() 
    {
        _sliderText = GetComponentInChildren<TextMeshProUGUI>();
        slider = GetComponent<Slider>();
        slider.onValueChanged.AddListener(OnValueChanged);
        GV = GameObject.FindGameObjectWithTag("GlobalVolume").GetComponent<GlobalVolume>();
    }

    void OnValueChanged(float value)
    {
        GV.setGlobalVolume(value);
        _sliderText.text = Mathf.RoundToInt(value * 100) + "%";
    }
}
