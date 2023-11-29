namespace rockPaper
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.uiTimer = new System.Windows.Forms.Timer(this.components);
            this.countTimer = new System.Windows.Forms.Timer(this.components);
            this.resetBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.winCntLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loseCntLabel = new System.Windows.Forms.Label();
            this.drawCntLabel = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.scissorsBtn = new System.Windows.Forms.Button();
            this.rockBtn = new System.Windows.Forms.Button();
            this.wrapperBtn = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.percentLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTimer
            // 
            this.uiTimer.Enabled = true;
            this.uiTimer.Tick += new System.EventHandler(this.uiTimer_Tick);
            // 
            // countTimer
            // 
            this.countTimer.Enabled = true;
            this.countTimer.Interval = 1000;
            this.countTimer.Tick += new System.EventHandler(this.countTimer_Tick);
            // 
            // resetBtn
            // 
            this.resetBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetBtn.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.resetBtn.Location = new System.Drawing.Point(681, 3);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(110, 25);
            this.resetBtn.TabIndex = 5;
            this.resetBtn.Text = "RESET";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "승리 :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // winCntLabel
            // 
            this.winCntLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winCntLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.winCntLabel.Location = new System.Drawing.Point(116, 0);
            this.winCntLabel.Name = "winCntLabel";
            this.winCntLabel.Size = new System.Drawing.Size(107, 31);
            this.winCntLabel.TabIndex = 8;
            this.winCntLabel.Text = "0";
            this.winCntLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(229, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "패배 : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loseCntLabel
            // 
            this.loseCntLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loseCntLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loseCntLabel.Location = new System.Drawing.Point(342, 0);
            this.loseCntLabel.Name = "loseCntLabel";
            this.loseCntLabel.Size = new System.Drawing.Size(107, 31);
            this.loseCntLabel.TabIndex = 8;
            this.loseCntLabel.Text = "0";
            this.loseCntLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drawCntLabel
            // 
            this.drawCntLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawCntLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.drawCntLabel.Location = new System.Drawing.Point(568, 0);
            this.drawCntLabel.Name = "drawCntLabel";
            this.drawCntLabel.Size = new System.Drawing.Size(107, 31);
            this.drawCntLabel.TabIndex = 10;
            this.drawCntLabel.Text = "0";
            this.drawCntLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            this.label34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label34.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label34.Location = new System.Drawing.Point(455, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(107, 31);
            this.label34.TabIndex = 11;
            this.label34.Text = "무승부 : ";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.814466F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.814466F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.37107F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 620);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 7;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel5.Controls.Add(this.winCntLabel, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.resetBtn, 6, 0);
            this.tableLayoutPanel5.Controls.Add(this.drawCntLabel, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.label34, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.loseCntLabel, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(794, 31);
            this.tableLayoutPanel5.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.countLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.resultLabel, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 77);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.49573F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.29914F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.20513F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 465);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.scissorsBtn, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.rockBtn, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.wrapperBtn, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 336);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(788, 126);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // scissorsBtn
            // 
            this.scissorsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scissorsBtn.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.scissorsBtn.Location = new System.Drawing.Point(160, 3);
            this.scissorsBtn.Name = "scissorsBtn";
            this.scissorsBtn.Size = new System.Drawing.Size(151, 120);
            this.scissorsBtn.TabIndex = 1;
            this.scissorsBtn.Text = "가위";
            this.scissorsBtn.UseVisualStyleBackColor = true;
            this.scissorsBtn.Click += new System.EventHandler(this.scissorsBtn_Click);
            // 
            // rockBtn
            // 
            this.rockBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rockBtn.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rockBtn.Location = new System.Drawing.Point(317, 3);
            this.rockBtn.Name = "rockBtn";
            this.rockBtn.Size = new System.Drawing.Size(151, 120);
            this.rockBtn.TabIndex = 2;
            this.rockBtn.Text = "바위";
            this.rockBtn.UseVisualStyleBackColor = true;
            this.rockBtn.Click += new System.EventHandler(this.rockBtn_Click);
            // 
            // wrapperBtn
            // 
            this.wrapperBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wrapperBtn.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.wrapperBtn.Location = new System.Drawing.Point(474, 3);
            this.wrapperBtn.Name = "wrapperBtn";
            this.wrapperBtn.Size = new System.Drawing.Size(151, 120);
            this.wrapperBtn.TabIndex = 3;
            this.wrapperBtn.Text = "보";
            this.wrapperBtn.UseVisualStyleBackColor = true;
            this.wrapperBtn.Click += new System.EventHandler(this.wrapperBtn_Click);
            // 
            // countLabel
            // 
            this.countLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countLabel.Font = new System.Drawing.Font("굴림", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.countLabel.Location = new System.Drawing.Point(3, 123);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(788, 210);
            this.countLabel.TabIndex = 0;
            this.countLabel.Text = "Ready!!!";
            this.countLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultLabel
            // 
            this.resultLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultLabel.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.resultLabel.Location = new System.Drawing.Point(3, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(788, 123);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.Text = "두근두근";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 7;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel4.Controls.Add(this.percentLabel, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 40);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(794, 31);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // percentLabel
            // 
            this.percentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.percentLabel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.percentLabel.Location = new System.Drawing.Point(116, 0);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(107, 31);
            this.percentLabel.TabIndex = 8;
            this.percentLabel.Text = "0";
            this.percentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 31);
            this.label8.TabIndex = 7;
            this.label8.Text = "승률 :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 620);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer uiTimer;
        private System.Windows.Forms.Timer countTimer;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label winCntLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label loseCntLabel;
        private System.Windows.Forms.Label drawCntLabel;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button scissorsBtn;
        private System.Windows.Forms.Button rockBtn;
        private System.Windows.Forms.Button wrapperBtn;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.Label label8;
    }
}

