﻿namespace V2RayGCon.Views
{
    partial class FormOption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOption));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageImport = new System.Windows.Forms.TabPage();
            this.btnImportAdd = new System.Windows.Forms.Button();
            this.flyImportPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageSubscribe = new System.Windows.Forms.TabPage();
            this.btnUpdateViaSubscription = new System.Windows.Forms.Button();
            this.btnAddSubsUrl = new System.Windows.Forms.Button();
            this.flySubsUrlContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBakBackup = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnOptionSave = new System.Windows.Forms.Button();
            this.btnBakRestore = new System.Windows.Forms.Button();
            this.btnOptionExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageImport.SuspendLayout();
            this.tabPageSubscribe.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPageImport);
            this.tabControl1.Controls.Add(this.tabPageSubscribe);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPageImport
            // 
            this.tabPageImport.Controls.Add(this.btnImportAdd);
            this.tabPageImport.Controls.Add(this.flyImportPanel);
            resources.ApplyResources(this.tabPageImport, "tabPageImport");
            this.tabPageImport.Name = "tabPageImport";
            this.tabPageImport.UseVisualStyleBackColor = true;
            // 
            // btnImportAdd
            // 
            resources.ApplyResources(this.btnImportAdd, "btnImportAdd");
            this.btnImportAdd.Name = "btnImportAdd";
            this.toolTip1.SetToolTip(this.btnImportAdd, resources.GetString("btnImportAdd.ToolTip"));
            this.btnImportAdd.UseVisualStyleBackColor = true;
            // 
            // flyImportPanel
            // 
            this.flyImportPanel.AllowDrop = true;
            resources.ApplyResources(this.flyImportPanel, "flyImportPanel");
            this.flyImportPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flyImportPanel.Name = "flyImportPanel";
            // 
            // tabPageSubscribe
            // 
            this.tabPageSubscribe.Controls.Add(this.btnUpdateViaSubscription);
            this.tabPageSubscribe.Controls.Add(this.btnAddSubsUrl);
            this.tabPageSubscribe.Controls.Add(this.flySubsUrlContainer);
            resources.ApplyResources(this.tabPageSubscribe, "tabPageSubscribe");
            this.tabPageSubscribe.Name = "tabPageSubscribe";
            this.tabPageSubscribe.UseVisualStyleBackColor = true;
            // 
            // btnUpdateViaSubscription
            // 
            resources.ApplyResources(this.btnUpdateViaSubscription, "btnUpdateViaSubscription");
            this.btnUpdateViaSubscription.Name = "btnUpdateViaSubscription";
            this.toolTip1.SetToolTip(this.btnUpdateViaSubscription, resources.GetString("btnUpdateViaSubscription.ToolTip"));
            this.btnUpdateViaSubscription.UseVisualStyleBackColor = true;
            // 
            // btnAddSubsUrl
            // 
            resources.ApplyResources(this.btnAddSubsUrl, "btnAddSubsUrl");
            this.btnAddSubsUrl.Name = "btnAddSubsUrl";
            this.toolTip1.SetToolTip(this.btnAddSubsUrl, resources.GetString("btnAddSubsUrl.ToolTip"));
            this.btnAddSubsUrl.UseVisualStyleBackColor = true;
            // 
            // flySubsUrlContainer
            // 
            this.flySubsUrlContainer.AllowDrop = true;
            resources.ApplyResources(this.flySubsUrlContainer, "flySubsUrlContainer");
            this.flySubsUrlContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flySubsUrlContainer.Name = "flySubsUrlContainer";
            // 
            // btnBakBackup
            // 
            resources.ApplyResources(this.btnBakBackup, "btnBakBackup");
            this.btnBakBackup.Name = "btnBakBackup";
            this.toolTip1.SetToolTip(this.btnBakBackup, resources.GetString("btnBakBackup.ToolTip"));
            this.btnBakBackup.UseVisualStyleBackColor = true;
            this.btnBakBackup.Click += new System.EventHandler(this.btnBakBackup_Click);
            // 
            // btnOptionSave
            // 
            resources.ApplyResources(this.btnOptionSave, "btnOptionSave");
            this.btnOptionSave.Name = "btnOptionSave";
            this.toolTip1.SetToolTip(this.btnOptionSave, resources.GetString("btnOptionSave.ToolTip"));
            this.btnOptionSave.UseVisualStyleBackColor = true;
            this.btnOptionSave.Click += new System.EventHandler(this.btnOptionSave_Click);
            // 
            // btnBakRestore
            // 
            resources.ApplyResources(this.btnBakRestore, "btnBakRestore");
            this.btnBakRestore.Name = "btnBakRestore";
            this.toolTip1.SetToolTip(this.btnBakRestore, resources.GetString("btnBakRestore.ToolTip"));
            this.btnBakRestore.UseVisualStyleBackColor = true;
            this.btnBakRestore.Click += new System.EventHandler(this.btnBakRestore_Click);
            // 
            // btnOptionExit
            // 
            resources.ApplyResources(this.btnOptionExit, "btnOptionExit");
            this.btnOptionExit.Name = "btnOptionExit";
            this.btnOptionExit.UseVisualStyleBackColor = true;
            this.btnOptionExit.Click += new System.EventHandler(this.btnOptionExit_Click);
            // 
            // FormOption
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBakRestore);
            this.Controls.Add(this.btnBakBackup);
            this.Controls.Add(this.btnOptionExit);
            this.Controls.Add(this.btnOptionSave);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormOption";
            this.Shown += new System.EventHandler(this.FormOption_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPageImport.ResumeLayout(false);
            this.tabPageSubscribe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSubscribe;
        private System.Windows.Forms.FlowLayoutPanel flySubsUrlContainer;
        private System.Windows.Forms.Button btnAddSubsUrl;
        private System.Windows.Forms.Button btnUpdateViaSubscription;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnOptionSave;
        private System.Windows.Forms.Button btnOptionExit;
        private System.Windows.Forms.TabPage tabPageImport;
        private System.Windows.Forms.Button btnImportAdd;
        private System.Windows.Forms.FlowLayoutPanel flyImportPanel;
        private System.Windows.Forms.Button btnBakBackup;
        private System.Windows.Forms.Button btnBakRestore;
    }
}
