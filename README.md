# 🕹️ Rétro-Game Café — Site Vitrine & Gestion

Application web ASP.NET Core MVC développée dans le cadre d'un laboratoire de formation. Ce projet met en œuvre une architecture monolithe en 3 couches (**WebApp**, **BLL**, **DAL**) pour présenter un café thématique rétro-gaming, sa carte de restauration et son parc de consoles et jeux vidéo rétro.

---

## 🎯 Objectifs pédagogiques & Stack technique

* **Back-end :** C# / .NET 10, ASP.NET Core MVC
* **Architecture :** Monolithe en couches (`WebApp` → `BLL` → `DAL`) avec injection de dépendances
* **Base de données & ORM :** SQL Server, Entity Framework Core 10 (*Code First*, *Fluent API*, Migrations)
* **Sécurité & Authentification :** Authentification par Cookies, gestion des rôles (`Admin` / `Modérateur`), hachage des mots de passe avec **Argon2**
* **Front-end :** HTML5, CSS3, Bootstrap, Razor Views, JavaScript
* **Versioning & Qualité :** Git, Tests unitaires (à venir sur la `BLL`)

---

## 🏗️ Architecture de la solution

```text
Solution/
├── DAL/                 # Data Access Layer (Accès aux données)
│   ├── Configurations/  # Configurations Fluent API (IEntityTypeConfiguration<T>)
│   ├── Entities/        # Entités mappées avec SQL Server
│   ├── Migrations/      # Historique des migrations EF Core
│   ├── Repositories/    # Implémentations et interfaces des repositories
│   └── AppDbContext.cs  # Contexte de base de données
│
├── BLL/                 # Business Logic Layer (Logique métier)
│   ├── Mappers/         # Conversions Entity <-> Model
│   ├── Models/          # Modèles métiers
│   └── Services/        # Règles de gestion, validations et vérification Argon2
│
└── WebApp/              # Couche présentation (ASP.NET Core MVC)
    ├── Controllers/     # Contrôleurs MVC
    ├── Views/           # Vues Razor (.cshtml)
    └── wwwroot/         # Ressources statiques (CSS, JS, images)
```

---

## 🗄️ Modèle de base de données

La base de données comprend **5 tables** :

* **`Users`** : Comptes utilisateurs avec gestion de rôles (`Id`, `FirstName`, `LastName`, `Email` unique, `Pseudo` unique, `PasswordHash`, `Role`).
* **`Consoles`** : Consoles rétro disponibles sur place (`Id`, `Name`).
* **`VideoGames`** : Catalogue des jeux vidéo (`Id`, `Title`, `FK_Console_Id`).
* **`Categories`** : Catégories de la carte (`Id`, `Name`).
* **`ProductsMenu`** : Plats, snacks et boissons (`Id`, `Name`, `Description`, `Price`, `IsVegie`, `FK_Categorie_Id`).

---

## 📌 État d'avancement du projet

### ✅ Fonctionnalités implémentées
* **Navigation publique :** Accès aux pages de présentation du site vitrine.
* **Authentification & Rôles :** Connexion et déconnexion par cookies pour les comptes **Admin** et **Modérateur** (vérification de mot de passe via Argon2) avec affichage conditionnel dans les vues.
* **Gestion des Consoles :** Ajout et suppression de consoles rétro pour les utilisateurs autorisés.

### 🚧 Reste à faire (Roadmap)
* [ ] CRUD complet pour les **Jeux Vidéo** (liaison avec les consoles).
* [ ] CRUD complet pour la **Carte** (Catégories et Produits du menu).
* [ ] Ajout de fonctionnalités dynamiques en **JavaScript** (ex. filtres sur la carte / les jeux).
* [ ] Mise en place du projet de **Tests Unitaires** pour la `BLL`.

---

## 🚀 Installation et lancement en local

### Prérequis
* [.NET 10 SDK](https://microsoft.com)
* SQL Server / SQL Server LocalDB (inclus avec Visual Studio)

### Étapes d'installation

1. **Cloner le dépôt :**
   ```bash
   git clone <url-de-ton-depot-git>
   cd <nom-du-dossier>
   ```

2. **Configurer la chaîne de connexion :**
   Vérifie ou adapte la `ConnectionString` dans le fichier `WebApp/appsettings.json` :
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=RetroGameCafeDb;Trusted_Connection=True;TrustServerCertificate=True;"
     }
   }
   ```

3. **Créer la base de données via les migrations EF Core :**
   Dans la Console du Gestionnaire de package (avec `DAL` en projet par défaut et `WebApp` en projet de démarrage) :
   ```powershell
   Update-Database
   ```
   *Ou via le terminal .NET CLI :*
   ```bash
   dotnet ef database update --project DAL --startup-project WebApp
   ```

4. **Lancer l'application :**
   Démarre le projet `WebApp` depuis Visual Studio (`F5`) ou via :
   ```bash
   dotnet run --project WebApp
   ```
