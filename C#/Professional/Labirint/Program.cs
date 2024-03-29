﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Labirint
{
    enum SideVale
    {
        North,
        West,
        East,
        Sourth
    }
    internal class Program
    { 
        static void alt7()
        {

        }
        static void alt5()
        {
            Console.WriteLine("alt5");
        }
        static void m4()
        {
            Console.WriteLine();
        }
        static void a4()
        {
            Console.WriteLine();
        }
        static void m3()
        {
            Console.WriteLine();
        }
        static void alt3()
        {
            Console.WriteLine();
        }
        static void Main2()
        {
            Console.WriteLine("Main2");
        }
        static void MainShow()
        {
            Console.WriteLine("MainShow2");
        }
        static void Alt2()
        { System.Console.WriteLine("alt2"); }
        static void Alt()
        { System.Console.WriteLine("Alt"); }

        static void Show3()
        {
            Console.WriteLine("SHOW3");
        }
        static void Show2()
        { Console.WriteLine("Show2"); }
        static void ShowText()
        { Console.WriteLine("ShowText"); }
        static void SwitchRoom(ref int currentRoom, ref int nextRoom )
        {
            int prom = currentRoom;
            currentRoom = nextRoom;
            nextRoom = prom;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(typeof(SideVale));
            foreach (var item in Enum.GetValues(typeof(SideVale)))
            {
                Console.WriteLine(item);
            }
            MazeGame mazeGame = new MazeGame();
            var maze = mazeGame.CreateMaze();

            string way;
            string east = Direction.East.ToString();
            bool room1Done = false;
            //bool room2Done = false;
            int currentRoom = 1;
            int nextRoom = 2;

            //int numberRoom = 1;
            MapSite side;
            ShowText();
            while (true)
            {   
                if (room1Done == false) 
                {
                    //numberRoom = 1;
                    Console.WriteLine("Ты вошел в первую комнату");
                }
                room1Done = true;
                SideVale wayEnum = 0;

                bool isWayNotSelect = true;
                while (isWayNotSelect)
                {
                    way = Console.ReadLine().ToString();
                    switch (way.ToLower())
                    {
                        case "north":
                            wayEnum = SideVale.North;
                            isWayNotSelect = false;
                            break;
                        case "west":
                            wayEnum = SideVale.West;
                            isWayNotSelect = false;
                            break;
                        case "east":
                            wayEnum = SideVale.East;
                            isWayNotSelect = false;
                            break;
                        case "sourth":
                            wayEnum = SideVale.Sourth;
                            isWayNotSelect = false;
                            break;
                        default:
                            Console.WriteLine("неправильная команды");
                            break;
                    }
                }
                switch (wayEnum)
                {
                    case SideVale.North:
                        maze.RoomNo(currentRoom).GetSide(Direction.North).Enter();
                        side = maze.RoomNo(currentRoom).GetSide(Direction.North);
                        if (side is Door)
                        {
                            room1Done = true;
                            //numberRoom = 2;
                            SwitchRoom(ref currentRoom, ref nextRoom);
                            
                            Console.WriteLine($"Ты вошел в {currentRoom} комнату");
                        }
                        break;
                    case SideVale.West:
                        maze.RoomNo(currentRoom).GetSide(Direction.West).Enter();
                        side = maze.RoomNo(currentRoom).GetSide(Direction.West);
                        if (side is Door)
                        {
                            room1Done = true;
                            //numberRoom = 2;
                            SwitchRoom(ref currentRoom, ref nextRoom);
                            Console.WriteLine($"Ты вошел в {currentRoom} комнату");
                        }
                        break;
                    case SideVale.East:
                        maze.RoomNo(currentRoom).GetSide(Direction.East).Enter();
                        side = maze.RoomNo(currentRoom).GetSide(Direction.East);
                        if (side is Door)
                        {
                            room1Done = true;
                            //numberRoom = 2;
                            SwitchRoom(ref currentRoom, ref nextRoom);
                            Console.WriteLine($"Ты вошел в {currentRoom} комнату");
                        }
                        break;
                    case SideVale.Sourth:
                        maze.RoomNo(currentRoom).GetSide(Direction.South).Enter();
                        side = maze.RoomNo(currentRoom).GetSide(Direction.South);
                        if (side is Door)
                        {
                            room1Done = true;
                            //numberRoom = 2;
                            SwitchRoom(ref currentRoom, ref nextRoom);
                            Console.WriteLine($"Ты вошел в {currentRoom} комнату");
                        }
                        break;
                    default:
                        break;

                }
            }

            //Console.ReadKey();

        }
    }
}
