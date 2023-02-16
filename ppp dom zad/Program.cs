using Newtonsoft.Json;
using ppp_dom_zad;
using System;
using System.Reflection.Emit;
/////////////////////////////////////////////////////
Console.SetWindowSize(150, 30);

Quest_Message qm = new Quest_Message();

RPGCharacter rpgc = new RPGCharacter("Валера",Race.Человек,Gender.М, 200,200);
//MageCharacter mc;



Map map = new Map();
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
            // Запрос имени персонажа
            Console.Write("Введите имя персонажа: ");
            string name = Console.ReadLine();

            // Запрос расы персонажа
            Console.Write("Введите расу персонажа (Человек, Дворф, Эльф, Гном): ");
            Race race = (Race)Enum.Parse(typeof(Race), Console.ReadLine());

            // Запрос пола персонажа
            Console.Write("Введите пол персонажа (М, Ж): ");
            Gender gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine());

            // Запрос максимального здоровья персонажа
            Console.Write("Введите максимальное здоровье персонажа: ");
            int maxHealth = Convert.ToInt32(Console.ReadLine());

            // Запрос текущего здоровья персонажа
            Console.Write("Введите текущее здоровье персонажа: ");
            int currentHealth = Convert.ToInt32(Console.ReadLine());

            RPGCharacter player = new RPGCharacter(name, race, gender, maxHealth, currentHealth);
            Console.WriteLine("Вы создали персонажа и игра начата!");
            Thread.Sleep(2000);
            qm.BeginOfTheGame();
            map.Bowerstone_map();
            Console.Write("\nКуда вы пойдете??\n>>> ");
            string Plot_Baworstone = Convert.ToString(Console.ReadLine());
            if (Plot_Baworstone == "Выход из города")
            {
                map.Bowerstone_map_go_ExitTown();
                qm.Quest_1();
                map.Quest_1_Map_World_goRosha();
            }
            // здесь можно добавить код для начала игры
            break;
        case "2":
            // Запрос имени персонажа
            Console.Write("Введите имя персонажа: ");
            name = Console.ReadLine();

            // Запрос расы персонажа
            Console.Write("Введите расу персонажа (Человек, Дворф, Эльф, Гном): ");
            race = (Race)Enum.Parse(typeof(Race), Console.ReadLine());

            // Запрос пола персонажа
            Console.Write("Введите пол персонажа (М, Ж): ");
            gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine());

            // Запрос максимального здоровья персонажа
            Console.Write("Введите максимальное здоровье персонажа: ");
            maxHealth = Convert.ToInt32(Console.ReadLine());

            // Запрос текущего здоровья персонажа
            Console.Write("Введите текущее здоровье персонажа: ");
            currentHealth = Convert.ToInt32(Console.ReadLine());

            player = new RPGCharacter(name, race, gender, maxHealth, currentHealth);
            Console.WriteLine("Вы создали персонажа и игра начата!");
            map.Bowerstone_map();
            Console.Write("\nКуда вы пойдете??\n>>> ");
            Plot_Baworstone = Convert.ToString(Console.ReadLine());
            if (Plot_Baworstone == "Выход из города")
            {
                map.Bowerstone_map_go_ExitTown();
                qm.Quest_1();
                map.Quest_1_Map_World_goRosha();
            }
            Console.WriteLine("Начало пропущено!");
            // здесь можно добавить код для пропуска начала игры
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


