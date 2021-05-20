using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class EncouragementBot : MonoBehaviour
{
    private List<string> unusedGenericSayings = new List<string>();
    private List<string> usedSayings = new List<string>();
    private Dictionary<string, List<string>> unusedUISayings
        = new Dictionary<string, List<string>>();
    private HashSet<string> unclickedUIComponents = new HashSet<string>();
    private string[] uiNames = { "Play", "Pause", "ClearCanvasButton", "ParticleBrushButton", "DepositBrushButton", "BrushSizeSlider",
    "BrushDensitySlider", "MoveDistanceSlider", "ScaleSlider", "DepositStrengthSlider", "AgentDepositStrengthSlider", "Picker", 
        "SenseDistanceSlider", "TraceDecaySlider", "DrawMouseDown", "DrawMouseUp"};
    private TextMeshProUGUI robotWords; 
    private int lastMessageTimeStamp = 0;
    void Start()
    {
        Debug.Log("ehllo");
        prepUnusedUISayings();
        prepUnusedGenericSayings();
        robotWords = GameObject.Find("RobotWords").GetComponent<TextMeshProUGUI>();
        robotWords.SetText("\n" + getMessage());
        lastMessageTimeStamp = 0;
    }

    public EncouragementBot()
    {
        //prepUnusedUISayings();
       
    } 

     void Update()
    {
        if ((int)Time.time == (lastMessageTimeStamp + Random.Range(5, 15)))
        {
            robotWords.SetText("\n" + getMessage());
            lastMessageTimeStamp = (int)Time.time;
        }
    }

    public void uiClicked(string ui, float value0, float value1, float value2)
    {
        if ((int)Time.time > (lastMessageTimeStamp + 5))
        {
            
            List<string> messages = unusedUISayings[ui];
            if (messages.Count > 0)
            {
                lastMessageTimeStamp = (int)Time.time;
                int index = Random.Range(0, messages.Count);
                robotWords.SetText("\n" + messages[index]);
            }
        }
    }

    private string getMessage()
    {
       // Random random = new Random();
        int index = Random.Range(0, unusedGenericSayings.Count);
        return unusedGenericSayings[index];
    }

    private void prepUnusedGenericSayings()
    {
        unusedGenericSayings.Add("Great job!");
        unusedGenericSayings.Add("Wow!");
        unusedGenericSayings.Add("You're so talented!");
    }

    private void prepUnusedUISayings()
    {
        for (int i = 0; i < uiNames.Length; i++)
        {
            unusedUISayings.Add(uiNames[i], new List<string>());
        }

        Dictionary<string, List<string>>.KeyCollection keyColl =
    unusedUISayings.Keys;
        foreach (string s in keyColl)
        {
           Debug.Log(s);
        }
        /*
        unusedUISayings["Play"].Add("Let's see it!");
        unusedUISayings["Play"].Add("Let's go!");
        unusedUISayings["Play"].Add("Exciting!");
        unusedUISayings["Play"].Add("ahhhhhh");
        unusedUISayings["Pause"].Add("Nice! Pausing is helpful when planning a design.");
        unusedUISayings["Pause"].Add("I can't wait to see what you design.");
        unusedUISayings["ClearCanvasButton"].Add("Time for a blank slate.");
        unusedUISayings["ClearCanvasButton"].Add("Time to start fresh!");
        unusedUISayings["ClearCanvasButton"].Add("Sometimes we just need to start over.");
        unusedUISayings["ClearCanvasButton"].Add("Spring cleaning... or is it spring clearing... ;)");
        unusedUISayings["ParticleBrushButton"].Add("You can modify so many settings of the particles!");
        unusedUISayings["ParticleBrushButton"].Add("I can't wait to see what type of particles you make.");
        unusedUISayings["DepositBrushButton"].Add("You can use the deposit brush to add some stability to your design.");
        unusedUISayings["DepositBrushButton"].Add("Ooh what type of deposit designs will you make?!");
        unusedUISayings["BrushSizeSlider"].Add("Playing with the size of the brush is a cool way to manage the amount of particles on the screen.");
        unusedUISayings["BrushDensitySlider"].Add("A lower brush density has a sparser brush feel.");
        unusedUISayings["BrushDensitySlider"].Add("A higher brush density has a denser feel.");
        unusedUISayings["MoveDistanceSlider"].Add("I love a design with fast and slow moving particles!");
        unusedUISayings["MoveDistanceSlider"].Add("slow and slimey wins the race...");
        unusedUISayings["ScaleSlider"].Add("When particles have a wider field of view they can see more, so they spread out rather than create lines.");
        unusedUISayings["ScaleSlider"].Add("When particles have a more narrow field of view they can see less, so they create lines.");
        unusedUISayings["DepositStrengthSlider"].Add("When deposit is stronger it is more attractive to particles.");
        unusedUISayings["AgentDepositStre thSlider"].Add("When agents emit deposit, they congregate together by following each other.");
        unusedUISayings["AgentDepositStrengthSlider"].Add("When agents don't emit deposit, they wander amelessly unless there is static deposit to find.");
        unusedUISayings["Picker"].Add("I love colors!");
        unusedUISayings["Picker"].Add("I love the colors you chose!");
        unusedUISayings["Picker"].Add("great colors!");
        unusedUISayings["SenseDistanceSlider"].Add("When particles can sense deposit further ahead of them, they can explore farther.");
        unusedUISayings["SenseDistanceSlider"].Add("Particles can be nearsighted or farsighted with the visibility distance setting.");
        unusedUISayings["TraceDecaySlider"].Add("A trace decay of 0 leaves a permanent trace.");
        unusedUISayings["TraceDecaySlider"].Add("A higher trace decay of leaves a shorter trace behind particles.");
        unusedUISayings["DrawMouseDown"].Add("I can't wait to see what you draw!");
        unusedUISayings["DrawMouseDown"].Add("Drawing Time!");
        unusedUISayings["DrawMouseUp"].Add("Cool!");
        unusedUISayings["DrawMouseUp"].Add("Woah!");
        unusedUISayings["DrawMouseUp"].Add("Stunning!");
        unusedUISayings["DrawMouseUp"].Add("Amazing!");
        unusedUISayings["DrawMouseUp"].Add("Beautiful!");
        unusedUISayings["DrawMouseUp"].Add("Gorgeous !");
        */




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
