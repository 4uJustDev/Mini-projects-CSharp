using SQLite;

namespace wfaSQLite
{
    public partial class Form1 : Form
    {
        private SQLiteConnection db;

        public Form1()
        {
            InitializeComponent();

            db = new SQLiteConnection("myDB.db");
            db.CreateTable<Log>();
            db.CreateTable<User>();
            db.CreateTable<City>();

            db.Insert(new Log() { DT = DateTime.Now });
            lvLogs.View = View.Details;
            lvLogs.Columns.Add("Дата и время", 200);
            foreach (var item in db.Table<Log>())
            {
                lvLogs.Items.Add(item.DT.ToString());
            }

            buShowLogs.Click += (s, e) => dataGridView1.DataSource = db.Table<Log>().ToList();
            buShowUsers.Click += (s, e) => dataGridView1.DataSource = db.Table<User>().ToList();
            buShowCities.Click += (s, e) => dataGridView1.DataSource = db.Table<City>().ToList();

            Random rnd = new();
            db.Insert(new City() { Name = $"Город - {rnd.Next()}" });

            buExecuteOne.Click += (s, e) => MessageBox.Show(db.ExecuteScalar<int>(edSQL.Text).ToString());
            buExecuteSQL.Click += (s, e) => dataGridView1.DataSource = db.Query<City>(edSQL.Text).ToList();

            // HW:
            // добавить еще функционал
            
        }
    }

    [Table("Cities")]
    internal class City
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
    }

    internal class User
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string FIO { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
    }

    internal class Log
    {
        public DateTime DT { get; set; }
    }
}