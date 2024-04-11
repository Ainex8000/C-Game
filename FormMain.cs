using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure_Game
{
    /// <summary>
    /// This is the code to the Adventure Game "Into the Magic Forest" made by Xenia DeNoyer (2022)
    /// Everything needed to run the program correctly should already be here and should not be edited
    /// The "If Else" statements are not in any order and were created when needed while testing the code
    /// If you have any questions, you can reach out at: xendenoy@uat.edu
    /// </summary>
    public partial class FormMain : Form
    {
        // Creates scenario objects needed
        ClassSetting objectMainMenu = new ClassSetting(); // This is the main menu
        ClassSetting objectForest = new ClassSetting(); // Starting scenario
        ClassSetting objectWaterfall = new ClassSetting(); // 1 of 2 first scenario
        ClassSetting objectCave = new ClassSetting(); // Possible outcome of the Waterfall scenario
        ClassSetting objectTree = new ClassSetting(); // 1 of 2 first scenario
        ClassSetting objectTemple = new ClassSetting(); // Possible outcome of the Tree Scenario
        ClassSetting objectCabin = new ClassSetting(); // Possible outcome of the Tree Scenario
        ClassSetting objectPond = new ClassSetting(); // Possible outcome of the Waterfall Scenario
        ClassSetting objectTraveler = new ClassSetting(); // Player grabs the compass
        ClassSetting objectLOTR = new ClassSetting(); // LOTR stands for Lord of the Rings; Player grabs the ring
        ClassSetting objectSkeletons = new ClassSetting(); // Encounter with Skeletons; Player grabs the sword
        ClassSetting objectGhoul = new ClassSetting(); // Encounter with a Ghoul; Player grabs the shield
        ClassSetting objectFaerie = new ClassSetting(); // Encounter with faerie; Player picks up the spell book
        ClassSetting objectWizard = new ClassSetting(); // Encounter with Wizard; Player picks up the staff
        ClassSetting objectWolf = new ClassSetting(); // Encounter with dread wolf; Player grabs the bow
        ClassSetting objectGiant = new ClassSetting(); // Encounter with a giant; Player grabs the spear

        // These are the possible endings of the game
        ClassSetting objectMountainDelver = new ClassSetting();
        ClassSetting objectLoneWanderer = new ClassSetting();
        ClassSetting objectMadness = new ClassSetting();
        ClassSetting objectWanderer = new ClassSetting();
        ClassSetting objectWarrior = new ClassSetting();
        ClassSetting objectBattleMaster = new ClassSetting();
        ClassSetting objectHero = new ClassSetting();
        ClassSetting objectProtector = new ClassSetting();
        ClassSetting objectPyromancer = new ClassSetting();
        ClassSetting objectIce = new ClassSetting();
        ClassSetting objectMage = new ClassSetting();
        ClassSetting objectSage = new ClassSetting();
        ClassSetting objectChampion = new ClassSetting();
        ClassSetting objectFriends = new ClassSetting();
        ClassSetting objectPerfectAccuracy = new ClassSetting();
        ClassSetting objectGiantFriend = new ClassSetting();

        // Sets the location of the player upon startup
        string UserLocation = "Into the Magic Forest";

        public FormMain()
        {
            // Since there is no use for the buttons at the startup, they are disabled
            InitializeComponent();
            buttonOne.Enabled = false;
            buttonTwo.Enabled = false;
            
            // Sets the properties of the objects needed for each scenario
            objectMainMenu.ScenarioName = "Into the Magic Forest";
            objectMainMenu.Situation = "Welcome to the game! Please click start to begin. If you want to restart, click the start game button and it will bring you back here." +
                " There are 16 different endings, try to collect them all!";
            objectForest.ScenarioName = "Awakening";
            objectForest.Situation = "You awake in a forest and are unsure of how you got here. You look around and see nothing but happy trees and bushes. " +
                "You can hear sounds of running water nearby as well as the sounds of birds. Where do you go?";
            objectWaterfall.ScenarioName = "The Waterfall";
            objectWaterfall.Situation = "You arrive to a small little lake with a waterfall pouring down from a cliff. " +
                "Staring closer at the waterfall you can see a cave entrance. You begin walking towards it and suddenly see a shining light in the water. What do you do?";
            objectCave.ScenarioName = "Secret Tunnel";
            objectCave.Situation = "You sneak behind the waterfall and enter into the cave. It is surprisingly well lit for a cave, allowing you to see perfectly fine. " +
                "Venturing farther in, you come upon a statue of what appears to be a warrior holding a sword" +
                " and a shield. At his feet is a plaque sating 'take one and face my test'. Which one do you take from the statue?";
            objectTree.ScenarioName = "The Giant Tree";
            objectTree.Situation = "You follow the sounds of birds deeper into the forest and find a great big tree, looking old as time but healthy. Staring closer at the tree, you think you can" +
                " almost see a face staring at you, but you shrug it off. You hear a bird tweet at you, flying in circles to tell you to follow. " +
                "You also see a frog at your foot, staring at you in the eyes until it hops away. What do you do?";
            objectTemple.ScenarioName = "The Ancient Temple";
            objectTemple.Situation = "You follow the bird to an old temple that is in ruins. Walking inside there are many books and robes. Perhaps this was a temple for mages?" +
                " looking around the many books, you find an old tome you figure to be a spell book. Beside the tome is a wooden staff that appears to be carved in runes. Which do you grab?";
            objectCabin.ScenarioName = "Abandoned Cabin";
            objectCabin.Situation = "You run after the frog, following him to a small shack. While examining the shack from the outside, you begin to feel footsteps shaking the ground. " +
                "You quickly hide into the cabin and duck under a table. Across the room you see a bow with a quiver leaning against the wall, next to it is a spear. Thinking you should " +
                "defend yourself, which weapon do you grab?";
            objectPond.ScenarioName = "Search the Water";
            objectPond.Situation = "You dip your hand into the cold water trying to reach out to the object you saw. Getting closer to the water you can see two objects at the bottom, a ring and " +
                "a compass. Which one do you grab?";
            objectTraveler.ScenarioName = "Beginner Traveler";
            objectTraveler.Situation = "You grab the compass and pull it out of the water. Drying it off with your shirt, it looks to be in great condition. It's made of gold with a red needle " +
                "pointing North. On the back there is an engravement that says 'Adventure is out there my friend, travel where your heart tells you to go.' Looking North you can see clear Mountains " +
                "far ahead of you. Looking South is the forest, but what is beyond the forest you question? To start your adventure, you must pick a direction.";
            objectLOTR.ScenarioName = "One Ring to Rule Them All";
            objectLOTR.Situation = "You grab the ring and bring it out of the water. You hold it in your hands and look at it. It's a beautiful gold ring with lettering all around it. You begin to " +
                "hear the ring call out to you in whispers. You feel compelled to put it on. What do you do?";
            objectSkeletons.ScenarioName = "The Undead Rise";
            objectSkeletons.Situation = "You grab the sword from the statue, it's a beautifully made sword with a silver hilt and a very sharp blade. You swing it around a couple times, you find " +
                "its weight to be comfortable to swing around, almost as if it was made for you. You ponder the test the statue mentioned and hear the rattling of bones. Looking behind the statue " +
                "you see three skeletons approaching you. You can either go for a heavy hit on all three of them at once or take an speedful attack and take them down one by one. What do you do?";
            objectGhoul.ScenarioName = "Not Cool Ghoul";
            objectGhoul.Situation = "You grab the shield from the statue. It's a well made shield and feels pretty sturdy. It has an oval shape to it and appears to be made of a strong metal, in the " +
                "center is a green stone, likely to make the appearance more appealing. Remembering the test the statue mentioned, you hear footsteps approaching from behind the statue. Looking in " +
                "that direction, you see a zombie like creature slowly approaching you as it groans at you. With a shield, one would normally go for the defensive side, but since it is only one" +
                " you believe you can take an offensive approach if you try. What do you do?";
            objectFaerie.ScenarioName = "More Than Pixie Dust";
            objectFaerie.Situation = "You pick up the spellbook and begin flipping through it. You find that the spell book is written in your language and you figure you could probably cast a " +
                "spell from this book. As you begin to mumble the words to a spell, you hear the sounds of an angry faerie cursing out at you. She is very mad at you for trespassing into the temple " +
                "and thus has sentenced to you to death. Assuming you would rather not die now, you look back the book in hopes to find a spell to combat against the faerie. You find a fire spell and an " +
                "ice spell. Which do you cast?";
            objectWizard.ScenarioName = "The Evil Wizard";
            objectWizard.Situation = "You pick up the wooden staff and swing it around, trying to cast a spell with it, but it doesn't work. You tap it on the ground as you wonder how to get it " +
                "to work. As you ponder, you hear the footsteps of an old wizard approaching you. He looks very angry at you as you continue tapping the staff on the ground. He calls you disrespectful " +
                "and tells you to have to swing it correctly for it to work. You are unsure of what way you are suppose to swing it and the wizard does not look like he's gonna tell you. The wizard " +
                "takes a combat stance and tells you that if you cannot figure it out, you shall perish. You figure swinging it downward or upwards might do something, it's worth a try if you want " +
                "to survive. How do you swing the staff?";
            objectWolf.ScenarioName = "The Dread Wolf Rises";
            objectWolf.Situation = "You pick up the bow and peer out of the window, to see what is approaching. You see giant wolf with black fur and red eyes, he is looking around his surroundings " +
                "while sniffing the ground a few times. You are sure the wolf is looking for you and you might its next meal if you don't do something. You're left with two options: Fight the wolf or " +
                "sneak away. You're unsure if you will surivive regardless of your choice. What do you do?";
            objectGiant.ScenarioName = "The Giant";
            objectGiant.Situation = "You grab the spear and take a peek through the window to see a giant roaming the area. He doesn't seem to be looking for you, but he is approaching the shack you are " +
                "hiding in. Figuring he might kill you if he sees you, you need to make a decision. The giant is blocking your exit regardless, so combat is your only option. You can likely " +
                "throw your spear at the giant from a safe distance and run away or you could try to pierce the giant in the foot and then run. What's your plan?";


            // These are the properties to the different endings
            objectMountainDelver.ScenarioName = "Mountain Delver";
            objectMountainDelver.Situation = "You begin to head North in hopes of finding a chilling adventure in the snowy mountains. Months later you are known as the Mountain Delver to the " +
                "nearby village at the foot of the mountain. Many of the villagers seek your aid in passing through the mountains to the village on the other side. Some even request your help when a " +
                "foolish villager goes into the mountains alone. You are the only one able to brave the harsh climate here and thus have earned your title as the Mountain Delver. " +
                "(Click Start Game to restart)";
            objectWarrior.ScenarioName = "The Oneshot Warrior";
            objectWarrior.Situation = "You set yourself into a stance as you take a moment to charge up before you unleash a heavy strike on the three skeletons, slicing all three in half in " +
                "one blow. You have passed the test and are now worthy to keep the sword in your hands. Leaving the cave, you head in search of mighty monsters to test your strength against. You would" +
                " later become well-known throughout the land as the Oneshot Warrior, who is able to defeat their foes in a single heavy blow and you have yet to" +
                " know defeat. (Click Start Game to restart)";
            objectHero.ScenarioName = "Shield Hero";
            objectHero.Situation = "You raise your shield in front of you and charge forward towards the ghoul, shield bashing him with a great strength. The ghoul is knocked down and slowly begins " +
                "to stand back up, but before he can you deal him one more shield bash, destroying the ghoul's skull. You have passed the test and are now worthy to keep the shield. You would " +
                "your new found strength protect the land from monsters and would eventually become known as the Shield Hero who attacks their foes with a mighty shield. (Click Start Game to restart)";
            objectProtector.ScenarioName = "Protective Defender";
            objectProtector.Situation = "You take a defensive stance as the ghoul begins to charge towards you. Unsure if defending will get you anywhere, you prepare to parry the ghoul's attack " +
                "as soon as he came in range. The ghoul gets in range and you swing your shield in attempt to parry the ghoul's attack. You succeed as the shield glows a bright green as you parry. " +
                "You realize the gemstone is magic and makes your parrys stronger when defending. The ghoul is defeated and you have passed the test. Taking your new protective item, you seek " +
                "out to defend vulnerable villages that might be attacked by bandits or monsters. You would later earn your title as the Protective Defender. (Click Start Game to restart)";
            objectMadness.ScenarioName = "Fallen to Madness";
            objectMadness.Situation = "You succumb to the whispers and put the ring on. Upon wearing it, great knowledge flows within you, but however it is too much. Unable to take the ring off " +
                "your mind begins to slip into madness as you are not able to comprehend the amount of knowledge. You roam the forest, rambling about ancient magics and forgotten realms, sometimes" +
                " screaming as the voices in your head continue to tell you more and more about the forgotten knowledge someone left behind. Some knowledge is best left forgotten. " +
                "(Click Start Game to restart)";
            objectWanderer.ScenarioName = "Forest Wanderer";
            objectWanderer.Situation = "You resist the urge to wear the ring and throw it farther into the lake, hoping no one will be able to find it. You could tell whatever that ring was, it" +
                " would only bring misfortune to whoever wears it. Deciding it would be best to ensure no one finds the ring ever, you wander the forest alone, scaring off any travelers that seek " +
                "adventure in these woods. You would become known as the Forest Wanderer who warns many about the dangers of this forest and protects what is hidden within. (Click Start Game to restart)";
            objectBattleMaster.ScenarioName = "Swiftful Blade";
            objectBattleMaster.Situation = "You decide it would be best to use quick attacks to defeat each skeleton one by one before they have the opportunity to fight you. Being swiftful as you " +
                "can be, you quickly attack each skeleton in a few quick attacks. It's very effective, as you defeat them in a mere seconds. You have passed the test and are now worthy to keep " +
                "the blade. You decided you would take your skill out into the world and become a mercenary. Being a quickful sword, you are known for defeating your enemies before they even " +
                "draw their blades and ending blades before they begin. You earned your title as the Swiftful Blade. (Click Start Game to restart)";
            objectLoneWanderer.ScenarioName = "Lone Wanderer";
            objectLoneWanderer.Situation = "You begin wandering South, seeking whatever is beyond the forest you have awaken in. In the following months, you have seen many different" +
                " regions across the land and have met many different travelers, merchants, and even villagers. Becoming known as the Lone Wanderer who wanders along the land in hopes of finding " +
                "new places, meeting new people, and finding great tales to share along with others. You dearly live the life of a wanderer who has no home waiting for them or anyone to deseparetly " +
                "return to. Not yet as least, someday you will settle, but that in the far future. For now, you wander alone. (Click Start Game to restart)";
            objectPyromancer.ScenarioName = "Wrath of Fire";
            objectPyromancer.Situation = "You read off the fire spell and blast the faerie into ashes. You avoided death this time. Looking back to the spellbook, the cover turns red and the reveals " +
                "even more fire spells. It seems you picked your element in that quick situation, but no harm to it. You find yourself quite masterful of fire magic and would become a great " +
                "pyromancer. Seeking out to learn more about your abilties and how to become a stronger fire mage, you begin traveling to seek the wisdom of a greater fire mage. Little did you know" +
                " the best teacher for fire magic would a great fire dragon. Of course, you wouldn't know for this a while, but it will be a surprise when the dragon finds you on their own accord. " +
                "(Click Start Game to restart)";
            objectIce.ScenarioName = "Cold Hearted";
            objectIce.Situation = "With barely any time to consider it, you read off an ice spell and freeze the faerie solid in mid-air, letting it drop the ground, shattering. You succeeded in " +
                "defending yourself against the faerie. Staring back at the tome, it appears to have changed itself into a spellbook full of ice spell. Feeling as though the coldness is a perfect " +
                "match with you, you take it upon yourself to become an ice mage. With a cold heart, you use ice and snow to your advantage to overwhelm your foes in a chilling manner. (Click Start Game to restart)";
            objectGiantFriend.ScenarioName = "Friend of the Giant";
            objectGiantFriend.Situation = "You ready your spear and prepare to attack the giant. You burst through the front door and pierce the spear into the giant's foot. The giant begins to " +
                "wail in pain as you begin to run away. Suddenly, you stop as you see the giant crying like a big baby as he holds his foot. Feeling bad for the giant you go back up to him and" +
                " apologize. He understands why you attack him and explains that he was merely looking around, he had no bad intentions towards you. Taking responsibility of your actions, you " +
                "help the giant treat his foot and aid him until he is well enough to walk on his own. Through this little endeavor, you found a giant friend. (Click Start Game to restart)";
            objectPerfectAccuracy.ScenarioName = "Perfect Accuracy";
            objectPerfectAccuracy.Situation = "You ready your spear and prepare your attack. You burst open the door and take aim at the giant and throw your spear into his eye with perfect accuracy," +
                " you take the opportunity and make your escape as the giant wails in pain and runs in the opposite direction. Now without a weapon in a likely dangerous forest, you begin to search " +
                "for the exit and hope you never encounter the giant again. (Click Start Game to restart)";
            objectChampion.ScenarioName = "Forest Champion";
            objectChampion.Situation = "You take aim at the wolf through the window, taking a deep breath as the wolf looks in your direct. You unleash your arrow, successfully shooting the wolf in " +
                "the eye. The wolf howls in pain and runs away from the scene. You never saw that wolf again and considered yourself lucky he did not seek vengenance against you. The creatures of " +
                "the forest thank you for driving the dread wolf away and have named you the Forest Champion, a title you keep as you protect the forest, hoping to never cross paths with the " +
                "dread wolf again.";
            objectFriends.ScenarioName = "Friend of the Dread Wolf";
            objectFriends.Situation = "You sneak out the front door in hopes of avoiding the wolf and you would have succeeded if you didn't step on a stick, breaking it halfway with a loud snap. " +
                "You make eye contact with the wolf and simply stare at each. Through the staring contest, the two of you find an agreement and the wolf returns the way it went, leaving you be. " +
                "Beliving the wolf would never approach you again, you would become surprised when it comes to defend you in trying times. You realize you have a found a friend in these lonely" +
                " woods and are now the Friend of the Dread Wolf. (Click Start Game to restart)";
            objectMage.ScenarioName = "What a Shock";
            objectMage.Situation = "You swing the staff downwards in hopes of a reaction from the staff and you rightfully earned it as it shoots out a bolt of lightning at the wizard, defeating him" +
                " instantly. Taking a breath of relief, you are grateful you got it right in your time of need. Remembering correctly, you now wield the lightning staff as new mage. Looking to " +
                "learn more about the runed staff and how to be a better mage, you begin your journey to the College of Magi in the South Coastland. What a Shock that you became a thundering mage." +
                " (Click Start Game to restart)";
            objectSage.ScenarioName = "Blow Them Away";
            objectSage.Situation = "You swing down the staff unleashing a whirl of wind towards the wizard, knocking him to the ground leaving him unconscious. You sigh in relief as you approach the " +
                "unconscious wizard, making sure he is still alive. He awakes and congratulates you for your efforts and offers to teach you to become a wind sage. Masterful of wind magic and a " +
                "mercifal sage, you take the wizard's offer and learn he was not actually serious about hurting you. You surely blew him away with how quick you could learn and would do your best " +
                "to make him proud and take what he teaches you to heart. (Click Start Game to restart)";

            // This sets the main menu upon start up
            textBoxHeader.Text = objectMainMenu.ScenarioName;
            textBoxSituation.Text = objectMainMenu.Situation;
        }

        // This button will serve as "Option One" to each scenario
        private void buttonOne_Click(object sender, EventArgs e)
        {
            // Reads the user's location to pull up the correct scenario
            if (UserLocation == objectForest.ScenarioName)
            {
                // This will set the new header
                textBoxHeader.Text = objectWaterfall.ScenarioName;
                // This will tell the user what the scenario is
                textBoxSituation.Text = objectWaterfall.Situation;
                // This will set the background to fit the setting
                this.BackgroundImage = Properties.Resources.Waterfall;

                // Changes the text on the button to the options the user is presented with
                buttonOne.Text = "Search Water";
                buttonTwo.Text = "Search Waterfall";

                // This will set the user's location
                UserLocation = objectWaterfall.ScenarioName;
            }
            // Reads the user's location to pull up the correct scenario
            else if (UserLocation == objectWaterfall.ScenarioName)
            {
                // This will set the new header
                textBoxHeader.Text = objectPond.ScenarioName;
                // This will tell the user what the scenario is
                textBoxSituation.Text = objectPond.Situation;
                // This will set the background to fit the setting
                this.BackgroundImage = Properties.Resources.Waterfall;

                // Changes the text on the button to the options the user is presented with
                buttonOne.Text = "Grab Compass";
                buttonTwo.Text = "Grab Ring";

                // This will set the user's location
                UserLocation = objectPond.ScenarioName;
            }
            // Reads the user's location to pull up the correct scenario
            else if (UserLocation == objectPond.ScenarioName)
            {
                // This will set the new header
                textBoxHeader.Text = objectTraveler.ScenarioName;
                // This will tell the user what the scenario is
                textBoxSituation.Text = objectTraveler.Situation;

                // Changes the text on the button to the options the user is presented with
                buttonOne.Text = "Head North";
                buttonTwo.Text = "Head South";

                // This will set the user's location
                UserLocation = objectTraveler.ScenarioName;
            }
            // Reads the user's location to pull up the correct scenario
            else if (UserLocation == objectTraveler.ScenarioName)
            {
                // This will set the new header
                textBoxHeader.Text = objectMountainDelver.ScenarioName;
                // This will tell the user what the scenario is
                textBoxSituation.Text = objectMountainDelver.Situation;
                // This will set the background to fit the setting
                this.BackgroundImage = Properties.Resources.Mountain;

                // Changes the text back as there is no choice to be made
                buttonOne.Text = "Choice One";
                buttonTwo.Text = "Choice Two";

                // There are no more choices needed for the player to make, so the buttons are disabled
                buttonOne.Enabled = false;
                buttonTwo.Enabled = false;

                // This will set the user's location
                UserLocation = objectMountainDelver.ScenarioName;
            }
            // Reads the user's location to pull up the correct scenario
            else if (UserLocation == objectCave.ScenarioName)
            {
                // This will set the new header
                textBoxHeader.Text = objectSkeletons.ScenarioName;
                // This will tell the user what the scenario is
                textBoxSituation.Text = objectSkeletons.Situation;

                // Changes the text on the button to the options the user is presented with
                buttonOne.Text = "Heavy Hit";
                buttonTwo.Text = "Quick Attack";

                // This will set the user's location
                UserLocation = objectSkeletons.ScenarioName;
            }
            // Reads the user's location to pull up the correct scenario
            else if (UserLocation == objectSkeletons.ScenarioName)
            {
                // This will set the new header
                textBoxHeader.Text = objectWarrior.ScenarioName;
                // This will tell the user what the scenario is
                textBoxSituation.Text = objectWarrior.Situation;
                // This will set the background to fit the setting
                this.BackgroundImage = Properties.Resources.Sword;

                // Changes the text back as there is no choice to be made
                buttonOne.Text = "Choice One";
                buttonTwo.Text = "Choice Two";

                // There are no more choices needed for the player to make, so the buttons are disabled
                buttonOne.Enabled = false;
                buttonTwo.Enabled = false;

                // This will set the user's location
                UserLocation = objectWarrior.ScenarioName;
            }
            // Reads the user's location to pull up the correct scenario
            else if (UserLocation == objectGhoul.ScenarioName)
            {
                // This will set the new header
                textBoxHeader.Text = objectHero.ScenarioName;
                // This will tell the user what the scenario is
                textBoxSituation.Text = objectHero.Situation;

                // Changes the text back as there is no choice to be made
                buttonOne.Text = "Choice One";
                buttonTwo.Text = "Choice Two";

                // There are no more choices needed for the player to make, so the buttons are disabled
                buttonOne.Enabled = false;
                buttonTwo.Enabled = false;

                // This will set the user's location
                UserLocation = objectHero.ScenarioName;
            }
            // Reads the user's location to pull up the correct scenario
            else if (UserLocation == objectLOTR.ScenarioName)
            {
                // This will set the new header
                textBoxHeader.Text = objectMadness.ScenarioName;
                // This will tell the user what the scenario is
                textBoxSituation.Text = objectMadness.Situation;
                // This will set the background to fit the setting
                this.BackgroundImage = Properties.Resources.Forest;

                // Changes the text back as there is no choice to be made
                buttonOne.Text = "Choice One";
                buttonTwo.Text = "Choice Two";

                // There are no more choices needed for the player to make, so the buttons are disabled
                buttonOne.Enabled = false;
                buttonTwo.Enabled = false;

                // This will set the user's location
                UserLocation = objectMadness.ScenarioName;
            }
            // Reads the user's location to pull up the correct scenario
            else if (UserLocation == objectTree.ScenarioName)
            {
                // This will set the new header
                textBoxHeader.Text = objectTemple.ScenarioName;
                // This will tell the user what the scenario is
                textBoxSituation.Text = objectTemple.Situation;
                // This will set the background to fit the setting
                this.BackgroundImage = Properties.Resources.Temple;

                // Changes the text on the button to the options the user is presented with
                buttonOne.Text = "Spell Book";
                buttonTwo.Text = "Wooden Staff";

                // This will set the user's location
                UserLocation = objectTemple.ScenarioName;
            }
            // Reads the user's location to pull up the correct scenario
            else if (UserLocation == objectTemple.ScenarioName)
            {
                // This will set the new header
                textBoxHeader.Text = objectFaerie.ScenarioName;
                // This will tell the user what the scenario is
                textBoxSituation.Text = objectFaerie.Situation;

                // Changes the text on the button to the options the user is presented with
                buttonOne.Text = "Fire Spell";
                buttonTwo.Text = "Ice Spell";

                // This will set the user's location
                UserLocation = objectFaerie.ScenarioName;
            }
            // Reads the user's location to pull up the correct scenario
            else if (UserLocation == objectFaerie.ScenarioName)
            {
                // This will set the new header
                textBoxHeader.Text = objectPyromancer.ScenarioName;
                // This will tell the user what the scenario is
                textBoxSituation.Text = objectPyromancer.Situation;
                // This will set the background to fit the setting
                this.BackgroundImage = Properties.Resources.Dragon;

                // Changes the text back as there is no choice to be made
                buttonOne.Text = "Choice One";
                buttonTwo.Text = "Choice Two";

                // There are no more choices needed for the player to make, so the buttons are disabled
                buttonOne.Enabled = false;
                buttonTwo.Enabled = false;

                // This will set the user's location
                UserLocation = objectPyromancer.ScenarioName;
            }
            // Reads the user's location to pull up the correct scenario
            else if (UserLocation == objectCabin.ScenarioName)
            {
                // This will set the new header
                textBoxHeader.Text = objectWolf.ScenarioName;
                // This will tell the user what the scenario is
                textBoxSituation.Text = objectWolf.Situation;

                // Changes the text on the button to the options the user is presented with
                buttonOne.Text = "Aim for the Wolf";
                buttonTwo.Text = "Sneak Away";

                // This will set the user's location
                UserLocation = objectWolf.ScenarioName;
            }
            // Reads the user's location to pull up the correct scenario
            else if (UserLocation == objectWolf.ScenarioName)
            {
                // This will set the new header
                textBoxHeader.Text = objectChampion.ScenarioName;
                // This will tell the user what the scenario is
                textBoxSituation.Text = objectChampion.Situation;
                // This will set the background to fit the setting
                this.BackgroundImage = Properties.Resources.Forest;

                // Changes the text back as there is no choice to be made
                buttonOne.Text = "Choice One";
                buttonTwo.Text = "Choice Two";

                // There are no more choices needed for the player to make, so the buttons are disabled
                buttonOne.Enabled = false;
                buttonTwo.Enabled = false;

                // This will set the user's location
                UserLocation = objectChampion.ScenarioName;
            }
            // Reads the user's location to pull up the correct scenario
            else if (UserLocation == objectWizard.ScenarioName)
            {
                // This will set the new header
                textBoxHeader.Text = objectMage.ScenarioName;
                // This will tell the user what the scenario is
                textBoxSituation.Text = objectMage.Situation;
                // This will set the background to fit the setting
                this.BackgroundImage = Properties.Resources.College;

                // Changes the text back as there is no choice to be made
                buttonOne.Text = "Choice One";
                buttonTwo.Text = "Choice Two";

                // There are no more choices needed for the player to make, so the buttons are disabled
                buttonOne.Enabled = false;
                buttonTwo.Enabled = false;

                // This will set the user's location
                UserLocation = objectMage.ScenarioName;
            }
            // Reads the user's location to pull up the correct scenario
            else if (UserLocation == objectGiant.ScenarioName)
            {
                // This will set the new header
                textBoxHeader.Text = objectPerfectAccuracy.ScenarioName;
                // This will tell the user what the scenario is
                textBoxSituation.Text = objectPerfectAccuracy.Situation;
                // This will set the background to fit the setting
                this.BackgroundImage = Properties.Resources.Forest;

                // Changes the text back as there is no choice to be made
                buttonOne.Text = "Choice One";
                buttonTwo.Text = "Choice Two";

                // There are no more choices needed for the player to make, so the buttons are disabled
                buttonOne.Enabled = false;
                buttonTwo.Enabled = false;

                // This will set the user's location
                UserLocation = objectPerfectAccuracy.ScenarioName;
            }
        }

        // This button will serve as the quit button and change to the Choice 2 button once the game starts
        private void buttonTwo_Click(object sender, EventArgs e)
        {
            // Reads the user's location to pull up the correct scenario
            if (UserLocation == objectForest.ScenarioName)
            {
                // This will set the new header
                textBoxHeader.Text = objectTree.ScenarioName;
                // This will tell the user what the scenario is
                textBoxSituation.Text = objectTree.Situation;
                // This will set the background to fit the setting
                this.BackgroundImage = Properties.Resources.Tree;

                // Changes the text on the button to the options the user is presented with
                buttonOne.Text = "Follow the Bird";
                buttonTwo.Text = "Follow the Frog";

                // This will set the user's location
                UserLocation = objectTree.ScenarioName;
            }
            // Reads the user's location to pull up the correct scenario
            else if (UserLocation == objectTree.ScenarioName)
            {
                // This will set the new header
                textBoxHeader.Text = objectCabin.ScenarioName;
                // This will tell the user what the scenario is
                textBoxSituation.Text = objectCabin.Situation;
                // This will set the background to fit the setting
                this.BackgroundImage = Properties.Resources.Cabin;

                // Changes the text on the button to the options the user is presented with
                buttonOne.Text = "Grab Bow";
                buttonTwo.Text = "Grab Spear";

                // This will set the user's location
                UserLocation = objectCabin.ScenarioName;
            }
            // Reads the user's location to pull up the correct scenario
            else if (UserLocation == objectCabin.ScenarioName)
            {
                // This will set the new header
                textBoxHeader.Text = objectGiant.ScenarioName;
                // This will tell the user what the scenario is
                textBoxSituation.Text = objectGiant.Situation;

                // Changes the text on the button to the options the user is presented with
                buttonOne.Text = "Throw the Spear";
                buttonTwo.Text = "Pierce with the Spear";

                // This will set the user's location
                UserLocation = objectGiant.ScenarioName;
            }
            // Reads the user's location to pull up the correct scenario
            else if (UserLocation == objectGiant.ScenarioName)
            {
                // This will set the new header
                textBoxHeader.Text = objectGiantFriend.ScenarioName;
                // This will tell the user what the scenario is
                textBoxSituation.Text = objectGiantFriend.Situation;
                // This will set the background to fit the setting
                this.BackgroundImage = Properties.Resources.Forest;

                // Changes the text back as there is no choice to be made
                buttonOne.Text = "Choice One";
                buttonTwo.Text = "Choice Two";

                // There are no more choices needed for the player to make, so the buttons are disabled
                buttonOne.Enabled = false;
                buttonTwo.Enabled = false;

                // This will set the user's location
                UserLocation = objectGiantFriend.ScenarioName;
            }
            // Reads the user's location to pull up the correct scenario
            else if (UserLocation == objectWaterfall.ScenarioName)
            {
                // This will set the new header
                textBoxHeader.Text = objectCave.ScenarioName;
                // This will tell the user what the scenario is
                textBoxSituation.Text = objectCave.Situation;
                // This will set the background to fit the setting
                this.BackgroundImage = Properties.Resources.Cave;

                // Changes the text on the button to the options the user is presented with
                buttonOne.Text = "Grab the Sword";
                buttonTwo.Text = "Grab the Shield";

                // This will set the user's location
                UserLocation = objectCave.ScenarioName;
            }
            // Reads the user's location to pull up the correct scenario
            else if (UserLocation == objectCave.ScenarioName)
            {
                // This will set the new header
                textBoxHeader.Text = objectGhoul.ScenarioName;
                // This will tell the user what the scenario is
                textBoxSituation.Text = objectGhoul.Situation;

                // Changes the text on the button to the options the user is presented with
                buttonOne.Text = "Offense";
                buttonTwo.Text = "Defense";

                // This will set the user's location
                UserLocation = objectGhoul.ScenarioName;
            }
            // Reads the user's location to pull up the correct scenario
            else if (UserLocation == objectGhoul.ScenarioName)
            {
                // This will set the new header
                textBoxHeader.Text = objectProtector.ScenarioName;
                // This will tell the user what the scenario is
                textBoxSituation.Text = objectProtector.Situation;
                // This will set the background to fit the setting
                this.BackgroundImage = Properties.Resources.City;

                // Changes the text back as there is no choice to be made
                buttonOne.Text = "Choice One";
                buttonTwo.Text = "Choice Two";

                // There are no more choices needed for the player to make, so the buttons are disabled
                buttonOne.Enabled = false;
                buttonTwo.Enabled = false;

                // This will set the user's location
                UserLocation = objectProtector.ScenarioName;
            }
            // Reads the user's location to pull up the correct scenario
            else if (UserLocation == objectPond.ScenarioName)
            {
                // This will set the new header
                textBoxHeader.Text = objectLOTR.ScenarioName;
                // This will tell the user what the scenario is
                textBoxSituation.Text = objectLOTR.Situation;

                // Changes the text on the button to the options the user is presented with
                buttonOne.Text = "Wear the Ring";
                buttonTwo.Text = "Throw the Ring";

                // This will set the user's location
                UserLocation = objectLOTR.ScenarioName;
            }
            // Reads the user's location to pull up the correct scenario
            else if (UserLocation == objectLOTR.ScenarioName)
            {
                // This will set the new header
                textBoxHeader.Text = objectWanderer.ScenarioName;
                // This will tell the user what the scenario is
                textBoxSituation.Text = objectWanderer.Situation;
                // This will set the background to fit the setting
                this.BackgroundImage = Properties.Resources.Forest;

                // Changes the text back as there is no choice to be made
                buttonOne.Text = "Choice One";
                buttonTwo.Text = "Choice Two";

                // There are no more choices needed for the player to make, so the buttons are disabled
                buttonOne.Enabled = false;
                buttonTwo.Enabled = false;

                // This will set the user's location
                UserLocation = objectWanderer.ScenarioName;
            }
            // Reads the user's location to pull up the correct scenario
            else if (UserLocation == objectSkeletons.ScenarioName)
            {
                // This will set the new header
                textBoxHeader.Text = objectBattleMaster.ScenarioName;
                // This will tell the user what the scenario is
                textBoxSituation.Text = objectBattleMaster.Situation;
                // This will set the background to fit the setting
                this.BackgroundImage = Properties.Resources.City;

                // Changes the text back as there is no choice to be made
                buttonOne.Text = "Choice One";
                buttonTwo.Text = "Choice Two";

                // There are no more choices needed for the player to make, so the buttons are disabled
                buttonOne.Enabled = false;
                buttonTwo.Enabled = false;

                // This will set the user's location
                UserLocation = objectBattleMaster.ScenarioName;
            }
            // Reads the user's location to pull up the correct scenario
            else if (UserLocation == objectTraveler.ScenarioName)
            {
                // This will set the new header
                textBoxHeader.Text = objectLoneWanderer.ScenarioName;
                // This will tell the user what the scenario is
                textBoxSituation.Text = objectLoneWanderer.Situation;
                // This will set the background to fit the setting
                this.BackgroundImage = Properties.Resources.Wanderer;

                // Changes the text back as there is no choice to be made
                buttonOne.Text = "Choice One";
                buttonTwo.Text = "Choice Two";

                // There are no more choices needed for the player to make, so the buttons are disabled
                buttonOne.Enabled = false;
                buttonTwo.Enabled = false;

                // This will set the user's location
                UserLocation = objectLoneWanderer.ScenarioName;
            }
            // Reads the user's location to pull up the correct scenario
            else if (UserLocation == objectFaerie.ScenarioName)
            {
                // This will set the new header
                textBoxHeader.Text = objectIce.ScenarioName;
                // This will tell the user what the scenario is
                textBoxSituation.Text = objectIce.Situation;
                // This will set the background to fit the setting
                this.BackgroundImage = Properties.Resources.Ice;

                // Changes the text back as there is no choice to be made
                buttonOne.Text = "Choice One";
                buttonTwo.Text = "Choice Two";

                // There are no more choices needed for the player to make, so the buttons are disabled
                buttonOne.Enabled = false;
                buttonTwo.Enabled = false;

                // This will set the user's location
                UserLocation = objectIce.ScenarioName;
            }
            // Reads the user's location to pull up the correct scenario
            else if (UserLocation == objectTemple.ScenarioName)
            {
                // This will set the new header
                textBoxHeader.Text = objectWizard.ScenarioName;
                // This will tell the user what the scenario is
                textBoxSituation.Text = objectWizard.Situation;

                // Changes the text on the button to the options the user is presented with
                buttonOne.Text = "Swing Upwards";
                buttonTwo.Text = "Swing Downwards";

                // This will set the user's location
                UserLocation = objectWizard.ScenarioName;
            }
            // Reads the user's location to pull up the correct scenario
            else if (UserLocation == objectWizard.ScenarioName)
            {
                // This will set the new header
                textBoxHeader.Text = objectSage.ScenarioName;
                // This will tell the user what the scenario is
                textBoxSituation.Text = objectSage.Situation;

                // Changes the text back as there is no choice to be made
                buttonOne.Text = "Choice One";
                buttonTwo.Text = "Choice Two";

                // There are no more choices needed for the player to make, so the buttons are disabled
                buttonOne.Enabled = false;
                buttonTwo.Enabled = false;

                // This will set the user's location
                UserLocation = objectSage.ScenarioName;
            }
            // Reads the user's location to pull up the correct scenario
            else if (UserLocation == objectWolf.ScenarioName)
            {
                // This will set the new header
                textBoxHeader.Text = objectFriends.ScenarioName;
                // This will tell the user what the scenario is
                textBoxSituation.Text = objectFriends.Situation;
                // This will set the background to fit the setting
                this.BackgroundImage = Properties.Resources.Wolf;

                // Changes the text back as there is no choice to be made
                buttonOne.Text = "Choice One";
                buttonTwo.Text = "Choice Two";

                // There are no more choices needed for the player to make, so the buttons are disabled
                buttonOne.Enabled = false;
                buttonTwo.Enabled = false;

                // This will set the user's location
                UserLocation = objectFriends.ScenarioName;
            }
        }
    

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Sets the header to the title of the first scenario
            textBoxHeader.Text = objectForest.ScenarioName;
            // Tells the user what is going on in the current scene
            textBoxSituation.Text = objectForest.Situation;
            // This will set the background to fit the setting
            this.BackgroundImage = Properties.Resources.Forest;

            // Sets the button text to the options presented to the user
            buttonOne.Text = "Towards Water";
            buttonTwo.Text = "Towards Birds";

            // Enables the buttons so the user can make choices
            buttonOne.Enabled = true;
            buttonTwo.Enabled = true;

            // This will set the user's location
            UserLocation = objectForest.ScenarioName;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Creating a sound object called myRadio from a class called SoundPlayer
            // I placed a resource into my new object when I initialized it
            SoundPlayer myRadio = new SoundPlayer(Properties.Resources.Call_To_Adventure);
            // We have to tell our object, in this case, we named it myRadio to do things.
            // We tell it to play
            myRadio.Play();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            // This button will close the application
            Application.Exit();
        }

        private void buttonSound_Click(object sender, EventArgs e)
        {
            // Creating a sound object called myRadio from a class called SoundPlayer
            // I placed a resource into my new object when I initialized it
            SoundPlayer myRadio = new SoundPlayer(Properties.Resources.Call_To_Adventure);
            // We have to tell our object, in this case, we named it myRadio to do things.
            // We tell it to stop
            myRadio.Stop();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            // Creating a sound object called myRadio from a class called SoundPlayer
            // I placed a resource into my new object when I initialized it
            SoundPlayer myRadio = new SoundPlayer(Properties.Resources.Call_To_Adventure);
            // We have to tell our object, in this case, we named it myRadio to do things.
            // We tell it to play
            myRadio.Play();
        }
    }
}
