Profiler();

static void Profiler(){

    string firstName, lastName;
    int age;
    float weight, height;

    //Clearing console before using
    Console.Clear();

    //Reading information from user's console
    Console.WriteLine("Введите Ваше имя: ");
    firstName = Console.ReadLine();
    Console.Clear();

    Console.WriteLine("Введите Вашу фамилию: ");
    lastName = Console.ReadLine();
    Console.Clear();

    Console.WriteLine("Введите Ваш возраст: ");
    int.TryParse(Console.ReadLine(), out age);
    Console.Clear();

    Console.WriteLine("Введите Ваш рост: ");
    float.TryParse(Console.ReadLine(), out height);
    Console.Clear();

    Console.WriteLine("Введите Ваш вес: ");
    float.TryParse(Console.ReadLine(), out weight);
    Console.Clear();

    //Visualisation of profile
    Console.WriteLine("Проверка правильности данных.\nИмя: {0};\nФамилия: {1};\nВозраст: {2};\nРост: {3};\nВес: {4}.", firstName, lastName, age, height, weight);

}