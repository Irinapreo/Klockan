

int times = 0;
for (int hour = 0; hour<24; hour++)
{
    for(int min= 0; min<60; min++)
    {
        for (int sec = 0; sec < 60; sec++)
        {
            Console.WriteLine(nolla(hour) + ":" + nolla(min) + ":" + nolla(sec));
            times++;
        }
    }
}
string nolla(int number)
{
    if (number <= 9)
    {
        return "0" + number;
    }
    else
    {
        return number.ToString();
    }
}