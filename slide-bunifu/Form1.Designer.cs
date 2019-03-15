namespace slide_bunifu
{
    partial class Form1
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
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.bib_cerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel_izquierdo = new System.Windows.Forms.Panel();
            this.bfb_contact = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bib_menu = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1_logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.f2 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bfb_home = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfb_service = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfb_comunity = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfn_blog = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelTransicion = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.LogoTransicion = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bib_cerrar)).BeginInit();
            this.panel_izquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bib_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_logo)).BeginInit();
            this.f2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.header.Controls.Add(this.label2);
            this.header.Controls.Add(this.bib_cerrar);
            this.LogoTransicion.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransicion.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(765, 60);
            this.header.TabIndex = 0;
            // 
            // bib_cerrar
            // 
            this.bib_cerrar.BackColor = System.Drawing.Color.SeaGreen;
            this.LogoTransicion.SetDecoration(this.bib_cerrar, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransicion.SetDecoration(this.bib_cerrar, BunifuAnimatorNS.DecorationType.None);
            this.bib_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("bib_cerrar.Image")));
            this.bib_cerrar.ImageActive = null;
            this.bib_cerrar.Location = new System.Drawing.Point(709, 12);
            this.bib_cerrar.Name = "bib_cerrar";
            this.bib_cerrar.Size = new System.Drawing.Size(44, 37);
            this.bib_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bib_cerrar.TabIndex = 0;
            this.bib_cerrar.TabStop = false;
            this.bib_cerrar.Zoom = 10;
            this.bib_cerrar.Click += new System.EventHandler(this.bib_cerrar_Click);
            // 
            // panel_izquierdo
            // 
            this.panel_izquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel_izquierdo.Controls.Add(this.bfn_blog);
            this.panel_izquierdo.Controls.Add(this.bfb_comunity);
            this.panel_izquierdo.Controls.Add(this.bfb_service);
            this.panel_izquierdo.Controls.Add(this.bfb_home);
            this.panel_izquierdo.Controls.Add(this.bfb_contact);
            this.panel_izquierdo.Controls.Add(this.bib_menu);
            this.panel_izquierdo.Controls.Add(this.pictureBox1_logo);
            this.panel_izquierdo.Controls.Add(this.label1);
            this.LogoTransicion.SetDecoration(this.panel_izquierdo, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransicion.SetDecoration(this.panel_izquierdo, BunifuAnimatorNS.DecorationType.None);
            this.panel_izquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_izquierdo.Location = new System.Drawing.Point(0, 60);
            this.panel_izquierdo.Name = "panel_izquierdo";
            this.panel_izquierdo.Size = new System.Drawing.Size(282, 380);
            this.panel_izquierdo.TabIndex = 1;
            // 
            // bfb_contact
            // 
            this.bfb_contact.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfb_contact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfb_contact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfb_contact.BorderRadius = 0;
            this.bfb_contact.ButtonText = "Contactar";
            this.bfb_contact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransicion.SetDecoration(this.bfb_contact, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransicion.SetDecoration(this.bfb_contact, BunifuAnimatorNS.DecorationType.None);
            this.bfb_contact.DisabledColor = System.Drawing.Color.Gray;
            this.bfb_contact.Iconcolor = System.Drawing.Color.Transparent;
            this.bfb_contact.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfb_contact.Iconimage")));
            this.bfb_contact.Iconimage_right = null;
            this.bfb_contact.Iconimage_right_Selected = null;
            this.bfb_contact.Iconimage_Selected = null;
            this.bfb_contact.IconMarginLeft = 0;
            this.bfb_contact.IconMarginRight = 0;
            this.bfb_contact.IconRightVisible = true;
            this.bfb_contact.IconRightZoom = 0D;
            this.bfb_contact.IconVisible = true;
            this.bfb_contact.IconZoom = 90D;
            this.bfb_contact.IsTab = false;
            this.bfb_contact.Location = new System.Drawing.Point(0, 95);
            this.bfb_contact.Name = "bfb_contact";
            this.bfb_contact.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfb_contact.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bfb_contact.OnHoverTextColor = System.Drawing.Color.White;
            this.bfb_contact.selected = false;
            this.bfb_contact.Size = new System.Drawing.Size(282, 48);
            this.bfb_contact.TabIndex = 3;
            this.bfb_contact.Text = "Contactar";
            this.bfb_contact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfb_contact.Textcolor = System.Drawing.Color.White;
            this.bfb_contact.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfb_contact.Click += new System.EventHandler(this.bfb_contact_Click);
            // 
            // bib_menu
            // 
            this.bib_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bib_menu.BackColor = System.Drawing.Color.SeaGreen;
            this.bib_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransicion.SetDecoration(this.bib_menu, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransicion.SetDecoration(this.bib_menu, BunifuAnimatorNS.DecorationType.None);
            this.bib_menu.Image = ((System.Drawing.Image)(resources.GetObject("bib_menu.Image")));
            this.bib_menu.ImageActive = null;
            this.bib_menu.Location = new System.Drawing.Point(227, 36);
            this.bib_menu.Name = "bib_menu";
            this.bib_menu.Size = new System.Drawing.Size(55, 37);
            this.bib_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bib_menu.TabIndex = 2;
            this.bib_menu.TabStop = false;
            this.bib_menu.Zoom = 10;
            this.bib_menu.Click += new System.EventHandler(this.bib_menu_Click);
            // 
            // pictureBox1_logo
            // 
            this.PanelTransicion.SetDecoration(this.pictureBox1_logo, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransicion.SetDecoration(this.pictureBox1_logo, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1_logo.Image")));
            this.pictureBox1_logo.Location = new System.Drawing.Point(8, 36);
            this.pictureBox1_logo.Name = "pictureBox1_logo";
            this.pictureBox1_logo.Size = new System.Drawing.Size(63, 37);
            this.pictureBox1_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1_logo.TabIndex = 1;
            this.pictureBox1_logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.PanelTransicion.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransicion.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "SARAH SOLUTION";
            // 
            // f2
            // 
            this.f2.BackColor = System.Drawing.Color.Navy;
            this.f2.Controls.Add(this.pictureBox1);
            this.f2.Controls.Add(this.label4);
            this.f2.Controls.Add(this.label3);
            this.LogoTransicion.SetDecoration(this.f2, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransicion.SetDecoration(this.f2, BunifuAnimatorNS.DecorationType.None);
            this.f2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.f2.Location = new System.Drawing.Point(282, 60);
            this.f2.Name = "f2";
            this.f2.Size = new System.Drawing.Size(483, 380);
            this.f2.TabIndex = 2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bfb_home
            // 
            this.bfb_home.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bfb_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bfb_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfb_home.BorderRadius = 0;
            this.bfb_home.ButtonText = "Home";
            this.bfb_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransicion.SetDecoration(this.bfb_home, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransicion.SetDecoration(this.bfb_home, BunifuAnimatorNS.DecorationType.None);
            this.bfb_home.DisabledColor = System.Drawing.Color.Gray;
            this.bfb_home.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfb_home.Iconcolor = System.Drawing.Color.Transparent;
            this.bfb_home.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfb_home.Iconimage")));
            this.bfb_home.Iconimage_right = null;
            this.bfb_home.Iconimage_right_Selected = null;
            this.bfb_home.Iconimage_Selected = null;
            this.bfb_home.IconMarginLeft = 0;
            this.bfb_home.IconMarginRight = 0;
            this.bfb_home.IconRightVisible = true;
            this.bfb_home.IconRightZoom = 0D;
            this.bfb_home.IconVisible = true;
            this.bfb_home.IconZoom = 90D;
            this.bfb_home.IsTab = false;
            this.bfb_home.Location = new System.Drawing.Point(0, 141);
            this.bfb_home.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bfb_home.Name = "bfb_home";
            this.bfb_home.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bfb_home.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bfb_home.OnHoverTextColor = System.Drawing.Color.White;
            this.bfb_home.selected = false;
            this.bfb_home.Size = new System.Drawing.Size(282, 48);
            this.bfb_home.TabIndex = 4;
            this.bfb_home.Text = "Home";
            this.bfb_home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfb_home.Textcolor = System.Drawing.Color.White;
            this.bfb_home.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfb_home.Click += new System.EventHandler(this.bfb_home_Click);
            // 
            // bfb_service
            // 
            this.bfb_service.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfb_service.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bfb_service.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfb_service.BorderRadius = 0;
            this.bfb_service.ButtonText = "Servicios";
            this.bfb_service.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransicion.SetDecoration(this.bfb_service, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransicion.SetDecoration(this.bfb_service, BunifuAnimatorNS.DecorationType.None);
            this.bfb_service.DisabledColor = System.Drawing.Color.Gray;
            this.bfb_service.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfb_service.Iconcolor = System.Drawing.Color.Transparent;
            this.bfb_service.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfb_service.Iconimage")));
            this.bfb_service.Iconimage_right = null;
            this.bfb_service.Iconimage_right_Selected = null;
            this.bfb_service.Iconimage_Selected = null;
            this.bfb_service.IconMarginLeft = 0;
            this.bfb_service.IconMarginRight = 0;
            this.bfb_service.IconRightVisible = true;
            this.bfb_service.IconRightZoom = 0D;
            this.bfb_service.IconVisible = true;
            this.bfb_service.IconZoom = 90D;
            this.bfb_service.IsTab = false;
            this.bfb_service.Location = new System.Drawing.Point(0, 188);
            this.bfb_service.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bfb_service.Name = "bfb_service";
            this.bfb_service.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bfb_service.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bfb_service.OnHoverTextColor = System.Drawing.Color.White;
            this.bfb_service.selected = false;
            this.bfb_service.Size = new System.Drawing.Size(282, 48);
            this.bfb_service.TabIndex = 5;
            this.bfb_service.Text = "Servicios";
            this.bfb_service.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfb_service.Textcolor = System.Drawing.Color.White;
            this.bfb_service.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfb_service.Click += new System.EventHandler(this.bft_service_Click);
            // 
            // bfb_comunity
            // 
            this.bfb_comunity.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfb_comunity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bfb_comunity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfb_comunity.BorderRadius = 0;
            this.bfb_comunity.ButtonText = "Comunidad";
            this.bfb_comunity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransicion.SetDecoration(this.bfb_comunity, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransicion.SetDecoration(this.bfb_comunity, BunifuAnimatorNS.DecorationType.None);
            this.bfb_comunity.DisabledColor = System.Drawing.Color.Gray;
            this.bfb_comunity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfb_comunity.Iconcolor = System.Drawing.Color.Transparent;
            this.bfb_comunity.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfb_comunity.Iconimage")));
            this.bfb_comunity.Iconimage_right = null;
            this.bfb_comunity.Iconimage_right_Selected = null;
            this.bfb_comunity.Iconimage_Selected = null;
            this.bfb_comunity.IconMarginLeft = 0;
            this.bfb_comunity.IconMarginRight = 0;
            this.bfb_comunity.IconRightVisible = true;
            this.bfb_comunity.IconRightZoom = 0D;
            this.bfb_comunity.IconVisible = true;
            this.bfb_comunity.IconZoom = 90D;
            this.bfb_comunity.IsTab = false;
            this.bfb_comunity.Location = new System.Drawing.Point(0, 235);
            this.bfb_comunity.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bfb_comunity.Name = "bfb_comunity";
            this.bfb_comunity.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bfb_comunity.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bfb_comunity.OnHoverTextColor = System.Drawing.Color.White;
            this.bfb_comunity.selected = false;
            this.bfb_comunity.Size = new System.Drawing.Size(282, 48);
            this.bfb_comunity.TabIndex = 6;
            this.bfb_comunity.Text = "Comunidad";
            this.bfb_comunity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfb_comunity.Textcolor = System.Drawing.Color.White;
            this.bfb_comunity.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfb_comunity.Click += new System.EventHandler(this.bfb_comunity_Click);
            // 
            // bfn_blog
            // 
            this.bfn_blog.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bfn_blog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bfn_blog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfn_blog.BorderRadius = 0;
            this.bfn_blog.ButtonText = "Blog";
            this.bfn_blog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoTransicion.SetDecoration(this.bfn_blog, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransicion.SetDecoration(this.bfn_blog, BunifuAnimatorNS.DecorationType.None);
            this.bfn_blog.DisabledColor = System.Drawing.Color.Gray;
            this.bfn_blog.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfn_blog.Iconcolor = System.Drawing.Color.Transparent;
            this.bfn_blog.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfn_blog.Iconimage")));
            this.bfn_blog.Iconimage_right = null;
            this.bfn_blog.Iconimage_right_Selected = null;
            this.bfn_blog.Iconimage_Selected = null;
            this.bfn_blog.IconMarginLeft = 0;
            this.bfn_blog.IconMarginRight = 0;
            this.bfn_blog.IconRightVisible = true;
            this.bfn_blog.IconRightZoom = 0D;
            this.bfn_blog.IconVisible = true;
            this.bfn_blog.IconZoom = 90D;
            this.bfn_blog.IsTab = false;
            this.bfn_blog.Location = new System.Drawing.Point(0, 282);
            this.bfn_blog.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bfn_blog.Name = "bfn_blog";
            this.bfn_blog.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bfn_blog.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bfn_blog.OnHoverTextColor = System.Drawing.Color.White;
            this.bfn_blog.selected = false;
            this.bfn_blog.Size = new System.Drawing.Size(282, 48);
            this.bfn_blog.TabIndex = 7;
            this.bfn_blog.Text = "Blog";
            this.bfn_blog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfn_blog.Textcolor = System.Drawing.Color.White;
            this.bfn_blog.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfn_blog.Click += new System.EventHandler(this.bfn_blog_Click);
            // 
            // PanelTransicion
            // 
            this.PanelTransicion.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.PanelTransicion.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 1;
            animation4.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 2F;
            animation4.TransparencyCoeff = 0F;
            this.PanelTransicion.DefaultAnimation = animation4;
            // 
            // LogoTransicion
            // 
            this.LogoTransicion.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.LogoTransicion.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 20;
            animation3.Padding = new System.Windows.Forms.Padding(30);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.LogoTransicion.DefaultAnimation = animation3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.PanelTransicion.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransicion.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Herramienta Administrativa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.PanelTransicion.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransicion.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(346, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "by Sorftweb.com";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.PanelTransicion.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransicion.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(444, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soluciones Informaticas contruidas a la medida.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.PanelTransicion.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransicion.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::slide_bunifu.Properties.Resources.feedly1;
            this.pictureBox1.Location = new System.Drawing.Point(83, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 440);
            this.Controls.Add(this.f2);
            this.Controls.Add(this.panel_izquierdo);
            this.Controls.Add(this.header);
            this.PanelTransicion.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransicion.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bib_cerrar)).EndInit();
            this.panel_izquierdo.ResumeLayout(false);
            this.panel_izquierdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bib_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_logo)).EndInit();
            this.f2.ResumeLayout(false);
            this.f2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel f2;
        private System.Windows.Forms.Panel panel_izquierdo;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton bib_cerrar;
        private System.Windows.Forms.PictureBox pictureBox1_logo;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bib_menu;
        private Bunifu.Framework.UI.BunifuFlatButton bfb_contact;
        private Bunifu.Framework.UI.BunifuFlatButton bfn_blog;
        private Bunifu.Framework.UI.BunifuFlatButton bfb_comunity;
        private Bunifu.Framework.UI.BunifuFlatButton bfb_service;
        private Bunifu.Framework.UI.BunifuFlatButton bfb_home;
        private BunifuAnimatorNS.BunifuTransition LogoTransicion;
        private BunifuAnimatorNS.BunifuTransition PanelTransicion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

