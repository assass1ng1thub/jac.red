# Установка
curl -s https://raw.githubusercontent.com/immisterio/jac.red/main/install.sh | bash

# Источники 
* Kinozal, Nnmclub, Rutor, Torrentby, Bitru, Rutracker, Selezen, Toloka (UKR), Rezka, Baibako, Anilibria, Animelayer, Anifilm

# Настройка
1. Указать логины и пароли в init.conf
2. Перенести в "crontab -e" данные с файла "Data/crontab"

# Доступ к доменам .onion
1. Запустить tor на порту 9050
2. В init.conf указать .onion домен в host

# Пример init.conf
* Список всех параметров, а так же значения по умолчанию смотреть в example.conf 
* В init.conf нужно указывать только те параметры, которые хотите изменить

```
{
  "listenport": 9120, // изменили порт
  "NNMClub": {        // изменили домен на адрес из сети tor 
    "host": "http://nnmclub2vvjqzjne6q4rrozkkkdmlvnrcsyes2bbkm7e5ut2aproy4id.onion"
  },
  "globalproxy": [
    {
      "pattern": "\\.onion",  // запросы на домены .onion отправить через прокси
      "list": [
        "socks5://127.0.0.1:9050" // прокси сервер tor
      ]
    }
  ]
}
```
