# Tales Of Shadowland - Game Server C#

## Host / Proxy

```
$ sudo nano /etc/nginx/site-enable/default
```

```
upstream api {
    server localhost:6588;
}

server {
    listen 80;
    listen [::]:80;
    server_name meuserver.com;

    location / {
        proxy_pass http://api;
        proxy_http_version 1.1;
        proxy_set_header Upgrade $http_upgrade;
        proxy_set_header Connection 'upgrade';
        proxy_set_header Host $host;
        proxy_cache_bypass $http_upgrade;
    }
}
```

## Dev Mode

To start the application in dev mode use the following commands

```bash
$ git clone git@github.com:andrehrferreira/tos-mmorpg-server-csharp.git server
$ cd server
$ dotnet build --configuration Debug
```

## Build

```bash
$ dotnet build --configuration Release
$ dotnet server.dll
```
