# .NET core app

1. Add secrets

  ``` json
    {
      "DbHost": "my local/docker ip",
      "DbPassword": "my_db_pass",
      "DbUser": "my_db_user"
    }
  ```

2. Generate models from database

> Scaffold-DbContext "User ID=myuser;Password=mypass;server=192.168.1.12;Pooling=true;Database=DemoData;" Npgsql.EntityFrameworkCore.PostgreSQL -OutputDir Models

3. Parameter store (check documents/parameters.jpg)

  3.1. using PopulateSampleDataForThisProject.cs you can create /dotnet-aws-samples/systems-manager-sample/common/settings/ parameters

  3.2. also there are 3 parameters for db:

    Private IPs of the instance:
    /prod/test-aws/databases/products-api/DbHost

    db user
    /prod/test-aws/databases/products-api/DbUser

    db pass
    /prod/test-aws/databases/products-api/DbPassword

  3.3. Parameter store format:

    /env/prj-name/subprj-name/key-group/key-name
    i.e. /prod/test-aws/products-api/database/DbHost

4. Endpoints:

    - /product

    - /settings

    - /testparameter/1

    - /testparameter/2

    - /weatherforecast/1