using UnityEngine;
using FMODUnity;

public class FireplaseInteract : MonoBehaviour, IInteractable
{
    [Header("Ognisko")]
    [SerializeField] GameObject ognisko;

    [Header("D¿wiêki")]
    [SerializeField] private EventReference fireplaseStart;
    [SerializeField] private EventReference fireplaseStop;

    [Header("Stan")]
    [SerializeField] private bool isActive = true;


    public void Interact()
    {
        isActive = !isActive;

        if (ognisko != null)
        {
            ognisko.SetActive(isActive);
            PlayInteractSound();
        }
    }

    private void PlayInteractSound()
    {
        if (isActive)
        {
            RuntimeManager.PlayOneShot(fireplaseStart);
        }
        else
        {
            RuntimeManager.PlayOneShot(fireplaseStop);
        }
    }

}
        
    
