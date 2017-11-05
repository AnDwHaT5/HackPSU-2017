/**
	*	Created by Avery A. Gambetti
	*	Name: Grade Tracker
	*	Purpose: To keeep track of the users grades and show progress.
	*	Created for HackPSU 11/4/17
*/
#include <iostream>
#include <string>
#include <vector>
#include "Utilities.h"
#include <fstream>
#include <direct.h>

using namespace std;

//The entry point to the program.
int main()
{
	struct stat st;
	start:
	cout << "Grade Tracker v1.0.0 Beta" << endl;
	cout << "Thank you for using the Grade Tracker." << endl;
	cout << "Will you be logging in or registering? (Acceptable Responses: login/register/exit)" << endl;
	cout << "Choice> ";
	//This variable represents the users choice.
	string choice;
	cin >> choice;
	choice = toLower(choice);
	//If the user types login at the prompt.
	if (choice == "login")
	{
		//Gathers the users credentials. 
		cout << "Username> ";
		string username;
		cin >> username;
		cout << "Password> ";
		string password;
		cin >> password;
		//Makes sure the Accounts folder has been generated.
		if (stat("Accounts", &st) != 0)
		{
			//Generates the Accounts folder.
			_mkdir("Accounts");
		}
		//Basically checks to see if the user's folder exists.
		if (!accountExists(username))
		{
			cout << "There is no account with that username. Consider registering an account.\n";
			system("pause");
			system("cls");
			goto start;
		}
		//If there is a user with that username.
		else
		{
			//Checks to see if the account has a password or not.
			//If the account does not have a password attached to it.
			string temp = readPassword(username);
			if (temp  == "")
			{
				cout << "Your account has no password. Enter a password> ";
				string newPassword;
				cin >> newPassword;
				//Saves the newly entered password.
				writePassword(username, newPassword);
			}
			//If the account DOES have a password attached to it.
			else
			{
				string filePass = readPassword(username);
				//Checks to see if the entered password meets the account password.
				//If the user enters the wrong password they go to the start.
				//If the user enters the correct password, they are sent below.
				if (filePass != password)
				{
					cout << "You entered an incorrecct password!\n";
					system("pause");
					system("cls");
					goto start;
				}
			}
		}
		//If the user enters a correct password or reinstates an account password.
		cout << "Account successfully verified. Welcome, " << username << "!" << endl;
		system("pause");
		system("cls");
		cout << "What would you like to do, " << username << "?" << endl;
		cout << "Valid options are view/add/remove/listsemesters/help/exit" << endl;
		cout << "Choice> ";


	}
	else
	//If the user chooses to register a new account.
	if (choice == "register")
	{
		registerNewUser();
		goto start;
	}
	else
	if (choice == "exit")
	{
		system("exit");
	}
	else
	{
		cout << "You have entered an incorrect input. Please try again." << endl;
		system("pause");
		system("cls");
		goto start;
	}
	system("pause");
}