namespace MyCaffeSampleUI
{
    partial class FormMyCaffeSamples
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
            this.components = new System.ComponentModel.Container();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLeNet = new System.Windows.Forms.Button();
            this.btnSiamese = new System.Windows.Forms.Button();
            this.btnTriplet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCharRnn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCartPole = new System.Windows.Forms.Button();
            this.btnAtariPong = new System.Windows.Forms.Button();
            this.btnAtariBreakout = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStyleTransfer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnONNX = new System.Windows.Forms.Button();
            this.btnWebCam = new System.Windows.Forms.Button();
            this.timerUI = new System.Windows.Forms.Timer(this.components);
            this.edtStatus = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(696, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Classification - MNIST";
            // 
            // btnLeNet
            // 
            this.btnLeNet.Location = new System.Drawing.Point(12, 74);
            this.btnLeNet.Name = "btnLeNet";
            this.btnLeNet.Size = new System.Drawing.Size(75, 23);
            this.btnLeNet.TabIndex = 2;
            this.btnLeNet.Text = "LeNet";
            this.btnLeNet.UseVisualStyleBackColor = true;
            this.btnLeNet.Click += new System.EventHandler(this.btnLeNet_Click);
            // 
            // btnSiamese
            // 
            this.btnSiamese.Location = new System.Drawing.Point(93, 74);
            this.btnSiamese.Name = "btnSiamese";
            this.btnSiamese.Size = new System.Drawing.Size(75, 23);
            this.btnSiamese.TabIndex = 3;
            this.btnSiamese.Text = "SiameseNet";
            this.btnSiamese.UseVisualStyleBackColor = true;
            this.btnSiamese.Click += new System.EventHandler(this.btnSiamese_Click);
            // 
            // btnTriplet
            // 
            this.btnTriplet.Location = new System.Drawing.Point(174, 74);
            this.btnTriplet.Name = "btnTriplet";
            this.btnTriplet.Size = new System.Drawing.Size(75, 23);
            this.btnTriplet.TabIndex = 4;
            this.btnTriplet.Text = "TripletNet";
            this.btnTriplet.UseVisualStyleBackColor = true;
            this.btnTriplet.Click += new System.EventHandler(this.btnTriplet_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(696, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Recurrent Learning";
            // 
            // btnCharRnn
            // 
            this.btnCharRnn.Location = new System.Drawing.Point(12, 139);
            this.btnCharRnn.Name = "btnCharRnn";
            this.btnCharRnn.Size = new System.Drawing.Size(75, 23);
            this.btnCharRnn.TabIndex = 6;
            this.btnCharRnn.Text = "CharRnn";
            this.btnCharRnn.UseVisualStyleBackColor = true;
            this.btnCharRnn.Click += new System.EventHandler(this.btnCharRnn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(696, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Reinforcement Learning";
            // 
            // btnCartPole
            // 
            this.btnCartPole.Location = new System.Drawing.Point(12, 204);
            this.btnCartPole.Name = "btnCartPole";
            this.btnCartPole.Size = new System.Drawing.Size(95, 23);
            this.btnCartPole.TabIndex = 8;
            this.btnCartPole.Text = "PG - Cart Pole";
            this.btnCartPole.UseVisualStyleBackColor = true;
            this.btnCartPole.Click += new System.EventHandler(this.btnCartPole_Click);
            // 
            // btnAtariPong
            // 
            this.btnAtariPong.Location = new System.Drawing.Point(113, 204);
            this.btnAtariPong.Name = "btnAtariPong";
            this.btnAtariPong.Size = new System.Drawing.Size(95, 23);
            this.btnAtariPong.TabIndex = 9;
            this.btnAtariPong.Text = "PG - Atari Pong";
            this.btnAtariPong.UseVisualStyleBackColor = true;
            this.btnAtariPong.Click += new System.EventHandler(this.btnAtariPong_Click);
            // 
            // btnAtariBreakout
            // 
            this.btnAtariBreakout.Location = new System.Drawing.Point(214, 204);
            this.btnAtariBreakout.Name = "btnAtariBreakout";
            this.btnAtariBreakout.Size = new System.Drawing.Size(121, 23);
            this.btnAtariBreakout.TabIndex = 10;
            this.btnAtariBreakout.Text = "DQN - Atari Breakout";
            this.btnAtariBreakout.UseVisualStyleBackColor = true;
            this.btnAtariBreakout.Click += new System.EventHandler(this.btnAtariBreakout_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(696, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Neural Style Transfer";
            // 
            // btnStyleTransfer
            // 
            this.btnStyleTransfer.Location = new System.Drawing.Point(12, 272);
            this.btnStyleTransfer.Name = "btnStyleTransfer";
            this.btnStyleTransfer.Size = new System.Drawing.Size(95, 23);
            this.btnStyleTransfer.TabIndex = 12;
            this.btnStyleTransfer.Text = "Style Transfer";
            this.btnStyleTransfer.UseVisualStyleBackColor = true;
            this.btnStyleTransfer.Click += new System.EventHandler(this.btnStyleTransfer_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-1, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(696, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Control Tests";
            // 
            // btnONNX
            // 
            this.btnONNX.Location = new System.Drawing.Point(12, 340);
            this.btnONNX.Name = "btnONNX";
            this.btnONNX.Size = new System.Drawing.Size(95, 23);
            this.btnONNX.TabIndex = 14;
            this.btnONNX.Text = "ONNX";
            this.btnONNX.UseVisualStyleBackColor = true;
            this.btnONNX.Click += new System.EventHandler(this.btnONNX_Click);
            // 
            // btnWebCam
            // 
            this.btnWebCam.Location = new System.Drawing.Point(113, 340);
            this.btnWebCam.Name = "btnWebCam";
            this.btnWebCam.Size = new System.Drawing.Size(95, 23);
            this.btnWebCam.TabIndex = 15;
            this.btnWebCam.Text = "WebCam";
            this.btnWebCam.UseVisualStyleBackColor = true;
            this.btnWebCam.Click += new System.EventHandler(this.btnWebCam_Click);
            // 
            // timerUI
            // 
            this.timerUI.Enabled = true;
            this.timerUI.Interval = 250;
            this.timerUI.Tick += new System.EventHandler(this.timerUI_Tick);
            // 
            // edtStatus
            // 
            this.edtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtStatus.BackColor = System.Drawing.Color.Aqua;
            this.edtStatus.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtStatus.Location = new System.Drawing.Point(12, 381);
            this.edtStatus.Multiline = true;
            this.edtStatus.Name = "edtStatus";
            this.edtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.edtStatus.Size = new System.Drawing.Size(671, 252);
            this.edtStatus.TabIndex = 17;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Candara Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(644, 354);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(39, 21);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormMyCaffeSamples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 645);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.edtStatus);
            this.Controls.Add(this.btnTriplet);
            this.Controls.Add(this.btnSiamese);
            this.Controls.Add(this.btnAtariBreakout);
            this.Controls.Add(this.btnAtariPong);
            this.Controls.Add(this.btnCartPole);
            this.Controls.Add(this.btnWebCam);
            this.Controls.Add(this.btnONNX);
            this.Controls.Add(this.btnStyleTransfer);
            this.Controls.Add(this.btnCharRnn);
            this.Controls.Add(this.btnLeNet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMyCaffeSamples";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MyCaffe Samples";
            this.Load += new System.EventHandler(this.FormMyCaffeSamples_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLeNet;
        private System.Windows.Forms.Button btnSiamese;
        private System.Windows.Forms.Button btnTriplet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCharRnn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCartPole;
        private System.Windows.Forms.Button btnAtariPong;
        private System.Windows.Forms.Button btnAtariBreakout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStyleTransfer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnONNX;
        private System.Windows.Forms.Button btnWebCam;
        private System.Windows.Forms.Timer timerUI;
        private System.Windows.Forms.TextBox edtStatus;
        private System.Windows.Forms.Button btnClear;
    }
}