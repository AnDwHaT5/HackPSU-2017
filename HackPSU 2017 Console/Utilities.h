#pragma once

#include <string>
#include <algorithm>
#include <iostream>
#include <fstream>
#include <direct.h>

//Cyber security? Whats that? Clearly a myth.
//Writes the users password.
void writePassword(std::string username, std::string password)
{
	std::ofstream stream;
	stream.open("Accounts/" + username + "/password.txt");
	stream << password;
	stream.close();
}

bool accountExists(std::string username)
{
	struct stat st;
	std::string path = "Accounts/" + username;
	if (stat(path.c_str(), &st) != 0)
	{
		return false;
	}
	return true;
}

//Oh so very secure. If only hacking was this easy.
//I guess it is in this program since everything is plain text.
//Reads the users password.
std::string readPassword(std::string username)
{
	std::ifstream ifs;
	//Opens the password file.
	ifs.open("Accounts/" + username + "/password.txt");
	std::string filePass;
	ifs >> filePass;
	return filePass;
}

//Goes through the prompts to register a new user.
void registerNewUser()
{
	struct stat st;
	std::cout << "Please enter the username you would like to use> ";
	std::string username;
	std::cin >> username;
	std::string path = "Accounts/" + username;
	//Loops until the person chooses an untaken username.
	while (stat(path.c_str(), &st) == 0)
	{
		std::cout << "There is already a person with that username!" << std::endl;
		std::cout << "Please enter the username you would like to use> ";
		std::cin >> username;
	}
	std::cout << "Please enter your password> ";
	std::string password;
	std::cin >> password;
	//Saves the users password.
	_mkdir(path.c_str());
	writePassword(username, password);
	std::cout << "Your account has been created! Now login using your username and password.\n";
	system("pause");
	system("cls");
}
std::string toLower(std::string information)
{
	std::transform(information.begin(), information.end(), information.begin(), ::tolower);
	return information;
}