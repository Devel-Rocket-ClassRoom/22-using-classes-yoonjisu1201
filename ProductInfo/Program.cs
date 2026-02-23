using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine();
ProductInfo product1 = new ProductInfo("노트북", 1500000);
product1.PrintInfo();

ProductInfo product2 = new ProductInfo("키보드", 80000, 20);
product2.PrintInfo();

product2.DiscountPercent = 30;
product2.PrintInfo();
class ProductInfo
{
    public string Name { get; set; }
    public int Price { get; set; }
    public int DiscountPercent { get; set; }
    public int DiscountAmount => Convert.ToInt32(Price * DiscountPercent * 0.01);
    public int FinalPrice => Price - DiscountAmount;

    public ProductInfo(string name, int price)
    {
        Name = name;
        Price = price;
        DiscountPercent = 0;
    }

    public ProductInfo(string name, int price, int discountPercent)
    {
        Name = name;
        Price = price;
        DiscountPercent = discountPercent;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"[상품 정보] {Name} - 가격: {Price}원, 할인: {DiscountPercent}% (-{DiscountAmount}원), 최종가: {FinalPrice}원");
    }
}
