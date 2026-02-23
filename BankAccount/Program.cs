using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine();
BankAccount account = new BankAccount("123-456-789", "홍길동");
account.ShowInfo();

account.Deposit(50000);
account.Deposit(30000);
account.Withdraw(20000);
account.Withdraw(100000);
account.Deposit(-1000);

account.ShowInfo();
class BankAccount
{
    //필드 / 속성
    public string AccountNumber { get; private set; }
    public string OwnerName { get; private set; }
    public decimal Balance { get; private set; }


    //생성자

    public BankAccount(string name, string acount)
    {
        OwnerName = name;
        AccountNumber = acount;
        Balance = 0;
    }
      
    //메서드

    //입금
    public void Deposit(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("입금 금액은 0보다 커야합니다.");
        }
        else
        {
            Balance += amount;
            Console.WriteLine($"{amount}원 입금 완료. 잔액: {Balance}");
        }
    }

    //출금
    public void Withdraw(int amount)
    {
        if (amount> Balance)
        {
            Console.WriteLine("잔액이 부족합니다.");
        }
        else if (amount>0)
        {
            Balance -= amount;
            Console.WriteLine($"{amount}원 출금 완료. 잔액: {Balance}");
        }
    }
    //출금정보
    public void ShowInfo()
    {
        Console.WriteLine($" [계좌 정보] {AccountNumber} ({OwnerName}) - 잔액: {Balance}원");
    }

}