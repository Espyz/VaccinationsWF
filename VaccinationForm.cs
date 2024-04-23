using Npgsql;
using System.Data;
using System.Windows.Forms;
using WinFormsApp1;

namespace VaccinationsWF
{
    public partial class VaccinationForm : Form
    {
        const int TableColumnsCount = 4;
        private string[] columnNames = { "id", "lastName", "name", "middleName" };
        private string[] columnNamesRus = { "Номер сотрудника", "Фамилия", "Имя", "Отчество" };

        public VaccinationForm()
        {
            InitializeComponent();
        }

        private void VaccinationForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            NpgsqlCommand command = new NpgsqlCommand("SELECT id, \"lastName\", name, \"middleName\"" +
                                                            " FROM employers" +
                                                            " ORDER BY id", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < TableColumnsCount; i++)
                {
                    EmployersTable.Columns.Add(columnNames[i], columnNamesRus[i]);
                }
                EmployersTable.ColumnHeadersVisible = true;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (EmployersTable.Rows.Count - 1 < i)
                    {
                        EmployersTable.Rows.Add();
                    }
                }
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    for (int j = 0; j < TableColumnsCount; j++)
                    {
                        EmployersTable.Rows[i].Cells[j].Value = table.Rows[i][columnNames[j]];
                    }
                }
                EmployersTable.Columns.Add(new DataGridViewButtonColumn());
                EmployersTable.Columns[TableColumnsCount].HeaderCell.Value = "Список вакцинаций";
            }
        }

        private void EmployersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                VaccinationsTable vaccinationsTable = new VaccinationsTable();
                vaccinationsTable.EmployerId = (long)senderGrid.Rows[e.RowIndex].Cells[0].Value;
                vaccinationsTable.Show();
            }
        }
    }
}