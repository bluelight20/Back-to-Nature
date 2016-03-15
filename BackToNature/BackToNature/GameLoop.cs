﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToNature
{
    public class GameLoop
    {
        Player player;


        private bool gameOver;

        public bool GameOver
        {
            get { return gameOver; }
        }

        public GameLoop(bool _gameOver)
        {
            player = new Player();

            gameOver = _gameOver;
            StartGame();
        }

        private void StartGame()
        {
            Console.WriteLine("Welcome to Back To Nature, a collaboration project between 2 people");
            Console.WriteLine("to learn how to program in C#");

            Console.WriteLine();

            Console.WriteLine("1.) Start new game \n2.) Load game\n3.) Exit");

            string input = Console.ReadLine();
            switch(input)
            {
                case "1":
                     EnterDetails();
                    break;
                case "2":
                    //do something
                    //de-serialize saved game data
                    break;
                case "3":
                    gameOver = true;
                    break;
                default:
                    Console.WriteLine("You suck! Keiko is awesome!!!");
                    break;
            }

        }

        private void EnterDetails()
        {
            Console.WriteLine("Please enter your name");

            string name = Console.ReadLine();

            player.SetName(name);

            Console.WriteLine("Please choose your Gender");
            Console.WriteLine("1.) Male \n2.) Female");

            string genderInput = Console.ReadLine();

            player.SetGender(genderInput);

            Console.Clear();

            Console.WriteLine("Hello there, " + player.Name + ". Welcome to our little town!\n");
            Console.WriteLine("Here are your details:\n\nYour name is: " + player.Name + "\nYou are a " + player.getGender() + "\nYou have " +
                player.getMoney() + " in your bank");



            //Console.WriteLine("Enter the tool that you want to have");
            //Console.WriteLine("1.) Sickle\n2.) Hoe\n3.) Pickaxe\n4.) Axe");

            //int toolsChoice = Int32.Parse(Console.ReadLine());

            //player.AddTool(toolsChoice);

            //Console.WriteLine("Select a tool to discard:");
            //player.DisplayTools();

            //int discardChoice = Int32.Parse(Console.ReadLine());
            //player.DiscardTool(discardChoice);

            //player.DisplayTools();

        }

    }
}