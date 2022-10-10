﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string countryCode;
            decimal quotiti, price;
            {
                const string COUNTRY_CODES =
                    "Азербайджан (994) | Киргизяи (996) | Таджикистан (992)\n"+
                    "Армения     (374) | Латвия   (371) | Туркмения   (993)\n"+
                    "Беларусь    (375) | Литва    (370) | Узбекистан  (998)\n"+
                    "Грузия      (995) | Молдова  (373) | Украина     (380)\n"+
                    "Казахстан   (007) | Россия   (007) | Эстония     (372)\n"+
                    "------------------------------------------------------";
                Console.WriteLine(COUNTRY_CODES);
                Console.Write("Телефонный код страны: ");
                countryCode = Console.ReadLine();
                Console.Write("Количество плитки: ");
                string stringQuontiti = Console.ReadLine();
                quotiti = Convert.ToUInt32(stringQuontiti);

                Console.Write("Цена за 1 м.кв. плитки: ");
                string stringPrice = Console.ReadLine();
                price = Convert.ToUInt32(stringPrice);
            }
            decimal rate;
            {
                const string AZERBAIJAN_CODE = "994", ARMENIA_CODE = "374", BELARUS_CODE = "375",
                             GEORGIA_CODE = "995", KAZAKHSTAN_CODE = "007", KYRGYZSTAN_CODE = "996",
                             LATVIA_CODE = "371", LITHUANIA_CODE = "370", MOLDOVA_CODE = "373",
                             RUSSIA_CODE = "007", TAJIKISTAN_CODE = "992", TURKMENISTAN_CODE = "993",
                             UZBEKISTAN_CODE = "998", URKAINE_CODE = "380", ESTONIA_CODE = "372";
                if (countryCode == AZERBAIJAN_CODE)
                {
                    const decimal AZERBAIJAN_RATE = 1.07m;
                    rate = AZERBAIJAN_RATE;
                }
                else if (countryCode == ARMENIA_CODE)
                {
                    const decimal ARMENIA_RATE = .95m;
                    rate = ARMENIA_RATE;
                }
                else if (countryCode == BELARUS_CODE)
                {
                    const decimal BELARUS_RATE = 1m;
                    rate = BELARUS_RATE;
                }
                else if (countryCode == GEORGIA_CODE)
                {
                    const decimal GEORGIA_RATE = 0.94m;
                    rate = GEORGIA_RATE;
                }
                else if (countryCode == KAZAKHSTAN_CODE)
                {
                    Console.Write($"Казахстан? да/нет: ");
                    string KazIf = Console.ReadLine();
                    if (KazIf == "да")
                    {
                        const decimal KAZAKHSTAN_RATE = 0.79m;
                        rate = KAZAKHSTAN_RATE;
                    }
                    else if (KazIf == "нет")
                    {
                        const decimal RUSSIA_RATE = 1m;
                        rate = RUSSIA_RATE;
                    }
                    else
                    {
                        rate = 0;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Надо вводить да или нет: {KazIf}!");
                    }
                }
                else if (countryCode == KYRGYZSTAN_CODE)
                {
                    const decimal KYRGYZSTAN__RATE = 0.83m;
                    rate = KYRGYZSTAN__RATE;
                }
                else if (countryCode == LATVIA_CODE)
                {
                    const decimal LATVIA_RATE = 1.12m;
                    rate = LATVIA_RATE;
                }
                else if (countryCode == LITHUANIA_CODE)
                {
                    const decimal LITHUANIA_RATE = 1.12m;
                    rate = LITHUANIA_RATE;
                }
                else
                {
                    rate = 0;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Вы ввели несуществующий код: {countryCode}!");
                }
            }
            decimal tilePriceWithRate = price * rate;
            decimal cost = quotiti * tilePriceWithRate;
            decimal discount; // руб
            {
                decimal discountPersentage;
                {
                    bool discount20PctAvailabe, discoun50PctAvailable;
                    {
                        const decimal MIN_TILE_QTY_FOR_DISCOUNT_20_PCT = 500,
                                      MIN_TILE_QTY_FOR_DISCOUNT_50_PCT = 1000;// м.кв.
                        discount20PctAvailabe = quotiti >= MIN_TILE_QTY_FOR_DISCOUNT_20_PCT &&
                                                quotiti < MIN_TILE_QTY_FOR_DISCOUNT_50_PCT;
                        discoun50PctAvailable = quotiti >= MIN_TILE_QTY_FOR_DISCOUNT_50_PCT;
                    }
                    if (discount20PctAvailabe)
                    {
                        discountPersentage = 20; // %
                    }
                    else if (discoun50PctAvailable)
                    {
                        discountPersentage = 50;
                    }
                    else
                    {    
                        discountPersentage = 0;
                    }
                }
                discount = cost / 100 * discountPersentage;
            }
            decimal paymentAmount = cost - discount;
            {
                Console.WriteLine($"Цена с коэффицентом   : {tilePriceWithRate} руб.");
                Console.WriteLine($"Общая стоимость плитки: {cost} руб.");
                Console.WriteLine($"Скидка                : {discount} руб.");
                Console.WriteLine($"Сумма к оплате        : {paymentAmount} руб.");
            }
            Console.ReadKey();
        }
    }
}
