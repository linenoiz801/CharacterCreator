# Character Creator
A simple D&D Style Character Creation program that will allow a user to build a character
profile and assign attributes. Once characters are created, they can then be assigned to a 
Team.

[Trello board](https://trello.com/b/ImMRm87i/blue-badge-agile-team-project)

## Create characters - give them physical and character attributes. 
## Balance their skills/traits by organizing teams for narrative purposes
## ----------------------------------------------------------------------

1) A user needs to be able to create a new character
	- Creating a new character will build an empty profile 
		* Character class is created, 200 OK returned (character/POST)

2) A user needs to be able to access an existing character
	- All existing characters can be viewed
		* Character list is created and returned (character/GET)
	- An individual character is returned
		* All attributes and characteristics are loaded from the database (character/GETById)

3) A user needs to be able to customize character's attributes
	- Physical attributes (height/weight)	[enum]
	- Skills (dex/agi/con)					[enum]
	- Race (elf/dwarf/human)				[enum]
	- Class (thief/mage/fighter)			[enum]
	- history (back story)					[string]
	- name									[string]
	- age									[int]
	
	* Character's attributes are saved to the database (character/PUT)
	* Only one record is updated	

4) A user needs to be able to save their character
	* All attributes and characteristics are saved to the database
	* Only one record is updated
	
5) A user needs to be able to create a new team
	- Creating a new team will build an empty team
		* team class is created, 200 OK returned (team/POST)		
		
8) A user needs to be able to view existing teams
	- All existing teams can be viewed
		* Team list is created a returned (team/GET)
	- A specific team can be viewed
		* A single Team class is returned (team/GETById)

6) A user needs to be able to assign a character to a team
	* A character is assigned to a team. (team/POSTCharacter)		

7) A user needs to be able to remove a character from a team
	* A character is removed from a team (team/DELETECharacter)

10) A user needs to be able to get paid in Doge coin whenever they level up
	- Adam will supply the funds to pay the user

