using UnityEngine;

public class PlayerAnimationEvents : MonoBehaviour
{
    [SerializeField] private PlayerAudioController audioController;
    [SerializeField] private ParticleSystem walkingeffect;

    public void PlayWalkSound()
    {
        audioController.PlayWalk();
        walkingeffect.Play();
    }
}
