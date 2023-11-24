

using Altkom._22_24._11._2023.DesignPatterns.Behavioral.Strategy;
using Altkom._22_24._11._2023.DesignPrinciples;
using Altkom._22_24._11._2023.SOLID.L;


Client.Execute();


static void DesignPrinciples()
{
    CustomerService customerService = new CustomerService();
    PaymentService paymentService = new PaymentService();



    var id = 232;

    var customer = customerService.FindById(id);
    paymentService.Fund(customer.PaymentAccount, 23);
}

static void SOLID()
{
    int a = 4;
    int b = 9;

    var rectangle = CreateRectangle(a, b);


    Console.WriteLine($"{a} * {b} = {rectangle.Area}");





    Rectangle CreateRectangle(int a, int b)
    {
        return new Altkom._22_24._11._2023.SOLID.L.Square() { A = a, B = b };
    }
}