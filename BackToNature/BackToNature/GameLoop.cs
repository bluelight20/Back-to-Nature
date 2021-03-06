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
        private int choice;

        FieldSpace field = new FieldSpace();

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
            bool done = false;

            while(!done)
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

                Console.WriteLine("\n\nAre your details correct?\n1.) YES\n2.) NO");
                choice = Int32.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        FarmOptions();
                        done = true;
                        break;
                    case 2:
                        done = false;
                        break;
                }

                Console.Clear();
            }
        }

        private void FarmOptions()
        {
            Console.Clear();
            Console.WriteLine("Select the number corresponding to your choice\n");

            Console.WriteLine("1.) Go to field");
            Console.WriteLine("2.) Open tools inventory");
            Console.WriteLine("3.) Open items inventory");
            Console.WriteLine("4.) Character Info");

            choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    field.PrintMatrix();
                    OpenToolInventory();
                    break;
                case 2:
                    OpenToolInventory();
                    break;
                case 3:
                    Console.WriteLine("STILL YET TO ADD");
                    break;
                case 4:
                    OpenCharacterInfo();
                    break;
            }
        }

        private void OpenCharacterInfo()
        {
            Console.WriteLine("Name: " + player.Name);
            Console.WriteLine("Gender: " + player.getGender());
            Console.WriteLine("Stamina: " + player.Stamina);
            Console.WriteLine("Current tool equipped: " + player.getEquippedTool());
            Console.WriteLine("Current gold: " + player.getMoney());

            Console.WriteLine("\n\nReturn to Farm Options?\n1.) YES\n2.)NO");

            choice = Int32.Parse(Console.ReadLine());
            
            switch(choice)
            {
                case 1:
                    FarmOptions();
                    break;
                case 2:
                    OpenCharacterInfo();
                    break;
            }
        }

        private void SelectFieldSpace()
        {
            Console.Clear();
            Console.WriteLine("Current tool equipped: " + player.getEquippedTool() + "\n");

            field.PrintMatrix();

            Console.WriteLine("\nSelect a space from your field\n");

            Console.WriteLine("Enter row number");
            int row = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter column number");
            int column = Int32.Parse(Console.ReadLine());

            if (field.SelectSpace(row, column, player.getEquippedTool()))
            {
                player.UseTool(choice);
            }
            else
                OpenToolInventory();

            field.PrintMatrix();
        }

        private void OpenToolInventory()
        {
            Console.Clear();
            bool done = false;
            while(!done)
            {
                Console.WriteLine("Equip a tool\n");

                int toolCount = player.DisplayTools();

                choice = Int32.Parse(Console.ReadLine());

                if (choice < toolCount - 1)
                    player.EquipTool(choice);
                else
                    OpenToolInventory();
                    
                

                SelectFieldSpace();

                Console.WriteLine("\nWould you like to use this tool again?\n1.) YES\n2.) NO\n");

                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        done = false;
                        SelectFieldSpace();
                        break;
                    case 2:
                        done = true;
                        OpenToolInventory();
                        break;
                    default:
                        FarmOptions();
                        break;
                }
            }

        }

        private void TaskOptions()
        {
            Console.WriteLine("--------EMPTY FUNCTION---------");
        }

    }
}