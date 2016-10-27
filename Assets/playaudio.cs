using UnityEngine;
using System.Collections;

public class playaudio : MonoBehaviour {
	private GvrAudioSoundfield soundfield;
	private bool started = false;
	// Use this for initialization
	void Start () {
		soundfield = GetComponent<GvrAudioSoundfield> ();
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if (!started) {
			soundfield.Play ();
			started = true;
		}
	}
}
