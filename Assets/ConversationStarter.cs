using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class ConversationStarter : MonoBehaviour
{
    [SerializeField] private NPCConversation myConversation;
    // Start is called before the first frame update

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player")) {
            if (Input.GetKeyDown(KeyCode.F)) { 
                ConversationManager.Instance.StartConversation(myConversation);
            }
        }
    }

    // Update is called once per frame

}
