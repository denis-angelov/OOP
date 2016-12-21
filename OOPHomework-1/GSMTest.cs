using System;


namespace DefiningClassesPart1
{

    //Problem 8. Calls

    static void Main()
    {
        GSM Samsung = new GSM("Galaxy", "Samsung", "400", "Ivan");
        GSM Nokia = new GSM("7650", "Nokia", "100");
        GSM Siemens = new GSM("C11", "Siemens", "200", "Frank");
        GSM Iphone = GSM.IPhone4S;

        GSM[] PhoneArray = new GSM[] { Samsung, Nokia, Siemens, Iphone };
        foreach (var Device in PhoneArray)
        {
            Console.WriteLine(Device.ToString());
        }

    }
}