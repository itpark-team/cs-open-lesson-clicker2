
namespace Кликер_v2
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.labelHpHero = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelScore = new System.Windows.Forms.Label();
            this.buttonUpgrade = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonHero = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelNumberKill = new System.Windows.Forms.Label();
            this.labelHpEnemy = new System.Windows.Forms.Label();
            this.buttonEnemy = new System.Windows.Forms.Button();
            this.timerEnemyAttack = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHpHero
            // 
            this.labelHpHero.AutoSize = true;
            this.labelHpHero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelHpHero.Font = new System.Drawing.Font("Sonic XBd BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHpHero.ForeColor = System.Drawing.Color.Lime;
            this.labelHpHero.Location = new System.Drawing.Point(1, 0);
            this.labelHpHero.Name = "labelHpHero";
            this.labelHpHero.Size = new System.Drawing.Size(56, 30);
            this.labelHpHero.TabIndex = 1;
            this.labelHpHero.Text = "HP: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelScore);
            this.panel1.Controls.Add(this.buttonUpgrade);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 413);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 37);
            this.panel1.TabIndex = 2;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.White;
            this.labelScore.Font = new System.Drawing.Font("Sonic XBd BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelScore.Location = new System.Drawing.Point(3, 3);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(94, 30);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "Score: ";
            // 
            // buttonUpgrade
            // 
            this.buttonUpgrade.BackColor = System.Drawing.Color.White;
            this.buttonUpgrade.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonUpgrade.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonUpgrade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpgrade.Font = new System.Drawing.Font("Sonic XBd BT", 18F);
            this.buttonUpgrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonUpgrade.Location = new System.Drawing.Point(185, 0);
            this.buttonUpgrade.Name = "buttonUpgrade";
            this.buttonUpgrade.Size = new System.Drawing.Size(125, 37);
            this.buttonUpgrade.TabIndex = 0;
            this.buttonUpgrade.Text = "Upgrade";
            this.buttonUpgrade.UseVisualStyleBackColor = false;
            this.buttonUpgrade.Click += new System.EventHandler(this.buttonUpgrade_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelHpHero);
            this.panel2.Controls.Add(this.buttonHero);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 202);
            this.panel2.TabIndex = 3;
            // 
            // buttonHero
            // 
            this.buttonHero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonHero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonHero.FlatAppearance.BorderSize = 0;
            this.buttonHero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.buttonHero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonHero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHero.Location = new System.Drawing.Point(0, 0);
            this.buttonHero.Name = "buttonHero";
            this.buttonHero.Size = new System.Drawing.Size(310, 202);
            this.buttonHero.TabIndex = 0;
            this.buttonHero.UseVisualStyleBackColor = false;
            this.buttonHero.Click += new System.EventHandler(this.buttonHero_Click);
            this.buttonHero.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonHero_MouseDown);
            this.buttonHero.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonHero_MouseUp);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelNumberKill);
            this.panel3.Controls.Add(this.labelHpEnemy);
            this.panel3.Controls.Add(this.buttonEnemy);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 212);
            this.panel3.TabIndex = 4;
            // 
            // labelNumberKill
            // 
            this.labelNumberKill.AutoSize = true;
            this.labelNumberKill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelNumberKill.Font = new System.Drawing.Font("Sonic XBd BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberKill.ForeColor = System.Drawing.Color.Brown;
            this.labelNumberKill.Location = new System.Drawing.Point(3, 182);
            this.labelNumberKill.Name = "labelNumberKill";
            this.labelNumberKill.Size = new System.Drawing.Size(192, 30);
            this.labelNumberKill.TabIndex = 1;
            this.labelNumberKill.Text = "Enemy killed: 0";
            // 
            // labelHpEnemy
            // 
            this.labelHpEnemy.AutoSize = true;
            this.labelHpEnemy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelHpEnemy.Font = new System.Drawing.Font("Sonic XBd BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHpEnemy.ForeColor = System.Drawing.Color.Brown;
            this.labelHpEnemy.Location = new System.Drawing.Point(3, 0);
            this.labelHpEnemy.Name = "labelHpEnemy";
            this.labelHpEnemy.Size = new System.Drawing.Size(56, 30);
            this.labelHpEnemy.TabIndex = 1;
            this.labelHpEnemy.Text = "HP: ";
            // 
            // buttonEnemy
            // 
            this.buttonEnemy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonEnemy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEnemy.BackgroundImage")));
            this.buttonEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEnemy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEnemy.FlatAppearance.BorderSize = 0;
            this.buttonEnemy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonEnemy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonEnemy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnemy.Location = new System.Drawing.Point(0, 0);
            this.buttonEnemy.Name = "buttonEnemy";
            this.buttonEnemy.Size = new System.Drawing.Size(310, 212);
            this.buttonEnemy.TabIndex = 0;
            this.buttonEnemy.UseVisualStyleBackColor = false;
            this.buttonEnemy.Click += new System.EventHandler(this.buttonEnemy_Click);
            this.buttonEnemy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.buttonEnemy.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // timerEnemyAttack
            // 
            this.timerEnemyAttack.Enabled = true;
            this.timerEnemyAttack.Interval = 2000;
            this.timerEnemyAttack.Tick += new System.EventHandler(this.timerEnemyAttack_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(310, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Кликер 2.0";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button buttonHero;
        public System.Windows.Forms.Button buttonEnemy;
        public System.Windows.Forms.Label labelHpHero;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label labelHpEnemy;
        public System.Windows.Forms.Label labelScore;
        public System.Windows.Forms.Button buttonUpgrade;
        public System.Windows.Forms.Timer timerEnemyAttack;
        public System.Windows.Forms.Label labelNumberKill;
    }
}

