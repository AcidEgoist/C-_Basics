Profiler();

Console.Clear();

double x1,x2,y1,y2;


Console.WriteLine("Введите координату х первой точки: ");
double.TryParse(Console.ReadLine(), out x1);

Console.WriteLine("Введите координату y первой точки: ");
double.TryParse(Console.ReadLine(), out y1);

Console.WriteLine("Введите координату х второй точки: ");
double.TryParse(Console.ReadLine(), out x2);

Console.WriteLine("Введите координату у второй точки: ");
double.TryParse(Console.ReadLine(), out y2);

Console.Clear();
Console.WriteLine("Расстояние между точками равно: {0}",TwoPointsDistance(x1, y1, x2, y2));

Console.Write("Для продолжения нажмите любую кнопку");
Console.Read();
Console.Clear();

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
    Console.WriteLine("Профиль создан.\nИмя: {0}\nФамилия: {1}\nВозраст: {2}\nРост: {3}\nВес: {4}", firstName, lastName, age, height, weight);
    Console.Write("\nДля продрлжения нажмите любую кнопку");  
    Console.ReadLine(); 

    Console.Clear();
    Console.WriteLine("Ваш индекс массы тела равен: {0}",BodyWeightIndex(weight, height));

    Console.Write("Для продолжения нажмите любую кнопку");
    Console.Read();

}

static float BodyWeightIndex(float weight, float height){
    
    if(height > 100) height /= 100;
    if (height==0 || height == 0) return 0;
    
    return weight/(height*height);

}

static double TwoPointsDistance(double x1, double y1, double x2, double y2){

    return (Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2)));

}
