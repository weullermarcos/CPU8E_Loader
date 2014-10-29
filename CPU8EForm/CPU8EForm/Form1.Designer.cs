namespace CPU8EForm
{
    partial class CPU8E_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPU8E_Form));
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCommand = new System.Windows.Forms.Label();
            this.cmdName = new System.Windows.Forms.Label();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.btnReadConfigurations = new System.Windows.Forms.Button();
            this.btnExec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCOM = new System.Windows.Forms.ComboBox();
            this.timerCOM = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtContent.Location = new System.Drawing.Point(12, 176);
            this.txtContent.MaxLength = 1024;
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(586, 245);
            this.txtContent.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(8, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 19);
            this.label1.TabIndex = 143;
            this.label1.Text = "Conteúdo do Arquivo";
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblCommand.Location = new System.Drawing.Point(8, 81);
            this.lblCommand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(140, 19);
            this.lblCommand.TabIndex = 142;
            this.lblCommand.Text = "Nome do arquivo";
            // 
            // cmdName
            // 
            this.cmdName.AutoSize = true;
            this.cmdName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.cmdName.Location = new System.Drawing.Point(-93, -68);
            this.cmdName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cmdName.Name = "cmdName";
            this.cmdName.Size = new System.Drawing.Size(354, 29);
            this.cmdName.TabIndex = 141;
            this.cmdName.Text = "Carregar arquivo de comando";
            // 
            // txtCommand
            // 
            this.txtCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCommand.Location = new System.Drawing.Point(12, 103);
            this.txtCommand.MaxLength = 256;
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.ReadOnly = true;
            this.txtCommand.Size = new System.Drawing.Size(586, 26);
            this.txtCommand.TabIndex = 2;
            // 
            // btnReadConfigurations
            // 
            this.btnReadConfigurations.BackColor = System.Drawing.Color.White;
            this.btnReadConfigurations.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReadConfigurations.BackgroundImage")));
            this.btnReadConfigurations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReadConfigurations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadConfigurations.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadConfigurations.ForeColor = System.Drawing.Color.White;
            this.btnReadConfigurations.Location = new System.Drawing.Point(12, 452);
            this.btnReadConfigurations.Margin = new System.Windows.Forms.Padding(4);
            this.btnReadConfigurations.Name = "btnReadConfigurations";
            this.btnReadConfigurations.Size = new System.Drawing.Size(156, 37);
            this.btnReadConfigurations.TabIndex = 4;
            this.btnReadConfigurations.Text = "Carregar arquivo";
            this.btnReadConfigurations.UseVisualStyleBackColor = false;
            this.btnReadConfigurations.Click += new System.EventHandler(this.btnReadConfigurations_Click);
            // 
            // btnExec
            // 
            this.btnExec.BackColor = System.Drawing.Color.White;
            this.btnExec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExec.BackgroundImage")));
            this.btnExec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExec.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExec.ForeColor = System.Drawing.Color.White;
            this.btnExec.Location = new System.Drawing.Point(176, 452);
            this.btnExec.Margin = new System.Windows.Forms.Padding(4);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(156, 37);
            this.btnExec.TabIndex = 5;
            this.btnExec.Text = "Enviar";
            this.btnExec.UseVisualStyleBackColor = false;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label2.Location = new System.Drawing.Point(8, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 19);
            this.label2.TabIndex = 145;
            this.label2.Text = "Selecione a Porta COM:";
            // 
            // cbxCOM
            // 
            this.cbxCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCOM.FormattingEnabled = true;
            this.cbxCOM.Location = new System.Drawing.Point(197, 39);
            this.cbxCOM.Name = "cbxCOM";
            this.cbxCOM.Size = new System.Drawing.Size(121, 21);
            this.cbxCOM.TabIndex = 146;
            // 
            // timerCOM
            // 
            this.timerCOM.Interval = 1000;
            this.timerCOM.Tick += new System.EventHandler(this.timerCOM_Tick);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.White;
            this.btnConnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConnect.BackgroundImage")));
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(352, 29);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(109, 37);
            this.btnConnect.TabIndex = 147;
            this.btnConnect.Text = "Conectar";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // CPU8E_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(637, 518);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cbxCOM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCommand);
            this.Controls.Add(this.cmdName);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.btnReadConfigurations);
            this.Controls.Add(this.btnExec);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CPU8E_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPU8E Loader";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CPU8E_Form_FormClosed);
            this.Load += new System.EventHandler(this.CPU8E_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.Label cmdName;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Button btnReadConfigurations;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCOM;
        private System.Windows.Forms.Timer timerCOM;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnConnect;
    }
}

