FROM microsoft/mssql-server-linux:latest
ARG sapass=abc
ENV ACCEPT_EULA=Y        
        ENV SA_PASSWORD=$sapass
        ENV MSSQL_PID=Developer
        ENV MSSQL_TCP_PORT=1433 

# Create app directory
RUN mkdir -p /usr/src/app
WORKDIR /usr/src/app

# Bundle app source
COPY . /usr/src/app

 RUN (/opt/mssql/bin/sqlservr --accept-eula & ) | grep -q "Service Broker manager has started" &&  /opt/mssql-tools/bin/sqlcmd -S127.0.0.1 -Usa -P$sapass -d master -i setup.sql && /opt/mssql-tools/bin/bcp DemoData.dbo.Products in "/usr/src/app/Products.csv" -c -t',' -S localhost -Usa -P$sapass
