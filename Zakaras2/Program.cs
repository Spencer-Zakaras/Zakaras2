﻿/********************************************************************
*** NAME : Spencer Zakaras
*** CLASS : CSC 346
*** ASSIGNMENT : 2
*** DUE DATE : 2/22/23
*** INSTRUCTOR : GAMRADT ***
*********************************************************************
*** DESCRIPTION : This is the program/main file. It is used for testing created classes, interfaces, etc. 
********************************************************************/
using NewVegasNS; //using shared namespace
NewVegas Charecter = new NewVegas(Global.NameType.RAIDER, 8); //create NewVegas charecter object
IView ViewV = Charecter; //create IView object(s)
IView guy = Charecter;
ViewV.ViewV(); //Call Vertical View Func
guy.ViewH(); //Call horizontal View Func