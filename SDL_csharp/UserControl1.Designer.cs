
namespace SDL_csharp
{
    partial class UserControl1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name_t = new System.Windows.Forms.TextBox();
            this.cost_t = new System.Windows.Forms.TextBox();
            this.combo_t = new Guna.UI2.WinForms.Guna2ComboBox();
            this.add_b = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cost of the Item :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category :";
            // 
            // name_t
            // 
            this.name_t.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_t.Location = new System.Drawing.Point(59, 193);
            this.name_t.Multiline = true;
            this.name_t.Name = "name_t";
            this.name_t.Size = new System.Drawing.Size(309, 33);
            this.name_t.TabIndex = 3;
            // 
            // cost_t
            // 
            this.cost_t.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_t.Location = new System.Drawing.Point(59, 283);
            this.cost_t.Multiline = true;
            this.cost_t.Name = "cost_t";
            this.cost_t.Size = new System.Drawing.Size(186, 33);
            this.cost_t.TabIndex = 4;
            // 
            // combo_t
            // 
            this.combo_t.BackColor = System.Drawing.Color.Transparent;
            this.combo_t.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_t.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_t.FocusedColor = System.Drawing.Color.Empty;
            this.combo_t.FocusedState.Parent = this.combo_t;
            this.combo_t.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_t.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_t.FormattingEnabled = true;
            this.combo_t.HoverState.Parent = this.combo_t;
            this.combo_t.ItemHeight = 30;
            this.combo_t.Items.AddRange(new object[] {
            "South Indian",
            "Punjabi",
            "Mexican",
            "American",
            "Italian",
            "Chinese",
            "Deserts",
            "Softdrinks"});
            this.combo_t.ItemsAppearance.Parent = this.combo_t;
            this.combo_t.Location = new System.Drawing.Point(59, 110);
            this.combo_t.Name = "combo_t";
            this.combo_t.ShadowDecoration.Parent = this.combo_t;
            this.combo_t.Size = new System.Drawing.Size(224, 36);
            this.combo_t.TabIndex = 5;
            // 
            // add_b
            // 
            this.add_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_b.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_b.ForeColor = System.Drawing.Color.White;
            this.add_b.Location = new System.Drawing.Point(206, 392);
            this.add_b.Name = "add_b";
            this.add_b.Size = new System.Drawing.Size(144, 40);
            this.add_b.TabIndex = 6;
            this.add_b.Text = "Add item";
            this.add_b.UseVisualStyleBackColor = true;
            this.add_b.Click += new System.EventHandler(this.add_b_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.add_b);
            this.Controls.Add(this.combo_t);
            this.Controls.Add(this.cost_t);
            this.Controls.Add(this.name_t);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(590, 450);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.Leave += new System.EventHandler(this.UserControl1_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_t;
        private System.Windows.Forms.TextBox cost_t;
        private Guna.UI2.WinForms.Guna2ComboBox combo_t;
        private System.Windows.Forms.Button add_b;
    }
}
