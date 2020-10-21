using System;
using System.Collections.Generic;

namespace HerosLib
{
    #region old way of creating class members

    /*
    public class Hero
    {
        // default mod of members of a class is private
        /*int id; // value type => System.Int32
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id=value;
            }
        }

        public int Id{get;set;} // autonomous property
        public string name; // reference type

        // Constructor
        public Hero()
        {
            //id=1;
            name="Bombasto";
        }
        
        // snippect ctor + double <tab> key
        public Hero(int id, string name)
        {
            //this.id = id;
            Id = id;
            this.name = name;
        }
    }
    */
    #endregion
    #region Modern way of creating class member
    
    public class Hero
    {
            public int Id { get; set; }
            public string Name { get; set; }

            #region Arrays
            //public string[] superPowers = new string[10]; // 1-D
            //jagged array
            //public int[][] ja = new int[3][];
            #endregion

            //public static List<string> superPowers = new List<string>();

            public static Stack<string> superPowers = new Stack<string>(); // LIFO

            
            public static Dictionary<string, string> hideOuts = new Dictionary<string, string>(); 
            /*      <key, value>
                    key should be unique, values can be the same
            */
            public Hero()
            {
                // Stack code
                superPowers.Push("Strength");
                superPowers.Push("Fly");
                superPowers.Push("Invisibility");
                superPowers.Push("X-Ray");

                // Dictionary
                hideOuts.Add("Thor", "Asgard");
                hideOuts.Add("Batman", "Batcave");
                hideOuts.Add("Superman", "Fortress of Solitude");
                
                /* // List code
                superPowers.Add("Strength");
                superPowers.Add("Fly");
                superPowers.Add("Invisibility");
                superPowers.Add("X-Ray");
                */
            }
            
            /*
            public static List<string> GetSuperPowers()
            {
                return superPowers;
            }
            */
            public static IEnumerable<string> GetSuperPowers()
            {
                return superPowers;
            }

            public static void RemoveSuperPower(/*string superPower*/) // List Code
            {
                // List code
                /*
                if(superPowers.Contains(superPower))
                {
                    superPowers.Remove(superPower);
                }
                */
                superPowers.Pop();
            }

            public static void AddSuperPower(string superPower)
            {
                if(superPower != null && superPower != "")
                { 
                    // List code
                    //superPowers.Add(superPower);
                    
                    // Stack code
                    superPowers.Push(superPower);
                }
            }
    }
    #endregion
}
