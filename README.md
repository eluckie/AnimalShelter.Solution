# Animal Shelter

#### By E. Luckie ☀️

#### A program for a faux animal shelter to track the animals in their facility based on animal type. 

## Technologies Used

* C#
* .NET 7.0
* EF Core 7.0
* MySQL Workbench
* LINQ
* HTML
* Markdown
* Git

## Description

A program for an animal shelter to track the animals in their facility based on animal type (such as cat or dog). Features to build out include those that let a shelter worker:

* Add types of animals to the system. type should be a column on the animals table. A type could be a cat, dog, bunny or any other animal.
* Add an animal to the system. An animal should have a name, date of admittance, and breed. When it gets added to the system, it should be added as a particular type.
* List animals by breed or type alphabetically.
* List animals starting with the ones who have been in the shelter the longest.

## Setup/Installation Requirements

1. Clone this repository to your desktop
2. In your computer's terminal, navigate to the production level of this directory called _**AnimalShelter**_
3. In the command line, run the command ``dotnet watch run`` to compile and execute the webpage in Development mode
* Optionally, you can run the command ``dotnet build`` to compile the program without running it

### Recreating the Database
1. Within the production level of this directory, called _**AnimalShelter**_, create a new file called **appsettings.json**
2. Input the following code into your _**appsettings.json**_ file
_**{ADD SCREENSHOT OF APPSETTINGS CODE}**_
* replace _[ YOUR-DB-NAME ]_ with the name of the database you just created in MySQL Workbench
* replace _[ YOUR-USER-HERE ]_ with your username for MySQL Workbench
* replace _[ YOUR-PASSWORD-HERE ]_ with your password for MySQL Workbench

### Flow Chart
_**{ADD SCREENSHOT OF FLOW CHART}**_

## Known Bugs

* No known bugs.

## Stretch Plans
* Create a Search() method in the Animal Shelter application. It should take the name of the animal as an argument and return any animals that match.
* Let users choose what properties to search by. For instance, this could be type or age of animal in the animal shelter application.
* Continue on to add update and delete functionality to your application.

## License

MIT License

Copyright (c) 2023 Luckie