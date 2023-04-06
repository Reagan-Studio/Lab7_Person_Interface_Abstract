using Lab7_Person_Interface_Abstract;



////Часть 4
//Person Ludmila = new Person("Кукина", "Людмила", new DateTime(1965, 5, 1));
//Person Ivan = new Person("Кукин", "Иван", new DateTime(1950, 4, 1));
//Building common_house1 = new Building(Ludmila, 1500000, "Зайцева, 79");
//Building common_house1_1 = new Building(Ivan, 1500000, "Зайцева, 79");
//Stead common_stead1 = new Stead(Ludmila, 150000, 300);
//Stead common_stead1_1 = new Stead(Ivan, 150000, 300);
//Stead garden_stead = new Stead(Ivan, 300000, 1000);
//Horse romashka = new Horse(Ivan, 20000, "Ромашка", 0, 7, 250);
//PassengerCar car = new PassengerCar(Ivan, 10000, "ЗАЗ-965", 0, 27);
//SmallShip smallShip = new SmallShip(Ivan, 25000, "", 0, 0, 15);


//Holding[] holdings = { romashka, car, smallShip, common_house1, common_house1_1, common_stead1, common_stead1_1, garden_stead, };

//Console.WriteLine("Проверка работы сортировки:\nНеотсортированный:");
//for (int i = 0; i < holdings.Length; i++)
//{
//    Console.WriteLine($"{holdings[i].Cost}");
//}
//Array.Sort(holdings);
//Console.WriteLine("-------------------------------");
//Console.WriteLine("\nОтсортированный:");
//for (int i = 0; i < holdings.Length; i++)
//{
//    Console.WriteLine($"{holdings[i].Cost}");
//}





////Часть 2,3

//Person Ludmila = new Person("Кукина", "Людмила", new DateTime(1965, 5, 1));
//Person Ivan = new Person("Кукин", "Иван", new DateTime(1950, 4, 1));
//Building common_house1 = new Building(Ludmila, 1500000, "Зайцева, 79");
//Building common_house1_1 = new Building(Ivan, 1500000, "Зайцева, 79");
//Stead common_stead1 = new Stead(Ludmila, 150000, 300);
//Stead common_stead1_1 = new Stead(Ivan, 150000, 300);
//Stead garden_stead = new Stead(Ivan, 300000, 1000);
//Horse romashka = new Horse(Ivan, 20000, "Ромашка", 0, 7, 250);
//PassengerCar car = new PassengerCar(Ivan, 10000, "ЗАЗ-965", 0, 27);
//SmallShip smallShip = new SmallShip(Ivan, 25000, "", 0, 0, 15);

//PersonFixPay Ivan_worker = new PersonFixPay(Ivan, 30000, 25);
//PersonFixPay Ludmila_worker = new PersonFixPay(Ludmila, 35000, 0);

//Holding[] holdings = { common_house1, common_house1_1, common_stead1, common_stead1_1, garden_stead, romashka, car, smallShip };

//double sum = 0;
//for (int i = 0; i < holdings.Length; i++)
//{
//    sum += holdings[i].Cost;
//}
//Console.WriteLine($"Общая стоимость имущества Кукиных = {sum} руб.");


//INalog[] nalogs = { common_house1, common_house1_1, common_stead1, common_stead1_1, garden_stead, romashka, car, smallShip, Ivan_worker, Ludmila_worker };
//double tax = 0;
//for (int i = 0; i < nalogs.Length; i++)
//{
//    tax += nalogs[i].Tax();
//}
//Console.WriteLine($"Семья Кукиных заплaтила общий налог размером {tax}руб.");






////Часть 1
//double TotalSumPay(PersonFixPay[] workers)
//{
//    double result = 0;
//    for (int i = 0; i < workers.Length; i++)
//    {
//        result += workers[i].FullTotalPayment();
//    }
//    return result;
//}


//double TotalSumTax(PersonFixPay[] workers)
//{
//    double result = 0;
//    for (int i = 0; i < workers.Length; i++)
//    {
//        result += workers[i].Tax();
//    }
//    return result;
//}


//PersonFixPay MaxPay(PersonFixPay[] workers)
//{
//    int max_index = 0;
//    for (int i = 1; i < workers.Length; i++)
//    {
//        if ((workers[i].TaxTotalPayment()) > workers[max_index].TaxTotalPayment())
//        {
//            max_index = i;
//        }
//    }
//    return workers[max_index];
//}

//PersonFixPay w1 = new PersonFixPay("Семенов", "Олег", 'M', 60000, 20);
//PersonFixPay w2 = new PersonFixPay("Сидоров", "Михаил", 'M', 100000, 200);
//PersonHourlyPay w3 = new PersonHourlyPay("Иванова", "Александра", 'F', 3000, 10, 50);
//PersonHourlyPay w4 = new PersonHourlyPay("Львова", "Анна", 'F', 2000, 25, 45);
//PersonFixPay[] workers = new PersonFixPay[] { w1, w2, w3, w4 };

//Console.WriteLine($"\nОбщая сумма, начисленная работникам = {TotalSumPay(workers)}");
//Console.WriteLine($"\nOбщая сумма уплаченных налогов для массива работников = {TotalSumTax(workers)}");
//Console.WriteLine($"\nOбъект работника с наибольшей полученной на руки суммой:");
//MaxPay(workers).Print();