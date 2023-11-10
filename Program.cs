using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task_2();
        }

        public static void Task_1()
        {
            /*Задание 1: Система хранения данных
            Вам необходимо разработать простую систему хранения данных, которая позволит хранить и обрабатывать различные типы 
            данных. В рамках данной системы будет использоваться обобщенные типы для достижения гибкости и повторного 
            использования кода.

            Описание задания
            Создайте обобщенный класс DataStorage<T>, который будет представлять систему хранения данных. В этом классе должны 
            быть следующие методы:

            void AddData(T data): метод для добавления данных в систему.
            void RemoveData(T data): метод для удаления данных из системы.
            bool ContainsData(T data): метод для проверки наличия данных в системе.
            void PrintData(): метод для печати всех данных в системе.
            Реализуйте классы Person и Product, которые представляют сущности для хранения. Классы должны иметь свойства и 
            конструкторы по умолчанию. Например:
            public class Person
            {
                public string Name { get; set; }
                public int Age { get; set; }
            }

            public class Product
            {
                public string Name { get; set; }
                public decimal Price { get; set; }
            }
            Создайте несколько экземпляров классов Person и Product.

            Создайте экземпляр класса DataStorage<T>, где T - это тип данных, который вы хотите хранить.

            Добавьте созданные экземпляры в систему хранения данных при помощи метода AddData().

            Проверьте наличие данных в системе при помощи метода ContainsData().

            Удалите некоторые данные из системы при помощи метода RemoveData().

            Напечатайте все данные в системе при помощи метода PrintData().
            */
            Person chendler = new Person("Чендлер Бинг", 25);
            Person joe = new Person("Джо Трибиани", 24);
            Person ross = new Person("Росс Геллер", 24);

            Product bread = new Product("Бородинский", 49.9m);
            Product sugar = new Product("Сахар", 72.3m);
            Product beer = new Product("Жигули", 45.5m);

            DataStorage<Person> storageOfPersons = new DataStorage<Person>();
            Console.WriteLine("********************* Проверка списка DataStorage<Person> ************************");

            storageOfPersons.AddData(chendler);
            storageOfPersons.AddData(joe);
            storageOfPersons.AddData(ross);
            Console.WriteLine("Cписок людей до удаления");
            storageOfPersons.PrintData();

            storageOfPersons.RemoveData(chendler);
            Console.WriteLine("Cписок людей после удаления");
            storageOfPersons.PrintData();
            Console.WriteLine("Проверка наличия объекта в списке людей");
            if (storageOfPersons.ContainsData(joe))
            {
                Console.WriteLine(joe.ToString() + " есть в списке.");
            }
            Console.WriteLine("------------------------- Проверка списка DataStorage<Product> -----------------------------");

            DataStorage<Product> dataStorageOfProduct = new DataStorage<Product>();
            dataStorageOfProduct.AddData(beer);
            dataStorageOfProduct.AddData(sugar);
            dataStorageOfProduct.AddData(bread);
            Console.WriteLine("Cписок продуктов до удаления");
            dataStorageOfProduct.PrintData();
            dataStorageOfProduct.RemoveData(beer);
            Console.WriteLine("Cписок продуктов после удаления одного продукта");
            dataStorageOfProduct.PrintData();
            Console.WriteLine("Проверка наличия объекта в списке продуктов");
            if (dataStorageOfProduct.ContainsData(bread))
            {
                Console.WriteLine(bread.ToString() + " есть в списке продуктов.");
            }
        }

        public static void Task_2()
        {
            /*Задание 2:
            У тебя есть список студентов. Каждый студент представлен объектом класса Student, содержащего следующие свойства:

            class Student
            {
                public string Name { get; set; }
                public int Age { get; set; }
                public string Gender { get; set; }
                public string Major { get; set; }
                public List<string> Subjects { get; set; }
            }
            Твоя задача:

            Создать список студентов, содержащий не менее 10 элементов.
            Найти и вывести на экран всех студентов мужского пола.
            Найти и вывести на экран всех студентов, чья возрастная категория попадает в диапазон от 20 до 25 лет.
            Найти и вывести на экран количество студентов по каждой специальности (Major).
            Найти и вывести на экран все уникальные предметы, которые изучают студенты.
            Найти и вывести на экран студента с наибольшим количеством изучаемых предметов.
            Требования:

            Используй LINQ-запросы или методы расширений LINQ для решения каждой подзадачи.
            Не забудь добавить пример заполнения списка студентов для проверки решения.*/
            List<Student> students = new List<Student>();
            RandomInitialization(students, 20);
            students.Add(new Student("Иван", "Иванов", 20, gender.male, major.программист, new List<string> { "математика", "русский язык", "литература", "программирование", "философия"}));
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
            // студенты мужского пола
            Console.WriteLine("***************************| Студенты мужского пола |***************************");
            var malesStudents = students.Where(s => s.Gender == gender.male);
            foreach(var item in malesStudents)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***************************| Студенты 20-25 лет |***************************");
            var ageStudents = students.Where(s => s.Age >= 20 && s.Age <= 25);
            foreach (var item in ageStudents)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("***************************| Студенты по специальностям |***************************");
            int numberOfAccountants = students.Count(s => s.Major == major.бухгалтер);
            int numberOfProgrammers = students.Count(s => s.Major == major.программист);
            int numberOfManagers = students.Count(s => s.Major == major.менеджер);
            int numberOfIngeners = students.Count(s => s.Major == major.инженер);
            Console.WriteLine("По специальности \"бухгалтер\" обучается " + numberOfAccountants + " студентов.");
            Console.WriteLine("По специальности \"программист\" обучается " + numberOfProgrammers + " студентов.");
            Console.WriteLine("По специальности \"менеджер\" обучается " + numberOfManagers + " студентов.");
            Console.WriteLine("По специальности \"инженер\" обучается " + numberOfIngeners + " студентов.");

            Console.WriteLine("*********| Уникальные предметы |*********");

            List<string> subjects = new List<string>();

            foreach(var item in students)
            {
                for(int i = 0; i < item.Subjects.Count; i++)
                {
                    subjects.Add(item.Subjects[i]);
                }
            }

            var sub = subjects.GroupBy(s => s).Where(s => s.Count() == 1).Select(s => s.Key);
            
            foreach(var item in sub)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("*********| Студенты с максимальным количеством изучаемых предметов |*********");
            int maxCountSubjects = students.Max(s => s.Subjects.Count());
            IEnumerable<Student> maxSubjectsStudent = from student in students where student.Subjects.Count() == maxCountSubjects select student;
            foreach(var item in maxSubjectsStudent)
            {
                Console.Write(item.Name + " " + item.Surname + "\n");
            }
            
        }

        public static void RandomInitialization(List<Student> students, int numbersOfStudents)
        {
            Random rnd = new Random();
            List<string> list_male_names = new List<string> {"Иван", "Сергей", "Андрей", "Михаил", "Пётр", "Максим", "Евгений", "Дмитрий", "Леонид", "Игорь", "Олег", "Николай"};
            List<string> list_female_names = new List<string> {"Ирина", "Светлана", "Анна", "Мария", "Полина", "Маргарита", "Евгения", "Диана", "Лида", "Инна", "Ольга", "Нина"};

            List<string> list_male_surnames = new List<string> {"Иванов", "Петров", "Сидоров", "Петухов", "Смирнов", "Семёнов", "Григорьев", 
                                                                    "Тарасов", "Терентьев", "Валынкин", "Зернов", "Тетерин", "Марков", "Пухов", "Ларин", "Борисов", "Белов", 
                                                                    "Найденов", "Луконин", "Крылов", "Кротов", "Кудряшов", "Соловьёв", "Солодов", "Филиппов", "Цветков", "Чернов"};
            List<string> list_female_surnames = new List<string> { "Попова", "Полякова", "Волкова", "Викторова", "Бобова", "Карандашова", "Краснова", "Степанова", "Быкова", 
                                                                   "Балашова", "Егорова", "Дружинина", "Абрамова", "Александрова", "Алексеева", "Воробьёва", "Воронина", 
                                                                    "Лебедева", "Ершова", "Медведева", "Прокофьева", "Павлова", "Осипова", "Денисова", "Козлова", "Ковалёва", 
                                                                    "Носкова" };

            List<string> subjectsOfAccountants = new List<string>() { "математика", "русский язык", "литература", "бухгалтерия"};
            List<string> subjectsOfProgrammers = new List<string>() { "математика", "русский язык", "литература", "программирование"};
            List<string> subjectsOfMenegments = new List<string>() { "математика", "русский язык", "литература", "менеджмент"};
            List<string> subjectsOfIngeners = new List<string>() { "математика", "русский язык", "литература", "инженеринг"};
            List<string> subjects = new List<string>();
            for (int i = 0; i < numbersOfStudents; i++)
            {
                major m = (major)rnd.Next(4);
                gender g = (gender)rnd.Next(2);
                string name = null;
                string surname = null;
                switch (m)
                {
                    case major.бухгалтер:
                        subjects = new List<string>(subjectsOfAccountants);
                        break;
                    case major.менеджер:
                        subjects = new List<string>(subjectsOfMenegments);
                        break;
                    case major.программист:
                        subjects = new List<string>(subjectsOfProgrammers);
                        break;
                    case major.инженер:
                        subjects = new List<string>(subjectsOfIngeners);
                        break;

                }

                if(g == gender.female)
                {
                    name = list_female_names[rnd.Next(list_female_names.Count)];
                    surname = list_female_surnames[rnd.Next(list_female_names.Count)];
                }
                else
                {
                    name = list_male_names[rnd.Next(list_male_names.Count)];
                    surname = list_male_surnames[rnd.Next(list_male_surnames.Count)];
                }
                
                students.Add(new Student( name, surname, (rnd.Next(10) + 19), g, m, subjects));
            }
            

        }

        


        

    }

    
}



