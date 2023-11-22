

using Altkom._22_24._11._2023.DesignPrinciples;

CustomerService customerService = new CustomerService();
PaymentService paymentService = new PaymentService();



var id = 232;

var customer = customerService.FindById(id);
paymentService.Fund(customer.PaymentAccount, 23);