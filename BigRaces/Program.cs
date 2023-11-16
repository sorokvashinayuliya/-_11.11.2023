using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigRaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("В консоли необходимо создать 4 команды: Россия, Франция, Китай и Казахстан, и чтобы они сыграли в 6 игр.");
            // Россия
            Person Artem = new Person("Артём",PersonPosition.игрок);
            Person Alexander = new Person("Александр", PersonPosition.игрок);
            Person Alex = new Person("Алексей", PersonPosition.игрок);
            Person Glebe = new Person("Глеб", PersonPosition.игрок);
            Person Denis = new Person("Денис", PersonPosition.игрок);
            Person Ilya = new Person("Илья", PersonPosition.игрок);
            Person Roman = new Person("Роман", PersonPosition.игрок);
            Person Nikita = new Person("Никита", PersonPosition.игрок);
            Person Sergey = new Person("Сергей", PersonPosition.игрок);
            Person Vlad = new Person("Влад", PersonPosition.игрок);
            Person Kirill = new Person("Кирилл", PersonPosition.игрок);
            Person Stepan= new Person("Степан", PersonPosition.игрок);
            Person Slava = new Person("Вячеслав", PersonPosition.игрок);
            Person Vladimir = new Person("Владимир", PersonPosition.игрок);
            Person Boris = new Person("Борис", PersonPosition.игрок);
            Team Russia = new Team("Россия", Artem, Alexander, Alex, Glebe, Denis,Ilya,Roman, Nikita,Sergey,Vlad, Kirill,Stepan,Slava,Vladimir,Boris );
            //Франция
            Person Artem1 = new Person("Артём", PersonPosition.игрок);
            Person Alexander1 = new Person("Александр", PersonPosition.игрок);
            Person Alex1 = new Person("Алексей", PersonPosition.игрок);
            Person Glebe1 = new Person("Глеб", PersonPosition.игрок);
            Person Denis1 = new Person("Денис", PersonPosition.игрок);
            Person Ilya1 = new Person("Илья", PersonPosition.игрок);
            Person Roman1 = new Person("Роман", PersonPosition.игрок);
            Person Nikita1 = new Person("Никита", PersonPosition.игрок);
            Person Sergey1 = new Person("Сергей", PersonPosition.игрок);
            Person Vlad1 = new Person("Влад", PersonPosition.игрок);
            Person Kirill1 = new Person("Кирилл", PersonPosition.игрок);
            Person Stepan1 = new Person("Степан", PersonPosition.игрок);
            Person Slava1 = new Person("Вячеслав", PersonPosition.игрок);
            Person Vladimir1 = new Person("Владимир", PersonPosition.игрок);
            Person Boris1 = new Person("Борис", PersonPosition.игрок);
            Team France = new Team("Франция", Artem1, Alexander1, Alex1, Glebe1, Denis1, Ilya1, Roman1, Nikita1, Sergey1, Vlad1, Kirill1, Stepan1, Slava1, Vladimir1, Boris1);
            //Китай
            Person Artem2 = new Person("Артём", PersonPosition.игрок);
            Person Alexander2 = new Person("Александр", PersonPosition.игрок);
            Person Alex2 = new Person("Алексей", PersonPosition.игрок);
            Person Glebe2 = new Person("Глеб", PersonPosition.игрок);
            Person Denis2 = new Person("Денис", PersonPosition.игрок);
            Person Ilya2 = new Person("Илья", PersonPosition.игрок);
            Person Roman2 = new Person("Роман", PersonPosition.игрок);
            Person Nikita2 = new Person("Никита", PersonPosition.игрок);
            Person Sergey2 = new Person("Сергей", PersonPosition.игрок);
            Person Vlad2 = new Person("Влад", PersonPosition.игрок);
            Person Kirill2 = new Person("Кирилл", PersonPosition.игрок);
            Person Stepan2 = new Person("Степан", PersonPosition.игрок);
            Person Slava2 = new Person("Вячеслав", PersonPosition.игрок);
            Person Vladimir2 = new Person("Владимир", PersonPosition.игрок);
            Person Boris2 = new Person("Борис", PersonPosition.игрок);
            Team China = new Team("Китай", Artem2, Alexander2, Alex2, Glebe2, Denis2, Ilya2, Roman2, Nikita2, Sergey2, Vlad2, Kirill2, Stepan2, Slava2, Vladimir2, Boris2);
            //Казахстан
            Person Artem3 = new Person("Артём", PersonPosition.игрок);
            Person Alexander3 = new Person("Александр", PersonPosition.игрок);
            Person Alex3 = new Person("Алексей", PersonPosition.игрок);
            Person Glebe3 = new Person("Глеб", PersonPosition.игрок);
            Person Denis3 = new Person("Денис", PersonPosition.игрок);
            Person Ilya3 = new Person("Илья", PersonPosition.игрок);
            Person Roman3 = new Person("Роман", PersonPosition.игрок);
            Person Nikita3 = new Person("Никита", PersonPosition.игрок);
            Person Sergey3 = new Person("Сергей", PersonPosition.игрок);
            Person Vlad3 = new Person("Влад", PersonPosition.игрок);
            Person Kirill3 = new Person("Кирилл", PersonPosition.игрок);
            Person Stepan3 = new Person("Степан", PersonPosition.игрок);
            Person Slava3 = new Person("Вячеслав", PersonPosition.игрок);
            Person Vladimir3 = new Person("Владимир", PersonPosition.игрок);
            Person Boris3 = new Person("Борис", PersonPosition.игрок);
            Team Kazakhstan = new Team("Казахстан", Artem3, Alexander3, Alex3, Glebe3, Denis3, Ilya3, Roman3, Nikita3, Sergey3, Vlad3, Kirill3, Stepan3, Slava3, Vladimir3, Boris3);
            Beach beach = new Beach();
            Sea sea = new Sea();
            Postmen postmen = new Postmen();
            Slide slide = new Slide();
            Fishing fishing = new Fishing();
            Mousetrap mousetrap = new Mousetrap();
            Chess chess = new Chess();
            BigRacesShow.StartShow(beach);
            BigRacesShow.StartShow(sea);
            BigRacesShow.StartShow(postmen);
            BigRacesShow.StartShow(slide);
            BigRacesShow.StartShow(fishing);
            BigRacesShow.StartShow(mousetrap);
            BigRacesShow.StartShow(chess);

        }
    }
}
