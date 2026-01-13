using UnityEngine;
using UnityEngine.UI;

public class VCAControl : MonoBehaviour
{
    private FMOD.Studio.VCA vca;
    private Slider slider;

    [Header("Ustawienia FMOD")]
    [SerializeField] private string vcaPath;
    [SerializeField] private string saveKey;

    [Header("Poziom G³oœnoœci")]
    [SerializeField] private float vcaVolume;
    void Start()
    {
        slider = GetComponent<Slider>();
        vca = FMODUnity.RuntimeManager.GetVCA(vcaPath);

        float savedVolume= PlayerPrefs.GetFloat(saveKey, defaultValue:1);

        vca.getVolume(out vcaVolume);
        slider.value = savedVolume;
    }

     public void SetVolume(float volume)
    {
        vca.setVolume(volume);

        PlayerPrefs.SetFloat(saveKey, volume);
    }
}
