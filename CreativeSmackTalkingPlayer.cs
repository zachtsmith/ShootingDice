using System;
using System.Collections.Generic;
namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : SmackTalkingPlayer
    {
        public override string Taunt 
        { 
            get 
                {
                    int index = new Random().Next(0,3);
                    return TauntList[index];
                } 
        }
        
        public List<string> TauntList = new List<string>
        {
            "loser", 
            "you're slow", 
            "ray charles can code faster"
        } ; 
    }
}