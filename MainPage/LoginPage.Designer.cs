namespace CProject.LoginPage
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btn_login = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_reset = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.cmb_user = new System.Windows.Forms.ComboBox();
            this.txt_password = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txt_username = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuPanel1.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(184, 372);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Variable Text", 20.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(45, 160);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(83, 37);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "LOGIN";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel1.Click += new System.EventHandler(this.bunifuLabel1_Click);
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.btn_login);
            this.bunifuPanel2.Controls.Add(this.btn_reset);
            this.bunifuPanel2.Controls.Add(this.cmb_user);
            this.bunifuPanel2.Controls.Add(this.txt_password);
            this.bunifuPanel2.Controls.Add(this.txt_username);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel2.Location = new System.Drawing.Point(184, 0);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(320, 372);
            this.bunifuPanel2.TabIndex = 1;
            // 
            // btn_login
            // 
            this.btn_login.AllowAnimations = true;
            this.btn_login.AllowMouseEffects = true;
            this.btn_login.AllowToggling = false;
            this.btn_login.AnimationSpeed = 200;
            this.btn_login.AutoGenerateColors = false;
            this.btn_login.AutoRoundBorders = false;
            this.btn_login.AutoSizeLeftIcon = true;
            this.btn_login.AutoSizeRightIcon = true;
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.BackColor1 = System.Drawing.Color.DarkCyan;
            this.btn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login.BackgroundImage")));
            this.btn_login.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_login.ButtonText = "Login";
            this.btn_login.ButtonTextMarginLeft = 0;
            this.btn_login.ColorContrastOnClick = 45;
            this.btn_login.ColorContrastOnHover = 45;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_login.CustomizableEdges = borderEdges1;
            this.btn_login.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_login.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_login.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_login.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_login.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_login.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_login.IconMarginLeft = 11;
            this.btn_login.IconPadding = 10;
            this.btn_login.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_login.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_login.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_login.IconSize = 25;
            this.btn_login.IdleBorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_login.IdleBorderRadius = 25;
            this.btn_login.IdleBorderThickness = 1;
            this.btn_login.IdleFillColor = System.Drawing.Color.DarkCyan;
            this.btn_login.IdleIconLeftImage = null;
            this.btn_login.IdleIconRightImage = null;
            this.btn_login.IndicateFocus = false;
            this.btn_login.Location = new System.Drawing.Point(164, 293);
            this.btn_login.Name = "btn_login";
            this.btn_login.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_login.OnDisabledState.BorderRadius = 25;
            this.btn_login.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_login.OnDisabledState.BorderThickness = 1;
            this.btn_login.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_login.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_login.OnDisabledState.IconLeftImage = null;
            this.btn_login.OnDisabledState.IconRightImage = null;
            this.btn_login.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_login.onHoverState.BorderRadius = 25;
            this.btn_login.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_login.onHoverState.BorderThickness = 1;
            this.btn_login.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_login.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_login.onHoverState.IconLeftImage = null;
            this.btn_login.onHoverState.IconRightImage = null;
            this.btn_login.OnIdleState.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_login.OnIdleState.BorderRadius = 25;
            this.btn_login.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_login.OnIdleState.BorderThickness = 1;
            this.btn_login.OnIdleState.FillColor = System.Drawing.Color.DarkCyan;
            this.btn_login.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_login.OnIdleState.IconLeftImage = null;
            this.btn_login.OnIdleState.IconRightImage = null;
            this.btn_login.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_login.OnPressedState.BorderRadius = 25;
            this.btn_login.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_login.OnPressedState.BorderThickness = 1;
            this.btn_login.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_login.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_login.OnPressedState.IconLeftImage = null;
            this.btn_login.OnPressedState.IconRightImage = null;
            this.btn_login.Size = new System.Drawing.Size(79, 30);
            this.btn_login.TabIndex = 4;
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_login.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_login.TextMarginLeft = 0;
            this.btn_login.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_login.UseDefaultRadiusAndThickness = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.AllowAnimations = true;
            this.btn_reset.AllowMouseEffects = true;
            this.btn_reset.AllowToggling = false;
            this.btn_reset.AnimationSpeed = 200;
            this.btn_reset.AutoGenerateColors = false;
            this.btn_reset.AutoRoundBorders = false;
            this.btn_reset.AutoSizeLeftIcon = true;
            this.btn_reset.AutoSizeRightIcon = true;
            this.btn_reset.BackColor = System.Drawing.Color.Transparent;
            this.btn_reset.BackColor1 = System.Drawing.Color.DarkCyan;
            this.btn_reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_reset.BackgroundImage")));
            this.btn_reset.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btn_reset.ButtonText = "Reset";
            this.btn_reset.ButtonTextMarginLeft = 0;
            this.btn_reset.ColorContrastOnClick = 45;
            this.btn_reset.ColorContrastOnHover = 45;
            this.btn_reset.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_reset.CustomizableEdges = borderEdges2;
            this.btn_reset.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_reset.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_reset.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_reset.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_reset.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_reset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_reset.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_reset.IconMarginLeft = 11;
            this.btn_reset.IconPadding = 10;
            this.btn_reset.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_reset.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_reset.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_reset.IconSize = 25;
            this.btn_reset.IdleBorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_reset.IdleBorderRadius = 25;
            this.btn_reset.IdleBorderThickness = 1;
            this.btn_reset.IdleFillColor = System.Drawing.Color.DarkCyan;
            this.btn_reset.IdleIconLeftImage = null;
            this.btn_reset.IdleIconRightImage = null;
            this.btn_reset.IndicateFocus = false;
            this.btn_reset.Location = new System.Drawing.Point(63, 293);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_reset.OnDisabledState.BorderRadius = 25;
            this.btn_reset.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_reset.OnDisabledState.BorderThickness = 1;
            this.btn_reset.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_reset.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_reset.OnDisabledState.IconLeftImage = null;
            this.btn_reset.OnDisabledState.IconRightImage = null;
            this.btn_reset.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_reset.onHoverState.BorderRadius = 25;
            this.btn_reset.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_reset.onHoverState.BorderThickness = 1;
            this.btn_reset.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_reset.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_reset.onHoverState.IconLeftImage = null;
            this.btn_reset.onHoverState.IconRightImage = null;
            this.btn_reset.OnIdleState.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_reset.OnIdleState.BorderRadius = 25;
            this.btn_reset.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btn_reset.OnIdleState.BorderThickness = 1;
            this.btn_reset.OnIdleState.FillColor = System.Drawing.Color.DarkCyan;
            this.btn_reset.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_reset.OnIdleState.IconLeftImage = null;
            this.btn_reset.OnIdleState.IconRightImage = null;
            this.btn_reset.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_reset.OnPressedState.BorderRadius = 25;
            this.btn_reset.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_reset.OnPressedState.BorderThickness = 1;
            this.btn_reset.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_reset.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_reset.OnPressedState.IconLeftImage = null;
            this.btn_reset.OnPressedState.IconRightImage = null;
            this.btn_reset.Size = new System.Drawing.Size(79, 30);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_reset.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_reset.TextMarginLeft = 0;
            this.btn_reset.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_reset.UseDefaultRadiusAndThickness = true;
            // 
            // cmb_user
            // 
            this.cmb_user.FormattingEnabled = true;
            this.cmb_user.Items.AddRange(new object[] {
            "Admin",
            "Doctor",
            "Receptionist"});
            this.cmb_user.Location = new System.Drawing.Point(101, 102);
            this.cmb_user.Name = "cmb_user";
            this.cmb_user.Size = new System.Drawing.Size(121, 21);
            this.cmb_user.TabIndex = 2;
            // 
            // txt_password
            // 
            this.txt_password.AcceptsReturn = false;
            this.txt_password.AcceptsTab = false;
            this.txt_password.AnimationSpeed = 200;
            this.txt_password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_password.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_password.BackColor = System.Drawing.Color.Transparent;
            this.txt_password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_password.BackgroundImage")));
            this.txt_password.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_password.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_password.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_password.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_password.BorderRadius = 1;
            this.txt_password.BorderThickness = 1;
            this.txt_password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_password.DefaultText = "";
            this.txt_password.FillColor = System.Drawing.Color.White;
            this.txt_password.HideSelection = true;
            this.txt_password.IconLeft = null;
            this.txt_password.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.IconPadding = 10;
            this.txt_password.IconRight = null;
            this.txt_password.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.Lines = new string[0];
            this.txt_password.Location = new System.Drawing.Point(28, 219);
            this.txt_password.MaxLength = 32767;
            this.txt_password.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_password.Modified = false;
            this.txt_password.Multiline = false;
            this.txt_password.Name = "txt_password";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_password.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_password.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_password.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_password.OnIdleState = stateProperties4;
            this.txt_password.Padding = new System.Windows.Forms.Padding(3);
            this.txt_password.PasswordChar = '●';
            this.txt_password.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_password.PlaceholderText = "Enter text";
            this.txt_password.ReadOnly = false;
            this.txt_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_password.SelectedText = "";
            this.txt_password.SelectionLength = 0;
            this.txt_password.SelectionStart = 0;
            this.txt_password.ShortcutsEnabled = true;
            this.txt_password.Size = new System.Drawing.Size(260, 37);
            this.txt_password.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_password.TabIndex = 1;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_password.TextMarginBottom = 0;
            this.txt_password.TextMarginLeft = 3;
            this.txt_password.TextMarginTop = 0;
            this.txt_password.TextPlaceholder = "Enter text";
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.WordWrap = true;
            // 
            // txt_username
            // 
            this.txt_username.AcceptsReturn = false;
            this.txt_username.AcceptsTab = false;
            this.txt_username.AnimationSpeed = 200;
            this.txt_username.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_username.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_username.BackColor = System.Drawing.Color.Transparent;
            this.txt_username.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_username.BackgroundImage")));
            this.txt_username.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_username.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_username.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_username.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_username.BorderRadius = 1;
            this.txt_username.BorderThickness = 1;
            this.txt_username.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_username.DefaultText = "";
            this.txt_username.FillColor = System.Drawing.Color.White;
            this.txt_username.HideSelection = true;
            this.txt_username.IconLeft = null;
            this.txt_username.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.IconPadding = 10;
            this.txt_username.IconRight = null;
            this.txt_username.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.Lines = new string[0];
            this.txt_username.Location = new System.Drawing.Point(28, 160);
            this.txt_username.MaxLength = 32767;
            this.txt_username.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_username.Modified = false;
            this.txt_username.Multiline = false;
            this.txt_username.Name = "txt_username";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_username.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_username.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_username.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_username.OnIdleState = stateProperties8;
            this.txt_username.Padding = new System.Windows.Forms.Padding(3);
            this.txt_username.PasswordChar = '\0';
            this.txt_username.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_username.PlaceholderText = "Enter Username";
            this.txt_username.ReadOnly = false;
            this.txt_username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_username.SelectedText = "";
            this.txt_username.SelectionLength = 0;
            this.txt_username.SelectionStart = 0;
            this.txt_username.ShortcutsEnabled = true;
            this.txt_username.Size = new System.Drawing.Size(260, 37);
            this.txt_username.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_username.TabIndex = 0;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_username.TextMarginBottom = 0;
            this.txt_username.TextMarginLeft = 3;
            this.txt_username.TextMarginTop = 0;
            this.txt_username.TextPlaceholder = "Enter Username";
            this.txt_username.UseSystemPasswordChar = false;
            this.txt_username.WordWrap = true;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 372);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.bunifuPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private System.Windows.Forms.ComboBox cmb_user;
        private Bunifu.UI.WinForms.BunifuTextBox txt_password;
        private Bunifu.UI.WinForms.BunifuTextBox txt_username;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_login;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_reset;
    }
}