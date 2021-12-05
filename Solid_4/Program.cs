using System;

/*Даний інтерфейс поганий тим, що він включає занадто багато методів.
 А що, якщо наш клас товарів не може мати знижок або промокодом, або для нього немає сенсу встановлювати матеріал з 
 якого зроблений (наприклад, для книг). Таким чином, щоб не реалізовувати в кожному класі невикористовувані в ньому методи, краще 
розбити інтерфейс на кілька дрібних і кожним конкретним класом реалізовувати потрібні інтерфейси.
Перепишіть, розбивши інтерфейс на декілька інтерфейсів, керуючись принципом розділення інтерфейсу. 
Опишіть класи книжки (розмір та колір не потрібні, але потрібна ціна та знижки) та верхній одяг (колір, розмір, ціна знижка),
які реалізують притаманні їм інтерфейси.*/

interface IPrice
{
    void SetPrice(double price);
}
interface IDiscount
{
    void ApplyDiscount(String discount);
    void ApplyPromocode(String promocode);
}
interface IColor
{
    void SetColor(byte color);
}
interface ISize
{
    void SetSize(byte size);
}

class Book : IPrice, IDiscount
{
    private double price;
    public void ApplyDiscount(string discount) { }
    public void ApplyPromocode(string promocode) { }
    public void SetPrice(double price)
    {
        this.price = price;
    }
}

class Outerwear : IColor, ISize, IPrice, IDiscount
{
    private byte color;
    private byte size;
    private double price;
    public void ApplyDiscount(string discount) { }
    public void ApplyPromocode(string promocode) { }
    public void SetColor(byte color)
    {
        this.color = color;
    }
    public void SetPrice(double price)
    {
        this.price = price;
    }
    public void SetSize(byte size)
    {
        this.size = size;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.ReadKey();
    }
}