# Inheritance Uygulaması

Bu proje, C# dilinde **kalıtım (inheritance)** kavramını temel bir örnekle göstermektedir. `Kisi` sınıfı temel (base) sınıf olarak tanımlanmış, bu sınıftan türetilen `Öğrenci` ve `Öğretmen` sınıfları kendi özellik ve metodlarıyla genişletilmiştir.

---

## 📁 Proje Yapısı

```
Inheritance.sln          # Çözüm dosyası

/Inheritance            # Konsol uygulaması proje klasörü
  ├─ Inheritance.csproj  # Proje dosyası
  ├─ Program.cs          # Uygulamanın giriş noktası
  └─ Models/             # Model sınıfları
      ├─ Kisi.cs         # Base sınıf
      ├─ Öğrenci.cs      # Kisi sınıfından türetilmiş öğrenci sınıfı
      └─ Öğretmen.cs     # Kisi sınıfından türetilmiş öğretmen sınıfı
```

---

## 🔧 Gereksinimler

* [.NET SDK 6.0](https://dotnet.microsoft.com/) (veya proje dosyasında belirtilen bir üst sürüm)
* Visual Studio 2022 (veya VS Code / Rider gibi bir IDE)

---

## 🚀 Kurulum ve Çalıştırma

1. Depoyu klonlayın:

   ```bash
   ```

git clone [https://github.com/BilalHantik41/Inheritance.git](https://github.com/BilalHantik41/Inheritance.git)
cd Inheritance/Inheritance

````

2. Projeyi derleyip çalıştırın:

```bash
dotnet run
````

---

## ⚙️ Uygulama Akışı

1. `Program.cs` içinde bir `Öğrenci` ve bir `Öğretmen` nesnesi oluşturulur.
2. Her iki nesneye ait tanıtım ve özel metodlar sırasıyla ekrana yazdırılır.
3. Konsolda aralarına ayrım çizgileri konarak sonuçlar gösterilir.

---

## 📋 Çıktı Örneği

```
************************************************
Ad: ALİ VELİ
************************************************
Öğrenci Kartı -> Ad: ALİ VELİ, Numara: 14
************************************************
Öğretmen İş Sözleşmesi -> Ad: Ayşe Fatma, Maaş: 311411 ₺
************************************************
```

---

## 🌱 Kavramsal Açıklama

* **Kalıtım (Inheritance):** Bir sınıfın (`Derived Class`) başka bir sınıftan (`Base Class`) özellik ve metotları devralmasıdır.
* **Base Class (`Kisi`):** Ortak özellikler (`Ad`, `SoyAdı`) ve `Tanıtma()` metodu içerir.
* **Derived Classes:**

  * `Öğrenci`: `Kisi` sınıfını genişleterek `ÖğrenciNumarası` özelliği ve `ÖğrenciKartı()` metodunu ekler.
  * `Öğretmen`: `Kisi` sınıfını genişleterek `Maaş` özelliği ve `ÖğretmenİşSözleşmesi()` metodunu ekler.

---

### İletişim

Herhangi bir sorunuz veya katkınız için lütfen [GitHub Issues](https://github.com/BilalHantik41/Inheritance/issues) üzerinden geribildirim gönderin.
