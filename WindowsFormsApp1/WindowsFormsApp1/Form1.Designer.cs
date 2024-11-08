
namespace WindowsFormsApp1
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
            this.PantallaCalculadora = new System.Windows.Forms.RichTextBox();
            this.Nueve = new System.Windows.Forms.Button();
            this.Ocho = new System.Windows.Forms.Button();
            this.Siete = new System.Windows.Forms.Button();
            this.Seis = new System.Windows.Forms.Button();
            this.Cinco = new System.Windows.Forms.Button();
            this.Cuatro = new System.Windows.Forms.Button();
            this.Tres = new System.Windows.Forms.Button();
            this.Dos = new System.Windows.Forms.Button();
            this.Uno = new System.Windows.Forms.Button();
            this.Resta = new System.Windows.Forms.Button();
            this.Igual = new System.Windows.Forms.Button();
            this.Cero = new System.Windows.Forms.Button();
            this.Suma = new System.Windows.Forms.Button();
            this.Multiplicacion = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PantallaCalculadora
            // 
            this.PantallaCalculadora.Location = new System.Drawing.Point(412, 39);
            this.PantallaCalculadora.Name = "PantallaCalculadora";
            this.PantallaCalculadora.Size = new System.Drawing.Size(271, 57);
            this.PantallaCalculadora.TabIndex = 0;
            this.PantallaCalculadora.Text = "";
            this.PantallaCalculadora.TextChanged += new System.EventHandler(this.PantallaCalculadora_TextChanged);
            // 
            // Nueve
            // 
            this.Nueve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(146)))));
            this.Nueve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nueve.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(146)))));
            this.Nueve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            this.Nueve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Nueve.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nueve.ForeColor = System.Drawing.Color.White;
            this.Nueve.Location = new System.Drawing.Point(177, 103);
            this.Nueve.Name = "Nueve";
            this.Nueve.Size = new System.Drawing.Size(47, 55);
            this.Nueve.TabIndex = 1;
            this.Nueve.Text = "9";
            this.Nueve.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Nueve.UseVisualStyleBackColor = false;
            // 
            // Ocho
            // 
            this.Ocho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(146)))));
            this.Ocho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ocho.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(146)))));
            this.Ocho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            this.Ocho.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ocho.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ocho.ForeColor = System.Drawing.Color.White;
            this.Ocho.Location = new System.Drawing.Point(102, 103);
            this.Ocho.Name = "Ocho";
            this.Ocho.Size = new System.Drawing.Size(47, 55);
            this.Ocho.TabIndex = 2;
            this.Ocho.Text = "8";
            this.Ocho.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Ocho.UseVisualStyleBackColor = false;
            this.Ocho.Click += new System.EventHandler(this.Ocho_Click);
            // 
            // Siete
            // 
            this.Siete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(146)))));
            this.Siete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Siete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(146)))));
            this.Siete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            this.Siete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Siete.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Siete.ForeColor = System.Drawing.Color.White;
            this.Siete.Location = new System.Drawing.Point(31, 103);
            this.Siete.Name = "Siete";
            this.Siete.Size = new System.Drawing.Size(47, 55);
            this.Siete.TabIndex = 3;
            this.Siete.Text = "7";
            this.Siete.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Siete.UseVisualStyleBackColor = false;
            this.Siete.Click += new System.EventHandler(this.Form1_Load);
            this.Siete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Siete_MouseClick);
            // 
            // Seis
            // 
            this.Seis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(146)))));
            this.Seis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Seis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(146)))));
            this.Seis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            this.Seis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Seis.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seis.ForeColor = System.Drawing.Color.White;
            this.Seis.Location = new System.Drawing.Point(177, 186);
            this.Seis.Name = "Seis";
            this.Seis.Size = new System.Drawing.Size(47, 55);
            this.Seis.TabIndex = 6;
            this.Seis.Text = "6";
            this.Seis.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Seis.UseVisualStyleBackColor = false;
            // 
            // Cinco
            // 
            this.Cinco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(146)))));
            this.Cinco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cinco.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(146)))));
            this.Cinco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            this.Cinco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cinco.ForeColor = System.Drawing.Color.White;
            this.Cinco.Location = new System.Drawing.Point(102, 186);
            this.Cinco.Name = "Cinco";
            this.Cinco.Size = new System.Drawing.Size(47, 55);
            this.Cinco.TabIndex = 5;
            this.Cinco.Text = "5";
            this.Cinco.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Cinco.UseVisualStyleBackColor = false;
            // 
            // Cuatro
            // 
            this.Cuatro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(146)))));
            this.Cuatro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cuatro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(146)))));
            this.Cuatro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            this.Cuatro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cuatro.ForeColor = System.Drawing.Color.White;
            this.Cuatro.Location = new System.Drawing.Point(31, 186);
            this.Cuatro.Name = "Cuatro";
            this.Cuatro.Size = new System.Drawing.Size(47, 55);
            this.Cuatro.TabIndex = 4;
            this.Cuatro.Text = "4";
            this.Cuatro.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Cuatro.UseVisualStyleBackColor = false;
            // 
            // Tres
            // 
            this.Tres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(146)))));
            this.Tres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tres.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(146)))));
            this.Tres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            this.Tres.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Tres.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tres.ForeColor = System.Drawing.Color.White;
            this.Tres.Location = new System.Drawing.Point(177, 262);
            this.Tres.Name = "Tres";
            this.Tres.Size = new System.Drawing.Size(47, 55);
            this.Tres.TabIndex = 9;
            this.Tres.Text = "3";
            this.Tres.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Tres.UseVisualStyleBackColor = false;
            // 
            // Dos
            // 
            this.Dos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(146)))));
            this.Dos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(146)))));
            this.Dos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            this.Dos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dos.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dos.ForeColor = System.Drawing.Color.White;
            this.Dos.Location = new System.Drawing.Point(102, 262);
            this.Dos.Name = "Dos";
            this.Dos.Size = new System.Drawing.Size(47, 55);
            this.Dos.TabIndex = 8;
            this.Dos.Text = "2";
            this.Dos.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Dos.UseVisualStyleBackColor = false;
            // 
            // Uno
            // 
            this.Uno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(146)))));
            this.Uno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Uno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(146)))));
            this.Uno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            this.Uno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Uno.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uno.ForeColor = System.Drawing.Color.White;
            this.Uno.Location = new System.Drawing.Point(31, 262);
            this.Uno.Name = "Uno";
            this.Uno.Size = new System.Drawing.Size(47, 55);
            this.Uno.TabIndex = 7;
            this.Uno.Text = "1";
            this.Uno.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Uno.UseVisualStyleBackColor = false;
            // 
            // Resta
            // 
            this.Resta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(146)))));
            this.Resta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Resta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(146)))));
            this.Resta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            this.Resta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Resta.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resta.ForeColor = System.Drawing.Color.White;
            this.Resta.Location = new System.Drawing.Point(246, 336);
            this.Resta.Name = "Resta";
            this.Resta.Size = new System.Drawing.Size(47, 55);
            this.Resta.TabIndex = 12;
            this.Resta.Text = "-";
            this.Resta.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Resta.UseVisualStyleBackColor = false;
            // 
            // Igual
            // 
            this.Igual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(146)))));
            this.Igual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Igual.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(146)))));
            this.Igual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            this.Igual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Igual.ForeColor = System.Drawing.Color.White;
            this.Igual.Location = new System.Drawing.Point(102, 336);
            this.Igual.Name = "Igual";
            this.Igual.Size = new System.Drawing.Size(122, 55);
            this.Igual.TabIndex = 11;
            this.Igual.Text = "=";
            this.Igual.UseVisualStyleBackColor = false;
            // 
            // Cero
            // 
            this.Cero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(146)))));
            this.Cero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(146)))));
            this.Cero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            this.Cero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cero.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cero.ForeColor = System.Drawing.Color.White;
            this.Cero.Location = new System.Drawing.Point(31, 336);
            this.Cero.Name = "Cero";
            this.Cero.Size = new System.Drawing.Size(47, 55);
            this.Cero.TabIndex = 10;
            this.Cero.Text = "0";
            this.Cero.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Cero.UseVisualStyleBackColor = false;
            // 
            // Suma
            // 
            this.Suma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(146)))));
            this.Suma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Suma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(146)))));
            this.Suma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            this.Suma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suma.ForeColor = System.Drawing.Color.White;
            this.Suma.Location = new System.Drawing.Point(246, 262);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(47, 55);
            this.Suma.TabIndex = 13;
            this.Suma.Text = "+";
            this.Suma.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Suma.UseVisualStyleBackColor = false;
            this.Suma.Click += new System.EventHandler(this.Suma_Click);
            // 
            // Multiplicacion
            // 
            this.Multiplicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(146)))));
            this.Multiplicacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Multiplicacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(146)))));
            this.Multiplicacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            this.Multiplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Multiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplicacion.ForeColor = System.Drawing.Color.White;
            this.Multiplicacion.Location = new System.Drawing.Point(246, 186);
            this.Multiplicacion.Name = "Multiplicacion";
            this.Multiplicacion.Size = new System.Drawing.Size(47, 55);
            this.Multiplicacion.TabIndex = 14;
            this.Multiplicacion.Text = "*";
            this.Multiplicacion.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Multiplicacion.UseVisualStyleBackColor = false;
            // 
            // Division
            // 
            this.Division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(146)))));
            this.Division.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Division.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(146)))));
            this.Division.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            this.Division.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Division.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Division.ForeColor = System.Drawing.Color.White;
            this.Division.Location = new System.Drawing.Point(246, 103);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(47, 55);
            this.Division.TabIndex = 15;
            this.Division.Text = "\\";
            this.Division.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Division.UseVisualStyleBackColor = false;
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(114, 39);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(0, 13);
            this.Output.TabIndex = 16;
            this.Output.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(174)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(777, 421);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplicacion);
            this.Controls.Add(this.Suma);
            this.Controls.Add(this.Resta);
            this.Controls.Add(this.Igual);
            this.Controls.Add(this.Cero);
            this.Controls.Add(this.Tres);
            this.Controls.Add(this.Dos);
            this.Controls.Add(this.Uno);
            this.Controls.Add(this.Seis);
            this.Controls.Add(this.Cinco);
            this.Controls.Add(this.Cuatro);
            this.Controls.Add(this.Siete);
            this.Controls.Add(this.Ocho);
            this.Controls.Add(this.Nueve);
            this.Controls.Add(this.PantallaCalculadora);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox PantallaCalculadora;
        private System.Windows.Forms.Button Nueve;
        private System.Windows.Forms.Button Ocho;
        private System.Windows.Forms.Button Siete;
        private System.Windows.Forms.Button Seis;
        private System.Windows.Forms.Button Cinco;
        private System.Windows.Forms.Button Cuatro;
        private System.Windows.Forms.Button Tres;
        private System.Windows.Forms.Button Dos;
        private System.Windows.Forms.Button Uno;
        private System.Windows.Forms.Button Resta;
        private System.Windows.Forms.Button Igual;
        private System.Windows.Forms.Button Cero;
        private System.Windows.Forms.Button Suma;
        private System.Windows.Forms.Button Multiplicacion;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Label Output;
    }
}

