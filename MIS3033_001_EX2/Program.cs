// MIS 3033 001 Exercise
// Fenix Strickland

// add xinglong.ju@ou.edu as the collaborator on GitHub
// 

//****************************************************
//Options Menu
//1. Add a new student's information
//2.Show all the students' information
//3. Show the student's information with smallest age
//4. Show the average weight of all the students
//Press other keys to exit.
//****************************************************

//Enter your option: 

//Add a new student
//Enter the ID: 
//Enter the name: 
//Enter the age: 
//Enter the weight:

List<Student> stuList = new LIst<Student>();
do
{

    Console.WriteLine("Options Menu");
    Console.WriteLine("1. Add a new student's information");
    Console.WriteLine("2. Show all the students' information");
    Console.WriteLine("3. Show the student's information with smallest age");
    Console.WriteLine("4. Show the average weight of all the students.");
    Console.WriteLine("Press other keys to exit");
    userInput = Console.ReadLine();
    if (userInput == "1")
    {

        Console.WriteLine("Add a new student");
        Console.WriteLine("Enter the ID:");
        string stuIDInputStr = Console.ReadLine();
        Console.WriteLine("Enter the name:");
        string stuNameInputStr = Console.ReadLine();
        Console.WriteLine("Enter the age:");
        int stuAgeInputInt = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Weight");
        double stuWeightInputDbl = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("**********************************");

        Student stu = new Student(stuIDInputStr, stuNameInputStr, stuAgeInputInt, stuWeightInputDbl);
        stuList.Add(stu);

        Console.WriteLine("Options Menu");
        Console.WriteLine("1. Add a new student's information");
        Console.WriteLine("2. Show all the students' information");
        Console.WriteLine("3. Show the student's information with smallest age");
        Console.WriteLine("4. Show the average weight of all the students.");
        Console.WriteLine("Press other keys to exit");
        userInput = Console.ReadLine();


    }
    else if (userInput == "2")
    {
        for (int i = 0; i < stuList.Count; i++)
        {
            Console.WriteLine("All the students' infor: ");
            Console.WriteLine(stuList[i]);
        }

        Console.WriteLine("**********************************");
        Console.WriteLine("Options Menu");
        Console.WriteLine("1. Add a new student's information");
        Console.WriteLine("2. Show all the students' information");
        Console.WriteLine("3. Show the student's information with smallest age");
        Console.WriteLine("4. Show the average weight of all the students.");
        Console.WriteLine("Press other keys to exit");
        userInput = Console.ReadLine();
    }
    else if (userInput == "3")
    {
        Student lowStudent = stuList[0];
        for (int i = 0; i < stuList.Count; i++)
        {
            if (lowStudent.AgeLevel() > stuList[i].AgeLevel())
            {
                lowStudent = stuList[i];
            }
        }
        Console.WriteLine("Student with smallest age:");
        Console.WriteLine($"{lowStudent.AgeLevel().ToString()}");

        Console.WriteLine("**********************************");
        Console.WriteLine("Options Menu");
        Console.WriteLine("1. Add a new student's information");
        Console.WriteLine("2. Show all the students' information");
        Console.WriteLine("3. Show the student's information with smallest age");
        Console.WriteLine("4. Show the average weight of all the students.");
        Console.WriteLine("Press other keys to exit");
        userInput = Console.ReadLine();
    }

    else if (userInput == "4")
    {
        for (int i = 0; i<stuList.Count; i++)
        {
            Console.WriteLine($"The average weight: {stuList[i]/stuList.Count} ");
        }
        
    }


} while (userInputt == "1" || userInput == "2" || userInput == "3" || userInput == "4");







public class Student
{
    public string stuName { get; set; }
    public string SID { get; set; }
    public int stuAge { get; set; }
    public double stuWeight { get; set; }



    public Student() { }

    public Student(string id, string name, int age, double weight)
    {
        this.SID = id;
        this.stuName = name;
        this.stuAge = age;
        this.stuWeight = weight;
    }
    public double AveWeight()
    {
        double avgWeight = 0;
        avgWeight = this.stuWeight / stuList.Count;
        return avgWeight;

    }

    public int AgeLevel()
    {
        int levelAge = 0;

        if (this.stuAge < 20)
        {
            levelAge = 1;
        }
        else if(this.stuAge >= 20 || this.stuAge < 35)
        {
            levelAge = 2;
        }
        else
        {
            levelAge = 3;
        }
        return levelAge;
    }

    public override string ToString()
    {
        string outMesStr = string.Format($"{this.stuName} ({this.SID}), Age {this.stuAge} ({this.AgeLevel()}), Weight: {this.stuWeight:F1}");
        return outMesStr;
    }

}

Console.ReadLine();
