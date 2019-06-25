# Kinowy-system-rezerwacji

## Opis

Jest to aplikacja służąca do zarządzania systemem rezerwacji biletów w kinie.

Do jej głównych funkcjonalności należą:
- przeglądanie dostępnych seansów
- rezerwowanie miejsc na wybrane seanse
- przeglądanie dokonanych rezerwacji

System może zostać w przyszłości rozbudowany o następujące funkcjonalności:
- anulowanie dokonanych rezerwacji
- dodawanie filmów i seansów (dla administratorów)
- obsługa wielu sal kinowych
- filtrowanie filmów zgodnie z wiekiem użytkownika

Dostęp do systemu jest zabezpieczony mechanizmem logowania.

## Instrukcja obsługi

### Uruchamianie systemu

Do uruchomienia programu wymagany jest plik `KinowySystemRezerwacji.exe` oraz dostęp do lokalnej bazy danych. Instrukcje inicjalizujące bazę danych są opisane w dalszej części dokumentacji.

### Logowanie i rejestracja

Aby korzystać z systemu, należy mieć w nim zarejestrowane konto. Okno logowania i rejestracji uruchamia się po uruchomieniu pliku startowego. Przycisk na dole ekranu przełącza okno pomiędzy trybem logowania i rejestracji. 

Podczas rejestracji pola są sprawdzane pod kątem spełniania określonych kryteriów:
- Nazwa użytkownika: 8-14 znaków, nie zawiera znaku spacji
- Hasło: co najmniej 8 znaków, co najmniej jedna cyfra, co najmniej jedna wielka litera
- Imię: rozpoczyna się z wielkiej litery, co najwyżej 20 znaków
- Nazwisko: rozpoczyna się z wielkiej litery, co najwyżej 30 znaków
- Email: poprawny zgodnie z ogólnym standardem

W przypadku niespełnienia któregoś  z warunków, odpowiedni komunikat jest wyświetlany na ekranie.

### Korzystanie z systemu

Dane dotyczące zalogowanego użytkownika wyświetlane są na górze ekranu.

Ten rozdział zostanie jeszcze uzupełniony. //TODO

## Inicjalizacja bazy danych

System zapisuje dane do bazy danych o nazwie `kinowy_system_rezerwacji`, która domyślnie powinna znajdować się na lokalnym serwerze na komputerze. Jej dane dostępowe, znajdujące się w pliku źródłowym `DBInfo.resx`, to:
- DataBase: `kinowy_system_rezerwacji`
- Password: puste
- Port: `3306`
- Server: `localhost`
- User: `root`

W przypadku innej lokalizacji bazy danych, należy zaktualizować dane znajdujące się w tym pliku.

Skrypty SQL inicjalizujące bazę danych:
- `create-database.sql`: tworzy bazę danych, umożliwiając wprowadzanie danych
- `create-data.sql`: wprowadza do bazy danych przykładowe dane do każdej z tabel



