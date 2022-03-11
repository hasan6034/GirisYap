namespace GirisYap
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtKadi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSifre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnGirisYap = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUye = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblGiris = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnUyeOl = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtKayıtSifre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSoyad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAd = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(451, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtKadi
            // 
            this.txtKadi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKadi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtKadi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtKadi.HintForeColor = System.Drawing.Color.White;
            this.txtKadi.HintText = "";
            this.txtKadi.isPassword = false;
            this.txtKadi.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtKadi.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.txtKadi.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txtKadi.LineThickness = 3;
            this.txtKadi.Location = new System.Drawing.Point(93, 24);
            this.txtKadi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKadi.Name = "txtKadi";
            this.txtKadi.Size = new System.Drawing.Size(297, 33);
            this.txtKadi.TabIndex = 1;
            this.txtKadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSifre
            // 
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSifre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSifre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSifre.HintForeColor = System.Drawing.Color.White;
            this.txtSifre.HintText = "";
            this.txtSifre.isPassword = false;
            this.txtSifre.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtSifre.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.txtSifre.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txtSifre.LineThickness = 3;
            this.txtSifre.Location = new System.Drawing.Point(93, 95);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(297, 33);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.btnGirisYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGirisYap.BorderRadius = 0;
            this.btnGirisYap.ButtonText = "Giriş Yap";
            this.btnGirisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGirisYap.DisabledColor = System.Drawing.Color.Gray;
            this.btnGirisYap.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGirisYap.Iconimage = null;
            this.btnGirisYap.Iconimage_right = null;
            this.btnGirisYap.Iconimage_right_Selected = null;
            this.btnGirisYap.Iconimage_Selected = null;
            this.btnGirisYap.IconMarginLeft = 0;
            this.btnGirisYap.IconMarginRight = 0;
            this.btnGirisYap.IconRightVisible = true;
            this.btnGirisYap.IconRightZoom = 0D;
            this.btnGirisYap.IconVisible = true;
            this.btnGirisYap.IconZoom = 90D;
            this.btnGirisYap.IsTab = false;
            this.btnGirisYap.Location = new System.Drawing.Point(93, 176);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.btnGirisYap.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnGirisYap.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGirisYap.selected = false;
            this.btnGirisYap.Size = new System.Drawing.Size(241, 48);
            this.btnGirisYap.TabIndex = 3;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGirisYap.Textcolor = System.Drawing.Color.White;
            this.btnGirisYap.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(3, 115);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(28, 13);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "Şifre";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtKadi);
            this.panel1.Controls.Add(this.lblUye);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.btnGirisYap);
            this.panel1.Location = new System.Drawing.Point(31, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 283);
            this.panel1.TabIndex = 5;
            // 
            // lblUye
            // 
            this.lblUye.AutoSize = true;
            this.lblUye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUye.ForeColor = System.Drawing.Color.White;
            this.lblUye.Location = new System.Drawing.Point(141, 241);
            this.lblUye.Name = "lblUye";
            this.lblUye.Size = new System.Drawing.Size(140, 13);
            this.lblUye.TabIndex = 4;
            this.lblUye.Text = "Üye olmak için lütfen tıklayın";
            this.lblUye.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 53);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(64, 13);
            this.bunifuCustomLabel1.TabIndex = 4;
            this.bunifuCustomLabel1.Text = "Kullanıcı Adı";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblGiris);
            this.panel2.Controls.Add(this.btnUyeOl);
            this.panel2.Controls.Add(this.txtKayıtSifre);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtSoyad);
            this.panel2.Controls.Add(this.txtAd);
            this.panel2.Controls.Add(this.bunifuCustomLabel7);
            this.panel2.Controls.Add(this.bunifuCustomLabel6);
            this.panel2.Controls.Add(this.bunifuCustomLabel5);
            this.panel2.Controls.Add(this.bunifuCustomLabel4);
            this.panel2.Location = new System.Drawing.Point(28, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 366);
            this.panel2.TabIndex = 6;
            this.panel2.Visible = false;
            // 
            // lblGiris
            // 
            this.lblGiris.AutoSize = true;
            this.lblGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGiris.ForeColor = System.Drawing.Color.White;
            this.lblGiris.Location = new System.Drawing.Point(114, 329);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(150, 13);
            this.lblGiris.TabIndex = 10;
            this.lblGiris.Text = "Giriş yapmak için lütfen tıklayın";
            this.lblGiris.Click += new System.EventHandler(this.lblGiris_Click);
            // 
            // btnUyeOl
            // 
            this.btnUyeOl.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUyeOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.btnUyeOl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUyeOl.BorderRadius = 0;
            this.btnUyeOl.ButtonText = "Üye Ol";
            this.btnUyeOl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUyeOl.DisabledColor = System.Drawing.Color.Gray;
            this.btnUyeOl.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUyeOl.Iconimage = null;
            this.btnUyeOl.Iconimage_right = null;
            this.btnUyeOl.Iconimage_right_Selected = null;
            this.btnUyeOl.Iconimage_Selected = null;
            this.btnUyeOl.IconMarginLeft = 0;
            this.btnUyeOl.IconMarginRight = 0;
            this.btnUyeOl.IconRightVisible = true;
            this.btnUyeOl.IconRightZoom = 0D;
            this.btnUyeOl.IconVisible = true;
            this.btnUyeOl.IconZoom = 90D;
            this.btnUyeOl.IsTab = false;
            this.btnUyeOl.Location = new System.Drawing.Point(56, 256);
            this.btnUyeOl.Name = "btnUyeOl";
            this.btnUyeOl.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.btnUyeOl.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnUyeOl.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUyeOl.selected = false;
            this.btnUyeOl.Size = new System.Drawing.Size(241, 48);
            this.btnUyeOl.TabIndex = 9;
            this.btnUyeOl.Text = "Üye Ol";
            this.btnUyeOl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUyeOl.Textcolor = System.Drawing.Color.White;
            this.btnUyeOl.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUyeOl.Click += new System.EventHandler(this.btnUyeOl_Click);
            // 
            // txtKayıtSifre
            // 
            this.txtKayıtSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKayıtSifre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtKayıtSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKayıtSifre.HintForeColor = System.Drawing.Color.White;
            this.txtKayıtSifre.HintText = "";
            this.txtKayıtSifre.isPassword = false;
            this.txtKayıtSifre.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtKayıtSifre.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.txtKayıtSifre.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txtKayıtSifre.LineThickness = 3;
            this.txtKayıtSifre.Location = new System.Drawing.Point(56, 194);
            this.txtKayıtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtKayıtSifre.Name = "txtKayıtSifre";
            this.txtKayıtSifre.Size = new System.Drawing.Size(297, 33);
            this.txtKayıtSifre.TabIndex = 8;
            this.txtKayıtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.HintForeColor = System.Drawing.Color.White;
            this.txtEmail.HintText = "";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtEmail.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txtEmail.LineThickness = 3;
            this.txtEmail.Location = new System.Drawing.Point(56, 147);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(297, 33);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoyad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoyad.HintForeColor = System.Drawing.Color.White;
            this.txtSoyad.HintText = "";
            this.txtSoyad.isPassword = false;
            this.txtSoyad.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtSoyad.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.txtSoyad.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txtSoyad.LineThickness = 3;
            this.txtSoyad.Location = new System.Drawing.Point(56, 95);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(297, 33);
            this.txtSoyad.TabIndex = 6;
            this.txtSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtAd
            // 
            this.txtAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAd.HintForeColor = System.Drawing.Color.White;
            this.txtAd.HintText = "";
            this.txtAd.isPassword = false;
            this.txtAd.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtAd.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.txtAd.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.txtAd.LineThickness = 3;
            this.txtAd.Location = new System.Drawing.Point(56, 33);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(297, 33);
            this.txtAd.TabIndex = 5;
            this.txtAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(3, 214);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(28, 13);
            this.bunifuCustomLabel7.TabIndex = 4;
            this.bunifuCustomLabel7.Text = "Şifre";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(3, 167);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(35, 13);
            this.bunifuCustomLabel6.TabIndex = 4;
            this.bunifuCustomLabel6.Text = "E-mail";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(3, 115);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(37, 13);
            this.bunifuCustomLabel5.TabIndex = 4;
            this.bunifuCustomLabel5.Text = "Soyad";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(3, 53);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(23, 13);
            this.bunifuCustomLabel4.TabIndex = 4;
            this.bunifuCustomLabel4.Text = "Ad ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(413, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(408, 471);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(370, 471);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(293, 471);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(332, 471);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(486, 535);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtKadi;
        private Bunifu.Framework.UI.BunifuFlatButton btnGirisYap;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSifre;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUye;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSoyad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAd;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGiris;
        private Bunifu.Framework.UI.BunifuFlatButton btnUyeOl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtKayıtSifre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

