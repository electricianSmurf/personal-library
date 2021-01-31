using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;//added

using System.Windows.Forms.DataVisualization.Charting;//added

namespace home_library_automation
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConn = new SqlConnection("Data Source = R-BILGISAYAR; Initial Catalog = library; Integrated Security = SSPI");
        SqlDataAdapter dataAdapter;
        SqlCommand command;

        DataTable dTable;

        string sqlQuery;

        bool isUpdatedOrAdded;

        List<string> lstDates = new List<string>();
        List<int> lstPages = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            tidyFormForAdding();

            pnlAddNewBook.Visible = true;
            btnExecuteAdding.Visible = true;
            btnExecuteAdding.Text = "Add";
        }
        void tidyFormForAdding()
        {
            hidePanels();

            hideIndicatorsAndButtons();

            TBoxBookName.Clear();
            TBoxWriter.Clear();
            TBoxPublisher.Clear();
            TBoxGenre.Clear();

            CBoxRead.Checked = false;
            CBoxUnread.Checked = false;

            TBoxTotalBookNumber.Visible = false;
            lblTotalBook.Visible = false;
        }
        void hidePanels()
        {
            pnlAddReadPages.Visible = false;
            pnlBookSearch.Visible = false;
            pnlAddNewBook.Visible = false;
        }
        void hideIndicatorsAndButtons()
        {
            btnAddReadPages.Visible = false;
            btnShowReadPages.Visible = false;
            btnUpdateBook.Visible = false;

            lblSearchingText.Visible = false;
            TBoxSearchingText.Visible = false;
            btnBack.Visible = false;
            btnExecuteSearch.Visible = false;

            chart1.Visible = false;
            dataGridView1.Visible = false;
        }
        private void btnExecuteAdding_Click(object sender, EventArgs e)
        {
            if (!isUpdatedOrAdded)
            {
                addNewBook();
            }
            else
            {
                updateBookReadStatus();
            }

            isUpdatedOrAdded = false;
            btnExecuteAdding.Visible = false;
            showAllBooks();
        }
        void addNewBook()
        {
            try
            {
                sqlQuery = "insert into BOOKS (bookName, bookWriter, bookPublisher, bookGenre, bookStatus) " +
                "values (@name, @writer, @publisher, @genre, @status)";
                command = new SqlCommand(sqlQuery, sqlConn);
                getAddingBookParameters();
                executeInserting();

                MessageBox.Show("New Book Added!");
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Failed!");
            }
        }
        void getAddingBookParameters()
        {
            command.Parameters.AddWithValue("@name", TBoxBookName.Text);
            command.Parameters.AddWithValue("@writer", TBoxWriter.Text);
            command.Parameters.AddWithValue("@publisher", TBoxPublisher.Text);
            command.Parameters.AddWithValue("@genre", TBoxGenre.Text);
            command.Parameters.AddWithValue("@status", checkIsBookRead());
        }
        void executeInserting()
        {
            sqlConn.Open();
            command.ExecuteNonQuery();
            sqlConn.Close();
        }
        void showAllBooks()
        {
            try
            {
                sqlQuery = "select * from BOOKS order by bookId";
                dataAdapter = new SqlDataAdapter(sqlQuery, sqlConn);
                fillGridView();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Failed!");
            }
        }
        void fillGridView()
        {
            dTable = new DataTable();

            dataAdapter.Fill(dTable);
            dataGridView1.DataSource = dTable;
            setGridSettings();
        }
        void setGridSettings()
        {
            dataGridView1.Visible = true;
            if (dataGridView1.RowCount > 0)
            {
                dataGridView1.Rows[dataGridView1.RowCount - 1].Selected = true;
            }
            dataGridView1.Columns["bookId"].Visible = false;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        void updateBookReadStatus()
        {
            try
            {
                sqlQuery = "update BOOKS set bookStatus = @status where bookName = @name";
                command = new SqlCommand(sqlQuery, sqlConn);
                command.Parameters.AddWithValue("@status", checkIsBookRead());
                command.Parameters.AddWithValue("@name", dataGridView1.CurrentRow.Cells["bookName"].Value);
                executeInserting();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Failed!");
            }
        }
        private bool checkIsBookRead()
        {
            bool status = false;
            if (CBoxRead.Checked && !CBoxUnread.Checked)
            {
                status = true;
            }
            else if (CBoxUnread.Checked && !CBoxRead.Checked)
            {
                status = false;
            }
            return status;
        }
        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            hidePanels();
            hideIndicatorsAndButtons();

            pnlBookSearch.Visible = true;
            pnlBookSearch.Location = new Point(1, 50);

            setSearchingSettings();
        }
        void setSearchingSettings()
        {
            btnSearchByBookName.Visible = true;
            btnSearchByWriter.Visible = true;
            btnSearchByPublisher.Visible = true;
            btnSearchByGenre.Visible = true;
            TBoxSearchingText.Clear();
        }
        private void btnSearchByBookName_Click(object sender, EventArgs e)
        {
            hideSearchButtons();

            btnSearchByBookName.Visible = true;

            showSearchItems();

            sqlQuery = "select * from BOOKS where bookName like @text + '%' order by bookId";
        }
        void hideSearchButtons()
        {
            btnSearchByBookName.Visible = false;
            btnSearchByWriter.Visible = false;
            btnSearchByPublisher.Visible = false;
            btnSearchByGenre.Visible = false;
        }
        void showSearchItems()
        {
            TBoxSearchingText.Visible = true;
            lblSearchingText.Visible = true;
            btnExecuteSearch.Visible = true;
            btnBack.Visible = true;
        }
        private void btnSearchByWriter_Click(object sender, EventArgs e)
        {
            hideSearchButtons();

            btnSearchByWriter.Visible = true;

            showSearchItems();

            sqlQuery = "select * from BOOKS where bookWriter like @text + '%' order by bookId";
        }

        private void btnSearchByPublisher_Click(object sender, EventArgs e)
        {
            hideSearchButtons();

            btnSearchByPublisher.Visible = true;

            showSearchItems();

            sqlQuery = "select * from BOOKS where bookPublisher like @text + '%' order by bookId";
        }

        private void btnSearchByGenre_Click(object sender, EventArgs e)
        {
            hideSearchButtons();

            btnSearchByGenre.Visible = true;

            showSearchItems();

            sqlQuery = "select * from BOOKS where bookGenre like @text + '%' order by bookId";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnBack.Visible = false;
            dataGridView1.Visible = false;

            setSearchingSettings();

            TBoxSearchingText.Visible = false;
            btnExecuteSearch.Visible = false;
            lblSearchingText.Visible = false;
        }

        private void btnExecuteSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBoxSearchingText.Text) || TBoxSearchingText.Text == " ")
            {
                MessageBox.Show("Please enter something!");
                TBoxSearchingText.Clear();
            }
            else
            {
                executeSearch();                

                btnUpdateBook.Visible = true;
            }
        }
        void executeSearch()
        {
            try
            {
                dataAdapter = new SqlDataAdapter();
                command = new SqlCommand(sqlQuery, sqlConn);
                command.Parameters.AddWithValue("@text", TBoxSearchingText.Text);
                dataAdapter.SelectCommand = command;
                fillGridView();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Failed!");
            }
        }
        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            tidyFormForShowingBooks();

            btnExecuteAdding.Visible = false;

            showBooks();
            
            btnUpdateBook.Visible = true;
        }
        void tidyFormForShowingBooks()
        {
            hidePanels();
            pnlAddNewBook.Visible = true;

            lblTotalBook.Visible = true;
            TBoxTotalBookNumber.Visible = true;

            chart1.Visible = false;

            btnAddReadPages.Visible = false;
            btnShowReadPages.Visible = false;
        }
        void showBooks()
        {
            try
            {
                sqlQuery = "select * from BOOKS order by bookId";
                dataAdapter = new SqlDataAdapter(sqlQuery, sqlConn);

                fillGridView();
                TBoxTotalBookNumber.Text = dataGridView1.RowCount.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Failed!");
            }
        }
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            hidePanels();
            pnlAddNewBook.Visible = true;

            isUpdatedOrAdded = true;

            btnExecuteAdding.Text = "Update";
            btnExecuteAdding.Visible = true;
        }
        private void btnShowStatistics_Click(object sender, EventArgs e)
        {
            hidePanels();

            btnShowReadPages.Visible = true;
            btnAddReadPages.Visible = true;

            btnUpdateBook.Visible = false;
            dataGridView1.Visible = false;

            chart1.Visible = false;
        }
        private void btnShowReadPages_Click(object sender, EventArgs e)
        {
            pnlAddReadPages.Visible = false;

            clearDatePageLists();

            getReadPagesFromSql();

            fillDatePageLists();
            
            chart1.Visible = true;
            chart1.Series.Clear();
            chart1.Series.Add(createNewSeries());

            setChartSettings();
        }
        void clearDatePageLists()
        {
            lstDates.Clear();
            lstPages.Clear();
            lstDates.TrimExcess();
            lstPages.TrimExcess();
        }
        void getReadPagesFromSql()
        {
            try
            {
                sqlQuery = "select Date, SUM(page) as Page from readpages group by date order by date";
                dataAdapter = new SqlDataAdapter(sqlQuery, sqlConn);
                dTable = new DataTable();
                dataAdapter.Fill(dTable);
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Failed!");
            }
        }
        void fillDatePageLists()
        {
            for (int i = 0; i < dTable.Rows.Count; i++)
            {
                lstDates.Add(Convert.ToDateTime(dTable.Rows[i]["date"]).ToShortDateString());
                lstPages.Add(Convert.ToInt32(dTable.Rows[i]["page"]));
            }
        }
        private Series createNewSeries()
        {
            Series mySeries = new Series();

            mySeries.Name = "Pages";
            mySeries.Color = Color.Green;
            mySeries.IsValueShownAsLabel = true;
            mySeries.Points.DataBindXY(lstDates, lstPages);

            return mySeries;
        }
        void setChartSettings()
        {
            chart1.Series[0]["PixelPointWidth"] = "10";//column width

            chart1.ChartAreas[0].AxisX.Maximum = double.NaN;
            chart1.ChartAreas[0].AxisY.Maximum = double.NaN;

            chart1.ChartAreas[0].AxisX.ScaleView.Size = 10;

            //to delete chart's grid lines
            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = 90;
            chart1.ChartAreas[0].AxisX.Interval = 1;
        }
        private void btnAddReadPages_Click(object sender, EventArgs e)
        {
            pnlAddReadPages.Visible = true;
            pnlAddNewBook.Location = new Point(1, 50);

            chart1.Visible = false;
        }
        private void btnAddPages_Click(object sender, EventArgs e)
        {
            addPages();

            TBoxPageAmount.Clear();
        }
        void addPages()
        {
            try
            {
                sqlQuery = "insert into READPAGES(date, page) values(@date, @page)";
                command = new SqlCommand(sqlQuery, sqlConn);
                command.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);
                if (!string.IsNullOrEmpty(TBoxPageAmount.Text))
                {
                    command.Parameters.AddWithValue("@page", TBoxPageAmount.Text);
                }

                executeInserting();

                MessageBox.Show("Pages Added!");
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Failed!");
            }
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int selectedRow = e.RowIndex;

                TBoxBookName.Text = dataGridView1.Rows[selectedRow].Cells["bookName"].Value.ToString();
                TBoxWriter.Text = dataGridView1.Rows[selectedRow].Cells["bookWriter"].Value.ToString();
                TBoxPublisher.Text = dataGridView1.Rows[selectedRow].Cells["bookPublisher"].Value.ToString();
                TBoxGenre.Text = dataGridView1.Rows[selectedRow].Cells["bookGenre"].Value.ToString();

                if (Convert.ToBoolean(dataGridView1.Rows[selectedRow].Cells["bookStatus"].Value))//if true
                {
                    CBoxRead.Checked = true;
                    CBoxUnread.Checked = false;
                }
                else
                {
                    CBoxUnread.Checked = true;
                    CBoxRead.Checked = false;
                }
            }
        }
        private void CBoxRead_Click(object sender, EventArgs e)
        {
            CBoxUnread.Checked = false;
        }
        private void CBoxUnread_Click(object sender, EventArgs e)
        {
            CBoxRead.Checked = false;
        }

    }
}
