int firstnumber = int.Parse(Console.ReadLine());
/*
 * parse هتحول القيمه اللي هيدخلهاالمستخدم من string الي int
 * ويخزن القيمه تحت اسم firstnumber 
 */
int secondnumber = int.Parse(Console.ReadLine());
/*
 * parse هتحول القيمه اللي هيدخلهاالمستخدم من string الي int
 * ويخزن القيمه تحت اسم secondnumber 
 */
int result;
// عرف متغير اسمه result نوعه int
result = firstnumber + secondnumber;
Console.WriteLine("The first number is :" + firstnumber);
// اطبع The first number is : وحط قيمة firstnumber اللي المستخدم حطها 
Console.WriteLine("The second number is :" + secondnumber);
// اطبع The second number is : وحط قيمة secondnumber اللي المستخدم حطها 
Console.WriteLine("The result is :" +result);
// اطبع The result is : وحط قيمة firstnumber+secondnumber
Console.WriteLine("The summation of {0} and {1} = {2}", firstnumber, secondnumber, result);
// اطبع The summation of قيمة firstnumber + قيمة secondnumber يساوي result
 
 