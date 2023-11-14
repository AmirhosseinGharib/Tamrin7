
List<Student> students = new List<Student>();

StreamReader sr = new 
    StreamReader(@"C:\c\bbb.txt");


while (!sr.EndOfStream)
{

    string line = sr.ReadLine();
    Student student = new Student();

    student.FName = line.Split(',')[0];
    student.pishrafteh1 = Convert.ToDouble(line.Split(',')[1]);
    student.tafsir = Convert.ToDouble(line.Split(',')[2]);
    student.riazi = Convert.ToDouble(line.Split(',')[3]);
    student.kargah = Convert.ToDouble(line.Split(',')[4]);
    student.zaban = Convert.ToDouble(line.Split(',')[5]);
    student.pishrafteh2 = Convert.ToDouble(line.Split(',')[6]);
    student.sheygaraee = Convert.ToDouble(line.Split(',')[7]);
    student.varzesh = Convert.ToDouble(line.Split(',')[8]);
    student. sistem= Convert.ToDouble(line.Split(',')[9]);
    student.algoritm = Convert.ToDouble(line.Split(',')[10]);

    students.Add(student);

}
Console.WriteLine("which part do you  want to see?");
Console.WriteLine(" 1(moadel kol doros) \n" +" 2(moadel amaly**)\n" +" 3(moadel teory*)\n" +" 4(moadel amaly** + moadel teory*) \n" + " 5(moadel grade bandi )\n" + " 6(moadel sort bandi) \n" + " 7(moadel adad aval)?\n" + " please inser 0 to exit!");


int x= Convert.ToInt32(Console.ReadLine());
if(x==1)
{
    foreach(var student in students)
    {
        Console.WriteLine(student.FName + "=" +student.moadelKolDoros());
       
    }
    
}
else 
if(x==2)
{
    foreach (var student in students)
    {
        Console.WriteLine(student.FName + "=" + student.moadelAmaly());

    }

}
else 
if(x==3)
{
    foreach (var student in students)
    {
        Console.WriteLine(student.FName + "=" + student.moadeTeory());

    }
}

else
if(x==4)
{
    foreach (var student in students)
    {
        Console.WriteLine(student.FName + "=" + student.moadelAmalyVaTeory());

    }
}
else if(x==5)
{
    foreach (var student in students)
    {
        Console.WriteLine(student.FName + "=" + student.GetGrade());
    }
}
else if (x == 6)
{
    foreach (var student in students)
    {
        Console.WriteLine("SORT BANDY==>"+ "////"+ student.FName + ":" + "moadel kol" + "=" + student.moadelKolDoros()+ "////" + "moadel amaly**" + "=" + student.moadelAmaly() + "////" + "moadel teory*" +"=" + student.moadeTeory() + "////" + "moadel amaly** va teory*" + "=" + student.moadelAmalyVaTeory());
    }
}
else if (x == 7)
{
    foreach (var student in students)
    {
        Console.WriteLine(student.FName + "=" + student.AdadAval());
    }
}



class Student
{
    public string FName { get; set; }
    public double pishrafteh1 { get; set; }
    public double tafsir { get; set; }
    public double riazi { get; set; }
    public double kargah { get; set; }
    public double zaban { get; set; }
    public double pishrafteh2 { get; set; }
    public double sheygaraee { get; set; }
    public double varzesh { get; set; }
    public double sistem { get; set; }
    public double algoritm { get; set; }
    public double moadelKolDoros()
    {
        return ((pishrafteh1 * 3) + (tafsir * 1) + (riazi * 2) + (kargah * 1) + (zaban * 2) + (pishrafteh2 * 3) + (sheygaraee * 3) + (varzesh * 1) + (sistem * 3) + (algoritm * 3)) / 22;
    }
    
    public double moadelAmaly()
    {
        return ((pishrafteh1 * 3) + (pishrafteh2 * 3) + (sheygaraee * 3)) / 9;
    }

    public double moadeTeory()
    {
        return ((sistem * 3) + (algoritm * 3)) / 6;
    }

    public double moadelAmalyVaTeory()
    {
        return ((sistem * 3) + (algoritm * 3)+ (pishrafteh1 * 3) + (pishrafteh2 * 3) + (sheygaraee * 3)) / 15 ;
    }
    public string GetGrade()
    {
        if (moadelKolDoros() >= 17)
            return FName + " " + " Gade A";

        if (moadelKolDoros() >= 15 && moadelKolDoros() < 17)
            return FName + " " + " Gade B";

        if (moadelKolDoros() >= 13 && moadelKolDoros() < 15)
            return FName + " " + " Gade C";

        if (moadelKolDoros() >= 10 && moadelKolDoros() < 13)
            return FName + " " + " Gade D";

        if (moadelKolDoros() >= 7 && moadelKolDoros() < 10)
            return FName + " " + " Gade E";

        if (moadelKolDoros() >= 3 && moadelKolDoros() < 7)
            return FName + " " + " Gade F";

        if (moadelKolDoros() >= 0 && moadelKolDoros() < 3)
            return FName + " " + " Gade G";
            return FName + " " + " Gade G";
    }

    public string sortbandi()
    {
        return ("moadelKolDoros");
        return (" moadelAmaly");
        return ("moadeTeory");
        return ("moadelAmalyVaTeory");

    }

    public string AdadAval()
    {
        if (moadelKolDoros() >= 19 && moadelKolDoros() < 20)
        return FName + " " + " NOT AVAL";
        

        if (moadelKolDoros()== 19 )
        return FName + " " + " ADAD AVAL";

        if (moadelKolDoros() >= 17 && moadelKolDoros() < 19)
        return FName + " " + " NOT AVAL";

        if (moadelKolDoros() == 17 )
        return FName + " " + " ADAD AVAL";

        if (moadelKolDoros() >=13 && moadelKolDoros() <17)
        return FName + " " + " NOT AVAL";

        if (moadelKolDoros()==13 )
        return FName + " " + " ADAD AVAL";

        if (moadelKolDoros() >= 11 && moadelKolDoros() < 13)
        return FName + " " + " NOT AVAL";

        if (moadelKolDoros() ==11)
        return FName + " " + " ADAD AVAL";

        if (moadelKolDoros() >= 7 && moadelKolDoros() <11)
        return FName + " " + " NOT AVAL";

        if (moadelKolDoros() ==7)
        return FName + " " + " ADAD AVAL";

        if (moadelKolDoros() >=5 && moadelKolDoros() < 7)
        return FName + " " + " NOT AVAL";

        if (moadelKolDoros() ==5)
        return FName + " " + " ADAD AVAL";

        if (moadelKolDoros() >= 3 && moadelKolDoros() <5)
        return FName + " " + " NOT AVAL";

        if (moadelKolDoros() ==3)
        return FName + " " + " ADAD AVAL";

        if (moadelKolDoros() >=2 && moadelKolDoros() <3)
        return FName + " " + " NOT AVAL";

        if (moadelKolDoros() == 2)
        return FName + " " + " ADAD AVAL";

        if (moadelKolDoros() >= 0 && moadelKolDoros() < 2)
        return FName + " " + " NOT AVAL";
        return FName + " " + " NOT AVAL";
    }
}
