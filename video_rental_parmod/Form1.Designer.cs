namespace video_rental_parmod
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
            this.genre_label = new System.Windows.Forms.Label();
            this.plot_label = new System.Windows.Forms.Label();
            this.copies_label = new System.Windows.Forms.Label();
            this.rentalcost_label = new System.Windows.Forms.Label();
            this.year_label = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.rating_label = new System.Windows.Forms.Label();
            this.genre_text = new System.Windows.Forms.TextBox();
            this.plot_text = new System.Windows.Forms.TextBox();
            this.copies_text = new System.Windows.Forms.TextBox();
            this.rentalcost_text = new System.Windows.Forms.TextBox();
            this.year_text = new System.Windows.Forms.TextBox();
            this.title_text = new System.Windows.Forms.TextBox();
            this.rating_text = new System.Windows.Forms.TextBox();
            this.movieid_label = new System.Windows.Forms.Label();
            this.moveid_text = new System.Windows.Forms.TextBox();
            this.update_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.addmoview_button = new System.Windows.Forms.Button();
            this.movie_Grid = new System.Windows.Forms.DataGridView();
            this.datereturned_date = new System.Windows.Forms.Label();
            this.rentedate_label = new System.Windows.Forms.Label();
            this.custid_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rmid_label = new System.Windows.Forms.Label();
            this.returndate_text = new System.Windows.Forms.TextBox();
            this.rentdate_text = new System.Windows.Forms.TextBox();
            this.Custid_text = new System.Windows.Forms.TextBox();
            this.movieid_text = new System.Windows.Forms.TextBox();
            this.RMID_text = new System.Windows.Forms.TextBox();
            this.rentedout_ = new System.Windows.Forms.RadioButton();
            this.allrent_radio = new System.Windows.Forms.RadioButton();
            this.return_button = new System.Windows.Forms.Button();
            this.issue_button = new System.Windows.Forms.Button();
            this.rentalGrid = new System.Windows.Forms.DataGridView();
            this.phone_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.lname_label = new System.Windows.Forms.Label();
            this.fname_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.phone_text = new System.Windows.Forms.TextBox();
            this.address_text = new System.Windows.Forms.TextBox();
            this.lname_text = new System.Windows.Forms.TextBox();
            this.fname_text = new System.Windows.Forms.TextBox();
            this.addcustomer_button = new System.Windows.Forms.Button();
            this.customer_Grid = new System.Windows.Forms.DataGridView();
            this.Srno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Best_buy = new System.Windows.Forms.Button();
            this.Top_buy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.movie_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // genre_label
            // 
            this.genre_label.AutoSize = true;
            this.genre_label.Location = new System.Drawing.Point(149, 441);
            this.genre_label.Name = "genre_label";
            this.genre_label.Size = new System.Drawing.Size(48, 17);
            this.genre_label.TabIndex = 58;
            this.genre_label.Text = "Genre";
            // 
            // plot_label
            // 
            this.plot_label.AutoSize = true;
            this.plot_label.Location = new System.Drawing.Point(149, 402);
            this.plot_label.Name = "plot_label";
            this.plot_label.Size = new System.Drawing.Size(32, 17);
            this.plot_label.TabIndex = 57;
            this.plot_label.Text = "Plot";
            // 
            // copies_label
            // 
            this.copies_label.AutoSize = true;
            this.copies_label.Location = new System.Drawing.Point(149, 357);
            this.copies_label.Name = "copies_label";
            this.copies_label.Size = new System.Drawing.Size(51, 17);
            this.copies_label.TabIndex = 56;
            this.copies_label.Text = "Copies";
            // 
            // rentalcost_label
            // 
            this.rentalcost_label.AutoSize = true;
            this.rentalcost_label.Location = new System.Drawing.Point(130, 318);
            this.rentalcost_label.Name = "rentalcost_label";
            this.rentalcost_label.Size = new System.Drawing.Size(81, 17);
            this.rentalcost_label.TabIndex = 55;
            this.rentalcost_label.Text = "Rental Cost";
            // 
            // year_label
            // 
            this.year_label.AutoSize = true;
            this.year_label.Location = new System.Drawing.Point(162, 192);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(38, 17);
            this.year_label.TabIndex = 54;
            this.year_label.Text = "Year";
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Location = new System.Drawing.Point(165, 227);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(35, 17);
            this.title_label.TabIndex = 53;
            this.title_label.Text = "Title";
            // 
            // rating_label
            // 
            this.rating_label.AutoSize = true;
            this.rating_label.Location = new System.Drawing.Point(165, 273);
            this.rating_label.Name = "rating_label";
            this.rating_label.Size = new System.Drawing.Size(49, 17);
            this.rating_label.TabIndex = 52;
            this.rating_label.Text = "Rating";
            // 
            // genre_text
            // 
            this.genre_text.Location = new System.Drawing.Point(217, 436);
            this.genre_text.Name = "genre_text";
            this.genre_text.Size = new System.Drawing.Size(100, 22);
            this.genre_text.TabIndex = 51;
            // 
            // plot_text
            // 
            this.plot_text.Location = new System.Drawing.Point(217, 397);
            this.plot_text.Name = "plot_text";
            this.plot_text.Size = new System.Drawing.Size(100, 22);
            this.plot_text.TabIndex = 50;
            // 
            // copies_text
            // 
            this.copies_text.Location = new System.Drawing.Point(217, 352);
            this.copies_text.Name = "copies_text";
            this.copies_text.Size = new System.Drawing.Size(100, 22);
            this.copies_text.TabIndex = 49;
            // 
            // rentalcost_text
            // 
            this.rentalcost_text.Location = new System.Drawing.Point(217, 313);
            this.rentalcost_text.Name = "rentalcost_text";
            this.rentalcost_text.Size = new System.Drawing.Size(100, 22);
            this.rentalcost_text.TabIndex = 48;
            // 
            // year_text
            // 
            this.year_text.Location = new System.Drawing.Point(217, 192);
            this.year_text.Name = "year_text";
            this.year_text.Size = new System.Drawing.Size(100, 22);
            this.year_text.TabIndex = 47;
            // 
            // title_text
            // 
            this.title_text.Location = new System.Drawing.Point(217, 227);
            this.title_text.Name = "title_text";
            this.title_text.Size = new System.Drawing.Size(100, 22);
            this.title_text.TabIndex = 46;
            // 
            // rating_text
            // 
            this.rating_text.Location = new System.Drawing.Point(217, 273);
            this.rating_text.Name = "rating_text";
            this.rating_text.Size = new System.Drawing.Size(100, 22);
            this.rating_text.TabIndex = 45;
            // 
            // movieid_label
            // 
            this.movieid_label.AutoSize = true;
            this.movieid_label.Location = new System.Drawing.Point(153, 159);
            this.movieid_label.Name = "movieid_label";
            this.movieid_label.Size = new System.Drawing.Size(58, 17);
            this.movieid_label.TabIndex = 44;
            this.movieid_label.Text = "MovieID";
            // 
            // moveid_text
            // 
            this.moveid_text.Enabled = false;
            this.moveid_text.Location = new System.Drawing.Point(217, 159);
            this.moveid_text.Name = "moveid_text";
            this.moveid_text.Size = new System.Drawing.Size(100, 22);
            this.moveid_text.TabIndex = 43;
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(245, 478);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(113, 45);
            this.update_button.TabIndex = 42;
            this.update_button.Text = "Update Movie";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(141, 478);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(98, 45);
            this.delete_button.TabIndex = 41;
            this.delete_button.Text = "Delete Movie";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // addmoview_button
            // 
            this.addmoview_button.Location = new System.Drawing.Point(20, 478);
            this.addmoview_button.Name = "addmoview_button";
            this.addmoview_button.Size = new System.Drawing.Size(115, 45);
            this.addmoview_button.TabIndex = 40;
            this.addmoview_button.Text = "Add Movie";
            this.addmoview_button.UseVisualStyleBackColor = true;
            this.addmoview_button.Click += new System.EventHandler(this.addmoview_button_Click);
            // 
            // movie_Grid
            // 
            this.movie_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movie_Grid.Location = new System.Drawing.Point(24, 12);
            this.movie_Grid.Name = "movie_Grid";
            this.movie_Grid.RowTemplate.Height = 24;
            this.movie_Grid.Size = new System.Drawing.Size(293, 101);
            this.movie_Grid.TabIndex = 59;
            this.movie_Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.movie_Grid_CellContentClick);
            // 
            // datereturned_date
            // 
            this.datereturned_date.AutoSize = true;
            this.datereturned_date.Location = new System.Drawing.Point(414, 391);
            this.datereturned_date.Name = "datereturned_date";
            this.datereturned_date.Size = new System.Drawing.Size(101, 17);
            this.datereturned_date.TabIndex = 73;
            this.datereturned_date.Text = "Date Returned";
            // 
            // rentedate_label
            // 
            this.rentedate_label.AutoSize = true;
            this.rentedate_label.Location = new System.Drawing.Point(418, 348);
            this.rentedate_label.Name = "rentedate_label";
            this.rentedate_label.Size = new System.Drawing.Size(88, 17);
            this.rentedate_label.TabIndex = 72;
            this.rentedate_label.Text = "Rented Date";
            // 
            // custid_label
            // 
            this.custid_label.AutoSize = true;
            this.custid_label.Location = new System.Drawing.Point(457, 311);
            this.custid_label.Name = "custid_label";
            this.custid_label.Size = new System.Drawing.Size(49, 17);
            this.custid_label.TabIndex = 71;
            this.custid_label.Text = "CustID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 70;
            this.label1.Text = "MovieID";
            // 
            // rmid_label
            // 
            this.rmid_label.AutoSize = true;
            this.rmid_label.Location = new System.Drawing.Point(473, 225);
            this.rmid_label.Name = "rmid_label";
            this.rmid_label.Size = new System.Drawing.Size(42, 17);
            this.rmid_label.TabIndex = 69;
            this.rmid_label.Text = "RMID";
            // 
            // returndate_text
            // 
            this.returndate_text.Location = new System.Drawing.Point(534, 391);
            this.returndate_text.Name = "returndate_text";
            this.returndate_text.Size = new System.Drawing.Size(100, 22);
            this.returndate_text.TabIndex = 68;
            // 
            // rentdate_text
            // 
            this.rentdate_text.Location = new System.Drawing.Point(534, 343);
            this.rentdate_text.Name = "rentdate_text";
            this.rentdate_text.Size = new System.Drawing.Size(100, 22);
            this.rentdate_text.TabIndex = 67;
            // 
            // Custid_text
            // 
            this.Custid_text.Location = new System.Drawing.Point(534, 308);
            this.Custid_text.Name = "Custid_text";
            this.Custid_text.Size = new System.Drawing.Size(100, 22);
            this.Custid_text.TabIndex = 66;
            // 
            // movieid_text
            // 
            this.movieid_text.Location = new System.Drawing.Point(534, 267);
            this.movieid_text.Name = "movieid_text";
            this.movieid_text.Size = new System.Drawing.Size(100, 22);
            this.movieid_text.TabIndex = 65;
            // 
            // RMID_text
            // 
            this.RMID_text.Location = new System.Drawing.Point(534, 225);
            this.RMID_text.Name = "RMID_text";
            this.RMID_text.Size = new System.Drawing.Size(100, 22);
            this.RMID_text.TabIndex = 64;
            // 
            // rentedout_
            // 
            this.rentedout_.AutoSize = true;
            this.rentedout_.Location = new System.Drawing.Point(521, 433);
            this.rentedout_.Name = "rentedout_";
            this.rentedout_.Size = new System.Drawing.Size(102, 21);
            this.rentedout_.TabIndex = 63;
            this.rentedout_.TabStop = true;
            this.rentedout_.Text = "Out Rented";
            this.rentedout_.UseVisualStyleBackColor = true;
            this.rentedout_.CheckedChanged += new System.EventHandler(this.rentedout__CheckedChanged);
            // 
            // allrent_radio
            // 
            this.allrent_radio.AutoSize = true;
            this.allrent_radio.Location = new System.Drawing.Point(421, 433);
            this.allrent_radio.Name = "allrent_radio";
            this.allrent_radio.Size = new System.Drawing.Size(94, 21);
            this.allrent_radio.TabIndex = 62;
            this.allrent_radio.TabStop = true;
            this.allrent_radio.Text = "All Rented";
            this.allrent_radio.UseVisualStyleBackColor = true;
            this.allrent_radio.CheckedChanged += new System.EventHandler(this.allrent_radio_CheckedChanged);
            // 
            // return_button
            // 
            this.return_button.Location = new System.Drawing.Point(521, 475);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(106, 48);
            this.return_button.TabIndex = 61;
            this.return_button.Text = "Return Movie";
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // issue_button
            // 
            this.issue_button.Location = new System.Drawing.Point(394, 475);
            this.issue_button.Name = "issue_button";
            this.issue_button.Size = new System.Drawing.Size(121, 48);
            this.issue_button.TabIndex = 60;
            this.issue_button.Text = "Issue Movie";
            this.issue_button.UseVisualStyleBackColor = true;
            this.issue_button.Click += new System.EventHandler(this.issue_button_Click);
            // 
            // rentalGrid
            // 
            this.rentalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalGrid.Location = new System.Drawing.Point(394, 12);
            this.rentalGrid.Name = "rentalGrid";
            this.rentalGrid.RowTemplate.Height = 24;
            this.rentalGrid.Size = new System.Drawing.Size(297, 182);
            this.rentalGrid.TabIndex = 74;
            this.rentalGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rentalGrid_CellContentClick);
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Location = new System.Drawing.Point(704, 417);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(49, 17);
            this.phone_label.TabIndex = 87;
            this.phone_label.Text = "Phone";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(702, 387);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(60, 17);
            this.address_label.TabIndex = 86;
            this.address_label.Text = "Address";
            // 
            // lname_label
            // 
            this.lname_label.AutoSize = true;
            this.lname_label.Location = new System.Drawing.Point(690, 345);
            this.lname_label.Name = "lname_label";
            this.lname_label.Size = new System.Drawing.Size(76, 17);
            this.lname_label.TabIndex = 85;
            this.lname_label.Text = "Last Name";
            // 
            // fname_label
            // 
            this.fname_label.AutoSize = true;
            this.fname_label.Location = new System.Drawing.Point(686, 306);
            this.fname_label.Name = "fname_label";
            this.fname_label.Size = new System.Drawing.Size(76, 17);
            this.fname_label.TabIndex = 84;
            this.fname_label.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(704, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 83;
            this.label2.Text = "Custid";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(900, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 41);
            this.button1.TabIndex = 82;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(822, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 41);
            this.button2.TabIndex = 81;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(772, 260);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 22);
            this.textBox1.TabIndex = 80;
            // 
            // phone_text
            // 
            this.phone_text.Location = new System.Drawing.Point(772, 417);
            this.phone_text.Name = "phone_text";
            this.phone_text.Size = new System.Drawing.Size(73, 22);
            this.phone_text.TabIndex = 79;
            // 
            // address_text
            // 
            this.address_text.Location = new System.Drawing.Point(772, 382);
            this.address_text.Name = "address_text";
            this.address_text.Size = new System.Drawing.Size(100, 22);
            this.address_text.TabIndex = 78;
            // 
            // lname_text
            // 
            this.lname_text.Location = new System.Drawing.Point(772, 340);
            this.lname_text.Name = "lname_text";
            this.lname_text.Size = new System.Drawing.Size(100, 22);
            this.lname_text.TabIndex = 77;
            // 
            // fname_text
            // 
            this.fname_text.Location = new System.Drawing.Point(772, 301);
            this.fname_text.Name = "fname_text";
            this.fname_text.Size = new System.Drawing.Size(88, 22);
            this.fname_text.TabIndex = 76;
            // 
            // addcustomer_button
            // 
            this.addcustomer_button.Location = new System.Drawing.Point(698, 474);
            this.addcustomer_button.Name = "addcustomer_button";
            this.addcustomer_button.Size = new System.Drawing.Size(118, 41);
            this.addcustomer_button.TabIndex = 75;
            this.addcustomer_button.Text = "Add Customer";
            this.addcustomer_button.UseVisualStyleBackColor = true;
            this.addcustomer_button.Click += new System.EventHandler(this.addcustomer_button_Click);
            // 
            // customer_Grid
            // 
            this.customer_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Srno});
            this.customer_Grid.Location = new System.Drawing.Point(720, 12);
            this.customer_Grid.Name = "customer_Grid";
            this.customer_Grid.RowTemplate.Height = 24;
            this.customer_Grid.Size = new System.Drawing.Size(264, 182);
            this.customer_Grid.TabIndex = 88;
            this.customer_Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customer_Grid_CellContentClick);
            // 
            // Srno
            // 
            this.Srno.DataPropertyName = "CustID";
            this.Srno.HeaderText = "Srno";
            this.Srno.Name = "Srno";
            this.Srno.ReadOnly = true;
            // 
            // Best_buy
            // 
            this.Best_buy.Location = new System.Drawing.Point(341, 304);
            this.Best_buy.Name = "Best_buy";
            this.Best_buy.Size = new System.Drawing.Size(97, 38);
            this.Best_buy.TabIndex = 92;
            this.Best_buy.Text = "Best Buy";
            this.Best_buy.UseVisualStyleBackColor = true;
            this.Best_buy.Click += new System.EventHandler(this.Best_buy_Click);
            // 
            // Top_buy
            // 
            this.Top_buy.Location = new System.Drawing.Point(341, 250);
            this.Top_buy.Name = "Top_buy";
            this.Top_buy.Size = new System.Drawing.Size(97, 43);
            this.Top_buy.TabIndex = 91;
            this.Top_buy.Text = "Top Movie";
            this.Top_buy.UseVisualStyleBackColor = true;
            this.Top_buy.Click += new System.EventHandler(this.Top_buy_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 535);
            this.Controls.Add(this.Best_buy);
            this.Controls.Add(this.Top_buy);
            this.Controls.Add(this.customer_Grid);
            this.Controls.Add(this.phone_label);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.lname_label);
            this.Controls.Add(this.fname_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.phone_text);
            this.Controls.Add(this.address_text);
            this.Controls.Add(this.lname_text);
            this.Controls.Add(this.fname_text);
            this.Controls.Add(this.addcustomer_button);
            this.Controls.Add(this.rentalGrid);
            this.Controls.Add(this.datereturned_date);
            this.Controls.Add(this.rentedate_label);
            this.Controls.Add(this.custid_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rmid_label);
            this.Controls.Add(this.returndate_text);
            this.Controls.Add(this.rentdate_text);
            this.Controls.Add(this.Custid_text);
            this.Controls.Add(this.movieid_text);
            this.Controls.Add(this.RMID_text);
            this.Controls.Add(this.rentedout_);
            this.Controls.Add(this.allrent_radio);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.issue_button);
            this.Controls.Add(this.movie_Grid);
            this.Controls.Add(this.genre_label);
            this.Controls.Add(this.plot_label);
            this.Controls.Add(this.copies_label);
            this.Controls.Add(this.rentalcost_label);
            this.Controls.Add(this.year_label);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.rating_label);
            this.Controls.Add(this.genre_text);
            this.Controls.Add(this.plot_text);
            this.Controls.Add(this.copies_text);
            this.Controls.Add(this.rentalcost_text);
            this.Controls.Add(this.year_text);
            this.Controls.Add(this.title_text);
            this.Controls.Add(this.rating_text);
            this.Controls.Add(this.movieid_label);
            this.Controls.Add(this.moveid_text);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.addmoview_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movie_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label genre_label;
        private System.Windows.Forms.Label plot_label;
        private System.Windows.Forms.Label copies_label;
        private System.Windows.Forms.Label rentalcost_label;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label rating_label;
        private System.Windows.Forms.TextBox genre_text;
        private System.Windows.Forms.TextBox plot_text;
        private System.Windows.Forms.TextBox copies_text;
        private System.Windows.Forms.TextBox rentalcost_text;
        private System.Windows.Forms.TextBox year_text;
        private System.Windows.Forms.TextBox title_text;
        private System.Windows.Forms.TextBox rating_text;
        private System.Windows.Forms.Label movieid_label;
        private System.Windows.Forms.TextBox moveid_text;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button addmoview_button;
        private System.Windows.Forms.DataGridView movie_Grid;
        private System.Windows.Forms.Label datereturned_date;
        private System.Windows.Forms.Label rentedate_label;
        private System.Windows.Forms.Label custid_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rmid_label;
        private System.Windows.Forms.TextBox returndate_text;
        private System.Windows.Forms.TextBox rentdate_text;
        private System.Windows.Forms.TextBox Custid_text;
        private System.Windows.Forms.TextBox movieid_text;
        private System.Windows.Forms.TextBox RMID_text;
        private System.Windows.Forms.RadioButton rentedout_;
        private System.Windows.Forms.RadioButton allrent_radio;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Button issue_button;
        private System.Windows.Forms.DataGridView rentalGrid;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Label lname_label;
        private System.Windows.Forms.Label fname_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox phone_text;
        private System.Windows.Forms.TextBox address_text;
        private System.Windows.Forms.TextBox lname_text;
        private System.Windows.Forms.TextBox fname_text;
        private System.Windows.Forms.Button addcustomer_button;
        private System.Windows.Forms.DataGridView customer_Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Srno;
        private System.Windows.Forms.Button Best_buy;
        private System.Windows.Forms.Button Top_buy;
    }
}

