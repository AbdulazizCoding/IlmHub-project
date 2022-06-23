while(true)
{   
    int n = int.Parse(Console.ReadLine());
    if(n > 0 && n < 115){
        AlQuranDownlaod.Download(n);
    }else{
        Console.WriteLine($"{n} chi sura mavjut emas");
    }
}
