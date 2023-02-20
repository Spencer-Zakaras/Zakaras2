/********************************************************************
*** NAME : Spencer Zakaras
*** CLASS : CSc 346 
*** ASSIGNMENT : 2
*** DUE DATE : 2/22/23
*** INSTRUCTOR : GAMRADT 
*********************************************************************
*** DESCRIPTION : This file declares two interface functions for vertical and horizontal view.
********************************************************************/

namespace NewVegasNS; //in shared namespace
public interface IView //declare interface object
{
    void ViewH(); //horizontal View Display, Defined in NewVegas.cs
    void ViewV(); //Vertical View Display, Defined in NewVegas.cs
}
