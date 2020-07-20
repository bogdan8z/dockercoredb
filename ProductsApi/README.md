add secrets
>{
  "DbHost": "my local/docker ip",
  "DbPassword": "my_db_pass",
  "DbUser": "my_db_user"
}

generate models from database
>Scaffold-DbContext "User ID=myuser;Password=mypass;server=192.168.1.12;Pooling=true;Database=DemoData;" Npgsql.EntityFrameworkCore.PostgreSQL -OutputDir Models
