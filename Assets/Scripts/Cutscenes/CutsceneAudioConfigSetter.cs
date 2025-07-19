using UnityEngine;

public class CutsceneAudioConfigSetter : MonoBehaviour
{
				DialogueClip dialogueControlClip = clip.asset as DialogueClip;
			dialogueControlClip.PauseTimelineEvent = PauseTimelineEvent;
			dialogueControlClip.PlayDialogueEvent = PlayDialogueEvent;
	/*[SerializeField] private AudioConfigurationSO _audioConfig = default;
	[SerializeField] private VoidEventChannelSO onCutsceneStart = default;

	private void OnEnable()
	{
		onCutsceneStart.OnEventRaised += SetVolume;
	}

	private void OnDestroy()
	{
		onCutsceneStart.OnEventRaised -= SetVolume;
	}

	private void SetVolume()
	{
		GetComponent<AudioSource>().volume = _audioConfig.Volume;
	}*/
}
