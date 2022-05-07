# Chatterino! - Simple IRC App
- aplicatie simpla de chat folosind API IRC (Internet Relay Chat);
- conturile sunt salvate/verificate in baza de date online (Azure);
- proiect realizat pentru laboratorul de MTP si PIUG;

## Fereastra principala
- se deschide la prima rulare a aplicatiei;

![MainWindow](https://user-images.githubusercontent.com/92821731/167261250-cf5c662a-ac02-4a1a-97e3-f6ba31d3a031.png)

- daca s-a uitat parola de la cont, aceasta poate fi recuperata din baza de date si trimisa pe email
![Parola](https://user-images.githubusercontent.com/92821731/167261664-c99421c2-0e9f-4948-904f-fd4e9cdb2c55.png)

![ParolaSucc](https://user-images.githubusercontent.com/92821731/167261762-330212ab-9e47-4aa7-aceb-c9d72478ef73.png)
![ParolaRecuperata](https://user-images.githubusercontent.com/92821731/167261764-42f24318-4238-43c9-a1dd-1b271b01a84d.jpg)



Conectare realizata cu succes.

![LoginMessage](https://user-images.githubusercontent.com/92821731/167261280-43bc8271-1cdc-4758-bfdf-3843965561d2.png)


### Interfata de chat.
- userlist-ul din stanga se actualizeaza periodic pe baza unui timer;
- pentru a scrie un mesaj se introduce textul in caseta si se apasa butonul Trimite sau ENTER;
- deconectarea se face prin apasarea butonului sau prin click dreapta pe Icon Tray-ul din taskbar;
![MessagesOnChat](https://user-images.githubusercontent.com/92821731/167261307-6fdddc21-1afd-4018-8cb0-962b0d097289.png)
![FromHexchat](https://user-images.githubusercontent.com/92821731/167261931-585e6185-c9f6-4c7b-b053-68b5520b23d1.png)

![Tray1](https://user-images.githubusercontent.com/92821731/167261496-32f51d06-4b68-4437-a634-0fd264cb9995.png)
![Tray2](https://user-images.githubusercontent.com/92821731/167261506-c94f16be-8b39-403d-aa05-58b5eacf68e2.png)

### Fereastra de inregistrare
![RegisterWindow](https://user-images.githubusercontent.com/92821731/167261597-a0e1f3ee-f4d7-44b8-9769-da1542602250.png)
![MesajContCreat](https://user-images.githubusercontent.com/92821731/167261815-df5bac97-5ebc-43e2-862c-bf0c1e236c6d.png)
![ContCreat](https://user-images.githubusercontent.com/92821731/167261891-b6d5c313-3d43-448b-93a5-1c21cdf1d41b.png)







### Fereastra de Help
![HelpWindow](https://user-images.githubusercontent.com/92821731/167261543-f602d848-77c4-4463-9740-22a6a591f952.png)
- la apasarea pe hyperlink-ul "aici" se va deschide o mini fereastra cu detalii;

![About](https://user-images.githubusercontent.com/92821731/167261924-98482595-ee81-4300-89b9-74b8b5c5a61a.png)

### Fereastra de Feedback/Intrebari
![FeedbackWindow](https://user-images.githubusercontent.com/92821731/167261963-1221d443-c03f-4053-99c3-57c97e10aa7c.png)
![FeedbackWindow2](https://user-images.githubusercontent.com/92821731/167261968-3e1f5bde-fa0a-4fc5-ab41-572e7f197b8e.png)
- mesajul este primit pe adresa de mail setata din aplicatie;
![FeedbackMessageReceived](https://user-images.githubusercontent.com/92821731/167261971-4ac9facc-27ba-4612-a195-ea4a0620e3a6.png)

### Structura bazei de date
- parolele sunt criptate;

![Database](https://user-images.githubusercontent.com/92821731/167262095-370f4873-91ac-4520-b8d8-18cfe4555f01.png)





