using System;

namespace GenericFluent
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = new Customer();
            var validateBase = new BaseValidate();
            var validateCustomer = new CustomerValidate();

            var process = new ProcessValidate<Customer, Base>(validateCustomer, validateBase);

            var result = process.Validate(model);

            foreach (var item in result)
            {
                Console.WriteLine("Erro é {0}", item);
            }

            Console.ReadKey();
        }
    }
}
