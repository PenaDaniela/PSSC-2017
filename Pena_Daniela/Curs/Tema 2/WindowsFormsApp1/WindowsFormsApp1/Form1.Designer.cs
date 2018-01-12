namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelPizza = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelIngredients = new System.Windows.Forms.FlowLayoutPanel();
            this.AddPizzaToOrderButton = new System.Windows.Forms.Button();
            this.CompleteOrderButton = new System.Windows.Forms.Button();
            this.ResetPizzaButton = new System.Windows.Forms.Button();
            this.RemovePizzaFromOrderButton = new System.Windows.Forms.Button();
            this.StatusButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ResetOrderButton = new System.Windows.Forms.Button();
            this.luigiPizzaDBDataSet = new WindowsFormsApp1.LuigiPizzaDBDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new WindowsFormsApp1.LuigiPizzaDBDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.LuigiPizzaDBDataSetTableAdapters.TableAdapterManager();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.luigiPizzaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // flowLayoutPanelPizza
            // 
            this.flowLayoutPanelPizza.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanelPizza.Name = "flowLayoutPanelPizza";
            this.flowLayoutPanelPizza.Size = new System.Drawing.Size(351, 606);
            this.flowLayoutPanelPizza.TabIndex = 1;
            // 
            // flowLayoutPanelIngredients
            // 
            this.flowLayoutPanelIngredients.Location = new System.Drawing.Point(369, 71);
            this.flowLayoutPanelIngredients.Name = "flowLayoutPanelIngredients";
            this.flowLayoutPanelIngredients.Size = new System.Drawing.Size(385, 547);
            this.flowLayoutPanelIngredients.TabIndex = 2;
            // 
            // AddPizzaToOrderButton
            // 
            this.AddPizzaToOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPizzaToOrderButton.Location = new System.Drawing.Point(802, 22);
            this.AddPizzaToOrderButton.Name = "AddPizzaToOrderButton";
            this.AddPizzaToOrderButton.Size = new System.Drawing.Size(186, 64);
            this.AddPizzaToOrderButton.TabIndex = 3;
            this.AddPizzaToOrderButton.Text = "Add Pizza to Order";
            this.AddPizzaToOrderButton.UseVisualStyleBackColor = true;
            this.AddPizzaToOrderButton.Click += new System.EventHandler(this.AddPizzaToOrderButton_Click);
            // 
            // CompleteOrderButton
            // 
            this.CompleteOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompleteOrderButton.Location = new System.Drawing.Point(802, 420);
            this.CompleteOrderButton.Name = "CompleteOrderButton";
            this.CompleteOrderButton.Size = new System.Drawing.Size(186, 108);
            this.CompleteOrderButton.TabIndex = 5;
            this.CompleteOrderButton.Text = "Complete Order";
            this.CompleteOrderButton.UseVisualStyleBackColor = true;
            this.CompleteOrderButton.Click += new System.EventHandler(this.CompleteOrderButton_Click);
            // 
            // ResetPizzaButton
            // 
            this.ResetPizzaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetPizzaButton.Location = new System.Drawing.Point(1055, 71);
            this.ResetPizzaButton.Name = "ResetPizzaButton";
            this.ResetPizzaButton.Size = new System.Drawing.Size(186, 72);
            this.ResetPizzaButton.TabIndex = 6;
            this.ResetPizzaButton.Text = "Reset Pizza";
            this.ResetPizzaButton.UseVisualStyleBackColor = true;
            this.ResetPizzaButton.Click += new System.EventHandler(this.ResetPizzaButton_Click);
            // 
            // RemovePizzaFromOrderButton
            // 
            this.RemovePizzaFromOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemovePizzaFromOrderButton.Location = new System.Drawing.Point(1055, 266);
            this.RemovePizzaFromOrderButton.Name = "RemovePizzaFromOrderButton";
            this.RemovePizzaFromOrderButton.Size = new System.Drawing.Size(186, 72);
            this.RemovePizzaFromOrderButton.TabIndex = 7;
            this.RemovePizzaFromOrderButton.Text = "Remove pizza from order";
            this.RemovePizzaFromOrderButton.UseVisualStyleBackColor = true;
            this.RemovePizzaFromOrderButton.Click += new System.EventHandler(this.RemovePizzaFromOrderButton_Click);
            // 
            // StatusButton
            // 
            this.StatusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusButton.Location = new System.Drawing.Point(1088, 487);
            this.StatusButton.Name = "StatusButton";
            this.StatusButton.Size = new System.Drawing.Size(127, 41);
            this.StatusButton.TabIndex = 8;
            this.StatusButton.Text = "Status";
            this.StatusButton.UseVisualStyleBackColor = true;
            this.StatusButton.Click += new System.EventHandler(this.StatusButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(797, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Order Price : ";
            // 
            // ResetOrderButton
            // 
            this.ResetOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetOrderButton.Location = new System.Drawing.Point(1055, 169);
            this.ResetOrderButton.Name = "ResetOrderButton";
            this.ResetOrderButton.Size = new System.Drawing.Size(186, 72);
            this.ResetOrderButton.TabIndex = 6;
            this.ResetOrderButton.Text = "Reset Order";
            this.ResetOrderButton.UseVisualStyleBackColor = true;
            this.ResetOrderButton.Click += new System.EventHandler(this.ResetOrderButton_Click);
            // 
            // luigiPizzaDBDataSet
            // 
            this.luigiPizzaDBDataSet.DataSetName = "LuigiPizzaDBDataSet";
            this.luigiPizzaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.luigiPizzaDBDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.LuigiPizzaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(802, 123);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(802, 237);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(186, 173);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(924, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(797, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Pizza Price :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(923, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 630);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StatusButton);
            this.Controls.Add(this.RemovePizzaFromOrderButton);
            this.Controls.Add(this.ResetOrderButton);
            this.Controls.Add(this.ResetPizzaButton);
            this.Controls.Add(this.CompleteOrderButton);
            this.Controls.Add(this.AddPizzaToOrderButton);
            this.Controls.Add(this.flowLayoutPanelIngredients);
            this.Controls.Add(this.flowLayoutPanelPizza);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luigiPizzaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPizza;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelIngredients;
        private System.Windows.Forms.Button AddPizzaToOrderButton;
        private System.Windows.Forms.Button CompleteOrderButton;
        private System.Windows.Forms.Button ResetPizzaButton;
        private System.Windows.Forms.Button RemovePizzaFromOrderButton;
        private System.Windows.Forms.Button StatusButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ResetOrderButton;
        private LuigiPizzaDBDataSet luigiPizzaDBDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private LuigiPizzaDBDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private LuigiPizzaDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

