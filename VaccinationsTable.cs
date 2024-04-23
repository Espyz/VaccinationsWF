using Npgsql;
using NpgsqlTypes;
using System.Data;
using WinFormsApp1;

namespace VaccinationsWF
{

    public partial class VaccinationsTable : Form
    {
        const int TableColumnsCount = 3;
        private string[] columnNames = { "id", "name", "date" };
        private string[] columnNamesRus = { "Идентификатор", "Название", "Дата" };
        private long employerId;
        public long EmployerId { get => employerId; set => employerId = value; }

        public VaccinationsTable()
        {
            InitializeComponent();
        }

        public void VaccinationsTable_Load(object sender, EventArgs e)
        {
            VaccinationView.Columns.Clear();
            DB db = new DB();
            DataTable table = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand("SELECT v.id, vt.name, to_char(v.\"vaccinDate\", 'dd.mm.YYYY') AS \"date\"" +
                                                            " FROM vaccination v" +
                                                            " INNER JOIN vaccintype vt ON v.\"vaccinType\" = vt.id" +
                                                            " WHERE v.\"employerId\" = @1" +
                                                            " ORDER BY id", db.getConnection());
            command.Parameters.Add("@1", NpgsqlDbType.Bigint).Value = employerId;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < TableColumnsCount; i++)
                {
                    VaccinationView.Columns.Add(columnNames[i], columnNamesRus[i]);
                }
                VaccinationView.ColumnHeadersVisible = true;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (VaccinationView.Rows.Count - 1 < i)
                    {
                        VaccinationView.Rows.Add();
                    }
                }
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    for (int j = 0; j < TableColumnsCount; j++)
                    {
                        VaccinationView.Rows[i].Cells[j].Value = table.Rows[i][columnNames[j]];
                    }
                }
                VaccinationView.Columns.Add(new DataGridViewButtonColumn());
                VaccinationView.Columns[TableColumnsCount].HeaderCell.Value = "Удаление";
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            VaccinationAddForm vaccinationAddForm = new VaccinationAddForm();
            vaccinationAddForm.Owner = this;
            vaccinationAddForm.ShowDialog(this);
        }

        private void VaccinationView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DB db = new DB();
                DataTable table = new DataTable();
                db.openConnection();
                NpgsqlCommand command = new NpgsqlCommand("DELETE FROM vaccination WHERE id = @1 RETURNING id", db.getConnection());
                command.Parameters.Add("@1", NpgsqlDbType.Bigint).Value = VaccinationView.Rows[e.RowIndex].Cells[0].Value;
                NpgsqlDataReader reader = command.ExecuteReader();
                db.closeConnection();
                VaccinationsTable_Load(sender, e);
            }
        }
    }
}
