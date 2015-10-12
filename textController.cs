using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextControllor : MonoBehaviour {

	public Text text;
	
	private enum States{room0, room1, room_Key, room_Torch, room_Both, key, torch, box, box_Death, door0, door_Key, door_Locked, door_Torch, door_Both, door_Death, door_Unlock, false_freedom, death, corridor0, corridor1, floor_Death, floor_Life, mosaic, stone0, stone1, face_Death, face_Unlock, wall_Death_elephant, wall_Death_horse, wall_Life, wall, freedom};
	private States myState;
	
	bool keyInv = false;
	bool torchInv = false;
	bool stoneFed = false;
	
	void Start () 
	{
		text.text = "Welcome to Aztec Adventure!";
		myState = States.room0;
	}
	
	void Update () 
	{
		if (myState == States.room0)
		{
			state_room0();
		}
		else if(myState == States.box)
		{
			state_box();
		}
		else if(myState == States.box_Death)
		{
			state_box_Death();
		}
		else if(myState == States.death)
		{
			state_death();
		}
		else if(myState == States.room1)
		{
			state_room1();
		}
		else if(myState == States.key)
		{
			state_key();
		}
		else if(myState == States.room_Key)
		{
			state_room_Key();
		}
		else if(myState == States.torch)
		{
			state_Torch();
		}
		else if(myState == States.room_Torch)
		{
			state_room_Torch();
		}
		else if(myState == States.room_Both)
		{
			state_room_Both();
		}
		else if(myState == States.door0)
		{
			state_door0();
		}
		else if(myState == States.door_Torch)
		{
			state_door_Torch();
		}
		else if(myState == States.door_Unlock)
		{
			state_door_Unlock();
		}
		else if(myState == States.door_Key)
		{
			state_door_Key();
		}
		else if(myState == States.door_Locked)
		{
			state_door_Locked();
		}
		else if(myState == States.door_Death)
		{
			state_door_Death();
		}
		else if(myState == States.door_Both)
		{
			state_door_Both();
		}
		else if(myState == States.false_freedom)
		{
			state_false_freedom();
		}
		else if(myState == States.corridor0)
		{
			state_corridor0();
		}
		else if(myState == States.stone0)
		{
			state_stone0();
		}
		else if(myState == States.stone1)
		{
			state_stone1();
		}
		else if(myState == States.face_Death)
		{
			state_face_Death();
		}
		else if(myState == States.mosaic)
		{
			state_mosaic();
		}
		else if(myState == States.wall_Death_elephant)
		{
			state_wall_Death_Elephant();
		}
		else if(myState == States.wall_Death_horse)
		{
			state_wall_Death_Horse();
		}
		
	}
	
	void state_room0()
	{
		text.text = "You awake inside what appears to be an ancient Aztec temple. " +
					"You realise quickly that making the wrong move will cost you your life. " + 
					"You inspect your surroundings. You are in a room with only a torch for light. " +
					"The door blocking your exit seems to be made of stone with a big wooden lock. " +
					"Under you, you can see a little ornate box which is closed and a golden key.\n\n" + 
					"Press B to view the Box.\n"  +
					"Press T to view the Torch.\n" +
					"Press K to view the Key.\n" +
					"Press D to view the Door.";
		
		if(Input.GetKeyDown(KeyCode.B))
		{
			myState = States.box;
		}
		else if(Input.GetKeyDown(KeyCode.T))
		{
			myState = States.torch;
		}
		else if(Input.GetKeyDown(KeyCode.D))
		{
			if(keyInv == true && torchInv == true)
			{
				myState = States.door_Both;
			}
			else if(keyInv == false && torchInv == true)
			{
				myState = States.door_Torch;
			}
			else if(keyInv == true && torchInv == false)
			{
				myState = States.door_Key;
			}
			else if(keyInv == false && torchInv == false)
			{
				myState = States.door0;
			}
		}
		else if(Input.GetKeyDown(KeyCode.K))
		{
			myState = States.key;
		}
		
	}
	
	void state_room1()
	{
		text.text = "You are in a room with only a torch for light. " +
					"The door blocking your exit seems to be made of stone with a big wooden lock. " +
					"Under you, you can see a little ornate box which is closed and a golden key.\n\n" + 
					"Press B to view the Box.\n"  +
					"Press T to view the Torch.\n" +
					"Press K to view the Key.\n" +
					"Press D to view the Door.";
		
		if(Input.GetKeyDown(KeyCode.B))
		{
			myState = States.box;
		}
		else if(Input.GetKeyDown(KeyCode.T))
		{
			myState = States.torch;
		}
		else if(Input.GetKeyDown(KeyCode.D))
		{
			if(keyInv == true && torchInv == true)
			{
				myState = States.door_Both;
			}
			else if(keyInv == false && torchInv == true)
			{
				myState = States.door_Torch;
			}
			else if(keyInv == true && torchInv == false)
			{
				myState = States.door_Key;
			}
			else if(keyInv == false && torchInv == false)
			{
				myState = States.door0;
			}
		}
		else if(Input.GetKeyDown(KeyCode.K))
		{
			myState = States.key;
		}
	}
	
	void state_room_Key()
	{
		text.text = "You awake inside what appears to be an ancient Aztec temple. " +
					"You realise quickly that making the wrong move will cost you your life. " + 
					"You inspect your surroundings. You are in a room with only a torch for light. " +
					"The door blocking your exit seems to be made of stone with a big wooden lock. " +
					"Under you, you can see a little ornate box which is closed.\n\n" + 
					"Press B to view the ornate Box.\n"  +
					"Press T to view the Torch.\n" +
					"Press D to view the Door.\n";
		
		if(Input.GetKeyDown(KeyCode.B))
		{
			myState = States.box;
		}
		else if(Input.GetKeyDown(KeyCode.T))
		{
			myState = States.torch;
		}
		else if(Input.GetKeyDown(KeyCode.D))
		{
			if(keyInv == true && torchInv == true)
			{
				myState = States.door_Both;
			}
			else if(keyInv == false && torchInv == true)
			{
				myState = States.door_Torch;
			}
			else if(keyInv == true && torchInv == false)
			{
				myState = States.door_Key;
			}
			else if(keyInv == false && torchInv == false)
			{
				myState = States.door0;
			}
			
		}
		
	}
	
	void state_room_Torch()
	{
		text.text = "You inspect your surroundings. The door blocking your exit seems to be made of stone with a big wooden lock. " +
			"Under you, you can see a little ornate box which is closed and a golden key.\n\n" + 
				"Press B to view the Box.\n"  +
				"Press K to view the Key.\n" +
				"Press D to view the Door.";
		
		if(Input.GetKeyDown(KeyCode.B))
		{
			myState = States.box;
		}
		else if(Input.GetKeyDown(KeyCode.D))
		{
			if(keyInv == true)
			{
				myState = States.door_Both;
			}
			else if(keyInv == false)
			{
				myState = States.door_Torch;
			}
		}
		else if(Input.GetKeyDown(KeyCode.K))
		{
			myState = States.key;
		}
	}
	
	void state_room_Both()
	{
		text.text = "You inspect your surroundings. The door blocking your exit seems to be made of stone with a big wooden lock. " +
					"Under you, you can see a little ornate box which is closed.\n\n" + 
					"Press B to view the Box.\n"  +
					"Press D to view the Door.";
		
		if(Input.GetKeyDown(KeyCode.B))
		{
			print ("B PRESSED");
			myState = States.box;
		}
		else if(Input.GetKeyDown(KeyCode.D))
		{
			print("D PRESSED");
			myState = States.door_Both;
		}
	}
	
	void state_box()
	{
		text.text = "You inspect the box. It appears to be incredibly old and important. " +
					"The wood of the box is a deep scarlet and the edging is made of gold. " +
					"Along the top edge the inscription reads: \n\n " +
					"'The Soul of the Witchdoctor of Chichen Itza'\n\n" +
					"Press O to Open the box.\n" +
					"Press P to Put it down again.";
					
		if(Input.GetKeyDown(KeyCode.O))
		{
			myState = States.box_Death;
		}
		else if(Input.GetKeyDown(KeyCode.P))
		{
			if(keyInv == true && torchInv == true)
			{
				myState = States.room_Both;
			}
			else if(keyInv == false && torchInv == true)
			{
				myState = States.room_Torch;
			}
			else if(keyInv == true && torchInv == false)
			{
				myState = States.room_Key;
			}
			else if(keyInv == false && torchInv == false)
			{
				myState = States.room1; 
			}
		}
	}
	
	void state_box_Death()
	{
		text.text = "You open the box...\n\n" +
					"Suddenly red mist pours out of the box, sweeping across the room. " +
					"It slowly fills the room, and you begin to choke. " +
					"You realise you have made a great mistake. You begin to drift off into a deep sleep. " +
					"The last thing you ever hear is:\n\n " +
					"'Finally... I am free agai...'\n\n" +
					"Press C to continue";
					
		if(Input.GetKeyDown (KeyCode.C))
		{
			myState = States.death;
		}
					
	}
	
	void state_death()
	{
		text.text = "Due to your own stupidity you managed to kill yourself.\n\n" +
					"Maybe Darwin was right about Natural Selection after all...\n\n" +
					"Press R to Restart";
					
		if(Input.GetKeyDown (KeyCode.R))
		{
			myState = States.room0;
		}
	}
	
	void state_key()
	{
		text.text = "You inspect the key. It is heavy, golden and has an inscription reading:\n\n" +
					"'HERD RINGER'\n\n" +
					"Press T to Take the key.\n" +
					"Press P to Put it back down.";
					
		if(Input.GetKeyDown(KeyCode.T))
		{
			keyInv = true;
			if(torchInv == false)
			{
				myState = States.room_Key;
			}
			else if(torchInv == true)
			{
				myState = States.room_Both;
			}
		}
		else if(Input.GetKeyDown(KeyCode.P))
		{
			if(torchInv == false)
			{
				myState = States.room1;
			}
			else if(torchInv == true)
			{
				myState = States.room_Torch;
			}
		}
	}
	
	void state_Torch()
	{
		text.text = "The wooden torch burns hot and bright. You fear you might burn yourself if you take it. " +
					"However it might prove useful if you actually want to escape. Do you take the risk?\n\n" +
					"Press T to Take the torch.\n" +
					"Press L to Leave it be.";
					
		if(Input.GetKeyDown(KeyCode.T))
		{
			torchInv = true;
			if(keyInv == false)
			{
				myState = States.room_Torch;
			}
			else if(keyInv == true)
			{
				myState = States.room_Both;
			}
		}
		else if(Input.GetKeyDown(KeyCode.L))
		{
			if(keyInv == false)
			{
				myState = States.room1;
			}
			else if(keyInv == true)
			{
				myState = States.room_Key;
			}
		}
	}
	
	void state_door0()
	{
		text.text = "The large stone door is imposing. You inspect further and notice the entire door is covered in tiny spikes. " + 
					"While the door is an odd shade of purple, the lock is clearly wooden. The lock has some sort of tiny inscription around it. " +
					"However lighting in the room is too dim to make it out.\n\n" +
					"Press P to try and Push the door open\n" +
					"Press R to Return to the rest of the room.";
					
		if(Input.GetKeyDown(KeyCode.P))
		{
			myState = States.door_Death;
		}
		else if(Input.GetKeyDown(KeyCode.R))
		{
			myState = States.room1;
		}
		
	}
	
	void state_door_Torch()
	{
		text.text = "The large stone door is imposing. You inspect further and notice the entire door is covered in tiny spikes. " + 
					"While the door is an odd shade of purple, the lock is clearly wooden. The lock has some sort of tiny inscription around it. " +
					"However lighting in the room is too dim to make it out.\n\n" +
					"Press P to try and Push the door open\n" +
					"Press L to Light up the lock with the torch so you can read the inscription.\n" +
					"Press R to Return to the rest of the room.";
		
		if(Input.GetKeyDown(KeyCode.P))
		{
			myState = States.door_Death;
		}
		else if(Input.GetKeyDown(KeyCode.L))
		{
			myState = States.door_Unlock;
		}
		else if(Input.GetKeyDown(KeyCode.R))
		{
			myState = States.room_Torch;
		}
	}
	
	void state_door_Unlock()
	{
		text.text = "As you lean in to read the inscription, the wooden lock catches the flame of the torch. " +
					"The lock burns brightly for a few seconds then fizzles out. The door swings freely open with a mighty creek.\n\n" +
					"Press C to Continue.";
					
		if(Input.GetKeyDown(KeyCode.C))
		{
			myState = States.false_freedom;
		}
				
	}
	
	void state_door_Key()
	{
		text.text = "The large stone door is imposing. You inspect further and notice the entire door is covered in tiny spikes. " + 
					"While the door is an odd shade of purple, the lock is clearly wooden. The lock has some sort of tiny inscription around it. " +
					"However lighting in the room is too dim to make it out.\n\n" +
					"Press P to try and Push the door open\n" +
					"Press U to try and Unlock the door using the Key\n" +
					"Press R to Return to the rest of the room.";
					
		if(Input.GetKeyDown(KeyCode.P))
		{
			myState = States.door_Death;
		}
		else if(Input.GetKeyDown(KeyCode.U))
		{
			myState = States.door_Locked;
		}
		else if(Input.GetKeyDown(KeyCode.R))
		{
			myState = States.room_Key;
		}
	}
	
	void state_door_Both()
	{
		text.text = "The large stone door is imposing. You inspect further and notice the entire door is covered in tiny spikes. " + 
					"While the door is an odd shade of purple, the lock is clearly wooden. The lock has some sort of tiny inscription around it. " +
					"However lighting in the room is too dim to make it out.\n\n" +
					"Press P to try and Push the door open\n" +
					"Press L to Light up the lock with the torch so you can read the inscription.\n" +
					"Press U to try and Unlock the door using the Key\n" +
					"Press R to Return to the rest of the room.";
		
		if(Input.GetKeyDown(KeyCode.P))
		{
			myState = States.door_Death;
		}
		else if(Input.GetKeyDown(KeyCode.U))
		{
			myState = States.door_Locked;
		}
		else if(Input.GetKeyDown(KeyCode.R))
		{
			myState = States.room_Both;
		}
		else if(Input.GetKeyDown(KeyCode.L))
		{
			myState = States.door_Unlock;
		}			
				
	}
	
	void state_door_Locked()
	{
		text.text = "You put the key in the lock, but it wont turn at all. " +
					"Clearly this Golden key is not for this Wooden lock...\n\n" +
					"Press R to return.";
		
		if (Input.GetKeyDown(KeyCode.R))
		{
			if(torchInv == true)
			{
				myState = States.door_Both;
			} 
			else if(torchInv == false)
			{
				myState = States.door_Key;
			}
		}
	}
	
	void state_door_Death()
	{
		text.text = "As you push the door, the spikes quickly pierce your hands. " +
					"You realise that the doors strange purple hue is poison...\n\n" +
					"Your vision begins to become blury and you start to get dizzy. " +
					"Soon enough you find it hard to breathe and slowly drop to the floor.\n\n" +
					"Finally everything goes dark.\n\n" +
					"Press C to Continue.";
					
		if(Input.GetKeyDown (KeyCode.C))
		{
			myState = States.death;
		}
	}
	
	void state_false_freedom()
	{
		text.text = "You step through the doorway, into freedom." +
					"Freedom should look like the sunshine, grass and the sky...\n" +
					"Freedom should not look like this... a long corridor, lined with torches...\n\n" +
					"You see you are only in a long, stone clad corridor\n" +
					"You are not free, you have only left your cell...\n\n" +
					"Press C to continue!";
					
		if(Input.GetKeyDown (KeyCode.C))
		{
			myState = States.corridor0;
		}
	}
	
	void state_corridor0()
	{
		text.text = "You survey the corridor you are now in. " +
					"To your left, a large, stone Aztec face is mounted on the wall. " +
					"On your right is a colourful mosaic depicting some sort of jungle. " +
					"At the end of the corridor, you can see a large painted wall with an engraving.\n\n" +
					"Press F to inspect the stone face.\n" +
					"Press M to inspect the Mosaic.\n" +
					"Press W to walk towards the wall at the end of the corridor.";
		if(Input.GetKeyDown (KeyCode.F))
		{
			if(keyInv == true)
			{
				myState = States.stone1;
			}
			else if(keyInv == false)
			{
				myState = States.stone0;
			}
		}
		else if(Input.GetKeyDown(KeyCode.M))
		{
			myState = States.mosaic;
		}
		else if(Input.GetKeyDown(KeyCode.W))
		{
			if (stoneFed == true)
			{
				myState = States.floor_Death;
			}
			else if(stoneFed == false)
			{
				myState = States.floor_Life;
			}
		}
	}
	
	void state_stone0()
	{
		text.text = "Before you mounted on the wall is a large aztec face chiseled out of stone. " +
					"It's eyes almost seem to glow and eerie yellow gold colour. " +
					"What stands out the most is its large gaping mouth. \n\n" +
					"Press H to put your Hand in the mouth of the face and check inside. " +
					"Press R to Return to the rest of the corridor";
					
		if(Input.GetKeyDown (KeyCode.H))
		{
			myState = States.face_Death;
		}
		else if(Input.GetKeyDown (KeyCode.R))
		{
			myState = States.corridor0;
		}
	}
	
	void state_stone1()
	{
		text.text = "Before you mounted on the wall is a large aztec face chiseled out of stone. " +
					"It's eyes almost seem to glow and eerie yellow gold colour. " +
					"What stands out the most is its large gaping mouth. " +
					"It is almost as if you could put anything in there.\n\n" +
					"Press H to put your Hand in the mouth of the face and check inside. \n" +
					"Press K to put your Key in the mouth of the face. \n" +
					"Press R to Return to the rest of the corridor";
					
		if(Input.GetKeyDown (KeyCode.H))
		{
			myState = States.face_Death;
		}
		else if(Input.GetKeyDown (KeyCode.K))
		{
			myState = States.face_Unlock;
		}
		else if(Input.GetKeyDown (KeyCode.R))
		{
			myState = States.corridor0;
		}
						
	}
	
	void state_face_Death()
	{
		text.text = "You push your hand into the mouth of the aztec face, hoping to feel for something useful. " + 
					"As you are searching, you hear a click. Suddenly some sort of stone block falls from inside the face. " +
					"Shock overcomes you, and you qucikly try and pull your hand out of the mouth. " + 
					"However you realise that only your arm has left the Aztec face, your hand is no longer there... " +
					"The loss of blood and the shock cause you to begin to pass out... How did it take off your hand?\n\n" +
					"Press C to Continue.";
					
		if(Input.GetKeyDown (KeyCode.C))
		{
			myState = States.death;
		}
	}
	
	void state_mosaic()
	{
		text.text = "The mosaic in front of you is incredible, it takes your breath away. " +
					"Full of reds, greens and yellows, its both bright and detailed. " +
					"What tweaks your interest are the three large symbols in the centre of the piece. \n" +
					"A large Horse with great yellow wings. \n" +
					"A wide Elephant painted in tones of red. \n" +
					"A long green Crocodile biting its tail. \n\n" +
					"Press R to Return";
		
		if (Input.GetKeyDown(KeyCode.R))
		{
			if(stoneFed == false)
			{
				myState = States.corridor0;
			}
			else if(stoneFed == true)
			{
				myState = States.corridor1;
			}
		}
	}
	
	void state_face_Unlock()
	{
		stoneFed = true;
		text.text = "You put your key into the face. You hear a low rumbling sound " +
					"As you look around you realise that somehow everything seems safer.\n\n" +
					"Press C to Continue.";
		
		if(Input.GetKeyDown(KeyCode.C))
		{
			myState = States.corridor1;
		}
	}
	
	void state_corridor1()
	{
		text.text = "You survey the corridor you are now in. " +
					"On your right is a colourful mosaic depicting some sort of jungle. " +
					"At the end of the corridor, you can see a large painted wall with an engraving.\n\n" +
					"Press M to inspect the Mosaic.\n" +
					"Press W to walk towards the painted wall at the end of the corridor.";
		
		if(Input.GetKeyDown(KeyCode.M))
		{
			myState = States.mosaic;
		}
		else if(Input.GetKeyDown(KeyCode.W))
		{
			if (stoneFed == true)
			{
				myState = States.floor_Death;
			}
			else if(stoneFed == false)
			{
				myState = States.floor_Life;
			}
		}
	}
	
	void state_floor_Death()
	{
		text.text = "You see the wall at the end of the corridor, and you begin to walk towards it. " +
					"You feel the stone below you begin to give way so you jump to the next one. " +
					"However this also begins to fall beneath you as well. You realise the entire floor has given way. " +
					"You fall and fall and fall, for what seems like a life time, until you hit something hard with a whack. \n\n" +
					"Press C to Continue.";
					
		if(Input.GetKeyDown(KeyCode.C))
		{
			myState = States.death;
		}
	}
	
	void state_floor_Life()
	{
		text.text = "You feel that the ground beneath you is firm and strong. " +
					"You continue apprehensively and eventually you reach the wall at the end. \n\n" +
					"Press C to Continue.";
		
		if(Input.GetKeyDown(KeyCode.C))
		{
			myState = States.wall;
		}
	}
	
	void state_wall()
	{
		text.text = "You approach the wall at the end of the corridor. " +
					"T
	}
	
	void state_wall_Death_Elephant()
	{
		
	}
	
	void state_wall_Death_Horse()
	{
	
	}
	
	void state_wall_Life()
	{
	
	}
	
	void state_freedom()
	{
	
	}
	
}
