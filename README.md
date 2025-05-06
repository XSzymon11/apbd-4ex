# TESTOWANIE

============================ pobierania listy zwierząt (GET) ============================
https://localhost:7222/api/animal

================== pobierania danych konkretnego zwierzęcia po id (GET) =================
https://localhost:7222/api/animal/4

============================== dodawania zwierzęcia (POST) ==============================
https://localhost:7222/api/animal

BODY:
{
    "Name": "Szymon",
    "Category": "koń",
    "Weight": "93",
    "HairColor": "niebieski"
}

============================= edycji danych zwierzęcia (PUT) =============================
https://localhost:7222/api/animal/5

BODY:
{
    "Name": "Kacper",
    "Category": "źrebak",
    "Weight": "130",
    "HairColor": "czarny"
}

============================== usuwania zwierzęcia (DELETE) ==============================
https://localhost:7222/api/animal/5

================ wyszukania wszystkich zwierząt na podstawie imienia (GET) ===============
https://localhost:7222/api/animal/search?name=Angel

= chcielibyśmy mieć możliwość pobrania listy wizyt powiązanych z danym zwierzęciem (GET) =
https://localhost:7222/api/visit/3

================ chcielibyśmy mieć możliwość dodawania nowych wizyt (POST) ================
https://localhost:7222/api/visit/3

BODY:
{
  "dateTime": "2025-05-06T23:45:00",
  "description": "Vaccination",
  "cost": 150.0
}

można sprawdzić dając ponownie GET -> https://localhost:7222/api/visit/3
