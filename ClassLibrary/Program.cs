using System.CommandLine;
using System.CommandLine.Invocation;
using System.CommandLine.NamingConventionBinder;
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.

namespace ClassLibrary;

class Program
{
    static async Task Main(string[] args)
    {
 
        var cmd = new RootCommand
        {
            new Option<string>(name: "--conn-type", description: "This accepts win or sql"){ IsRequired = true},
            new Option<string>(name: "--conn-server", description: "The SQL Server Name"){ IsRequired = true},
            new Option<string>(name: "--conn-db", description: "The SQL Database Name"){ IsRequired = true},
            new Option<string>(name: "--conn-user", description: "The SQL Auth User Name", getDefaultValue: () => "sa"),
            new Option<string>(name: "--conn-pass", description: "The SQL Auth User Pass"),
            new Option<string>(name: "--sqlite-path", description: "The path for the sqlite database to be created. Note this must be fully qualified. or it will create it where the bin is"){ IsRequired = true}

        };

        cmd.Handler = CommandHandler.Create<string, string, string, string?, string?, string>((connType, connServer, connDb, connUser, connPass, sqlitePath) =>
        {
            string sqlConnString = "";
            string dirPath = Path.GetDirectoryName(sqlitePath)!;
            string fileName = Path.GetFileName(sqlitePath);
            DirectoryInfo di = System.IO.Directory.CreateDirectory(dirPath);

            if (di == null)
            {
                Console.WriteLine("Sorry but can't create your file in that dir");
                return;
            }

            if (connType == "win")
            {
                sqlConnString = GetSqlServerConnectionString(connServer, connDb);
            }
            else
            {
                if (connUser == null || connPass == null)
                {
                    Console.WriteLine("You must provide user and pass if you are not going to use windows auth");
                    return;
                }
                sqlConnString = GetSqlServerConnectionString(connServer, connDb, connUser, connPass);
            }

            // change true to argument for Triggers
            // change false to argument for Views
            // change true to argument for GuiDAs String
            SqlServerToSQLite.ConvertSqlServerToSQLiteDatabase(sqlConnString, sqlitePath, null, null,
                null, null, true, false, true, true);
            

        });

        // KP
        await cmd.InvokeAsync(args);



    }
    static string GetSqlServerConnectionString(string address, string db)
    {
        string res = $@"Data Source={address.Trim()};Initial Catalog={db.Trim()};Integrated Security=SSPI;";
        return res;
    }
    static string GetSqlServerConnectionString(string address, string db, string user, string pass)
    {
        string res = @"Data Source=" + address.Trim() +
                     ";Initial Catalog=" + db.Trim() + ";User ID=" + user.Trim() + ";Password=" + pass.Trim();
        return res;
    }

    //private static string GetSqlServerConnectionString(string address, string db)
    //{
    //    string res = @"Data Source=" + address.Trim() +
    //            ";Initial Catalog=" + db.Trim() + ";Integrated Security=SSPI;";
    //    return res;
    //}
    //private static string GetSqlServerConnectionString(string address, string db, string user, string pass)
    //{
    //    string res = @"Data Source=" + address.Trim() +
    //        ";Initial Catalog=" + db.Trim() + ";User ID=" + user.Trim() + ";Password=" + pass.Trim();
    //    return res;
    //}
}