namespace SBBv2
{
    partial class ConnectionProgram
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.btnConnection = new System.Windows.Forms.Button();
            this.dgvConnection = new System.Windows.Forms.DataGridView();
            this.DepartureConnections = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Platform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelConnections = new System.Windows.Forms.Label();
            this.txtFromStation = new System.Windows.Forms.TextBox();
            this.lbFromAutoInputList = new System.Windows.Forms.ListBox();
            this.dgvStationBoard = new System.Windows.Forms.DataGridView();
            this.DepartureStationBoard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameStationBoard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFromStationBoard = new System.Windows.Forms.Button();
            this.btnToStationBoard = new System.Windows.Forms.Button();
            this.txtToStation = new System.Windows.Forms.TextBox();
            this.lbToAutoInputList = new System.Windows.Forms.ListBox();
            this.dtSetTime = new System.Windows.Forms.DateTimePicker();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.companyName = new System.Windows.Forms.Label();
            this.slogan = new System.Windows.Forms.Label();
            this.btnSwap = new System.Windows.Forms.Button();
            this.btnConnectionHidden = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnToStationBoardHidden = new System.Windows.Forms.Button();
            this.btnFromStationBoardHidden = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStationBoard)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.BackColor = System.Drawing.Color.Transparent;
            this.labelFrom.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelFrom.Location = new System.Drawing.Point(476, 153);
            this.labelFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(176, 46);
            this.labelFrom.TabIndex = 2;
            this.labelFrom.Text = "ABFAHRT";
            this.labelFrom.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTo.Location = new System.Drawing.Point(1224, 153);
            this.labelTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(185, 46);
            this.labelTo.TabIndex = 3;
            this.labelTo.Text = "ANKUNFT";
            this.labelTo.Click += new System.EventHandler(this.labelTo_Click);
            // 
            // btnConnection
            // 
            this.btnConnection.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnConnection.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnection.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnection.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConnection.Location = new System.Drawing.Point(233, 444);
            this.btnConnection.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(1372, 79);
            this.btnConnection.TabIndex = 5;
            this.btnConnection.Text = "alle Verbindungen suchen";
            this.btnConnection.UseVisualStyleBackColor = false;
            this.btnConnection.Visible = false;
            this.btnConnection.Click += new System.EventHandler(this.FindConnectionButton);
            // 
            // dgvConnection
            // 
            this.dgvConnection.AllowUserToAddRows = false;
            this.dgvConnection.AllowUserToDeleteRows = false;
            this.dgvConnection.AllowUserToResizeColumns = false;
            this.dgvConnection.AllowUserToResizeRows = false;
            this.dgvConnection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConnection.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvConnection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConnection.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConnection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConnection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartureConnections,
            this.Platform,
            this.From,
            this.Arrival,
            this.To,
            this.Duration});
            this.dgvConnection.GridColor = System.Drawing.SystemColors.Control;
            this.dgvConnection.Location = new System.Drawing.Point(51, 599);
            this.dgvConnection.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvConnection.Name = "dgvConnection";
            this.dgvConnection.ReadOnly = true;
            this.dgvConnection.RowHeadersVisible = false;
            this.dgvConnection.RowHeadersWidth = 80;
            this.dgvConnection.Size = new System.Drawing.Size(1733, 396);
            this.dgvConnection.TabIndex = 10;
            this.dgvConnection.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConnection_CellContentClick);
            // 
            // DepartureConnections
            // 
            this.DepartureConnections.HeaderText = "Departure";
            this.DepartureConnections.MinimumWidth = 10;
            this.DepartureConnections.Name = "DepartureConnections";
            this.DepartureConnections.ReadOnly = true;
            // 
            // Platform
            // 
            this.Platform.HeaderText = "Platform";
            this.Platform.MinimumWidth = 10;
            this.Platform.Name = "Platform";
            this.Platform.ReadOnly = true;
            // 
            // From
            // 
            this.From.HeaderText = "From";
            this.From.MinimumWidth = 10;
            this.From.Name = "From";
            this.From.ReadOnly = true;
            // 
            // Arrival
            // 
            this.Arrival.HeaderText = "Arrival";
            this.Arrival.MinimumWidth = 10;
            this.Arrival.Name = "Arrival";
            this.Arrival.ReadOnly = true;
            // 
            // To
            // 
            this.To.HeaderText = "To";
            this.To.MinimumWidth = 10;
            this.To.Name = "To";
            this.To.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.MinimumWidth = 10;
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // labelConnections
            // 
            this.labelConnections.AutoSize = true;
            this.labelConnections.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnections.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelConnections.Location = new System.Drawing.Point(52, 547);
            this.labelConnections.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelConnections.Name = "labelConnections";
            this.labelConnections.Size = new System.Drawing.Size(294, 46);
            this.labelConnections.TabIndex = 11;
            this.labelConnections.Text = "VERBINDUNGEN";
            this.labelConnections.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtFromStation
            // 
            this.txtFromStation.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtFromStation.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFromStation.Location = new System.Drawing.Point(235, 205);
            this.txtFromStation.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtFromStation.Name = "txtFromStation";
            this.txtFromStation.Size = new System.Drawing.Size(601, 53);
            this.txtFromStation.TabIndex = 1;
            this.txtFromStation.TextChanged += new System.EventHandler(this.FromStationTextBox_TextChanged);
            // 
            // lbFromAutoInputList
            // 
            this.lbFromAutoInputList.BackColor = System.Drawing.Color.LavenderBlush;
            this.lbFromAutoInputList.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFromAutoInputList.FormattingEnabled = true;
            this.lbFromAutoInputList.ItemHeight = 33;
            this.lbFromAutoInputList.Location = new System.Drawing.Point(235, 257);
            this.lbFromAutoInputList.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lbFromAutoInputList.Name = "lbFromAutoInputList";
            this.lbFromAutoInputList.Size = new System.Drawing.Size(601, 136);
            this.lbFromAutoInputList.TabIndex = 13;
            this.lbFromAutoInputList.Visible = false;
            this.lbFromAutoInputList.Click += new System.EventHandler(this.FromClickAutoInput);
            this.lbFromAutoInputList.SelectedIndexChanged += new System.EventHandler(this.lbFromAutoInputList_SelectedIndexChanged);
            // 
            // dgvStationBoard
            // 
            this.dgvStationBoard.AllowUserToAddRows = false;
            this.dgvStationBoard.AllowUserToDeleteRows = false;
            this.dgvStationBoard.AllowUserToResizeColumns = false;
            this.dgvStationBoard.AllowUserToResizeRows = false;
            this.dgvStationBoard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStationBoard.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvStationBoard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStationBoard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStationBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStationBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartureStationBoard,
            this.NameStationBoard,
            this.Destination});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStationBoard.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStationBoard.GridColor = System.Drawing.SystemColors.Control;
            this.dgvStationBoard.Location = new System.Drawing.Point(51, 599);
            this.dgvStationBoard.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvStationBoard.Name = "dgvStationBoard";
            this.dgvStationBoard.ReadOnly = true;
            this.dgvStationBoard.RowHeadersVisible = false;
            this.dgvStationBoard.RowHeadersWidth = 80;
            this.dgvStationBoard.Size = new System.Drawing.Size(1730, 396);
            this.dgvStationBoard.TabIndex = 14;
            this.dgvStationBoard.Visible = false;
            this.dgvStationBoard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStationBoard_CellContentClick);
            // 
            // DepartureStationBoard
            // 
            this.DepartureStationBoard.HeaderText = "Departure";
            this.DepartureStationBoard.MinimumWidth = 10;
            this.DepartureStationBoard.Name = "DepartureStationBoard";
            this.DepartureStationBoard.ReadOnly = true;
            // 
            // NameStationBoard
            // 
            this.NameStationBoard.HeaderText = "Name";
            this.NameStationBoard.MinimumWidth = 10;
            this.NameStationBoard.Name = "NameStationBoard";
            this.NameStationBoard.ReadOnly = true;
            // 
            // Destination
            // 
            this.Destination.HeaderText = "Destination";
            this.Destination.MinimumWidth = 10;
            this.Destination.Name = "Destination";
            this.Destination.ReadOnly = true;
            // 
            // btnFromStationBoard
            // 
            this.btnFromStationBoard.BackColor = System.Drawing.Color.Pink;
            this.btnFromStationBoard.FlatAppearance.BorderSize = 0;
            this.btnFromStationBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFromStationBoard.Font = new System.Drawing.Font("Corbel", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFromStationBoard.ForeColor = System.Drawing.Color.Black;
            this.btnFromStationBoard.Location = new System.Drawing.Point(233, 365);
            this.btnFromStationBoard.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnFromStationBoard.Name = "btnFromStationBoard";
            this.btnFromStationBoard.Size = new System.Drawing.Size(603, 67);
            this.btnFromStationBoard.TabIndex = 2;
            this.btnFromStationBoard.Text = "alle Abfahrten anzeigen";
            this.btnFromStationBoard.UseVisualStyleBackColor = false;
            this.btnFromStationBoard.Visible = false;
            this.btnFromStationBoard.Click += new System.EventHandler(this.ShowFromStationBoard);
            // 
            // btnToStationBoard
            // 
            this.btnToStationBoard.BackColor = System.Drawing.Color.Pink;
            this.btnToStationBoard.FlatAppearance.BorderSize = 0;
            this.btnToStationBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToStationBoard.Font = new System.Drawing.Font("Corbel", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToStationBoard.ForeColor = System.Drawing.Color.Black;
            this.btnToStationBoard.Location = new System.Drawing.Point(1004, 364);
            this.btnToStationBoard.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnToStationBoard.Name = "btnToStationBoard";
            this.btnToStationBoard.Size = new System.Drawing.Size(601, 68);
            this.btnToStationBoard.TabIndex = 4;
            this.btnToStationBoard.Text = "alle Ankünfte anzeigen";
            this.btnToStationBoard.UseVisualStyleBackColor = false;
            this.btnToStationBoard.Visible = false;
            this.btnToStationBoard.Click += new System.EventHandler(this.ShowToStationBoard);
            // 
            // txtToStation
            // 
            this.txtToStation.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtToStation.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToStation.Location = new System.Drawing.Point(1004, 205);
            this.txtToStation.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtToStation.Name = "txtToStation";
            this.txtToStation.Size = new System.Drawing.Size(601, 53);
            this.txtToStation.TabIndex = 3;
            this.txtToStation.TextChanged += new System.EventHandler(this.ToStationTextBox_TextChanged);
            // 
            // lbToAutoInputList
            // 
            this.lbToAutoInputList.BackColor = System.Drawing.Color.LavenderBlush;
            this.lbToAutoInputList.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToAutoInputList.FormattingEnabled = true;
            this.lbToAutoInputList.ItemHeight = 33;
            this.lbToAutoInputList.Location = new System.Drawing.Point(1004, 257);
            this.lbToAutoInputList.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lbToAutoInputList.Name = "lbToAutoInputList";
            this.lbToAutoInputList.Size = new System.Drawing.Size(601, 136);
            this.lbToAutoInputList.TabIndex = 18;
            this.lbToAutoInputList.Visible = false;
            this.lbToAutoInputList.Click += new System.EventHandler(this.ToClickAutoInput);
            // 
            // dtSetTime
            // 
            this.dtSetTime.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.dtSetTime.CustomFormat = "HH:mm";
            this.dtSetTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSetTime.Location = new System.Drawing.Point(235, 271);
            this.dtSetTime.Margin = new System.Windows.Forms.Padding(4);
            this.dtSetTime.Name = "dtSetTime";
            this.dtSetTime.Size = new System.Drawing.Size(601, 31);
            this.dtSetTime.TabIndex = 19;
            this.dtSetTime.ValueChanged += new System.EventHandler(this.dtSetTime_ValueChanged);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelHeader.Controls.Add(this.companyName);
            this.panelHeader.Location = new System.Drawing.Point(-3, -1);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1845, 96);
            this.panelHeader.TabIndex = 20;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // companyName
            // 
            this.companyName.AutoSize = true;
            this.companyName.Font = new System.Drawing.Font("Corbel", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.companyName.Location = new System.Drawing.Point(43, 10);
            this.companyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(178, 66);
            this.companyName.TabIndex = 21;
            this.companyName.Text = "SBBv2";
            this.companyName.Click += new System.EventHandler(this.companyName_Click);
            // 
            // slogan
            // 
            this.slogan.AutoSize = true;
            this.slogan.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slogan.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.slogan.Location = new System.Drawing.Point(1623, 105);
            this.slogan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.slogan.Name = "slogan";
            this.slogan.Size = new System.Drawing.Size(204, 39);
            this.slogan.TabIndex = 22;
            this.slogan.Text = "SBB reworked";
            this.slogan.Click += new System.EventHandler(this.slogan_Click);
            // 
            // btnSwap
            // 
            this.btnSwap.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSwap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSwap.FlatAppearance.BorderSize = 0;
            this.btnSwap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwap.Font = new System.Drawing.Font("Corbel", 8F, System.Drawing.FontStyle.Bold);
            this.btnSwap.Location = new System.Drawing.Point(845, 364);
            this.btnSwap.Margin = new System.Windows.Forms.Padding(4);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(150, 68);
            this.btnSwap.TabIndex = 21;
            this.btnSwap.Text = "SWAP";
            this.btnSwap.UseVisualStyleBackColor = false;
            this.btnSwap.Click += new System.EventHandler(this.ClickStartToEnd);
            // 
            // btnConnectionHidden
            // 
            this.btnConnectionHidden.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnConnectionHidden.Enabled = false;
            this.btnConnectionHidden.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnConnectionHidden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnectionHidden.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectionHidden.ForeColor = System.Drawing.Color.White;
            this.btnConnectionHidden.Location = new System.Drawing.Point(233, 444);
            this.btnConnectionHidden.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnConnectionHidden.Name = "btnConnectionHidden";
            this.btnConnectionHidden.Size = new System.Drawing.Size(1372, 79);
            this.btnConnectionHidden.TabIndex = 22;
            this.btnConnectionHidden.Text = "alle Verbindungen suchen";
            this.btnConnectionHidden.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.AliceBlue;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Corbel", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnReset.Location = new System.Drawing.Point(1615, 444);
            this.btnReset.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(149, 79);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnResetTextBox);
            // 
            // btnToStationBoardHidden
            // 
            this.btnToStationBoardHidden.BackColor = System.Drawing.Color.Pink;
            this.btnToStationBoardHidden.Enabled = false;
            this.btnToStationBoardHidden.FlatAppearance.BorderSize = 0;
            this.btnToStationBoardHidden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToStationBoardHidden.Font = new System.Drawing.Font("Corbel", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToStationBoardHidden.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnToStationBoardHidden.Location = new System.Drawing.Point(1004, 364);
            this.btnToStationBoardHidden.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnToStationBoardHidden.Name = "btnToStationBoardHidden";
            this.btnToStationBoardHidden.Size = new System.Drawing.Size(601, 68);
            this.btnToStationBoardHidden.TabIndex = 25;
            this.btnToStationBoardHidden.Text = "alle Ankünfte anzeigen";
            this.btnToStationBoardHidden.UseVisualStyleBackColor = false;
            // 
            // btnFromStationBoardHidden
            // 
            this.btnFromStationBoardHidden.BackColor = System.Drawing.Color.Pink;
            this.btnFromStationBoardHidden.Enabled = false;
            this.btnFromStationBoardHidden.FlatAppearance.BorderSize = 0;
            this.btnFromStationBoardHidden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFromStationBoardHidden.Font = new System.Drawing.Font("Corbel", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFromStationBoardHidden.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnFromStationBoardHidden.Location = new System.Drawing.Point(233, 364);
            this.btnFromStationBoardHidden.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnFromStationBoardHidden.Name = "btnFromStationBoardHidden";
            this.btnFromStationBoardHidden.Size = new System.Drawing.Size(603, 68);
            this.btnFromStationBoardHidden.TabIndex = 24;
            this.btnFromStationBoardHidden.Text = "alle Abfahrten anzeigen";
            this.btnFromStationBoardHidden.UseVisualStyleBackColor = false;
            // 
            // ConnectionProgram
            // 
            this.AcceptButton = this.btnConnection;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1840, 1050);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.slogan);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.lbToAutoInputList);
            this.Controls.Add(this.lbFromAutoInputList);
            this.Controls.Add(this.dtSetTime);
            this.Controls.Add(this.txtToStation);
            this.Controls.Add(this.btnToStationBoard);
            this.Controls.Add(this.btnFromStationBoard);
            this.Controls.Add(this.dgvStationBoard);
            this.Controls.Add(this.txtFromStation);
            this.Controls.Add(this.labelConnections);
            this.Controls.Add(this.dgvConnection);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.btnConnectionHidden);
            this.Controls.Add(this.btnFromStationBoardHidden);
            this.Controls.Add(this.btnToStationBoardHidden);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ConnectionProgram";
            this.Load += new System.EventHandler(this.ConnectionProgram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStationBoard)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.DataGridView dgvConnection;
        private System.Windows.Forms.Label labelConnections;
        private System.Windows.Forms.TextBox txtFromStation;
        private System.Windows.Forms.ListBox lbFromAutoInputList;
        private System.Windows.Forms.DataGridView dgvStationBoard;
        private System.Windows.Forms.Button btnFromStationBoard;
        private System.Windows.Forms.Button btnToStationBoard;
        private System.Windows.Forms.TextBox txtToStation;
        private System.Windows.Forms.ListBox lbToAutoInputList;
        private System.Windows.Forms.DateTimePicker dtSetTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureStationBoard;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameStationBoard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureConnections;
        private System.Windows.Forms.DataGridViewTextBoxColumn Platform;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label slogan;
        private System.Windows.Forms.Label companyName;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button btnConnectionHidden;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnToStationBoardHidden;
        private System.Windows.Forms.Button btnFromStationBoardHidden;
    }
}

