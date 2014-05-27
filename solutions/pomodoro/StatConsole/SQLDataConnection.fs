// The SqlDataConnection (LINQ to SQL) TypeProvider allows you to write code that uses 
// a live connection to a database. For more information, please go to 
//    http://go.microsoft.com/fwlink/?LinkId=229209

namespace Pomodoro.Stat.SQLDataConnection

module SQLDataConnection =

    #if INTERACTIVE
    #r "System.Data"
    #r "System.Data.Linq"
    #r "FSharp.Data.TypeProviders"
    #endif

    open System.Data
    open System.Data.Linq
    open Microsoft.FSharp.Data.TypeProviders

    // You can use Server Explorer to build your ConnectionString. 
    type SqlConnection = Microsoft.FSharp.Data.TypeProviders.SqlDataConnection<ConnectionString = @"Data Source=MITHRIEL-VM;Initial Catalog=Pomodoro;Integrated Security=True">
    let db = SqlConnection.GetDataContext()

    let entry_table = query {
        for row in db.Entry do
            select row
        }

    let tag_table = query {
        for row in db.Tag do
            select row
        }

    let tag_num = query {
        for row in db.Tag do
            select row
            count
    }
    
    let printer = 
        for entry in entry_table do
            printfn "%d %s %s" entry.EntryID (entry.Timestamp.ToString "yyyy-MM-dd HH:mm:ss") entry.Description
     
        