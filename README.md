# ⚡ Sport Center

**C# Windows Forms** ve **SQL Server** kullanılarak geliştirilmiş, **Entity Framework 6** ile veritabanı işlemlerini yöneten bir masaüstü spor merkezi yönetim uygulamasıdır.

## 📋 Özellikler

- **Personel Girişi** — Kullanıcı adı ve şifre ile güvenli giriş ekranı
- **Üye Yönetimi** — Spor merkezi üyelerini ekleme, güncelleme, silme ve listeleme
- **Üyelik Yönetimi** — Üyelere paket atama, otomatik başlangıç/bitiş tarihi hesaplama
- **Paket Takibi** — Üyelik paketlerini ve fiyatlarını takip etme
- **İstatistikler** — En aktif üyeyi ve en çok kazandıran paketi görüntüleme

## 🛠️ Kullanılan Teknolojiler

| Teknoloji | Sürüm |
|---|---|
| C# / .NET Framework | 4.7.2 |
| Windows Forms | - |
| Entity Framework | 6.5.2 |
| SQL Server Express | 17.0 |

## 🗄️ Veritabanı

Proje **SQL Server Express** kullanmaktadır. Tablolar:

- `Table_Staff` — Personel/yönetici hesapları
- `Table_Member` — Spor merkezi üyeleri
- `Table_Package` — Üyelik paketleri
- `Table_Membership` — Üye-paket atamaları

## 🚀 Kurulum

### Gereksinimler

- Visual Studio 2019 veya üzeri
- SQL Server Express (SQLEXPRESS02 örneği)
- .NET Framework 4.7.2

### Adımlar

1. Depoyu klonlayın:
   ```bash
   git clone https://github.com/elffgkce/SportCenter.git
   ```

2. `Sport Center.sln` dosyasını Visual Studio ile açın

3. Veritabanını kurun:
   - **SQL Server Management Studio**'yu açın
   - `localhost\SQLEXPRESS02`'ye bağlanın
   - `Sport Center/database.sql` dosyasını açıp çalıştırın

4. Projeyi Visual Studio'da derleyip çalıştırın

## 📁 Proje Yapısı

```
Sport Center/
├── Form1.cs                  # Giriş ekranı
├── Form2.cs                  # Üye yönetimi ekranı
├── Form_Membership.cs        # Üyelik yönetimi ekranı
├── Member.cs                 # Üye modeli
├── Membership.cs             # Üyelik modeli
├── Package.cs                # Paket modeli
├── Staff.cs                  # Personel modeli
├── SportCenterDbContext.cs   # Entity Framework DB bağlamı
├── database.sql              # Veritabanı şeması ve veriler
└── App.config                # Bağlantı dizesi ayarları
```
