# .NET SQLi Lab

Une application ASP.NET Core vulnérable à l'injection SQL, pour entraînement local.

## Lancer avec Docker

```bash
sudo docker-compose down -v # pour recommencer si besoin
docker-compose up --build


# Ensuite, accéder à : http://localhost:5000/Login

## Scénario SQL Injection

### Tenter avec les payloads :

```bash
' OR 1=1--

' OR '1'='1' --

admin'--

admin' OR '1'='1' --

Username = un de ces, password = n'importe quoi.
