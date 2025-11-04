# Code quest
## About the project
Code quest is a basic CMD game aboout a Wizard training to beat a dungeon.
### Chapter 1: Training wizard path
In this chapter, you name and train your wizard.

Depending on the exp earned through the training, the wizard will get a specific rank.
### Chapter 2: The dungeon of the dragon RAMón the Mighty
Now that the wizard is trained, they must reach the dungeon's core.

There are 3 doors, and the wizard has 3 tries. If they fail, the dragon will throw the wizard out the dungeon.
### Chapter 3: Mine the loot
You've defeated the dragon and found a mine full of magical bitcoins!

Now you have 5 excavations to try to loot as much bits as possible. You can either get 5-50 bits or none.

If you get more then 200 bits, you'll get the golden CPU.

## Test game
*Menu*
|Case              | Expected                                               | Happened                                               |
|------------------|--------------------------------------------------------|--------------------------------------------------------|
|Not a number      | "Invalid input. Please enter a number between 0 and 3."| "Invalid input. Please enter a number between 0 and 3."|
|Not a valid number| "Invalid input. Please enter a number between 0 and 3."| "Invalid input. Please enter a number between 0 and 3."|
|Number 1          | Starts chapter 1                                       | Starts chapter 1                                       |
|Number 2          | Starts chapter 2                                       | Starts chapter 2                                       |
|Number 3          | Starts chapter 3                                       | Starts chapter 3                                       |
|Number 0          | Exits program                                          | Exits program                                          |
