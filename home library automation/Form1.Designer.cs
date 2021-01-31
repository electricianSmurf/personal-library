namespace home_library_automation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.btnBookSearch = new System.Windows.Forms.Button();
            this.btnShowBooks = new System.Windows.Forms.Button();
            this.pnlAddNewBook = new System.Windows.Forms.Panel();
            this.CBoxUnread = new System.Windows.Forms.CheckBox();
            this.CBoxRead = new System.Windows.Forms.CheckBox();
            this.TBoxTotalBookNumber = new System.Windows.Forms.TextBox();
            this.lblTotalBook = new System.Windows.Forms.Label();
            this.lblBookStatus = new System.Windows.Forms.Label();
            this.TBoxGenre = new System.Windows.Forms.TextBox();
            this.TBoxPublisher = new System.Windows.Forms.TextBox();
            this.TBoxWriter = new System.Windows.Forms.TextBox();
            this.TBoxBookName = new System.Windows.Forms.TextBox();
            this.btnExecuteAdding = new System.Windows.Forms.Button();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblWriter = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.pnlBookSearch = new System.Windows.Forms.Panel();
            this.lblSearchingText = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.arama_sonucu_lbl = new System.Windows.Forms.Label();
            this.btnExecuteSearch = new System.Windows.Forms.Button();
            this.TBoxSearchingText = new System.Windows.Forms.TextBox();
            this.btnSearchByGenre = new System.Windows.Forms.Button();
            this.btnSearchByPublisher = new System.Windows.Forms.Button();
            this.btnSearchByWriter = new System.Windows.Forms.Button();
            this.btnSearchByBookName = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShowStatistics = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnShowReadPages = new System.Windows.Forms.Button();
            this.btnAddReadPages = new System.Windows.Forms.Button();
            this.pnlAddReadPages = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAddPages = new System.Windows.Forms.Button();
            this.TBoxPageAmount = new System.Windows.Forms.TextBox();
            this.lblReadPageAmount = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlAddNewBook.SuspendLayout();
            this.pnlBookSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.pnlAddReadPages.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.Location = new System.Drawing.Point(0, 0);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(87, 23);
            this.btnAddNewBook.TabIndex = 0;
            this.btnAddNewBook.Text = "Add New Book";
            this.btnAddNewBook.UseVisualStyleBackColor = true;
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewBook_Click);
            // 
            // btnBookSearch
            // 
            this.btnBookSearch.Location = new System.Drawing.Point(87, 0);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Size = new System.Drawing.Size(75, 23);
            this.btnBookSearch.TabIndex = 1;
            this.btnBookSearch.Text = "Search";
            this.btnBookSearch.UseVisualStyleBackColor = true;
            this.btnBookSearch.Click += new System.EventHandler(this.btnBookSearch_Click);
            // 
            // btnShowBooks
            // 
            this.btnShowBooks.Location = new System.Drawing.Point(162, 0);
            this.btnShowBooks.Name = "btnShowBooks";
            this.btnShowBooks.Size = new System.Drawing.Size(75, 23);
            this.btnShowBooks.TabIndex = 2;
            this.btnShowBooks.Text = "Show Books";
            this.btnShowBooks.UseVisualStyleBackColor = true;
            this.btnShowBooks.Click += new System.EventHandler(this.btnShowBooks_Click);
            // 
            // pnlAddNewBook
            // 
            this.pnlAddNewBook.BackColor = System.Drawing.Color.Transparent;
            this.pnlAddNewBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddNewBook.Controls.Add(this.CBoxUnread);
            this.pnlAddNewBook.Controls.Add(this.CBoxRead);
            this.pnlAddNewBook.Controls.Add(this.TBoxTotalBookNumber);
            this.pnlAddNewBook.Controls.Add(this.lblTotalBook);
            this.pnlAddNewBook.Controls.Add(this.lblBookStatus);
            this.pnlAddNewBook.Controls.Add(this.TBoxGenre);
            this.pnlAddNewBook.Controls.Add(this.TBoxPublisher);
            this.pnlAddNewBook.Controls.Add(this.TBoxWriter);
            this.pnlAddNewBook.Controls.Add(this.TBoxBookName);
            this.pnlAddNewBook.Controls.Add(this.btnExecuteAdding);
            this.pnlAddNewBook.Controls.Add(this.lblGenre);
            this.pnlAddNewBook.Controls.Add(this.lblPublisher);
            this.pnlAddNewBook.Controls.Add(this.lblWriter);
            this.pnlAddNewBook.Controls.Add(this.lblBookName);
            this.pnlAddNewBook.Location = new System.Drawing.Point(1, 50);
            this.pnlAddNewBook.Name = "pnlAddNewBook";
            this.pnlAddNewBook.Size = new System.Drawing.Size(314, 173);
            this.pnlAddNewBook.TabIndex = 3;
            this.pnlAddNewBook.Visible = false;
            // 
            // CBoxUnread
            // 
            this.CBoxUnread.AutoSize = true;
            this.CBoxUnread.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBoxUnread.Location = new System.Drawing.Point(153, 94);
            this.CBoxUnread.Name = "CBoxUnread";
            this.CBoxUnread.Size = new System.Drawing.Size(71, 22);
            this.CBoxUnread.TabIndex = 14;
            this.CBoxUnread.Text = "Unread";
            this.CBoxUnread.UseVisualStyleBackColor = true;
            this.CBoxUnread.Click += new System.EventHandler(this.CBoxUnread_Click);
            // 
            // CBoxRead
            // 
            this.CBoxRead.AutoSize = true;
            this.CBoxRead.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBoxRead.Location = new System.Drawing.Point(86, 94);
            this.CBoxRead.Name = "CBoxRead";
            this.CBoxRead.Size = new System.Drawing.Size(57, 22);
            this.CBoxRead.TabIndex = 13;
            this.CBoxRead.Text = "Read";
            this.CBoxRead.UseVisualStyleBackColor = true;
            this.CBoxRead.Click += new System.EventHandler(this.CBoxRead_Click);
            // 
            // TBoxTotalBookNumber
            // 
            this.TBoxTotalBookNumber.Location = new System.Drawing.Point(86, 118);
            this.TBoxTotalBookNumber.Name = "TBoxTotalBookNumber";
            this.TBoxTotalBookNumber.Size = new System.Drawing.Size(62, 20);
            this.TBoxTotalBookNumber.TabIndex = 12;
            this.TBoxTotalBookNumber.Visible = false;
            // 
            // lblTotalBook
            // 
            this.lblTotalBook.AutoSize = true;
            this.lblTotalBook.Location = new System.Drawing.Point(4, 121);
            this.lblTotalBook.Name = "lblTotalBook";
            this.lblTotalBook.Size = new System.Drawing.Size(59, 13);
            this.lblTotalBook.TabIndex = 11;
            this.lblTotalBook.Text = "Total Book";
            this.lblTotalBook.Visible = false;
            // 
            // lblBookStatus
            // 
            this.lblBookStatus.AutoSize = true;
            this.lblBookStatus.Location = new System.Drawing.Point(4, 98);
            this.lblBookStatus.Name = "lblBookStatus";
            this.lblBookStatus.Size = new System.Drawing.Size(37, 13);
            this.lblBookStatus.TabIndex = 9;
            this.lblBookStatus.Text = "Status";
            // 
            // TBoxGenre
            // 
            this.TBoxGenre.Location = new System.Drawing.Point(86, 74);
            this.TBoxGenre.Name = "TBoxGenre";
            this.TBoxGenre.Size = new System.Drawing.Size(224, 20);
            this.TBoxGenre.TabIndex = 8;
            // 
            // TBoxPublisher
            // 
            this.TBoxPublisher.Location = new System.Drawing.Point(86, 52);
            this.TBoxPublisher.Name = "TBoxPublisher";
            this.TBoxPublisher.Size = new System.Drawing.Size(224, 20);
            this.TBoxPublisher.TabIndex = 7;
            // 
            // TBoxWriter
            // 
            this.TBoxWriter.Location = new System.Drawing.Point(86, 30);
            this.TBoxWriter.Name = "TBoxWriter";
            this.TBoxWriter.Size = new System.Drawing.Size(224, 20);
            this.TBoxWriter.TabIndex = 6;
            // 
            // TBoxBookName
            // 
            this.TBoxBookName.Location = new System.Drawing.Point(86, 8);
            this.TBoxBookName.Name = "TBoxBookName";
            this.TBoxBookName.Size = new System.Drawing.Size(224, 20);
            this.TBoxBookName.TabIndex = 5;
            // 
            // btnExecuteAdding
            // 
            this.btnExecuteAdding.Location = new System.Drawing.Point(126, 148);
            this.btnExecuteAdding.Name = "btnExecuteAdding";
            this.btnExecuteAdding.Size = new System.Drawing.Size(74, 23);
            this.btnExecuteAdding.TabIndex = 4;
            this.btnExecuteAdding.Text = "Add";
            this.btnExecuteAdding.UseVisualStyleBackColor = true;
            this.btnExecuteAdding.Click += new System.EventHandler(this.btnExecuteAdding_Click);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(4, 74);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(64, 13);
            this.lblGenre.TabIndex = 3;
            this.lblGenre.Text = "Book Genre";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(4, 52);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(50, 13);
            this.lblPublisher.TabIndex = 2;
            this.lblPublisher.Text = "Publisher";
            // 
            // lblWriter
            // 
            this.lblWriter.AutoSize = true;
            this.lblWriter.Location = new System.Drawing.Point(4, 30);
            this.lblWriter.Name = "lblWriter";
            this.lblWriter.Size = new System.Drawing.Size(35, 13);
            this.lblWriter.TabIndex = 1;
            this.lblWriter.Text = "Writer";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(4, 8);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(63, 13);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.Text = "Book Name";
            // 
            // pnlBookSearch
            // 
            this.pnlBookSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnlBookSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBookSearch.Controls.Add(this.lblSearchingText);
            this.pnlBookSearch.Controls.Add(this.btnBack);
            this.pnlBookSearch.Controls.Add(this.arama_sonucu_lbl);
            this.pnlBookSearch.Controls.Add(this.btnExecuteSearch);
            this.pnlBookSearch.Controls.Add(this.TBoxSearchingText);
            this.pnlBookSearch.Controls.Add(this.btnSearchByGenre);
            this.pnlBookSearch.Controls.Add(this.btnSearchByPublisher);
            this.pnlBookSearch.Controls.Add(this.btnSearchByWriter);
            this.pnlBookSearch.Controls.Add(this.btnSearchByBookName);
            this.pnlBookSearch.Location = new System.Drawing.Point(340, 43);
            this.pnlBookSearch.Name = "pnlBookSearch";
            this.pnlBookSearch.Size = new System.Drawing.Size(303, 120);
            this.pnlBookSearch.TabIndex = 4;
            this.pnlBookSearch.Visible = false;
            // 
            // lblSearchingText
            // 
            this.lblSearchingText.AutoSize = true;
            this.lblSearchingText.Location = new System.Drawing.Point(2, 54);
            this.lblSearchingText.Name = "lblSearchingText";
            this.lblSearchingText.Size = new System.Drawing.Size(79, 13);
            this.lblSearchingText.TabIndex = 19;
            this.lblSearchingText.Text = "Searching Text";
            this.lblSearchingText.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(3, 92);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(48, 25);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // arama_sonucu_lbl
            // 
            this.arama_sonucu_lbl.AutoSize = true;
            this.arama_sonucu_lbl.Location = new System.Drawing.Point(138, 74);
            this.arama_sonucu_lbl.Name = "arama_sonucu_lbl";
            this.arama_sonucu_lbl.Size = new System.Drawing.Size(10, 13);
            this.arama_sonucu_lbl.TabIndex = 8;
            this.arama_sonucu_lbl.Text = " ";
            this.arama_sonucu_lbl.Visible = false;
            // 
            // btnExecuteSearch
            // 
            this.btnExecuteSearch.Location = new System.Drawing.Point(113, 93);
            this.btnExecuteSearch.Name = "btnExecuteSearch";
            this.btnExecuteSearch.Size = new System.Drawing.Size(75, 23);
            this.btnExecuteSearch.TabIndex = 5;
            this.btnExecuteSearch.Text = "Search";
            this.btnExecuteSearch.UseVisualStyleBackColor = true;
            this.btnExecuteSearch.Visible = false;
            this.btnExecuteSearch.Click += new System.EventHandler(this.btnExecuteSearch_Click);
            // 
            // TBoxSearchingText
            // 
            this.TBoxSearchingText.Location = new System.Drawing.Point(90, 51);
            this.TBoxSearchingText.Name = "TBoxSearchingText";
            this.TBoxSearchingText.Size = new System.Drawing.Size(206, 20);
            this.TBoxSearchingText.TabIndex = 4;
            this.TBoxSearchingText.Visible = false;
            // 
            // btnSearchByGenre
            // 
            this.btnSearchByGenre.Location = new System.Drawing.Point(224, 3);
            this.btnSearchByGenre.Name = "btnSearchByGenre";
            this.btnSearchByGenre.Size = new System.Drawing.Size(75, 23);
            this.btnSearchByGenre.TabIndex = 3;
            this.btnSearchByGenre.Text = "Genre";
            this.btnSearchByGenre.UseVisualStyleBackColor = true;
            this.btnSearchByGenre.Click += new System.EventHandler(this.btnSearchByGenre_Click);
            // 
            // btnSearchByPublisher
            // 
            this.btnSearchByPublisher.Location = new System.Drawing.Point(150, 3);
            this.btnSearchByPublisher.Name = "btnSearchByPublisher";
            this.btnSearchByPublisher.Size = new System.Drawing.Size(75, 23);
            this.btnSearchByPublisher.TabIndex = 2;
            this.btnSearchByPublisher.Text = "Publisher";
            this.btnSearchByPublisher.UseVisualStyleBackColor = true;
            this.btnSearchByPublisher.Click += new System.EventHandler(this.btnSearchByPublisher_Click);
            // 
            // btnSearchByWriter
            // 
            this.btnSearchByWriter.Location = new System.Drawing.Point(76, 3);
            this.btnSearchByWriter.Name = "btnSearchByWriter";
            this.btnSearchByWriter.Size = new System.Drawing.Size(75, 23);
            this.btnSearchByWriter.TabIndex = 1;
            this.btnSearchByWriter.Text = "Writer";
            this.btnSearchByWriter.UseVisualStyleBackColor = true;
            this.btnSearchByWriter.Click += new System.EventHandler(this.btnSearchByWriter_Click);
            // 
            // btnSearchByBookName
            // 
            this.btnSearchByBookName.Location = new System.Drawing.Point(2, 3);
            this.btnSearchByBookName.Name = "btnSearchByBookName";
            this.btnSearchByBookName.Size = new System.Drawing.Size(75, 23);
            this.btnSearchByBookName.TabIndex = 0;
            this.btnSearchByBookName.Text = "Book Name";
            this.btnSearchByBookName.UseVisualStyleBackColor = true;
            this.btnSearchByBookName.Click += new System.EventHandler(this.btnSearchByBookName_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(312, 0);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateBook.TabIndex = 7;
            this.btnUpdateBook.Text = "Update Book";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Visible = false;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 230);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(622, 253);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnShowStatistics
            // 
            this.btnShowStatistics.Location = new System.Drawing.Point(237, 0);
            this.btnShowStatistics.Name = "btnShowStatistics";
            this.btnShowStatistics.Size = new System.Drawing.Size(75, 23);
            this.btnShowStatistics.TabIndex = 13;
            this.btnShowStatistics.Text = "Statistics";
            this.btnShowStatistics.UseVisualStyleBackColor = true;
            this.btnShowStatistics.Click += new System.EventHandler(this.btnShowStatistics_Click);
            // 
            // chart1
            // 
            chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.White;
            chartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 245);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(622, 237);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // btnShowReadPages
            // 
            this.btnShowReadPages.Location = new System.Drawing.Point(0, 23);
            this.btnShowReadPages.Name = "btnShowReadPages";
            this.btnShowReadPages.Size = new System.Drawing.Size(87, 23);
            this.btnShowReadPages.TabIndex = 16;
            this.btnShowReadPages.Text = "Show Statistics";
            this.btnShowReadPages.UseVisualStyleBackColor = true;
            this.btnShowReadPages.Visible = false;
            this.btnShowReadPages.Click += new System.EventHandler(this.btnShowReadPages_Click);
            // 
            // btnAddReadPages
            // 
            this.btnAddReadPages.Location = new System.Drawing.Point(87, 23);
            this.btnAddReadPages.Name = "btnAddReadPages";
            this.btnAddReadPages.Size = new System.Drawing.Size(101, 23);
            this.btnAddReadPages.TabIndex = 17;
            this.btnAddReadPages.Text = "Add Read Pages";
            this.btnAddReadPages.UseVisualStyleBackColor = true;
            this.btnAddReadPages.Visible = false;
            this.btnAddReadPages.Click += new System.EventHandler(this.btnAddReadPages_Click);
            // 
            // pnlAddReadPages
            // 
            this.pnlAddReadPages.BackColor = System.Drawing.Color.Transparent;
            this.pnlAddReadPages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddReadPages.Controls.Add(this.dateTimePicker1);
            this.pnlAddReadPages.Controls.Add(this.btnAddPages);
            this.pnlAddReadPages.Controls.Add(this.TBoxPageAmount);
            this.pnlAddReadPages.Controls.Add(this.lblReadPageAmount);
            this.pnlAddReadPages.Controls.Add(this.lblDate);
            this.pnlAddReadPages.Location = new System.Drawing.Point(225, 175);
            this.pnlAddReadPages.Name = "pnlAddReadPages";
            this.pnlAddReadPages.Size = new System.Drawing.Size(200, 100);
            this.pnlAddReadPages.TabIndex = 18;
            this.pnlAddReadPages.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(39, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(155, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // btnAddPages
            // 
            this.btnAddPages.Location = new System.Drawing.Point(64, 62);
            this.btnAddPages.Name = "btnAddPages";
            this.btnAddPages.Size = new System.Drawing.Size(75, 23);
            this.btnAddPages.TabIndex = 4;
            this.btnAddPages.Text = "Add";
            this.btnAddPages.UseVisualStyleBackColor = true;
            this.btnAddPages.Click += new System.EventHandler(this.btnAddPages_Click);
            // 
            // TBoxPageAmount
            // 
            this.TBoxPageAmount.Location = new System.Drawing.Point(39, 26);
            this.TBoxPageAmount.Name = "TBoxPageAmount";
            this.TBoxPageAmount.Size = new System.Drawing.Size(111, 20);
            this.TBoxPageAmount.TabIndex = 3;
            // 
            // lblReadPageAmount
            // 
            this.lblReadPageAmount.AutoSize = true;
            this.lblReadPageAmount.Location = new System.Drawing.Point(0, 29);
            this.lblReadPageAmount.Name = "lblReadPageAmount";
            this.lblReadPageAmount.Size = new System.Drawing.Size(32, 13);
            this.lblReadPageAmount.TabIndex = 1;
            this.lblReadPageAmount.Text = "Page";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(0, 7);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(622, 487);
            this.Controls.Add(this.pnlAddReadPages);
            this.Controls.Add(this.btnAddReadPages);
            this.Controls.Add(this.btnShowReadPages);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnShowStatistics);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.pnlBookSearch);
            this.Controls.Add(this.pnlAddNewBook);
            this.Controls.Add(this.btnShowBooks);
            this.Controls.Add(this.btnBookSearch);
            this.Controls.Add(this.btnAddNewBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "My Bookshelf";
            this.pnlAddNewBook.ResumeLayout(false);
            this.pnlAddNewBook.PerformLayout();
            this.pnlBookSearch.ResumeLayout(false);
            this.pnlBookSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.pnlAddReadPages.ResumeLayout(false);
            this.pnlAddReadPages.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewBook;
        private System.Windows.Forms.Button btnBookSearch;
        private System.Windows.Forms.Button btnShowBooks;
        private System.Windows.Forms.Panel pnlAddNewBook;
        private System.Windows.Forms.TextBox TBoxBookName;
        private System.Windows.Forms.Button btnExecuteAdding;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblWriter;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox TBoxGenre;
        private System.Windows.Forms.TextBox TBoxPublisher;
        private System.Windows.Forms.TextBox TBoxWriter;
        private System.Windows.Forms.Panel pnlBookSearch;
        private System.Windows.Forms.Button btnExecuteSearch;
        private System.Windows.Forms.TextBox TBoxSearchingText;
        private System.Windows.Forms.Button btnSearchByGenre;
        private System.Windows.Forms.Button btnSearchByPublisher;
        private System.Windows.Forms.Button btnSearchByWriter;
        private System.Windows.Forms.Button btnSearchByBookName;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Label arama_sonucu_lbl;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblBookStatus;
        private System.Windows.Forms.TextBox TBoxTotalBookNumber;
        private System.Windows.Forms.Label lblTotalBook;
        private System.Windows.Forms.Button btnShowStatistics;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnShowReadPages;
        private System.Windows.Forms.Button btnAddReadPages;
        private System.Windows.Forms.Panel pnlAddReadPages;
        private System.Windows.Forms.Button btnAddPages;
        private System.Windows.Forms.TextBox TBoxPageAmount;
        private System.Windows.Forms.Label lblReadPageAmount;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox CBoxUnread;
        private System.Windows.Forms.CheckBox CBoxRead;
        private System.Windows.Forms.Label lblSearchingText;
    }
}

