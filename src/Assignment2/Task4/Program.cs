using Task4;

Admin admin = new Admin("Aminul", "Ahasan", "aminul.ahasan@gmail.com");
admin.GenerateId();
Console.WriteLine($"Admin: {admin.FullName} \nEmail: {admin.Email} \nID: {admin.Id}");
Console.WriteLine();

Student student = new Student("Mobinul", "Ahasan", "mobinul.ahasan@gmail.com");
student.GenerateId();
Console.WriteLine($"Student: {student.FullName} \nEmail: {student.Email} \nID: {student.Id}");
Console.WriteLine();

Teacher teacher = new Teacher("Md. Jalal", "Uddin", "jalal.uddin@gmail.com");
teacher.GenerateId();
Console.WriteLine($"Teacher: {teacher.FullName} \nEmail: {teacher.Email} \nID: {teacher.Id}");