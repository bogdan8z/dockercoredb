# Docker: .net core & ms sql


1. run local

a. locate docker-compose.yml

b. run(cmd)
>docker-compose build

>docker-compose up



2. if you want to install it on aws:

a. https://hub.docker.com/r/flashm01/test1coredb

b. ssh to instance and run:

>docker pull flashm01/test1coredb:db


>docker pull flashm01/test1coredb:api

c.run images:
>docker run -p 1433:1433 -d flashm01/test1coredb:db


>docker run -p 80:80 -p 443:443 -d flashm01/test1coredb:api



Modify an image and create another one:

>docker run -p 5432:5432 -d old-img

>docker commit --change "ENV POSTGRES_USER=u1 POSTGRES_PASSWORD=p1" c5e new-img

>docker run -p 5432:5432 -d new-img

>check if ok: open container:ec2-user: printenv
