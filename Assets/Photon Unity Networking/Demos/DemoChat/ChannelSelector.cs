using ExitGames.Client.Photon.Chat;
using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ChannelSelector : Photon.MonoBehaviour, IPointerClickHandler
{
    public string Channel;

    public void SetChannel(string channel)
    {
        this.Channel = channel;
        Text t = GetComponentInChildren<Text>();
        t.text = this.Channel;        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        ChatGui handler = FindObjectOfType<ChatGui>();
        handler.ShowChannel(this.Channel);
    }
}