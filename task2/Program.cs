using task2;

Account heikkis_account = new Account(1000.0);
heikkis_account.OutputDepozit(100.0);

Account personal_account = new Account(0);
personal_account.InputDepozit(100.0);

System.Console.WriteLine(heikkis_account.ToString());
System.Console.WriteLine(personal_account.ToString());
