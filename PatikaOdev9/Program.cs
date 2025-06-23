// Kullanıcı başka bir tatil planlamak isterse diye kontrol değişkeni
bool continueApp = true;

while (continueApp)
{
    // Lokasyon bilgisini tutacak değişkenler
    string location = "";
    int locationPrice = 0;

    // Kullanıcıdan geçerli bir lokasyon alana kadar sorulacak ifadeler
    while (true)
    {
        System.Console.WriteLine("Lütfen bir lokasyon seçiniz (Bodrum, Marmaris, Çeşme):");
        location = System.Console.ReadLine().ToLower(); // Küçük harfe çevirerek kontrolü kolaylaştırır

        if (location == "bodrum")
        {
            locationPrice = 4000;
            break; // geçerli giriş olduğunda döngüden çık
        }
        else if (location == "marmaris")
        {
            locationPrice = 3000;
            break;
        }
        else if (location == "çeşme" || location == "cesme") // iki yazım şekli de kabul edilecek
        {
            locationPrice = 5000;
            break;
        }
        else
        {
            // Geçersiz girişte kullanıcı uyarılır
            System.Console.WriteLine("Hatalı giriş yaptınız. Lütfen Bodrum, Marmaris veya Çeşme yazınız.\n");
        }
    }

    // Kişi sayısını tutacak değişken
    int personCount;
    while (true)
    {
        System.Console.WriteLine("Kaç kişi için tatil planlıyorsunuz?");
        string input = System.Console.ReadLine();

        // Kullanıcının girdiği değer sayı mı ve 0'dan büyük mü sorgusu
        if (int.TryParse(input, out personCount) && personCount > 0)
        {
            break;
        }
        else
        {
            // Geçersiz girişte kullanıcı uyarılır
            System.Console.WriteLine("Lütfen geçerli bir pozitif sayı giriniz.");
        }
    }

    // Ulaşım tipine göre kişi başı ulaşım fiyatı
    int travelCostPerPerson = 0;
    while (true)
    {
        System.Console.WriteLine("Ulaşım türünü seçiniz:");
        System.Console.WriteLine("1 - Kara Yolu (1500 TL kişi başı)");
        System.Console.WriteLine("2 - Hava Yolu (4000 TL kişi başı)");

        string travelChoice = System.Console.ReadLine();

        if (travelChoice == "1")
        {
            travelCostPerPerson = 1500;
            break;
        }
        else if (travelChoice == "2")
        {
            travelCostPerPerson = 4000;
            break;
        }
        else
        {
            // Geçersiz seçimde kullanıcıya tekrar soruluyor
            System.Console.WriteLine("Hatalı seçim yaptınız. Lütfen sadece 1 ya da 2 giriniz.\n");
        }
    }

    // Toplam tutar hesaplanıyor
    int totalCost = (locationPrice + travelCostPerPerson) * personCount;

    // Kullanıcıya tatil planı özet olarak gösteriliyor
    System.Console.WriteLine("\nTatil Planınız:");
    System.Console.WriteLine("-----------------------------");
    System.Console.WriteLine("Seçilen lokasyon : " + location);
    System.Console.WriteLine("Kişi sayısı      : " + personCount);
    System.Console.WriteLine("Ulaşım türü      : " + (travelCostPerPerson == 1500 ? "Kara Yolu" : "Hava Yolu"));
    System.Console.WriteLine("Toplam tutar     : " + totalCost + " TL");
    System.Console.WriteLine("-----------------------------\n");

    // Kullanıcı başka bir tatil planlamak ister mi?
    System.Console.WriteLine("Başka bir tatil planlamak ister misiniz? (E/H)");
    // Kullanıcı başka bir tatil planlamak isterse "e" yazar, aksi halde uygulama biter
    string again = System.Console.ReadLine().ToLower();

    // Eğer kullanıcı "e" girmezse uygulama kapanır
    if (again != "e") // Eğer kullanıcı "e" dışında bir şey girdiyse
    {
        continueApp = false; // Döngü bitiyor
        System.Console.WriteLine("İyi günler, tekrar bekleriz!");
    }
}
