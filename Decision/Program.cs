class DecisionMaking{

    static void Main (string[] args){
        double ex_balance =30000,amount,balance;
        int pin_no= 1234,upin;

        Console.WriteLine("Enter your PIN NO:");
        upin =int.Parse(Console.ReadLine());
       
        if(upin==pin_no){
            Console.WriteLine("Your PIN is valid");
            Console.WriteLine("Enter your amount:");
            amount=double.Parse(Console.ReadLine());
            if(amount<=ex_balance){
                balance=ex_balance-amount;
              Console.WriteLine("Amount Withdraw Succesfully");
              Console.WriteLine($"Your Withdrawal Amount is {amount} and Your Balance Amount is {balance}");

            }
            else{
                   Console.WriteLine("Insufficient Fund! Try again latter");
            }
        }
        else{
             Console.WriteLine("Your PIN is Invalid");
        }
        
    }
}
