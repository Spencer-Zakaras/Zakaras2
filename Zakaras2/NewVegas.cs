/********************************************************************
*** NAME : Spencer Zakaras
*** CLASS : CSc 346
*** ASSIGNMENT : 2
*** DUE DATE : 2/22/23
*** INSTRUCTOR : GAMRADT ***
*********************************************************************
*** DESCRIPTION : This file defines the NewVegas class including S.P.E.C.I.A.L traits associated with our class/charecter. it also defines two constructors, and two interface functions. This is for assignment 2 "New vegas Charecter".
********************************************************************/

namespace NewVegasNS; //in shared namespace
    public class NewVegas : IView //declare NewVegas Class & prepare to define IView functions
    {
        public Global.NameType Name{get;set;} //All Auto properties for NameType & S.P.E.C.I.A.L traits
        public int Strength{get;set;}
        public int Perception{get;set;}
        public int Endurance{get;set;}
        public int Charisma{get;set;}
        public int Intelligence{get;set;}
        public int Agility{get;set;}
        public int Luck{get;set;} //must seem like an 18 Carot Run of Bad Luck


        /********************************************************************
*** METHOD NewVegas ***
*********************************************************************
*** DESCRIPTION : This is the Copy Contructor of the NewVegas object ***
*** INPUT ARGS : original - NewVegas Object to copy ***
*** OUTPUT ARGS : N/A ***
*** IN/OUT ARGS : original ***
*** RETURN : N/A ***
********************************************************************/
        public NewVegas(NewVegas original) //copy constructor
        {
            Name = original.Name; //copy original values to new object
            Strength = original.Strength;
            Perception = original.Perception; //Truth is, the game was rigged from the start
            Endurance = original.Endurance;
            Charisma = original.Charisma;
            Intelligence = original.Intelligence;
            Agility = original.Agility;
            Luck = original.Luck;
        }



/********************************************************************
*** METHOD NewVegas ***
*********************************************************************
*** DESCRIPTION : This is the default value Contructor of the NewVegas object ***
*** INPUT ARGS : name, strength, perception, endurance, charisma, Intelligence, Agility, Luck - All of these properties have default values initialized ***
*** OUTPUT ARGS : N/A ***
*** IN/OUT ARGS : name, strength, perception, endurance, charisma, Intelligence, Agility, Luck
*** RETURN : N/A ***
********************************************************************/
        public NewVegas(Global.NameType name = Global.NameType.COURIER, int strength = 5, int perception = 5, int endurance = 5, int charisma = 5, int intelligence = 5, int agility = 5, int luck = 5) //default values constructor
        {
            Name = name; //set values to whatever passed in, else use default values
            Strength = strength; //hail Caesar
            Perception = perception;
            Endurance = endurance;
            Charisma = charisma;
            Intelligence = intelligence;
            Agility = agility;
            Luck = luck;

        }


        /********************************************************************
*** METHOD ViewH ***
*********************************************************************
*** DESCRIPTION : Horizontal Display of NewVegas Object name & S.P.E.C.I.A.L Traits ***
*** INPUT ARGS : N/A ***
*** OUTPUT ARGS : N/A ***
*** IN/OUT ARGS : N/A ***
*** RETURN : VOID ***
********************************************************************/
        void IView.ViewH()
        {
            Console.WriteLine("Name               Str            Perc           End            Char           Int            Agil          Luck");
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.WriteLine("{0,-10}         {1,-10}     {2,-10}     {3,-10}     {4,-10}     {5,-10}     {6,-10}     {7,-10}", this.Name, this.Strength, this.Perception, this.Endurance, this.Charisma, this.Intelligence, this.Agility, this.Luck);
        }


/********************************************************************
*** METHOD ViewV ***
*********************************************************************
*** DESCRIPTION : Vertical Display of NewVegas Object name & S.P.E.C.I.A.L Traits ***
*** INPUT ARGS : N/A ***
*** OUTPUT ARGS : N/A ***
*** IN/OUT ARGS : N/A ***
*** RETURN : VOID ***
********************************************************************/
        void IView.ViewV()
        {
            Console.WriteLine("Name:          {0}", this.Name);
            Console.WriteLine("Strength:      {0}", this.Strength);
            Console.WriteLine("Perception:    {0}", this.Perception);
            Console.WriteLine("Endurance:     {0}", this.Endurance);
            Console.WriteLine("Charisma:      {0}", this.Charisma);
            Console.WriteLine("Intelligence:  {0}", this.Intelligence);
            Console.WriteLine("Agility:       {0}", this.Agility);
            Console.WriteLine("Luck:          {0}", this.Luck);
        }
    }

    