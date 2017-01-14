namespace Zad5
{
    partial class SharpGLForm
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
            this.openGLControl = new SharpGL.OpenGLControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.openGLControl1 = new SharpGL.OpenGLControl();
            this.openGLControl2 = new SharpGL.OpenGLControl();
            this.openGLControl3 = new SharpGL.OpenGLControl();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl3)).BeginInit();
            this.SuspendLayout();
            // 
            // openGLControl
            // 
            this.openGLControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openGLControl.DrawFPS = true;
            this.openGLControl.Location = new System.Drawing.Point(3, 3);
            this.openGLControl.Name = "openGLControl";
            this.openGLControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl.RenderContextType = SharpGL.RenderContextType.FBO;
            this.openGLControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl.Size = new System.Drawing.Size(591, 323);
            this.openGLControl.TabIndex = 0;
            this.openGLControl.OpenGLInitialized += new System.EventHandler(this.openGLControl_OpenGLInitialized);
            this.openGLControl.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl_OpenGLDraw);
            this.openGLControl.Resized += new System.EventHandler(this.openGLControl_Resized);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.openGLControl3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.openGLControl2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.openGLControl1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.openGLControl, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1195, 658);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // openGLControl1
            // 
            this.openGLControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openGLControl1.DrawFPS = true;
            this.openGLControl1.Location = new System.Drawing.Point(600, 3);
            this.openGLControl1.Name = "openGLControl1";
            this.openGLControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl1.RenderContextType = SharpGL.RenderContextType.FBO;
            this.openGLControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl1.Size = new System.Drawing.Size(592, 323);
            this.openGLControl1.TabIndex = 1;
            this.openGLControl1.OpenGLInitialized += new System.EventHandler(this.openGLControl1_OpenGLInitialized);
            this.openGLControl1.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl1_OpenGLDraw_1);
            this.openGLControl1.Resized += new System.EventHandler(this.openGLControl1_Resized);
            // 
            // openGLControl2
            // 
            this.openGLControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openGLControl2.DrawFPS = true;
            this.openGLControl2.Location = new System.Drawing.Point(3, 332);
            this.openGLControl2.Name = "openGLControl2";
            this.openGLControl2.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl2.RenderContextType = SharpGL.RenderContextType.FBO;
            this.openGLControl2.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl2.Size = new System.Drawing.Size(591, 323);
            this.openGLControl2.TabIndex = 2;
            this.openGLControl2.OpenGLInitialized += new System.EventHandler(this.openGLControl2_OpenGLInitialized);
            this.openGLControl2.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl2_OpenGLDraw);
            this.openGLControl2.Resized += new System.EventHandler(this.openGLControl2_Resized);
            // 
            // openGLControl3
            // 
            this.openGLControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openGLControl3.DrawFPS = true;
            this.openGLControl3.Location = new System.Drawing.Point(600, 332);
            this.openGLControl3.Name = "openGLControl3";
            this.openGLControl3.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl3.RenderContextType = SharpGL.RenderContextType.FBO;
            this.openGLControl3.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl3.Size = new System.Drawing.Size(592, 323);
            this.openGLControl3.TabIndex = 3;
            this.openGLControl3.OpenGLInitialized += new System.EventHandler(this.openGLControl3_OpenGLInitialized);
            this.openGLControl3.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl3_OpenGLDraw);
            this.openGLControl3.Resized += new System.EventHandler(this.openGLControl3_Resized);
            // 
            // SharpGLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 658);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SharpGLForm";
            this.Text = "SharpGL Form";
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private SharpGL.OpenGLControl openGLControl3;
        private SharpGL.OpenGLControl openGLControl2;
        private SharpGL.OpenGLControl openGLControl1;
    }
}

