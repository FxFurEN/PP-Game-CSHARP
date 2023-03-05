﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ppp_dom_zad
{
    
    public class Quest_Message
    {
        public void BeginOfTheGame()
        {
            string bg_1 = "Ты переступаешь порог таверны и немедленно окунаешься в атмосферу тепла и уюта.\n" +
                "Камин, горящий в углу, создает уютное освещение и распространяет тепло по всему помещению.\n" +
                "Казалось бы, что здесь сгрудились все типы персонажей: от бродяг до благородных рыцарей и волшебников.\n" +
                "В углу за столом весело смеются группа гномов, в то время как несколько эльфов сидят за барной стойкой и наслаждаются изысканными напитками.\n" +
                "Твои глаза скользят по стенам, увешанным оружием и шкурами зверей.\nЧерез громкий шум толпы, ты слышишь приглушенный звук карабканья кухонной утвари и шуршание шкур.\n" +
                "Твой желудок начинает громко рычать, и ты осознаешь, что нуждаешься в чем-то сытном и вкусном." +
                "\nК тебе подходит официантка с карманами под глазами и улыбкой на лице, и говорит:\n" +
                "\"Что я могу для тебя сделать, странник?\"\n";
                for (int i = 0; i < bg_1.Length; i++)
                {
                    if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                    {
                        Console.Clear();
                        Console.Write(bg_1);
                        Thread.Sleep(2000);
                    break;
                    }
                    Console.Write(bg_1[i]);
                    Thread.Sleep(50); // задержка в 50 миллисекунд между символами
                }
            Console.Clear();
            string bg_2 = "Ты заказываешь блюдо и напиток, и официантка исчезает за дверью, ведущей на кухню.\n" +
                "В это время ты замечаешь,что на стене висит доска объявлений, на которой перечислены задания и приключения, доступные в этом районе.\n" +
                "Некоторые из них зовут на сокровищницы, другие - на охоту за опасными монстрами.\n" +
                "Вдали ты слышишь звук скрипучих дверей, которые открываются, и в таверну входят новые гости.\n" +
                "За столом возле камина, рыцарь в полном доспехе устраивает настольную игру с гномом,\n" +
                "тогда как за соседним столом группа путешественников, обмениваются рассказами о своих приключениях.\n" +
                "Твои мысли вновь перенаправляются к своим заданиям, и ты начинаешь рассматривать объявления на доске,пытаясь выбрать следующую миссию.\n" +
                "В этот момент официантка возвращается с твоим заказом, и ты наслаждаешься вкусным блюдом,\nобщением с новыми друзьями и атмосферой таверны," +
                "которая, кажется, наполнена возможностями и приключениями.\n";
            for (int i = 0; i < bg_2.Length; i++)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                    Console.Write(bg_2);
                    Thread.Sleep(2000);
                    break;
                }
                Console.Write(bg_2[i]);
                Thread.Sleep(50); // задержка в 50 миллисекунд между символами
            }

            Console.Clear();
            string bg_3 = "После небольшой трапезы, вы замечаете темную личность одетою в черную мантию, которая направляется к вам\n" +
                "Ты ощущаешь легкую дрожь, когда незнакомец садится рядом с тобой за столик, пока ты наслаждаешься трапезой в таверне.\n" +
                "Незнакомец скрыт в капюшоне, но ты можешь видеть, что он неоднократно оглядывается по сторонам, прежде чем обратить свое внимание на тебя.\n" +
                "\"Простите меня, но я ищу помощи. Я искал кого-то, кто бы мог выполнить задание, но я не нашел его. Но теперь, я нашел тебя.\n" +
                "Ты выглядишь сильным и опытным путешественником, который может выполнить задание\",- говорит незнакомец, наклонившись к тебе и говоря тихим шепотом.\n" +
                "\"Мне нужно, чтобы ты убил монстра обитающий в местных лесах. Я заплачу тебе щедро за это задание.\n" +
                "Откажешься от меня, и я уйду, но я был бы весьма благодарен, если бы ты согласился мне помочь\", - продолжает незнакомец.\n" +
                "Твой внутренний голос говорит тебе, что это задание может быть опасным и трудным, но ты также знаешь, что деньги могут быть весьма привлекательными.\nКак бы ты поступил в этой ситуации?\n";
            for (int i = 0; i < bg_3.Length; i++)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                    Console.Write(bg_3);
                    Thread.Sleep(2000);
                    break;
                }
                Console.Write(bg_3[i]);
                Thread.Sleep(50); // задержка в 50 миллисекунд между символами
            }

            Console.Clear();
            string bg_4 = "Ты внимательно изучаешь незнакомца в капюшоне, пытаясь понять, насколько ему можно доверять.\n" +
                "Но у тебя нет оснований отвергнуть его предложение, поскольку ты - опытный путешественник и убийство монстра - одно из твоих повседневных дел.\n" +
                "\"Я могу выполнить ваше задание, но прежде чем я соглашусь, мне нужно знать больше о монстре, чтобы подготовиться к этому заданию\",\n - отвечаешь ты, сохраняя спокойный тон.\n" +
                "Незнакомец, слегка улыбнувшись, говорит: \"Я могу рассказать тебе о монстре и дать тебе карту, которая поможет тебе найти его логово.\n" +
                "Но я должен предупредить, что монстр довольно опасен и может напасть на тебя, если ты не будешь осторожен\".\nТы соглашаешься на задание и принимаешь карту и оплату от незнакомца.\n" +
                "Он благодарит тебя и уходит, и ты начинаешь готовиться к опасному заданию, зная, что успех позволит тебе получить не только деньги,\n но и репутацию среди других путешественников.\n";
            for (int i = 0; i < bg_4.Length; i++)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                    Console.Write(bg_4);
                    Thread.Sleep(2000);
                    break;
                }
                Console.Write(bg_4[i]);
                Thread.Sleep(50); // задержка в 50 миллисекунд между символами
            }

            Console.Clear();
            string bg_5 = "Ты завершаешь свой обед и покидаешь таверну, выйдя из таверны вы наблюдаете виды небольшого города." +
                "\nПеред путешествием вы решаетесь подойти к стенду с картой города, чтобы  более подробно изучить его.";
            for (int i = 0; i < bg_5.Length; i++)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                    Console.Write(bg_5);
                    Thread.Sleep(2000);
                    break;
                }
                Console.Write(bg_5[i]);
                Thread.Sleep(50); // задержка в 50 миллисекунд между символами
            }
            Thread.Sleep(2000);

        }

        public void ZCHB()
        {
            string zchb = "Вы подходите к Воротам Западной части города. Перед вами стоит охраник который косо смотрит на вас , когда вы приближаетесь к нему. " +
                "Он держит руку на рукояти своего меча и выглядит настороженным.\r\n\r\n\"Стойте! Куда вы направляетесь?\" - спрашивает он вас, смотря на вас внимательно.\r\n\r\n" +
                "Вы объясняете ему, что хотите пройти через Ворота Западной части города, чтобы добраться до своей цели.\r\n\r\nОхранник посмотрел на вас подозрительно и начал задавать ряд вопросов, чтобы убедиться, что вы не представляете угрозы для города.\n" +
                "Вы отвечаете на все его вопросы, стараясь убедить его, что вы честный человек.\r\n\r\n- Я о тебе ничего не знаю, для меня ты все еще подозрительный. Приходи когда ты станешь более популярным.\n" +
                "Вам ничего остается делать и вы разворачиваетесь, и направляетесь к выходу с города";
            for (int i = 0; i < zchb.Length; i++)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                    Console.Write(zchb);
                    Thread.Sleep(2000);
                    break;
                }
                Console.Write(zchb[i]);
                Thread.Sleep(50); // задержка в 50 миллисекунд между символами
            }
        }

        public void Shop()
        {
            Console.Clear();
            string sh = "Вы подходите к рынку, где толпа народа толкается между прилавками, выбирая продукты." +
                "Вдалеке вы слышите крики торговцев, которые пытаются привлечь внимание потенциальных покупателей к своим товарам.\r\n\r\nПройдя мимо нескольких лавок, вы замечаете странного старика, который сидит на скамейке и продает свои странные изделия." +
                "Он улыбается вам и предлагает заглянуть в его торговую лавку.\r\n\r\nВойдя внутрь, вы видите, что лавка наполнена магическими предметами, книгами и зельями." +
                "Старик говорит, что он может помочь вам в вашем приключении и предлагает купить несколько своих товаров.\r\n\r\nВы вспоминаете о задании, которое вы взяли у того странного странника, и решаете посмотреть, что он может предложить. Вы покупаете зелья лечения, свитки заклинаний и магические кристаллы, которые могут помочь в битве." +
                "\r\n\r\nПосле того, как вы закончили покупки, старик говорит, что видит вам судьбу героя и предлагает свою помощь в будущих заданиях. Вы благодарите его и уходите из лавки, готовые к новым приключениям в этом мире магии и опасностей.";
            string sh1 = "После того как вы сходили на рынок вы решили сразу же отправится на задание";
            for (int i = 0; i < sh.Length; i++)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                    Console.Write(sh);
                    Thread.Sleep(2000);
                    break;
                }
                Console.Write(sh[i]);
                Thread.Sleep(50); // задержка в 50 миллисекунд между символами
            }
            Thread.Sleep(2000);
            for (int i = 0; i < sh1.Length; i++)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                    Console.Write(sh1);
                    Thread.Sleep(2000);
                    break;
                }
                Console.Write(sh1[i]);
                Thread.Sleep(50); // задержка в 50 миллисекунд между символами
            }
        }

        public void SouthTown()
        {
            Console.Clear();
            string l_1 = "Вы приблизились к охраннику, который стоял у входа в южную часть города. Он был высоким и мускулистым, в руках держал огромный меч." +
                "\nКогда вы прошли к нему, он вас остановил и сказал: \"Стой, куда ты идешь?\"\r\n\r\nВы ответили ему, что вам нужно пройти в южную часть города." +
                "\nОхранник нахмурился и ответил: \"Это невозможно. Южная часть города закрыта для посетителей.Доступ к этой части города только по приглашению." +
                "\nВернись, откуда пришел\"." +
                "\nВам ничего не осталось как просто уйти оттуда.Вы решили не ждать с моря погоды и отправились выполнять задание которе вам дал странник";
            for (int i = 0; i < l_1.Length; i++)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                    Console.Write(l_1);
                    Thread.Sleep(2000);
                    break;
                }
                Console.Write(l_1[i]);
                Thread.Sleep(50); // задержка в 50 миллисекунд между символами
            }
        }
        public void School_exit()
        {
            Console.Clear();
            string q_1 = "Вы вышли со школы.И решили отправится на задание которок вам дал странник.";
            for (int i = 0; i < q_1.Length; i++)
            {
                Console.Write(q_1![i]);
                Thread.Sleep(50); // задержка в 50 миллисекунд между символами
            }
        }
        public void Quest_1(int q1)
        {
            
            Console.Clear();
            string q_1 = "Вы вышли из города.И направились по карте в поисках монстра\n";

            string q_2 = "Cледуя за указанным маршрутом, который должен был привести вас к месту обитания опасного монстра." +
                "\nПосле нескольких дней путешествия вы оказались в густой темной роще, которая выглядела очень зловеще." +
                "\r\n\r\nВы были уверены, что монстр находится где-то внутри этой рощи. Однако, как только вы ступили на первый шаг внутрь, вы почувствовали,что что-то не так." +
                "\nВоздух был холодным и сырым, и весь лес казался окутанным мрачной атмосферой." +
                "\r\n\r\nВы продолжали свой путь внутри рощи, в поисках монстра, который мог быть где-то совсем рядом." +
                "\nВы столкнулись с некоторыми препятствиями, такими как различные ловушки и опасные звери, но вы продолжали двигаться вперед, несмотря на все трудности." +
                "\r\n\r\nПосле долгих поисков вы наконец нашли монстра. Он был гораздо больше и опаснее, чем вы ожидали. Вы бросились в бой";

            string q_3 = "Бой был жестоким и непредсказуемым, но в конце концов вы одержали победу.По итогу вы решили немного отдохнуть. Развели костер, достали приписы и начали обедать." +
                "\nВокруг было тихо и спокойно, но вы чувствовали, что это только временное умиротворение." +
                "\r\n\r\nВы понимали, что всегда будете сталкиваться с новыми вызовами и опасностями в своих приключениях." +
                "\nПоэтому вы не расслаблялись и продолжали тренироваться и совершенствоваться, чтобы быть готовыми к любым испытаниям." +
                "\r\n\r\nПосле короткого отдыха вы отрубили голову монстра, обернули ее в бумагу, закинули на плечо и пошли в сторону к выходу с темной рощи.";

            string q_4 = "Выйдя с темной рощи, вы замечаете как к вам направляется разбойник." +
                "\nВы сразу же готовы к бою и вынимаете свою оружие. Разбойник замечает, что вы не такие, как остальные путешественники, и начинает отступать." +
                "\nВы решаете не преследовать его и продолжаете свой путь." +
                "\r\n\r\nОднако, вы понимаете, что вам нужно быть более осторожным, так как путешественники и разбойники не являются единственными опасностями в этих местах." +
                "\nВы продолжаете свой путь, не теряя бдительности и готовности к бою." +
                "\r\n\r\nСпустя некоторое время, вы натыкаетесь на загадочный храм. Вы решаете исследовать его и войти внутрь. Внутри храма вы обнаруживаете свиток с 3 загадками." +
                "\r\n\r\nВы решаете забрать свиток с собой и продолжаете свое путешествие. Однако, вы чувствуете, что таинственные силы начинают притягивать вас к храму." +
                "\nВы понимаете, что вы должны вернуться в храм и разгадать тайну свитка.";

            string q_5 = "Приближаясь к храму, вы замечаете, что вокруг начинают появляться тени, которые кажутся живыми и опасными. Вы понимаете, что это могут быть призраки, и решаете быть готовыми к бою." +
                "\r\n\r\nВойдя в храм, вы начинаете исследовать его глубины и обнаруживаете, что свиток является ключом к открытию тайной двери, которая приведет вас к могущественному артефакту.";

            string q_6 = "Вы видите перед собой три двери. На каждой двери написано число и рисунок свитка.Вы решаете раскрыть свиток и узнать что-то там написано.\n" +
                "\nРаскрыв свиток вы видите 3 загадки:" +
                "\n1.Первая дверь: 'Я всегда иду, но никогда не бегу. Я имею рот, но никогда не говорю. Что я?'" +
                "\n2.Вторая дверь: 'Я есть вещь, которую вы можете разорвать или сломать, но я всегда останусь целой. Что это?'" +
                "\n3.Третья дверь: 'Я начинаю утро, заканчиваю вечером, но появляюсь только тогда, когда солнце заходит. Что это?'";
           
            string q_6_1_1 = "К сожалению, вы не смогли отгадать загадоку и это привело к тому, что дверь не открылась. На стенах храма загорелся красный свет, и вы почувствовали, что что-то необычное происходит." +
                "\nИз глубин храма начали появляться тени, которые медленно приближались к вам. Вы попытались убежать, но было уже слишком поздно - тени настигли вас и вы погрузились во тьму.";

            string q_6_2 = "Вы подходите к первой двери и произносите свой ответ. Дверь начинает медленно открываться, показывая вам проход дальше";

            string q_6_3 = "Вы говорите свой ответ, и третья дверь начинает медленно открываться.";

            string q_6_4 = "Вы проходите сквозь третью дверь и оказываетесь внутри храма. Вы видите перед собой артефакт - это могущественный кристалл, который сияет ярким светом." +
                "\nВы подходите к нему и осторожно берете в руки. Вы чувствуете, как власть и магия пронизывают вас.";

            string q_8 = "Вы успешно прошли все три загадки и двери открылись перед вами. Вы входите в большую комнату и видите перед собой магический кристалл, который вы искали." +
                "\nОн сияет красивым ярким светом, и вы осторожно берете его в руки. Вы чувствуете мощь и энергию, которые исходят от кристалла, и понимаете, что он действительно очень могущественный." +
                "\r\n\r\nВы тщательно обернули кристалл и положили его в свой рюкзак, затем направились к выходу из храма. Все было тихо и спокойно, никаких ловушек или опасностей, только загадки, которые вам удалось успешно разгадать." +
                "\nВы покинули храм и отправились в город.";


            if (q1 == 0)
            {
                for (int i = 0; i < q_1.Length; i++)
                {
                    Console.Write(q_1![i]);
                    Thread.Sleep(50); // задержка в 50 миллисекунд между символами
                }
            }
            if (q1 == 1)
            {
                for (int i = 0; i < q_2.Length; i++)
                {
                    if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                    {
                        Console.Clear();
                        Console.Write(q_2);
                        Thread.Sleep(2000);
                        break;
                    }
                    Console.Write(q_2[i]);
                    Thread.Sleep(50); // задержка в 50 миллисекунд между символами
                }
            }
            if (q1 == 2)
            {
                for (int i = 0; i < q_3.Length; i++)
                {
                    if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                    {
                        Console.Clear();
                        Console.Write(q_3);
                        Thread.Sleep(2000);
                        break;
                    }
                    Console.Write(q_3[i]);
                    Thread.Sleep(50); // задержка в 50 миллисекунд между символами
                }
            }
            if (q1 == 3)
            {
                for (int i = 0; i < q_4.Length; i++)
                {
                    if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                    {
                        Console.Clear();
                        Console.Write(q_4);
                        Thread.Sleep(2000);
                        break;
                    }
                    Console.Write(q_4[i]);
                    Thread.Sleep(50); // задержка в 50 миллисекунд между символами
                }
            }
            if (q1 == 4)
            {
                for (int i = 0; i < q_5.Length; i++)
                {
                    if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                    {
                        Console.Clear();
                        Console.Write(q_5);
                        Thread.Sleep(2000);
                        break;
                    }
                    Console.Write(q_5[i]);
                    Thread.Sleep(50); // задержка в 50 миллисекунд между символами
                }
            }
            if (q1 == 5)
            {
                for (int i = 0; i < q_6.Length; i++)
                {
                    if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                    {
                        Console.Clear();
                        Console.Write(q_6);
                        Thread.Sleep(2000);
                        break;
                    }
                    Console.Write(q_6[i]);
                    Thread.Sleep(50); // задержка в 50 миллисекунд между символами
                }
                Console.Write("\n1. >>> ");
                string zagadka1 = Convert.ToString(Console.ReadLine());
                if (zagadka1 == "Часы" || zagadka1 == "часы")
                {
                    for (int i = 0; i < q_6_2.Length; i++)
                    {
                        Console.Write(q_6_2[i]);
                        Thread.Sleep(50); // задержка в 50 миллисекунд между символами
                    }
                }
                else
                {
                    for (int i = 0; i < q_6_1_1.Length; i++)
                    {
                        if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                        {
                            Console.Clear();
                            Console.Write(q_6_1_1);
                            Thread.Sleep(2000);
                            break;
                        }
                        Console.Clear();
                        Console.Write(q_6_1_1[i]);
                        Thread.Sleep(50); // задержка в 50 миллисекунд между символами
                    }
                    Console.Write("\n\nВы мертвы");
                    Process.GetCurrentProcess().Kill();
                }
                Console.Write("\n2. >>> ");
                string zagadka2 = Convert.ToString(Console.ReadLine());
                if (zagadka2 == "Тишина" || zagadka2 == "тишина")
                {
                    for (int i = 0; i < q_6_3.Length; i++)
                    {
                        Console.Write(q_6_3[i]);
                        Thread.Sleep(50); // задержка в 50 миллисекунд между символами
                    }
                }
                else
                {
                    for (int i = 0; i < q_6_1_1.Length; i++)
                    {
                        if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                        {
                            Console.Clear();
                            Console.Write(q_6_1_1);
                            Thread.Sleep(2000);
                            break;
                        }
                        Console.Clear();
                        Console.Write(q_6_1_1[i]);
                        Thread.Sleep(50); // задержка в 50 миллисекунд между символами
                    }
                    Console.Write("\n\nВы мертвы");
                    Process.GetCurrentProcess().Kill();
                }
                Console.Write("\n3. >>> ");
                string zagadka3 = Convert.ToString(Console.ReadLine());
                if (zagadka3 == "Тень" || zagadka3 == "тень")
                {
                    Console.Clear();
                    for (int i = 0; i < q_6_4.Length; i++)
                    {
                        
                        Console.Write(q_6_4[i]);
                        Thread.Sleep(50); // задержка в 50 миллисекунд между символами
                    }
                }
                else
                {
                    for (int i = 0; i < q_6_1_1.Length; i++)
                    {
                        if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                        {
                            Console.Clear();
                            Console.Write(q_6_1_1);
                            Thread.Sleep(2000);
                            break;
                        }
                        Console.Clear();
                        Console.Write(q_6_1_1[i]);
                        Thread.Sleep(50); // задержка в 50 миллисекунд между символами
                    }
                    Console.Write("\n\nВы мертвы");
                    Process.GetCurrentProcess().Kill();
                }

            }
            if (q1 == 6)
            {

            }
        }

        public void School_quest1()
        {
            int vb = 0;
            Console.Clear();
            string scq_1 = "Вы подходите к школе для детей-сирот, которая выглядит довольно скромно, но ухоженно.\nНекоторые из детей играют во дворе, бегают, ловят мячи, кричат и смеются." +
                "\nВнутри здания находится главный офис школы, где вы можете встретиться с директором или другими сотрудниками.\r\n\r\nДиректор школы, Миссис Хьюз, приветствует вас и объясняет, что школа была основана для обучения и заботы о детях-сиротах." +
                "\nОна также говорит, что на данный момент школа нуждается в вашей помощи. Один из учителей, Мистер Харрисон, пропал в лесу недалеко от школы, когда он проводил экскурсию для учеников.\r\n\r\nДиректор Хьюз просит вас отправиться в лес и найти Мистера Харрисона." +
                "\nВы соглашаетесь помочь и отправляетесь в лес.\n";

            string scq_2 = "Войдя в школьный лес, перед вами виднеется развилка\nКуда вы пойдете???\n1 - Налево\n2 - Направо\n>>>";

            string scq_3 = "Вы решили пойти по левой трапинке.\n";
            string scq_4 = "Пройдя немного вы увидили сново развилку.\nКуда вы пойдете???\n1 - Налево\n2 - Направо\n>>>";
            string scq_5 = "Тупик\nВы решили вернуться назад.";
            string scq_6 = "Вы следуете по лесной тропе, прислушиваясь к любым звукам или признакам, которые могут указать на местонахождение Мистера Харрисона." +
                "\nВы замечаете некоторые следы на земле, которые ведут в глубь леса.\nВы начинаете следовать за ними и наконец видите Мистера Харрисона, сидящего на земле с закрытыми глазами." +
                "\r\n\r\nВы быстро подходите к нему и проверяете его пульс и дыхание, они есть, но он кажется слабым и обессиленным.\nВы понимаете, что ему срочно нужна медицинская помощь. Вы забираете его на руки и отправляетесь обратно в школу." +
                "\r\n\r\nПо прибытии вы сообщаете директору Хьюз об обнаружении Мистера Харрисона и о его состоянии. Она немедленно вызывает скорую помощь и дает вам комнату для того, чтобы вы могли отдохнуть после напряженного поиска." +
                "\r\n\r\nКогда Мистер Харрисон приходит в сознание, он благодарит вас за спасение его жизни. Вы чувствуете удовлетворение от того, что смогли помочь и спасти жизнь этого человека. Вы осознаете, что ваша помощь и поддержка могут сделать настоящую разницу в жизни других людей, особенно тех, кто нуждается в этом больше всего.";

            for (int i = 0; i < scq_1.Length; i++)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                    Console.Write(scq_1);
                    Thread.Sleep(2000);
                    break;
                }
                Console.Write(scq_1[i]);
                Thread.Sleep(50); // задержка в 50 миллисекунд между символами
            }
            Map map = new Map();
            map.Bowerstone_Schooll_Forest();
            Console.Write(scq_2);

            int sw = Convert.ToInt32(Console.ReadLine());
            switch(sw)
            {
                case 1:
                    Console.Write(scq_3);
                    map.Bowerstone_Schooll_Forest_GO_0();
                    Console.Write(scq_4);
                    int sw1 = Convert.ToInt32(Console.ReadLine());
                    switch (sw1)
                    {
                        case 1:
                            map.Bowerstone_Schooll_Forest_GO_1();
                            Console.Write(scq_5);
                            break;
                        case 2:
                            map.Bowerstone_Schooll_Forest_GO_1_2();
                            Console.Write(scq_4);
                            int sw2 = Convert.ToInt32(Console.ReadLine());
                            switch(sw2)
                            {
                                case 1:
                                    map.Bowerstone_Schooll_Forest_GO_2();
                                    for (int i = 0; i < scq_6.Length; i++)
                                    {
                                        if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                                        {
                                            Console.Clear();
                                            Console.Write(scq_6);
                                            Thread.Sleep(2000);
                                            break;
                                        }
                                        Console.Write(scq_6[i]);
                                        Thread.Sleep(50); // задержка в 50 миллисекунд между символами
                                    }
                                    break;
                                case 2:
                                    map.Bowerstone_Schooll_Forest_GO_3();
                                    Console.Write(scq_5);
                                    break;
                            }
                            break;
                    }
                    break;
                case 2:
                    map.Bowerstone_Schooll_Forest_GO_4();
                    Console.Write(scq_5);
                    break;
            }


        }
    }
}
