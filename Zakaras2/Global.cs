/********************************************************************
*** NAME : Spencer Zakaras
*** CLASS : CSC 346
*** ASSIGNMENT : 2
*** DUE DATE : 2/22/23
*** INSTRUCTOR : GAMRADT ***
*********************************************************************
*** DESCRIPTION : This is the global class file, this is a static public class for the New Vegas Charecter Program. This file defines an enumerated data type called NameType which defines what the charecters name is
********************************************************************/

namespace NewVegasNS; //in shared namespace
    public static class Global //avalible to all files with shared namespace
    {
        public enum NameType //enumerated data type defined
        {
            COURIER,
            RAIDER,
            SHOPKEEPER,
            SOLDIER
       }
    }
