int crystalCost = 13;
Console.WriteLine("Здравствуй, путник, сколько золотых у тебя в карманах?");
int gold = int.Parse(Console.ReadLine());
Console.WriteLine("И сколько кристаллов вы хотите на них купить? В моем магазине они дешевые - всего по 13 монет.");
int quantityPurchased = int.Parse(Console.ReadLine());
gold -= quantityPurchased * crystalCost;
Console.WriteLine($"У вас в инвентаре {gold} золота и {quantityPurchased} кристаллов.");