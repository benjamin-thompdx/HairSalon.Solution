# _Eau Claire's Salon Business Tracker_

#### _A C# MVC web application for managing employees and clients._, _Mar. 20, 2020_

#### By _**Benjamin Thom**_

## Description

_A web application for managing Eau Claire's Salon's employees and their respected clients._

## Project Specifications

| Behavior | Input | Output |
|---|:---:|:---:|
|User visits homepage and the application displays a welcome massage, a link to view all stylists, and a link to view all clients|User enters url into web browser: http://localhost:5000/|"Welcome to the Eau Claire's Salon Business Tracker!", View all stylists(http://localhost:5000/Stylists), View all clients(http://localhost:5000/Clients)|
|User clicks on "view all stylists" link and the application displays a list of stylists or if no stylists have been added yet the application will dsplay the following message: "No stylists have been added yet!" and two links: link #1 will allow the user to add a new stylist, and link #2 will route the user to the homepage|User clicks View all stylists link|"No stylists have been added yet!", Add new stylist(http://localhost:5000/Stylists/Create), Home(http://localhost:5000/)|User enters url into web browser: http://localhost:5000/|
|User clicks on "Add new stylist" and the application displays a new stylist form, a button to confirm details and add new stylist, and a link to show all stylists|Name:, Specialty:, Date_Hired:|"Bill Throngood", "Long & Curly Hair", "07/20/2009"|
|User fills out new stylist form, presses add new stylist button and is routed back to the stylists page where the can view all stylists, click on stylist for additonal details, or click on the "Home" link to return to the homepage|User clicks new stylist button|"Bill Throngood", Add new stylist(http://localhost:5000/Stylists/Create), Home(http://localhost:5000/)|
|User clicks on Stylist name to view additional details and the application displays stylist details and three links: link #1 routes user back to stylists page, link #2 routes user to edit stylist page, and link #3 routes user to delete stylist page|User clicks "Bill Throngood"|Name: "Bill Throngood", Specialty: "Long & Curly Hair", Date Hired: "07/20/2009", Back to stylists(http://localhost:5000/Stylists), Edit Stylist(http://localhost:5000/Stylists/Edit/9), Delete Stylist(http://localhost:5000/Stylists/Delete/9)|
|User clicks on "view all clients" link and the application displays a list of clients or if no clients have been added yet the application will dsplay the following message: "No clients have been added yet! Note: A stylist must be selected to add a new client" and two links: link #1 will allow the user to add a new stylist, and link #2 will route the user to the homepage|user clicks View all clients link|"No stylists have been added yet!", Add new stylist(http://localhost:5000/Clients/Create), Home(http://localhost:5000/)|
|User clicks on "Add new client" and the application displays a new client form, a button to confirm details and add new client, and a link to show all clients. NOTE: if user does not specify a stylist within the new client form, the entry will not be saved|Name:, Phone_Number:, Email:, Stylist:|"Tom Smith", "(775)544-2323", "Tom@mail.com", "Bill Throngood"|
|User fills out new client form, presses add new client button and is routed back to the clients page where the can view all clients or click on the "Home" link to return to the homepage|User clicks "Tom Smith"|Name: "Tom Smith", Phone_Number:"(775)544-2323", Email:"Tim@mail.com", Stylist:"Bill Throngood", Back to clients(http://localhost:5000/Clients), Edit Client(http://localhost:5000/Clients/Edit/9), Delete Stylist(http://localhost:5000/Clients/Delete/9)|

## Setup/Installation Requirements

_In Terminal:_

* Navigate to where you want this application to be saved, i.e.:
```cd desktop```
* Clone the file from GitHub with HTTPS
```git clone https://github.com/benjamin-thompdx/HairSalon.Solution.git```
* Open file in your preferred text editor
* On Mac: ```open -a {your text editor} HairSalon.Solution```
* On Windows: ```HairSalon.Solution```

_Download Manually:_

* Navigate to https://github.com/benjamin-thompdx/HairSalon.Solution.
* Click the green "Clone or Download" button.
* Click "Download ZIP".
* Click downloaded file to unzip.
* Open folder called "HairSalon.Solution".

_Install MySQL | MacOS:_

* Download the MySQL Community Server DMG File from [MySQL Community Server](https://dev.mysql.com/downloads/file/?id=484914)
* You can exit the mysql program by entering ```exit```.
* Download the MySQL Workbench DMG File from [MySQL Workbench](https://dev.mysql.com/downloads/file/?id=484391). (Use the No thanks, just start my download link.)
* Install MySQL Workbench to Applications folder.
* Open MySQL Workbench and select the ```Local instance 3306 server```. You will need to enter the password you set. (We used ```epicodus```.) If it connects, you're all set.

_Install MySQL | Windows 10:_

* Download the MySQL Web Installer from [MySQL Downloads](https://dev.mysql.com/downloads/file/?id=484919) (Use the No thanks, just start my download link.)
* You can exit the mysql program by entering ```exit```
* Add the MySQL environment variable to the System PATH. We must include MySQL in the System Environment Path Variable. This is its own multi-step process. Instructions here are for Windows 10:
  1. Open the Control Panel and visit System > Advanced System Settings > Environment Variables...
  2. Then select PATH..., click Edit..., then Add.
  3. Add the exact location of your MySQL installation, and click OK. (This location is likely ```C:\Program Files\MySQL\MySQL Server 8.0\bin```, but may differ depending on your specific installation.)
* Download the MySQL Workbench DMG File from [MySQL Workbench](https://dev.mysql.com/downloads/file/?id=484391). (Use the No thanks, just start my download link.)
* Open MySQL Workbench and select the ```Local instance 3306``` server (it may have a different name). You will need to enter the password you set (We used ```epicodus```). If it connects, you're all set.
 
 _MySQL Workbench Database Setup:_

  > CREATE DATABASE `benjamin_thom`;

  > USE `benjamin_thom`;
  
  > CREATE TABLE `stylists` ( 
      `StylistId` INT(11) PRIMARY KEY NOT NULL AUTO_INCREMENT, 
      `Name` VARCHAR(255) DEFAULT NULL,
      `Specialty` VARCHAR(255) DEFAULT NULL,
      `Date_Hired` VARCHAR(255) DEFAULT NULL
    );

  > CREATE TABLE `clients` (
      `ClientId` INT(11) PRIMARY KEY NOT NULL AUTO_INCREMENT,
      `Name` VARCHAR(255) DEFAULT NULL,
      `Phone_Number` VARCHAR(255) DEFAULT NULL,
      `Email` VARCHAR(255) DEFAULT NULL,
      `StylistId` INT(11) DEFAULT '0'
    );

_Note For Editors:_ 

* Download the .NET Core SDK [Software Development Kit](https://dotnet.microsoft.com/download)
* Open the .Net Core SDK file and install
* To confirm installation was successful, run the ```$ dotnet --version``` command in your terminal
* Install dotnet script, run the ```$ dotnet tool install -g dotnet-script``` command in your terminal
* Restart your terminal to complete installation, and run the ```$ dotnet run``` command to run application within your terminal - Note: To exit, simply press ```Ctrl + C```
* Open project's productions directory within your terminal ```$ cd HairSalon.Solution/HairSalon```
* Run the command ```> dotnet restore```
* Run the command ```> dotnet build``` 
* If build is successful, run the command ```> dotnet run```, if build failed, make necessary updates and repeat ```> dotnet restore``` followed by ```> dotnet build```

## Known Bugs

_No known bugs at this time._

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/benjamin-thompdx/HairSalon.Solution/issues) here on GitHub._

## Technologies Used

* _Git 2.23.0_
* _C# language_
* _.NET Core 2.2.106_
* _dotnet script 0.50.1_
* _VS Code 1.43.1_
* _Model-View-Controller(MVC) framework_
* _Create, Read, Update, Delete (CRUD) functionality_
* _MySQL 8.0.15_
* _MySQL Workbench 8.0.15_
* _Entity Framework Core 2.2.4_
* _Language-Integrated Query (LINQ)_
* _ASP.NET Razor_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Benjamin Thom_**
