namespace SnakeGame
{
    partial class FrmSnakeGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TimerGameLoop = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // TimerGameLoop
            // 
            TimerGameLoop.Interval = 300;
            TimerGameLoop.Tick += TimerGameLoop_Tick;
            // 
            // FrmSnakeGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 481);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmSnakeGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SnakeGame";
            Load += FrmSnakeGame_Load;
            Paint += FrmSnakeGame_Paint;
            KeyDown += FrmSnakeGame_KeyDown;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer TimerGameLoop;
    }
}
