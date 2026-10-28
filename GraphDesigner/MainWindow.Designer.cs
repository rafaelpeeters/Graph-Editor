namespace GraphDesigner
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.moveModeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.growTSbutton = new System.Windows.Forms.ToolStripButton();
            this.shrinkTSButton = new System.Windows.Forms.ToolStripButton();
            this.eraseTSButton = new System.Windows.Forms.ToolStripButton();
            this.colorTSButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveModeToolStripButton,
            this.growTSbutton,
            this.shrinkTSButton,
            this.eraseTSButton,
            this.colorTSButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // moveModeToolStripButton
            // 
            this.moveModeToolStripButton.CheckOnClick = true;
            this.moveModeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("moveModeToolStripButton.Image")));
            this.moveModeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.moveModeToolStripButton.Name = "moveModeToolStripButton";
            this.moveModeToolStripButton.Size = new System.Drawing.Size(75, 35);
            this.moveModeToolStripButton.Text = "Move Mode";
            this.moveModeToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // growTSbutton
            // 
            this.growTSbutton.Image = ((System.Drawing.Image)(resources.GetObject("growTSbutton.Image")));
            this.growTSbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.growTSbutton.Name = "growTSbutton";
            this.growTSbutton.Size = new System.Drawing.Size(23, 35);
            this.growTSbutton.Text = "+";
            this.growTSbutton.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.growTSbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.growTSbutton.ToolTipText = "toolStripButton1";
            this.growTSbutton.Click += new System.EventHandler(this.growTSbutton_Click);
            // 
            // shrinkTSButton
            // 
            this.shrinkTSButton.Image = ((System.Drawing.Image)(resources.GetObject("shrinkTSButton.Image")));
            this.shrinkTSButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.shrinkTSButton.Name = "shrinkTSButton";
            this.shrinkTSButton.Size = new System.Drawing.Size(23, 35);
            this.shrinkTSButton.Text = "-";
            this.shrinkTSButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.shrinkTSButton.Click += new System.EventHandler(this.shrinkTSButton_Click);
            // 
            // eraseTSButton
            // 
            this.eraseTSButton.Image = ((System.Drawing.Image)(resources.GetObject("eraseTSButton.Image")));
            this.eraseTSButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eraseTSButton.Name = "eraseTSButton";
            this.eraseTSButton.Size = new System.Drawing.Size(55, 35);
            this.eraseTSButton.Text = "Erase All";
            this.eraseTSButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.eraseTSButton.Click += new System.EventHandler(this.eraseTSButton_Click);
            // 
            // colorTSButton
            // 
            this.colorTSButton.Image = ((System.Drawing.Image)(resources.GetObject("colorTSButton.Image")));
            this.colorTSButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorTSButton.Name = "colorTSButton";
            this.colorTSButton.Size = new System.Drawing.Size(45, 35);
            this.colorTSButton.Text = "Colors";
            this.colorTSButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.colorTSButton.Click += new System.EventHandler(this.colorTSButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainWindow_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseUp);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton moveModeToolStripButton;
        private System.Windows.Forms.ToolStripButton growTSbutton;
        private System.Windows.Forms.ToolStripButton shrinkTSButton;
        private System.Windows.Forms.ToolStripButton eraseTSButton;
        private System.Windows.Forms.ToolStripButton colorTSButton;
    }
}

