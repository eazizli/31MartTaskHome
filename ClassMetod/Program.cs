using ClassMetod;
using System.Reflection.Emit;

NewMethod();

static void NewMethod()
{

    Student student = new Student("ab","bc",12);

    int std = 1;
    for (int i = 0; i < std; i++)
    {
        std++;

        
        {
            string click = Console.ReadLine();
            if (click == "1")
            {

                Console.WriteLine("Created Student"); ;
                Console.Write("Telebenin adi -" + " ");
                student.Name = Console.ReadLine();
                Console.Write("Telebenin soyadi -"+" ");
                student.Surname = Console.ReadLine();
                Console.Write("telebenin Id-si -" + " ");
                Int32.TryParse(Console.ReadLine(), out student.Id);
               
            }
           
            
            
            if (click == "2")
            {

               Console.WriteLine("Get Studnet");
               Console.WriteLine(student.Name + " " + student.Surname );
            }
            

            
            if(click == "3") 
            {
                Console.WriteLine("Exit");
                break;
            }
        }

      
       
      
    }
   
}
