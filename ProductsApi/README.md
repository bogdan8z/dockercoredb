.net core + postgres + docker + aws


add secrets
``` json
{
  "DbHost": "my local/docker ip",
  "DbPassword": "my_db_pass",
  "DbUser": "my_db_user"
}
```

generate models from database
>Scaffold-DbContext "User ID=myuser;Password=mypass;server=192.168.1.12;Pooling=true;Database=DemoData;" Npgsql.EntityFrameworkCore.PostgreSQL -OutputDir Models


parameter store (check documents/parameters.jpg)
1. using PopulateSampleDataForThisProject.cs you can create /dotnet-aws-samples/systems-manager-sample/common/settings/ parameters
2. also there are 3 parameters for db:
Private IPs of the instance:
/prod/test-aws/databases/products-api/DbHost
db user
/prod/test-aws/databases/products-api/DbUser
db pass
/prod/test-aws/databases/products-api/DbPassword

parameter store format:
> /env/prj-name/subprj-name/key-group/key-name
i.e. /prod/test-aws/products-api/database/DbHost

endpoints:
/product
/settings
/testparameter/1
/testparameter/2
/weatherforecast/1