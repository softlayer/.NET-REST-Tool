namespace SLAPI_REST_CS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtEndPoint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApiUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPostvars = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.rdoGet = new System.Windows.Forms.RadioButton();
            this.rdoPost = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.rdoObjectMask = new System.Windows.Forms.RadioButton();
            this.btnPut = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbDropDown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtEndPoint
            // 
            this.txtEndPoint.Location = new System.Drawing.Point(77, 132);
            this.txtEndPoint.Name = "txtEndPoint";
            this.txtEndPoint.Size = new System.Drawing.Size(501, 20);
            this.txtEndPoint.TabIndex = 4;
            this.txtEndPoint.Text = "SoftLayer_Account/OpenTickets.xml";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "End Point:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "API Url:";
            // 
            // txtApiUrl
            // 
            this.txtApiUrl.Location = new System.Drawing.Point(77, 93);
            this.txtApiUrl.Name = "txtApiUrl";
            this.txtApiUrl.Size = new System.Drawing.Size(504, 20);
            this.txtApiUrl.TabIndex = 3;
            this.txtApiUrl.Text = "https://api.softlayer.com/rest/v3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Post Vars:";
            // 
            // txtPostvars
            // 
            this.txtPostvars.Location = new System.Drawing.Point(74, 202);
            this.txtPostvars.Multiline = true;
            this.txtPostvars.Name = "txtPostvars";
            this.txtPostvars.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPostvars.Size = new System.Drawing.Size(504, 167);
            this.txtPostvars.TabIndex = 5;
            this.txtPostvars.WordWrap = false;
            this.txtPostvars.TextChanged += new System.EventHandler(this.txtPostvars_TextChanged);
            this.txtPostvars.Leave += new System.EventHandler(this.txtPostvars_Leave);
            // 
            // btnPost
            // 
            this.btnPost.Enabled = false;
            this.btnPost.Location = new System.Drawing.Point(314, 394);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(84, 28);
            this.btnPost.TabIndex = 6;
            this.btnPost.Text = "Http Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(74, 437);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResponse.Size = new System.Drawing.Size(504, 167);
            this.txtResponse.TabIndex = 7;
            this.txtResponse.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Response:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "API Key:";
            // 
            // txtApiKey
            // 
            this.txtApiKey.Location = new System.Drawing.Point(77, 55);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(504, 20);
            this.txtApiKey.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(77, 15);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(504, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(224, 394);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(84, 28);
            this.btnGet.TabIndex = 13;
            this.btnGet.Text = "Http Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // rdoGet
            // 
            this.rdoGet.AutoSize = true;
            this.rdoGet.Checked = true;
            this.rdoGet.Location = new System.Drawing.Point(77, 169);
            this.rdoGet.Name = "rdoGet";
            this.rdoGet.Size = new System.Drawing.Size(140, 17);
            this.rdoGet.TabIndex = 17;
            this.rdoGet.TabStop = true;
            this.rdoGet.Text = "Recently Closed Tickets";
            this.rdoGet.UseVisualStyleBackColor = true;
            this.rdoGet.CheckedChanged += new System.EventHandler(this.rdoGet_CheckedChanged);
            // 
            // rdoPost
            // 
            this.rdoPost.AutoSize = true;
            this.rdoPost.Location = new System.Drawing.Point(501, 171);
            this.rdoPost.Name = "rdoPost";
            this.rdoPost.Size = new System.Drawing.Size(80, 17);
            this.rdoPost.TabIndex = 18;
            this.rdoPost.Text = "New Ticket";
            this.rdoPost.UseVisualStyleBackColor = true;
            this.rdoPost.CheckedChanged += new System.EventHandler(this.rdoPost_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Examples:";
            // 
            // rdoObjectMask
            // 
            this.rdoObjectMask.AutoSize = true;
            this.rdoObjectMask.Location = new System.Drawing.Point(293, 171);
            this.rdoObjectMask.Name = "rdoObjectMask";
            this.rdoObjectMask.Size = new System.Drawing.Size(121, 17);
            this.rdoObjectMask.TabIndex = 20;
            this.rdoObjectMask.Text = "Servers On Account";
            this.rdoObjectMask.UseVisualStyleBackColor = true;
            this.rdoObjectMask.CheckedChanged += new System.EventHandler(this.rdoObjectMask_CheckedChanged);
            // 
            // btnPut
            // 
            this.btnPut.Enabled = false;
            this.btnPut.Location = new System.Drawing.Point(404, 394);
            this.btnPut.Name = "btnPut";
            this.btnPut.Size = new System.Drawing.Size(84, 28);
            this.btnPut.TabIndex = 21;
            this.btnPut.Text = "Http Put";
            this.btnPut.UseVisualStyleBackColor = true;
            this.btnPut.Click += new System.EventHandler(this.btnPut_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(494, 394);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 28);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Http Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbDropDown
            // 
            this.cmbDropDown.FormattingEnabled = true;
            this.cmbDropDown.Items.AddRange(new object[] {
            "XML Mode",
            "JSON Mode"});
            this.cmbDropDown.Location = new System.Drawing.Point(74, 399);
            this.cmbDropDown.Name = "cmbDropDown";
            this.cmbDropDown.Size = new System.Drawing.Size(110, 21);
            this.cmbDropDown.TabIndex = 23;
            this.cmbDropDown.Text = "XML Mode";
            this.cmbDropDown.SelectedIndexChanged += new System.EventHandler(this.cmbDropDown_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 638);
            this.Controls.Add(this.cmbDropDown);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPut);
            this.Controls.Add(this.rdoObjectMask);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rdoPost);
            this.Controls.Add(this.rdoGet);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtApiKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPostvars);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApiUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEndPoint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "SLAPI Example of REST Interface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEndPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApiUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPostvars;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApiKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.RadioButton rdoGet;
        private System.Windows.Forms.RadioButton rdoPost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdoObjectMask;
        private System.Windows.Forms.Button btnPut;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbDropDown;
    }
}

