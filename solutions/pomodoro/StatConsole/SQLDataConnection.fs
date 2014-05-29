// The SqlDataConnection (LINQ to SQL) TypeProvider allows you to write code that uses 
// a live connection to a database. For more information, please go to 
//    http://go.microsoft.com/fwlink/?LinkId=229209

namespace Pomodoro.Stat

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

    let entry_num = query {
        for row in db.Entry do
            select row
            count
    }

    let entry_num_with_default_description = query {
        for row in db.Entry do
            where (row.Description = "What have you done?")
            select row
            count
    }

    let entry_per_day (day : string) = query {
        let day = System.DateTime.Parse day
        for row in db.Entry do
            where (row.Timestamp.Year = day.Year)
            where (row.Timestamp.Month = day.Month)
            where (row.Timestamp.Day = day.Day)
            select row
            count
    }

    let entry_num_with_default_description_percent = (double (double entry_num_with_default_description) / (double entry_num ) * (double 100))

    let tag_num_by_entry (entry : int) = query {
        for row in db.Entry_Tag do
            where (row.EntryID = entry)
            select row
            count
    }

    let add a b =
        a + b

    let increment x =
        x + 1

    let decrement x =
        x - 1

    let concat (a : string) (b : string) =
        a + b

    let life =
        (double (38 + 2 + 1 + 1) * 0.5 * 2.0)

    let printer = 
        for entry in entry_table do
            printfn "%d %s %s" entry.EntryID (entry.Timestamp.ToString "yyyy-MM-dd HH:mm:ss") entry.Description
     
        