using UnityEngine;

namespace Egam202
{
    public class MircogameListener : MonoBehaviour
    {    
        public void OnMicrogameStart(float duration, string prompt)
        {
            // Send a message?
            gameObject.SendMessage("MicrogameStart", SendMessageOptions.DontRequireReceiver);
            gameObject.SendMessage("MicrogameStartDuration", duration, SendMessageOptions.DontRequireReceiver);
            gameObject.SendMessage("MicrogameStartPrompt", prompt, SendMessageOptions.DontRequireReceiver);
        }
    }
}