using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class EncouragementBot : MonoBehaviour
{
    private List<string> unusedGenericSayings = new List<string>();
    private Dictionary<string, List<string>> unusedUISayings
        = new Dictionary<string, List<string>>();
    private string[] uiNames = { "Play", "Pause", "ClearCanvasButton", "ParticleBrushButton", "DepositBrushButton", "BrushSizeSlider",
    "BrushDensitySlider", "MoveDistanceSlider", "ScaleSlider", "DepositStrengthSlider", "AgentDepositStrengthSlider", "Picker", 
        "SenseDistanceSlider", "TraceDecaySlider", "DrawMouseDown", "DrawMouseUp"};
    private TextMeshProUGUI robotWords; 
    private int lastMessageTimeStamp = 0;
    private bool startedDrawingFlag = false;
   
    void Start() {
        prepUnusedGenericSayings(); // prep unused generic sayings dictionary
        robotWords = GameObject.Find("RobotWords").GetComponent<TextMeshProUGUI>();
        robotWords.SetText("\nWelcome to SlimeArt!"); // set the default message until they begin drawing
    }

    public EncouragementBot()  {
        prepUnusedUISayings(); // prep the unused ui sayings
    } 

    public void startedDrawing()  {
        startedDrawingFlag = true; // once this flag is on, the bot can start displaying messages
    }

    public void Update()  {
        // if the user has started drawing & enough time has passed since a message was displayed
        if (((int)Time.time >= (lastMessageTimeStamp + Random.Range(10, 15))) && startedDrawingFlag) {
            robotWords.SetText("\n" + getMessage()); // display a random unused generic message
            lastMessageTimeStamp = (int)Time.time; // save the time
        }
    }

    /*
     * uiClicked() is called from ComputeHookup whenever any ui item is clicked
     */
    public void uiClicked(string ui, float value0, float value1, float value2) {
        // if enough time has passed since a message was displayed
        if ((int)Time.time > (lastMessageTimeStamp + 4)) {
            // if the ui key is in the unusedUISayings dictionary
            if (unusedUISayings.ContainsKey(ui)) {
                List<string> messages = unusedUISayings[ui]; // the messages for that ui component
                if (messages.Count > 0) {
                    lastMessageTimeStamp = (int)Time.time;
                    int index = Random.Range(0, messages.Count); // choose a random index
                    robotWords = GameObject.Find("RobotWords").GetComponent<TextMeshProUGUI>();
                    robotWords.SetText("\n" + messages[index]); // display that message
                    unusedUISayings[ui].RemoveAt(index); // remove it from the list
                } 
            } else {
                Debug.Log("unusedUISayings does not contain key " + ui);
            }
        }
    }

    /*
     * returns a random unused generic message, and a smiley face if there are no more
     */
    private string getMessage() {
       if (unusedGenericSayings.Count > 0) {
            int index = Random.Range(0, unusedGenericSayings.Count);
            string message = unusedGenericSayings[index]; // get random generic saying
            unusedGenericSayings.RemoveAt(index); // remove it from the List
            return message;
        }
        return ":)"; // the default when the bot runs out of messages
    }

    /*
     * fills the generic sayings dictionary
     */
    private void prepUnusedGenericSayings() {
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

    /*
     * preps the messages when the user clicks a ui component
     */
    private void prepUnusedUISayings() {
        for(int i = 0; i < uiNames.Length; i++)
        {
            unusedUISayings.Add(uiNames[i], new List<string>());
        }

        //play
        unusedUISayings["Play"].Add("Let's see it!");
        unusedUISayings["Play"].Add("Let's go!");
        unusedUISayings["Play"].Add("Exciting!");
        unusedUISayings["Play"].Add("ahhhhhh");
        
        //Pause
        unusedUISayings["Pause"].Add("Nice! Pausing is helpful when planning a design.");
        unusedUISayings["Pause"].Add("I can't wait to see what you design.");
        
        //ClearCanvasButton
        unusedUISayings["ClearCanvasButton"].Add("Time for a blank slate.");
        unusedUISayings["ClearCanvasButton"].Add("Time to start fresh!");
        unusedUISayings["ClearCanvasButton"].Add("Sometimes we just need to start over.");
        unusedUISayings["ClearCanvasButton"].Add("Spring cleaning... or is it spring clearing... ;)");
        
        //ParticleBrushButton
        unusedUISayings["ParticleBrushButton"].Add("You can modify so many settings of the particles!");
        unusedUISayings["ParticleBrushButton"].Add("I can't wait to see what type of particles you make.");
        
        //DepositBrushButton
        unusedUISayings["DepositBrushButton"].Add("You can use the deposit brush to add some stability to your design.");
        unusedUISayings["DepositBrushButton"].Add("Ooh what type of deposit designs will you make?!");
        
        //BrushSizeSlider
        unusedUISayings["BrushSizeSlider"].Add("Playing with the size of the brush is a cool way to manage the amount of particles on the screen.");
        
        //BrushDensitySlider
        unusedUISayings["BrushDensitySlider"].Add("A lower brush density has a sparser brush feel.");
        unusedUISayings["BrushDensitySlider"].Add("A higher brush density has a denser feel.");
        
        //MoveDistanceSlider
        unusedUISayings["MoveDistanceSlider"].Add("I love a design with fast and slow moving particles!");
        unusedUISayings["MoveDistanceSlider"].Add("slow and slimey wins the race...");
        
        //ScaleSlider
        unusedUISayings["ScaleSlider"].Add("When particles have a wider field of view they can see more, so they spread out rather than create lines.");
        unusedUISayings["ScaleSlider"].Add("When particles have a more narrow field of view they can see less, so they create lines.");
        
        //DepositStrengthSlider
        unusedUISayings["DepositStrengthSlider"].Add("When deposit is stronger it is more attractive to particles.");
        
        //AgentDepositStrengthSlider
        unusedUISayings["AgentDepositStrengthSlider"].Add("When agents emit deposit, they congregate together by following each other.");
        unusedUISayings["AgentDepositStrengthSlider"].Add("When agents don't emit deposit, they wander amelessly unless there is static deposit to find.");
        
        //Picker
        unusedUISayings["Picker"].Add("I love colors!");
        unusedUISayings["Picker"].Add("I love the colors you chose!");
        unusedUISayings["Picker"].Add("great colors!");
        
        //SenseDistanceSlider
        unusedUISayings["SenseDistanceSlider"].Add("When particles can sense deposit further ahead of them, they can explore farther.");
        unusedUISayings["SenseDistanceSlider"].Add("Particles can be nearsighted or farsighted with the visibility distance setting.");
        
        //TraceDecaySlider
        unusedUISayings["TraceDecaySlider"].Add("A trace decay of 0 leaves a permanent trace.");
        unusedUISayings["TraceDecaySlider"].Add("A higher trace decay of leaves a shorter trace behind particles.");
        
        //DrawMouseDown
        unusedUISayings["DrawMouseDown"].Add("I can't wait to see what you draw!");
        unusedUISayings["DrawMouseDown"].Add("Drawing Time!");
        
        //DrawMouseUp
        unusedUISayings["DrawMouseUp"].Add("Cool!");
        unusedUISayings["DrawMouseUp"].Add("Woah!");
        unusedUISayings["DrawMouseUp"].Add("Stunning!");
        unusedUISayings["DrawMouseUp"].Add("Amazing!");
        unusedUISayings["DrawMouseUp"].Add("Beautiful!");
        unusedUISayings["DrawMouseUp"].Add("Gorgeous!");
    }

}
