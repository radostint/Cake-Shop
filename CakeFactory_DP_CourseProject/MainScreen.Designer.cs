using System;
using System.Windows.Forms;

namespace CakeFactory_DP_CourseProject
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.buttonHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SelectedPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.productsControl = new CakeFactory_DP_CourseProject.ProductsControl();
            this.homeControl = new CakeFactory_DP_CourseProject.HomeControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(10, 211);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(189, 46);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "Начало";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(66)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.SelectedPanel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonProducts);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 627);
            this.panel1.TabIndex = 1;
            // 
            // SelectedPanel
            // 
            this.SelectedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.SelectedPanel.Location = new System.Drawing.Point(1, 211);
            this.SelectedPanel.Name = "SelectedPanel";
            this.SelectedPanel.Size = new System.Drawing.Size(10, 46);
            this.SelectedPanel.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = global::CakeFactory_DP_CourseProject.Properties.Resources.sladkarnica_logo_variant2;
            this.pictureBox1.Image = global::CakeFactory_DP_CourseProject.Properties.Resources.sladkarnica_logo_variant2;
            this.pictureBox1.ImageLocation = " ";
            this.pictureBox1.Location = new System.Drawing.Point(2, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // buttonProducts
            // 
            this.buttonProducts.FlatAppearance.BorderSize = 0;
            this.buttonProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProducts.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProducts.ForeColor = System.Drawing.Color.White;
            this.buttonProducts.Image = ((System.Drawing.Image)(resources.GetObject("buttonProducts.Image")));
            this.buttonProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProducts.Location = new System.Drawing.Point(10, 263);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(189, 46);
            this.buttonProducts.TabIndex = 1;
            this.buttonProducts.Text = "Продукти";
            this.buttonProducts.UseVisualStyleBackColor = true;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1090, 10);
            this.panel2.TabIndex = 2;
            // 
            // productsControl
            // 
            this.productsControl.BackColor = System.Drawing.Color.Transparent;
            this.productsControl.Location = new System.Drawing.Point(202, 12);
            this.productsControl.Name = "productsControl";
            this.productsControl.Size = new System.Drawing.Size(1088, 615);
            this.productsControl.TabIndex = 3;
            // 
            // homeControl
            // 
            this.homeControl.BackColor = System.Drawing.Color.Transparent;
            this.homeControl.Location = new System.Drawing.Point(200, 0);
            this.homeControl.Name = "homeControl";
            this.homeControl.Size = new System.Drawing.Size(1098, 655);
            this.homeControl.TabIndex = 4;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CakeFactory_DP_CourseProject.Properties.Resources.sladkarnica_bg_variant2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1290, 627);
            this.Controls.Add(this.homeControl);
            this.Controls.Add(this.productsControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHome;
        private Panel panel1;
        private Panel panel2;
        private Button buttonProducts;
        private PictureBox pictureBox1;
        private Panel SelectedPanel;
        private ProductsControl productsControl;
        private HomeControl homeControl;
    }
}