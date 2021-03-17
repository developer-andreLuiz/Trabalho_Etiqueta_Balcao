namespace Balcao
{
    partial class FrmInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicial));
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigodeBarra = new System.Windows.Forms.TextBox();
            this.picLayout01 = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.picLayout02 = new System.Windows.Forms.PictureBox();
            this.picLayout03 = new System.Windows.Forms.PictureBox();
            this.picFinal = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.TimerMsg = new System.Windows.Forms.Timer(this.components);
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnBalcao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLayout01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLayout02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLayout03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "Quantidade ";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(12, 177);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(126, 31);
            this.txtQuantidade.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 136);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Insira o código de Barra";
            // 
            // txtCodigodeBarra
            // 
            this.txtCodigodeBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigodeBarra.Location = new System.Drawing.Point(163, 177);
            this.txtCodigodeBarra.Name = "txtCodigodeBarra";
            this.txtCodigodeBarra.Size = new System.Drawing.Size(312, 31);
            this.txtCodigodeBarra.TabIndex = 1;
            this.txtCodigodeBarra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picLayout01
            // 
            this.picLayout01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLayout01.Location = new System.Drawing.Point(12, 469);
            this.picLayout01.Name = "picLayout01";
            this.picLayout01.Size = new System.Drawing.Size(120, 77);
            this.picLayout01.TabIndex = 30;
            this.picLayout01.TabStop = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // picLayout02
            // 
            this.picLayout02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLayout02.Location = new System.Drawing.Point(138, 469);
            this.picLayout02.Name = "picLayout02";
            this.picLayout02.Size = new System.Drawing.Size(120, 77);
            this.picLayout02.TabIndex = 31;
            this.picLayout02.TabStop = false;
            // 
            // picLayout03
            // 
            this.picLayout03.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLayout03.Location = new System.Drawing.Point(264, 469);
            this.picLayout03.Name = "picLayout03";
            this.picLayout03.Size = new System.Drawing.Size(120, 77);
            this.picLayout03.TabIndex = 32;
            this.picLayout03.TabStop = false;
            // 
            // picFinal
            // 
            this.picFinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picFinal.Location = new System.Drawing.Point(12, 564);
            this.picFinal.Name = "picFinal";
            this.picFinal.Size = new System.Drawing.Size(360, 77);
            this.picFinal.TabIndex = 33;
            this.picFinal.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 289);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 20);
            this.lblStatus.TabIndex = 34;
            this.lblStatus.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "01";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "02";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "03";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 593);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Resultado ";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 339);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(154, 89);
            this.dataGridView.TabIndex = 39;
            // 
            // TimerMsg
            // 
            this.TimerMsg.Enabled = true;
            this.TimerMsg.Interval = 1000;
            this.TimerMsg.Tick += new System.EventHandler(this.TimerMsg_Tick);
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.Location = new System.Drawing.Point(367, 224);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(102, 47);
            this.btnEstoque.TabIndex = 3;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = false;
            this.btnEstoque.Click += new System.EventHandler(this.BtnEstoque_Click);
            // 
            // btnBalcao
            // 
            this.btnBalcao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBalcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalcao.Location = new System.Drawing.Point(16, 224);
            this.btnBalcao.Name = "btnBalcao";
            this.btnBalcao.Size = new System.Drawing.Size(102, 47);
            this.btnBalcao.TabIndex = 2;
            this.btnBalcao.Text = "Balcão";
            this.btnBalcao.UseVisualStyleBackColor = false;
            this.btnBalcao.Click += new System.EventHandler(this.BtnBalcao_Click);
            // 
            // FrmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 330);
            this.Controls.Add(this.btnBalcao);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.picFinal);
            this.Controls.Add(this.picLayout03);
            this.Controls.Add(this.picLayout02);
            this.Controls.Add(this.picLayout01);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigodeBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etiqueta";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmInicial_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLayout01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLayout02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLayout03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigodeBarra;
        private System.Windows.Forms.PictureBox picLayout01;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PictureBox picLayout02;
        private System.Windows.Forms.PictureBox picLayout03;
        private System.Windows.Forms.PictureBox picFinal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Timer TimerMsg;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnBalcao;
    }
}