namespace OCR
{
    partial class Principal
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
            this.pbScratch = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ilSamples = new System.Windows.Forms.ImageList(this.components);
            this.lvInputs = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnTreinar = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnTestar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEpoch = new System.Windows.Forms.Label();
            this.lblErro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbScratch)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbScratch
            // 
            this.pbScratch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbScratch.Location = new System.Drawing.Point(12, 12);
            this.pbScratch.Name = "pbScratch";
            this.pbScratch.Size = new System.Drawing.Size(200, 200);
            this.pbScratch.TabIndex = 0;
            this.pbScratch.TabStop = false;
            this.pbScratch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbScratch_MouseDown);
            this.pbScratch.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbScratch_MouseMove);
            this.pbScratch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbScratch_MouseUp);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(218, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 37);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "&Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ilSamples
            // 
            this.ilSamples.ColorDepth = System.Windows.Forms.ColorDepth.Depth4Bit;
            this.ilSamples.ImageSize = new System.Drawing.Size(8, 8);
            this.ilSamples.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lvInputs
            // 
            this.lvInputs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvInputs.LargeImageList = this.ilSamples;
            this.lvInputs.Location = new System.Drawing.Point(336, 12);
            this.lvInputs.Name = "lvInputs";
            this.lvInputs.Size = new System.Drawing.Size(192, 200);
            this.lvInputs.StateImageList = this.ilSamples;
            this.lvInputs.TabIndex = 2;
            this.lvInputs.UseCompatibleStateImageBehavior = false;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(12, 218);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 31);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "<Nome do Padrão>";
            // 
            // btnTreinar
            // 
            this.btnTreinar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreinar.Location = new System.Drawing.Point(6, 19);
            this.btnTreinar.Name = "btnTreinar";
            this.btnTreinar.Size = new System.Drawing.Size(129, 48);
            this.btnTreinar.TabIndex = 4;
            this.btnTreinar.Text = "&Treinamento";
            this.btnTreinar.UseVisualStyleBackColor = true;
            this.btnTreinar.Click += new System.EventHandler(this.btnTreinar_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(218, 55);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 39);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnTestar
            // 
            this.btnTestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestar.Location = new System.Drawing.Point(324, 19);
            this.btnTestar.Name = "btnTestar";
            this.btnTestar.Size = new System.Drawing.Size(129, 50);
            this.btnTestar.TabIndex = 6;
            this.btnTestar.Text = "T&estar";
            this.btnTestar.UseVisualStyleBackColor = true;
            this.btnTestar.Click += new System.EventHandler(this.btnTestar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblEpoch);
            this.groupBox1.Controls.Add(this.lblErro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnTreinar);
            this.groupBox1.Controls.Add(this.btnTestar);
            this.groupBox1.Location = new System.Drawing.Point(12, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 159);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rede Neural";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(406, 77);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Padrão:";
            // 
            // lblEpoch
            // 
            this.lblEpoch.AutoSize = true;
            this.lblEpoch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEpoch.Location = new System.Drawing.Point(92, 107);
            this.lblEpoch.Name = "lblEpoch";
            this.lblEpoch.Size = new System.Drawing.Size(0, 20);
            this.lblEpoch.TabIndex = 10;
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.Location = new System.Drawing.Point(92, 77);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 20);
            this.lblErro.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Épocas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Erro:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 436);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lvInputs);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pbScratch);
            this.Name = "Principal";
            this.Text = "Redes Neurais Artificiais em OCR";
            ((System.ComponentModel.ISupportInitialize)(this.pbScratch)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbScratch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ImageList ilSamples;
        private System.Windows.Forms.ListView lvInputs;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnTreinar;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnTestar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEpoch;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}

