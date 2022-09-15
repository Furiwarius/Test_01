// выводить строку если она меньше либо равна 3


string[] StringArrayGenerator(){
    Random random = new Random();
    string str = "qwertyuiopasdfghjkl;'zxcvbnm,.1234567890-=!@#$%^&*()_+";
    string[] array = new string[random.Next(3, 15)];
    for (int i = 0; i < array.Length; i++)
    {
        string newString = "";
        for (int j = 0; j < random.Next(1,10); j++)
        {
            newString+=str[random.Next(1, str.Length)];
        }
        array[i] = newString;
    }
    return array;
}



string[] newArray = StringArrayGenerator();
