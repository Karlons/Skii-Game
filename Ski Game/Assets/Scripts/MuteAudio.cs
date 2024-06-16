using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteAudio : MonoBehaviour
{
    private bool isMuted = false; // Flag to track if audio is muted

    // Method to toggle mute state
    public void ToggleMute()
    {
        isMuted = !isMuted; // Toggle the mute flag

        // Set the AudioListener volume based on the mute flag
        AudioListener.volume = isMuted ? 0f : 1f;

        // Optionally, you can update the button's text or image to reflect the current state
        // Example: GetComponentInChildren<Text>().text = isMuted ? "Unmute" : "Mute";
    }
}
