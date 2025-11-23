using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class TextChangeInfoMenu : MonoBehaviour
{
    public TMP_Text text;
    
    public void InfoMenuFisherman() 
    {
    	text.text = "The Old Fisherman is a painting by the Hungarian artist Tivadar Csontváry Kosztka (1853–1919). If you mirror the left side, you see a praying old man in a boat on a calm sea. If you mirror the right side, the Devil appears, looking at you, with a stormy scene behind him.";
    }
    
    public void InfoMenuSewing() 
    {
    	text.text = "Girl at Sewing Machine is an oil-on-canvas painting by the American artist Edward Hopper. It portrays a young woman sitting at a sewing machine facing a window on a beautiful sunny day.  It is one of the first of Hopper's many window paintings. Hopper's repeated decision to pose a young woman against her sewing is said to be a commentary on solitude.";
    }
    
    public void InfoMenuSailboats()
    {
    	text.text = "Sailboats is a painting by Henri de Toulouse-Lautrec. The artist, known for his immersion in the colourful and theatrical life of late 19th-century Paris, produced a collection of enticing, elegant, and provocative images that captured the sometimes decadent affairs of the era. In this painting, however, we see a more hidden and unexpected side of his world.";
    }
    
    public void InstructionE()
    {
    	text.text = "Press [E] to Interact";
    }
    
    public void InstructionClick()
    {
    	text.text = "Click to Interact";
    }
}
