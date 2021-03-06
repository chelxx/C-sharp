﻿using System;

namespace WizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("*** *** *** *** *** *** *** *** *** ***");
            Wizard hermione = new Wizard("Hermione");
            Wizard millicent = new Wizard("Millicent");
            hermione.heal();
            hermione.fireball(millicent);

            System.Console.WriteLine("*** *** *** *** *** *** *** *** *** ***");
            Ninja naruto = new Ninja("Naruto");
            Ninja sakura = new Ninja("Sakura");
            naruto.steal(sakura);
            naruto.get_away();

            System.Console.WriteLine("*** *** *** *** *** *** *** *** *** ***");
            Samurai masamune = new Samurai("Masamune");
            Samurai hattori = new Samurai("Hattori");
            hattori.death_blow(masamune);
            hattori.death_blow(masamune);
            masamune.meditate();
            System.Console.WriteLine(Samurai.how_many());
        }
    }
}
// Notes:
// #1: When do you want or not want to use VOID? NO RETURN USE VOID
// #2: Where do returns go??
// #3: What is base?