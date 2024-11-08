
using System;

namespace ejemplo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.FlipACoin = new System.Windows.Forms.Button();
            this.HelloWorld = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FlipACoin
            // 
            this.FlipACoin.BackColor = System.Drawing.Color.Goldenrod;
            this.FlipACoin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FlipACoin.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.FlipACoin.FlatAppearance.BorderSize = 3;
            this.FlipACoin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.FlipACoin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FlipACoin.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FlipACoin.ForeColor = System.Drawing.Color.LightCyan;
            this.FlipACoin.Location = new System.Drawing.Point(294, 336);
            this.FlipACoin.Name = "FlipACoin";
            this.FlipACoin.Size = new System.Drawing.Size(136, 66);
            this.FlipACoin.TabIndex = 1;
            this.FlipACoin.Text = "Flip a Coin";
            this.FlipACoin.UseVisualStyleBackColor = false;
            this.FlipACoin.Click += new System.EventHandler(this.button1_Click);
            // 
            // HelloWorld
            // 
            this.HelloWorld.AutoSize = true;
            this.HelloWorld.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HelloWorld.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HelloWorld.Font = new System.Drawing.Font("Arial", 52F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.HelloWorld.ForeColor = System.Drawing.Color.SaddleBrown;
            this.HelloWorld.Location = new System.Drawing.Point(317, 405);
            this.HelloWorld.Name = "HelloWorld";
            this.HelloWorld.Size = new System.Drawing.Size(41, 62);
            this.HelloWorld.TabIndex = 2;
            this.HelloWorld.Text = " ";
            this.HelloWorld.Click += new System.EventHandler(this.HelloWorld_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(44, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(435, 56);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.HelloWorld);
            this.Controls.Add(this.FlipACoin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void HelloWorld_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button FlipACoin;
        private System.Windows.Forms.Label HelloWorld;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

