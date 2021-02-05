
namespace SDL_csharp
{
    partial class UserControl4
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
            this.label1 = new System.Windows.Forms.Label();
            this.cate_UC = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cat_combo = new System.Windows.Forms.Label();
            this.itmlist = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.itm_t = new Guna.UI2.WinForms.Guna2TextBox();
            this.cst_t = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edtb = new Guna.UI2.WinForms.Guna2Button();
            this.rmvb = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name :";
            // 
            // cate_UC
            // 
            this.cate_UC.BackColor = System.Drawing.Color.Transparent;
            this.cate_UC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cate_UC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cate_UC.FocusedColor = System.Drawing.Color.Empty;
            this.cate_UC.FocusedState.Parent = this.cate_UC;
            this.cate_UC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cate_UC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cate_UC.FormattingEnabled = true;
            this.cate_UC.HoverState.Parent = this.cate_UC;
            this.cate_UC.ItemHeight = 30;
            this.cate_UC.Items.AddRange(new object[] {
            "South Indian",
            "Punjabi",
            "Mexican",
            "American",
            "Italian",
            "Chinese",
            "Deserts",
            "Softdrinks"});
            this.cate_UC.ItemsAppearance.Parent = this.cate_UC;
            this.cate_UC.Location = new System.Drawing.Point(38, 68);
            this.cate_UC.Name = "cate_UC";
            this.cate_UC.ShadowDecoration.Parent = this.cate_UC;
            this.cate_UC.Size = new System.Drawing.Size(169, 36);
            this.cate_UC.TabIndex = 12;
            this.cate_UC.SelectedIndexChanged += new System.EventHandler(this.cate_UC_SelectedIndexChanged);
            // 
            // cat_combo
            // 
            this.cat_combo.AutoSize = true;
            this.cat_combo.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.cat_combo.ForeColor = System.Drawing.Color.White;
            this.cat_combo.Location = new System.Drawing.Point(34, 41);
            this.cat_combo.Name = "cat_combo";
            this.cat_combo.Size = new System.Drawing.Size(87, 20);
            this.cat_combo.TabIndex = 11;
            this.cat_combo.Text = "Category :";
            // 
            // itmlist
            // 
            this.itmlist.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itmlist.FormattingEnabled = true;
            this.itmlist.ItemHeight = 20;
            this.itmlist.Location = new System.Drawing.Point(38, 167);
            this.itmlist.Name = "itmlist";
            this.itmlist.Size = new System.Drawing.Size(169, 244);
            this.itmlist.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(337, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Item Name :";
            // 
            // itm_t
            // 
            this.itm_t.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.itm_t.DefaultText = "";
            this.itm_t.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.itm_t.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.itm_t.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itm_t.DisabledState.Parent = this.itm_t;
            this.itm_t.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itm_t.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itm_t.FocusedState.Parent = this.itm_t;
            this.itm_t.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itm_t.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itm_t.HoverState.Parent = this.itm_t;
            this.itm_t.Location = new System.Drawing.Point(341, 67);
            this.itm_t.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.itm_t.Name = "itm_t";
            this.itm_t.PasswordChar = '\0';
            this.itm_t.PlaceholderText = "";
            this.itm_t.SelectedText = "";
            this.itm_t.ShadowDecoration.Parent = this.itm_t;
            this.itm_t.Size = new System.Drawing.Size(200, 37);
            this.itm_t.TabIndex = 15;
            // 
            // cst_t
            // 
            this.cst_t.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cst_t.DefaultText = "";
            this.cst_t.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cst_t.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cst_t.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cst_t.DisabledState.Parent = this.cst_t;
            this.cst_t.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cst_t.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cst_t.FocusedState.Parent = this.cst_t;
            this.cst_t.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cst_t.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cst_t.HoverState.Parent = this.cst_t;
            this.cst_t.Location = new System.Drawing.Point(341, 167);
            this.cst_t.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cst_t.Name = "cst_t";
            this.cst_t.PasswordChar = '\0';
            this.cst_t.PlaceholderText = "";
            this.cst_t.SelectedText = "";
            this.cst_t.ShadowDecoration.Parent = this.cst_t;
            this.cst_t.Size = new System.Drawing.Size(200, 36);
            this.cst_t.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(337, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cost :";
            // 
            // edtb
            // 
            this.edtb.CheckedState.Parent = this.edtb;
            this.edtb.CustomImages.Parent = this.edtb;
            this.edtb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtb.ForeColor = System.Drawing.Color.White;
            this.edtb.HoverState.Parent = this.edtb;
            this.edtb.Location = new System.Drawing.Point(341, 248);
            this.edtb.Name = "edtb";
            this.edtb.ShadowDecoration.Parent = this.edtb;
            this.edtb.Size = new System.Drawing.Size(200, 45);
            this.edtb.TabIndex = 18;
            this.edtb.Text = "Update";
            this.edtb.Click += new System.EventHandler(this.edtb_Click);
            // 
            // rmvb
            // 
            this.rmvb.CheckedState.Parent = this.rmvb;
            this.rmvb.CustomImages.Parent = this.rmvb;
            this.rmvb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmvb.ForeColor = System.Drawing.Color.White;
            this.rmvb.HoverState.Parent = this.rmvb;
            this.rmvb.Location = new System.Drawing.Point(341, 334);
            this.rmvb.Name = "rmvb";
            this.rmvb.ShadowDecoration.Parent = this.rmvb;
            this.rmvb.Size = new System.Drawing.Size(200, 45);
            this.rmvb.TabIndex = 19;
            this.rmvb.Text = "Remove";
            this.rmvb.Click += new System.EventHandler(this.rmvb_Click);
            // 
            // UserControl4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(139)))));
            this.Controls.Add(this.rmvb);
            this.Controls.Add(this.edtb);
            this.Controls.Add(this.cst_t);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itm_t);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itmlist);
            this.Controls.Add(this.cate_UC);
            this.Controls.Add(this.cat_combo);
            this.Controls.Add(this.label1);
            this.Name = "UserControl4";
            this.Size = new System.Drawing.Size(590, 450);
            this.Load += new System.EventHandler(this.UserControl4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cate_UC;
        private System.Windows.Forms.Label cat_combo;
        private System.Windows.Forms.ListBox itmlist;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox itm_t;
        private Guna.UI2.WinForms.Guna2TextBox cst_t;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button edtb;
        private Guna.UI2.WinForms.Guna2Button rmvb;
    }
}
