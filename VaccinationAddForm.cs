using Npgsql;
using NpgsqlTypes;
using System.Data;
using WinFormsApp1;

namespace VaccinationsWF
{
    public partial class VaccinationAddForm : Form
    {
        public VaccinationAddForm()
        {
            InitializeComponent();
            TypeBox.DataSource = new BindingSource(new Dictionary<int, string>()
            {
                { 1, "Прививка от гриппа" },
                { 2, "Ревакцинация от дифтерии" },
                { 3, "Ревакцинация от столбняка"},
                { 4, "Прививка от кори" },
                { 5, "Вакцинация от краснухи" },
                { 6, "Иммунизация против гепатита B" },
                { 7, "Прививка от гепатита А" },
                { 8, "Прививка от дизентиерии Зонне" },
            }, null);
            TypeBox.SelectedIndex = 0;
            TypeBox.DisplayMember = "Value";
            TypeBox.ValueMember = "Key";
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            VaccinationsTable? main = Owner as VaccinationsTable;
            if (main == null)
            {
                return;
            }
            DB db = new DB();
            db.openConnection();
            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO vaccination (\"employerId\", \"vaccinType\", \"vaccinDate\")" +
                " VALUES (@1, @2, @3) RETURNING id"
                , db.getConnection());
            command.Parameters.Add("@1", NpgsqlDbType.Bigint).Value = main.EmployerId;
            command.Parameters.Add("@2", NpgsqlDbType.Integer).Value = TypeBox.SelectedValue;
            command.Parameters.Add("@3", NpgsqlDbType.Date).Value = DatePicker.Value;
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Успешное добавление");
            }
            else
            {
                MessageBox.Show("Добавление не удалось");
            }
            db.closeConnection();
            main.VaccinationsTable_Load(sender, e);
            this.Close();
        }
    }
}
