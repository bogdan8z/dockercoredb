
FROM library/postgres



ARG sapass=abc
ENV POSTGRES_USER doc1
ENV POSTGRES_DB demodata
ENV POSTGRES_PASSWORD $sapass




# Create app directory
RUN mkdir -p /docker-entrypoint-initdb.d

# Bundle app source
COPY init.sql /docker-entrypoint-initdb.d
COPY products.csv /docker-entrypoint-initdb.d