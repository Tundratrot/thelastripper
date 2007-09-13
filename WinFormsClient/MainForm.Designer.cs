﻿/*
 * Created by SharpDevelop.
 * User: jopsen
 * Date: 11-02-2007
 * Time: 14:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace WinFormsClient
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.PersonalButton = new System.Windows.Forms.Button();
			this.TagButton = new System.Windows.Forms.Button();
			this.PlaylistButton = new System.Windows.Forms.Button();
			this.ArtistButton = new System.Windows.Forms.Button();
			this.HateButton = new System.Windows.Forms.Button();
			this.LoveButton = new System.Windows.Forms.Button();
			this.SkipButton = new System.Windows.Forms.Button();
			this.TuneInButton = new System.Windows.Forms.Button();
			this.RadioStationCb = new System.Windows.Forms.ComboBox();
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.generatePlaylistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.legalIssuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.onlineHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.StationLabel = new System.Windows.Forms.Label();
			this.DurationLabel = new System.Windows.Forms.Label();
			this.AlbumLabel = new System.Windows.Forms.Label();
			this.ArtistLabel = new System.Windows.Forms.Label();
			this.TrackLabel = new System.Windows.Forms.Label();
			this.StatuspictureBox = new System.Windows.Forms.PictureBox();
			this.StatusBar = new System.Windows.Forms.ProgressBar();
			this.RadioElementCb = new System.Windows.Forms.ComboBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.NeighbourhoodButton = new System.Windows.Forms.Button();
			this.RecommendationsButton = new System.Windows.Forms.Button();
			this.GroupButton = new System.Windows.Forms.Button();
			this.LovedButton = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.MainMenu.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.StatuspictureBox)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// PersonalButton
			// 
			this.PersonalButton.Location = new System.Drawing.Point(6, 62);
			this.PersonalButton.Name = "PersonalButton";
			this.PersonalButton.Size = new System.Drawing.Size(60, 23);
			this.PersonalButton.TabIndex = 8;
			this.PersonalButton.Text = "Personal";
			this.PersonalButton.UseVisualStyleBackColor = true;
			this.PersonalButton.Click += new System.EventHandler(this.PersonalButtonClick);
			// 
			// TagButton
			// 
			this.TagButton.Location = new System.Drawing.Point(72, 33);
			this.TagButton.Name = "TagButton";
			this.TagButton.Size = new System.Drawing.Size(60, 23);
			this.TagButton.TabIndex = 7;
			this.TagButton.Text = "Tag";
			this.TagButton.UseVisualStyleBackColor = true;
			this.TagButton.Click += new System.EventHandler(this.TagButtonClick);
			// 
			// PlaylistButton
			// 
			this.PlaylistButton.Location = new System.Drawing.Point(72, 62);
			this.PlaylistButton.Name = "PlaylistButton";
			this.PlaylistButton.Size = new System.Drawing.Size(60, 23);
			this.PlaylistButton.TabIndex = 6;
			this.PlaylistButton.Text = "Playlist";
			this.PlaylistButton.UseVisualStyleBackColor = true;
			this.PlaylistButton.Click += new System.EventHandler(this.PlaylistButtonClick);
			// 
			// ArtistButton
			// 
			this.ArtistButton.Location = new System.Drawing.Point(6, 33);
			this.ArtistButton.Name = "ArtistButton";
			this.ArtistButton.Size = new System.Drawing.Size(60, 23);
			this.ArtistButton.TabIndex = 4;
			this.ArtistButton.Text = "Artist";
			this.ArtistButton.UseVisualStyleBackColor = true;
			this.ArtistButton.Click += new System.EventHandler(this.ArtistButtonClick);
			// 
			// HateButton
			// 
			this.HateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.HateButton.Enabled = false;
			this.HateButton.Location = new System.Drawing.Point(168, 190);
			this.HateButton.Name = "HateButton";
			this.HateButton.Size = new System.Drawing.Size(75, 23);
			this.HateButton.TabIndex = 0;
			this.HateButton.Text = "H&ate";
			this.HateButton.UseVisualStyleBackColor = true;
			this.HateButton.Click += new System.EventHandler(this.HateButtonClick);
			// 
			// LoveButton
			// 
			this.LoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.LoveButton.Enabled = false;
			this.LoveButton.Location = new System.Drawing.Point(87, 190);
			this.LoveButton.Name = "LoveButton";
			this.LoveButton.Size = new System.Drawing.Size(75, 23);
			this.LoveButton.TabIndex = 0;
			this.LoveButton.Text = "&Love";
			this.LoveButton.UseVisualStyleBackColor = true;
			this.LoveButton.Click += new System.EventHandler(this.LoveButtonClick);
			// 
			// SkipButton
			// 
			this.SkipButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.SkipButton.Enabled = false;
			this.SkipButton.Location = new System.Drawing.Point(6, 190);
			this.SkipButton.Name = "SkipButton";
			this.SkipButton.Size = new System.Drawing.Size(75, 23);
			this.SkipButton.TabIndex = 0;
			this.SkipButton.Text = "&Skip";
			this.SkipButton.UseVisualStyleBackColor = true;
			this.SkipButton.Click += new System.EventHandler(this.SkipButtonClick);
			// 
			// TuneInButton
			// 
			this.TuneInButton.Enabled = false;
			this.TuneInButton.Location = new System.Drawing.Point(6, 33);
			this.TuneInButton.Name = "TuneInButton";
			this.TuneInButton.Size = new System.Drawing.Size(75, 23);
			this.TuneInButton.TabIndex = 2;
			this.TuneInButton.Text = "&Tune in";
			this.TuneInButton.UseVisualStyleBackColor = true;
			this.TuneInButton.Click += new System.EventHandler(this.TuneInButtonClick);
			// 
			// RadioStationCb
			// 
			this.RadioStationCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.RadioStationCb.Enabled = false;
			this.RadioStationCb.FormattingEnabled = true;
			this.RadioStationCb.Items.AddRange(new object[] {
									"lastfm://globaltags/rock",
									"lastfm://globaltags/indie",
									"lastfm://globaltags/alternative",
									"lastfm://globaltags/seen%20live",
									"lastfm://globaltags/metal",
									"lastfm://globaltags/electronic",
									"lastfm://globaltags/pop",
									"lastfm://globaltags/punk",
									"lastfm://globaltags/indie%20rock",
									"lastfm://globaltags/classic%20rock"});
			this.RadioStationCb.Location = new System.Drawing.Point(6, 6);
			this.RadioStationCb.Name = "RadioStationCb";
			this.RadioStationCb.Size = new System.Drawing.Size(318, 21);
			this.RadioStationCb.TabIndex = 1;
			// 
			// MainMenu
			// 
			this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.MainMenu.Location = new System.Drawing.Point(0, 0);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Size = new System.Drawing.Size(362, 24);
			this.MainMenu.TabIndex = 1;
			this.MainMenu.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.settingsToolStripMenuItem,
									this.generatePlaylistsToolStripMenuItem,
									this.toolStripSeparator2,
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.settingsToolStripMenuItem.Text = "&Settings";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItemClick);
			// 
			// generatePlaylistsToolStripMenuItem
			// 
			this.generatePlaylistsToolStripMenuItem.Name = "generatePlaylistsToolStripMenuItem";
			this.generatePlaylistsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.generatePlaylistsToolStripMenuItem.Text = "&Generate playlists";
			this.generatePlaylistsToolStripMenuItem.Click += new System.EventHandler(this.GeneratePlaylistsToolStripMenuItemClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.legalIssuesToolStripMenuItem,
									this.onlineHelpToolStripMenuItem,
									this.toolStripSeparator1,
									this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// legalIssuesToolStripMenuItem
			// 
			this.legalIssuesToolStripMenuItem.Name = "legalIssuesToolStripMenuItem";
			this.legalIssuesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.legalIssuesToolStripMenuItem.Text = "&Legal issues";
			this.legalIssuesToolStripMenuItem.Click += new System.EventHandler(this.LegalIssuesToolStripMenuItemClick);
			// 
			// onlineHelpToolStripMenuItem
			// 
			this.onlineHelpToolStripMenuItem.Name = "onlineHelpToolStripMenuItem";
			this.onlineHelpToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.onlineHelpToolStripMenuItem.Text = "Online &Help";
			this.onlineHelpToolStripMenuItem.Click += new System.EventHandler(this.OnlineHelpToolStripMenuItemClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(128, 6);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.aboutToolStripMenuItem.Text = "&About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.StationLabel);
			this.groupBox2.Controls.Add(this.DurationLabel);
			this.groupBox2.Controls.Add(this.AlbumLabel);
			this.groupBox2.Controls.Add(this.ArtistLabel);
			this.groupBox2.Controls.Add(this.TrackLabel);
			this.groupBox2.Controls.Add(this.StatuspictureBox);
			this.groupBox2.Controls.Add(this.HateButton);
			this.groupBox2.Controls.Add(this.LoveButton);
			this.groupBox2.Controls.Add(this.StatusBar);
			this.groupBox2.Controls.Add(this.SkipButton);
			this.groupBox2.Location = new System.Drawing.Point(12, 153);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(338, 219);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Currently recording";
			// 
			// StationLabel
			// 
			this.StationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.StationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StationLabel.Location = new System.Drawing.Point(6, 135);
			this.StationLabel.Name = "StationLabel";
			this.StationLabel.Size = new System.Drawing.Size(180, 23);
			this.StationLabel.TabIndex = 6;
			this.StationLabel.Text = "Station: ";
			// 
			// DurationLabel
			// 
			this.DurationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.DurationLabel.Location = new System.Drawing.Point(6, 112);
			this.DurationLabel.Name = "DurationLabel";
			this.DurationLabel.Size = new System.Drawing.Size(180, 23);
			this.DurationLabel.TabIndex = 5;
			this.DurationLabel.Text = "Duration: ";
			// 
			// AlbumLabel
			// 
			this.AlbumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.AlbumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AlbumLabel.Location = new System.Drawing.Point(6, 89);
			this.AlbumLabel.Name = "AlbumLabel";
			this.AlbumLabel.Size = new System.Drawing.Size(180, 23);
			this.AlbumLabel.TabIndex = 4;
			this.AlbumLabel.Text = "Album: ";
			// 
			// ArtistLabel
			// 
			this.ArtistLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.ArtistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ArtistLabel.Location = new System.Drawing.Point(6, 66);
			this.ArtistLabel.Name = "ArtistLabel";
			this.ArtistLabel.Size = new System.Drawing.Size(180, 23);
			this.ArtistLabel.TabIndex = 3;
			this.ArtistLabel.Text = "Artist: ";
			// 
			// TrackLabel
			// 
			this.TrackLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.TrackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TrackLabel.Location = new System.Drawing.Point(6, 19);
			this.TrackLabel.Name = "TrackLabel";
			this.TrackLabel.Size = new System.Drawing.Size(180, 47);
			this.TrackLabel.TabIndex = 2;
			this.TrackLabel.Text = "Not recording...";
			// 
			// StatuspictureBox
			// 
			this.StatuspictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.StatuspictureBox.Location = new System.Drawing.Point(192, 15);
			this.StatuspictureBox.Name = "StatuspictureBox";
			this.StatuspictureBox.Size = new System.Drawing.Size(140, 140);
			this.StatuspictureBox.TabIndex = 1;
			this.StatuspictureBox.TabStop = false;
			// 
			// StatusBar
			// 
			this.StatusBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.StatusBar.Location = new System.Drawing.Point(6, 161);
			this.StatusBar.Name = "StatusBar";
			this.StatusBar.Size = new System.Drawing.Size(326, 23);
			this.StatusBar.TabIndex = 0;
			// 
			// RadioElementCb
			// 
			this.RadioElementCb.FormattingEnabled = true;
			this.RadioElementCb.Location = new System.Drawing.Point(6, 6);
			this.RadioElementCb.Name = "RadioElementCb";
			this.RadioElementCb.Size = new System.Drawing.Size(318, 21);
			this.RadioElementCb.TabIndex = 3;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 27);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(338, 120);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.NeighbourhoodButton);
			this.tabPage1.Controls.Add(this.RecommendationsButton);
			this.tabPage1.Controls.Add(this.GroupButton);
			this.tabPage1.Controls.Add(this.LovedButton);
			this.tabPage1.Controls.Add(this.TagButton);
			this.tabPage1.Controls.Add(this.PersonalButton);
			this.tabPage1.Controls.Add(this.RadioElementCb);
			this.tabPage1.Controls.Add(this.PlaylistButton);
			this.tabPage1.Controls.Add(this.ArtistButton);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(330, 94);
			this.tabPage1.TabIndex = 1;
			this.tabPage1.Text = "Find Music";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// NeighbourhoodButton
			// 
			this.NeighbourhoodButton.Location = new System.Drawing.Point(221, 33);
			this.NeighbourhoodButton.Name = "NeighbourhoodButton";
			this.NeighbourhoodButton.Size = new System.Drawing.Size(103, 23);
			this.NeighbourhoodButton.TabIndex = 12;
			this.NeighbourhoodButton.Text = "Neighbourhood";
			this.NeighbourhoodButton.UseVisualStyleBackColor = true;
			this.NeighbourhoodButton.Click += new System.EventHandler(this.NeighbourhoodButtonClick);
			// 
			// RecommendationsButton
			// 
			this.RecommendationsButton.Location = new System.Drawing.Point(221, 62);
			this.RecommendationsButton.Name = "RecommendationsButton";
			this.RecommendationsButton.Size = new System.Drawing.Size(103, 23);
			this.RecommendationsButton.TabIndex = 11;
			this.RecommendationsButton.Text = "Recommendations";
			this.RecommendationsButton.UseVisualStyleBackColor = true;
			this.RecommendationsButton.Click += new System.EventHandler(this.RecommendationsButtonClick);
			// 
			// GroupButton
			// 
			this.GroupButton.Location = new System.Drawing.Point(138, 33);
			this.GroupButton.Name = "GroupButton";
			this.GroupButton.Size = new System.Drawing.Size(60, 23);
			this.GroupButton.TabIndex = 10;
			this.GroupButton.Text = "Group";
			this.GroupButton.UseVisualStyleBackColor = true;
			this.GroupButton.Click += new System.EventHandler(this.GroupButtonClick);
			// 
			// LovedButton
			// 
			this.LovedButton.Location = new System.Drawing.Point(138, 62);
			this.LovedButton.Name = "LovedButton";
			this.LovedButton.Size = new System.Drawing.Size(60, 23);
			this.LovedButton.TabIndex = 9;
			this.LovedButton.Text = "Loved";
			this.LovedButton.UseVisualStyleBackColor = true;
			this.LovedButton.Click += new System.EventHandler(this.LovedButtonClick);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.RadioStationCb);
			this.tabPage2.Controls.Add(this.TuneInButton);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(330, 94);
			this.tabPage2.TabIndex = 0;
			this.tabPage2.Text = "URL";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(362, 380);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.MainMenu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.MainMenu;
			this.MinimumSize = new System.Drawing.Size(370, 350);
			this.Name = "MainForm";
			this.Text = "TheLastRipper";
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.StatuspictureBox)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button RecommendationsButton;
		private System.Windows.Forms.Button NeighbourhoodButton;
		private System.Windows.Forms.Button GroupButton;
		private System.Windows.Forms.Button LovedButton;
		private System.Windows.Forms.Button PlaylistButton;
		private System.Windows.Forms.Button PersonalButton;
		private System.Windows.Forms.ComboBox RadioStationCb;
		private System.Windows.Forms.ComboBox RadioElementCb;
		private System.Windows.Forms.Button TagButton;
		private System.Windows.Forms.Button ArtistButton;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Label DurationLabel;
		private System.Windows.Forms.Label StationLabel;
		private System.Windows.Forms.Label TrackLabel;
		private System.Windows.Forms.Label ArtistLabel;
		private System.Windows.Forms.Label AlbumLabel;
		private System.Windows.Forms.MenuStrip MainMenu;
		private System.Windows.Forms.Button HateButton;
		private System.Windows.Forms.Button LoveButton;
		private System.Windows.Forms.Button SkipButton;
		private System.Windows.Forms.Button TuneInButton;
		private System.Windows.Forms.PictureBox StatuspictureBox;
		private System.Windows.Forms.ProgressBar StatusBar;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem onlineHelpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem legalIssuesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem generatePlaylistsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}
