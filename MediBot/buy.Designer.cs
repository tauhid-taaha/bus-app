namespace MediBot
{
    partial class buy
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.userlist = new System.Windows.Forms.ListBox();
            this.searchuser = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passangertxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.amounthave = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.traveldob = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Unitprice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Totaltk = new Guna.UI2.WinForms.Guna2TextBox();
            this.reservebtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label5 = new System.Windows.Forms.Label();
            this.totalseat = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // userlist
            // 
            this.userlist.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlist.FormattingEnabled = true;
            this.userlist.ItemHeight = 21;
            this.userlist.Location = new System.Drawing.Point(45, 121);
            this.userlist.Name = "userlist";
            this.userlist.Size = new System.Drawing.Size(235, 466);
            this.userlist.TabIndex = 0;
            this.userlist.SelectedIndexChanged += new System.EventHandler(this.userlist_SelectedIndexChanged);
            // 
            // searchuser
            // 
            this.searchuser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchuser.DefaultText = "";
            this.searchuser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchuser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchuser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchuser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchuser.FillColor = System.Drawing.Color.PeachPuff;
            this.searchuser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchuser.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.searchuser.ForeColor = System.Drawing.Color.Black;
            this.searchuser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchuser.Location = new System.Drawing.Point(45, 57);
            this.searchuser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchuser.Name = "searchuser";
            this.searchuser.PasswordChar = '\0';
            this.searchuser.PlaceholderText = "Search--------------------------";
            this.searchuser.SelectedText = "";
            this.searchuser.Size = new System.Drawing.Size(251, 48);
            this.searchuser.TabIndex = 23;
            this.searchuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchuser.TextChanged += new System.EventHandler(this.searchuser_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Search Passenger";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(398, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Passenger Name";
            // 
            // passangertxtbox
            // 
            this.passangertxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passangertxtbox.DefaultText = "";
            this.passangertxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passangertxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passangertxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passangertxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passangertxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passangertxtbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passangertxtbox.ForeColor = System.Drawing.Color.Black;
            this.passangertxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passangertxtbox.Location = new System.Drawing.Point(401, 72);
            this.passangertxtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passangertxtbox.Name = "passangertxtbox";
            this.passangertxtbox.PasswordChar = '\0';
            this.passangertxtbox.PlaceholderText = "";
            this.passangertxtbox.SelectedText = "";
            this.passangertxtbox.Size = new System.Drawing.Size(258, 48);
            this.passangertxtbox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(772, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Amount Have";
            // 
            // amounthave
            // 
            this.amounthave.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amounthave.DefaultText = "";
            this.amounthave.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.amounthave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.amounthave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.amounthave.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.amounthave.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.amounthave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amounthave.ForeColor = System.Drawing.Color.Black;
            this.amounthave.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.amounthave.Location = new System.Drawing.Point(775, 72);
            this.amounthave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.amounthave.Name = "amounthave";
            this.amounthave.PasswordChar = '\0';
            this.amounthave.PlaceholderText = "";
            this.amounthave.SelectedText = "";
            this.amounthave.Size = new System.Drawing.Size(258, 48);
            this.amounthave.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(399, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Seat Number";
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(402, 190);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(258, 48);
            this.guna2TextBox2.TabIndex = 28;
            // 
            // traveldob
            // 
            this.traveldob.Checked = true;
            this.traveldob.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.traveldob.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.traveldob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.traveldob.Location = new System.Drawing.Point(402, 369);
            this.traveldob.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.traveldob.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.traveldob.Name = "traveldob";
            this.traveldob.Size = new System.Drawing.Size(218, 36);
            this.traveldob.TabIndex = 33;
            this.traveldob.Value = new System.DateTime(2023, 4, 25, 19, 30, 35, 86);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(408, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Traveling Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(772, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Price Per Ticket";
            // 
            // Unitprice
            // 
            this.Unitprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Unitprice.DefaultText = "";
            this.Unitprice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Unitprice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Unitprice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Unitprice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Unitprice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Unitprice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unitprice.ForeColor = System.Drawing.Color.Black;
            this.Unitprice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Unitprice.Location = new System.Drawing.Point(775, 357);
            this.Unitprice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Unitprice.Name = "Unitprice";
            this.Unitprice.PasswordChar = '\0';
            this.Unitprice.PlaceholderText = "";
            this.Unitprice.SelectedText = "";
            this.Unitprice.Size = new System.Drawing.Size(258, 48);
            this.Unitprice.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(773, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Total Amount";
            // 
            // Totaltk
            // 
            this.Totaltk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Totaltk.DefaultText = "";
            this.Totaltk.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Totaltk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Totaltk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Totaltk.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Totaltk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Totaltk.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totaltk.ForeColor = System.Drawing.Color.Black;
            this.Totaltk.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Totaltk.Location = new System.Drawing.Point(776, 487);
            this.Totaltk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Totaltk.Name = "Totaltk";
            this.Totaltk.PasswordChar = '\0';
            this.Totaltk.PlaceholderText = "";
            this.Totaltk.SelectedText = "";
            this.Totaltk.Size = new System.Drawing.Size(258, 48);
            this.Totaltk.TabIndex = 36;
            // 
            // reservebtn
            // 
            this.reservebtn.Animated = true;
            this.reservebtn.AutoRoundedCorners = true;
            this.reservebtn.BackColor = System.Drawing.Color.Transparent;
            this.reservebtn.BorderRadius = 21;
            this.reservebtn.BorderThickness = 1;
            this.reservebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reservebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reservebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reservebtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reservebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reservebtn.FillColor = System.Drawing.Color.PeachPuff;
            this.reservebtn.FillColor2 = System.Drawing.Color.PeachPuff;
            this.reservebtn.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold);
            this.reservebtn.ForeColor = System.Drawing.Color.Black;
            this.reservebtn.ImageSize = new System.Drawing.Size(22, 22);
            this.reservebtn.Location = new System.Drawing.Point(542, 580);
            this.reservebtn.Name = "reservebtn";
            this.reservebtn.Size = new System.Drawing.Size(180, 45);
            this.reservebtn.TabIndex = 38;
            this.reservebtn.Text = "Buy";
            this.reservebtn.UseTransparentBackground = true;
            this.reservebtn.Click += new System.EventHandler(this.reservebtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(772, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Total Seat";
            // 
            // totalseat
            // 
            this.totalseat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalseat.DefaultText = "";
            this.totalseat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.totalseat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.totalseat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalseat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalseat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalseat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.totalseat.ForeColor = System.Drawing.Color.Black;
            this.totalseat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalseat.Location = new System.Drawing.Point(775, 190);
            this.totalseat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.totalseat.Name = "totalseat";
            this.totalseat.PasswordChar = '\0';
            this.totalseat.PlaceholderText = "";
            this.totalseat.SelectedText = "";
            this.totalseat.Size = new System.Drawing.Size(258, 48);
            this.totalseat.TabIndex = 39;
            this.totalseat.TextChanged += new System.EventHandler(this.totalseat_TextChanged_1);
            // 
            // buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalseat);
            this.Controls.Add(this.reservebtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Totaltk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Unitprice);
            this.Controls.Add(this.traveldob);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amounthave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passangertxtbox);
            this.Controls.Add(this.searchuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userlist);
            this.Name = "buy";
            this.Size = new System.Drawing.Size(1126, 767);
            this.Load += new System.EventHandler(this.buy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.ListBox userlist;
        private Guna.UI2.WinForms.Guna2TextBox searchuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox amounthave;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox passangertxtbox;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox Totaltk;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox Unitprice;
        private Guna.UI2.WinForms.Guna2DateTimePicker traveldob;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2GradientButton reservebtn;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox totalseat;
    }
}
