namespace mode_control
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tMode = new System.Windows.Forms.TextBox();
            this.tMinimal = new System.Windows.Forms.TextBox();
            this.tMaximum = new System.Windows.Forms.TextBox();
            this.cMixed = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bInsert = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bQuery = new System.Windows.Forms.Button();
            this.rAll = new System.Windows.Forms.RadioButton();
            this.rMixed = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modalidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mínimo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Máximo";
            // 
            // tMode
            // 
            this.tMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMode.Location = new System.Drawing.Point(40, 56);
            this.tMode.Name = "tMode";
            this.tMode.Size = new System.Drawing.Size(100, 26);
            this.tMode.TabIndex = 3;
            // 
            // tMinimal
            // 
            this.tMinimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMinimal.Location = new System.Drawing.Point(40, 149);
            this.tMinimal.Name = "tMinimal";
            this.tMinimal.Size = new System.Drawing.Size(100, 26);
            this.tMinimal.TabIndex = 4;
            // 
            // tMaximum
            // 
            this.tMaximum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMaximum.Location = new System.Drawing.Point(40, 258);
            this.tMaximum.Name = "tMaximum";
            this.tMaximum.Size = new System.Drawing.Size(100, 26);
            this.tMaximum.TabIndex = 5;
            // 
            // cMixed
            // 
            this.cMixed.AutoSize = true;
            this.cMixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cMixed.Location = new System.Drawing.Point(40, 319);
            this.cMixed.Name = "cMixed";
            this.cMixed.Size = new System.Drawing.Size(73, 28);
            this.cMixed.TabIndex = 6;
            this.cMixed.Text = "Misto";
            this.cMixed.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(189, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(379, 249);
            this.dataGridView1.TabIndex = 7;
            // 
            // bInsert
            // 
            this.bInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInsert.Location = new System.Drawing.Point(307, 298);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(75, 32);
            this.bInsert.TabIndex = 9;
            this.bInsert.Text = "Inserir";
            this.bInsert.UseVisualStyleBackColor = true;
            this.bInsert.Click += new System.EventHandler(this.bInsert_Click);
            // 
            // bDelete
            // 
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.Location = new System.Drawing.Point(388, 298);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 32);
            this.bDelete.TabIndex = 10;
            this.bDelete.Text = "Apagar";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUpdate.Location = new System.Drawing.Point(469, 298);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(78, 32);
            this.bUpdate.TabIndex = 11;
            this.bUpdate.Text = "Atualizar";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bQuery
            // 
            this.bQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bQuery.Location = new System.Drawing.Point(218, 298);
            this.bQuery.Name = "bQuery";
            this.bQuery.Size = new System.Drawing.Size(83, 32);
            this.bQuery.TabIndex = 12;
            this.bQuery.Text = "Pesquisar";
            this.bQuery.UseVisualStyleBackColor = true;
            this.bQuery.Click += new System.EventHandler(this.bQuery_Click);
            // 
            // rAll
            // 
            this.rAll.AutoSize = true;
            this.rAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rAll.Location = new System.Drawing.Point(587, 65);
            this.rAll.Name = "rAll";
            this.rAll.Size = new System.Drawing.Size(71, 24);
            this.rAll.TabIndex = 13;
            this.rAll.TabStop = true;
            this.rAll.Text = "Todos";
            this.rAll.UseVisualStyleBackColor = true;
            this.rAll.CheckedChanged += new System.EventHandler(this.rAll_CheckedChanged);
            // 
            // rMixed
            // 
            this.rMixed.AutoSize = true;
            this.rMixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rMixed.Location = new System.Drawing.Point(587, 100);
            this.rMixed.Name = "rMixed";
            this.rMixed.Size = new System.Drawing.Size(65, 24);
            this.rMixed.TabIndex = 14;
            this.rMixed.TabStop = true;
            this.rMixed.Text = "Misto";
            this.rMixed.UseVisualStyleBackColor = true;
            this.rMixed.CheckedChanged += new System.EventHandler(this.rMixed_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(583, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Filtro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 394);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rMixed);
            this.Controls.Add(this.rAll);
            this.Controls.Add(this.bQuery);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bInsert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cMixed);
            this.Controls.Add(this.tMaximum);
            this.Controls.Add(this.tMinimal);
            this.Controls.Add(this.tMode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Controle de Modalidade";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tMode;
        private System.Windows.Forms.TextBox tMinimal;
        private System.Windows.Forms.TextBox tMaximum;
        private System.Windows.Forms.CheckBox cMixed;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bInsert;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bQuery;
        private System.Windows.Forms.RadioButton rAll;
        private System.Windows.Forms.RadioButton rMixed;
        private System.Windows.Forms.Label label4;
    }
}

