﻿using System;

namespace _15_Exception
{
    class EngineBase : IBaseEngine
    {
        bool engineIsDead = false;
        int currentSpeed = 0;
        int maxSpeed = 100;
        virtual public int MaxSpeed
        { 
            get { return maxSpeed; } 
        }

        public int Accelerate(int delta = 10)
        {
            // Если приращение скорости меньше нуля генерируем исключение.
            if (delta < 0)
            {
                throw new ArgumentOutOfRangeException("Для разгона, ускорение должно быть больше нуля.");
            }

            if (engineIsDead)
            {
                return 0;
            }
            else
            {
                currentSpeed += delta;
                // Если текущая скорость превышает максимально допустимую.
                if (currentSpeed > MaxSpeed)
                {
                    engineIsDead = true;
                    currentSpeed = 0;
                    Console.Title = "Текущая Скорость = " + currentSpeed;

                    EngineIsDeadException ex = new EngineIsDeadException("Двигатель перегрелся.");

                    // Устанавливаем гиперссылку связываемую с исключением.
                    ex.HelpLink = "http://www.CarsRace.com/errorService";

                    // Вставляем дополнительную информацию об ошибке.
                    ex.Data.Add("Время поломки   :", string.Format("Двигатель вышел из строя {0}", DateTime.Now));
                    ex.Data.Add("Причина поломки :", "Вы превысили допустимую скорость. Двигатель сгорел.");

                    throw ex;
                }
                else
                {
                    Console.Title = "Текущая Скорость = " + currentSpeed;
                    return currentSpeed;
                }
            }
        }
    }
}
