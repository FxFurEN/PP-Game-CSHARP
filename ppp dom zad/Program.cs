using Newtonsoft.Json;
using ppp_dom_zad;
using System;
using System.Reflection.Emit;
/////////////////////////////////////////////////////
Console.SetWindowSize(150, 30);

Quest_Message qm = new Quest_Message();

//RPGCharacter rpgc = new RPGCharacter("Валера",Race.Человек,Gender.М, 200,200);
//MageCharЫacter mc;

Map map = new Map();
int q1 = 0;
bool running = true;
while (running)
{
    Console.WriteLine("Добро пожаловать в игру:");
    Console.WriteLine("Выберите опцию:");
    Console.WriteLine("1 - Начать игру");
    Console.WriteLine("2 - Пропустить начало");
    Console.WriteLine("3 - Выйти");

    string input = Console.ReadLine();
    switch (input)
    {
        case "1":
            qm.BeginOfTheGame();
        link1:
            map.Bowerstone_map();
            Console.Write("\nКуда вы пойдете??\n1 - Выход из города\n2 - Рынок\n3 - Школа\n4 - Западная Часть Города\n5 - Южная Часть Города\n>>> ");
            int Plot_Baworstone = Convert.ToInt32(Console.ReadLine());

            switch (Plot_Baworstone)
            {
                case 1:
                    map.Bowerstone_map_go_ExitTown();
                link2:
                    qm.Quest_1(q1);
                    map.Quest_1_Map_World_goRosha(q1);
                    qm.Quest_1(q1 = 1);
                    qm.Quest_1(q1 = 2);
                    map.Quest_1_Map_World_goRosha(q1 = 1);
                    qm.Quest_1(q1 = 3);
                    qm.Quest_1(q1 = 4);
                    qm.Quest_1(q1 = 5);
                    map.Quest_1_Map_World_goRosha(q1 = 2);
                    qm.Quest_1(q1 = 6);
                    break;
                case 2:
                    map.Bowerstone_map_go_Shop();
                    qm.Shop();
                    Thread.Sleep(500);
                    goto link2;
                    break;
                case 3:
                    map.Bowerstone_map_go_Schooll();
                    qm.School_quest1();
                    qm.School_exit();
                    goto link2;
                    break;
                case 4:
                    map.Bowerstone_map_go_ZCB();
                    qm.ZCHB();
                    goto link2;
                    break;
                case 5:
                    map.Bowerstone_map_go_SouthBowerstone();
                    qm.SouthTown();
                    goto link2;
                    break;
            }
            break;
        case "2":
            goto link1;
            break;
        case "3":
            Console.WriteLine("Выход из игры...");
            running = false;
            break;
        default:
            Console.WriteLine("Некорректный выбор.");
            break;
    }
}


//int randPlayer = new Random().Next(5);
//RPGCharacter player = (RPGCharacter)rpgc[randPlayer].Clone();
//int randEnemy = new Random().Next(5);
//RPGCharacter enemy = (RPGCharacter)rpgc[randEnemy].Clone();
//if (randPlayer == randEnemy)
//{
//    randPlayer = new Random().Next(5);
//    player = (RPGCharacter)rpgc[randPlayer].Clone();
//    randEnemy = new Random().Next(5);
//    enemy = (RPGCharacter)rpgc[randEnemy].Clone();
//}
//while (player.CurrentHealth > 0 && enemy.CurrentHealth > 0)
//{

//    Console.WriteLine("{0}: здоровье {1}, опыт {2}", player.Name, player.CurrentHealth, player.EXP);
//    Console.WriteLine("{0}: здоровье {1}", enemy.Name, enemy.CurrentHealth);

//    Console.WriteLine("Выберите действие: 1 - атаковать, 2 - сбежать");
//    string choice = Console.ReadLine();

//    if (choice == "1")
//    {
//        Console.Clear();
//        int damage = player.Attack(enemy);
//        Console.WriteLine("{0} нанес {1} урона {2}", player.Name, damage, enemy.Name);

//    }
//    else if (choice == "2")
//    {
//        Console.Clear();
//        if (player.TryToEscape())
//        {

//            Console.WriteLine("{0} сбежал от {1}", player.Name, enemy.Name);
//            break;
//        }
//        else
//        {
//            Console.WriteLine("{0} не смог сбежать от {1}", player.Name, enemy.Name);
//        }
//    }
//    else
//    {
//        Console.WriteLine("Некорректный ввод");
//    }

//    int enemyDamage = enemy.Attack(player);
//    Console.WriteLine("{0} нанес {1} урона {2}", enemy.Name, enemyDamage, player.Name);
//}

//if (player.CurrentHealth <= 0)
//{
//    Console.WriteLine("Вы проиграли");
//}
//else
//{
//    Console.WriteLine("Вы победили");
//}


