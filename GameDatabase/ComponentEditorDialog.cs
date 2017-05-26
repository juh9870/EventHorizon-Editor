﻿using System;
using System.Windows.Forms;
using GameDatabase.EditorModel;

namespace GameDatabase
{
    public partial class ComponentEditorDialog : Form
    {
        public ComponentEditorDialog(Database database, Component component)
        {
            _component = component;
            _database = database;
            
            InitializeComponent();
        }

        private void ComponentEditorDialog_Load(object sender, EventArgs e)
        {
            Text = _component.ItemId.Name;
            structDataEditor1.Database = _database;
            structDataEditor1.Data = _component;
        }

        private readonly Component _component;
        private readonly Database _database;
    }
}
