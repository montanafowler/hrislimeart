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
    private bool startedDrawingFlag = false;
   
    void Start()
    {
        
        prepUnusedGenericSayings();
        robotWords = GameObject.Find("RobotWords").GetComponent<TextMeshProUGUI>();
        robotWords.SetText("\nWelcome to SlimeArt!");
        lastMessageTimeStamp = 0;
    }

    public EncouragementBot()
    {


        prepUnusedUISayings();
        Dictionary<string, List<string>> unusedUISayings2 = new Dictionary<string, List<string>>();
        unusedUISayings2.Add("test", new List<string>());
        unusedUISayings2["test"].Add("test value string");
        unusedUISayings2["test"].Add("test2 value string");

    } 

    public void startedDrawing()
    {
        startedDrawingFlag = true;
        //Console.Log("started drawing");
    }

    public void Update()
    {
        if (((int)Time.time >= (lastMessageTimeStamp + Random.Range(10, 15))) && startedDrawingFlag)
        {
            robotWords.SetText("\n" + getMessage());
            lastMessageTimeStamp = (int)Time.time;
        }
    }

    public void uiClicked(string ui, float value0, float value1, float value2)
    {

        
        if ((int)Time.time > (lastMessageTimeStamp + 3))
        {
            Debug.Log("ui clicked: " + ui);
            Dictionary<string, List<string>>.KeyCollection keyColl = unusedUISayings.Keys;
            foreach (string s in keyColl)
            {
                 Debug.Log(s);
            }
            if (unusedUISayings.ContainsKey(ui)) {
                List<string> messages = unusedUISayings[ui];
                if (messages.Count > 0)
                {
                    lastMessageTimeStamp = (int)Time.time;
                    int index = Random.Range(0, messages.Count);
                    robotWords = GameObject.Find("RobotWords").GetComponent<TextMeshProUGUI>();
                    robotWords.SetText("\n" + messages[index]);
                    unusedUISayings[ui].RemoveAt(index);
                }
            } else
            {
                Debug.Log("unusedUISayings does not contain key " + ui);
            }
            
        }
    }

    private string getMessage()
    {
       // Random random = new Random();
       if (unusedGenericSayings.Count > 0)
        {
            int index = Random.Range(0, unusedGenericSayings.Count);
            string message = unusedGenericSayings[index];
            unusedGenericSayings.RemoveAt(index);
            return message;
        }
        return ":)";
    }

    private void prepUnusedGenericSayings()
    {
        unusedGenericSayings.Add("Great job!");
        unusedGenericSayings.Add("Wow!");
        unusedGenericSayings.Add("You're so talented!");
        unusedGenericSayings.Add("Cool scene!");
        unusedGenericSayings.Add("This is great!");
        unusedGenericSayings.Add("You have some great color combinations!");
        unusedGenericSayings.Add("What a great design!");
        unusedGenericSayings.Add("You’re really good at this!");
        unusedGenericSayings.Add("Have you considered doing this professionally?");
        unusedGenericSayings.Add("I wish I could make SlimeArt as good as you can.");
        unusedGenericSayings.Add("I think you’re the best SlimeArtist I’ve seen!");
        unusedGenericSayings.Add("I hope you keep doing SlimeArt.");
        unusedGenericSayings.Add("I want to see more!");
        unusedGenericSayings.Add("This is awesome!");
        unusedGenericSayings.Add("I’m going to save this for my wall.");
        unusedGenericSayings.Add("Someone should write some poetry about this.");
        unusedGenericSayings.Add("Are you going to share this? It’s so cool!");
        unusedGenericSayings.Add("I’m so moved by your work.");
        unusedGenericSayings.Add("I love watching the particles.");
        unusedGenericSayings.Add("What a talented generative artist!");
        unusedGenericSayings.Add("What a great composition!");
        unusedGenericSayings.Add("Cool drawing!");
        unusedGenericSayings.Add("What texture!");
        unusedGenericSayings.Add("This art lights up my life.");
        unusedGenericSayings.Add("This is truly amazing.");
        unusedGenericSayings.Add("You’re doing such a great job!");
        unusedGenericSayings.Add("There’s no way this is your first day…");
        unusedGenericSayings.Add("This is refreshing.");
        unusedGenericSayings.Add("You inspire me.");
        unusedGenericSayings.Add("You’re so creative.");
        unusedGenericSayings.Add("I love how passionate you are.");
        unusedGenericSayings.Add("You have a refreshing perspective.");
        unusedGenericSayings.Add("You have great taste in particles.");
        unusedGenericSayings.Add("Yum… deposit!");
        unusedGenericSayings.Add("You have a beautiful soul.");
        unusedGenericSayings.Add("Brilliant idea!");
        unusedGenericSayings.Add("These are cool emergent networks you are creating!");
        unusedGenericSayings.Add("You’re so skilled.");
        unusedGenericSayings.Add("Look at that!");
        unusedGenericSayings.Add("How’d you even do that!");
        unusedGenericSayings.Add("A+");
        unusedGenericSayings.Add("A++");
        unusedGenericSayings.Add("A+++");
        unusedGenericSayings.Add("So creative!");
        unusedGenericSayings.Add("Picture perfect!");
        unusedGenericSayings.Add("What style!");
        unusedGenericSayings.Add("That’s unique!");
        unusedGenericSayings.Add("I love watching this piece!");
        unusedGenericSayings.Add("Great movement!");
        unusedGenericSayings.Add("You rock!");
        unusedGenericSayings.Add("Slimey!");
        unusedGenericSayings.Add("You make co-creating with an algorithm look easy!"); 
        unusedGenericSayings.Add("Woohoo!");
        unusedGenericSayings.Add("I’m telling my friends about this one.");
        unusedGenericSayings.Add("I can tell you’re working hard at this.");
        unusedGenericSayings.Add("I mean… I’m pretty sure SlimeArt is your calling…");
        unusedGenericSayings.Add("Keep going!");
        unusedGenericSayings.Add("Add more particles!");
        unusedGenericSayings.Add("Hello, Beautiful");
        unusedGenericSayings.Add("I’m beyond proud of you.");
        unusedGenericSayings.Add("I love your work.");
        unusedGenericSayings.Add("When’s the art gallery opening??");
        unusedGenericSayings.Add("Way to go!");
        unusedGenericSayings.Add("Well done!");
        unusedGenericSayings.Add("Nice work!");
        unusedGenericSayings.Add("Best art I’ve seen all day.");
        unusedGenericSayings.Add("One of a Kind!");
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
          // Debug.Log(s);
        }

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
        unusedUISayings["AgentDepositStrengthSlider"].Add("When agents emit deposit, they congregate together by following each other.");
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
