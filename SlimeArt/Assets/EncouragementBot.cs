using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncouragementBot : MonoBehaviour
{
    private HashSet<string> unusedGenericSayings = new HashSet<string>();
    private List<string> usedSayings = new List<string>();
    private Dictionary<string, List<string>> unusedUISayings
        = new Dictionary<string, List<string>>();
    private HashSet<string> unclickedUIComponents = new HashSet<string>();
    private string[] uiNames = { "Play", "Pause", "ClearCanvasButton", "ParticleBrushButton", "DepositBrushButton", "BrushSizeSlider",
    "BrushDensitySlider", "MoveDistanceSlider", "ScaleSlider", "DepositStrengthSlider", "AgentDepositStrengthSlider", "Picker", 
        "SenseDistanceSlider", "TraceDecaySlider", "DrawMouseDown", "DrawMouseUp"};
   

    public EncouragementBot()
    {
        //prepUnusedUISayings();
        Debug.Log("ehllo");
        prepUnusedUISayings();
    }

    private void prepUnusedUISayings()
    {
        for (int i = 0; i < uiNames.Length; i++)
        {
            unusedUISayings.Add(uiNames[i], new List<string>());
        }

        Dictionary<string, List<string>>.KeyCollection keyColl =
    unusedUISayings.Keys;

        // The elements of the KeyCollection are strongly typed
        // with the type that was specified for dictionary keys.
       
        foreach (string s in keyColl)
        {
           Debug.Log(s);
        }
    }

    /*private void prepUnusedUISayings()
    {
        // unused ui sayings prep
        for (int i = 0; i < uiNames.Length; i++)
        {
            unusedUISayings.Add(uiNames[i], new List<string>());
        }
        Debug.Log(prepUnusedUISayings.Keys);
        /*unusedUISayings.Add("ViewDropdown", new List<string>());
        //userClickData["DepositBrushButton"].Add(new UIClickData(Time.time, "deposit brush button click", 1.0f));
        //userClickData["DepositBrushButton"].Add(new UIClickData(Time.time, "deposit brush button click", 1.0f));

        unusedUISayings.Add("Play", new List<string>());
        unusedUISayings.Add("Pause", new List<string>());
        unusedUISayings.Add("ClearCanvasButton", new List<string>());
        unusedUISayings.Add("ParticleBrushButton", new List<string>());
        unusedUISayings.Add("DepositBrushButton", new List<string>());
        unusedUISayings.Add("BrushSizeSlider", new List<string>());
        unusedUISayings.Add("BrushDensitySlider", new List<string>());
        unusedUISayings.Add("MoveDistanceSlider", new List<string>());
        unusedUISayings.Add("ScaleSlider", new List<string>());
        unusedUISayings.Add("DepositStrengthSlider", new List<string>());
        unusedUISayings.Add("AgentDepositStrengthSlider", new List<string>());
        unusedUISayings.Add("Picker", new List<string>());
        unusedUISayings.Add("SenseDistanceSlider", new List<string>());
        unusedUISayings.Add("TraceDecaySlider", new List<string>());
        unusedUISayings.Add("DrawMouseDown", new List<string>());
        unusedUISayings.Add("DrawMouseUp", new List<string>());*/
  //  }*/

    /*
     * 
     *  userClickData.Add("ViewDropdown", new List<UIClickData>());
        userClickData.Add("Play", new List<UIClickData>());
        userClickData.Add("Pause", new List<UIClickData>());
        userClickData.Add("ClearCanvasButton", new List<UIClickData>());
        userClickData.Add("ParticleBrushButton", new List<UIClickData>());
        userClickData.Add("DepositBrushButton", new List<UIClickData>());
        userClickData.Add("BrushSizeSlider", new List<UIClickData>());
        userClickData.Add("BrushDensitySlider", new List<UIClickData>());
        userClickData.Add("MoveDistanceSlider", new List<UIClickData>());
        userClickData.Add("ScaleSlider", new List<UIClickData>());
        userClickData.Add("DepositStrengthSlider", new List<UIClickData>());
        userClickData.Add("AgentDepositStrengthSlider", new List<UIClickData>());
        userClickData.Add("Picker", new List<UIClickData>());
        userClickData.Add("SenseDistanceSlider", new List<UIClickData>());
        userClickData.Add("TraceDecaySlider", new List<UIClickData>());
        userClickData.Add("DrawMouseDown", new List<UIClickData>());
        userClickData.Add("DrawMouseUp", new List<UIClickData>());
     * */
}
