# SkinVault

SkinVault is a Windows Forms desktop app for keeping track of Counter-Strike weapon skins stored in a SQL Server database. Users log in or create an account; accounts with admin rights get a management panel where they add, edit and remove skins (weapon, skin name, condition, float value, price and inspect link), and regular users get a market view that shows every skin as a card with its image, price, float and an "Inspect in game" button that opens the item through Steam.

## Features

- **Splash screen** that fades in, waits three seconds and fades out before the login screen opens.
- **Login** checked against the `Kullanicilar` (users) table. The `Yetki` column decides where the user goes: `1` opens the admin panel, `0` opens the market view.
- **Registration** form with username, password and email. All fields are required and the email must contain `@` and `.`. New accounts are created as regular users.
- **Admin panel**
  - Loads the `Envanter` (inventory) table into a grid.
  - Add, update and remove skins. Weapon type comes from a preset list (AK-47, M4A4, M4A1-S, AWP, Desert Eagle, USP-S, Glock-18, Karambit, Butterfly Knife, Galil-AR) and condition from Factory New to Battle-Scarred.
  - The price and float fields only accept digits, `.` and `,`.
  - Clicking a row fills the form, shows the skin image and draws the float value on a wear bar.
- **Float bar**: a colored bar split into the wear ranges (0–0.07, 0.07–0.15, 0.15–0.38, 0.38–0.45, 0.45–1.00) with a marker at the item's float.
- **Market view**
  - Greets the logged-in user by name.
  - Shows each inventory item as a card with image, price in dollars, float value and float bar.
  - "Inspect in game" opens the item's `steam://` inspect link; a Steam button opens the Steam client.
- **Log out** from either panel returns to the login screen.

## Built with

- C# and Windows Forms on .NET Framework 4.7.2
- Microsoft SQL Server (Express) through `System.Data.SqlClient`
- [Guna.UI2.WinForms](https://www.nuget.org/packages/Guna.UI2.WinForms) 2.0.4.7 for the UI controls

## Getting started

### Requirements

- Windows
- Visual Studio with the ".NET desktop development" workload and the .NET Framework 4.7.2 targeting pack. The solution file uses the newer `.slnx` format, so use Visual Studio 2022 (17.13 or later) or Visual Studio 2026.
- SQL Server Express and SQL Server Management Studio (or `sqlcmd`)

### Database

`db.sql` creates the `SkinVaultDB` database with two tables and some sample data:

| Table | Columns |
| --- | --- |
| `Envanter` | `SkinID`, `SilahTuru` (weapon), `SkinAdi` (skin name), `Kondisyon` (condition), `FloatDegeri` (float), `Fiyat` (price), `InspectLink` |
| `Kullanicilar` | `KullaniciID`, `KullaniciAdi` (username), `Sifre` (password), `Eposta` (email), `Yetki` (role, default `0`) |

1. Open `db.sql` in SSMS and run it against your SQL Server instance, or run `sqlcmd -S .\SQLEXPRESS -E -i db.sql`.
2. The script was exported from SQL Server 2025 Express (compatibility level 170, data files under `MSSQL17.SQLEXPRESS`). On another SQL Server version, change the `FILENAME` paths and the compatibility level at the top of the script, or create an empty `SkinVaultDB` database yourself and run only the part after `USE [SkinVaultDB]`.
3. To get an admin account, register in the app and then set `Yetki = 1` for that user in the `Kullanicilar` table.

### Connection string

The connection string is hard-coded for my own machine. Change the `Data Source` to your SQL Server instance (for example `.\SQLEXPRESS`) in:

- `WindowsFormsApp1/SqlBaglantim.cs` (used by all forms)
- `WindowsFormsApp1/App.config` and `WindowsFormsApp1/Properties/Settings.settings` (used by the typed DataSets)

The app uses Windows authentication (`Integrated Security=True`).

### Build and run

1. Open `WindowsFormsApp1.slnx` in Visual Studio.
2. Restore NuGet packages if Visual Studio asks (Guna.UI2.WinForms is also included in `packages/`).
3. Build and run. The output is `WindowsFormsApp1.exe`.

### Skin images

Images are loaded from a `Skins` folder next to the executable, named after the skin, for example `Skins\Redline.png`. The sample images are in `WindowsFormsApp1/bin/Debug/Skins`. If you build in Release, copy that folder next to the Release executable. Skins without a matching image are shown without a picture.

## Project structure

```
WindowsFormsApp1.slnx          Solution
db.sql                         Database script with sample data
WindowsFormsApp1/
  Program.cs                   Entry point, starts the splash screen
  FormSplash.cs                Fade-in/fade-out splash screen
  Form1.cs                     Login screen
  FormKayit.cs                 Registration form
  Form2.cs                     Admin panel (add, update, remove skins)
  FormMarket.cs                Market view for regular users
  SkinCard.cs                  User control for one skin card
  SqlBaglantim.cs              Opens the SQL Server connection
  SkinVaultDB*.xsd             Typed DataSets generated by Visual Studio
packages/                      Guna.UI2.WinForms NuGet package
```

## Notes

Passwords are stored and compared as plain text, so do not use real passwords with this app.

## Türkçe

SkinVault, SQL Server veritabanında tutulan Counter-Strike silah skinlerini yönetmek için yazdığım bir Windows Forms uygulamasıdır. Kullanıcılar giriş yapar veya kayıt olur; yönetici yetkisi olan hesaplar skin ekleyip güncelleyip silebildiği bir panele, normal kullanıcılar ise skinleri resim, fiyat ve float değeriyle kartlar halinde gösteren market ekranına yönlendirilir. Her kartta, eşyayı Steam üzerinden oyunda incelemek için bir "Inspect in game" butonu bulunur.

Made by [Hasan Alp Güngör](https://hasanalpgungor.com/en)
